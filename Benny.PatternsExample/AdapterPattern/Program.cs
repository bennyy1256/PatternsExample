using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/AdapterPattern.html
/// 適配器模式 : 通過class的繼承或對象的組合，讓不兼容的接口變得兼容。
/// 側重於轉換已有的接口。
/// 
/// 有分為class的適配器模式和對象的適配器模式 
/// </summary>
namespace AdapterPattern
{
    //主題: 三頭插座(Socket)原本只適合三頭的插頭(Connector)，
    //要讓三頭插座也能插兩頭的插頭，就要讓它同時具有三頭和兩頭插頭的特徵
    class Program
    {
        static void Main(string[] args)
        {
            var powerAdapter = new ThreeToTwoSocketAdapter();
            Console.WriteLine(powerAdapter.Supply());
            Console.WriteLine(powerAdapter.Take());
            Console.Read();
        }
    }
}
