using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            string müsteriAdı = "Esma";
            string müsteriSoyadı = "Çilekçi";
            int müsteriId = 1;

            string[] müsteri = new string[] { };

            
            Musteri musteri1 = new Musteri();

            musteri1.Adı ="Esma";
            musteri1.Soyadı = "Çilekçi";
            musteri1.Id = 1;


            Musteri musteri2 = new Musteri();

            musteri2.Adı = "Ayşe";
            musteri2.Soyadı = "Çilekçi";
            musteri2.Id = 2;


            Musteri musteri3 = new Musteri();
         
            musteri3.Adı = "Ceylin";
            musteri3.Soyadı = "Kaya";
            musteri3.Id = 3;

            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var item in musteri)
            {
                Console.WriteLine(item.Adı);
                Console.WriteLine(item.Soyadı);
                Console.WriteLine(item.Id);
            }
        }
    }
}
