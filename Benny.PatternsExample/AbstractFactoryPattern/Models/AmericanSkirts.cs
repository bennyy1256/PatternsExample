﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class AmericanSkirts : Skirts
    {
        public override void OutPut()
        {
            Console.WriteLine("American Style Skirts !");
        }
    }
}