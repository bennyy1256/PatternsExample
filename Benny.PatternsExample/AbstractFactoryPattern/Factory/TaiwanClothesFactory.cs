using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class TaiwanClothesFactory : ClothesFactory
    {
        public override Pants CreatePants()
        {
            return new TaiwanPants();
        }

        public override Skirts CreateSkirts()
        {
            return new TaiwanSkirts();
        }
    }
}
