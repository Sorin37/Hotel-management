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
        private string numberOfDays = "";
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

        private double finalPrice = 0;
        public double FinalPrice
        {
            get
            {
                return finalPrice;
            }
            set
            {
                finalPrice = value;
                NotifyPropertyChanged("Price");
            }
        }
        public double Price
        {
            get
            {
                int days;
                if (!int.TryParse(numberOfDays.ToString(), out days))
                    days = 0;
                if (Offer != null)
                {
                    return (days * CurrentRoom.price + finalPrice) * (100 - Offer.price_reduction) / 100;
                }
                else
                {
                    return days * CurrentRoom.price + finalPrice;
                }
            }
        }
        public ObservableCollection<Feature> Features { get; set; }
        public Feature SelectedFeature = new Feature();
        private Offer offer = new Offer();
        public Offer Offer {
            get
            {
                return offer;
            }
            set
            {
                offer = value;
                NotifyPropertyChanged("Offer");
            }
        }
        public BookRoomVM(Room room, Offer offer)
        {
            CurrentRoom = new Room();
            CurrentRoom = room;
            Date = DateTime.Now.Date;
            Dates = new ObservableCollection<DateTime>();
            RoomBLL roomBLL = new RoomBLL();
            Dates = roomBLL.GetAllBookingsOfARoom(CurrentRoom.id);
            Features = new ObservableCollection<Feature>();
            Features = roomBLL.GetAllFeaturesOfARoom(CurrentRoom.id);
            if (Features.Count > 0)
            {
                SelectedFeature = Features[0];
            }
            if(offer != null)
            {
                NumberOfDays = offer.number_of_days.ToString();
            }
        }
    }
}
