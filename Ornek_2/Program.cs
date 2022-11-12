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