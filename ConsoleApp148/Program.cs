using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = “Hesap Makinesi”;
            string secim;
            double sonuc;
            int sayi1, sayi2;
            Console.WriteLine(“1.TOPLAMA—> T”);
            Console.WriteLine(“2.ÇIKARMA—> C”);
            Console.WriteLine(“3.ÇARPMA —> R”);
            Console.WriteLine(“4.BÖLME —> B “);
            Console.WriteLine(“—————“);
            Console.Write(“İşlem tipinizi seçiniz(T - C - R - B):”);
            secim = Console.ReadLine();

            
        
switch (secim)
            {
                case “T”:
Console.Clear();
                    Console.WriteLine(“********************************”);
                    Console.WriteLine(“*Seçilen işlem TOPLAMA işlemi *”);
                    Console.WriteLine(“********************************”);
                    Console.Write(“1.Sayıyı giriniz:”);
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(“2.Sayıyı giriniz:”);
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    sonuc = sayi1 + sayi2;
                    Console.Write(“Sonuç ={ 0}”, sonuc);
                    break;
                case “C”:
Console.Clear();
                    Console.WriteLine(“********************************”);
                    Console.WriteLine(“*Seçilen işlem ÇIKARMA işlemi *”);
                    Console.WriteLine(“********************************”);
                    Console.Write(“1.Sayıyı giriniz:”);
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(“2.Sayıyı giriniz:”);
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    sonuc = sayi1 – sayi2;
                    Console.Write(“Sonuç ={ 0}”, sonuc);
                    break;
                case “R”:
Console.Clear();
                    Console.WriteLine(“********************************”);
                    Console.WriteLine(“*Seçilen işlem ÇARPMA işlemi *”);
                    Console.WriteLine(“********************************”);
                    Console.Write(“1.Sayıyı giriniz:”);
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(“2.Sayıyı giriniz:”);
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    sonuc = sayi1 * sayi2;
                    Console.Write(“Sonuç ={ 0}”, sonuc);
                    break;
                case “B”:
Console.Clear();
                    Console.WriteLine(“********************************”);
                    Console.WriteLine(“*Seçilen işlem ÇIKARMA işlemi *”);
                    Console.WriteLine(“********************************”);
                    Console.Write(“1.Sayıyı giriniz:”);
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(“2.Sayıyı giriniz:”);
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    switch (sayi2)
                    {
                        default:
                            sonuc = sayi1 / sayi2;
                            Console.Write(“Sonuç ={ 0}”, sonuc);
                            break; 
                        case 0:
                            Console.WriteLine(“!!!SIFIRA BÖLME HATASI!!!”);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine(“T - C - R - B ‘den farklı bir değer girdiniz…”);
                    break;
            }

            Console.ReadKey();
        }
    }
}

 