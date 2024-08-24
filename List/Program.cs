using System;
class Program
{
    static void Main()
    {
        List<string> ziyaretciİsimleri = new List<string>();

        ziyaretciİsimleri.Add("Bülent Ersoy");
        ziyaretciİsimleri.Add("Ajda Pekkan");
        ziyaretciİsimleri.Add("Ebru Gündeş");
        ziyaretciİsimleri.Add("Hadise");
        ziyaretciİsimleri.Add("Hande Yener");
        ziyaretciİsimleri.Add("Tarkan");
        ziyaretciİsimleri.Add("Funda Arar");
        ziyaretciİsimleri.Add("Demet Akalın");

        Console.WriteLine("**Davetliler**");

        foreach(string isim in ziyaretciİsimleri)
        {
            Console.WriteLine(isim);
        }





    }
}