using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Business;
using WingtipToys.Data;
using WingtipToys.Data.Models;

namespace WingtipToys
{
    public partial class ProductCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static readonly IStoreService _service = new StoreService(new InMemoryProductRepository(), new InMemoryCategoryRepository());
        public IQueryable<Category> GetCategories()
        {
            return _service.GetAllCategories().AsQueryable();
        }

        protected void ButtonProduct_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var product = new Product
                {
                    ProductName = ProdName.Text,
                    Description = Description.Value
                };
                var created = _service.CreateProduct(product);
                MesageCategoryName.Text = created.ProductName;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (IsPostBack && IsValid)
            {
                CreateProductForm.Visible = false;
                SuccessBlock.Visible = true;
            }
        }
    }
}