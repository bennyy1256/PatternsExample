using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public abstract class DBConnectFactory
    {
        public abstract IDBConnection CreateDBConnectFactory();
    }
}
