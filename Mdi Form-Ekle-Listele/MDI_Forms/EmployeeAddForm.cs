﻿using System;
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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        public string _firstName = "";
        public string _lastName = "";

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {

            _firstName = txtBxFirstName.Text;
            _lastName = txtBxLastName.Text;
           
        }
    }
}
