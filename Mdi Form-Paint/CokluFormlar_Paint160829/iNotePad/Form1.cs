using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Parametre olarak adres yerine sadece dosya adı verirsek, ilgili dosyayı .exe'nin yanına oluşturur.

            // bool append : Bu parametre dosyaya yazı yazılırken yazılar üzerine eklenerek mi yoksa üzerine yazarak mı ilerlemesi gerektiğini gösterir. 
            // true / false --> true = Her yazdığımızı ekler.  false = Öncekiler siler, en son yazdığımız ekranda görünür.
            StreamWriter yazici = new StreamWriter("metin.txt", true);

            yazici.WriteLine(rTxtBxMetin.Text);
            MessageBox.Show("Yazdığınız yazıyı kaydettim haberin olsun.");
            yazici.Close();
            rTxtBxMetin.Clear();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            // try'da hatayı bulunca catch'e düşüyor ve try'da kalanını görmüyor. Hata bulmazsa tyr'i okur ve bitirir.
            try
            {
                StreamReader okuyucu = new StreamReader("metin.txt");
                rTxtBxMetin.Text = okuyucu.ReadLine();   // Satırı okur.
                // rTxtBxMetin.Text = okuyucu.ReadToEnd();  // Bütün page^yi okur getirir.

                okuyucu.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dosya Bulunamadı. Dosya taşınmış veya oluşturulmamış olabilir.");
            }
            catch (Exception ex)   // Buradaki ex gerçek hatayı getirir. Görmek için ilk catch'i yorum satırına al.
            {
                MessageBox.Show(string.Format("Bir hata oluştu. Detay : {0}", ex.Message));
               // MessageBox.Show("Bir hata oluştur. Detay : "+ex.Message);
               // MessageBox.Show("Bir hata oluştu. Detay : {0}", ex.Message);
            }



            #region Try Catch
            try
            {
                // Kod blogları buraya  yazılır.(1)

            }
            catch (Exception)
            {
                //(1) bölümünde hata var ise bu scop içi çalışır.
            }


            finally
            {
                // Hata varsa da yoksa çalışır.
            }
            #endregion
        }


    }
}
