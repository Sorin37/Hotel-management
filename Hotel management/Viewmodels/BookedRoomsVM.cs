using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_management.Viewmodels
{
    internal class BookedRoomsVM : BasePropertyChanged
    {
        public ObservableCollection<Tuple<long, DateTime, string>> roomTime { get; set; }
        public ObservableCollection<Tuple<long, DateTime, string>> RoomTime {
            get
            {
                return roomTime;
            }
            set
            {
                roomTime = value;
                NotifyPropertyChanged("RoomTime");
            }
        }
        public Tuple<long, DateTime, string> HighlightedBooking { get; set; }
        public long CurrentUserId;
        public BookedRoomsVM(long user_id)
        {
            CurrentUserId = user_id;
            RoomTime = new ObservableCollection<Tuple<long, DateTime, string>>();
            UserBLL userBLL = new UserBLL();
            RoomTime = userBLL.GetAllBookingsOfAUser(CurrentUserId);
            if (RoomTime.Count > 0)
            {
                HighlightedBooking = RoomTime[0];
            }
        }
    }
}
