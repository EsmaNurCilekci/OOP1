using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MüşteriManager
    {
        public void Kaydet ( Musteri musteri)
        {
            Console.WriteLine("Kişi başarıyla eklendi:" + musteri.Adı);
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Kişi başarıyla silindi:" + musteri.Adı);

        }

        public void Dondur (Musteri musteri)
        {
            Console.WriteLine("Kişi kaydı başarıyla donduruldu:" + musteri.Adı);

        }


    }
}
