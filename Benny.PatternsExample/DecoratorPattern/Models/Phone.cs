using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    /// <summary>
    /// 抽象手機類別，即裝飾者模式中的抽象類別
    /// </summary>
    public abstract class Phone
    {
        /// <summary>
        /// CPU種類.
        /// </summary>
        /// <value>
        /// The cpu.
        /// </value>
        public string CPU { get; set; }

        /// <summary>
        /// 成本價.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price { get; set; }

        /// <summary>
        /// 售價.
        /// </summary>
        /// <returns></returns>
        public virtual int SellPrice()
        {
            return Price + 500;
        }

        public abstract string Print();
    }
}
