--Constraints
--1) Primary Key
--1.1) Landline Master
Go
Alter Table dbo.LandlineMaster
Add Constraint [Landline Primary Key]
Primary Key (LandlineID)

--1.2) Mobile Master
Go
Alter Table dbo.MobileMaster
Add Constraint [Mobile Phone Primary Key]
Primary Key (MobileNumberID)

--2) Foreign Key
--2.1) Landline Master
Go
Alter Table dbo.LandlineMaster
Add Constraint [Pin Code Foreign Key]
Foreign Key (PinID)
References [PINMaster](PINID)

--2.2) Mobile Master
Go
Alter Table dbo.MobileMaster
Add Constraint [ISD Foreign Key]
Foreign Key (NationalityID)
References [NationalityMaster](NationalityID)


--3) Unique Key
--3.1) Landline Master
Go
Alter Table dbo.LandlineMaster
Add Constraint [Unique Landline Number]
Unique (LandlineNumber)

--3.2) Mobile Master
Go
Alter Table dbo.MobileMaster
Add Constraint [Unique Mobile Number]
Unique (MobileNumber)
