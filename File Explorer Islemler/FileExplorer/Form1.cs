using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> _kopyalanacaklarListesi;
        bool _kesMi = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDiskSec.Items.AddRange(DriveInfo.GetDrives());
        }

        private void cmbDiskSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo seciliSurucu = (cmbDiskSec.SelectedItem as DriveInfo);
            //DriveInfo seciliSurucu1 = (DriveInfo)cmbDiskSec.SelectedItem;

            if (seciliSurucu != null && seciliSurucu.IsReady)
            {
                KlasorleriDoldurBySurucu(seciliSurucu.Name);
            }
            else
            {
                MessageBox.Show("Sürücü hazır değil");
            }
        }

        void KlasorleriDoldurBySurucu(string surucuAdi)
        {
            trvKlasorler.Nodes.Clear();
            //Seçili sürücüyü TreeView'a ilk eleman olarak ekliyoruz.
            TreeNode surucuNode = new TreeNode();
            surucuNode.Text = surucuAdi;
            trvKlasorler.Nodes.Add(surucuNode);

            DirectoryInfo dizin = new DirectoryInfo(surucuAdi);
            DirectoryInfo[] klasorler = dizin.GetDirectories();

            foreach (DirectoryInfo item in klasorler)
            {
                //cmbDiskSec'den seçilen sürücü içindeki klasörleri TreeView'a ekle.
                TreeNode klasorNode = new TreeNode();
                klasorNode.Text = item.Name;
                klasorNode.Tag = item.FullName;
                surucuNode.Nodes.Add(klasorNode);
            }
            surucuNode.Expand();
        }

        private void trvKlasorler_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DosyalariDoldur(e.Node.Tag.ToString());
            }
            catch (Exception)
            {

            }

        }

        void DosyalariDoldur(string path)
        {
            DirectoryInfo dosyaDizini = new DirectoryInfo(path);
            FileInfo[] dosyalar = dosyaDizini.GetFiles();
            lstGoruntule.Items.Clear();
            cmbFiltre.Items.Clear();
            cmbFiltre.Items.Add("*.*");
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = dosyalar.Length;
            toolStripProgressBar1.Step = 1;
            double toplamDosyaBoyutu = 0;


            foreach (FileInfo item in dosyalar)
            {
                ListViewItem lstItem = new ListViewItem();
                lstItem.Text = item.Name;
                lstItem.Tag = item.FullName;
                long dosyaBoyutu = item.Length;
                lstItem.SubItems.Add(dosyaBoyutu.ToString());
                DateTime olusturulmaTarihi = item.CreationTime;
                lstItem.SubItems.Add(olusturulmaTarihi.ToLongTimeString());
                lstGoruntule.Items.Add(lstItem);
                toplamDosyaBoyutu += dosyaBoyutu;
                toolStripProgressBar1.PerformStep();
                string uzanti = "*" + item.Extension.ToLower();

                if (!cmbFiltre.Items.Contains(uzanti))
                {
                    cmbFiltre.Items.Add(uzanti);
                }

                toolStripProgressBar1.Visible = false;

                toolStripStatusLabel1.Text = string.Format("{0} adet dosya, {1} boyut", dosyalar.Length, toplamDosyaBoyutu);
            }
        }

        private void trvKlasorler_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in e.Node.Nodes)
            {
                AltKlasorleriDoldur(item);
            }
        }

        void AltKlasorleriDoldur(TreeNode tree)
        {
            try
            {
                tree.Nodes.Clear();
                DirectoryInfo altDizin = new DirectoryInfo(tree.Tag.ToString());
                DirectoryInfo[] altKlasorler = altDizin.GetDirectories();

                foreach (DirectoryInfo item in altKlasorler)
                {
                    TreeNode altKlasorNode = new TreeNode();
                    altKlasorNode.Text = item.Name;
                    altKlasorNode.Tag = item.FullName;
                    tree.Nodes.Add(altKlasorNode);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            #region HATA VAR!!!!
            if (cmbFiltre.SelectedIndex < 0)
            {
                return;
            }

            //DosyalariDoldur(trvKlasorler.SelectedNode.Tag.ToString());

            string seciliUzanti = cmbFiltre.SelectedItem.ToString().Substring(1);
            //cmbFiltre'nin 0'ıncı indexindeki eleman *.*
            //*.* haricinde bir eleman seçilirse IF bloğundaki kodlar çalışacak.
            if (cmbFiltre.SelectedIndex > 0)
            {
                foreach (ListViewItem item in lstGoruntule.Items)
                {
                    if (Path.GetExtension(item.Text.ToLower()) != seciliUzanti)
                    {
                        item.Remove();
                    }
                }
            }
            //*.* seçilirse buraya düşecek
            else
            {
                DosyalariDoldur(trvKlasorler.SelectedNode.Tag.ToString());
            }
            #endregion
        }

        private void lstGoruntule_DoubleClick(object sender, EventArgs e)
        {
            DosyaCalistir(lstGoruntule.FocusedItem.Tag.ToString());
        }

        void DosyaCalistir(string dosyaPath)
        {
            try
            {
                Process.Start(dosyaPath);
            }
            catch (Exception)
            {

                MessageBox.Show("Dosya çalıştırılamadı. Sistem yöneticinize başvurun.");
            }
        }

        private void Kopyala_Click(object sender, EventArgs e)
        {
            _kesMi = false;
            KopyalaKes();
        }

        private void Kes_Click(object sender, EventArgs e)
        {
            _kesMi = true;
            KopyalaKes();
        }

        void KopyalaKes()
        {
            _kopyalanacaklarListesi = new List<string>();

            foreach (ListViewItem item in lstGoruntule.SelectedItems)
            {
                _kopyalanacaklarListesi.Add(item.Tag.ToString());
                if (_kesMi)
                {
                    item.ForeColor = Color.Gray;
                }
            }
        }

        private void Yapistir_Click(object sender, EventArgs e)
        {
            string yapistirilacakYer = trvKlasorler.SelectedNode.Tag.ToString();

            foreach (string item in _kopyalanacaklarListesi)
            {
                string dosyaAdi = Path.GetFileName(item);

                try
                {
                    if (!string.IsNullOrEmpty(dosyaAdi))
                    {
                        string kopyalanacakPath = Path.Combine(yapistirilacakYer, dosyaAdi);
                        if (_kesMi)
                        {
                            File.Move(item, kopyalanacakPath);
                        }
                        else
                        {
                            File.Copy(item, kopyalanacakPath);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(@"Bu dosya zaten var, yinede kopyalansın mı?", @"VAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (_kesMi)
                            {
                                File.Move(item, yapistirilacakYer);
                            }
                            else
                            {
                                File.Copy(item, Path.Combine(item, "(Copy)" + dosyaAdi));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Silmek istediğinize eminseniz EVET'e emin değilseniz HAYIR'a basınız.", @"Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                foreach (ListViewItem item in lstGoruntule.SelectedItems)
                {
                    File.Delete(item.Tag.ToString());
                }
                DosyalariDoldur(trvKlasorler.SelectedNode.Tag.ToString());
            }
        }
    }
}