using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Models;

namespace DecoratorPattern.Decorators
{
    /// <summary>
    /// 手機配飾，具體裝飾者
    /// </summary>
    /// <seealso cref="DecoratorPattern.Decorators.PhoneDecorator" />
    public class Accessories : PhoneDecorator
    {
        public Accessories(Phone phone) : base(phone)
        {
        }

        public override string Print()
        {
            return string.Join("，", new string[] { base.Print(), AddAccessories() });
        }

        public string AddAccessories()
        {
            return "幫手機加上配飾";
        }

        /// <summary>
        /// 售價.
        /// </summary>
        /// <returns></returns>
        public override int SellPrice()
        {
            return base.SellPrice() + 1500;
        }
    }
}
