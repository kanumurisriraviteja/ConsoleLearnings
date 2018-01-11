using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    class LCollections
    {
        //Array,ArrarList,List,IEnumerable,IQueryable,ICollection,HashTable,Dictionary,Queue,Stack.
        public static void MainCollections()
        {

            //Array
            //index based,Generic ,Fixed length.
            Console.WriteLine("Array");
            int[] iArray = new int[10];
            iArray[0] = 1;
            iArray[1] = 2;
            iArray[2] = 3;
            iArray[3] = 4;
            //int[] iArray = {1,2,3,4}
            foreach (var VARIABLE in iArray)
            {
                Console.WriteLine(VARIABLE);
            }

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


            //List
            //index based,Generic,Variable length
            List<int> iList = new List<int>();
            iList.Add(1);
            iList.Add(2);
            //List<int> iList = new List<int>() {1,2 };
            Console.WriteLine(iList[1]);
            foreach (var VARIABLE in iList)
            {
                Console.WriteLine(VARIABLE);
            }



            //IEnumerable.
            //index based,Generic,Variable length
            //no modification to be done.
            Console.WriteLine("IEnumerable");
            IEnumerable<int> iEnumerable = new List<int>() { 1, 2, 3, 4 };
            //iEnumerable.Add(1);//Error cant add to a IEnumerable.
            Console.WriteLine(iList[1]);
            foreach (var VARIABLE in iEnumerable)
            {
                Console.WriteLine(VARIABLE);
            }

            //IQueryable.
            //index based,Generic,Variable length
            //no modification to be done. holds good to get data filter through large records.
            Console.WriteLine("IQueryable");
            IQueryable<int> iQueryable = null;
            //iQueryable.Add(1);//Error cant add to a IEnumerable.
            foreach (var VARIABLE in iEnumerable)
            {
                Console.WriteLine(VARIABLE);
            }

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
            Console.WriteLine("HashSet-ex2");
            HashSet<Employee> emphashset = new HashSet<Employee>();
            emphashset.Add(new Employee { Id = 1, FName = "teja" });
            emphashset.Add(new Employee { Id = 2, FName = "teja" });
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
            //HashTable
            //key-value based,Non-Generic
            Console.WriteLine("HashTable");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 1);
            hashtable.Add("a", "teja");
            hashtable.Add(3, "teja");
            hashtable.Remove(3);
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable["a"]);
            Console.WriteLine(1);

            foreach (var VARIABLE in hashtable)
            {
                Console.WriteLine(hashtable[VARIABLE]);
            }

            //Dictionary
            //Key-value based,Generic
            Console.WriteLine("Dictionary");
            IDictionary<int, string> iDictionary = new Dictionary<int, string>();
            iDictionary.Add(1, "1");
            //iDictionary.Add(1,"1");Error contains same key
            iDictionary.Add(3, "teja3");
            iDictionary.Add(2, "teja2");
            iDictionary.Remove(3);
            Console.WriteLine(iDictionary[2]);
            //Console.WriteLine(iDictionary[2]);Error Doesn't contains the key.
            foreach (var VARIABLE in iDictionary)
            {
                Console.WriteLine(VARIABLE.Key + " " + VARIABLE.Value);
            }


            //Stack
            //LIFO->Last in First Out principle.
            Console.WriteLine("Stack");
            Stack stack = new Stack();
            Stack<int> stack1 = new Stack<int>();
            stack.Push(1);
            stack.Push("teja");
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            //Queue
            //FIFO->First in First Out principle.
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            Queue<int> queue1 = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue("teja");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            List<Employee> e = new List<Employee>();
            e.Add(new Employee() { Id = 1, FName = "a", LName = "b" });
            e.Add(new Employee() { Id = 2, FName = "a", LName = "b" });
            e.Add(new Employee() { Id = 3, FName = "a", LName = "b" });

            Employee e3 = new Employee() { Id = 1, FName = "a", LName = "b" };
            Employee e4 = new Employee() { Id = 1, FName = "a", LName = "b" };

            if (e.Contains(e1))
            {
                Console.WriteLine("Yes");
            }
            if (e1 == e2)
            {
                Console.WriteLine("==");
            }
            if (e1.Equals(e2))
            {
                Console.WriteLine("equals");
            }

            Console.WriteLine(e1.GetHashCode());
            Console.WriteLine(e1.GetType());
            Console.WriteLine(e2.GetHashCode());
            Console.WriteLine(e2.GetType());
            Console.ReadKey();
        }
      
        //}
        class Employee : IEquatable<Employee>, IComparable<Employee>
        {
            public int Id { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }


            public override int GetHashCode()
            {
                return this.Id.GetHashCode() ^ this.FName.GetHashCode() ^ this.LName.GetHashCode();
            }

            public bool Equals(Employee other)
            {
                return this.Id == other.Id && this.FName == other.FName && this.LName == other.LName;
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            //IComparable Interface
            public int CompareTo(Employee other)
            {
                return this.Id.CompareTo(other.Id);
            }
        }
    }
}
