--1) Primary Keys
--1.1) UserName
Go
Alter Table dbo.UserNameMaster
Add Constraint [Primary Key UserName]
Primary Key (UserNameID)

--1.2) UserPassword
Go
Alter Table dbo.UserPasswordMaster
Add Constraint [Primary Key UserPassword]
Primary Key (UserPassID)

--2) Foreign Key
--2.1) Password Foreign Key
Go
Alter Table dbo.UserNameMaster
Add Constraint [Password Foreign Key]
Foreign Key (UserPasswordID)
References [UserPasswordMaster] (UserPassID)

--3) Unique Key
--3.1) Unique UserName 
Go
Alter Table dbo.UserNameMaster
Add Constraint [Unique UserName]
Unique (UserName)

--
Go
