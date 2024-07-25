using OgfenciYonetimApp;
using System.Threading.Channels;

List<Ogrenci> ogrenciler = new List<Ogrenci>();
while (true)
{
    Console.Clear();
    Console.WriteLine("Öğrenci Tönetim Uygulaması");
    Console.WriteLine("1-Öğrenci Ekle");
    Console.WriteLine("2-Öğrenci Güncell");
    Console.WriteLine("3-Öğrenci Sil");
    Console.WriteLine("4-Öğrencileri Listele");
    Console.WriteLine("5-Çıkış Yap");
    Console.Write("Seçimini Yap: ");
    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            OgrenciEkle(ogrenciler);
            break;

        case 2:
            OgrenciGuncelle(ogrenciler);
            break;

        case 3:
            OgrenciSil(ogrenciler);
            break;

        case 4:
            OgrencileriListele(ogrenciler);
            break;

        case 5:
            Console.WriteLine("Çıkış Yapılıyor...");
            return;

        default:
            Console.WriteLine("Geçersiz Seçim!");
            break;
    }
    Console.WriteLine("Devam etmek için bir tuşa basın.");
    Console.ReadKey();
}

static void OgrenciEkle(List<Ogrenci> ogrenciler)
{
    Console.Write("Öğrenci Numarası: ");
    int numara = int.Parse(Console.ReadLine());
    Console.Write("Öğrenci Adı: ");
    string ad = Console.ReadLine();
    Console.Write("Öğrenci Soyadı: ");
    string soyad = Console.ReadLine();
    Console.Write("Öğrenci Yaşı: ");
    int yas = int.Parse(Console.ReadLine());

    ogrenciler.Add(new Ogrenci { Numara = numara, Ad = ad, Soyad = soyad, Yas = yas });
    Console.WriteLine("Öğrenci başarıyla eklendi.");
}
static void OgrenciGuncelle(List<Ogrenci> ogrenciler)
{
    Console.WriteLine("Güncellemek istediğiniz öğrencinin numarasını giriniz: ");
    int numara = int.Parse(Console.ReadLine());

    Ogrenci ogrenci = ogrenciler.Find(o => o.Numara == numara);
    if (ogrenci != null)
    {
        Console.WriteLine("Yeni Adı: ");
        ogrenci.Ad = Console.ReadLine();
        Console.WriteLine("Yeni Soyadı: ");
        ogrenci.Soyad = Console.ReadLine();
        Console.WriteLine("Yeni Yaşı: ");
        ogrenci.Yas = int.Parse(Console.ReadLine());
        if (true)
        {
            string deger = "Öğrenci Bilgileri Başarıyla Güncellenmiştir.";
            Console.WriteLine(deger);
        }
    }
    else
        Console.WriteLine("Öğrenci bulunamadı.");
}
static void OgrenciSil(List<Ogrenci> ogrenciler)
{
    Console.WriteLine("Silmek istediğiniz öğrencinin numarasını giriniz: ");
    int numara = int.Parse(Console.ReadLine());

    Ogrenci ogrenci = ogrenciler.Find(o => o.Numara == numara);
    if (numara != null)
    {
        ogrenciler.Remove(ogrenci);
        Console.WriteLine("Öğrenci başarıyla silinmiştir.");
    }
    else Console.WriteLine("Öğrenci bulunamadı");
}
static void OgrencileriListele(List<Ogrenci> ogrenciler)
{
    Console.WriteLine("Öğrenci Listesi:");
    foreach (Ogrenci o in ogrenciler)
        Console.WriteLine($"Ad: {o.Ad} \nSoyad: {o.Soyad} \nYaş {o.Yas} \nNumara: {o.Numara}");
}