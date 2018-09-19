using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class ProductDAL : IDataMapper<Product, Int32>
    {
        SqlCommand cmd;
        public ProductDAL()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }
        public int Insert(Product item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "insert into Products(ProductName, UnitsInStock,UnitPrice) values(@name,@stock,@price)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", item.ProductName);
            cmd.Parameters.AddWithValue("@stock", item.UnitsInStock);
            cmd.Parameters.AddWithValue("@price", item.UnitPrice);

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                affectedRows = cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception("Ekleme İşlemi Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(Product item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "Update Products set ProductName=@name,UnitsInStock=@stock,UnitPrice = @price where ProductID=@id ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", item.ProductName);
            cmd.Parameters.AddWithValue("@stock", item.UnitsInStock);
            cmd.Parameters.AddWithValue("@price", item.UnitPrice);
            cmd.Parameters.AddWithValue("@id", item.ProductID);


            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                affectedRows = cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception("Güncelleme İşlemi Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return affectedRows;
        }


        public int Delete(Product item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "delete from Products where ProductId = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", item.ProductID);


            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                affectedRows = cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception("Ekleme İşlemi Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return affectedRows;
        }


        public List<Product> GetAll()
        {
            List<Product> proList = new List<Product>();
            cmd.CommandText = "select ProductID, ProductName, UnitsInStock,UnitPrice from Products";
            cmd.Parameters.Clear();

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product pro = new Product();
                        pro.ProductID =(int)reader[0];
                        pro.ProductName = reader[1].ToString();
                        pro.UnitsInStock = (Int16)reader[2];
                        pro.UnitPrice = (decimal)reader[3]; 

                        proList.Add(pro);
                    }
                }
                reader.Close();


            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();

            }

            return proList;

        }

        public Product Get(int id)
        {
            Product pro = null;
            cmd.CommandText = "select ProductId, ProductName, UnitsInStock,UnitPrice from Products where ProductId = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read()) // 1 tane döndürdüğü için while'e gerek yok. If'de kullansak olur.
                    {
                        pro = new Product();
                        pro.ProductID = (int)reader[0];
                        pro.ProductName = (string)reader[1];
                        pro.UnitsInStock = reader[2] != DBNull.Value ? (Int16)reader[2] : default(Int16);
                        pro.UnitPrice = reader[3] != DBNull.Value ? (decimal)reader[3] : default(decimal);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                
                throw new Exception("İşlem Başarısız!");
            }finally{
                cmd.Connection.Close();
            }

            return pro;
        
        }
    }
}
