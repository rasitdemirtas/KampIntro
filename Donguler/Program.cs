using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamay başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "pyhton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = new string[] { "Yazılım geliştirici Yetiştirme Kampı" ,
                "Programlamay başlangıç için temel kurs",
            "java", "pyhton"};



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            {

            }
        }
    }
}
