using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public class MYSQLConnectFactory : DBConnectFactory
    {
        public override Interfaces.IDBConnection CreateDBConnectFactory()
        {
            return new MYSQLConnection();
        }
    }
}
