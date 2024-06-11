using System.Collections;
using System.Collections.Generic;

namespace _9.C__CollectionsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List +
            //Dictionary +
            //SortedList +
            //Stack +
            //Queue +

            //Func<int, long> func = foo;
            //long foo (int a) { return 1; }

            //int[] array = { 1, 2, 3, 4, 5 };
            //int[] array1 = { 12, 20, 34, 14, 15 };

            //Console.WriteLine("List : ");
            //List<string> list = new List<string>();
            //list.Add("C# is High Level Programming Language !");
            //list.ForEach(x => Console.WriteLine(x));
            //List<int> list1 = new List<int>(array);
            //list1.Add(11);
            //list1.Add(90);
            //list1.AddRange(array1);
            //list1.ForEach(x1 => Console.Write($"{x1} "));
            //Console.WriteLine($"\nAverage : {list1.Average()}");
            //list1.Clear();
            //list1.ForEach(x4 => Console.WriteLine(x4));
            
            /////////////////////////////////////

            //Console.WriteLine("Dictionary : ");
            //Dictionary<string, int> Dictionary = new Dictionary<string, int>()
            //{
            //    { "Name", 100 },
            //    { "Name1", 70 },
            //    { "Name2", 100 },
            //    { "Name3",81 }
            //};
            //Dictionary<string, int> select80 = Dictionary.Where(result => result.Value >= 70).ToDictionary(result => result.Key, result => result.Value);
            //foreach (var study in select80)
            //{
            //    Console.WriteLine($"{study.Key}: {study.Value}");
            //}
            //Console.WriteLine();
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "NAME");
            //dict.Add(2, "NAME1");
            //dict.Add(3, "NAME2");
            //dict.Add(4, "NAME3");
            //dict.Remove(2);
            //dict.Remove(3);
            //Console.WriteLine(dict.Equals(dict));
            //dict.SimpleMethod();

            //Stack
            //Console.WriteLine("Stack : ");
            //int[] arr = {1,2,3,23,12,32,24};

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Pop();
            //bool hundred = stack.All(item => item < 10);
            //Console.WriteLine(hundred);
            //stack.CopyTo(arr,0);
            //Console.WriteLine(stack.Count());
            //Console.WriteLine(stack.Contains(6));
            //Console.WriteLine(stack.Contains(1));
            //foreach (var item in stack)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //foreach (var item1 in arr)
            //{
            //    Console.Write($"{item1} ");
            //}

            ///////////////////Queue

            //Console.WriteLine("Queue");
            //Queue<string> queue = new();
            //queue.Enqueue("Hello World");
            //queue.Enqueue("Hello Mars");
            //queue.Enqueue("Hello Uranus");
            //queue.Dequeue();
            //string total = queue.ToArray().Aggregate((a, c) => a + c);
            //Console.WriteLine("Simple Aggregate: " + total);
            //foreach(string item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            ////SortedList

            //Console.WriteLine("SortedList :");

            //SortedList SortedList = new SortedList();

            //SortedList.Add("C", "C#");
            //SortedList.Add("A", "Python");
            //SortedList.Add("B", "Java");
            //SortedList.Add("E", "C++");
            //SortedList.Add("D", "CSS");
            //SortedList.Remove("D");
            //foreach (dynamic result in SortedList)
            //{
            //    Console.WriteLine(result.Key + ": " + result.Value);
            //}
        }
    }
}
