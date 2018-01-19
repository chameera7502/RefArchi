using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain.DomainClasses;
using POS.DAL;

namespace POS.BLL.InventoryControl
{
    public class CategoryBLC : ICategoryBL
    {
        UnitOfWork unitOfWork;
        public CategoryBLC()
        {
            unitOfWork = new UnitOfWork(new Domain.POSContext());
        }
        public void Add(Category item)
        {
            unitOfWork.GetRepository<Category>().Add(item);
            unitOfWork.Commit();
        }

        public IEnumerable<Category> CategoryList()
        {
           return unitOfWork.GetRepository<Category>().List;
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryByID(int categoryID)
        {
            return unitOfWork.GetRepository<Category>().FirstOrDefalult(categoryID);
        }

        public void Update(Category item)
        {
            unitOfWork.GetRepository<Category>().Update(item);
            unitOfWork.Commit();
        }
    }
}
