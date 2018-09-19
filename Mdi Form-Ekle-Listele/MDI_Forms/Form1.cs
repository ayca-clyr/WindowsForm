using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Forms
{
    public partial class Form1 : Form
    {
        // MDI
        // Multiple Document Interface 
        // Çoklu Belge(Form) Arayüzü
        // Formun Propertiesinden ISMdiContainer'ı True yap!
        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

       public EmployeeAddForm employeeAddForm = new EmployeeAddForm();
       public EmployeeListForm employeeAddList = new EmployeeListForm();
        public StockAddForm stockAddForm = new StockAddForm(); 
        private void menuItemNewEmployee_Click(object sender, EventArgs e)
        {
            

            employeeAddForm.MdiParent = this;
            employeeAddForm.Show();
            employeeAddForm.btnEmployeeSave.Click += new EventHandler(BtnEmployeeSave_Click);
            employeeAddList.MdiParent = this;
            employeeAddList.Show();
            stockAddForm.MdiParent = this;
            stockAddForm.Show();
            stockAddForm.btnSaveStock.Click +=  new EventHandler(BtnSaveStock_Click);
            employeeAddList.MdiParent = this;
            employeeAddList.Show();
            
           
         
        }

        private void BtnSaveStock_Click(object sender, EventArgs e)
        {
            int stockAdedi = stockAddForm._stockMiktarı;
            
        }

        private void BtnEmployeeSave_Click(object sender, EventArgs e)
        {
            string firstName = employeeAddForm._firstName;
            string lastName = employeeAddForm._lastName;
            employeeAddList.lstBxEmployees.Items.Add(firstName + " " + lastName + "    "+stockAddForm._stockMiktarı);
        }

        private void menuItemEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.Show();

            employeeListForm.MdiParent = this;
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void basamakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ikonlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void hepsiniKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //  this.MdiChildren[0].Close();
            DialogResult result = MessageBox.Show("Tüm pencereleri kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                foreach (Form form in this.MdiChildren)
                // Bana Formlar arasında öyle bir form getir ki, bu form mdi'nin childiren'i olsun.)
                {
                    form.Close();
                }
            }
        }
    }
}
