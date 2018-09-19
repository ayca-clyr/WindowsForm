using Linq_Entity_Lamda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Entity_Lamda
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

            // Extension Method - Lambda Expression
            // dGVQuery.DataSource = db.Categories.ToList();

            // dGVQuery.DataSource = db.Categories
            //                         .Where(x => x.CategoryID > 5).ToList();

            // FirstOrDefault'da aradıklarımdan sadece ilkini getir.

            // MessageBox.Show(db.Categories
            //                    .Where(x => x.CategoryName == "Beverages")
            //                   .Select(x => x.CategoryID).FirstOrDefault().ToString());

            //dGVQuery.DataSource = db.Products
            //                        .Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
            //                        .Select(x => new{                               
            //                                x.ProductName,
            //                                x.UnitPrice,
            //                                x.UnitsInStock,
            //                                x.Category.CategoryName,
            //                                x.Supplier.SupplierID
            //                                }).ToList();

            // OrderID si verilen siparişin miktarı ile ürün isimleri

            //dGVQuery.DataSource = db.Order_Details
            //                         .Where(x=>x.OrderID < 10500)
            //                         .Select(x => new { 
            //                                 x.OrderID, 
            //                                 x.Quantity, 
            //                                 x.Product.ProductName,
            //                                 x.UnitPrice }).ToList();

#region 1. Yazım Join'li (Category - Product - OrderDetails)
            dGVQuery.DataSource = db.Categories
                                    .Join(db.Products, 
                                            cat => cat.CategoryID, 
                                            pro => pro.CategoryID, 
                                            (cat, pro) => new { cat, pro })
                                    .Where(catPro => catPro.cat.CategoryID == catPro.pro.CategoryID)
                                    .Join(db.Order_Details, 
                                            catPro => catPro.pro.ProductID, 
                                            od => od.ProductID, 
                                            (catPro, od) => new { catPro, od })
                                    .Where(catProOd => catProOd.catPro.pro.ProductID == catProOd.od.ProductID)
                                    .Where(x=>x.catPro.pro.UnitPrice >= 100)
                                    .Select(x => new
                                    {
                                        x.catPro.cat.CategoryName,
                                        x.catPro.pro.ProductName,
                                        x.od.OrderID
                                    }).ToList(); 
            #endregion

#region 2. Yazım
            dGVQuery.DataSource = db.Order_Details
                                       .Where(x => x.Product.UnitPrice >= 100)
                                       .Select(x => new
                                       {
                                           x.Product.Category.CategoryName,
                                           x.Product.ProductName,
                                           x.OrderID
                                       }).ToList(); 
            #endregion

           // Venezuelaya gönderilecek olan siparişlerin hangi çalışanım tarafından sipariş alındığını bu çalışanımın kime rapor gönderdiğini bu siparişin hangi kargo ve hangi şirkete gönderileceğini, son olarakta bu kargo şirketinin telefonunu istemekteyiz.

            //from o in db.Orders
            //    join em in db.Employees on o.EmployeeID equals em.EmployeeID
            //    join em1 in db.Employees on em.EmployeeID equals em1.EmployeeID
            //    join shi in db.Shippers on o.ShipVia equals shi.ShipperID
            //    where o.ShipCountry == "Venezuela"

             //em.FirstName,
             //       em.LastName,
             //       em1.ReportsTo,
             //       shi.CompanyName,
             //       o.ShipName,
             //       shi.Phone


            dGVQuery.DataSource = db.Orders
                                     .Join(db.Employees,
                                     o => o.EmployeeID,
                                     emp => emp.EmployeeID,
                                     (o,emp) => new {o,emp})
                                     .Where(oEmp => oEmp.emp.EmployeeID == oEmp.o.EmployeeID)
                                    .Join(db.Shippers,
                                    oEmp => oEmp.o.ShipVia,
                                    shi => shi.ShipperID,
                                    (oEmp, shi) => new {oEmp,shi})
                                    .Where(oEmpShi => oEmpShi.oEmp.o.ShipVia == oEmpShi.shi.ShipperID)
                                    .Where(x=>x.oEmp.o.ShipCountry == "Venezuela")
                                    .Select(x=> new{
                       x.oEmp.emp.FirstName,
                       x.oEmp.emp.LastName,
                       x.oEmp.emp.ReportsTo,
                       x.shi.CompanyName,
                       x.shi.Phone,
                       x.oEmp.o.ShipVia
                                    }).ToList();

                                     
        }
    }
}
