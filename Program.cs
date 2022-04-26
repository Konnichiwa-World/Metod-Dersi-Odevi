using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Lütfen konu seçiniz: 1- Cebir 2-Geometri");
            Int32 x =Int32.Parse(Console.ReadLine());
            switch(x){
                case 1:

                System.Console.WriteLine("1- Topla 2-Çıkar 3-Böl 4-Çarp 5-Kalanı ver. 6-Little little in the middle");
                Int32 a =Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("İki sayi giriniz:");
                Int32 y =Int32.Parse(Console.ReadLine());
                Int32 z =Int32.Parse(Console.ReadLine());
                switch(a){
                case 1: Topla(y,z);
                return;
                case 2: Cikarma(y, z);
                return;
                case 3: Bolme(y, z);
                return;
                case 4: Carpma(y, z);
                return;
                case 5: Kalan(y, z);
                return;
                case 6: Middle(y, z);
                return;}
                return;

                static void Topla(int y, int z){int yz1=y+z;System.Console.WriteLine(yz1);return;}
                static void Cikarma(int y, int z){int yz2=y-z;System.Console.WriteLine(yz2);return;}
                static void Bolme(int y, int z){int yz3=y/z;System.Console.WriteLine(yz3);return;}
                static void Carpma(int y, int z){int yz4=y*z;System.Console.WriteLine(yz4);return;}
                static void Kalan(int y, int z){int yz5=y%z;System.Console.WriteLine(yz5);return;}
                static void Middle(int y, int z){
                int yz1=y+z;System.Console.WriteLine("Toplam=" + yz1);
                int yz2=y-z;System.Console.WriteLine("Cikarma=" +yz2);
                int yz3=y/z;System.Console.WriteLine("Bolme="+yz3);
                int yz4=y*z;System.Console.WriteLine("Carpma="+yz4);
                int yz5=y%z;System.Console.WriteLine("Kalan="+yz5);return;}
                

                case 2: System.Console.WriteLine("1-Kare Alani 2-Üçgen Alani 3-Küp Alani 4-Silindirin alani 5-Hepsini çöz.");
                Int32 b =Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("2 adet sayi giriniz. Şekle göre, girdiğiniz değerler pozisyon değiştirecek.");
                Int32 c =Int32.Parse(Console.ReadLine());
                Int32 d =Int32.Parse(Console.ReadLine());
                    switch(b){
                    case 1: Kare(c, d);
                    return;
                    case 2: Ucgen(c, d);
                    return;
                    case 3: Kup(c, d);
                    return;
                    case 4: Silindir(c, d);
                    return;
                    case 5: Hepsi(c, d);
                    return;}
                    return;
}
static void Kare(int c, int d){System.Console.WriteLine("Kare Alani=" + c*d);return;}
static void Ucgen(int c, int d){System.Console.WriteLine("Ucgen Alani (1. sayi h: 2. sayi taban)=" + c*d/2);return;}
static void Kup(int c, int d){System.Console.WriteLine("Kup Alani(sadece ilk sayi alindi)=" + c*c*8);return;}
static void Silindir(int c, int d){System.Console.WriteLine("Silindir Alani(1. sayi r:2. sayi h)=" + Math.PI*c*c*d);return;}
static void Hepsi(int c, int d){
System.Console.WriteLine("Kare Alani=" + c*d);
System.Console.WriteLine("Ucgen Alani (1. sayi h: 2. sayi taban)=" + c*d/2);
System.Console.WriteLine("Kup Alani(sadece ilk sayi alindi)=" + c*c*8);
System.Console.WriteLine("Silindir Alani(1. sayi r:2. sayi h)=" + Math.PI*c*c*d);return;}}}
}

