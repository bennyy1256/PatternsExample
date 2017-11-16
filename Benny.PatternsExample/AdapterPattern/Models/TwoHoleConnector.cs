using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    /// <summary>
    /// 兩孔插頭
    /// </summary>
    /// <seealso cref="AdapterPattern.Models.Connector" />
    public class TwoHoleConnector : Connector
    {
        public string Features
        {
            get
            {
                return "兩孔插頭";
            }
        }

        /// <summary>
        /// 取電.
        /// </summary>
        public override string Take()
        {
            return this.Features + base.Take();
        }

    }
}
