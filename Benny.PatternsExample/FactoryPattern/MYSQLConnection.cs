using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MYSQLConnection : IDBConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("建立MYSQL連線...");
        }
    }
}
