using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    public class InterviewQns
    {
        //const string constString ;//A Constant requires a value.
        const string constString = "tejaConst";
        private readonly string readonlyString = "tejaRead";
        readonly static string readonlyString1;
        readonly string readonlyString2;
        InterviewQns interviewQns;
        //InterviewQns interviewQns = new InterviewQns();//Error StackOverFlow Exception Occur's.


        static InterviewQns()
        {
            //readonlyString1 = Console.ReadLine();//t1
        }
        public InterviewQns()
        {
            //readonlyString2 = Console.ReadLine();//t2,t3(2nd iteration)

        }
        public void Qns()
        {
            #region ConstantReadOnly       
            //Console.WriteLine(readonlyString1);//t1
            //Console.WriteLine(readonlyString);//tejaRead
            //Console.WriteLine(constString);//tejaConst
            //InterviewQns interviewQns1 = new InterviewQns();
            //Console.WriteLine(interviewQns1.readonlyString2);//t2
            //Console.WriteLine(readonlyString);//tejaRead
            //InterviewQns interviewQns2 = new InterviewQns();
            //Console.WriteLine(interviewQns2.readonlyString2);//t3
            //Console.WriteLine(readonlyString);//tejaRead
            #endregion

            #region RefOut

            int a1;
            int a2 = 6;
            // RefOut(ref a1);// Ref must be initialized
            Ref(ref a2);
            Console.WriteLine(a2);//7
            Out(out a1);
            Console.WriteLine(a1);//6
            Normal(a1);
            Console.WriteLine(a1);//6
            #endregion

            #region Delegates
            Console.WriteLine("L4");
            MyDelegate md1 = new MyDelegate(TestDelegate);
            //md1(1); Error
            Console.WriteLine(md1("teja"));//TestDelegate teja
            Console.WriteLine(TestDelegate("teja"));//TestDelegate teja calling the method directly.
            test(TestDelegate1);
            /*
              TestDelegate 0
              TestDelegate 1
              TestDelegate 2
              TestDelegate 3
              TestDelegate 4
             */

            m2(TestDelegate, 1);//m2 TestDelegate 1

            interviewQns = new InterviewQns();
            interviewQns.LongRunning();
            /*0
              1
              2
              3
              4
              */
            //LongRunning();
            LongRunningDelegate(CallBack1);
            /*0
              1
              2
              3
              4
              */
            #endregion
        }
        public static void Ref(ref int a1)
        {
            a1++;
        }
        public static void Out(out int a1)
        {
            a1 = 5;
            a1++;
        }
        public static void Normal(int a1)
        {
            a1++;
            Console.WriteLine(a1);//7
        }

        public delegate string MyDelegate(string s);

        public static string TestDelegate(string s)
        {
            return "TestDelegate" + " " + s;
        }

        public delegate string MyDelegate1(int a);
        public static string TestDelegate1(int myDelegate)
        {
            return "TestDelegate" + " " + myDelegate;
        }

        public static void test(MyDelegate1 myDelegate1)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myDelegate1(i));
            }
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

        public void LongRunning()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void LongRunningDelegate(CallBack obj)
        {
            for (int i = 0; i < 5; i++)
            {
                obj(i);
            }
        }

        public delegate void CallBack(int i);
        static void CallBack1(int i)
        {
            // can write some code here
            Console.WriteLine(i);
        }
    }
}
