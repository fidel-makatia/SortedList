using System;

using System.Collections.Generic;

namespace SortedList__
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> myList = new SortedList<int, string>()
            {
                {101,"fIDEL" },
                 {103, "GGG" },
                {102, "Makatia" },
               
                {105,"KUKU" }
            };

            myList.Add(107, "lilo");
            


            foreach(var item in myList)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }
        }
    }
}
