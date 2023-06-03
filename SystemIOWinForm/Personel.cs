using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWinForm
{
    public class Personel
    {
        public int İD { get; set; }
        public string İsim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string firmaAdı { get; set; }
        public string ulke { get; set; }

        public override string ToString()
        {
            return İsim + " " + soyisim;
        }
        public string personelBilgiGetir()
        {
            return string.Format("isim:{0} soyisim:{1} email adresi:{2} firma:{3} Ülke:{4}",İsim,soyisim,emailAdres,firmaAdı,ulke);

        }
    }
}
