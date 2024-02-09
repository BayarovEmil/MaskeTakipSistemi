using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete.DataBaseManager.FileManager
{
    public class FileWriter
    {
        public static void DosyayaYaz(string metin, string dosyaAdi)
        {
            File.WriteAllText(dosyaAdi, metin);
            Console.WriteLine($"'{dosyaAdi}' adlı dosyaya yazıldı.");
        }
    }
}
