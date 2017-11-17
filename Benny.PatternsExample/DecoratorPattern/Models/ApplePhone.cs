using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    /// <summary>
    /// Apple 手機類別，即裝飾者模式中的具體類別
    /// </summary>
    /// <seealso cref="DecoratorPattern.Models.Phone" />
    public class ApplePhone : Phone
    {
        public override string Print()
        {
            return "實體iPhone";
        }

        /// <summary>
        /// 售價.
        /// </summary>
        /// <returns></returns>
        public override int SellPrice()
        {
            // Apple 就是潮，加價20000
            return base.SellPrice() + 20000;
        }
    }
}
