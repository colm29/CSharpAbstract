using System;

namespace DBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string conn)
        {
            if (String.IsNullOrEmpty(conn))
                throw new ArgumentException();

            ConnectionString = conn;
        }
        
        public abstract void Open();

        public abstract void Close();

    }


}
