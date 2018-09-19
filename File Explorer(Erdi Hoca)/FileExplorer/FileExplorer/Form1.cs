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

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            TreeNode node;

            foreach (DriveInfo drive in drives)
            {
                DirectoryInfo directory = new DirectoryInfo(drive.Name);

                node = new TreeNode();
                node.Text = directory.Name;
                node.Tag = directory.FullName;

                trvDirectories.Nodes.Add(node);
                try
                {
                    if (directory.GetDirectories().Length > 0)
                    {
                        node.Nodes.Add(string.Empty);
                    }
                }
                catch (Exception)
                {

                }

            }
        }

        private void trvDirectories_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNode expandedNode = e.Node;
            expandedNode.Nodes.Clear();

            string directoryPath = (string)expandedNode.Tag;

            DirectoryInfo directory = new DirectoryInfo(directoryPath);


            DirectoryInfo[] subDirectories = directory.GetDirectories();

            TreeNode subNode;

            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                subNode = new TreeNode();
                subNode.Text = subDirectory.Name;
                subNode.Tag = subDirectory.FullName;

                expandedNode.Nodes.Add(subNode);

                try
                {
                    if (subDirectory.GetDirectories().Length > 0)
                    {
                        subNode.Nodes.Add(string.Empty);
                    }
                }
                catch (Exception)
                {

                }
            }

        }

        private void trvDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvFiles.Items.Clear();

            TreeNode selectedNode = e.Node;

            string directoryPath = (string)selectedNode.Tag;

            DirectoryInfo directory = new DirectoryInfo(directoryPath);


            // Add Sub Directories to ListView
            try
            {
                DirectoryInfo[] directories = directory.GetDirectories();

                ListViewItem lvi;

                foreach (DirectoryInfo subDir in directories)
                {
                    lvi = new ListViewItem();
                    lvi.Text = subDir.Name;
                    lvi.Tag = subDir.FullName;
                    lvi.SubItems.Add(subDir.CreationTime.ToString());
                    lvi.SubItems.Add(string.Empty);
                    lsvFiles.Items.Add(lvi);
                }
            }
            catch (Exception)
            {

            }


            // Add Files to ListView
            try
            {
                FileInfo[] files = directory.GetFiles();

                ListViewItem lvi;

                foreach (FileInfo file in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = file.Name;
                    lvi.Tag = file.FullName;
                    lvi.SubItems.Add(file.CreationTime.ToString());
                    lvi.SubItems.Add(((double)((double)file.Length / 1024) / 1024).ToString("0:00"));
                    lsvFiles.Items.Add(lvi);
                }
            }
            catch (Exception)
            {

            }
        }

        private void lsvFiles_DoubleClick(object sender, EventArgs e)
        {
            ListView lsvFiles = (ListView)sender;

            if (lsvFiles.SelectedItems != null && lsvFiles.SelectedItems.Count > 0)
            {
                ListViewItem selectedLvi = lsvFiles.SelectedItems[0];
                string fullPath = (string)selectedLvi.Tag;

                System.Diagnostics.Process proc = System.Diagnostics.Process.Start(fullPath);
            }

        }

        private void lsvFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (lsvFiles.SelectedItems != null && lsvFiles.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvFiles.SelectedItems[0];

                lsvFiles.DoDragDrop(selectedItem, DragDropEffects.Move);
            }
        }

        private void trvDirectories_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void trvDirectories_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem lvi = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            string fileName = (string)lvi.Tag;

            FileInfo file = new FileInfo(fileName);

            int realX = e.X - this.Location.X - splitContainer1.Location.X;
            int realY = e.Y - this.Location.Y - splitContainer1.Location.Y - (this.Height - this.ClientRectangle.Height);

            Point point = new Point(realX, realY);


            TreeNode node = GetNodeAtPoint(trvDirectories.Nodes, realX, realY);

            if (node != null)
            {
                DialogResult dialog = MessageBox.Show(file.Name + " isimli dosya " + node.Text + " isimli klasöre taşınacak.\n\nDevam etmek istiyor musunuz?", "Dikkat!", MessageBoxButtons.OKCancel);

                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    string targetDirectoryPath = (string)node.Tag;

                    try
                    {
                        //MessageBox.Show(targetDirectoryPath + "\\" + file.Name);

                        file.MoveTo(targetDirectoryPath + "\\" + file.Name);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

            }


            //foreach (TreeNode node in trvDirectories.Nodes)
            //{
            //    if (
            //        realX >= node.Bounds.X
            //        &&
            //        realX <= node.Bounds.X + node.Bounds.Width
            //        &&
            //        realY >= node.Bounds.Y
            //        &&
            //        realY <= node.Bounds.Y + node.Bounds.Height
            //        )
            //    {
            //        string targetDirectoryPath = (string)node.Tag;

            //        //DirectoryInfo targetDirectory = new DirectoryInfo(targetDirectoryPath);

            //        file.MoveTo(targetDirectoryPath + file.Name);

            //        MessageBox.Show(node.Text);

            //        break;
            //    }

            //    // TODO: Serdar'ın yüzü suyu hürmetine burası geliştirilecek.
            //}


        }

        TreeNode GetNodeAtPoint(TreeNodeCollection nodes, int x, int y)
        {
            TreeNode subNode = null;

            if (nodes.Count == 1 && nodes[0].Text == string.Empty)
            {
                return subNode;
            }

            foreach (TreeNode node in nodes)
            {
                if (
                    x >= node.Bounds.X
                    &&
                    x <= node.Bounds.X + node.Bounds.Width
                    &&
                    y >= node.Bounds.Y
                    &&
                    y <= node.Bounds.Y + node.Bounds.Height
                    )
                {
                    return subNode = node;
                }
                else
                {
                    if (node.Nodes.Count > 0)
                    {
                        subNode = GetNodeAtPoint(node.Nodes, x, y);
                    }
                }

                if (subNode != null)
                {
                    break;
                }
            }

            return subNode;
        }
    }
}
