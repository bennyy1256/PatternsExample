using FactoryPattern.Factory;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.cnblogs.com/zhili/p/FactoryMethod.html
/// 工廠模式，將簡單工廠的Factory變為抽象類別，實際的創建工作改由其子類來完成，
/// 解決了簡單工廠在新增產品種類時需要去Factory類修改程式碼的問題。
/// </summary>
namespace FactoryPattern
{
    //範例:不同資料庫連線(同簡單工廠模式)，當今天要增加一個MYSQL連線
    class Program
    {
        static void Main(string[] args)
        {
            //分別建立工廠
            DBConnectFactory mssqlFactory = new MSSQLConnectFactory();
            IDBConnection mssqlConn = mssqlFactory.CreateDBConnectFactory();
            DBConnectFactory oracleFacotry = new OracleConnectFactory();
            IDBConnection oracleConn = oracleFacotry.CreateDBConnectFactory();
            DBConnectFactory mysqlFactory = new MYSQLConnectFactory();
            IDBConnection mysqlConn = mysqlFactory.CreateDBConnectFactory();

            //開始生產(建立連線)
            mssqlConn.DoConnect();
            oracleConn.DoConnect();
            mysqlConn.DoConnect();

            Console.ReadLine();


        }
    }
}
