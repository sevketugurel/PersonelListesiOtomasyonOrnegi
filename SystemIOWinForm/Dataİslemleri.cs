using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWinForm
{
    public class Dataİslemleri
    {
        public Dataİslemleri()
        {

        }
        public List<Personel> personelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();
            int id = 0;
            for (int i = 0; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.İD = id++;
                personel.İsim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdı = FakeData.NetworkData.GetDomain();
                personel.emailAdres = personel.İsim + "." + personel.soyisim + "@" + personel.firmaAdı;
                personel.ulke = FakeData.PlaceData.GetCountry();
                personelListe.Add(personel);
            }
            return personelListe;
        }
        public void PersonelKaydet(string path, List<Personel> personelListesi)
        {
            DirectoryInfo ulkeBİlgisi = null;
            for (int i = 0; i <= personelListesi.Count; i++)
            {
                if (Directory.Exists(path + "\\" + personelListesi[i].ulke))
                {
                    ulkeBİlgisi = new DirectoryInfo(path + "\\" + personelListesi[i].ulke);
                }
                else
                {
                    Directory.CreateDirectory((path + "\\" + personelListesi[i].ulke));
                }
                
                FileStream fs = File.Create(ulkeBİlgisi.FullName +"\\"+ personelListesi[i].İsim + "." + personelListesi[i].soyisim+".txt");
                byte[] personelBilgi = new UTF8Encoding(true).GetBytes(personelListesi[i].personelBilgiGetir());
                fs.Write(personelBilgi,0,personelBilgi.Length);
                fs.Close();
            
            }
        }





    }
}
