using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete.DataBaseManager.FileManager
{
    public class FileReader
    {
        public static bool IsContains(string axtarilanAd, string dosyaAdi)
        {
            if (File.Exists(dosyaAdi))
            {
                string dosyaIcerik = File.ReadAllText(dosyaAdi);
                return dosyaIcerik.Contains(axtarilanAd);
            }
            else
            {
                return false;
            }
            
        }
    }
}
