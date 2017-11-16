using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/BuilderPattern.html
/// 建造者模式
/// 主要用在建構一個複雜對象的時候
/// 把產生對象實體的邏輯移到類別外部(也就是此例的Builder)，
/// 讓建造一個複雜實體簡化成比較簡單的對象
/// </summary>
namespace BuilderPattern
{
    //範例:汽車生產 
    class Program
    {
        static void Main(string[] args)
        {
            //首先需要有一個管理者
            Director director = new Director();
            //然後要有兩條實際的生產線
            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            //由管理者來發出命令，讓生產線生產，實際上由生產線製造
            director.Construct(builder1);

            //製造完成後，顯示出組好的成品
            Car car1 = builder1.GetCar();
            car1.Show();

            director.Construct(builder2);
            Car car2 = builder2.GetCar();
            car2.Show();


            Console.Read();
        }
    }
}
