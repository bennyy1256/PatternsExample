using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    /// <summary>
    /// 三孔插座 (要符合的目標)
    /// </summary>
    /// <seealso cref="AdapterPattern.Models.Socket" />
    public class ThreeHoleSocket : Socket
    {
        /// <summary>
        /// 供電.
        /// </summary>
        /// <returns></returns>
        public override string Supply()
        {
            return "三孔插座供給電力";
        }

    }
}
