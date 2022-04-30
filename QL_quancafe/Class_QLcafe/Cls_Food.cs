using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Class_QLcafe
{
    public class Cls_Food
    {
        public static DataTable find_Food(string id)
        {
            DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Food where idCategory="+id, Cls_ketnoi.qlcf);
                da.Fill(dt);
            return dt;
        }

        public static DataTable find_gia(string gia)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Food where price" + gia, Cls_ketnoi.qlcf);
            da.Fill(dt);
            return dt;
        } 
        public static DataTable Select_idfood()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from FoodCategory", Cls_ketnoi.qlcf);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Cls_ketnoi.qlcf.Close();
            }
            return dt;
        }
            public static DataTable Select_food()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Food", Cls_ketnoi.qlcf);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Cls_ketnoi.qlcf.Close();
            }
            return dt;
        }
    }
}
