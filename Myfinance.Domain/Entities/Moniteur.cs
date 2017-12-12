using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Domain.Entities
{
    public class Moniteur : Personne
    {
        public DateTime DateEmbauche { get; set; }
        public int AnneeExperience { get; set; }
        public virtual ICollection<SeancePlongee> seancesPlongscours { get; set; }

    }
}
