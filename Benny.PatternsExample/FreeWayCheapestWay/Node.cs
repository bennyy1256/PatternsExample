using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeWayCheapestWay
{
    public class Node
    {
        public string Name { get; set; }

        public int TollFee { get; set; }

        private List<Link> _Links;
        public List<Link> Links 
        {
            get 
            {
                if(_Links == null)
                {
                    _Links = new List<Link>();
                }
                return _Links;
            }
            set 
            {
                _Links = value;
            }
        }

        public Node(string name, int tollFee)
        {
            this.Name = name;
            this.TollFee = tollFee;
        }

    }
}
