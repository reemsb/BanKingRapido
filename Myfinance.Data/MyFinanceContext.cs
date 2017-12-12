using Myfinance.Data;
using Myfinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data
{
  public  class MyFinanceContext : DbContext
    {
        
    
        public MyFinanceContext()
            : base("Name=DefaultCon")
        {
          //  Database.SetInitializer<MyFinanceContext>(new MyFinanceContextInitialize());
        }

        public DbSet<SeancePlongee> Seances { get; set; }
        public DbSet<Personne> Personnes { get; set; }
    }

}

