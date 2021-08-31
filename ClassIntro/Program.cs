using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Raşit";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat";
            kurs4.İzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " - " + kurs1.Egitmen + " - " + kurs1.İzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " +  kurs.İzlenmeOrani);
                
            };




        }
    }
}

class Kurs 
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int İzlenmeOrani { get; set; }

}