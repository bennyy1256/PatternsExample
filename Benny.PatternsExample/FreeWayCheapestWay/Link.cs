using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeWayCheapestWay
{
    public class Link
    {
        public double Distance { get; set; }

        public Node FromNode { get; set; }

        public Node ToNode { get; set; }

        public RoadNameEnum Road { get; set; }

        public Link(
            Node fromNode,
            Node toNode,
            double distance,
            RoadNameEnum road)
        {
            this.FromNode = fromNode;
            this.ToNode = toNode;
            this.Distance = distance;
            this.Road = road;
        }

        public string GetOtherNodeName(string nodeName)
        {
            bool isFromNode = nodeName.Equals(FromNode.Name);
            bool isToNode = nodeName.Equals(ToNode.Name);

            if (isFromNode || isToNode)
            {
                return isFromNode ? ToNode.Name : FromNode.Name;
            }
            return string.Empty;
        }

        public enum RoadNameEnum
        {
            FreeWay1 = 1,
            FreeWay2 = 2,
            FreeWay3 = 3
        }

    }
}
