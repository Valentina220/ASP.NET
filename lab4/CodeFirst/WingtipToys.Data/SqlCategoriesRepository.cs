using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingtipToys.Data
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        public Category Create(Category category)
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                var added = ctx.Categories.Add(category);
                ctx.SaveChanges();
                return added;
            }

        }

        public bool Delete(int categoryId)
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                var existing = ctx.Categories.SingleOrDefault(x => x.CategoryID == categoryId);
                if (existing == null)
                {
                    return false;
                }
                ctx.Categories.Remove(existing);
                ctx.SaveChanges();
                return true;
            }

        }

        public Category Get(string categoryName)
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                return ctx.Categories.SingleOrDefault(x => x.CategoryName.Equals(categoryName, StringComparison.InvariantCultureIgnoreCase));
            }

        }

        public Category Get(int categoryId)
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                return ctx.Categories.SingleOrDefault(x => x.CategoryID == categoryId);
            }

        }

        public IEnumerable<Category> GetAll()
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                return ctx.Categories.ToList();
            }

        }

        public Category Update(Category category)
        {
            //throw new NotImplementedException();
            using (var ctx = new WingtipToysEntities())
            {
                var existing = ctx.Categories.SingleOrDefault(x => x.CategoryID == category.CategoryID);
                if (existing == null)
                {
                    return null;
                }
                existing.Description = category.Description;
                existing.CategoryName = category.CategoryName;
                ctx.SaveChanges();
                return existing;
            }

        }
    }

}
