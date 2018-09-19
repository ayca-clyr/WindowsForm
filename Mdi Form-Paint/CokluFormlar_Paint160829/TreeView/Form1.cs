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

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Harddiskteki mantıksal sürücüleri getirir.
            DriveInfo[] suruculer = DriveInfo.GetDrives();

            cBxDrivers.Items.AddRange(suruculer);


            //foreach (DriveInfo surucu in suruculer) //suruculerde dolastı
            //{
            //    TreeNode aNodes = tvSol.Nodes.Add(surucu.Name); //hangi surucuyu eklediysek o surucuyu treeNode değişkeninde(nesne) tuttu  tvSol --> Formdaki treeView adı
            //    try
            //    {
            //        DirectoryInfo d = new DirectoryInfo(surucu.Name); //hangi surucudeyse alt klasorlerini tutuyo
            //        DirectoryInfo[] klasor = d.GetDirectories();
            //        foreach (DirectoryInfo folder in klasor)
            //        {
            //            aNodes.Nodes.Add(surucu.Name + folder.Name);
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}



                // Alt dizinlere ulaşmamızı sağlar.
                DirectoryInfo directory = new DirectoryInfo("C:\\");

            // Belli bir dizin(klasör) içerisindeki dizinleri gösterir.  jpeg'ler dosya. Dosyayı taşıyan klasördür.
            DirectoryInfo[] dizinler = directory.GetDirectories();
            lstBxRightSide.Items.AddRange(dizinler);

            // Belirli bir dizin içerisindeki dosyaları gösterir.
            FileInfo[] dosyalar = directory.GetFiles();
            lstBxRightSide.Items.AddRange(dosyalar);

            // Bunlar üst kısımlar.
            TreeNode node1 = new TreeNode();
            node1.Text = "İstanbul";
            TreeNode node2 = new TreeNode();
            node2.Text = "Rize";
            TreeNode node3 = new TreeNode();
            node3.Text = "Sakarya";

            tvLeftSide.Nodes.Add(node1);
            tvLeftSide.Nodes.Add(node2);
            tvLeftSide.Nodes.Add(node3);

            // Alt dallar.
            TreeNode subNode1 = new TreeNode();
            subNode1.Text = "Avcılar";
            TreeNode subNode2 = new TreeNode();
            subNode2.Text = "Bakırköy";
            TreeNode subNode3 = new TreeNode();
            subNode3.Text = "Bostancı";

            TreeNode subNode4 = new TreeNode();
            subNode4.Text = "Hemşin";
            TreeNode subNode5 = new TreeNode();
            subNode5.Text = "Çayeli";

            // İstanbul için eklemeler yapılır.

            node1.Nodes.Add(subNode1);
            node1.Nodes.Add(subNode2);
            node1.Nodes.Add(subNode3);

            // Rize için eklemeler yapılır.

            node2.Nodes.Add(subNode4);
            node2.Nodes.Add(subNode5);

            // treeView'daki tüm seviyeleri açık hale getirir.
            tvLeftSide.ExpandAll();

            // treeView'daki tüm seviyeleri kapatır.
            tvLeftSide.CollapseAll();        

        }

        //private void tvSol_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    try
        //    {

        //        lstSag.Items.Clear();
        //        string[] dizindekiKlasorler = Directory.GetDirectories(tvSol.SelectedNode.Text);
        //        DirectoryInfo directory = new DirectoryInfo(tvSol.SelectedNode.Text);

        //        int j = 0;
        //        //sadece klasorleri sol ve sag tarafa
        //        for (j = 0; j < dizindekiKlasorler.Length; j++)
        //        {
        //            string klasor = dizindekiKlasorler[j].ToString();
        //            DirectoryInfo directoryInfo = new DirectoryInfo(klasor);
        //            string klasorAdi = directoryInfo.Name;
        //            tvSol.SelectedNode.Nodes.Add(tvSol.SelectedNode.Text + "/" + klasorAdi);
        //            lstSag.Items.Add(klasorAdi);
        //        }
        //        // dosyaları sağ tarafa
        //        FileInfo[] dosyalar = directory.GetFiles();
        //        for (int i = 0; i < dosyalar.Length; i++)
        //        {
        //            lstSag.Items.Add(dosyalar[i].ToString());
        //        }
        //    }
        //    catch (Exception)
        //    {


        //    }
        //}

    }
}
