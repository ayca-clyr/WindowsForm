using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ForgetPassword : Form
    {


        Employee employe;
        EmployeeBLL _employeeBLL;
        List<string> _mail;

        public ForgetPassword()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            employe = new Employee();
            _mail = new List<string>();

        }
        public ForgetPassword(int id)
        {
            _employeeBLL = new EmployeeBLL();
            employe = _employeeBLL.Get(id);
            _mail = new List<string>();

        }
        public void GetMail(string email)
        {


        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            //GetMail(txtMail.Text);


            foreach (Employee item in _employeeBLL.GetAll())
            {
                _mail.Add(item.Email);
            }
            Login lg = new Login();
            Employee emp = _employeeBLL.GetMailRemember(txtMail.Text);

            if (_mail.Contains(txtMail.Text))
            {
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Boş Bırakmayınız!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                try
                {

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    MailMessage mesaj = new MailMessage();
                    mesaj.To.Add(txtMail.Text);
                    mesaj.From = new MailAddress("asdas@gmail.com");
                    mesaj.Subject = "Şifremi Unuttum";
                    mesaj.Body = string.Format(" Sayın : {0} \n İş Yönetimine Ait Şifreniz :{1}", emp.FullName, emp.Password);
                    NetworkCredential guvenlik = new NetworkCredential("Garbondioksit1@gmail.com", "159753242Gf");
                    client.Credentials = guvenlik;
                    client.EnableSsl = true;
                    client.Send(mesaj);
                    MessageBox.Show("Şifreniz Başarıyla E-Mail Adresinize Gönderilmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtMail.Text = "";
                    lg.Activate();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Mail Gönderme Başarısız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtMail.Text = "";


                }

            }
        }
    }
}
