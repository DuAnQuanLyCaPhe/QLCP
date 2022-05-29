using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL_Client
{
    public class Cls_ketnoi
    {
        public static SqlConnection kn = new SqlConnection(@"Server=THONG\SQLEXPRESS; Database =QL_COFFEE;Integrated Security=True");
    }
}
