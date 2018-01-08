using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    class L1
    {
        static List<int> newlist = new List<int>();
        static void Main(string[] args)
        {

            int[] numbers = { 5, 4, 5, 5, 4, 1, 5, 5, 5, 5, 5, 5, 5, 5 };

            Console.WriteLine("L1");
            IDictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int VARIABLE in numbers)
            {
                if (!dic.ContainsKey(VARIABLE))
                {
                    dic.Add(VARIABLE, numbers.Count(x => x == VARIABLE));

                }
            }
            foreach (var VARIABLE in dic)
            {
                Console.WriteLine(VARIABLE.Key + "is" + VARIABLE.Value);
            }
            Console.WriteLine(dic.Values.Max());
            Console.WriteLine(dic.Keys.Max());


            Console.WriteLine("L2");
            List<int> a = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 8, 8, 8 };
            Console.WriteLine(a.Max());


            Console.WriteLine("L3");
            int oddNumbers = numbers.Count(x => x / 2 == 1);
            Console.WriteLine(oddNumbers);


            Console.WriteLine("L4");
            MyDelegate md1 = new MyDelegate(TestDelegate);
            md1("teja");
            //md1(1); Error
            m2(TestDelegate, 1);

            Console.ReadKey();
        }
        public delegate string MyDelegate(string s);

        public static string TestDelegate(string s)
        {
            return "TestDelegate" + " " + s;
        }
        public static string TestDelegate(int i)
        {
            return "TestDelegate" + " " + i;
        }
        public static void m1(int i1)
        {
            Func<int, string> f1 = TestDelegate;
            string s1 = f1(i1);
            Console.WriteLine("m1" + " " + s1);

        }
        public static void m2(Func<int, string> f1, int i1)
        {
            Console.WriteLine("m2" + " " + f1(i1));
        }

    }

}

