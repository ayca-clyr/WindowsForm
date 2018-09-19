using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<Category> catList;
        List<Product> proList;
        private void Form1_Load(object sender, EventArgs e)
        {
            catList = new List<Category>();

            // Uzun Yazımı
            //Category cat = new Category();
            //cat.CategoryID = 1;
            //cat.CategoryName = "Elektronik";
            //catList.Add(cat);

            // Kısa Yazımı
            catList = new List<Category>();
            catList.Add(new Category() { CategoryID = 1, CategoryName = "Elektronik" });
            catList.Add(new Category() { CategoryID = 2, CategoryName = "Giyim" });
            catList.Add(new Category() { CategoryID = 3, CategoryName = "Yiyecek" });
            catList.Add(new Category() { CategoryID = 4, CategoryName = "Sağlık" });

            proList = new List<Product>();

            proList.Add(new Product() { ProductID = 1, ProductName = "HP Laptop", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 2, ProductName = "Lenova Masaüstü", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 3, ProductName = "DELL Laptop", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 4, ProductName = "T-Shirt", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 5, ProductName = "Gömlek", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 6, ProductName = "Pantolon", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 7, ProductName = "Hamburger", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 8, ProductName = "Kek", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 9, ProductName = "Kısır", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 10, ProductName = "Aspirin", CategoryID = 4 });


        }


        private void btnQuery1_Click(object sender, EventArgs e)
        {
            // Tüm Liste
            var result = (
                from cat in catList
                join pro in proList on cat.CategoryID equals pro.CategoryID
                select new
                {
                    CategoryID = cat.CategoryID,
                    CategoryName = cat.CategoryName,
                    ProductID = pro.ProductID,
                    ProductName = pro.ProductName,
                    FullName = cat.CategoryName + " " + pro.ProductName
                }
                ).ToList();
            lstQuery.ValueMember = "ProductID";
            lstQuery.DisplayMember = "FullName";
            lstQuery.DataSource = result;
            dGVQuery.DataSource = result;


            var result2 = (
               from cat in catList
               join pro in proList on cat.CategoryID equals pro.CategoryID
               select new
               {
                   CategoryID = cat.CategoryID,
                   CategoryName = cat.CategoryName,
                   ProductID = pro.ProductID,
                   ProductName = pro.ProductName,
                   FullName = cat.CategoryName + " " + pro.ProductName
               }
               ).ToList();
            cmbBxCategory.DataSource = result2;
            cmbBxCategory.ValueMember = "CategoryID"; // Arka planda tutulan
            cmbBxCategory.DisplayMember = "CategoryName";// Bize Görünen
        }



        private void cmbBxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            var result = (
                  from cat in catList
                  join pro in proList on cat.CategoryID equals pro.CategoryID
                  group cat by cat.CategoryName into grp
                  select new
                  {
                      Key = grp.Key,
                      ToplamSayi = grp.Count()
                  }
                  ).ToList();
            listBox1.DataSource = result;
            //dataGridView1.DataSource = result;


          //  lstQuery.DataSource = null;
          //  var result3 = (
          //      from cat in catList
          //      join pro in proList on cat.CategoryID equals pro.CategoryID
          //      where cat.CategoryID == ((Category)cmbBxCategory.SelectedItem).CategoryID
          //      group cat by cat.CategoryName into grp
          //      select new
          //      {
          //          Key = grp.Key,
          //          ToplamSayi = grp.Count()
          //      }
          //      ).ToList();

          //  lstBxQuery.DataSource = result;
          //  //lstBxProduct.ValueMember = "Key";
          //  lstBxQuery.DisplayMember = "Key" + "ToplamSayi";


          //  var result2 =
          //(from cat in catList
          // join pro in proList on cat.CategoryID equals pro.CategoryID
          // where cat.CategoryID == ((Category)cmbBxCategory.SelectedItem).CategoryID
          // select pro.ProductName
          //);

          //  lstBxProduct.DataSource = result2.ToList();


        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var result = ((
                  from cat in catList
                  join pro in proList on cat.CategoryID equals pro.CategoryID
                  group cat by cat.CategoryName into grp
                  select new
                  {
                      Key = grp.Key,
                      ToplamSayi = grp.Count()
                  }
                  )).Distinct().ToList();
            dataGridView1.DataSource = result;



        }
    }
}
