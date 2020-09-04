using System;

namespace MyApplications
{
    class exercicio_3
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2017,08,08);
            DateTime data2 = data1.AddDays(45);
            Console.WriteLine(data2.ToString("dd-MM-yyyy"));
        }
    }
}