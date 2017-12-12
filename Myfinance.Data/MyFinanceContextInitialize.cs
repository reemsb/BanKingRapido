using Myfinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data
{
    class MyFinanceContextInitialize : DropCreateDatabaseIfModelChanges<MyFinanceContext>
    {

        protected override void Seed(MyFinanceContext context)
        {
            /*  var listCategories = new List<Category>{
                  new Category{Name="Medicament" },
                  new Category{Name="Vetement" },
                  new Category{Name="Meuble" },
              };

              context.Categories.AddRange(listCategories);
              context.SaveChanges();
          }*/

        }
    }
}
