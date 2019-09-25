using System;

namespace DBConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string conn)
            : base(conn)
        {
            Timeout = TimeSpan.FromSeconds(60);
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }


}
