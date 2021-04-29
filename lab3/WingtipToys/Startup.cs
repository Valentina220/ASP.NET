using Microsoft.Owin;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(WingtipToys.Startup))]
namespace WingtipToys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
        }
    }

    //public IQueryable<Product> GetProduct([RouteData("productId")] int? productId)
    //{
    //    if (!productId.HasValue || productId.Value == 0)
    //    {
    //        return null;
    //    }
    //    return new List<Product>(1) { _service.GetProduct(productId.Value) }.AsQueryable();
    //}

}
