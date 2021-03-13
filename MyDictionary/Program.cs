using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customer = new MyDictionary<int, string>();

            customer.Add(1, "Yasir");
            customer.Add(2, "Ahmet");
            customer.Add(3, "Ayşe");

            customer.List();

        }
    }
}