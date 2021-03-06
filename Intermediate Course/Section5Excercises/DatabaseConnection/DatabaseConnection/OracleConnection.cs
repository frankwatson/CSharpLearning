using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString) { }

        public override void Open()
        {

            if (Timeout > DateTime.Now - DateTime.Now.Subtract(Timeout))
            {
                Console.WriteLine("Oracle connection has been opened.");
            }
            else
            {
                Console.WriteLine("Connection timed out...\nPlease try again.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection has been closed.");
        }
    }
}