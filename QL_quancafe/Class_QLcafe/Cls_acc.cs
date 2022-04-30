using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Class_QLcafe
{
    public class Cls_acc
    {
        public static DataTable Select_acc()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Account", Cls_ketnoi.qlcf);
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

        //public static DataTable Login_acc()
        //{ 
        //}
    }
}
