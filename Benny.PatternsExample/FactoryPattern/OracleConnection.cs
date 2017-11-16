﻿using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class OracleConnection : IDBConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("建立Oracle連線...");
        }
    }
}
