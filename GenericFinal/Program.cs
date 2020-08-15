using System;
using System.Collections.Generic;

namespace GenericFinal
{
    public class Program<T> where T: struct
    {
        private List<T> MyDatas { get; set; }
        public List<T> AddData(T t) {
            MyDatas.Add(t);
            return MyDatas;
        
        }
        public List<T> GetData() {
            return MyDatas.GetRange(3, 1);
        
        }

        public List<T> GetSorted()
        {
            MyDatas.Sort();
            MyDatas.Reverse();
            return MyDatas;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


      
    }
}
