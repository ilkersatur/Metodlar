//iki tam sayı toplama 1
Console.WriteLine("İki sayı toplama");
int toplama(int s1, int s2)
{
    return s2 + s1;
}
Console.Write("s1=");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("s2=");
int s2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(toplama(s1, s2));

///////////////
//Dairenin alanı 2
Console.WriteLine("Daire alan hesapla");
double DaireAlan(int r)
{
    double pi = Math.PI;
    return r * r * pi;

}
Console.Write("r= ");
Console.WriteLine(DaireAlan(Convert.ToInt16(Console.ReadLine())));

/////////////
// büyük küçük sayı 3
Console.WriteLine("Sen değer gir ben hangisinin büyük olduğunun bulucam");
int KucukSayıBulma(int sa1, int sa2)
{
    int sonuc;

    if (sa1 > sa2)
    {
        return sa2;
    }
    else if (sa1 < sa2)
    {
        return sa1;
    }
    else
    {
        return sa1;
    }


}
Console.Write("sayi1 gir=");
int sa1 = Convert.ToInt16(Console.ReadLine());
Console.Write("sayi2 gir=");
int sa2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(KucukSayıBulma(sa1, sa2));
////////////
//string tersine çevirme 4
Console.WriteLine("Tersten yazdırma");
string TersYazma(string ifade)
{
    string toplama = "";
    for (int i = ifade.Length - 1; i >= 0; i--)
    {
        toplama += ifade[i];
    }
    return toplama;
}
Console.WriteLine("yazı yaz ben sana tersten yazdıracam");
string ifade = Console.ReadLine();
Console.WriteLine(TersYazma(ifade));
///////////////
//string tersine çevirme 5
Console.WriteLine("5 kere yaz");
void BesKezYazdir(string ifade2)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(ifade2);
    }


}
Console.WriteLine("yazı yaz");
string ifade2 = Console.ReadLine();
BesKezYazdir(ifade2);

////////
// 6.soru kaç kez dönsün yazı 6
Console.WriteLine("yazın istediğin kadar dönsün");
void KullanıcıBelirlemeliDöngü(int a, string b)
{
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine(b);
    }


}
Console.Write("kaç kere dönsün");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ne yazalım");
string b = Convert.ToString(Console.ReadLine());
KullanıcıBelirlemeliDöngü(a, b);
//tam sayı gelen dizileri toplayıp ekrana yazma 7
Console.WriteLine("dizileri topla yaz");
int Topla(int[] dizi)
{
    int toplam = 0;
    for (int i = 0; i < dizi.Length; ++i)
        toplam += dizi[i];
    return toplam;
}


int[] dizi = { 3, 3, 9, 7, 7, 1 };
double ortalama = (double)(Topla(dizi) / dizi.Length);
Console.WriteLine($"dizinin toplamı {Topla(dizi)}, dizinin ortlaması {ortalama}");
Console.WriteLine(dizi.Length);
/////////////////// 
///// dizi olarak gelen tam sayıları ekrana yazma 8
Console.WriteLine("ekrana dizileri yaz");
void DiziEkranaYaz(int[] seri)
{
    foreach (int item in seri)
    {
        Console.Write(item + " ");
    }

}
int[] seri = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
DiziEkranaYaz(seri);

// bir tanm sayı dizin boyutu ve içeriği rastgele oluşacak geriye dödüreecek 9
Console.WriteLine("rastgele dizi boyutu oluştur ve rastgele içeriğini belirle");
int[] RastegeleDizi()
{

    int[] dizi = new int[new Random().Next(1, 20)];
    for (int i = 0; i < dizi.Length; ++i)
        dizi[i] = new Random().Next(1, 20);
    return dizi;
}
foreach (int item in RastegeleDizi())
{
    Console.WriteLine(item);
}
Console.WriteLine(RastegeleDizi());
Console.WriteLine(Topla(RastegeleDizi()));   // rastegele dizi oluşturup bu diziyi bir önceki topla metoduna gönderme 
// iki tam sayi dizisini birleştirip geriye döndürme 10
Console.WriteLine("iki diziyi birleştiriyom");
int[] DiziBirlestir(int[] dizi1, int[] dizi2)
{
    int[] sonuc = new int[dizi1.Length + dizi2.Length];

    for (int i = 0; i < dizi1.Length; i++)
    {
        sonuc[i] = dizi1[i];
    }

    for (int i = 0; i < dizi2.Length; i++)
    {
        sonuc[dizi1.Length + i] = dizi2[i];
    }
    return sonuc;
}
int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] dizi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

DiziBirlestir(dizi1, dizi2);
DiziEkranaYaz(DiziBirlestir(dizi1, dizi2)); // ekrana yaz metodu ile bu metodu birleştirdik
foreach (int item in DiziBirlestir(dizi1, dizi2))
{
    Console.WriteLine(item);
}