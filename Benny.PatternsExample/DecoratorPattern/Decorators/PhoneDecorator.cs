using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    /// <summary>
    /// 裝飾抽象類別，要讓裝飾完全取代抽象類別，所以必須繼承抽象類別
    /// 重要 : 要設定所有base擁有的屬性，因為是不同的reference
    /// base擁有的方法也要重新override
    /// </summary>
    /// <seealso c ref="DecoratorPattern.Models.Phone" />
    public abstract class PhoneDecorator : Phone
    {
        private Phone _Phone;

        public PhoneDecorator(Phone phone)
        {
            this._Phone = phone;

            // 要設定所有base擁有的屬性，因為是不同的reference
            base.CPU = phone.CPU;
            base.Price = phone.Price;
        }

        /// <summary>
        /// 售價.
        /// </summary>
        /// <returns></returns>
        public override int SellPrice()
        {
            var result = base.SellPrice();

            if (this._Phone != null)
            {
                result = this._Phone.SellPrice();
            }

            return result;
        }

        public override string Print()
        {
            var result = string.Empty;

            if(this._Phone != null)
            {
                result = this._Phone.Print();
            }

            return result;
        }


    }
}
