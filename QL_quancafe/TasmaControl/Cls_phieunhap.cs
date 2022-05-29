using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TasmaControl
{
    public class Cls_phieunhap
    {
        public static DataTable Select_phieunhap()
        {
            DataTable dt = new DataTable();
            Cls_ketnoi.kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *from PHIEUNHAP", Cls_ketnoi.kn);
            da.Fill(dt);
            Cls_ketnoi.kn.Close();
            return dt;
        }
        public static string Sinh_ma()
        {
            string ma;
            int sodong = Convert.ToInt32(Cls_phieunhap.Select_phieunhap().Rows.Count + 1);
            if (sodong < 10)
            {
                ma = "PN-0" + sodong;
            }
            else
            {
                ma = "PN-" + sodong;
            }
            return ma;
        }
        public static bool Insert_PN(string sopn, string sokho, string ngaynhap, string thanhtien)
        {
            bool rs = true;
            Cls_ketnoi.kn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Insert into PHIEUNHAP(SOPN,SOKHO,NGAYNHAP,THANHTIEN) values('{0}','{1}','{2}','{3}')", sopn, sokho, ngaynhap, thanhtien), Cls_ketnoi.kn);
            cmd.ExecuteNonQuery();
            Cls_ketnoi.kn.Close();
            return rs;
        }
        public static DataTable Select_PN_theongay(string ngaydau, string ngaycuoi)
        {
            DataTable dt = new DataTable();
            Cls_ketnoi.kn.Open();
            SqlDataAdapter da = new SqlDataAdapter(String.Format("Select *from PHIEUNHAP where NGAYNHAP between '{0}' and '{1}'", ngaydau, ngaycuoi), Cls_ketnoi.kn);
            da.Fill(dt);
            Cls_ketnoi.kn.Close();
            return dt;
        }
        public static DataTable Tiendatra(string sopn, int input)
        {
            DataTable dt = new DataTable();
            Cls_ketnoi.kn.Open();
            SqlDataAdapter da = new SqlDataAdapter(String.Format("Select sum(TIENDATRA + '{1}') as thanhtien from PHIEUNHAP where SOPN='{0}'", sopn, input), Cls_ketnoi.kn);
            da.Fill(dt);
            Cls_ketnoi.kn.Close();
            return dt;
        }
    }
}
