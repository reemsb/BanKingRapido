using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Domain.Entities
{
    public class Personne
    {    [Key]
        public string ID { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateNaissance { get; set; }
        public Address Address { get; set; }


    }
}
