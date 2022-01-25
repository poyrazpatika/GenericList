using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> Object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve listForeach
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma
            sayiListesi.Remove(4); // eleman ile çıkarma
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0); // index ile çıkarma
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu");
            }

            // Elemanın indeksini bulma
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi list'e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi temizleme
            hayvanListesi.Clear();

            // Liste içerisinde nesne tutma.
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim="Deniz",
                Soyisim="Arda",
                yas=24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yas:" + kullanıcı.yas);
            }
            yeniListe.Clear();

        }
    }
    public class Kullanıcılar
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int yas { get; set; }

    }
}
