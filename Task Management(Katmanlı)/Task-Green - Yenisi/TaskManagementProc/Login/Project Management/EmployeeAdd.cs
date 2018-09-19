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
    public partial class EmployeeForm : Form
    {
        EmployeeBLL _empBLL;
        Employee _emp;
        AccountTypeBLL _accBLL;
        List<string> _mail;
        bool isSave = false;
        public static int ID;

        public EmployeeForm()
        {
            InitializeComponent();
            _empBLL = new EmployeeBLL();
            _emp = new Employee();
            _accBLL = new AccountTypeBLL();
            _mail = new List<string>();
            isSave = true;
            btnSave.Text = "Kaydet";
        }

        public void EmployeeList()
        {
            dGVEmployeeList.DataSource = null;
            dGVEmployeeList.DataSource = _empBLL.GetAll();
         
            dGVEmployeeList.Columns[4].Visible = false;

    }
        public EmployeeForm(int id)
        {
            InitializeComponent();
            _empBLL = new EmployeeBLL();
            _accBLL = new AccountTypeBLL();
            _emp = _empBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelleme";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result;
            _emp.FirstName = txtBxFirstName.Text;
            _emp.LastName = txtBxLastName.Text;
            _emp.Phone = mBxPhone.Text;
            _emp.Password = txtBxPassword.Text;
            _emp.AcoountTypeID = (int)cBxAccountID.SelectedValue;

            foreach (Employee item in _empBLL.GetAll())
            {
                _mail.Add(item.Email);
            }
            if (isSave)
            {
                _emp.Email = txtBxEmail.Text;
                if (_mail.Contains(txtBxEmail.Text))
                {
                    MessageBox.Show("Sistemde Bu Mail Adresiyle Kaydınız Bulunmaktadır.Lütfen Başka Bir Mail Adresiyle Kayıt Olunuz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxEmail.Text = "";
                }
                else
                {
                    try
                    {
                        if (txtBxEmail.Text != "" && txtBxFirstName.Text != "" && txtBxLastName.Text != "" && txtBxPassword.Text != "")
                        {
                            var mail = new MailAddress(txtBxEmail.Text);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Boş Bırakmayınız!");
                        }
                        if (mBxPhone.Text.Length == 14)
                        {
                            result = _empBLL.Add(_emp);
                            Clear();
                            if (result)
                            {
                                MessageBox.Show("Ekle İşleminiz Başarıyla Gerçekleşmiştir", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                EmployeeList();

                            }
                            else
                            {
                                MessageBox.Show("Ekleme Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Numarayı Eksik Girdiniz! Lütfen Tekrar Kontrol Ediniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException)
                    {

                        MessageBox.Show("Lütfen Maili Doğru Formatta Giriniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBxEmail.Text = "";
                    }
                }
            }
            else
            {
                try
                {
                    if (txtBxEmail.Text != "" && txtBxFirstName.Text != "" && txtBxLastName.Text != "" && txtBxPassword.Text != "")
                    {
                        var mail = new MailAddress(txtBxEmail.Text);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Boş Bırakmayınız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (mBxPhone.Text.Length == 14)
                    {
                        result = _empBLL.Update(_emp);
                        Clear();
                        if (result)
                        {
                            MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşmiştir!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            EmployeeList();
                            btnSave.Text = "Kaydet";
                            isSave = true;
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme İşleminiz Başarısız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numarayı Eksik Girdiniz.Lütfen Tekrar Kontrol Ediniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen Maili Doğru Formatta Giriniz!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxEmail.Text = "";
                }
            }
        }
        private void Clear()
        {
            txtBxEmail.Text = "";
            txtBxFirstName.Text = "";
            txtBxLastName.Text = "";
            txtBxPassword.Text = "";
            mBxPhone.Text = "";
            cBxAccountID.Text = "";
        }
        public void GetCategoryCombobx()
        {
            cBxAccountID.DataSource = _accBLL.GetAll();
            cBxAccountID.DisplayMember = "Name";
            cBxAccountID.ValueMember = "AccountTypeID";
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetCategoryCombobx();
            EmployeeList();
            Application.Idle += new EventHandler(TextBox_SelectedChanged);
        }

        private void TextBox_SelectedChanged(object sender, EventArgs e)
        {
            int counter = this.Controls.Count;
            for (int i = 0; i < counter; i++)
            {
                if (this.Controls[i] is TextBox || this.Controls[i] is Button || this.Controls[i] is ComboBox)
                {
                    if (this.ActiveControl == this.Controls[i])
                        this.Controls[i].BackColor = Color.Aqua;
                    else
                        this.Controls[i].BackColor = Color.White;
                }
            }
        }

        public void GetUpdate()
        {
            ID = (int)dGVEmployeeList.SelectedRows[0].Cells[0].Value;
            _emp = _empBLL.Get(ID);
            txtBxFirstName.Text = _emp.FirstName;
            txtBxLastName.Text = _emp.LastName;
            txtBxPassword.Text = _emp.Password;
            mBxPhone.Text = _emp.Phone;
            txtBxEmail.Text = _emp.Email;
            cBxAccountID.SelectedValue = _emp.AcoountTypeID;
            btnSave.Text = "Güncelle";
            isSave = false;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCategoryCombobx();
            GetUpdate();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID = (int)dGVEmployeeList.SelectedRows[0].Cells[0].Value;
            _emp = _empBLL.Get(ID);
            DialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult == DialogResult.Yes)
            {
                bool result = _empBLL.Remove(_emp);
                if (result)
                {
                    MessageBox.Show("İşlem Gerçekleşti", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    EmployeeList();
                }
                else
                {
                    MessageBox.Show("İşlem Gerçekleşmedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtBxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtBxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }
    }
}
