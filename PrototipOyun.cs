using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class PrototipOyun
    {
        public string Baslik { get; set; }
        public string UrunAnahtari { get; set; }

        public abstract PrototipOyun Clone();

        public static string  UrunAnahtariUretim()
        {
            Random r = new Random();
            string UrunAnahtari = " ";

            for (int i = 0; i < 20; i++)
            {
                if( i % 5 == 0 && i != 0)
                {
                    UrunAnahtari += "-";
                }
                UrunAnahtari += (char)(r.Next(26) + 65);
            }
            return UrunAnahtari;
        }
      
    }
}
