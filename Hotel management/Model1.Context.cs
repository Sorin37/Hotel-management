//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_management
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelEntities1 : DbContext
    {
        public HotelEntities1()
            : base("name=HotelEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int AddFeature(Nullable<long> room_id, string name, Nullable<double> price)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddFeature", room_idParameter, nameParameter, priceParameter);
        }
    
        public virtual int AddPhoto(Nullable<long> room_id, byte[] image)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPhoto", room_idParameter, imageParameter);
        }
    
        public virtual int AddRoom(Nullable<long> number, Nullable<double> price, Nullable<long> number_of_rooms)
        {
            var numberParameter = number.HasValue ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(long));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var number_of_roomsParameter = number_of_rooms.HasValue ?
                new ObjectParameter("number_of_rooms", number_of_rooms) :
                new ObjectParameter("number_of_rooms", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRoom", numberParameter, priceParameter, number_of_roomsParameter);
        }
    
        public virtual int AddUser(string name, string surname, string password)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", nameParameter, surnameParameter, passwordParameter);
        }
    
        public virtual int BookARoom(Nullable<long> room_id, Nullable<long> user_id, Nullable<System.DateTime> date)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(long));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BookARoom", room_idParameter, user_idParameter, dateParameter);
        }
    
        public virtual int DeleteFeature(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFeature", idParameter);
        }
    
        public virtual int DeletePhoto(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePhoto", idParameter);
        }
    
        public virtual int DeleteRoom(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteRoom", idParameter);
        }
    
        public virtual int DeleteUser(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", idParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> GetAllBookingsOfARoom(Nullable<long> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("GetAllBookingsOfARoom", room_idParameter);
        }
    
        public virtual ObjectResult<GetAllBookingsOfAUser_Result> GetAllBookingsOfAUser(Nullable<long> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllBookingsOfAUser_Result>("GetAllBookingsOfAUser", user_idParameter);
        }
    
        public virtual ObjectResult<GetAllFeaturesOfARoom_Result> GetAllFeaturesOfARoom(Nullable<long> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllFeaturesOfARoom_Result>("GetAllFeaturesOfARoom", room_idParameter);
        }
    
        public virtual ObjectResult<GetAllOffers_Result> GetAllOffers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllOffers_Result>("GetAllOffers");
        }
    
        public virtual ObjectResult<GetAllPhotosOfARoom_Result> GetAllPhotosOfARoom(Nullable<long> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPhotosOfARoom_Result>("GetAllPhotosOfARoom", room_idParameter);
        }
    
        public virtual ObjectResult<GetAllRooms_Result> GetAllRooms()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllRooms_Result>("GetAllRooms");
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual int ModifyBooking(Nullable<long> user_id, Nullable<long> room_id, Nullable<System.DateTime> date, string state, Nullable<bool> deleted)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(long));
    
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyBooking", user_idParameter, room_idParameter, dateParameter, stateParameter, deletedParameter);
        }
    
        public virtual int ModifyFeature(Nullable<long> id, Nullable<long> room_id, string name, Nullable<double> price)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyFeature", idParameter, room_idParameter, nameParameter, priceParameter);
        }
    
        public virtual int ModifyRoom(Nullable<long> id, string number, Nullable<double> price, Nullable<long> number_of_rooms)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            var numberParameter = number != null ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var number_of_roomsParameter = number_of_rooms.HasValue ?
                new ObjectParameter("number_of_rooms", number_of_rooms) :
                new ObjectParameter("number_of_rooms", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyRoom", idParameter, numberParameter, priceParameter, number_of_roomsParameter);
        }
    
        public virtual int ModifyUser(Nullable<long> id, string name, string surname, string password, string type)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyUser", idParameter, nameParameter, surnameParameter, passwordParameter, typeParameter);
        }
    }
}
