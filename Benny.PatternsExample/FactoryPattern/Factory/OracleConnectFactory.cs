using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public class OracleConnectFactory : DBConnectFactory
    {
        public override Interfaces.IDBConnection CreateDBConnectFactory()
        {
            return new OracleConnection();
        }
    }
}
