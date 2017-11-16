using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class OracleConnection : IDBConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("建立Oracle連線...");
        }
    }
}
