using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        protected TimeSpan _timeout;

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("The connection string cannot be null, whitespace or empty");

            _connectionString = connectionString;
            _timeout = TimeSpan.FromSeconds(5);
        }

        public abstract void Open();

        public abstract void Close();
    }
}