using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tez2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            for (int i = 0; i < 3; i++)
            {
                frm6.listBox1.Items.Add(listBox1.Items[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                string kelime = frm6.listBox1.Items[i].ToString();

                switch (kelime)
                {
                    case "Kayma,takılma vb. nedenlerle düşme":
                        frm6.listBox2.Items.Add("İşletmedeki arayolların ve geçitlerin işçi miktarına ve malzeme hareketine uygun olarak düzenlenmesi gerekmektedir.");

                        break;
                }
                switch (kelime)
                {
                    case "Elektrikli aletler":
                        frm6.listBox2.Items.Add("Makine kısımları,araç gereçler ve bunların koruyucuları ile kullanılan malzemelerin standartlara uygunluğunun sağlanması gerekmektedir.");

                        break;
                }
                switch (kelime)
                {
                    case "Yüksekten düşme":
                        frm6.listBox2.Items.Add("İşçiler koruyucu tedbirlere uymalıdırlar.");

                        break;
                }
                switch (kelime)
                {
                    case "Cisimlerin düşmesi":
                        frm6.listBox2.Items.Add("Betonarme platformlarının veya döşeme kenarlarına düşmeyi önleyecek korkuluk ve ya korkuluklu iskele yapılmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Yangın,parlama ve patlama":
                        frm6.listBox2.Items.Add("Elektrik tesisatının koruma altına alınmalıdır/Yangın algılama önlemleri alınmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Hareketli erişim ekipmanları(Merdivenler,platformlar)":
                        frm6.listBox2.Items.Add("İş ekipmanının tehlikeli bölgeye ulaşmasını önleyecek uygun koruyucular  kullanılmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Biyolojik ajanlar(Virüs,bakteri)":
                        frm6.listBox2.Items.Add("Hijyen önlemleri alınmalıdır/Toplu koruma önlemleri alınmalıdır");

                        break;
                }
                switch (kelime)
                {
                    case "Gürültü ve titreşim":
                        frm6.listBox2.Items.Add("Kulak tamponu");

                        break;
                }
                switch (kelime)
                {
                    case "Radyasyon ve ultraviyole ışınlar":
                        frm6.listBox2.Items.Add("Radyasyon ve ultraviyole ışınlar yayan aletlerin belirlenmeli ve işletme içinde uygun yere konulmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Uygun olmayan duruş ve çalışma şekilleri":
                        frm6.listBox2.Items.Add("İşletme içinde ergonomi çalışması yapılarak uygun alet ve teçhizatlar kullanılmalıdır.");

                        break;
                }
            }
            frm6.Show();
            this.Hide();
        }
    }
}
