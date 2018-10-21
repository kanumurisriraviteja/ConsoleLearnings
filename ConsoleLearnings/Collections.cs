using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    class Collections
    {
        //Array,ArrarList,List,IEnumerable,IQueryable,ICollection,HashTable,Dictionary,Queue,Stack.
        public static void MainCollections()
        {
            //Array
            //index based,Generic ,Fixed length.
            Console.WriteLine("Array");
            int[] iArray = new int[10];
            //int[] iArray = {1,2,3,4}
            iArray[0] = 1;
            iArray[1] = 2;
            iArray[2] = 3;
            iArray[3] = 4;

            foreach (var VARIABLE in iArray)
            {
                Console.WriteLine(VARIABLE);
            }
            /*Array
                1
                2
                3
                4
                0
                0
                0
                0
                0
                0
             */

            //ArrayList
            //index based,Non-Generic ,Variable length.
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("teja");
            foreach (var VARIABLE in arrayList)
            {
                Console.WriteLine(VARIABLE);
            }

            /*
             ArrayList
                1
                teja
             */
            //List
            //index based,Generic,Variable length
            Console.WriteLine("List");
            List<int> iList = new List<int>();
            //List<int> iList = new List<int>() {1,2 };
            iList.Add(1);
            iList.Add(2);
            Console.WriteLine(iList[1]);//2
            foreach (var VARIABLE in iList)
            {
                Console.WriteLine(VARIABLE);
            }
            //List
            //2
            //1
            //2


            //IEnumerable.
            //index based,Generic,Variable length
            //no modification to be done.
            Console.WriteLine("IEnumerable");
            IEnumerable<int> iEnumerable = new List<int>() { 1, 2, 3, 4 };
            //iEnumerable.Add(1);//Error cant add to a IEnumerable.
            Console.WriteLine(iList[1]);//2
            foreach (var VARIABLE in iEnumerable)
            {
                Console.WriteLine(VARIABLE);
            }
            /*
             IEnumerable
                2
                1
                2
                3
                4
             */

            //IQueryable.
            //index based,Generic,Variable length
            //no modification to be done. holds good to get data filter through large records.
            Console.WriteLine("IQueryable");
            IQueryable<int> iQueryable = iList.AsQueryable();
            //iQueryable.Add(1);//Error cant add to a IEnumerable.
            foreach (var VARIABLE in iQueryable)
            {
                Console.WriteLine(VARIABLE);
            }
            /* IQueryable
             1
             2
             */

            //ICollection.
            ICollection iCollection = new List<int>();
            //you can find IEnumerable[ i ] --> Index Based
            //you can NOT find ICollection[i]-- > Not Index Based

            //HashSet
            // Same as List but only single values are stored with duplicates.
            Console.WriteLine("HashSet");
            HashSet<int> ihashset = new HashSet<int>();
            ihashset.Add(1);
            ihashset.Add(1);
            ihashset.Add(1);
            foreach (var item in ihashset)
            {
                Console.WriteLine(item);
            }
            /*
             HashSet
             1
             */
            Console.WriteLine("HashSet-ex2");
            HashSet<Employee> emphashset = new HashSet<Employee>();
            emphashset.Add(new Employee { Id = 1, FName = "teja" });
            emphashset.Add(new Employee { Id = 2, FName = "teja" });
            emphashset.Add(new Employee { Id = 1, FName = "teja", LName = "l" });
            emphashset.Add(new Employee { Id = 1, FName = "teja", LName = "l" });
            Employee e1 = new Employee() { Id = 4, FName = "teja" };
            Employee e2 = new Employee() { Id = 2, FName = "teja" };

            if (emphashset.Count(x => x.Id == e1.Id && x.FName == e1.FName && x.LName == e1.LName) > 0)
            {
                Console.WriteLine("duplicates exist");
            }


            foreach (var item in emphashset)
            {
                Console.WriteLine(item.Id);
            }
            /*1.
             HashSet-ex2
              1
              2
              1
              public bool Equals(Employee other)
            {
                return this.Id == other.Id && this.FName == other.FName && this.LName == other.LName;
                //return this.Id == other.Id;
            }
             */
            /*2.
           HashSet-ex2
            1
            2
            public bool Equals(Employee other)
          {
              
              return this.Id == other.Id;
          }
           */
            /*3.
           HashSet-ex2
            1
            2
            1
            1
            NO Equals method is overridden in the Employee object class.
          }
           */
            //HashTable
            //key-value based,Non-Generic
            Console.WriteLine("HashTable");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 1);
            hashtable.Add("a", "teja");
            hashtable.Add(2.1, "teja1");
            hashtable.Add(3, "teja");
            hashtable.Remove(3);
            Console.WriteLine(hashtable[1]);//1
            Console.WriteLine(hashtable["a"]);//teja

            foreach (DictionaryEntry VARIABLE in hashtable)
            {
                Console.WriteLine(VARIABLE.Key + " " + VARIABLE.Value);
            }
            /*
             HashTable
                1
                teja
                // elements are retrieved in the stack order.LIFO
                2.1  teja1
                a teja
                1 1
             */

            //Dictionary
            //Key-value based,Generic
            Console.WriteLine("Dictionary");
            IDictionary<int, string> iDictionary = new Dictionary<int, string>();
            iDictionary.Add(1, "1");
            if (!iDictionary.ContainsKey(1))// Error contains same key if IF is not present.
            {
                iDictionary.Add(1, "1");
            }

            iDictionary.Add(3, "teja3");
            iDictionary.Add(2, "teja2");
            iDictionary.Remove(3);
            Console.WriteLine(iDictionary[2]);//teja2
            //Console.WriteLine(iDictionary[2]);Error Doesn't contains the key.
            foreach (var VARIABLE in iDictionary)
            {
                Console.WriteLine(VARIABLE.Key + " " + VARIABLE.Value);
            }

            /*             
            Dictionary
            teja2
            1 1
            2 teja2
             */
            //Stack. Generic and Non-Generic both are possible
            //LIFO->Last in First Out principle.
            Console.WriteLine("Stack");
            Stack stack = new Stack();
            Stack<int> stack1 = new Stack<int>();
            stack.Push(1);
            stack.Push("teja");
            stack.Push(5);
            Console.WriteLine(stack.Peek());//get's the top element in the stack.
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            /* Stack
             5
             5
             teja
             1
             */

            //Queue. Generic and Non-Generic both are possible
            //FIFO->First in First Out principle.
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            Queue<int> queue1 = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue("teja");
            Console.WriteLine(queue.Peek());//Gets the first element in the Queue.
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            /*
             Queue
             1
            1
            teja
             */

            List<Employee> e = new List<Employee>();
            e.Add(new Employee() { Id = 1, FName = "a", LName = "b" });
            e.Add(new Employee() { Id = 2, FName = "a", LName = "b" });
            e.Add(new Employee() { Id = 3, FName = "a", LName = "b" });

            Employee e3 = new Employee() { Id = 1, FName = "a", LName = "b" };
            Console.WriteLine(e3.GetHashCode());//33476626
            Employee e4 = new Employee() { Id = 1, FName = "a", LName = "b" };
            Console.WriteLine(e4.GetHashCode());//32854180          
            Employee e5 = new Employee() { Id = 3, FName = "a", LName = "b" };
            Console.WriteLine(e5.GetHashCode());//27252167
            Employee e6 = new Employee() { Id = 4, FName = "a", LName = "b" };
            Console.WriteLine(e6.GetHashCode());//43942917
            Employee e7 = e6;
            Console.WriteLine(e7.GetHashCode());//43942917 same as e6
            e6 = e5;
            Console.WriteLine(e5.GetHashCode());//27252167
            Console.WriteLine(e6.GetHashCode());//27252167
            Console.WriteLine(e7.GetHashCode());//43942917
            e5.Id = 2;
            Console.WriteLine(e5.Id);//2
            Console.WriteLine(e6.Id);//2
            Console.WriteLine(e7.Id);//4

            if (e.Contains(e3))//Checks the Equals method in the Employee class if it is oveeriden with return this.Id == other.Id && this.FName == other.FName && this.LName == other.LName; then it returns true else false.
            {
                Console.WriteLine("Yes");
            }
            if (e3 == e4)
            {
                Console.WriteLine("==");
            }
            if (e3.Equals(e4))
            {
                Console.WriteLine("equals");
            }
            if (e.Contains(e5))//Checks the Equals method in the Employee class
            {
                Console.WriteLine("Yes");
            }
            if (e5 == e6)//Compares the HashCode of the Code.
            {
                Console.WriteLine("==");
            }
            if (e5.Equals(e6))//Equals is not ovverriden also then it is true.
            {
                Console.WriteLine("equals");
            }
      
            //Equals,GetHashCode,ToString,GetType
            Console.WriteLine(e3.GetType());//ConsoleLearnings.LCollections+Employee

            Console.ReadKey();
        }

        class Employee : IComparable<Employee>//, IEquatable<Employee> 
        {
            public int Id { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }


            public override int GetHashCode()
            {
                return this.Id.GetHashCode();// ^ this.FName.GetHashCode() ^ this.LName.GetHashCode();
            }

            public bool Equals(Employee other)
            {
                return this.Id == other.Id && this.FName == other.FName && this.LName == other.LName;
                //return this.Id == other.Id;
            }

            //public override bool Equals(object obj)
            //{
            //    return base.Equals(obj);
            //}

            //IComparable Interface
            public int CompareTo(Employee other)
            {
                return this.Id.CompareTo(other.Id);
            }
        }
    }
}
