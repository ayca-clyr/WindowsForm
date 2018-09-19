using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_MDIForms
{
    public partial class EmployeeForm : Form
    {
        public string _FirstName = string.Empty;
        public string _LastName = string.Empty;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeeKaydet_Click(object sender, EventArgs e)
        {
            _FirstName = txtBxEmployeeAdı.Text;
            _LastName = txtBxEmployeeSoyadı.Text;
        }
    }
}
