CREATE TABLE [dbo].[LoginMaster]
(
	[LoginID] VARCHAR(15) NOT NULL,
	[Password] varchar(15) not null
)

--Constraints
--1) Primary Key
Go
Alter Table dbo.LoginMaster
Add Constraint [Login Primary Key]
Primary Key (LoginID)

--2) Unique Constraint
Go
Alter Table dbo.LoginMaster
Add Constraint [Password Unique Key]
Unique (Password)