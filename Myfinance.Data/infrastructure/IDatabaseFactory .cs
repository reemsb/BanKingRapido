using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteData.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        CompteContexte DataContext { get; }
    }

}
