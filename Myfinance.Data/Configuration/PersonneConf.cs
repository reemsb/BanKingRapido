using Myfinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data.Configuration
{
    public class PersonneConf : EntityTypeConfiguration<Personne>
    { 
        public PersonneConf()
        {
            Map<Moniteur>(c =>
            {
                c.Requires("Type").HasValue("M");
            });
            Map<Personne>(c =>
            {
                c.Requires("Type").HasValue("P");
            });
            
    }

}

    }

