using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StarPatterns
    {
        // *
        //* *
        //* * *


        private int GetLimit()
        {
            int limit;

            Console.WriteLine("Plese enter any limit");
            limit = Convert.ToInt32(Console.ReadLine());
            return limit;
        }



        public void Pattern1()
        {
            int limit = GetLimit();  //5

            for (int i = 1; i <= limit; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(j+64));
                }

                Console.WriteLine();
            }

        }

        public void Pattern2()
        {
            int limit = GetLimit();  //5

            for (int i = limit; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

        }




        public void Pattern3()
        {
            int limit = GetLimit();  //5

            for (int i = 1; i <= limit; i++)
            {

                for (int k = 1; k <= limit - i; k++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

        }




        public void Pattern4()
        {
            int limit = GetLimit();


            for (int i = limit; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



        public void Pattern5()
        {
            int limit = GetLimit();


            for (int i = limit; i >= 1; i--)
            {

                for (int k = 1; k <= limit-i ; k++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }




    }
}

