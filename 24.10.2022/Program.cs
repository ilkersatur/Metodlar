//metods
//functions
// programlama dillerinin gelişimi
//1- sıralı programlama dilleri
//2-fonksiyonel programlama dilleri (c,pascal)  -------- kütüphane kavramı gelmiştir
//3- oop

// metodların tanımlanması 

void Yaz(){
    Console.WriteLine("ilker");
    }
// metodun çağrılması
Yaz();

// metod yazmak için parametre ve return type belirle
//  parametre değişkendir
// return sonuçtur , örneğin f(parametre)=sonuc
// parametreler parantezin içine tanımlanır

// geriye değer döndüren metodlar çağırıldığı yere değer aktarır , eğer değer aktarmıyor ise değer döndürmeyen metod ya da fonkisyon denir

// metodun kalıbı------- retunType MetodunAdi(parametreler)
//                         {...............;
//                         }
// eğer bir metod geriye değer döndürmeyecek ise "void" yazılır
// eğer geriye değer döndürecek ise hangi tip değer döndürecekse o tip değer yazılır

void Islem(int s1, int s2)
{
    // geri değer döndürmeyen iki tam sayı parametreli metod
}

// int sayi1,sayi2 parametreler bu şekilde tanımlanamaz, her zaman parantez içinde tanımlanır

double PISayisi()
{
    // geriye dönecek değiri return ile belirtiriz
    return 3.1415;  // bir metotda birden fazla return olabilir ama en az bir tane olmak zorunda
}
