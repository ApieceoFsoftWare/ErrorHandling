using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class SpecialErrorClass : Exception
    {
        public SpecialErrorClass()
        {
            Console.WriteLine("Özel Hata Sınıfı oluştu!");
        }
    }
}
