using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain.DomainClasses;
using POS.DAL;

namespace POS.BLL
{
    public class ItemBLC : IItemsBLC
    {
        UnitOfWork unitOfWork;
        public ItemBLC()
        {
            unitOfWork = new UnitOfWork(new Domain.POSContext());
        }
        /// <summary>
        /// Get list of Items
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> ItemList()
        {
           return unitOfWork.GetRepository<Item>().List;
        }
        /// <summary>
        /// Add an Item
        /// </summary>
        /// <param name="item"></param>
        public void Add(Item item)
        {
            unitOfWork.GetRepository<Item>().Add(item);
            unitOfWork.Commit();
        }
        /// <summary>
        /// Update Existing Item
        /// </summary>
        /// <param name="item"></param>
        public void Update(Item item)
        {
            unitOfWork.GetRepository<Item>().Update(item);
            unitOfWork.Commit();
        }
        /// <summary>
        /// Delete Item
        /// </summary>
        /// <param name="item"></param>
        public void Delete(Item item)
        {
            unitOfWork.GetRepository<Item>().Delete(item);
            unitOfWork.Commit();
        }
        /// <summary>
        /// Get single item
        /// </summary>
        /// <param name="ItemCode"></param>
        /// <returns></returns>
        public Item GetItemByID(int ItemCode)
        {
           return unitOfWork.GetRepository<Item>().FirstOrDefalult(ItemCode);
        }

        public int GetItemID(string itemName)
        {
            //var items = from l in this.ListNew.Where(c => c.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase)) select l;
            var item = from l in unitOfWork.GetRepository<Item>().List
                       .Where(c => c.itemName.Contains(itemName))
                       select l.itemId;


            return int.Parse(item.FirstOrDefault().ToString());
        }
    }
}
