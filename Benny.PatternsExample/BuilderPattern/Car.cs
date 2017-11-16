using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class Car
    {
        private List<string> _CarComponents = new List<string>();

        public void Add(string car)
        {
            _CarComponents.Add(car);
        }

        public void Show()
        {
            Console.WriteLine("-----------開始生產汽車--------------");
            foreach(var item in _CarComponents)
            {
                string content = string.Format("裝上{0}",item);
                Console.WriteLine(content);
            }
            Console.WriteLine("-----------組裝結束--------------");
        }
    }
}
