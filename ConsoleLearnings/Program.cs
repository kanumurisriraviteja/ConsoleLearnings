using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{

    public static bool Check_sub(String str1, String str3)
    {
        if (str3.Contains(str1))
        {
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        String str1 = "waterbottle";
        String str2 = "erbottlewat";
        String str3 = str1 + str1;

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("not rotation");
        }
        else
        {
            if (Check_sub(str2, str3))
            {
                Console.WriteLine(" rotation");
            }
            else
            {
                Console.WriteLine("not rotationn");
            }
        }
        Console.ReadKey();
    }
}
