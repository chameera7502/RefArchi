using POS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.InventoryControl
{
    public interface ICategoryBL
    {
        IEnumerable<Category> CategoryList();
        void Add(Category item);
        void Update(Category item);
        void Delete(Category item);
        Category GetCategoryByID(int categoryID);
    }
}
