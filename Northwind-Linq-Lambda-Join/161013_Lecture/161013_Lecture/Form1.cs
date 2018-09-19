using _161013_Lecture.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161013_Lecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();

            //Extension Method - Lambda Expression

            //1. 

            //MessageBox.Show(db.Categories
            //    .Where(x=>x.CategoryName=="Beverages")
            //    .Select(x=>x.CategoryID)
            //    .FirstOrDefault()        //Aradıklarımdan sadece birini getirir
            //    .ToString());



            //2.
            //dataGridView1.DataSource = db.Products
            //    .Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
            //    .Select(x => new
            //    { 
            //        x.ProductID,
            //        x.UnitPrice,
            //        x.UnitsInStock,
            //        x.Category.CategoryName,
            //        x.Supplier.ContactName
            //    }).ToList();

            //3.OrderID si verilen siparişin miktarı ile ürün isimleri

            //dataGridView1.DataSource = db.Order_Details //İki tablo join li gibi
            //    .Where(x=>x.OrderID < 10500)
            //    .Select(x => new 
            //    { 
            //        x.OrderID, 
            //        x.Product.ProductName,
            //        x.UnitPrice,
            //        x.Quantity
            //    }).ToList();


//JOİN ile
            //4. Category-Product-OrderDetails
            dataGridView1.DataSource = db.Categories
                .Join(db.Products,
                c => c.CategoryID,
                p => p.CategoryID,
                (c, p) => new { c, p })
                .Where(cp => cp.c.CategoryID == cp.p.CategoryID)
                .Join(db.Order_Details,
                cp => cp.p.ProductID,
                od => od.ProductID, (cp, od) => new { cp, od })
                .Where(cpod => cpod.cp.p.ProductID == cpod.od.ProductID)
                .Select(x => new
                {
                    x.cp.c.CategoryName,
                    x.cp.p.ProductName,
                    x.od.OrderID
                }).ToList();

                




        }
    }
}
