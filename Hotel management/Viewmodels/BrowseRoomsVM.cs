using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Viewmodels
{
    internal class BrowseRoomsVM : BasePropertyChanged
    {
        private User currentUser;
        public User CurrentUser { 
            get => currentUser;
            set
            {
                currentUser = value;
                NotifyPropertyChanged("CurrentUser");
            }
        }

        public BrowseRoomsVM()
        {
            currentUser = new User();
        }
    }
}
