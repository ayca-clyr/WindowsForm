using BussinessLayer;
using Entities;
using Login.Business_Alanyst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        EmployeeBLL _employeeBLL;
        Employee _employee;

        public Login()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _employee = new Employee();
        }

        public Login(int id)
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _employee = _employeeBLL.Get(id);
        }
        Random rnd = new Random();
        int random;
        private void Login_Load(object sender, EventArgs e)
        {
            
            random = rnd.Next(10000, 99999);
            lblRandomNumber.Text = random.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            random = rnd.Next(10000, 99999);
            lblRandomNumber.Text = random.ToString();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtBxEmail.Text))
                {
                    MessageBox.Show("Lütfen Mailinizi Giriniz!");
                    txtBxEmail.Text = "";
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(txtBxPassword.Text))
                    {
                        MessageBox.Show("Lütfen Şifrenizi Giriniz!");
                        txtBxPassword.Text = "";
                    }
                    else
                    {
                        if (txtBxSecurityNumber.Text != lblRandomNumber.Text)
                        {
                            MessageBox.Show("Lütfen Yandaki Sayıyı Doğru Giriniz!");
                            random = rnd.Next(10000, 99999);
                            lblRandomNumber.Text = random.ToString();
                            txtBxSecurityNumber.Text = "";
                        }
                        else
                        {
                            
                            Employee employee = _employeeBLL.Get(txtBxEmail.Text, txtBxPassword.Text);
                            
                            if (employee.AcoountTypeID == 1)
                            {
                                ProjectManagement proManagement = new ProjectManagement();
                                MessageBox.Show("Proje Yöneticisi Olarak Başarılı bir şekilde giriş yaptınız. İlgili sayfaya yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                proManagement.Show();
                                this.Hide();
                            }
                            else if (employee.AcoountTypeID == 2)
                            {
                                TeamLeaderLogin teamLeader = new TeamLeaderLogin();
                                MessageBox.Show("Takım Lideri Olarak Başarılı bir şekilde giriş yaptınız. İlgili sayfaya yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                teamLeader.Show();
                                this.Hide();
                            }
                            else if (employee.AcoountTypeID == 3)
                            {
                                BusinessAnalystLogin busiAnalyst = new BusinessAnalystLogin();
                                MessageBox.Show("İş Analisti Olarak Başarılı bir şekilde giriş yaptınız. İlgili sayfaya yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                busiAnalyst.Show();
                                this.Hide();
                            }
                            else if (employee.AcoountTypeID == 4)
                            {
                                TestingSpecialist test = new TestingSpecialist();
                                MessageBox.Show("Test Uzmanı Olarak Başarılı bir şekilde giriş yaptınız. İlgili sayfaya yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                test.Show();
                                this.Hide();
                            }
                            else if (employee.AcoountTypeID == 5)
                            {
                                SoftwareDeveloper soft = new SoftwareDeveloper();
                                MessageBox.Show("Yazılım Uzmanı Olarak Başarılı bir şekilde giriş yaptınız. İlgili sayfaya yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                soft.Show();
                                this.Hide();
                            }
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                txtBxEmail.Text = "";
                txtBxPassword.Text = "";
                txtBxSecurityNumber.Text = "";
                random = rnd.Next(10000, 99999);
                lblRandomNumber.Text = random.ToString();

            }
            
        }

        private void txtBxSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
