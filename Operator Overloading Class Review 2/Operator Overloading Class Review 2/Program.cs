using System;

namespace Operator_Overloading_Class_Review_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringList list = new StringList();
            list.Add("Fidash");
            list.Add("Fidush");

            list.GetAll(); 

            IntList list1 = new IntList();
            list1.Add(13);

            list1.GetAll();
        }
    }

    public class StringList
    {
        private string[] arr;

        public StringList()
        {
            arr = new string[0];

        }

        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class IntList
    {
        private int[] arr;

        public IntList()
        {
            arr = new int[0];

        }

        public void Add(int m)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = m;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}