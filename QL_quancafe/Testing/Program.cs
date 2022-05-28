using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TasmaControl;
namespace Testing
{
    class Program
    {
        public static SqlConnection kn = new SqlConnection(
            @"Server=DESKTOP-MC\SQLEXPRESS; Database=QL_COFFEE; Integrated Security=true");
        public static void XoaHD_ThanhVien()
        {
            DataTable hd = TasmaMain.LietKeDuLieu("HOADON", "MaTV", "TV001", kn);
            for(int i = 0; i < hd.Rows.Count; i++)
            {
                TasmaMain.XoaDuLieu("CTHD", "MaHoaDon", 
                    hd.Rows[i]["MaHoaDon"].ToString().Trim(), kn);
                DataTable tk = TasmaMain.LietKeDuLieu("CTTK", "MAHOADON",
                    hd.Rows[i]["MaHoaDon"].ToString().Trim(), kn);
                for(int j = 0; j < tk.Rows.Count; j++)
                {
                    TasmaMain.XoaDuLieu("CTTK", "MaHoaDon", tk.Rows[j]["MaHoaDon"], kn);
                }
            }
            TasmaMain.XoaDuLieu("HOADON", "MaTV", "TV001", kn);
        }
        static void Main(string[] args)
        {
            XoaHD_ThanhVien();
            Console.ReadLine();
        }
    }
}
