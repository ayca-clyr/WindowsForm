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

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TreeVieweVeriEkleme()
        {
            TreeNode anaNode;

            DirectoryInfo directoInfo = new DirectoryInfo("C:\\");
            if (directoInfo.Exists)
            {
                anaNode = new TreeNode(directoInfo.Name);
                anaNode.Tag = directoInfo;
                GetDirectories(directoInfo.GetDirectories(), anaNode);
                tvSurucu.Nodes.Add(anaNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] altDirectory, TreeNode nodeEkle)
        {
            TreeNode node1;
            DirectoryInfo[] altAltDirectory;
            foreach (DirectoryInfo altDir in altDirectory)
            {
                try
                {
                    node1 = new TreeNode(altDir.Name, 0, 0);
                    node1.Tag = altDir;
                    altAltDirectory = altDir.GetDirectories();
                    if (altAltDirectory.Length != 0)
                    {
                        GetDirectories(altAltDirectory, node1);
                    }
                    nodeEkle.Nodes.Add(node1);
                }
                catch (Exception)
                {
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeVieweVeriEkleme();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
             TreeNode yeniSecilen = e.Node;

            listView1.Items.Clear();
            DirectoryInfo secilen = (DirectoryInfo)yeniSecilen.Tag;
            ListViewItem.ListViewSubItem[] altItems;
            ListViewItem item = null;

            foreach (DirectoryInfo directoryInfo in secilen.GetDirectories())
            {
                item = new ListViewItem(directoryInfo.Name, 0);
                altItems = new ListViewItem.ListViewSubItem[]
                  {
                      new ListViewItem.ListViewSubItem(item, "Directory"), 
                   new ListViewItem.ListViewSubItem(item, directoryInfo.CreationTime.Date.ToShortDateString())};
                item.SubItems.AddRange(altItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo fileInfo in secilen.GetFiles())
            {
                item = new ListViewItem(fileInfo.Name, 1);
                altItems = new ListViewItem.ListViewSubItem[]
                  { 
                      new ListViewItem.ListViewSubItem(item, "File"), 
                   new ListViewItem.ListViewSubItem(item, fileInfo.CreationTime.Date.ToShortDateString()),
                   new ListViewItem.ListViewSubItem(item, fileInfo.Length.ToString() + "Kb")};

                item.SubItems.AddRange(altItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }       
    }
}



















