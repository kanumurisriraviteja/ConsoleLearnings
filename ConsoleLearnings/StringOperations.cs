using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    public static class StringOperations
    {

        public static void Operations()
        {
            //1 same instance for the string.
            string s1 = "teja";
            string s2 = "teja";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));//True
            Console.WriteLine(Object.Equals(s1, s2));//True
            Console.WriteLine(s1.GetHashCode());//1230421684
            Console.WriteLine(s2.GetHashCode());//1230421684 // s2 will point to the same instance.


            //2 string is mutable
            string test = "ddd";
            Console.WriteLine(test.GetHashCode());//-1029223246
            Console.WriteLine(test.Remove(0, 1).GetHashCode());//-840517700 New instance is created.

            //string builder is immutable
            StringBuilder a = new StringBuilder();
            a.Append("t");
            Console.WriteLine(a.GetHashCode());//46104728
            a.Append("tas");
            Console.WriteLine(a.Remove(0, 1).GetHashCode());//46104728 we will have the same instance.


            string firstname;
            string lastname;
            string testname;

            firstname = "Steven Clark";
            lastname = "Clark";
            testname = firstname.Clone().ToString();


            Console.WriteLine(firstname.Clone());
            Console.WriteLine(firstname.GetHashCode());//1470518261
            Console.WriteLine(testname.GetHashCode());//1470518261 has the same instance.
            // Makes String Clone

            Console.WriteLine(firstname.CompareTo(lastname));//1
            Console.WriteLine(firstname.CompareTo(testname));//0
            //Compare two string value and returns 0 for true and     1 for false


            Console.WriteLine(firstname.Contains("ven"));//True
            //Check whether specified value exists or not in string

            Console.WriteLine(firstname.EndsWith("n")); // False
            //Check whether specified value is the last character of string

            Console.WriteLine(firstname.Equals(lastname));// False
            Console.WriteLine(firstname.Equals(testname));//True
            //Compare two string and returns true and false


            Console.WriteLine(firstname.GetHashCode());
            //Returns HashCode of String

            Console.WriteLine(firstname.GetType());//System.String
            //Returns type of string

            Console.WriteLine(firstname.GetTypeCode());//String
            //Returns type of string

            Console.WriteLine(firstname.IndexOf("e")); //2
            //Returns the first index position of specified value  the first index position of specified value

            Console.WriteLine(firstname.LastIndexOf("e")); //4
            //Returns the last index position of specified value

            Console.WriteLine(firstname.ToLower());//steven clark
            //Covert string into lower case

            Console.WriteLine(firstname.ToUpper());//STEVEN CLARK
            //Convert string into Upper case

            Console.WriteLine(firstname.Insert(0, "Hello")); //HelloSteven Clark
            //Insert substring into string
            Console.WriteLine(firstname.GetHashCode());//1470518261. The string will not be modified. it will be creating a new string.

            Console.WriteLine(firstname.IsNormalized());//True.
                                                        //Check Whether string is in Unicode normalization from C




            Console.WriteLine(firstname.Length);//12
            //Returns the Length of String

            Console.WriteLine(firstname.Remove(5));//Steve
            //Deletes all the characters from begining to specified index.

            Console.WriteLine(firstname.Replace('e', 'i'));//Stivin Clark
            // Replace the character

            string[] split = firstname.Split(new char[] { 'e' });
            //Split the string based on specified value


            Console.WriteLine(split[0]);//St
            Console.WriteLine(split[1]);//v
            Console.WriteLine(split[2]);//n Clark


            Console.WriteLine(firstname.StartsWith("S")); //True
            //Check wheter first character of string is same as specified value

            Console.WriteLine(firstname.Substring(2, 5));//even
                                                         //Returns substring start position and give the length of the characters.
            Char[] charArray = firstname.ToCharArray();
            Console.WriteLine(charArray);//Steven Clark
            //Converts an string into char array.
            Console.WriteLine(charArray);

            Console.WriteLine(firstname.Trim());//Steven Clark
            //It removes starting and ending white spaces from  string.

            Console.WriteLine(string.Join("", firstname.Reverse()));
            //kralC nevetS
            //Reverse the string
            //Reverse() will only return the IEnumerable Array.

            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string str = String.Join("\n", starray);


        }
        // Extension method should be defined only in static class.
        public static string TestExtensions(this String input)
        {
            return "Kanumrui" + input;
        }
    }
}
