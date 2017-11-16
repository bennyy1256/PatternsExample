using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public abstract class ClothesFactory
    {
        public abstract Pants CreatePants();

        public abstract Skirts CreateSkirts();
    }
}
