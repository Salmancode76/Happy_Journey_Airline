﻿/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 12-Dec-2024 03:27:50:PM 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Administrator_Message]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Administrator] DROP CONSTRAINT [FK_Administrator_Message]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Administrator_Service]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Administrator] DROP CONSTRAINT [FK_Administrator_Service]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Administrator_User_02]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Administrator] DROP CONSTRAINT [FK_Administrator_User_02]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Airport_City]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Airport] DROP CONSTRAINT [FK_Airport_City]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Booking_Traveler]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Booking] DROP CONSTRAINT [FK_Booking_Traveler]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Credit Card_Payment]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Credit Card] DROP CONSTRAINT [FK_Credit Card_Payment]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Debit Card_Payment]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Debit Card] DROP CONSTRAINT [FK_Debit Card_Payment]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Employer_User]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Employer] DROP CONSTRAINT [FK_Employer_User]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Flight_Booking]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Flight] DROP CONSTRAINT [FK_Flight_Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_FlightClass_Booking]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [FlightClass] DROP CONSTRAINT [FK_FlightClass_Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Service_Service Booking]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Service] DROP CONSTRAINT [FK_Service_Service Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Service_Subscription]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Service] DROP CONSTRAINT [FK_Service_Subscription]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Subscription_Booking]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Subscription] DROP CONSTRAINT [FK_Subscription_Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Traveler_Message]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Traveler] DROP CONSTRAINT [FK_Traveler_Message]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Traveler_Subscription]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Traveler] DROP CONSTRAINT [FK_Traveler_Subscription]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Traveler_User]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Traveler] DROP CONSTRAINT [FK_Traveler_User]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Administrator]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Administrator]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Airport]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Airport]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Booking]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[City]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [City]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Country]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Country]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Credit Card]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Credit Card]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Debit Card]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Debit Card]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Employer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Employer]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Flight]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Flight]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FlightClass]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [FlightClass]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Message]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Message]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Payment]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Payment]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Service]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Service]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Service Booking]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Service Booking]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Subscription]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Subscription]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Traveler]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Traveler]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[User]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [User]
GO

/* Create Tables */

CREATE TABLE [Administrator]
(
	[admin_id] int NOT NULL IDENTITY (1, 1),
	[user_id] int NULL
)
GO

CREATE TABLE [Airport]
(
	[airport_id] int NOT NULL IDENTITY (1, 1),
	[airport_code] varchar(3) NULL,
	[city_id] int NULL,
	[airport_name] varchar(50) NULL
)
GO

CREATE TABLE [Booking]
(
	[booking_id] int NOT NULL IDENTITY (1, 1),
	[flight_class_id] int NULL,
	[flight_id] int NULL,
	[payment_id] int NULL,
	[seat_no] int NULL,
	[status] varchar(50) NULL,
	[subscription_id] int NULL,
	[traveler_id] int NULL,
	[booking_service_id] int NULL
)
GO

CREATE TABLE [City]
(
	[city_id] int NOT NULL IDENTITY (1, 1),
	[city_name] varchar(50) NULL
)
GO

CREATE TABLE [Country]
(
	[country_id] int NOT NULL IDENTITY (1, 1),
	[country_name] varchar(50) NULL,
	[region] varchar(50) NULL
)
GO

CREATE TABLE [Credit Card]
(
	[credit_card_id] int NOT NULL IDENTITY (1, 1),
	[card_number] int NULL,
	[card_holder] varchar(50) NULL,
	[expiration_date] datetime NULL,
	[cvv] int NULL
)
GO

CREATE TABLE [Debit Card]
(
	[debit_card_id] int NOT NULL IDENTITY (1, 1),
	[card_number] int NULL,
	[card_holder] varchar(50) NULL,
	[expiration_date] datetime NULL,
	[pin] int NULL
)
GO

CREATE TABLE [Employer]
(
	[employer_id] int NOT NULL IDENTITY (1, 1),
	[user_id] int NULL
)
GO

CREATE TABLE [Flight]
(
	[flight_id] int NOT NULL IDENTITY (1, 1),
	[departure] int NULL,
	[destination] int NULL,
	[flight_no] int NULL,
	[airport_id] int NULL,
	[capacity] int NULL,
	[price] float NULL,
	[status] varchar(50) NULL,
	[departure_time] datetime NULL,
	[arrival_time] datetime NULL
)
GO

CREATE TABLE [FlightClass]
(
	[flight_class_id] int NOT NULL IDENTITY (1, 1),
	[flight_class_name] varchar(50) NULL,
	[seat_count] int NULL
)
GO

CREATE TABLE [Message]
(
	[message_id] int NOT NULL IDENTITY (1, 1),
	[content] varchar(100) NULL,
	[sender_id] int NULL,
	[receiver_id] int NULL,
	[timestamp] datetime NULL
)
GO

CREATE TABLE [Payment]
(
	[payment_id] int NOT NULL IDENTITY (1, 1),
	[date] datetime NULL,
	[amount] float NULL
)
GO

CREATE TABLE [Service]
(
	[service_id] int NOT NULL IDENTITY (1, 1),
	[service_name] varchar(50) NULL,
	[description] varchar(100) NULL,
	[price] float NULL
)
GO

CREATE TABLE [Service Booking]
(
	[service_id] int NULL,
	[booking_id] int NULL,
	[booking_service_id] int NOT NULL IDENTITY (1, 1)
)
GO

CREATE TABLE [Subscription]
(
	[subscription_id] int NOT NULL IDENTITY (1, 1),
	[services_id] int NULL,
	[subscribers_id] int NULL,
	[start_date] datetime NULL,
	[end_date] datetime NULL,
	[cost] float NULL
)
GO

CREATE TABLE [Traveler]
(
	[traveler_id] int NOT NULL IDENTITY (1, 1),
	[user_id] int NULL
)
GO

CREATE TABLE [User]
(
	[user_id] int NOT NULL IDENTITY (1, 1),
	[name] varchar(50) NULL,
	[age] int NULL,
	[dob] date NULL,
	[email] varchar(50) NULL,
	[gender] varchar(50) NULL,
	[username] varchar(50) NULL,
	[password] varchar(100) NULL,
	[phone_no] varchar(20) NULL,
	[role] varchar(50) NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Administrator] 
 ADD CONSTRAINT [PK_Administrator]
	PRIMARY KEY CLUSTERED ([admin_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Administrator_Message] 
 ON [Administrator] ([admin_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Administrator_Service] 
 ON [Administrator] ([admin_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Administrator_User] 
 ON [Administrator] ([admin_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Administrator_User_02] 
 ON [Administrator] ([admin_id] ASC)
GO

ALTER TABLE [Airport] 
 ADD CONSTRAINT [PK_Airport]
	PRIMARY KEY CLUSTERED ([airport_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Airport_City] 
 ON [Airport] ([airport_id] ASC)
GO

ALTER TABLE [Booking] 
 ADD CONSTRAINT [PK_Booking]
	PRIMARY KEY CLUSTERED ([booking_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Booking_Service Booking] 
 ON [Booking] ([booking_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Booking_Traveler] 
 ON [Booking] ([traveler_id] ASC)
GO

ALTER TABLE [City] 
 ADD CONSTRAINT [PK_City]
	PRIMARY KEY CLUSTERED ([city_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_City_Country] 
 ON [City] ([city_id] ASC)
GO

ALTER TABLE [Country] 
 ADD CONSTRAINT [PK_Country]
	PRIMARY KEY CLUSTERED ([country_id] ASC)
GO

ALTER TABLE [Credit Card] 
 ADD CONSTRAINT [PK_Credit Card]
	PRIMARY KEY CLUSTERED ([credit_card_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Credit Card_Payment] 
 ON [Credit Card] ([credit_card_id] ASC)
GO

ALTER TABLE [Debit Card] 
 ADD CONSTRAINT [PK_Debit Card]
	PRIMARY KEY CLUSTERED ([debit_card_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Debit Card_Payment] 
 ON [Debit Card] ([debit_card_id] ASC)
GO

ALTER TABLE [Employer] 
 ADD CONSTRAINT [PK_Employer]
	PRIMARY KEY CLUSTERED ([employer_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Employer_User] 
 ON [Employer] ([employer_id] ASC)
GO

ALTER TABLE [Flight] 
 ADD CONSTRAINT [PK_Flight]
	PRIMARY KEY CLUSTERED ([flight_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Flight_Airport] 
 ON [Flight] ([departure] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Flight_Airport_02] 
 ON [Flight] ([destination] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Flight_Booking] 
 ON [Flight] ([flight_id] ASC)
GO

ALTER TABLE [FlightClass] 
 ADD CONSTRAINT [PK_FlightClass]
	PRIMARY KEY CLUSTERED ([flight_class_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_FlightClass_Booking] 
 ON [FlightClass] ([flight_class_id] ASC)
GO

ALTER TABLE [Message] 
 ADD CONSTRAINT [PK_Message]
	PRIMARY KEY CLUSTERED ([message_id] ASC)
GO

ALTER TABLE [Payment] 
 ADD CONSTRAINT [PK_Payment]
	PRIMARY KEY CLUSTERED ([payment_id] ASC)
GO

ALTER TABLE [Service] 
 ADD CONSTRAINT [PK_Service]
	PRIMARY KEY CLUSTERED ([service_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Service_Service Booking] 
 ON [Service] ([service_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Service_Subscription] 
 ON [Service] ([service_id] ASC)
GO

ALTER TABLE [Service Booking] 
 ADD CONSTRAINT [PK_Service Booking]
	PRIMARY KEY CLUSTERED ([booking_service_id] ASC)
GO

ALTER TABLE [Subscription] 
 ADD CONSTRAINT [PK_Subscription]
	PRIMARY KEY CLUSTERED ([subscription_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Subscription_Booking] 
 ON [Subscription] ([subscription_id] ASC)
GO

ALTER TABLE [Traveler] 
 ADD CONSTRAINT [PK_Traveler]
	PRIMARY KEY CLUSTERED ([traveler_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Traveler_Message] 
 ON [Traveler] ([traveler_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Traveler_Subscription] 
 ON [Traveler] ([traveler_id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Traveler_User] 
 ON [Traveler] ([traveler_id] ASC)
GO

ALTER TABLE [User] 
 ADD CONSTRAINT [PK_User]
	PRIMARY KEY CLUSTERED ([user_id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [Administrator] ADD CONSTRAINT [FK_Administrator_Message]
	FOREIGN KEY ([admin_id]) REFERENCES [Message] ([message_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Administrator] ADD CONSTRAINT [FK_Administrator_Service]
	FOREIGN KEY ([admin_id]) REFERENCES [Service] ([service_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Administrator] ADD CONSTRAINT [FK_Administrator_User_02]
	FOREIGN KEY ([admin_id]) REFERENCES [User] ([user_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Airport] ADD CONSTRAINT [FK_Airport_City]
	FOREIGN KEY ([airport_id]) REFERENCES [City] ([city_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Booking] ADD CONSTRAINT [FK_Booking_Traveler]
	FOREIGN KEY ([traveler_id]) REFERENCES [Traveler] ([traveler_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Credit Card] ADD CONSTRAINT [FK_Credit Card_Payment]
	FOREIGN KEY ([credit_card_id]) REFERENCES [Payment] ([payment_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Debit Card] ADD CONSTRAINT [FK_Debit Card_Payment]
	FOREIGN KEY ([debit_card_id]) REFERENCES [Payment] ([payment_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Employer] ADD CONSTRAINT [FK_Employer_User]
	FOREIGN KEY ([employer_id]) REFERENCES [User] ([user_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Flight] ADD CONSTRAINT [FK_Flight_Booking]
	FOREIGN KEY ([flight_id]) REFERENCES [Booking] ([booking_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [FlightClass] ADD CONSTRAINT [FK_FlightClass_Booking]
	FOREIGN KEY ([flight_class_id]) REFERENCES [Booking] ([booking_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Service] ADD CONSTRAINT [FK_Service_Service Booking]
	FOREIGN KEY ([service_id]) REFERENCES [Service Booking] ([booking_service_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Service] ADD CONSTRAINT [FK_Service_Subscription]
	FOREIGN KEY ([service_id]) REFERENCES [Subscription] ([subscription_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Subscription] ADD CONSTRAINT [FK_Subscription_Booking]
	FOREIGN KEY ([subscription_id]) REFERENCES [Booking] ([booking_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Traveler] ADD CONSTRAINT [FK_Traveler_Message]
	FOREIGN KEY ([traveler_id]) REFERENCES [Message] ([message_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Traveler] ADD CONSTRAINT [FK_Traveler_Subscription]
	FOREIGN KEY ([traveler_id]) REFERENCES [Subscription] ([subscription_id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Traveler] ADD CONSTRAINT [FK_Traveler_User]
	FOREIGN KEY ([traveler_id]) REFERENCES [User] ([user_id]) ON DELETE No Action ON UPDATE No Action
GO
