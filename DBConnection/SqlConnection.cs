using System;

namespace DBConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string conn)
            : base(conn)
        {
            Timeout = TimeSpan.FromSeconds(30);
        }
        
        public override void Open()
        {
            Console.WriteLine("Opening SQL connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection");
        }
    }


}
