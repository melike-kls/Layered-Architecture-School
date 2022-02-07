using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Öğrenci Adı Giriniz:");
            ogr.Ad = Console.ReadLine();

            Console.WriteLine("Soyad Giriniz:");
            ogr.Soyad = Console.ReadLine();

            Console.WriteLine("Numara Giriniz:");
            ogr.Numara = Console.ReadLine();

            ogr.Sinifid = 1;

            OgrenciBL obl = new OgrenciBL();
            
            Console.WriteLine(obl.Kaydet(ogr)?"Başarılı":"Başarısız!");
        }
    }
}
