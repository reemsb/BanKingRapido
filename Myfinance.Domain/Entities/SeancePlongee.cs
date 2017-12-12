using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Domain.Entities
{
    public enum Niveau { Debutant, Interlerdiaire, Expert }

    public class SeancePlongee
    {    [Key]
        public int SeanceId { get; set; }
        public Niveau Niveau { get; set; }
        [Range(0,float.MaxValue)]
        public float PrixParHeures { get; set; }
        public float Profondeur { get; set; }
        public int? MoniteurId { get; set; }
        public virtual Moniteur moniteur { get; set; }
        public virtual ICollection<Plongeur> plongeurs { get; set; }

    }
}
