using System;
using System.Collections.Generic;
namespace PratikWhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir limit giriniz :"); 
            int limit;
            bool result = int.TryParse(Console.ReadLine(), out limit); // Kullanıcıdan bir limit değeri alınır bu sayı ise result true döner değilse hata mesajı gelir

            if (result) 
            {
                Console.WriteLine("Yapılacak işlemi seçin While-DoWhile");                
                int sayac = 0;

                switch (Console.ReadLine()) // Kullanıcıdan alınan input switch-case girer ve While-DoWhile işlemlerine göre bir döngüye girer.
                {
                    case "While": // Kullanıcı While girdiyse While döngüsü çalışır.
                        while (sayac <= limit)
                        {
                            Console.WriteLine($"{sayac} Ben bir Patika'lıyım");
                            sayac++;
                        }
                        break;

                    case "DoWhile": // Kullanıcı DoWhile girdiyse Do-While döngüsü çalışır.
                        do
                        {
                            Console.WriteLine($"{sayac} Ben bir Patika'lıyım");
                            sayac++;
                        } while (sayac <= limit);
                        break;

                    default: // Kullanıcı başka bir işlem seçerse hata mesajı ile karşılaşır.
                        Console.WriteLine("Geçerli bir işlem girmediniz.");
                        break;
                }
            }

            else
                Console.WriteLine("Geçerli bir sayı girmediniz.");

            // Sonuç olarak 
            // While    -> 10 sayısını input olarak kullanırsak 11 kez çıktı alırız. -5 sayısını input alırsak çıktı alamayız.
            // DoWhile  -> 10 sayısını input olarak kullanırsak 11 kez çıktı alırız. -5 sayısını input alırsak 1 kez çıktı alırız. (DoWhile En az 1 kere çalışır.)
        }
    }
}