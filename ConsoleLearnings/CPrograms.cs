using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    class CPrograms
    {
        public static void Programs()
        {
            //Reserve,Sum,Count.
            //ReverseNum();

            //No of Terms,Less than particular no, No is fibanocci or not.
            //Fibanocci();

            //No of Terms
            // PrimeNumNoOfTerms();
            int number = Convert.ToInt32(Console.ReadLine());

            //int sum = 0, i = 0, given = number;
            //while (number > 0)
            //{
            //    i = number % 10;
            //    sum = sum + (i * i * i);
            //    number = number / 10;
            //}
            //if (given == sum)
            //{
            //    Console.WriteLine("No is Armstrong" + given);
            //}
            int count = 0;
            int l = 1;
            //for (int i = 0; count < number;)
            //{
            for (int k = 0; k < l; k++)
            {
                int sum = 0, m = 0;
                int n = k;
                int digits = k;
                int digitscount = 0;
                while (digits > 0)
                {
                    digitscount++;
                    digits = digits / 10;
                }
                while (n > 0)
                {
                    m = n % 10;

                    int s = 1;
                    for (int i = 0; i < digitscount; i++)
                    {
                        s = s * m;
                    }
                    sum = sum + (s);
                    n = n / 10;
                }
                if (k == sum)
                {
                    Console.WriteLine("No is Armstrong" + k);
                    count++;
                    if (count == number)
                    {
                        break;
                    }
                }

                l++;
                //}
            }
            Console.ReadKey();

        }

        public static void ReverseNum()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int rn = 0, sn = 0, cn = 0;
            while (number > 0)
            {
                rn = rn * 10 + (number % 10);
                sn = sn + number % 10;
                cn++;
                number = number / 10;
            }
            Console.WriteLine(rn);
            Console.WriteLine(sn);
            Console.WriteLine(cn);
        }

        public static void Fibanocci()
        {
            int FibanocciTerms = Convert.ToInt32(Console.ReadLine());

            //No of Terms
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < FibanocciTerms; i++)
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write(c + ",");
            }

            //Less than a particular no.
            a = 0;
            b = 1;
            c = 0;
            int Fibanoccinumber = Convert.ToInt32(Console.ReadLine());
            if (Fibanoccinumber > 0)
            {
                Console.Write(a + "," + b);
                while (c <= Fibanoccinumber)
                {
                    Console.Write(c + ",");
                    c = a + b;
                    a = b;
                    b = c;
                }

            }

            Console.ReadKey();
        }

        public static void PrimeNumNoOfTerms()
        {
            int i = 3, count, c;

            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1)
            {
                Console.WriteLine(2);
            }

            for (count = 2; count <= n;)
            {
                for (c = 2; c <= i - 1; c++)
                {
                    if (i % c == 0)
                        break;
                }
                if (c == i)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }
        }


    }
}
