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

        //geeksforgeek
        //gksforgk
        //acaaabbbacdddd
        //acac
        public static void RemoveConsecutiveChars()
        {
            string s;
            do
            {
                s = Console.ReadLine().ToString();
                List<char> a1 = new List<char>();
                a1 = s.ToList();
                for (int i = 0; i < a1.Count;)
                {
                    if (i < a1.Count - 1 && a1[i] == a1[i + 1])
                    {
                        a1.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                //foreach (var item in a1)
                //{
                //    Console.Write(item);
                //}
                a1.ForEach(Console.Write);
            } while (!string.Equals(s.ToString(), "No", StringComparison.OrdinalIgnoreCase));
        }

        //Only difference in i++
        //geeksforgeek
        //gksforgk
        //acaaabbbacdddd
        //acaabbacdd
        public static void RemoveConsecutiveCharsAll()
        {
            string s;
            do
            {
                s = Console.ReadLine().ToString();
                List<char> a1 = new List<char>();
                a1 = s.ToList();
                for (int i = 0; i < a1.Count; i++)
                {
                    if (i < a1.Count - 1 && a1[i] == a1[i + 1])
                    {
                        a1.RemoveAt(i);
                    }
                }
                //foreach (var item in a1)
                //{
                //    Console.Write(item);
                //}
                a1.ForEach(Console.Write);
            } while (!string.Equals(s.ToString(), "No", StringComparison.OrdinalIgnoreCase));
        }

        //geeksforgeek
        //gksforgk
        //acaaabbbacdddd
        //acabac
        //geeksforgeegk
        //gksfork
        public static void RemoveRecursiveRepitativeStack()
        {
            string s;
            do
            {
                s = Console.ReadLine().ToString();
                Stack<char> st = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (st.Count != 0 && st.Peek() == s[i])
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(s[i]);
                    }

                }
                List<char> a1 = new List<char>();
                int c = st.Count;
                for (int i = 0; i < c; i++)
                {
                    a1.Add(st.Pop());
                }
                for (int i = 0; i < a1.Count; i++)
                {
                    Console.Write(a1[a1.Count - 1 - i]);
                }
            } while (!string.Equals(s.ToString(), "No", StringComparison.OrdinalIgnoreCase));
        }

        //Pattern Match
        //()()(){}{}{}[][][]
        //Balance
        //({[]})({[]})
        //Balance
        //(((((
        //No Balance
        public static void RemoveRecursiveRepitativeString()
        {
            StringBuilder test;
            do
            {
                test = new StringBuilder();
                test.Append(Console.ReadLine().ToString());
                int le = test.Length;
                bool isInFormat = false;

                for (int i = 0; i < test.Length - 1;)
                {
                    if (test[i] == '{')
                    {
                        if (!CheckFormat(test.ToString().Substring(i, test.ToString().IndexOf('}') + 1)))
                        {
                            isInFormat = false;

                            break;
                        }
                        else
                        {
                            isInFormat = true;
                            string a = test.ToString().Remove(i, test.ToString().IndexOf('}') + 1);
                            test = new StringBuilder();
                            test.Append(a);
                            i = test.ToString().IndexOf('}') + 1;
                        }
                    }
                    else if (test[i] == '[')
                    {
                        if (!CheckFormat(test.ToString().Substring(i, test.ToString().IndexOf(']') + 1)))
                        {
                            isInFormat = false;

                            break;
                        }
                        else
                        {
                            isInFormat = true;
                            string a = test.ToString().Remove(i, test.ToString().IndexOf(']') + 1);
                            test = new StringBuilder();
                            test.Append(a);
                            i = test.ToString().IndexOf(']') + 1;
                        }
                    }
                    else if (test[i] == '(')
                    {
                        if (!CheckFormat(test.ToString().Substring(i, test.ToString().IndexOf(')') + 1)))
                        {
                            isInFormat = false;

                            break;
                        }
                        else
                        {
                            isInFormat = true;
                            string a = test.ToString().Remove(i, test.ToString().IndexOf(')') + 1);
                            test = new StringBuilder();
                            test.Append(a);
                            i = test.ToString().IndexOf(')') + 1;
                        }
                    }
                    else
                    {
                        isInFormat = false;
                        break;
                    }

                }
                if (isInFormat)
                {
                    Console.WriteLine("Balance");
                }
                else
                {
                    Console.WriteLine("No Balance");

                }

            } while (!string.Equals(test.ToString(), "No", StringComparison.OrdinalIgnoreCase));
            Console.ReadKey();
        }
        static bool CheckFormat(string input)
        {
            bool isInFormat = false;
            int le = input.Length;
            if (le % 2 == 0)
            {


                for (int i = 0; i < input.Length / 2; i++)
                {
                    if ((input[i] == '{' && input[le - i - 1] == '}') || (input[i] == '[' && input[le - i - 1] == ']') || (input[i] == '(' && input[le - i - 1] == ')'))
                    {
                        isInFormat = true;
                    }
                    else
                    {
                        isInFormat = false;
                        break;

                    }

                }
            }
            return isInFormat;
        }

        //Pattern Match
        //()()(){}{}{}[][][]
        //Balance
        //({[]})({[]})
        //Balance
        //(((((
        //No Balance
        public static void RemoveRecursiveRepitativeStringwithStack()
        {
            string s;
            do
            {
                s = Console.ReadLine().ToString();
                bool isInFormat = true;
                Stack<char> st = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    {
                        st.Push(s[i]);
                    }
                    else if (st.Count() != 0 && (st.Peek() == '{' && s[i] == '}') || (st.Peek() == '[' && s[i] == ']') || (st.Peek() == '(' && s[i] == ')'))
                    {
                        st.Pop();
                    }
                    else
                    {
                        isInFormat = false;
                        break;
                    }
                }
                if (isInFormat && st.Count() == 0)
                {
                    Console.WriteLine("Balance");
                }
                else
                {
                    Console.WriteLine("No Balance");
                }
            } while (!string.Equals(s.ToString(), "No", StringComparison.OrdinalIgnoreCase));
        }
        public static void StringMutable()
        {
            //string is mutable
            string test = "ddd";
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test.Remove(0, 1).GetHashCode());

            //string builder is immutable
            StringBuilder a = new StringBuilder();
            a.Append("t");
            Console.WriteLine(a.GetHashCode());
            a.Append("tas");
            Console.WriteLine(a.Remove(0, 1).GetHashCode());
        }
    }

}
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//public class GFG
//{
//    static public void Main()
//    {
//        var counter = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < counter; i++)
//        {
//            var s = Console.ReadLine();
//            stringPermutations(s);
//        }
//    }
//    private static void stringPermutations(string inputString)
//    {
//        char[] characters = inputString.ToCharArray().OrderBy(c => c).ToArray();
//        var q = new Queue<char>();
//        characters.ToList().ForEach(c => q.Enqueue(c));
//        var wordAccumulator = new List<char>();
//        var resultAccumulator = new List<string>();
//        recursionStep(wordAccumulator, q, inputString.Length, resultAccumulator);
//        resultAccumulator.Sort();
//        var strBld = new StringBuilder();
//        Console.WriteLine(string.Join(" ", resultAccumulator));

//    }
//    private static void recursionStep(List<char> currentVector, Queue<char> queue, int target, List<string> resultAccumulator)
//    {
//        if (currentVector.Count == target)
//        {
//            var strBld = new StringBuilder();
//            currentVector.ForEach(c => strBld.Append(c));
//            //Trace.WriteLine(strBld);
//            resultAccumulator.Add(strBld.ToString());
//        }

//        for (int i = 0; i < queue.Count; i++)
//        {
//            var temp = queue.Dequeue();
//            currentVector.Add(temp);
//            recursionStep(currentVector, queue, target, resultAccumulator);
//            currentVector.Remove(temp);//remove the last item to continue iterating
//            queue.Enqueue(temp);//enqueue item back as we keep only 1 queue
//        }
//    }
//}
//public static bool Check_sub(String str1, String str3)
//{
//    if (str3.Contains(str1))
//    {
//        return true;
//    }
//    return false;
//}
//String str1 = "waterbottle";
//String str2 = "erbottlewat";
//String str3 = str1 + str1;

//    if (str1.Length != str2.Length)
//    {
//        Console.WriteLine("not rotation");
//    }
//    else
//    {
//        if (Check_sub(str2, str3))
//        {
//            Console.WriteLine(" rotation");
//        }
//        else
//        {
//            Console.WriteLine("not rotationn");
//        }
//    }