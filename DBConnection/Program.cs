using System;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SqlConnection("sseeeeeqqueeellll");
            var o = new OracleConnection("ooorrracccllee");

            s.Open();
            var sqlcmd = new DbCommand(s, "select * from someTable");
            sqlcmd.Run();
            s.Close();

            o.Open();
            var ocmd = new DbCommand(o, "select * from anOracleTable");
            ocmd.Run();
            o.Close();
        }
    }


}
