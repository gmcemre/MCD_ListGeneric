using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist Generic Versiyonu

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            // <T> : T tipi demek .NET Framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek.

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            //listeGeneric.Add("emre");

            for (int i = 0; i < listeGeneric.Count ; i++)
            {
                Console.WriteLine(listeGeneric [i]);
            }

            
            List<string> isimler = new List<string>();
            isimler.Add("Emre");
            isimler.Add("Elif");
            isimler.Add("Serkan");
            //isimler.Add(123);

            for (int i = 0; i < isimler .Count ; i++)
            {
                Console.WriteLine(isimler [i]);
            }

            List<Musteri> musteriListe = new List<Musteri>() ;
            musteriListe.Add(new Musteri()
            {
                id=1,
                isim ="emre",
                soyisim ="gemici"
            });

            foreach (Musteri  item in musteriListe )
            {
                Console.WriteLine(item .isim);
            }


            Console.ReadKey();
        }
    }
}
