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
    internal class RoomDAL
    {
        public ObservableCollection<Room> GetAllRooms()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllRooms", con);
                ObservableCollection<Room> result = new ObservableCollection<Room>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room p = new Room();
                    p.id = (long)reader[0];//reader.GetInt(0);
                    p.number = (long)reader[1];//reader.GetInt(0);
                    p.price = (double)reader[2];//reader.GetInt(0);
                    p.number_of_rooms = (long)reader[3];
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
    }
}
