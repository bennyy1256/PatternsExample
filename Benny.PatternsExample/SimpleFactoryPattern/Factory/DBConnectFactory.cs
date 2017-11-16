using SimpleFactoryPattern.Enums;
using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Factory
{
    public class DBConnectFactory
    {
        public IDBConnection GetConnection(ConnectionEnum value)
        {
            IDBConnection result = null;
            switch(value)
            {
                case ConnectionEnum.MSSQL:
                    result = new MSSQLConnection();
                    break;
                case ConnectionEnum.Oracle:
                    result = new OracleConnection();
                    break;
            }

            return result;
        }
    }
}
