using POS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL
{
    public interface IItemsBLC
    {
        IEnumerable<Item> ItemList();
        void Add(Item item);
        void Update(Item item);
        void Delete(Item item);
        Item GetItemByID(int ItemCode);
        int GetItemID(string itemName);
    }
}
