using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAL : IDataMapper<Category, Int32>
    {
        // ExecureNonQuery => insert, update, delete işlemlerinde etkilenen satır sayının döndürür.
        // ExecuteScalar => Select sorgusu sonucun tek bir hücre veri döndürür. Where koşulunda id 'ye göre çekiyoruz. Buda bize tek hücre veri döndürür demektir.
        // ExecuteReader => select sprgusu sonucu birden fazla veriyi döndürür. Ama koşul yoksa veya birden fazlaysa Reader yapmak zorundayız.
        SqlCommand cmd;
        public CategoryDAL()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }
        public int Insert(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "insert into Categories(CategoryName, Description) values(@name,@desc)";

            cmd.Parameters.Clear(); // Parametleri önce sil sonra ekle. Çünkü her seferinde bunu kullanıcaz. O yüzden önce silmek lazım.

            cmd.Parameters.AddWithValue("@name", item.CategoryName);
            cmd.Parameters.AddWithValue("@desc", item.Description);

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ekleme Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();

            }

            return affectedRows;
        }

        public int Update(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "update Categories set CategoryName = @name, Description=@desc where CategoryId=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name",item.CategoryName);
            cmd.Parameters.AddWithValue("@desc",item.Description);
            cmd.Parameters.AddWithValue("@id",item.CategoryID);
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                affectedRows = cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                
                throw new Exception("Güncelleme Başarısız!");
            }
            finally
            {
                cmd.Connection.Close();
            }
            return affectedRows;

        }

        public int Delete(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            cmd.CommandText = "delete from Categories where CategoryId = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id",item.CategoryID);
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Silme Başarısız!"); 
              
            }
            finally
            {
                cmd.Connection.Close();
            }


            return affectedRows;
        }

        public List<Category> GetAll()
        {
            List<Category> catList = new List<Category>();
            cmd.CommandText = "select CategoryID,CategoryName,Description from Categories";
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
                        Category cat = new Category();
                        cat.CategoryID =(int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader.IsDBNull(2) ? default(string) : reader[2].ToString();

                        catList.Add(cat);
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

            return catList;
        }

        public Category Get(int id)
        {
            Category cat = null;
            cmd.CommandText = "select CategoryID, CategoryName, Description from Categories where CategoryID = @id";
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
                        cat = new Category();
                        cat.CategoryID = (int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader[2] != DBNull.Value ? (string)reader[2] : default(string); //Satır boş değilse {reader[2] != DBNull.Value} direk oku ?'den sonraki kısım {(string)reader[2]} : üstte değilse yani boşsa default değerini ata.{default(string)}
                        // Ternary if(Tek satırda if kontrolü) => Tek bir koşul için, o koşula ait var ya da yok, uyuyor ya da uymuyor gibi sadece iki farklı yolu varsa , aynı zamanda 2 yol içinde tek satırlık bir kod yazıcaksam bu yapıyı kullanıyorum. 
                        // Koşul geçerliyse " ? işaretinden :'e işaretine kadar geçerli kodu çalıştırır." Koşul geçerli değilse "  : 'dan sonraki kodu çalıştırır."
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

            return cat;
        }
    }
}
