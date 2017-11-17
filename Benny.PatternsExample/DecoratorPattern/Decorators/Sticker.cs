using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    /// <summary>
    /// 貼膜，具體裝飾者
    /// </summary>
    /// <seealso cref="DecoratorPattern.Models.PhoneDecorator" />
    public class Sticker : PhoneDecorator
    {
        public Sticker(Phone phone) : base(phone)
        {
        }

        public override string Print()
        {
            return string.Join("，", new string[] { base.Print(), AddSticker() });
        }

        public string AddSticker()
        {
            return "幫手機貼上貼膜";
        }

        /// <summary>
        /// 售價.
        /// </summary>
        /// <returns></returns>
        public override int SellPrice()
        {
            return base.SellPrice() + 1000;
        }
    }
}
