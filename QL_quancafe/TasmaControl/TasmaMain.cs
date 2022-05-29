using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TasmaControl
{
    public class TasmaMain
    {
        public static string HD = "";
        public static string SK = "";
        public static SqlConnection kn = TasmaMain.ketnoi(@"THONG\SQLEXPRESS", "QL_COFFEE");
        public static string StrangeDate(string date)
        {
            string[] dates = date.Split('/');
            Array.Reverse(dates);
            return String.Join("-", dates);
        }
        public static bool XLDangNhap(string tentable, Dictionary<string, object> inforTK, SqlConnection ketnoi)
        {
            bool res = false;
            string infor = "";
            foreach (var i in inforTK)
            {
                infor += String.Format("{0}='{1}' AND ", i.Key, i.Value);
            }
            infor = infor.Substring(0, infor.Length - 4);
            string query = String.Format("SELECT * FROM {0} WHERE {1}", tentable, infor);
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res = true;
                }
                reader.Close();
                //cmd.Connection.Close();
            }
            cmd.Connection.Close();
            return res;
        }
        public static DataTable LietKeTuDo(string lenh, SqlConnection ketnoi)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(lenh, ketnoi);
            adap.Fill(dt);
            return dt;
        }
        public static bool LenhTuDo(string lenh, SqlConnection ketnoi)
        {
            bool res = true;
            SqlCommand cmd = new SqlCommand(lenh, ketnoi);
            cmd.Connection.Open();
                res = (cmd.ExecuteNonQuery() > 0);
            cmd.Connection.Close();
            return res;
        }
        public static DataTable LietKeDuLieu(string tentable, SqlConnection ketnoi)
        {
            string query = "SELECT * FROM " + tentable;
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(query, ketnoi);
            adap.Fill(dt);
            return dt;
        }
        public static DataTable LietKeDuLieu(string tentable, string tencotthamchieu, 
            object giatrithamchieu, SqlConnection ketnoi)
        {
            try { Convert.ToInt32(giatrithamchieu); } catch { giatrithamchieu = "'" + giatrithamchieu + "'"; }
            string query = String.Format("SELECT * FROM {0} WHERE {1}={2}", tentable, 
                tencotthamchieu, giatrithamchieu);
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(query, ketnoi);
            adap.Fill(dt);
            return dt;
        }
        public static bool ThemDuLieu(string tentable, Dictionary<string, object> dlcanthem, SqlConnection ketnoi)
        {
            bool result = true;
            string strKey = "";
            string strValue = "";
            foreach(var dl in dlcanthem)
            {
                strKey += dl.Key + ",";
                try {
                    strValue += String.Format("{0},", Convert.ToInt32(dl.Value));
                }
                catch {
                    strValue += String.Format((dl.Value.ToString() != "NULL") ? "N'{0}'," : "{0},", dl.Value);
                }
            }
            strKey = strKey.Substring(0, strKey.Length - 1);
            strValue = strValue.Substring(0, strValue.Length - 1);
            string query = String.Format("INSERT INTO {0}({1}) VALUES({2})", tentable, strKey, strValue);
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            cmd.Connection.Open();
            try { result = (cmd.ExecuteNonQuery() > 0); }
            catch { result = false; }
            cmd.Connection.Close();
            return result;
        }
        public static string KT_ThemDuLieu(string tentable, Dictionary<string, object> dlcanthem)
        {
            string strKey = "";
            string strValue = "";
            foreach (var dl in dlcanthem)
            {
                strKey += dl.Key + ",";
                try
                {
                    strValue += String.Format("{0},", Convert.ToInt32(dl.Value));
                }
                catch
                {
                    strValue += String.Format((dl.Value.ToString() != "NULL") ? "N'{0}'," : "{0},", dl.Value);
                }
            }
            strKey = strKey.Substring(0, strKey.Length - 1);
            strValue = strValue.Substring(0, strValue.Length - 1);
            string query = String.Format("INSERT INTO {0}({1}) VALUES({2})", tentable, strKey, strValue);
            return query;
        }
        public static bool SuaDuLieu(string tentable, Dictionary<string, object> dlcansua, 
            string tencotthamchieu, object giatrithamchieu,
            SqlConnection ketnoi)
        {
            bool result;
            try { Convert.ToInt32(giatrithamchieu); } catch { giatrithamchieu = "'" + giatrithamchieu + "'"; }
            string strRes = "";
            foreach (var dl in dlcansua)
            {
                try
                {
                    strRes += String.Format("{0}={1},", dl.Key, Convert.ToInt32(dl.Value));
                }
                catch
                {
                    strRes += String.Format("{0}=N'{1}',", dl.Key, dl.Value);
                }
            }
            
            strRes = strRes.Substring(0, strRes.Length - 1);
            string query = String.Format("UPDATE {0} SET {1} WHERE {2}={3}", tentable, strRes, 
                tencotthamchieu, giatrithamchieu);
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            cmd.Connection.Open();
            try { result = (cmd.ExecuteNonQuery() > 0); }
            catch { result = false; }
            cmd.Connection.Close();
            return result;
        }
        public static bool XoaDuLieu(string tentable, string tencotthamchieu, object giatrithamchieu, SqlConnection ketnoi)
        {
            bool result;
            try { Convert.ToInt32(giatrithamchieu); } catch { giatrithamchieu = "'" + giatrithamchieu + "'"; }
            string query = String.Format("DELETE FROM {0} WHERE {1}={2}", tentable,
                tencotthamchieu, giatrithamchieu);
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            cmd.Connection.Open();
            try { result = (cmd.ExecuteNonQuery() > 0); }
            catch { result = false; }
            cmd.Connection.Close();
            return result;
        }
        public static SqlConnection ketnoi(string tenserver, string tencsdl)
        {
            string query = String.Format(@"Server={0};Database={1};Integrated Security=true", tenserver, tencsdl);
            SqlConnection conn = new SqlConnection(query);
            return conn;
        }
        public static string IDSinhTruong(string maID)
        {
            string idNum = "";
            string idStr = "";
            foreach(char c in maID)
            {
                if (isNumber(c))
                {
                    idNum += c + ",";
                } 
                else
                {
                    idStr += c + ",";
                }
            }
            idNum = idNum.Substring(0, idNum.Length - 1);
            idStr = idStr.Substring(0, idStr.Length - 1);
            string[] idNumFull = idNum.Split(',');
            string[] idStrFull = idStr.Split(',');
            string idRes = String.Join("", idStrFull) + upCount(String.Join("", idNumFull));
            return idRes;
        }
        private static string upCount(string idNum)
        {
            string res = "";
            int up = Convert.ToInt32(idNum) + 1;
            if(up < 10)
            {
                res = "00" + up;
            }else if(up > 9 && up < 100)
            {
                res = "0" + up;
            } else if(up > 99)
            {
                res = up.ToString();
            }
            return res;
        }
        public static bool isNumber(char id)
        {
            return (Char.IsNumber(id));
        }
    }
}
