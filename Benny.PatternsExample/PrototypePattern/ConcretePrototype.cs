﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class ConcretePrototype : CellPrototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {

        }

        public override CellPrototype Clone()
        {
            return (CellPrototype)this.MemberwiseClone();
        }

    }
}
