namespace OnlineRestoran
{
    public class Yemek
    {
        public string Ad { get; set; }
        public string Yapilisi { get; set; }
        public int Kisisayisi { get; set; }
        public int Sure { get; set; }
        public string Kod { get; set; }
        public string Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public int Kalori { get; set; }

        public Yemek(string ad, string yapilisi, int kisisayisi, int sure, string kod, string kategori, decimal fiyat, int kalori)
        {
            Ad = ad;
            Yapilisi = yapilisi;
            Kisisayisi = kisisayisi;
            Sure = sure;
            Kod = kod;
            Kategori = kategori;
            Fiyat = fiyat;
            Kalori = kalori;


        }
    }
    public class Menu
    {
        public List<Yemek> yemekler = new List<Yemek>();

        public void YemekEkle(Yemek yemek)
        {
            yemekler.Add(yemek);
        }

        public Yemek this[int index]
        {
            get {
                return yemekler[index]; 
            }
            set {
                yemekler[index] = value;
            }
        }

        public List<Yemek> Listele()
        {
            return yemekler;
        }
        

    }


    public class Musteri
    {
        public string Ad { get; set; }
        public List<Siparis> SiparisGecmisi { get; set; }

        public Musteri(string ad)
        {
            Ad = ad;
            SiparisGecmisi = new List<Siparis>();
        }

        public void SiparisEkle(Siparis siparis)
        {
            SiparisGecmisi.Add(siparis);
            Console.WriteLine(this.Ad + " isimli müşteriye " + siparis.SiparisYemegi.Ad + " siparişi eklendi.");
        }
        

        public void SiparisGecmisiniGoster()
        {
            Console.WriteLine("\n"+this.Ad+" isimli müşterinin sipariş geçmişi:");
            foreach (var siparis in SiparisGecmisi)
            {
                Console.WriteLine(siparis.SiparisYemegi.Ad+" - "+siparis.SiparisTarihi);
            }
        }

    }

    public class Siparis
    {
        public Yemek SiparisYemegi { get; set; }
        public DateTime SiparisTarihi { get; set; }

        public Siparis(Yemek yemek)
        {
            SiparisYemegi = yemek;
            SiparisTarihi = DateTime.Now;
        }
    }

    public class Restaurant
    {
        public Menu Menu { get; private set; }
        public List<Musteri> Musteriler { get;  set; }

        public Restaurant()
        {
            Menu = new Menu();
            Musteriler = new List<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            Musteriler.Add(musteri);
        }
        
    }


    public class GenericYonetici<T>
    {
        private List<T> koleksiyon = new List<T>();

        public void Ekle(T eleman)
        {
            koleksiyon.Add(eleman);
        }

        public List<T> Listele()
        {
            return koleksiyon;
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("<<< HELLO WORLD RESTAURANTINA HOŞ GELDİNİZ >>>");
            Restaurant sistem = new Restaurant();


            sistem.Menu.YemekEkle(new Yemek("Pizza", "Hamuru aç, malzemeleri ekle, fırına ver.", 4, 30, "001", "Fast Food", 50, 700));
            sistem.Menu.YemekEkle(new Yemek("Kebap", "Etleri şişe diz, közde pişir.", 2, 45, "002", "Ana Yemek", 70, 600));
            sistem.Menu.YemekEkle(new Yemek("Lahmacun", "Hamuru aç, kıymayı sür, taş fırında pişir.", 1, 20, "003", "Ara Sıcak", 25, 300));
            sistem.Menu.YemekEkle(new Yemek("Çorba", "Malzemeleri karıştır, kaynat.", 3, 15, "004", "Başlangıç", 15, 150));
            sistem.Menu.YemekEkle(new Yemek("Mantı", "Hamuru aç, kıymalı iç koy, haşla.", 4, 50, "005", "Ana Yemek", 60, 500));
            sistem.Menu.YemekEkle(new Yemek("Pide", "Hamuru aç, malzemeleri ekle, taş fırında pişir.", 2, 35, "006", "Fast Food", 40, 400));
            sistem.Menu.YemekEkle(new Yemek("Tavuk Şiş", "Tavukları şişe diz, közde pişir.", 2, 30, "007", "Ana Yemek", 55, 350));
            sistem.Menu.YemekEkle(new Yemek("Pilav", "Pirinçleri yıka, pişir.", 4, 20, "008", "Yan Yemek", 20, 250));
            sistem.Menu.YemekEkle(new Yemek("Salata", "Sebzeleri doğra, karıştır.", 4, 10, "009", "Yan Yemek", 15, 100));
            sistem.Menu.YemekEkle(new Yemek("Dondurma", "Servis yap.", 1, 5, "010", "Tatlı", 10, 200));
            sistem.Menu.YemekEkle(new Yemek("Sarma", "Yaprakları sar, haşla.", 5, 60, "011", "Ara Sıcak", 50, 400));
            sistem.Menu.YemekEkle(new Yemek("Künefe", "Kadayıfı hazırla, pişir.", 2, 25, "012", "Tatlı", 40, 500));
            sistem.Menu.YemekEkle(new Yemek("Burger", "Ekmeği hazırla, köfteyi pişir.", 1, 20, "013", "Fast Food", 45, 650));
            sistem.Menu.YemekEkle(new Yemek("Balık Izgara", "Balığı temizle, ızgarada pişir.", 3, 30, "014", "Ana Yemek", 80, 400));
            sistem.Menu.YemekEkle(new Yemek("Sütlaç", "Pirinç ve sütü kaynat.", 4, 30, "015", "Tatlı", 20, 300));
            sistem.Menu.YemekEkle(new Yemek("Baklava", "Kat kat aç, şerbetle.", 8, 90, "016", "Tatlı", 100, 800));
            sistem.Menu.YemekEkle(new Yemek("Köfte", "Kıymayı yoğur, şekil ver, pişir.", 3, 25, "017", "Ana Yemek", 50, 400));
            sistem.Menu.YemekEkle(new Yemek("Tantuni", "Etleri kavur, lavaşa sar.", 2, 15, "018", "Fast Food", 30, 300));
            sistem.Menu.YemekEkle(new Yemek("Çiğ Köfte", "Malzemeleri yoğur.", 6, 40, "019", "Ara Sıcak", 35, 350));
            sistem.Menu.YemekEkle(new Yemek("Gözleme", "Hamuru aç, iç harcı koy, pişir.", 2, 20, "020", "Fast Food", 25, 400));
            sistem.Menu.YemekEkle(new Yemek("Omlet", "Yumurtayı çırp, tavada pişir.", 1, 10, "021", "Kahvaltı", 10, 200));
            sistem.Menu.YemekEkle(new Yemek("Suşi", "Pirinç ve balığı sar.", 2, 50, "022", "Deniz Ürünleri", 100, 500));
            sistem.Menu.YemekEkle(new Yemek("Makarna", "Makarnayı haşla, sos ekle.", 2, 15, "023", "Ana Yemek", 25, 300));
            sistem.Menu.YemekEkle(new Yemek("Tavuk Kanat", "Kanatları marine et, pişir.", 3, 40, "024", "Ara Sıcak", 60, 450));
            sistem.Menu.YemekEkle(new Yemek("Kumpir", "Patatesi pişir, malzeme ekle.", 1, 30, "025", "Fast Food", 35, 500));

            Musteri musteri1 = new Musteri("Ali");
            sistem.MusteriEkle(musteri1);

            Musteri musteri2 = new Musteri("Ayşe");
            sistem.MusteriEkle(musteri2);

            Console.WriteLine("\n");
            Console.WriteLine("MENÜ");
            foreach (var yemek in sistem.Menu.Listele())
            {
                Console.WriteLine("Kod:"+yemek.Kod+ " "+"Yemek:"+" "+yemek.Ad+"Fiyat:"+" "+ yemek.Fiyat+ "TL");
            }

            bool devamEt = true;

            while (devamEt)
            {
                Console.WriteLine("İsmizi giriniz:");
                string musteriAdi = Console.ReadLine();

                Musteri secilenMusteri = null;
                foreach (var musteri in sistem.Musteriler)
                {
                    if (musteri.Ad == musteriAdi)
                    {
                        secilenMusteri = musteri;
                        break;
                    }
                }

                if (secilenMusteri == null)
                {
                    Console.WriteLine("Böyle bir müşteri bulunamadı. Lütfen geçerli bir müşteri adı girin.");
                    continue;
                }

                Console.WriteLine("Sipariş vermek istediğiniz yemeğin kodunu girin:");
                string yemekKodu = Console.ReadLine();

                Yemek secilenYemek = null;
                foreach (var yemek in sistem.Menu.Listele())
                {
                    if (yemek.Kod == yemekKodu)
                    {
                        secilenYemek = yemek;
                        break;
                    }
                }

                if (secilenYemek == null)
                {
                    Console.WriteLine("Böyle bir yemek bulunamadı. Lütfen doğru bir kod girin.");
                    continue;
                }

                Siparis yeniSiparis = new Siparis(secilenYemek);
                secilenMusteri.SiparisEkle(yeniSiparis);

                Console.WriteLine("Sipariş başarıyla eklendi!");

                secilenMusteri.SiparisGecmisiniGoster();

                Console.WriteLine("\nBaşka bir sipariş vermek ister misiniz? (E/H):");
                string cevap = Console.ReadLine();

                if (cevap == null || cevap != "E" && cevap != "e")
                {
                    devamEt = false;
                }

            }

            Console.WriteLine("Siparişiniz sonlandırılmıştır. Bizi tercih ettiğiniz için teşekkür ederiz!");

        }
    }
}