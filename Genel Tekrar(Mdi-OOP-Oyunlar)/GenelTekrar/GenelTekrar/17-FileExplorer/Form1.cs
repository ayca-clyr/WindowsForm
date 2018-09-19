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

namespace _17_FileExplorer
{
    public partial class Form1 : Form
    {
        DriveInfo[] Driver = DriveInfo.GetDrives();
        ImageList images = new ImageList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeViewList();
            images.Images.Add(Image.FromFile("folder.png"));
            images.Images.Add(Image.FromFile("SelecFolder.png"));
            treeView1.ImageList = images;
            treeView1.StateImageList = images;
            treeView1.ImageIndex = 0;
            treeView1.SelectedImageIndex = 1;



        }
        private void TreeViewList()
        {
            foreach (DriveInfo drive in Driver)
            {
                TreeNode rootNode;
                DirectoryInfo info = new DirectoryInfo(drive.Name);
                if (info.Exists)
                {
                    rootNode = new TreeNode(info.Name);
                    rootNode.Tag = info;
                    GetDirectories(info.GetDirectories(), rootNode);
                    treeView1.Nodes.Add(rootNode);
                }
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                try
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);
                }
                catch (Exception)
                {


                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            newSelected.SelectedImageIndex = 1;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]{new ListViewItem.ListViewSubItem(item,dir.CreationTime.Date.ToShortDateString()),
                new ListViewItem.ListViewSubItem(item,"")};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);

            }

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, file.CreationTime.Date.ToShortDateString()),
                   new ListViewItem.ListViewSubItem(item, file.Length.ToString()+" Kb")};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

        }
    }
}
