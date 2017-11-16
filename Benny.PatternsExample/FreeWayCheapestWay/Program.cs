using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeWayCheapestWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            double cost;
            var bestPath = map.FindBestPath("基金", "機場", out cost);
            foreach(var item in bestPath)
            {
                Console.WriteLine($"============={item}===============");
            }
            Console.WriteLine(cost);

            Console.ReadLine();
        }
    }
}
