using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class CellPrototype
    {
        public string id { get; set; }

        public CellPrototype(string id)
        {
            this.id = id;
        }

        public abstract CellPrototype Clone();
    }
}
