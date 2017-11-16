using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeWayCheapestWay
{
    public class Map
    {
        private Dictionary<string, Node> _nodes = new Dictionary<string, Node>();

        public Map()
        {
            //
            //  construct / load map data
            //
            this.AddNode("基金", 0);
            this.AddNode("七堵", 0);
            this.AddNode("汐止", 0);
            this.AddNode("樹林收費站", 40);
            this.AddNode("機場", 0);
            
            this.AddLink("基金", "七堵", 4.9, Link.RoadNameEnum.FreeWay1);
            this.AddLink("七堵", "汐止", 5.8, Link.RoadNameEnum.FreeWay1);
            this.AddLink("汐止", "樹林收費站", 11.2, Link.RoadNameEnum.FreeWay1);
            this.AddLink("樹林收費站", "機場", 5.1, Link.RoadNameEnum.FreeWay1);
            
            //------

            this.AddNode("新店收費站", 40);
            this.AddNode("中和", 0);

            this.AddLink("基金", "新店收費站", 13.8, Link.RoadNameEnum.FreeWay2);
            this.AddLink("新店收費站", "中和", 4, Link.RoadNameEnum.FreeWay2);
            this.AddLink("中和", "機場", 9.1, Link.RoadNameEnum.FreeWay2);

            //------

            this.AddNode("大安", 0);
            this.AddNode("深坑收費站", 40);

            this.AddLink("基金", "大安", 12.5, Link.RoadNameEnum.FreeWay3);
            this.AddLink("大安", "深坑收費站", 7.2, Link.RoadNameEnum.FreeWay3);
            this.AddLink("深坑收費站", "機場", 6.9, Link.RoadNameEnum.FreeWay3);

            //------

            this.AddLink("汐止", "中和", 3.2, Link.RoadNameEnum.FreeWay1);
            this.AddLink("樹林收費站", "中和", 4.1, Link.RoadNameEnum.FreeWay2);

            this.AddLink("新店收費站", "大安", 2.7, Link.RoadNameEnum.FreeWay2);
            this.AddLink("深坑收費站", "新店收費站", 1.2, Link.RoadNameEnum.FreeWay3);

        }

        private void AddNode(string name, int tollFee)
        {
            Node node = new Node(name, tollFee);
            this._nodes.Add(name, node);
        }

        private void AddLink(string fromNode, string toNode, double distance, Link.RoadNameEnum road)
        {
            Node node1 = this._nodes[fromNode];
            Node node2 = this._nodes[toNode];
            Link link = new Link(this._nodes[fromNode], this._nodes[toNode], distance, road);
            node1.Links.Add(link);
            node2.Links.Add(link);
        }

        public Link FindLink(string name1, string name2)
        {
            foreach (Link way in this._nodes[name1].Links)
            {
                if (way.GetOtherNodeName(name1) == name2) return way;
            }
            return null;
        }

        //=================================================

        /// <summary>
        /// 目前的最低收費路線費用.
        /// </summary>
        private double _Cost { get; set; }

        private string[] _BestPath { get; set; }

        private Stack<string> _Path { get; set; }

        //先把全部點走一遍，再決定最便宜的路徑 
        // PS. 一公升走15公里，每公升30元，所以相當於路程一公里兩塊錢
        private void Search(
            string startName, 
            string endName, 
            double currentCost)
        {
            this._Path.Push(startName);
            if(startName == endName)
            {
                if(this._Cost == 0 || currentCost < this._Cost)
                {
                    this._Cost = currentCost;
                    this._BestPath = this._Path.ToArray();
                }
                this._Path.Pop();
                return;
            }

            foreach(Link way in this._nodes[startName].Links)
            {
                string next = way.GetOtherNodeName(startName);
                if(!this._Path.Contains(next))
                {
                    var cost = currentCost + this._nodes[next].TollFee + way.Distance * 2;
                    this.Search(next, endName, cost);
                }
            }
            this._Path.Pop();

        }

        public string[] FindBestPath(
            string startName, 
            string endName, 
            out double cost)
        {
            try {
                this._Cost = 0;
                this._Path = new Stack<string>();
                this.Search(startName, endName, 0);
                cost = this._Cost;
                return this._BestPath;
            }
            finally
            {
                this._Cost = 0;
                this._Path = null;
            }

        }

    }
}
