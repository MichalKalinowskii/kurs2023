using System.Data.Common;

namespace DataBaseConnection
{

    public enum DBMS
    {
        MSSQL,
        ORACLE,
        POSTGRE
    }

    public class Shape
    {
        public string Shape1 { get; set; }
        public string Shape2 { get; set; }
        public string Shape3 { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = $"DBMS: {DBMS.MSSQL}; AdressIp: 127.0.0.1; table: {nameof(Shape)}; timeout: 10";

            CustomDbCommand<Shape> db = new CustomDbCommand<Shape>(connectionString, "select * from shapes");
            db.GetData();
        }
    }

    class CustomDb<T> where T : class
    {
        private string _connectionString;

        public CustomDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        internal void OpenConnection()
        {
            Console.WriteLine($"StartConnection({_connectionString})");
        }

        internal void CloseConnection()
        {
            Console.WriteLine($"EndConnection({_connectionString})");
        }

        internal List<T> RunSql(string sql)
        {
            Console.WriteLine(sql);
            return null;
        }

    }


    class CustomDbCommand<T> : CustomDb<T> where T : class
    {
        private string _sql;
        public CustomDbCommand(string connectionString, string sql) : base(connectionString)
        {
            _sql = sql;
        }

        public List<T> GetData()
        {
            OpenConnection();
            RunSql(_sql);
            CloseConnection();
            return null;
        }

    }
}