using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    public class UserBLL
    {
        public ObservableCollection<User> UserList { get; set; }

        UserDAL userDAL = new UserDAL();

        public ObservableCollection<User> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        public void AddUser(User user)
        {
            userDAL.AddUser(user);
            UserList.Add(user);
        }

        public UserBLL()
        {
            UserList = new ObservableCollection<User>();
        }
    }
}
