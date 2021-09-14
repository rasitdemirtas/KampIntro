using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Raşit");
            MyList<int> yas = new MyList<int>();
            yas.Add(19);

            Console.WriteLine("Hello World!");
        }
    }
}
