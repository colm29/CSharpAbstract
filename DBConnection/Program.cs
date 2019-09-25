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
            Console.WriteLine("Doing SQL stuff.....");
            s.Close();

            o.Open();
            Console.WriteLine("Doing Oracle stuff.....");
            o.Close();
        }
    }


}
