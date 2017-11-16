using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        //存放實體
        private static Singleton _UniqueInstance;

        private static readonly object _Locker = new object();

        //私有的建構子，不然外部自行建立實體
        private Singleton()
        { 
        
        }

        //公開取得實體的方法
        public static Singleton GetInstance()
        {
            //不用每次都加鎖，只有當實體為null的時候再加鎖即可
            if (_UniqueInstance == null)
            {
                //防止一次多執行跑到判斷null方法中造成建立不只一個實體
                //當有一個執行跑到此就會對_Locker加鎖
                lock (_Locker)
                {
                    if (_UniqueInstance == null)
                    {
                        _UniqueInstance = new Singleton();
                    }
                }
            }
            
            return _UniqueInstance;
        }

    }
}
