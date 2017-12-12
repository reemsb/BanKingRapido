using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Domain.Entities
{
    public class Address
    {
        public string ville { get; set; }
        public string rue { get; set; }
        public string codePostal { get; set; }
    }
}
