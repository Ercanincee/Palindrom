Console.WriteLine("polindrom sayiyi bulma uygulamasina hosgeldiniz");
string girilendeger = Console.ReadLine();
int duz = 0;
int ters = girilendeger.Length - 1;
while (duz < ters)
{
    if (girilendeger[duz] == girilendeger[ters]) 
    {   duz++;
        ters--;
    }
    else {
        Console.WriteLine("Girdiginiz Deger Polindrom Degildir");
        break; }
    Console.WriteLine("Evet Polindrom bir deger Girdiniz");
}

