using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierss
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calısan calısan1 = new Calısan();
            calısan1.Ad = "Ali";
            calısan1.Soyad = "Şeker";
            calısan1.No = 34356534;
            calısan1.Departman = "Satın Alma";
            calısan1.CalısanBilgileri();
            Console.WriteLine("**********");

           
            Calısan calısan2 = new Calısan();

            calısan2.Ad = "Veli";
            calısan2.Soyad = "Kısmet";
            calısan2.No = 7845902;
            calısan2.Departman = "İnsan Kaynakları";
            calısan2.CalısanBilgileri();
            Console.WriteLine("**********");

            Console.ReadLine();
        }
    }


    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın adı :{0}", Ad);
            Console.WriteLine("Çalışanın soyadı :{0}", Soyad);
            Console.WriteLine("Çalışanın numarası :{0}", No);
            Console.WriteLine("Çalışanın departmanı :{0}", Departman);
        }

    }
    
}
