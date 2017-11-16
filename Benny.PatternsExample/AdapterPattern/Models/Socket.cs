using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public abstract class Socket : ISocket
    {
        /// <summary>
        /// 供電.
        /// </summary>
        public virtual string Supply()
        {
            return "提供電力";
        }
    }
}
