using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160916_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Book> listBook = new List<Book>();
        Book book;

        void Clear()
        {
            foreach (Control controls in Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = string.Empty;
                }
            }

            dtpReleaseDate.Value = DateTime.Now;
            cbCategory.SelectedIndex = 0;
        }

        void getRegister()
        {
            listView.Items.Clear();

            foreach (var item in listBook)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.ReleaseDate.ToString());
                listViewItem.SubItems.Add(item.AuthorFirstName);
                listViewItem.SubItems.Add(item.AuthorLastName);
                listViewItem.Tag = item;
                listView.Items.Add(listViewItem);
            }
        }

        void AddList()
        {
            book = new Book();
            book.Name = txtName.Text;
            book.Category = cbCategory.Text;
            book.ReleaseDate = dtpReleaseDate.Value;
            book.AuthorFirstName = txtAuthorFirstName.Text;
            book.AuthorLastName = txtAuthorLastName.Text;
            listBook.Add(book);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAuthorFirstName.Text) || string.IsNullOrEmpty(txtAuthorLastName.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(dtpReleaseDate.Text)) return;


            AddList();
            getRegister();
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme Durumu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                try
                {

                    // listBook.Remove(listBook[listView.FocusedItem.Index]);
                    listBook.Remove((Book)listView.SelectedItems[0].Tag);
                    getRegister();
                    Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("Silinecek Kişiyi Seçmediniz!");
                }

            }
            else
            {
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book kitap = (Book)listView.SelectedItems[0].Tag;
                kitap.Name = txtName.Text;
                kitap.AuthorFirstName = txtAuthorFirstName.Text;
                kitap.AuthorLastName = txtAuthorLastName.Text;
                kitap.Category = cbCategory.Text;
                kitap.ReleaseDate = dtpReleaseDate.Value;

                //listBook[listView.FocusedItem.Index].Name = txtName.Text;
                //listBook[listView.FocusedItem.Index].AuthorFirstName = txtAuthorFirstName.Text;
                //listBook[listView.FocusedItem.Index].AuthorLastName = txtAuthorLastName.Text;
                //listBook[listView.FocusedItem.Index].Category = cbCategory.Text;
                //listBook[listView.FocusedItem.Index].ReleaseDate = dtpReleaseDate.Value;

                getRegister();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Olmayan Bir Kaydı Güncellemeye çalıştınız!");
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Book kitap = (Book)listView.SelectedItems[0].Tag;
                txtName.Text = kitap.Name;
                txtAuthorFirstName.Text = kitap.AuthorFirstName;
                txtAuthorLastName.Text = kitap.AuthorLastName;
                cbCategory.Text = kitap.Category;
                dtpReleaseDate.Value = kitap.ReleaseDate;
            }
            catch (Exception)
            {


            }

            //txtName.Text = listBook[listView.FocusedItem.Index].Name;
            //txtAuthorFirstName.Text = listBook[listView.FocusedItem.Index].AuthorFirstName;
            //txtAuthorLastName.Text = listBook[listView.FocusedItem.Index].AuthorLastName;
            //cbCategory.Text = listBook[listView.FocusedItem.Index].Category;
            //dtpReleaseDate.Value = listBook[listView.FocusedItem.Index].ReleaseDate;
        }
    }
}
