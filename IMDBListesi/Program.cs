using System;
using System.Collections.Generic;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmler = new List<Film>();
        string devam;

        do
        {
            Console.Write("Film ismini girin: ");
            string isim = Console.ReadLine();

            Console.Write("IMDB puanını girin: ");
            double imdbPuani;

            while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0)
            {
                Console.Write("Geçerli bir IMDB puanı girin: ");
            }

            filmler.Add(new Film(isim, imdbPuani));

            Console.Write("Yeni bir film eklemek ister misiniz? (evet/hayır): ");
            devam = Console.ReadLine().ToLower();

        } while (devam == "evet");

        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        Console.WriteLine("\nIMDB Puanı 4 ile 9 Arasında Olan Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }

        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler ve IMDB Puanları:");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }
    }
}
