using Part_1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        OrderEditForm orderEdit;
        List<Order> order = new List<Order>();

        public Order guncellenecek;

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            gBxDate.Enabled = false; 
            cBxEmployeeName.DataSource = (from emp in db.Employees select emp).ToList();
            cBxEmployeeName.DisplayMember = "FirstName";
            cBxEmployeeName.ValueMember = "EmployeeID";
            cBxEmployeeName.Text = "";
            dGVOrders.DataSource = db.Orders.ToList();

        }
        private void Yenile(List<Order> name)
        {

            dGVOrders.DataSource = null;
            dGVOrders.DataSource = name;
        }

 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.CustomerID = txtBxCompany.Text;

            List<Order> result = (
                from o in db.Orders
                where o.CustomerID.ToLower().StartsWith(ord.CustomerID)
                orderby o.CustomerID
                select o).ToList();
            Yenile(result);
        }

        private void cBxEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxEmployeeName.SelectedIndex > -1)
            {
                Order order = new Order();
                order.EmployeeID = cBxEmployeeName.SelectedIndex + 1;



                List<Order> result = (
                    from o in db.Orders
                    where o.EmployeeID.ToString().Contains(order.EmployeeID.ToString())
                    orderby o.EmployeeID
                    select o).ToList();

                Yenile(result);
            }
        }

        private void rBtnEqual_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dTPOrderDate2.Visible = false;

            Order order = new Order();
            order.OrderDate =DateTime.Parse(dTPOrderDate1.Value.ToString());
            
            List<Order> result = (from o in db.Orders
                                  where o.OrderDate.Value == order.OrderDate
                                  orderby o.OrderDate
                                  select o).ToList();

            Yenile(result);
        }

        private void rBtnNotEqual_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dTPOrderDate2.Visible = false;
            Order order = new Order();
            order.OrderDate = DateTime.Parse(dTPOrderDate1.Value.ToString());

            List<Order> result = (from o in db.Orders
                                  where !(o.OrderDate.Value.ToString().Contains(order.OrderDate.ToString()))
                                  orderby o.OrderDate
                                  select o).ToList();

            Yenile(result);
        }

        private void rBtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dTPOrderDate2.Visible = false;
            Order order = new Order();
            order.OrderDate = DateTime.Parse(dTPOrderDate1.Value.ToString());

            List<Order> result = (from o in db.Orders
                                  where o.OrderDate.Value > order.OrderDate
                                  orderby o.OrderDate
                                  select o).ToList();

            Yenile(result);
        }

        private void rBtnLittle_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dTPOrderDate2.Visible = false;
            Order order = new Order();
            order.OrderDate = DateTime.Parse(dTPOrderDate1.Value.ToString());

            List<Order> result = (from o in db.Orders
                                  where o.OrderDate.Value < order.OrderDate
                                  orderby o.OrderDate
                                  select o).ToList();

            Yenile(result);
        }

        private void rBtnBetween_CheckedChanged(object sender, EventArgs e)
        {
           
                dTPOrderDate2.Visible = true;
                label4.Visible = true;
                if(dTPOrderDate1.Value < dTPOrderDate2.Value)
                {
                    DateTime date1 = DateTime.Parse(dTPOrderDate1.Value.ToString());
                    DateTime date2 = DateTime.Parse(dTPOrderDate2.Value.ToString());


                    List<Order> result = (from o in db.Orders
                                          where o.OrderDate.Value < date2 && o.OrderDate.Value > date1
                                          orderby o.OrderDate
                                          select o).ToList();

                    Yenile(result);
                    
                }else if(dTPOrderDate1.Value > dTPOrderDate2.Value)
                {
                    DateTime date1 = DateTime.Parse(dTPOrderDate1.Value.ToString());
                    DateTime date2 = DateTime.Parse(dTPOrderDate2.Value.ToString());


                    List<Order> result = (from o in db.Orders
                                          where o.OrderDate.Value > date2 && o.OrderDate.Value < date1
                                          orderby o.OrderDate
                                          select o).ToList();

                    Yenile(result);

                
            }
        }

        private void btnDateActive_Click(object sender, EventArgs e)
        {
            gBxDate.Enabled = true;
        }
    }
}
