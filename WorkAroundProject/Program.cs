using System;

namespace WorkAroundProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();
            Console.ReadLine();
        }
        public void Degiskenler()
        {
            string mesaj = "Salam";
            double tutar = 100000; // from db
            int say = 100;
            bool isAuthenticated = false;


            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.19);
            Console.WriteLine(say);
            Console.WriteLine(mesaj);
            Console.WriteLine(isAuthenticated);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string soyad { get; set; }
        public int il {get; set;}
        public long tcNo { set; get; };
    }
}
