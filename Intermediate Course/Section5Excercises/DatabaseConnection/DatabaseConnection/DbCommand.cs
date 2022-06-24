using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _command;
        
        public DbCommand(DbConnection dbConnection, string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException(nameof(command));

            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
            _command = command;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Command: " + _command);
            _dbConnection.Close();
        }
    }
}