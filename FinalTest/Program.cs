using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class SortList<T> : IComparer<T> where T:struct
    {
        public int Compare(T x, T y)
        {
            if (x == 0 || y == )
            {
                return 0;
            }

            // CompareTo() method 
            return x.CompareTo(y);

        }
    }


    public class FinalTest<T> where T: struct
    {
        private List<T> PrivateGenericCollection;

        FinalTest()
        {
            PrivateGenericCollection = new List<T>();
        }

        public void AddToCollection(T element)
        {
            PrivateGenericCollection.Add(element);
        }

        public T GetItemFromCollection(int index)
        {
            return PrivateGenericCollection.ElementAt(index);
        }

        public void Sort(List<T> l)
        {
            List<T> SortedList = new List<T>(l);

            SortList<T> sl = new SortList<T>;

            SortedList.Sort();

            foreach(T g in SortedList)
            {
                Console.WriteLine(g);
            }
        }
    }

}
