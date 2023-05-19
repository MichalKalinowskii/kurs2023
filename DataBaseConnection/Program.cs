using System.Data.Common;

namespace DataBaseConnection
{

    public enum DBMS
    {
        MSSQL,
        ORACLE,
        POSTGRE
    }

    public class Shapes
    {
        public string Shape1 { get; set; }
        public string Shape2 { get; set; }
        public string Shape3 { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = $"DB: {DBMS.MSSQL}; table: Shapes; timeout: 10";
          
            CustomDbCommand<Shapes> db = new CustomDbCommand<Shapes>(connectionString);
            db.GetData();
        }
    }

    class CustomDb
    {
        private string _connectionString;

        public CustomDb(string connectionString) 
        {
            _connectionString = connectionString;
        }

        internal void OpenConnection() 
        {
            //StartConnection(_connectionString);
        }

        internal void CloseConnection() 
        { 
            //EndConnection(_connectionString);
        }
        
    }


    class CustomDbCommand<T> : CustomDb where T : class
    {
        public CustomDbCommand(string connectionString) : base(connectionString) 
        {

        }        

        public List<T> GetData()
        {
            return null;
        }

    }
}