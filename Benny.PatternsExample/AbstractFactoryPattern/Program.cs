using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/AbstractFactory.html
/// 抽象工廠模式，主要用來解決工廠模式的問題
/// 解決工廠模式一個工廠只生產一種產品的問題(也不能說是問題，應該說實際上很少有這種工廠只生產一種產品)
/// </summary>
namespace AbstractFactoryPattern
{
    //範例 : 衣服工廠 分別產生適合美國人以及台灣人穿的褲子和裙子
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========美國=============");

            //建造工廠(美國)
            ClothesFactory americanFactory = new AmericanClothesFactory();
            //產出褲子
            Pants americanPants = americanFactory.CreatePants();
            americanPants.OutPut();
            //產出裙子
            Skirts americanSkirts = americanFactory.CreateSkirts();
            americanSkirts.OutPut();

            Console.WriteLine("==========台灣=============");

            //建造工廠(台灣)
            ClothesFactory taiwanFactory = new TaiwanClothesFactory();
            //產出褲子
            Pants taiwanPants = taiwanFactory.CreatePants();
            taiwanPants.OutPut();
            //產出裙子
            Skirts taiwanSkirts = taiwanFactory.CreateSkirts();
            taiwanSkirts.OutPut();

            Console.ReadLine();
        }
    }
}
