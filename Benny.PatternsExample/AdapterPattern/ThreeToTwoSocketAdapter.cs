using AdapterPattern.Interfaces;
using AdapterPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 三孔插頭後面接兩孔插座的轉接器
    /// 提供了三孔插頭的行為，但其本質是調用兩孔插頭的方法 
    /// </summary>
    /// <seealso cref="AdapterPattern.Models.TwoHoleConnector" />
    /// <seealso cref="AdapterPattern.Interfaces.IThreeHole" />
    public class ThreeToTwoSocketAdapter : ISocket, IConnector
    {
        /// <summary>
        /// 插座 - 三孔
        /// </summary>
        private Socket _socket;
        private Socket _Socket
        {
            get
            {
                if(_socket == null)
                {
                    _socket = new ThreeHoleSocket();
                }
                return _socket;
            }
        }

        /// <summary>
        /// 插頭 - 兩孔
        /// </summary>
        private Connector _connector;
        private Connector _Connector
        {
            get
            {
                if (_connector == null)
                {
                    _connector = new TwoHoleConnector();
                }
                return _connector;
            }
        }

        /// <summary>
        /// 提供電力
        /// </summary>
        /// <returns></returns>
        public string Supply()
        {
            return _Socket.Supply();
        }

        /// <summary>
        /// 取得電力
        /// </summary>
        /// <returns></returns>
        public string Take()
        {
            return _Connector.Take();
        }
    }
}
