using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteBuilder2 : Builder
    {
        Car car = new Car();
        public override void BuildCover()
        {
            car.Add("車殼2");
        }

        public override void BuildEngine()
        {
            car.Add("引擎2");
        }

        public override void BuildTire()
        {
            car.Add("輪胎2");
        }

        public override Car GetCar()
        {
            return car;
        }

    }
}
