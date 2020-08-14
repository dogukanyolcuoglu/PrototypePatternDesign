using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Oyun2 : PrototipOyun
    {
        public Oyun2(string baslik)
        {
            Baslik = baslik;
        }
        public override PrototipOyun Clone()
        {
            return (Oyun2)this.MemberwiseClone();
        }
    }
}
