using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Builder
    {
        /// <summary>
        /// 車殼模型
        /// </summary>
        public abstract void BuildCover();

        /// <summary>
        /// 裝引擎
        /// </summary>
        public abstract void BuildEngine();

        /// <summary>
        /// 裝輪胎
        /// </summary>
        public abstract void BuildTire();

        //....細節省略

        /// <summary>
        /// 取得組裝完成的汽車
        /// </summary>
        public abstract Car GetCar();

    }
}
