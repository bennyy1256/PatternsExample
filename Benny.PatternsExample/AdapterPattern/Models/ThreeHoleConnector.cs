using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    /// <summary>
    /// 三孔插頭
    /// </summary>
    /// <seealso cref="AdapterPattern.Models.Connector" />
    public class ThreeHoleConnector : Connector
    {
        public string Features
        {
            get
            {
                return "三孔插頭";
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
