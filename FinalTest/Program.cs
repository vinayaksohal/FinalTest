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
            FinalTest<int> finaltest = new FinalTest<int>();
            finaltest.AddToCollection(11);
            finaltest.AddToCollection(2);
            finaltest.AddToCollection(3);
            finaltest.AddToCollection(10);
            finaltest.AddToCollection(14);

            FinalTest<char> finaltest2 = new FinalTest<char>();
            finaltest2.AddToCollection('v');
            finaltest2.AddToCollection('a');
            finaltest2.AddToCollection('b');
            finaltest2.AddToCollection('v');
            finaltest2.AddToCollection('c');


            Console.WriteLine(finaltest.GetItemFromCollection(1));

            Console.WriteLine();
            Console.WriteLine("----Displaying List in Decending order---");
            finaltest.SortDispaly();
            finaltest2.SortDispaly();


            FinalTest<float> finaltest1 = new FinalTest<float>();
       
        }
    }


    //public class SortList<T> : IComparer<T> where T:struct
    //{
    //    public int Compare(T x, T y)
    //    {
    //        if (x == 0 || y == )
    //        {
    //            return 0;
    //        }

    //        // CompareTo() method 
    //        return x.CompareTo(y);

    //    }
    //}


    public class FinalTest<T> where T: struct
    {
        private List<T> PrivateGenericCollection;

        public FinalTest()
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

        public void SortDispaly()
        {

            //SortList<T> sl = new SortList<T>;

            this.PrivateGenericCollection.Sort();
            this.PrivateGenericCollection.Reverse();

            foreach(T g in PrivateGenericCollection)
            {
                Console.WriteLine(g);
            }
        }
    }

}
