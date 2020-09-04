using System;

namespace MyApplications
{
    class exercicio_1
    {
        static void Main(string[] args)
        {
            int x = 5;
            double k = 4.67823;
            int i;

            for (i = 1; i<=5; i++)
            {
                double t = Math.Round(k,x);
                x--;
                Console.WriteLine(t.ToString("0.00000"));
            }
        }
    }
}