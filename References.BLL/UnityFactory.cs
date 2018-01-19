using Microsoft.Practices.Unity;
using POS.BLL.InventoryControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL
{
    public class UnityFactory:IDisposable
    {
        IUnityContainer container;
        public UnityFactory()
        {
            container = new UnityContainer();
        }

        public IItemsBLC CreateItemObject()
        {
            container.RegisterType(typeof(IItemsBLC), typeof(ItemBLC));
            IItemsBLC obj = container.Resolve<IItemsBLC>();
            return obj;
        }

        public ICategoryBL CreateCategoryObject()
        {
            container.RegisterType(typeof(ICategoryBL), typeof(CategoryBLC));
            ICategoryBL obj = container.Resolve<ICategoryBL>();
            return obj;
        }

        public void Dispose()
        {
            container.Dispose();
            //throw new NotImplementedException();
        }
    }
}
