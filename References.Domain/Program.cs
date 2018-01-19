using POS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new POSContext())
            {
                Category cat = new Category() { CategoryName = "New Student" };

                ctx.Category.Add(cat);
                ctx.SaveChanges();
            }
        }
        /*To Affect the changes you did in the model 
         * Run Update-Database -verbose command on PM after setting POS.Domain As start up program*/
    }
}
