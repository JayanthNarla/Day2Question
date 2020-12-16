using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Question
{
    class Program

    {

        static void Main(string[] args)

        {

            int st, en, cnt = 0;

            Console.WriteLine("Num 1:-");

            st = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 2:-");

            en = int.Parse(Console.ReadLine());

            for (int i = 1; i < en; i++)

            {

                for (int j = 1; j < en; j++)

                {

                    if (i % j == 0)
                    {
                        cnt++;
                    }

                }

                if (cnt == 2)

                {

                    //Write Print statement here

                }

                cnt = 0;

            }

            Console.ReadKey();

        }

    }
}
