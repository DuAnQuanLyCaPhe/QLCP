using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TasmaControl
{
    public class Cls_CTPN
    {
        public static bool Insert_CTPN(string sopn, string manv, string mahang, int soluong, string tonkho, long sotien)
        {
            bool rs = true;
            Cls_ketnoi.kn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Insert into CTPN values('{0}','{1}','{2}','{3}','{4}','{5}')", sopn, manv, mahang, soluong, tonkho, sotien), Cls_ketnoi.kn);
            cmd.ExecuteNonQuery();
            Cls_ketnoi.kn.Close();
            return rs;
        }
    }
}
