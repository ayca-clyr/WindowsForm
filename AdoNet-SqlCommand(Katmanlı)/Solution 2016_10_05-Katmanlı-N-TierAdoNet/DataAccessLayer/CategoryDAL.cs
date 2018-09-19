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
    public class CategoryDAL : IDataMapper<Category, Int32>
    {
        SqlCommand _command;
        public CategoryDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public int insert(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;


            _command.CommandText = "insert into Categories(CategoryName,Description) values(@name,@desc)";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@name", item.CategoryName);
            _command.Parameters.AddWithValue("@desc", item.Description);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //Form olmadığı için messageBox'la mesaj veremem. Bu şekilde hata fırlatırken bir nevi msj veriyoruz.
                throw new Exception("Ekleme başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }

        public int Update(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;


            _command.CommandText = "update Categories set CategoryName=@name,Description=@desc where CategoryId=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@name", item.CategoryName);
            _command.Parameters.AddWithValue("@desc", item.Description);
            _command.Parameters.AddWithValue("@id", item.CategoryID);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //Form olmadığı için messageBox'la mesaj veremem. Bu şekilde hata fırlatırken bir nevi msj veriyoruz.
                throw new Exception("Güncelleme başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }

        public int Delete(Category item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            _command.CommandText = "delete from Categories where CategoryID=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.CategoryID);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Silme işlemi başarısız oldu");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }

        public List<Category> GetAll()
        {
            List<Category> catList = new List<Category>();
            _command.CommandText = "select CategoryID,CategoryName,Description from Categories";
            _command.Parameters.Clear();

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                //ExecuteNonQuery=> insert , update , delete işlemlerinde etkilenen sayısını döndürür.
                //ExecuteScalar=> Select sorgusu sonucun tek bir hücre veri döndürür.

                //ExecuteReader => select sorgusu sonucu birden fazla veriyi döndürür.

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category();
                        cat.CategoryID = (int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader.IsDBNull(2) ? default(string) : reader[2].ToString();

                        catList.Add(cat);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız");
            }
            finally
            {
                _command.Connection.Close();
            }
            return catList;
        }

        public Category Get(int id)
        {
            Category cat = null;
            _command.CommandText = "select CategoryID,CategoryName,Description from Categories where CategoryID=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", id);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        cat = new Category();
                        cat.CategoryID = (int)reader[0];
                        cat.CategoryName = (string)reader[1];
                        cat.Description = reader[2] != DBNull.Value ? (string)reader[2] : default(string);
                        // -----Koşul-----      ---True----         --False
                        //Ternary if (Tek satırda if kontrolü) => Tek bir koşul için, o koşula ait var ya da yok, uyuyor ya da uymuyor gibi sadece iki farklı yolu varsa, aynı zamanda 2 yol içinde tek satırlık bir kod yazıcaksam bu yapıyı kullanıyorum. Koşul geçerliyse (soru işareti) ? işaretinden  (iki nokta üst üste) :  işaretine kadar geçerli kodu çalıştırır. Koşul geçerli değilse : dan sonraki kodu çalıştırır. 
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return cat;
        }
    }
}
