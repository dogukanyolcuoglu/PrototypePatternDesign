using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Oyun1 : PrototipOyun
    {
        public Oyun1(string baslik)
        {
            Baslik = baslik;
        }
        public override PrototipOyun Clone()
        {
            return (Oyun1)this.MemberwiseClone();
        }
    }
}
