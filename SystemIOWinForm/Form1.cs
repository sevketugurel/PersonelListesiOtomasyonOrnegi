using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWinForm
{
    public partial class Form1 : Form
    {
        Dataİslemleri dataIslemleri;
        List<Personel> personelListe;
        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new Dataİslemleri();
            // btnPersonelKaydet.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            personelListe = dataIslemleri.personelGetir(150);
            lstPersonel.DataSource= personelListe;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel seçilenPersonel=(Personel)lstPersonel.SelectedItem;
            txtİsim.Text = seçilenPersonel.İsim;
            txtSoyisim.Text = seçilenPersonel.soyisim;
            txtEmailAdres.Text = seçilenPersonel.emailAdres;
            txtFirma.Text = seçilenPersonel.firmaAdı;
            txtUlke.Text = seçilenPersonel.ulke;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataIslemleri.PersonelKaydet("c:\\udemy", personelListe);
        }
    }
}
