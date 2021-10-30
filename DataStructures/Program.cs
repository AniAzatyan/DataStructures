using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------Stack--------------------");

            Stack<int> myStack = new Stack<int>();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Peek();

            foreach (var item in myStack)
                Console.WriteLine(item + ", ");

            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack1 = new Stack<int>(arr);

            foreach (var item in myStack1)
                Console.WriteLine(item + ",  ");

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop() + ",");

            Console.WriteLine(myStack1.Contains(2));
            Console.WriteLine(myStack1.Contains(10));

            Console.WriteLine("--------------------------Queue--------------------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var id in queue)
                Console.Write(id);

            queue.Contains(2);
            queue.Contains(10);

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("C");
            strQ.Enqueue("o");
            strQ.Enqueue("n");
            strQ.Enqueue("t");
            strQ.Enqueue("r");
            strQ.Enqueue("o");
            strQ.Enqueue("l");

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            Console.WriteLine(strQ.Peek());

            Console.WriteLine("--------------------------SortedList--------------------");
            SortedList<int, string> sortedlist = new SortedList<int, string>();

            sortedlist.Add(1, "Sunday");
            sortedlist.Add(3, "Tuesday");
            sortedlist.Add(2, "Monday");
            sortedlist.Add(4, "Wednesday");
            sortedlist.Add(6, "Friday");
            sortedlist.Add(5, "Thusday");
            sortedlist.Add(7, "Saturday");
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("The capacity is:" + sortedlist.Capacity);
            sortedlist.Clear();
            Console.WriteLine("The capacity is:" + sortedlist.Capacity);

            Console.WriteLine("--------------------------HashTable--------------------");
            Hashtable hashTable = new Hashtable();
            hashTable.Add("1", "Anna");
            hashTable.Add("2", "Narine");
            hashTable.Add("3", "Suren");
            hashTable.Add("4", "Arthur");
            ICollection key = hashTable.Keys;
            Console.WriteLine("Elements: ");
            Console.WriteLine();
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + hashTable[k]);
            }
            hashTable.Remove(3);
            hashTable.Remove(2);
        }
    }
}