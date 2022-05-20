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
    internal class BookRoomVM : BasePropertyChanged
    {
        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
            }
        }
        public ObservableCollection<DateTime> Dates { get; set; }
        private string numberOfDays="";
        public string NumberOfDays
        {
            get
            {
                return numberOfDays;
            }
            set
            {
                numberOfDays = value;
                NotifyPropertyChanged("NumberOfDays");
                NotifyPropertyChanged("Price");
            }
        }

        public Room CurrentRoom { get; set; }
        public long User_id { get; set; }

        public double Price {
            get
            {
                int days;
                if(int.TryParse(numberOfDays.ToString(), out days))
                {
                    return days * CurrentRoom.price;
                }
                else
                {
                    return 0;
                }
            }
        }
        public BookRoomVM(Room room)
        {
            CurrentRoom = new Room();
            CurrentRoom = room;
            Date = DateTime.Now.Date;
            Dates = new ObservableCollection<DateTime>();
            RoomBLL roomBLL = new RoomBLL();
            Dates = roomBLL.GetAllBookingsOfARoom(CurrentRoom.id);
        }
    }
}
