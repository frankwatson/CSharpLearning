namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("10.20.1.15:password");
            var dbCommand = new DbCommand(sqlConnection, "SELECT * FROM CUSTOMERS");
            dbCommand.Execute();

            // var oracleConnection = new OracleConnection("10.20.1.16:12345Admin");
            // var dbCommandOracle = new DbCommand(oracleConnection, "SELECT * FROM USERS");
            // dbCommandOracle.Execute();
        }
    }
}
