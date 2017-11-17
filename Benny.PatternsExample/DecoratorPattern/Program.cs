using DecoratorPattern.Decorators;
using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 裝飾者模式 : 動態的給對象附加上更多職責
/// </summary>
namespace DecoratorPattern
{
    // 主題 : 手機
    // 重要 : 要設定所有base擁有的屬性，因為是不同的reference
    // base擁有的方法也要重新override
    class Program
    {
        static void Main(string[] args)
        {
            // 建立手機實體
            Phone phone = new ApplePhone();
            phone.CPU = "台積電";
            phone.Price = 5000;
            Console.WriteLine(phone.Print());
            Console.WriteLine("CPU : " + phone.CPU);
            Console.WriteLine("成本價 : " + phone.Price);
            Console.WriteLine("售價 : " + phone.SellPrice());
            Console.WriteLine("----------------------\n");

            // 加上貼膜
            PhoneDecorator applePhoneWithSticker = new Sticker(phone);
            Console.WriteLine(applePhoneWithSticker.Print());
            Console.WriteLine("CPU : " + applePhoneWithSticker.CPU);
            Console.WriteLine("成本價 : " + applePhoneWithSticker.Price);
            Console.WriteLine("售價 : " + applePhoneWithSticker.SellPrice());
            Console.WriteLine("----------------------\n");

            // 加上配飾
            PhoneDecorator applePhoneWithAccessories = new Accessories(phone);
            Console.WriteLine(applePhoneWithAccessories.Print());
            Console.WriteLine("CPU : " + applePhoneWithAccessories.CPU);
            Console.WriteLine("成本價 : " + applePhoneWithAccessories.Price);
            Console.WriteLine("售價 : " + applePhoneWithAccessories.SellPrice());
            Console.WriteLine("----------------------\n");

            // 同時加上貼膜和配飾
            Sticker sticker = new Sticker(phone);
            PhoneDecorator applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            Console.WriteLine(applePhoneWithAccessoriesAndSticker.Print());
            Console.WriteLine("CPU : " + applePhoneWithAccessoriesAndSticker.CPU);
            Console.WriteLine("成本價 : " + applePhoneWithAccessoriesAndSticker.Price);
            Console.WriteLine("售價 : " + applePhoneWithAccessoriesAndSticker.SellPrice());
            Console.Read();
        }
    }
}
