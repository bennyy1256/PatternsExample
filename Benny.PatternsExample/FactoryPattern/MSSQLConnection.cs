using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MSSQLConnection : IDBConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("建立MSSQL連線...");
        }
    }
}
