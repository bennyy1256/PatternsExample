using SimpleFactoryPattern.Enums;
using SimpleFactoryPattern.Factory;
using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/SimpleFactory.html
/// 但簡單工廠再遇到需要新增一個種類時，必須要修改到工廠類別，這違反OCP
/// ，工廠模式會解決這個問題。
/// </summary>
namespace SimpleFactoryPattern
{
    //範例:不同資料庫連線
    class Program
    {
        static void Main(string[] args)
        {
            //使用MSSQL連線
            DBConnectFactory factory = new DBConnectFactory();
            IDBConnection mssqlConn = factory.GetConnection(ConnectionEnum.MSSQL);
            mssqlConn.DoConnect();

            //使用Oracle連線
            IDBConnection oracleConn = factory.GetConnection(ConnectionEnum.Oracle);
            oracleConn.DoConnect();

            Console.ReadLine();
        }
    }
}
