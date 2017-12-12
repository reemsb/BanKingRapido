using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteData.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private CompteContexte dataContext;
        public CompteContexte DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new CompteContexte();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
