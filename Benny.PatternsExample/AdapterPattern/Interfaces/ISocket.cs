using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    public interface ISocket
    {
        /// <summary>
        /// 供電.
        /// </summary>
        string Supply();
    }
}
