using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

        public ObservableCollection<BitmapFrame> GetAllPhotosOfARoom(int id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllPhotosOfARoom", con);
                ObservableCollection<BitmapFrame> result = new ObservableCollection<BitmapFrame>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];

                    using (var stream = new MemoryStream(img))
                    {
                        var bitmap = BitmapFrame.Create(stream,
                                                BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                        result.Add(bitmap);
                    }

                    //result.Add(reader[0].ToString());
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
