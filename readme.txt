sql server:

1. create table script:
	a.  USE - change to the relative databse name - USE [{Database_Name}]
	b. run this:

USE [TestDB]
GO

/****** Object:  Table [dbo].[tbl_Users]    Script Date: 1/13/2024 7:32:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Birthday] [datetime] NOT NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-------------------------------------------------------------------------------------------------------------------------------
backend (Visual studio - .net core 7):

https://github.com/roygim/TableBackend

1. git clone https://github.com/roygim/TableBackend

2. appsettings.json:
	a. connection strings - change server name && databe name:
	   Server={ServerName};Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;

	b. allowed origins - add your cleint domain

3. run

-------------------------------------------------------------------------------------------------------------------------------
frontend (Visual studio code - react):

https://github.com/roygim/TableFrontend

1. git clone https://github.com/roygim/TableFrontend

2. file .env: 
	a. REACT_APP_API_URL - change to current server url: 
	   REACT_APP_API_URL='SERVER_URL'

3. run - npm install

4. run - npm start



