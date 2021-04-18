using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_method
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add(" seniors");
            myList.Add(" juniors");
            myList.Add(" mca ");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Sort();
            Console.WriteLine("\after sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Remove("seniors");
            Console.WriteLine("\removing seniors");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Insert(2,"Lecturers");
            Console.WriteLine("\n Inserting Lecturers at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}
