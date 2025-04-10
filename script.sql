USE [master]
GO
/****** Object:  Database [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF]    Script Date: 12/25/2024 4:50:08 PM ******/
CREATE DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Database', FILENAME = N'C:\Users\HP\Documents\GitHub\Happy_Journey_Airline\Happy Journey Airline\Backend\Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Database_log', FILENAME = N'C:\Users\HP\Documents\GitHub\Happy_Journey_Airline\Happy Journey Airline\Backend\Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ARITHABORT OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET  MULTI_USER 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET QUERY_STORE = OFF
GO
USE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Airport]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airport](
	[airport_id] [int] IDENTITY(1,1) NOT NULL,
	[city_id] [int] NULL,
	[airport_name] [varchar](100) NULL,
 CONSTRAINT [PK_Airport] PRIMARY KEY CLUSTERED 
(
	[airport_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[booking_id] [int] IDENTITY(1,1) NOT NULL,
	[flight_class_id] [int] NULL,
	[flight_id] [int] NULL,
	[seat_no] [nvarchar](max) NULL,
	[traveler_id] [int] NULL,
	[passportNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[city_id] [int] IDENTITY(1,1) NOT NULL,
	[country_id] [int] NOT NULL,
	[city_name] [varchar](50) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[city_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[country_id] [int] IDENTITY(1,1) NOT NULL,
	[region] [varchar](50) NULL,
	[country_name] [varchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employer]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employer](
	[employer_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_Employer] PRIMARY KEY CLUSTERED 
(
	[employer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flight]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flight](
	[flight_id] [int] IDENTITY(1,1) NOT NULL,
	[departure] [int] NULL,
	[destination] [int] NULL,
	[flight_no] [varchar](50) NULL,
	[capacity] [int] NULL,
	[price] [float] NULL,
	[status] [varchar](50) NULL,
	[departure_time] [datetime] NULL,
	[arrival_time] [datetime] NULL,
	[departure_date] [datetime] NULL,
	[arrival_date] [datetime] NULL,
 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED 
(
	[flight_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FlightClass]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlightClass](
	[flight_class_id] [int] IDENTITY(1,1) NOT NULL,
	[flight_class_name] [varchar](50) NULL,
 CONSTRAINT [PK_FlightClass] PRIMARY KEY CLUSTERED 
(
	[flight_class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[message_id] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](max) NULL,
	[sender_id] [int] NULL,
	[receiver_id] [int] NULL,
	[timestamp] [datetime] NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[message_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[service_name] [varchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service Booking](
	[service_id] [int] NULL,
	[booking_id] [int] NULL,
	[booking_service_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Service Booking] PRIMARY KEY CLUSTERED 
(
	[booking_service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscriber Subscription]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscriber Subscription](
	[subscriber_id] [int] NULL,
	[subscription_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscription]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscription](
	[subscription_id] [int] IDENTITY(1,1) NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[description] [varchar](100) NULL,
	[subscription_name] [varchar](100) NULL,
 CONSTRAINT [PK_Subscription] PRIMARY KEY CLUSTERED 
(
	[subscription_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traveler]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traveler](
	[traveler_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_Traveler] PRIMARY KEY CLUSTERED 
(
	[traveler_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/25/2024 4:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[age] [int] NULL,
	[dob] [date] NULL,
	[email] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](100) NULL,
	[phone_no] [varchar](20) NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([admin_id], [user_id]) VALUES (24, 58)
INSERT [dbo].[Administrator] ([admin_id], [user_id]) VALUES (25, 59)
INSERT [dbo].[Administrator] ([admin_id], [user_id]) VALUES (26, 60)
INSERT [dbo].[Administrator] ([admin_id], [user_id]) VALUES (27, 63)
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Airport] ON 

INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (4, 1, N'John F. Kennedy International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (5, 2, N'Los Angeles International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (6, 3, N'O''Hare International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (7, 4, N'Miami International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (8, 5, N'San Francisco International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (9, 6, N'Seattle-Tacoma International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (10, 7, N'Dallas/Fort Worth International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (11, 8, N'HartsField-Jackson Atlanta International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (12, 9, N'Denver International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (13, 10, N'Phoenix Sky Harbor International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (14, 11, N'George Bush International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (15, 12, N'Charlotte Douglas International Airport')
INSERT [dbo].[Airport] ([airport_id], [city_id], [airport_name]) VALUES (16, 13, N'Logan International Airport')
SET IDENTITY_INSERT [dbo].[Airport] OFF
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (65, 1, 14, N'1A', 10, N'12345678')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (66, 2, 31, N'2B', 11, N'23456789')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (67, 1, 32, N'3C', 12, N'34567890')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (68, 2, 33, N'4D', 10, N'45678901')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (69, 1, 34, N'5E', 11, N'56789012')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (70, 2, 35, N'6F', 12, N'67890123')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (71, 1, 36, N'7G', 13, N'78901234')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (72, 1, 37, N'8H', 10, N'89012345')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (73, 2, 38, N'9I', 11, N'90123456')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (74, 1, 39, N'10J', 12, N'01234567')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (75, 2, 40, N'11K', 13, N'12345678')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (76, 3, 14, N'34F', 14, N'91246535')
INSERT [dbo].[Booking] ([booking_id], [flight_class_id], [flight_id], [seat_no], [traveler_id], [passportNo]) VALUES (77, 1, 14, N'3E', 10, N'34537588')
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (1, 1, N'New York')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (2, 2, N'Los Angeles')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (3, 3, N'Chicago')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (4, 4, N'Miami')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (5, 5, N'San Francisco')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (6, 6, N'Seattle')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (7, 7, N'Dallas')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (8, 8, N'Atlanta')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (9, 9, N'Denver')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (10, 10, N'Phoenix')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (11, 11, N'Houston')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (12, 12, N'Charlotte')
INSERT [dbo].[City] ([city_id], [country_id], [city_name]) VALUES (13, 13, N'Boston')
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (1, N'North America', N'United States')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (2, N'North America', N'Canada')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (3, N'North America', N'Mexico')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (4, N'Europe', N'United Kingdom')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (5, N'Europe', N'Germany')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (6, N'Europe', N'France')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (7, N'Asia', N'China')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (8, N'Asia', N'Japan')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (9, N'Asia', N'India')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (10, N'Africa', N'South Africa')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (11, N'South America', N'Brazil')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (12, N'South America', N'Argentina')
INSERT [dbo].[Country] ([country_id], [region], [country_name]) VALUES (13, N'Europe ', N'Italy')
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[Employer] ON 

INSERT [dbo].[Employer] ([employer_id], [user_id]) VALUES (3, 56)
INSERT [dbo].[Employer] ([employer_id], [user_id]) VALUES (4, 61)
INSERT [dbo].[Employer] ([employer_id], [user_id]) VALUES (5, 66)
SET IDENTITY_INSERT [dbo].[Employer] OFF
GO
SET IDENTITY_INSERT [dbo].[Flight] ON 

INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (14, 4, 5, N'SW404', 160, 180, N'Available', CAST(N'2024-12-25T09:00:00.000' AS DateTime), CAST(N'2024-12-25T11:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (31, 4, 5, N'AA101', 180, 150, N'Available', CAST(N'2024-12-25T10:00:00.000' AS DateTime), CAST(N'2024-12-25T12:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (32, 5, 6, N'UA202', 150, 200, N'Available', CAST(N'2024-12-25T14:00:00.000' AS DateTime), CAST(N'2024-12-25T16:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (33, 6, 4, N'DL303', 200, 250, N'Available', CAST(N'2024-12-25T18:00:00.000' AS DateTime), CAST(N'2024-12-25T20:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (34, 4, 8, N'SW404', 160, 180, N'Available', CAST(N'2024-12-25T09:00:00.000' AS DateTime), CAST(N'2024-12-25T11:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (35, 5, 11, N'JA606', 190, 200, N'Available', CAST(N'2024-12-25T12:30:00.000' AS DateTime), CAST(N'2024-12-25T14:30:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (36, 6, 12, N'LA707', 180, 230, N'Available', CAST(N'2024-12-25T16:30:00.000' AS DateTime), CAST(N'2024-12-25T18:30:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (37, 7, 9, N'MA808', 160, 190, N'Available', CAST(N'2024-12-25T19:00:00.000' AS DateTime), CAST(N'2024-12-25T21:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (38, 8, 10, N'NA909', 200, 250, N'Available', CAST(N'2024-12-25T10:30:00.000' AS DateTime), CAST(N'2024-12-25T12:30:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (39, 9, 11, N'OA010', 170, 210, N'Available', CAST(N'2024-12-25T13:30:00.000' AS DateTime), CAST(N'2024-12-25T15:30:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Flight] ([flight_id], [departure], [destination], [flight_no], [capacity], [price], [status], [departure_time], [arrival_time], [departure_date], [arrival_date]) VALUES (40, 10, 12, N'BA111', 160, 220, N'Available', CAST(N'2024-12-25T15:30:00.000' AS DateTime), CAST(N'2024-12-25T17:30:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime), CAST(N'2024-12-25T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Flight] OFF
GO
SET IDENTITY_INSERT [dbo].[FlightClass] ON 

INSERT [dbo].[FlightClass] ([flight_class_id], [flight_class_name]) VALUES (1, N'Economy')
INSERT [dbo].[FlightClass] ([flight_class_id], [flight_class_name]) VALUES (2, N'Business')
INSERT [dbo].[FlightClass] ([flight_class_id], [flight_class_name]) VALUES (3, N'First Class')
SET IDENTITY_INSERT [dbo].[FlightClass] OFF
GO
SET IDENTITY_INSERT [dbo].[Message] ON 

INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (36, N'Welcome to our travel service, John!', 58, 54, CAST(N'2024-12-25T15:38:56.917' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (37, N'Please confirm your travel details.', 58, 54, CAST(N'2024-12-25T15:38:56.920' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (38, N'Diana, your travel itinerary has been updated.', 59, 57, CAST(N'2024-12-25T15:39:05.707' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (39, N'Let me know if you have any questions.', 59, 57, CAST(N'2024-12-25T15:39:05.707' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (40, N'George, we have a new travel package available.', 60, 62, CAST(N'2024-12-25T15:39:30.460' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (41, N'Would you like more information?', 60, 62, CAST(N'2024-12-25T15:39:30.460' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (42, N'Hi Fiona, I received the welcome message, thank you!', 54, 58, CAST(N'2024-12-25T15:40:16.707' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (43, N'I have confirmed my travel details.', 54, 58, CAST(N'2024-12-25T15:40:16.707' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (44, N'Thanks for the update, Alice!', 57, 59, CAST(N'2024-12-25T15:40:16.710' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (45, N'I have a few questions about my itinerary.', 57, 59, CAST(N'2024-12-25T15:40:16.710' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (46, N'Hi Reem, I’m interested in the new travel package.', 62, 60, CAST(N'2024-12-25T15:40:16.710' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (47, N'Can you provide more details?', 62, 60, CAST(N'2024-12-25T15:40:16.710' AS DateTime))
INSERT [dbo].[Message] ([message_id], [content], [sender_id], [receiver_id], [timestamp]) VALUES (48, N'Hello, I would like to report an issue with my booking.', 64, 63, CAST(N'2024-12-25T16:07:41.937' AS DateTime))
SET IDENTITY_INSERT [dbo].[Message] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (1, N'Baggage Handling', N'Assistance with baggage handling at the airport.', 15)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (2, N'Airport Lounge Access', N'Access to exclusive airport lounges for relaxation before flights.', 30)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (3, N'Travel Insurance', N'Comprehensive travel insurance for peace of mind during trips.', 50)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (4, N'Priority Boarding', N'Board the plane before general boarding for a smoother experience.', 20)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (5, N'In-Flight Meal Service', N'Pre-order meals for your flight to enjoy during travel.', 25)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (6, N'Seat Selection', N'Choose your preferred seat in advance for added comfort.', 10)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (7, N'Airport Shuttle Service', N'Transportation to and from the airport.', 40)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (8, N'VIP Service', N'Personalized assistance at the airport for a premium experience.', 100)
INSERT [dbo].[Service] ([service_id], [service_name], [description], [price]) VALUES (9, N'Group Booking Service', N'Special rates and assistance for group travel bookings.', 5)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[Service Booking] ON 

INSERT [dbo].[Service Booking] ([service_id], [booking_id], [booking_service_id]) VALUES (1, 76, 1)
INSERT [dbo].[Service Booking] ([service_id], [booking_id], [booking_service_id]) VALUES (4, 76, 2)
INSERT [dbo].[Service Booking] ([service_id], [booking_id], [booking_service_id]) VALUES (8, 76, 3)
INSERT [dbo].[Service Booking] ([service_id], [booking_id], [booking_service_id]) VALUES (2, 77, 4)
INSERT [dbo].[Service Booking] ([service_id], [booking_id], [booking_service_id]) VALUES (5, 77, 5)
SET IDENTITY_INSERT [dbo].[Service Booking] OFF
GO
INSERT [dbo].[Subscriber Subscription] ([subscriber_id], [subscription_id]) VALUES (64, 11)
INSERT [dbo].[Subscriber Subscription] ([subscriber_id], [subscription_id]) VALUES (64, 16)
INSERT [dbo].[Subscriber Subscription] ([subscriber_id], [subscription_id]) VALUES (65, 20)
INSERT [dbo].[Subscriber Subscription] ([subscriber_id], [subscription_id]) VALUES (65, 14)
GO
SET IDENTITY_INSERT [dbo].[Subscription] ON 

INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (11, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Basic Flight Plan: 1 roundtrip flight credit per month, access to exclusive flight deals.', N'Basic Flight Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (12, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Standard Flight Plan: 2 roundtrip flight credits per month, priority customer support.', N'Standard Flight Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (13, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Premium Flight Plan: 4 roundtrip flight credits per month, complimentary lounge access.', N'Premium Flight Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (14, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Family Flight Plan: 6 roundtrip flight credits per month, kids fly free on select routes.', N'Family Flight Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (15, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Last-Minute Flight Plan: 1 roundtrip flight credit per month, access to last-minute deals.', N'Last-Minute Flight Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (16, CAST(N'2025-05-01T00:00:00.000' AS DateTime), CAST(N'2026-04-30T00:00:00.000' AS DateTime), N'GoWild! Pass: Unlimited travel to any Frontier destination for $499, with booking flexibility.', N'GoWild! All-You-Can-Fly Pass')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (18, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Frequent Flyer Plan: 5 roundtrip flights per year, free checked baggage, and lounge access.', N'Frequent Flyer Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (20, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Last-Minute Travel Plan: 2 roundtrip flights per year, access to last-minute deals and discounts.', N'Last-Minute Travel Plan')
INSERT [dbo].[Subscription] ([subscription_id], [start_date], [end_date], [description], [subscription_name]) VALUES (21, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Business Traveler Plan: 6 roundtrip flights per year, priority check-in, and complimentary upgrades.', N'Business Traveler Plan')
SET IDENTITY_INSERT [dbo].[Subscription] OFF
GO
SET IDENTITY_INSERT [dbo].[Traveler] ON 

INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (10, 54)
INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (11, 55)
INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (12, 57)
INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (13, 62)
INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (14, 64)
INSERT [dbo].[Traveler] ([traveler_id], [user_id]) VALUES (15, 65)
SET IDENTITY_INSERT [dbo].[Traveler] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (54, N'John', N'Doe', 30, CAST(N'1994-01-15' AS Date), N'johndoe@gmail.com', N'Male', N'johndoe', N'$2a$11$6yL3X86zQ6oJ5Rm3YNh5SuJCJW/UUBca9uuFnxFLbkIS4Hqsrysl.', N'34546366', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (55, N'Jane', N'Smith', 29, CAST(N'1995-02-20' AS Date), N'janesmith@gmail.com', N'Female', N'janesmith', N'$2a$11$3jYT.MFr5kYilvE2D133KuDl/GepqktvjgPvh6RH.ysSUWy/6CON2', N'34646534', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (56, N'Bob', N'Brown', 29, CAST(N'1995-02-20' AS Date), N'janesmith@gmail.com', N'Male', N'bobBrown', N'$2a$11$lbqhZdYX5qq/Tddht3k3m.aUtcMbKm6kcnijsYOBlx45YQmTtZkji', N'35657742', N'Employer')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (57, N'Diana', N'Wilson', 25, CAST(N'1999-07-14' AS Date), N'dianawil@gmail.com', N'Female', N'dianaWilson', N'$2a$11$6GgcPPeeZk/Sg3IRex26jeLWuPXNqnENrr93m18RouCgefoOG4yo6', N'36546363', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (58, N'Fiona', N'Martinez', 32, CAST(N'1992-06-17' AS Date), N'fionamart@gmail.com', N'Female', N'fionaMartinez', N'$2a$11$szY15ICgJE1407tNQDtGb.IXx9PKiUt04ZeWuuN4YcmSM3dLAw7LG', N'36637735', N'Admin')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (59, N'Alice', N'Johnson', 32, CAST(N'1992-06-17' AS Date), N'alicejohn@gmail.com', N'Female', N'aliceJohnson', N'$2a$11$I6FisfUiqDWUyNgm.tT5sumM3eGalsK/xVcITMhBj8hJsOlYwo5Ii', N'36547623', N'Admin')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (60, N'Reem', N'Adam', 24, CAST(N'2000-07-19' AS Date), N'alicejohn@gmail.com', N'Female', N'reem021', N'$2a$11$bgH5D1bavKeSTjt1GpOy4OrBifbJ69Ww8D/mlm2yE7MO3B.3y8uG6', N'36457621', N'Admin')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (61, N'Ali', N'Ahmed', 20, CAST(N'2004-06-15' AS Date), N'aliAhmed23@gmail.com', N'Male', N'Aliah23', N'$2a$11$QuqBz/l80jj1bbOnOyRt0e/9tl9VOdq5qMjmw6FraXR0tg11.xLgS', N'34758474', N'Employer')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (62, N'George', N'Anderson', 31, CAST(N'1993-05-03' AS Date), N'georgeanderson3@gmail.com', N'Male', N'georgea', N'$2a$11$5jYsVdlauiF00VY1pgWFBexHqhyqOWAPtcXXQ0MIlqdKfZH2uBnri', N'34758474', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (63, N'noora', N'ali', 21, CAST(N'2003-07-23' AS Date), N'nooraAli@gmail.com', N'Female', N'noora23', N'$2a$11$iFt6kDU0lqEaBEeM.TvNsOwv7UHSVRt6QTxvg2m0aLopIWz7aa746', N'34646532', N'Admin')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (64, N'maria', N'khalid', 21, CAST(N'2003-09-05' AS Date), N'mariaK22@gmail.com', N'Female', N'mk22', N'$2a$11$mC0K6iG/Pyv44AY3yJBgyOSZp9iQnXsRfdGuu9oymMas5PjxAKP5y', N'33645237', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (65, N'Deena', N'Ali', 0, CAST(N'2024-12-25' AS Date), N'deena@gmail.com', N'Female', N'deena01', N'$2a$11$irTyD83d2m.p5fKR2kkkhuyD.GPCxs/ZP8YTNp.5opkPmsbdneMnG', N'34556353', N'Traveler')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [age], [dob], [email], [gender], [username], [password], [phone_no], [role]) VALUES (66, N'yaseen', N'ahmed', 0, CAST(N'2024-12-25' AS Date), N'yaseen@gmail.com', N'Male', N'yaseen2', N'$2a$11$5TXU0ntHUTB1fQHZ.l7uiOP4R3GfAkxWZs5zYIiSBWzDsMk0EQf0m', N'34644955', N'Employer')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  Index [IXFK_Administrator_Message]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Administrator_Message] ON [dbo].[Administrator]
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Administrator_Service]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Administrator_Service] ON [dbo].[Administrator]
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Administrator_User]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Administrator_User] ON [dbo].[Administrator]
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Administrator_User_02]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Administrator_User_02] ON [dbo].[Administrator]
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Airport_City]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Airport_City] ON [dbo].[Airport]
(
	[airport_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Booking_Service Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Booking_Service Booking] ON [dbo].[Booking]
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_City_Country]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_City_Country] ON [dbo].[City]
(
	[city_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Employer_User]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Employer_User] ON [dbo].[Employer]
(
	[employer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Flight_Airport]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Flight_Airport] ON [dbo].[Flight]
(
	[departure] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Flight_Airport_02]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Flight_Airport_02] ON [dbo].[Flight]
(
	[destination] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Flight_Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Flight_Booking] ON [dbo].[Flight]
(
	[flight_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_FlightClass_Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_FlightClass_Booking] ON [dbo].[FlightClass]
(
	[flight_class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Service_Service Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Service_Service Booking] ON [dbo].[Service]
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Service_Subscription]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Service_Subscription] ON [dbo].[Service]
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Subscription_Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Subscription_Booking] ON [dbo].[Subscription]
(
	[subscription_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Traveler_Booking]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Traveler_Booking] ON [dbo].[Traveler]
(
	[traveler_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Traveler_Message]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Traveler_Message] ON [dbo].[Traveler]
(
	[traveler_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Traveler_Subscription]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Traveler_Subscription] ON [dbo].[Traveler]
(
	[traveler_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_Traveler_User]    Script Date: 12/25/2024 4:50:09 PM ******/
CREATE NONCLUSTERED INDEX [IXFK_Traveler_User] ON [dbo].[Traveler]
(
	[traveler_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_User]
GO
ALTER TABLE [dbo].[Airport]  WITH CHECK ADD  CONSTRAINT [FK_Airport_City1] FOREIGN KEY([city_id])
REFERENCES [dbo].[City] ([city_id])
GO
ALTER TABLE [dbo].[Airport] CHECK CONSTRAINT [FK_Airport_City1]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Flight] FOREIGN KEY([flight_id])
REFERENCES [dbo].[Flight] ([flight_id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Flight]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_FlightClass] FOREIGN KEY([flight_class_id])
REFERENCES [dbo].[FlightClass] ([flight_class_id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_FlightClass]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Traveler1] FOREIGN KEY([traveler_id])
REFERENCES [dbo].[Traveler] ([traveler_id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Traveler1]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([country_id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
ALTER TABLE [dbo].[Employer]  WITH CHECK ADD  CONSTRAINT [FK_Employer_User1] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Employer] CHECK CONSTRAINT [FK_Employer_User1]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airport] FOREIGN KEY([destination])
REFERENCES [dbo].[Airport] ([airport_id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airport]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airport1] FOREIGN KEY([departure])
REFERENCES [dbo].[Airport] ([airport_id])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airport1]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_User] FOREIGN KEY([sender_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_User]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_User1] FOREIGN KEY([receiver_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_User1]
GO
ALTER TABLE [dbo].[Service Booking]  WITH CHECK ADD  CONSTRAINT [FK_Service Booking_Booking] FOREIGN KEY([booking_id])
REFERENCES [dbo].[Booking] ([booking_id])
GO
ALTER TABLE [dbo].[Service Booking] CHECK CONSTRAINT [FK_Service Booking_Booking]
GO
ALTER TABLE [dbo].[Service Booking]  WITH CHECK ADD  CONSTRAINT [FK_Service Booking_Service] FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[Service Booking] CHECK CONSTRAINT [FK_Service Booking_Service]
GO
ALTER TABLE [dbo].[Subscriber Subscription]  WITH CHECK ADD  CONSTRAINT [FK_Subscriber Subscription_Subscription] FOREIGN KEY([subscription_id])
REFERENCES [dbo].[Subscription] ([subscription_id])
GO
ALTER TABLE [dbo].[Subscriber Subscription] CHECK CONSTRAINT [FK_Subscriber Subscription_Subscription]
GO
ALTER TABLE [dbo].[Subscriber Subscription]  WITH CHECK ADD  CONSTRAINT [FK_Subscriber Subscription_User] FOREIGN KEY([subscriber_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Subscriber Subscription] CHECK CONSTRAINT [FK_Subscriber Subscription_User]
GO
ALTER TABLE [dbo].[Traveler]  WITH CHECK ADD  CONSTRAINT [FK_Traveler_User1] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Traveler] CHECK CONSTRAINT [FK_Traveler_User1]
GO
USE [master]
GO
ALTER DATABASE [C:\USERS\HP\DOCUMENTS\GITHUB\HAPPY_JOURNEY_AIRLINE\HAPPY JOURNEY AIRLINE\BACKEND\DATABASE.MDF] SET  READ_WRITE 
GO
