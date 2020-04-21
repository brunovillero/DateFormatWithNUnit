using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, DateFormat.ChangeFormat(testDate, "aaaa-mm-dd"));
        }
    }
}
