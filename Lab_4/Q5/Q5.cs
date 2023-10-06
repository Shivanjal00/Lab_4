using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Q5
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            var Collection = new CustomList<String>();
            Collection[0] = "A";
            Collection[1] = "B";
            Collection[2] = "C";
            Collection[3] = "D";
            Collection[4] = "E";
            Console.WriteLine("Z's Friendlist : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Collection[i]);
        }
    }
    class CustomList<T>
    {
        private T[] list = new T[5];
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}
