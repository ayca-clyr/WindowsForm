using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _160901_FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //Harddiskteki mantıksal sürücüleri getiren kod:
            DriveInfo[] suruculer = DriveInfo.GetDrives();
            //AddRange Ayrı ayrı yazılmazı için kullanılır. 
            //Dizi olduğu için kullanılır.

            DirectoryInfo directory = new DirectoryInfo("C:\\");
            //Belli bir dizin(klasör) içerisindeki dizinleri gösteren kod
            DirectoryInfo[] dizinler = directory.GetDirectories();
            

            //Belirli bir dizin içerisindeki dosyaları gösteren kod:

            FileInfo[] dosyalar = directory.GetFiles();

            foreach (DriveInfo surucu in suruculer) // suruculerde dolastı
            {
                TreeNode node = treeView1.Nodes.Add(surucu.Name);//Hangi sunucuyu eklediysek o surucuyu treeNode değişkeninde(nesne) tuttu

                try
                {
                    DirectoryInfo altklasör = new DirectoryInfo(surucu.Name);// hangi surucuduyse alt klasörlerini tutuyo
                    DirectoryInfo[] dizin = altklasör.GetDirectories();
                    foreach (DirectoryInfo dosya in dizin)
                    {
                        node.Nodes.Add(dosya.Name);
                    }
                }

                catch (Exception)
                {

                }


            }
            
            
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string[] dosyaİsimleri; //Klasör seçildiğinde listviewde göstermek için dizi kullanmam gerekiyor.

            listGörüntüle.Items.Clear(); // Her seçimden önce listView temizlemem gerekiyor.

            try
            {
                string[] dosyalar = System.IO.Directory.GetDirectories(e.Node.FullPath);
                for (int i = 0; i <= dosyalar.GetUpperBound(0); i++)
                {
                    dosyaİsimleri = dosyalar[i].Split('\\');// Split araya ifade yazmamız için kullanılıyor. Dizi elemanları arasına
                    listGörüntüle.Items.Add(dosyaİsimleri[dosyaİsimleri.GetUpperBound(0)]);//GetUpperBound Dizinin son elemanına ulaşmak için son seçilen gösterilsin diye.
                }
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
