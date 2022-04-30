using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
        

namespace Class_QLcafe
{
    public class Cls_ketnoi
    {
        public static SqlConnection qlcf = new SqlConnection(@"Server=DESKTOP-78BPEV2\SQLEXPRESS;Database=QuanLyQuanCafe;Integrated Security=true");
    }
}
