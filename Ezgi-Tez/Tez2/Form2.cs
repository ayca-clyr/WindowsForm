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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        Form3 frm3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 3; i++)
            {
                frm3.listBox1.Items.Add(listBox1.Items[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                string kelime = frm3.listBox1.Items[i].ToString();

                switch (kelime)
                {
                    case "Kayma,takılma vb. nedenlerle düşme":
                        frm3.listBox2.Items.Add("İşletmedeki arayolların ve geçitlerin işçi miktarına ve malzeme hareketine uygun olarak düzenlenmesi gerekmektedir.");

                        break;
                }
                switch (kelime)
                {
                    case "Elektrikli aletler":
                        frm3.listBox2.Items.Add("Makine kısımları,araç gereçler ve bunların koruyucuları ile kullanılan malzemelerin standartlara uygunluğunun sağlanması gerekmektedir.");

                        break;
                }
                switch (kelime)
                {
                    case "Yüksekten düşme":
                        frm3.listBox2.Items.Add("İşçiler koruyucu tedbirlere uymalıdırlar.");

                        break;
                }
                switch (kelime)
                {
                    case "Cisimlerin düşmesi":
                        frm3.listBox2.Items.Add("Betonarme platformlarının veya döşeme kenarlarına düşmeyi önleyecek korkuluk ve ya korkuluklu iskele yapılmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Yangın,parlama ve patlama":
                        frm3.listBox2.Items.Add("Elektrik tesisatının koruma altına alınmalıdır/Yangın algılama önlemleri alınmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Hareketli erişim ekipmanları(Merdivenler,platformlar)":
                        frm3.listBox2.Items.Add("İş ekipmanının tehlikeli bölgeye ulaşmasını önleyecek uygun koruyucular  kullanılmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Biyolojik ajanlar(Virüs,bakteri)":
                        frm3.listBox2.Items.Add("Hijyen önlemleri alınmalıdır/Toplu koruma önlemleri alınmalıdır");

                        break;
                }
                switch (kelime)
                {
                    case "Gürültü ve titreşim":
                        frm3.listBox2.Items.Add("Kulak tamponu");

                        break;
                }
                switch (kelime)
                {
                    case "Radyasyon ve ultraviyole ışınlar":
                        frm3.listBox2.Items.Add("Radyasyon ve ultraviyole ışınlar yayan aletlerin belirlenmeli ve işletme içinde uygun yere konulmalıdır.");

                        break;
                }
                switch (kelime)
                {
                    case "Uygun olmayan duruş ve çalışma şekilleri":
                        frm3.listBox2.Items.Add("İşletme içinde ergonomi çalışması yapılarak uygun alet ve teçhizatlar kullanılmalıdır.");

                        break;
                }
            }

            Hide();
            //Form2 form2 = new Form2();
            frm3.ShowDialog();
            //frm2 = null;
            Show();

            //this.frm3.Show();
            //this.Hide();
        }
        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
