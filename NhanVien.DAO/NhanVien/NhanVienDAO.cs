using NhanVien.DTO.NhanVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien.DAO.NhanVien
{
    public class NhanVienDAO : DBConnection
    {
        public CommandType CommandType { get; private set; }
        public List<NhanVienDTO> ReadNhanVien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Create proc GetEmployee as select * from Employee", conn);
            cmd.CommandText = "GetEmployee";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();



            List<NhanVienDTO> lstNV = new List<NhanVienDTO>();
            DepartmentDAO dep = new DepartmentDAO();
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.Id = reader["idemploy"].ToString();
                nv.Name = reader["name"].ToString();
                nv.Date = reader["datebirth"].ToString();
                nv.Gender = (bool)reader["gender"];
                nv.Department = dep.ReadDep(reader["iddepart"].ToString());
                nv.Placebirth = reader["placebirth"].ToString();

                lstNV.Add(nv);
            }
            conn.Close();
            return lstNV;
        }

        public void NewNV(NhanVienDTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();

            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {

                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spInsert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@idemploy", SqlDbType.Int).Value = nv.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nv.Name;
                cmd.Parameters.Add("@datebirth", SqlDbType.NVarChar).Value = nv.Date;
                cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = nv.Gender;
                cmd.Parameters.Add("@iddepart", SqlDbType.NVarChar).Value = nv.Department.Id;
                cmd.Parameters.Add("@placebirth", SqlDbType.NVarChar).Value = nv.Placebirth;


                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();

                Console.WriteLine("Them khach hang thanh cong !!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }

        }

        public void EditNV(NhanVienDTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();

            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {

                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spUpdate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@idemploy", SqlDbType.Int).Value = nv.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nv.Name;
                cmd.Parameters.Add("@datebirth", SqlDbType.NVarChar).Value = nv.Date;
                cmd.Parameters.Add("@iddepart", SqlDbType.Int).Value = nv.Department.Id;
                cmd.Parameters.Add("@placebirth", SqlDbType.NVarChar).Value = nv.Placebirth;

                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();

                Console.WriteLine("Sua khach hang thanh cong !!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }

        }

        public void DeleteNV(NhanVienDTO nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();

            //Chỗ này tạm thời có thể gán cứng chuỗi kết nối
            try
            {

                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@idemploy", SqlDbType.Int).Value = nv.Id;
                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }
        }
    }
}
