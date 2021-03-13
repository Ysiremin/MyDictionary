using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] Id;
        T2[] Name;

        public MyDictionary()
        {
            Id = new T1[0];
            Name = new T2[0];
        }

        public void Add(T1 id ,T2 name)
        {
            T1[] tempArray1 = Id;
            T2[] tempArray2 = Name;

            Id = new T1[Id.Length + 1];
            Name = new T2[Name.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                Id[i] = tempArray1[i];
                Name[i] = tempArray2[i];
            }

            Id[Id.Length - 1] = id;
            Name[Id.Length - 1] = name;
        }

        public void List()
        {
            for (int i = 0; i < Id.Length; i++)
            {
                Console.WriteLine("Id: " + Id[i] + " - Name: " + Name[i]);
            }
        }
    }
}
