using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection
{
    class DbCommand
    {
        DbConnection Conn { get; set; }
        string Cmd { get; set; }

        public DbCommand(DbConnection conn, string cmd)
        {
            if (conn == null)
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(cmd))
                throw new ArgumentException("Command cannot be null or empty");

            Conn = conn;
            Cmd = cmd;
        }

        public void Run() => Console.WriteLine(Cmd);
    }
}
