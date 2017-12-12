using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Domain.Entities
{
    public class Plongeur : Personne
    {
        public string Licence { get; set; }
        public virtual ICollection<SeancePlongee> seancesPlongs { get; set; }

    }
}
