namespace POS.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CatID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        itemId = c.Int(nullable: false, identity: true),
                        itemName = c.String(),
                        ROL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        salesPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        purchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        category_CatID = c.Int(),
                    })
                .PrimaryKey(t => t.itemId)
                .ForeignKey("dbo.Categories", t => t.category_CatID)
                .Index(t => t.category_CatID);
            
            CreateTable(
                "dbo.CustomerMasters",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        contactNumber = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
            CreateTable(
                "dbo.DebtorPayments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        paidDate = c.DateTime(nullable: false),
                        paidAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debtor_id = c.Int(),
                        CustomerMaster_customerID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Debtors", t => t.Debtor_id)
                .ForeignKey("dbo.CustomerMasters", t => t.CustomerMaster_customerID)
                .Index(t => t.Debtor_id)
                .Index(t => t.CustomerMaster_customerID);
            
            CreateTable(
                "dbo.Debtors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DebitDate = c.DateTime(nullable: false),
                        debitAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isPaid = c.Boolean(nullable: false),
                        Customer_customerID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CustomerMasters", t => t.Customer_customerID)
                .Index(t => t.Customer_customerID);
            
            CreateTable(
                "dbo.GRNDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        itemID = c.Int(nullable: false),
                        qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        lineDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        grnHeader_GRNId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GRNHeaders", t => t.grnHeader_GRNId)
                .Index(t => t.grnHeader_GRNId);
            
            CreateTable(
                "dbo.GRNHeaders",
                c => new
                    {
                        GRNId = c.Int(nullable: false, identity: true),
                        GRNNumber = c.String(),
                        GRNDate = c.DateTime(nullable: false),
                        narration = c.String(),
                    })
                .PrimaryKey(t => t.GRNId);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        itemId = c.Int(nullable: false),
                        qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        lineDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        invoiceHeader_invoiceID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.InvoiceHeaders", t => t.invoiceHeader_invoiceID)
                .Index(t => t.invoiceHeader_invoiceID);
            
            CreateTable(
                "dbo.InvoiceHeaders",
                c => new
                    {
                        invoiceID = c.Int(nullable: false, identity: true),
                        invoiceCode = c.String(),
                        invoiceDate = c.DateTime(nullable: false),
                        narration = c.String(),
                    })
                .PrimaryKey(t => t.invoiceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "invoiceHeader_invoiceID", "dbo.InvoiceHeaders");
            DropForeignKey("dbo.GRNDetails", "grnHeader_GRNId", "dbo.GRNHeaders");
            DropForeignKey("dbo.DebtorPayments", "CustomerMaster_customerID", "dbo.CustomerMasters");
            DropForeignKey("dbo.DebtorPayments", "Debtor_id", "dbo.Debtors");
            DropForeignKey("dbo.Debtors", "Customer_customerID", "dbo.CustomerMasters");
            DropForeignKey("dbo.Items", "category_CatID", "dbo.Categories");
            DropIndex("dbo.InvoiceDetails", new[] { "invoiceHeader_invoiceID" });
            DropIndex("dbo.GRNDetails", new[] { "grnHeader_GRNId" });
            DropIndex("dbo.Debtors", new[] { "Customer_customerID" });
            DropIndex("dbo.DebtorPayments", new[] { "CustomerMaster_customerID" });
            DropIndex("dbo.DebtorPayments", new[] { "Debtor_id" });
            DropIndex("dbo.Items", new[] { "category_CatID" });
            DropTable("dbo.InvoiceHeaders");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.GRNHeaders");
            DropTable("dbo.GRNDetails");
            DropTable("dbo.Debtors");
            DropTable("dbo.DebtorPayments");
            DropTable("dbo.CustomerMasters");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
