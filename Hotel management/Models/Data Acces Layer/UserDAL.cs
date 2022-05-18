using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Data_Acces_Layer
{
    internal class UserDAL
    {
        public ObservableCollection<User> GetAllUsers()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User p = new User();
                    p.id = (long)reader[0];//reader.GetInt(0);
                    p.name = reader.GetString(1);//reader[1].ToString();
                    p.password = reader.IsDBNull(2) ? null : reader[2].ToString();
                    p.type = reader.IsDBNull(3) ? null : reader[3].ToString();
                    p.deleted = (bool)reader[4];
                    result.Add(p);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
        public void AddUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramName = new SqlParameter("@name", user.name);
                SqlParameter paramPassword = new SqlParameter("@password", user.password);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
