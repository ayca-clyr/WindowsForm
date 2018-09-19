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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olası tehlike listelerinden size uygun olan kutucukları işaretleyiniz.Listeden en az 3 madde işaretlenmelidir. Sıralama önemli değildir.");
        }
        Form2 frm2 = new Form2();
        private void btnDevam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {


                frm2.listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                string kelime = checkedListBox1.CheckedItems[i].ToString();

                switch (kelime)
                {
                    case "Kayma,takılma vb. nedenlerle düşme":
                        frm2.listBox2.Items.Add("Hafif sıyrıklar,üç günden az iş güü kayıplı kazalar");

                        break;
                }
                switch (kelime)
                {
                    case "Elektrikli aletler":
                        frm2.listBox2.Items.Add("Doktor müdehalesi gerektiren şiddetli yaralanmalar/Ölüm");

                        break;
                }
                switch (kelime)
                {
                    case "Yüksekten düşme":
                        frm2.listBox2.Items.Add("Doktor müdehalesi gerektiren şiddetli yaralanmalar/Hafif yaralanmalar/Ölüm");

                        break;
                }
                switch (kelime)
                {
                    case "Cisimlerin düşmesi":
                        frm2.listBox2.Items.Add("Doktor müdehalesi gerektiren şiddetli yaralanmalar/Hafif yaralanmalar/Ölüm");

                        break;
                }
                switch (kelime)
                {
                    case "Yangın,parlama ve patlama":
                        frm2.listBox2.Items.Add("Uzuv kaybı/Ölüm/Bir çok çalışanın hayatını tehtid edici şekilde yaralanması");

                        break;
                }
                switch (kelime)
                {
                    case "Hareketli erişim ekipmanları(Merdivenler,platformlar)":
                        frm2.listBox2.Items.Add("Hafif yaralanmalar");

                        break;
                }
                switch (kelime)
                {
                    case "Biyolojik ajanlar(Virüs,bakteri)":
                        frm2.listBox2.Items.Add("Ölüm/Bir çok çalışanın hayatını tehtid edici şekilde zarar görmesi");

                        break;
                }
                switch (kelime)
                {
                    case "Gürültü ve titreşim":
                        frm2.listBox2.Items.Add("Meslek hastalığı(İşitme Kaybı)");

                        break;
                }
                switch (kelime)
                {
                    case "Radyasyon ve ultraviyole ışınlar":
                        frm2.listBox2.Items.Add("Ölüm/Meslek hastalığı");

                        break;
                }
                switch (kelime)
                {
                    case "Uygun olmayan duruş ve çalışma şekilleri":
                        frm2.listBox2.Items.Add("Vücut şekil bozuklukları/Kas ve iskelet hastalıkları");

                        break;
                }

            }

            Hide();
         
            frm2.ShowDialog();
           
            Show();

           
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Ayça Calayır ve Ezginur Orhan tarafından 2015-2016 yılında geliştirilmiştir.Programımızın amacı iş sağlığı ve güvenliği uzmanları başta olmak üzere kaza ve meslek hastalıklarıyla ilgilenen tüm kişilere kolaylık sağlamaktadır.Programımızın işleyişi olası kazalar sonucu oluşabilecek durumların değerlendirilmesi ve kazalar oluşmadan önce alınabilecek tedbirlerin rapor edilmesi esasına dayanmaktadır.");
        }
    }
}
