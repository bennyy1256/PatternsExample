using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public abstract class Connector : IConnector
    {
        /// <summary>
        /// 取電.
        /// </summary>
        public virtual string Take()
        {
            return "取得電力";
        }
    }
}
