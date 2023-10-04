using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HelloErrorHandling();
            ErrorHandlingObserving();
        }

        static void ErrorHandlingObserving()
        {
            // not olarak try catch blokları her yere yazılmaz ... Sadece özel yerlerde yazılır
            try
            {
                // Standart uygulama için yazmış olduğumuz kod blokları 
                Console.WriteLine("Bir sayı girişi yapınız!");
                int sayi1 = int.Parse(Console.ReadLine());

                if(sayi1 == 0)
                {
                    throw new SpecialErrorClass(); // Bu throw dışında bu special ile alakalı bir catch bloğu ** yoksa ** en base olana düşer
                }

            }
            catch (SpecialErrorClass fx) // Class olarak oluşturuğumuz hata sınıfı **Special Error Class**
            {
                Console.WriteLine("Özel hata sınıfı catch'de yakalandı!");
            }
            catch (FormatException fx )
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir!");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex) // Hata yönetiminde Exception class'ı base class'dır.
            {
                Console.WriteLine("Herhangi bir hata oluştu!");
                // Catch blokları sistem içerisinde runtime'da alınan hataların loglanmasına
                // ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                /*
                 * Try bloklarında kodlar çalışır
                 * Catch => içinde yapılacak işlemler yapılır...
                 * Finally => Kod tarafında  herhangi bir hata almasak da finally blokları çalışmaya devam eder.
                 * 
                 * Finally nerede kullınılır? 
                 * Örnek olarak bir database bağlantımız var ve biz içeride işlemler yapıyoruz.
                 * İşlem sırasında bir hata oldu.
                 * Ama son olarak da bizim database bağlantısını sonlandırmamız gerekiyor. 
                 * Hata aldığımız kod bölümünden sonraki kodlar çalışmayacağı için bunu finally blokları arasında yapmamız gerekir.
                 * Bu şekilde istediğimiz kod bloğunun çalışmasını garanti etmiş oluruz :D
                 */
                Console.WriteLine("Finally bloğu çalıştı!");
            }

            Console.WriteLine("Uygulama bitti!");
            Console.ReadLine();
        }

        static void HelloErrorHandling()
        {
            Console.WriteLine("Bir sayı girişi yapınız!");
            int sayi1 = int.Parse(Console.ReadLine());
        }
    }
}
