using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString) { }

        public override void Open()
        {

            if (Timeout > DateTime.Now - DateTime.Now.Subtract(Timeout))
            {
                Console.WriteLine("Sql connection has been opened.");
            }
            else
            {
                Console.WriteLine("Connection timed out...\nPlease try again.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection has been closed.");
        }
    }
}