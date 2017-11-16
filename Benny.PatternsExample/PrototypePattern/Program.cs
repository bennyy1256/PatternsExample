using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/PrototypePattern.html
/// 和工廠模式一樣，對使用者隱藏他的創建工作，
/// 不過是透過拷貝一個現有對象來生成新對象。
/// 
/// 關鍵在於MemberwiseClone() 這個shallow clone(淺拷貝)方法。
/// shallow clone只會複製一份steak，原來的對象和複製出的對象都同樣指向同一份heap位置，
/// 所以當heap值被修改，兩個物件同時改變
/// </summary>
namespace PrototypePattern
{
    //主題:細胞複製
    class Program
    {
        static void Main(string[] args)
        {
            //母細胞(第一個細胞)
            CellPrototype cell = new ConcretePrototype("Mother");

            //複製第一個
            CellPrototype clone1 = cell.Clone();
            Console.WriteLine("Cloned1:\t" + clone1.id);

            //複製第二個
            CellPrototype clone2 = cell.Clone();
            Console.WriteLine("Cloned2:\t" + clone2.id);

            Console.ReadLine();
        }
    }
}
