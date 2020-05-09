using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool durum = false;
            do
            {
                Console.WriteLine("Hello World.");
            }
            while (durum); // durum değişkeni false olduğu için 1 kere çalışır.
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0); // Koşul 0 dan büyük olduğu sürece birer birer azaltarak ekrana i değişkenini yazmaya devam et.
            Console.ReadKey();
        }
    }
}
/* Diğer döngülerde önce koşula bakılır. Daha sonra işlem yapılır.
   Do while döngüsünde ise önce işlem yapılır sonra koşula bakılır.
   Bu nedenle koşul sağlanıyor olsa bile döngü bir kere çalışır.
   do
   {
       //<İşlemler>
   }
   while (<koşul>);
*/