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
    internal class BookedRoomsVM
    {
        public ObservableCollection<Tuple<long, DateTime, string>> RoomTime { get; set; }
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

            //MessageBox.Show(RoomTime[0].Item1.ToString() + RoomTime[0].Item2.ToString());
        }
    }
}
