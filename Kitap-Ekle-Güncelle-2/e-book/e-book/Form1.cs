using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_book
{
    public partial class Form1 : Form
    {
        Book book;
        List<Book> listBook = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.TextLength>0 && txtBookName.TextLength>0 && cBoxCategory.SelectedIndex>=0)
            {
                book = new Book();
                book.BookName = txtBookName.Text;
                book.AuthorFullName = txtAuthorName.Text;
                book.ReleaseDate = dtpReleaseDate.Value;
                book.CategoryName = cBoxCategory.SelectedItem.ToString();
                listBook.Add(book);
                lViewAllInformationWirte();
                MessageBox.Show("Kayıt işlemi başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Clear()
        {
            txtAuthorName.Text = txtBookName.Text = "";
            dtpReleaseDate.Value = DateTime.Now;
            cBoxCategory.SelectedIndex =-1;
        }

        private void lViewAllInformationWirte()
        {
            lViewAllInformation.Items.Clear();
            foreach (Book book in listBook)
            {

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = book.BookName;
                listViewItem.SubItems.Add(book.AuthorFullName);
                listViewItem.SubItems.Add(book.CategoryName);
                listViewItem.SubItems.Add(book.ReleaseDate.ToShortDateString());
                listViewItem.Tag = book;
                lViewAllInformation.Items.Add(listViewItem);
            }
        }

        private void lViewAllInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            book = listBook[lViewAllInformation.FocusedItem.Index];
            txtBookName.Text = book.BookName;
            txtAuthorName.Text = book.AuthorFullName;
            cBoxCategory.SelectedItem = book.CategoryName;
            dtpReleaseDate.Value = book.ReleaseDate;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ((Book)lViewAllInformation.SelectedItems[0].Tag).BookName = txtBookName.Text;
                ((Book)lViewAllInformation.SelectedItems[0].Tag).AuthorFullName = txtAuthorName.Text;
                ((Book)lViewAllInformation.SelectedItems[0].Tag).CategoryName = cBoxCategory.SelectedItem.ToString();
                ((Book)lViewAllInformation.SelectedItems[0].Tag).ReleaseDate = dtpReleaseDate.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme yapmak için bir kayıt seçiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                lViewAllInformationWirte();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Seçilen kitabı silmek istedğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    listBook.Remove((Book)lViewAllInformation.SelectedItems[0].Tag);
                    MessageBox.Show("Silme işlemi başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                lViewAllInformationWirte();
            }
        }
    }
}
