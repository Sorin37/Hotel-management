USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 26-May-22 10:37:24 PM ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotel', N'ON'
GO
ALTER DATABASE [Hotel] SET QUERY_STORE = OFF
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[room_id] [bigint] NOT NULL,
	[user_id] [bigint] NOT NULL,
	[date] [date] NOT NULL,
	[state] [nvarchar](10) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feature]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feature](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[room_id] [bigint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Feature] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offer]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offer](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[start_date] [date] NOT NULL,
	[number_of_days] [int] NOT NULL,
	[price_reduction] [float] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[room_id] [bigint] NOT NULL,
	[image] [image] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Photo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[number] [bigint] NOT NULL,
	[price] [float] NOT NULL,
	[number_of_rooms] [bigint] NOT NULL,
	[deleted] [bit] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [bigint] IDENTITY(2,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Room]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_User]
GO
ALTER TABLE [dbo].[Feature]  WITH CHECK ADD  CONSTRAINT [FK_Feature_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Feature] CHECK CONSTRAINT [FK_Feature_Room]
GO
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD  CONSTRAINT [FK_Photo_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Photo] CHECK CONSTRAINT [FK_Photo_Room]
GO
/****** Object:  StoredProcedure [dbo].[AddFeature]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddFeature]
	@room_id bigint,
	@name nvarchar(50),
	@price float
AS
BEGIN
	insert into [dbo].[Feature]([room_id], [name], [price], [deleted])
	values(@room_id, @name, @price, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[AddPhoto]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPhoto]
	@room_id bigint,
	@image image
AS
BEGIN
	insert into [dbo].[Photo]([room_id], [image], [deleted])
	values(@room_id, @image, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[AddRoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRoom]
	@number bigint,
	@price float,
	@number_of_rooms bigint
AS
BEGIN
	insert into [dbo].[Room]([number], [price], [number_of_rooms], [deleted])
	values(@number, @price, @number_of_rooms, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddUser]
	@name nvarchar(50),
	@surname nvarchar(50),
	@password nvarchar(50)
AS
BEGIN
	insert into [dbo].[User]([name], [surname], [password], [type], [deleted])
	values(@name, @surname, @password, 'Client', 0)
END
GO
/****** Object:  StoredProcedure [dbo].[BookARoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BookARoom]
	@room_id bigint,
	@user_id bigint,
	@date date
AS
BEGIN
	insert into [dbo].[Bookings]([room_id], [user_id], [date], [state], [deleted])
	values(@room_id, @user_id, @date, 'active', 0)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteFeature]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteFeature] 
	@id bigint
AS
BEGIN
	update	[dbo].[Feature]
	set		[deleted] = 1
	where	[dbo].[Feature].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePhoto]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePhoto] 
	@id bigint
AS
BEGIN
	update	[dbo].[Photo]
	set		[deleted] = 1
	where	[dbo].[Photo].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteRoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteRoom] 
	@id bigint
AS
BEGIN
	update	[dbo].[Room]
	set		[deleted] = 1
	where	[dbo].[Room].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUser] 
	@id bigint
AS
BEGIN
	update	[dbo].[User]
	set		[deleted] = 1
	where	[dbo].[User].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBookingsOfARoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllBookingsOfARoom]
	@room_id bigint
AS
BEGIN
	SELECT [dbo].[Bookings].[date] FROM [dbo].[Room] 
	INNER JOIN [dbo].[Bookings] 
	ON [dbo].[Room].[id]=[dbo].[Bookings].[room_id]
	WHERE  [dbo].[Room].[id]=@room_id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBookingsOfAUser]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllBookingsOfAUser]
	@user_id bigint
AS
BEGIN
	SELECT [dbo].[Bookings].[room_id], [dbo].[Bookings].[date],[dbo].[Bookings].[state] FROM [dbo].[Room] 
	INNER JOIN [dbo].[Bookings] 
	ON [dbo].[Room].[id]=[dbo].[Bookings].[room_id]
	WHERE  [dbo].[Bookings].[user_id]=@user_id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllFeaturesOfARoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllFeaturesOfARoom]
	@room_id bigint
AS
BEGIN
	SELECT [dbo].[Feature].id, [dbo].[Feature].name, [dbo].[Feature].price FROM [dbo].[Room] 
	INNER JOIN [dbo].[Feature] 
	ON [dbo].[Feature].[room_id] = [dbo].[Room].[id]
	WHERE  [dbo].[Feature].[room_id] = @room_id AND [dbo].[Feature].[deleted] = 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOffers]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAllOffers]
AS
SELECT * FROM [dbo].[Offer] WHERE [dbo].[Offer].[deleted]=0 AND [dbo].[Offer].[start_date] > GETDATE()
GO
/****** Object:  StoredProcedure [dbo].[GetAllPhotosOfARoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPhotosOfARoom]
	@room_id bigint
AS
BEGIN
	SELECT [dbo].Photo.[id], [Photo].image FROM [dbo].[Room] 
	INNER JOIN [dbo].[Photo] 
	ON [dbo].[Room].[id]=[dbo].[Photo].[room_id]
	WHERE  [dbo].[Room].[id]=@room_id AND [dbo].[Photo].deleted = 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllRooms]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAllRooms]
AS
SELECT * FROM [dbo].[Room]
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAllUsers]
AS
SELECT * FROM [dbo].[User] WHERE [dbo].[User].[deleted]=0
GO
/****** Object:  StoredProcedure [dbo].[ModifyBooking]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModifyBooking] 
	@user_id bigint,
	@room_id bigint,
	@date date,
	@state nvarchar(10),
	@deleted bit
AS
BEGIN
	update	[dbo].[Bookings]
	set		[state] = @state,
			[deleted] = @deleted
	where	[dbo].[Bookings].[user_id] = @user_id AND 
		    [dbo].[Bookings].[room_id] = @room_id AND 
			[dbo].[Bookings].[date] = @date
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyFeature]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModifyFeature] 
	@id bigint,
	@room_id bigint,
	@name nvarchar(50),
	@price float
AS
BEGIN
	update	[dbo].[Feature]
	set		[name] = @name,
			room_id = @room_id,
			@price = @price
	where	[dbo].[Feature].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyRoom]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModifyRoom] 
	@id bigint,
	@number nvarchar(50),
	@price float,
	@number_of_rooms bigint
AS
BEGIN
	update	[dbo].[Room]
	set		[number] = @number,
			[price] = @price,
			[number_of_rooms] = @number_of_rooms
	where	[dbo].[Room].[id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ModifyUser]    Script Date: 26-May-22 10:37:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModifyUser] 
	@id bigint,
	@name nvarchar(50),
	@surname nvarchar(50),
	@password nvarchar(50),
	@type nvarchar(20)
AS
BEGIN
	update	[dbo].[User]
	set		[name] = @name,
			[surname] = @surname,
			[password] = @password,
			[type] = @type
	where	[dbo].[User].[id] = @id
END
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
