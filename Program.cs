using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toplama işlemi
            int cevap = Toplama(30, 80);
            Console.WriteLine(cevap);
            
            //eğer bu cevap değişkenini başka yerde kullanmayacaksak değişken tanımlamaya gerek yok.
            
            //Zaten toplama methodu sayıyı direkt olarak return ediyor. O yüzden şu şekilde yazmak daha doğru olur:

            Console.WriteLine("Toplama işleminin sonucu: " + Toplama(30, 80));

            Console.WriteLine("Çıkarma işleminin sonucu: " + Cikarma(30, 80));

            Console.WriteLine("Çarpma işleminin sonucu: " + Carpma(30, 80));

            Console.WriteLine("Bölme işleminin sonucu: " + Bolme(30, 80));

         

        }

        //Toplama işlemi

        //Öncelikle access specifier'ı yazmalıyım bu da ya public-(Metoda dışardan erişim olsun istersek), ya da private-(erişim vermiyoruz).
        //Eğer methodum private olacaksa belirtmeme gerek yok, yazmasam da otomatik olarak private algılar.
        //Sonrasında return type yazmalıyım, sayı dönsün istiyorsam int, metin olursa string, metodum görevini yapıyor, ancak..
        //..çağırıldığı yere hiçbir şey getirmiyorsa void yazıyorum.
        //Sonrasında methodun adını yazıyorum -Toplama-, daha sonra parametreleri giriyorum. 
        //Kıvırcık parantez içinde de ne yapmasını istiyorsam onu giriyorum, methodun gövdesini oluşturuyorum.
        //Main methodu static yazıyor, metodlar static ve static olmayan şekilde tanımlanabilir, static bir metodun içinde başka bir..
        //..metodu çağırıyorsak eğer onun da static olması gerekiyor, o yüzden başına static yazıyorum.
        //Daha sonra main metoduna çıkıp bu methodu çağırıyorum. (up)
        static int Toplama(int sayi1, int sayi2)
        {
           
            return sayi1 + sayi2;
        }

        //ÖDEV
     
        static int Cikarma(int sayi1, int sayi2)
        {
            return sayi2 - sayi1;
        }
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;

        }
        static float Bolme(float sayi1, float sayi2)
        {
            return sayi2 / sayi1;
        }
    }

}
