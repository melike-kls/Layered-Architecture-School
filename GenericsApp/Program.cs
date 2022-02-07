using System;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Deneme<int> d = new Deneme<int>(); 
        }
    }

    class Deneme<T>
    {
        public T veri;

        public Deneme()
        {
            Console.WriteLine(typeof(T));
        }

        public void Metod(T parameter)
        {

        }
    }
}
