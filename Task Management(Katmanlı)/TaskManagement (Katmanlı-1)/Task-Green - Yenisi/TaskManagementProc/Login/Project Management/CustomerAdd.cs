using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class CustomerRegistery : Form
    {
        public static int ID;
        CustomerBLL _cusBLL;
        Customer _cusEntitiy;
        List<string> _mail;
        public Customer _customer;
        bool isSave = false;

        public CustomerRegistery()
        {
            InitializeComponent();
            _cusBLL = new CustomerBLL();
            _cusEntitiy = new Customer();
            _mail = new List<string>();
            _customer = new Customer();
            isSave = true;
            btnSave.Text = "Kaydet";
        }

        public CustomerRegistery(int id)
        {
            InitializeComponent();
            _cusBLL = new CustomerBLL();
            _cusEntitiy = _cusBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelleme";
        }

        private void cmbContactName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CustomersList()
        {
            dgvCustomerList.DataSource = null;
            dgvCustomerList.DataSource = _cusBLL.GetAll();
        }
        private void CustomerRegistery_Load(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(TextBox_SelectedChanged);
            CustomersList();
        }

        private void TextBox_SelectedChanged(object sender, EventArgs e)
        {
            int counter = this.Controls.Count;
            for (int i = 0; i < counter; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    if (this.ActiveControl == this.Controls[i])
                        this.Controls[i].BackColor = Color.Aqua;
                    else
                        this.Controls[i].BackColor = Color.White;
                }
            }
        }
        private void Clear()
        {
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtAdress.Text = "";
            txtEMail.Text = "";
            mPhone.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result;
            _cusEntitiy.ContactName = txtContactName.Text;
            _cusEntitiy.CompanyName = txtCompanyName.Text;
            _cusEntitiy.Address = txtAdress.Text;
            _cusEntitiy.Phone = mPhone.Text;

            foreach (Customer item in _cusBLL.GetAll())
            {
                _mail.Add(item.Email);
            }
            if (isSave)
            {
                _cusEntitiy.Email = txtEMail.Text;
                if (_mail.Contains(txtEMail.Text))
                {
                    MessageBox.Show("Sistem Bu mail Adresiyle Alınmış Bir Kayıt Bulunmaktadır! Lütfen Başka Bir Mail Adresiyle Kayıt Yapınız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEMail.Text = "";
                }
                else
                {
                    try
                    {
                        if (txtEMail.Text != "" && txtContactName.Text != "" && txtCompanyName.Text != "" && txtAdress.Text != "")
                        {
                            var mail = new MailAddress(txtEMail.Text);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Boş Bırakmayınız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (mPhone.Text.Length == 14)
                        {
                            result = _cusBLL.Add(_cusEntitiy);
                            Clear();
                            if (result)
                            {
                                MessageBox.Show("Ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CustomersList();

                            }
                            else
                            {
                                MessageBox.Show("Ekleme işlemi başarısız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Numarayı Eksik Girdiniz. Lütfen Tekrar Kontrol Ediniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen Maili Doğru Formatta Giriniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEMail.Text = "";
                    }
                }
            }
            else
            {
                int id = (int)dgvCustomerList.SelectedRows[0].Cells[0].Value;
                _cusEntitiy.Email = txtEMail.Text;

                if (_mail.Contains(txtEMail.Text) && _cusEntitiy.CustomerID != id)
                {
                    MessageBox.Show("Sistem Bu mail Adresiyle Alınmış Bir Kayıt Bulunmaktadır! Lütfen Başka Bir Mail Adresi Giriniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEMail.Text = "";
                }
                else
                {

                    try
                    {
                        if (txtEMail.Text != "" && txtContactName.Text != "" && txtCompanyName.Text != "" && txtAdress.Text != "")
                        {
                            var mail = new MailAddress(txtEMail.Text);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Boş Bırakmayınız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (mPhone.Text.Length == 14)
                        {
                            result = _cusBLL.Update(_cusEntitiy);
                            Clear();
                            if (result)
                            {
                                MessageBox.Show("Güncelleme işleminiz gerçekleşmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CustomersList();
                                btnSave.Text = "Kaydet";
                                isSave = true;
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme işleminiz başarısız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Numarayı Eksik Girdiniz. Lütfen Tekrar Kontrol Ediniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen Maili Doğru Formatta Giriniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEMail.Text = "";
                    }
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID = (int)dgvCustomerList.SelectedRows[0].Cells[0].Value;
            _cusEntitiy = _cusBLL.Get(ID);
            txtAdress.Text = _cusEntitiy.Address;
            txtCompanyName.Text = _cusEntitiy.CompanyName;
            txtContactName.Text = _cusEntitiy.ContactName;
            txtEMail.Text = _cusEntitiy.Email;
            mPhone.Text = _cusEntitiy.Phone;
            btnSave.Text = "Güncelle";
            isSave = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID = (int)dgvCustomerList.SelectedRows[0].Cells[0].Value;
            _cusEntitiy = _cusBLL.Get(ID);
            DialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult == DialogResult.Yes)
            {
                bool result = _cusBLL.Remove(_cusEntitiy);
                if (result)
                {
                    MessageBox.Show("İşlem Gerçekleşti", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CustomersList();
                }
                else
                {
                    MessageBox.Show("İşlem Gerçekleşmedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
