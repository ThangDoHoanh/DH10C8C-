using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DS_SV
{
    internal class Modify
    {
        SqlDataAdapter adapter;
        SqlCommand command;
        public Modify()
        {

        }
        public DataTable getAllSv()
        {
            DataTable data = new DataTable();
            string query = "select * form table_1 ";
            using (SqlConnection sqlConection=Connection.getConnection())
            {
                sqlConection.Open();
                adapter = new SqlDataAdapter(query, sqlConection);
                adapter.Fill(data);

                sqlConection.Close();
            }
            return data;
        }
        public bool insert(QLNV nhanvien)
        {
            SqlConnection sqlConection=Connection.getConnection();
            string query = "insert into Table_1 value (@MaSV,@TenSV,@NgaySinh,@DiaChi,@Lop,@DiemTB)";
            try
            {
                sqlConection.Open();
                command = new SqlCommand(query, sqlConection);
                command.Parameters.Add("@MaSV", SqlDbType.NChar).Value = nhanvien.Id;
                command.Parameters.Add("@TenSV", SqlDbType.NChar).Value = nhanvien.Name;
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanvien.Date.ToShortDateString();
                command.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = nhanvien.Address;
                command.Parameters.Add("@Lop", SqlDbType.NChar).Value = nhanvien.Class;
                command.Parameters.Add("@DiemTB", SqlDbType.NChar).Value = nhanvien.DTB;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConection.Close();
            }
            return true;
        }

    }
}
