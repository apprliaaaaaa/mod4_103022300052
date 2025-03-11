using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_103022300052
{
    class KodeProduk
    {
        private static readonly Dictionary<string, string> kodeProDict = new Dictionary<string, string>()
        {
            {"Laptop", "E100" },
            {"Smartphone", "E200" },
            {"Tablet", "E300" },
            {"Headset", "E400" },
            {"Keyboard", "E500" },
            {"Mouse", "E600" },
            {"Printer", "E700" },
            {"Monitor", "E800" },
            {"Smarthwatch", "E900" },
            {"Kamera", "E1000" }
        };

        public static string GetKodeProduk(string namaProduk)
        {
            if (kodeProDict.ContainsKey(namaProduk))
            {
                return kodeProDict[namaProduk];
            }
            else
            {
                return "Produk tidak ditemukan";
            }
        }
    }
}
