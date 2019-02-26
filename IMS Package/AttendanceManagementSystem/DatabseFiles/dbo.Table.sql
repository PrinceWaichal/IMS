CREATE TABLE [dbo].[UserMaster]
(
	[Id] INT NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [MiddleName] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(20) NOT NULL, 
	[Address] VARCHAR(80) NOT NULL,
	[City] VARCHAR(80) NOT NULL,
	[PIN] NCHAR(6) NOT NULL,
	[State] VARCHAR(40) NOT NULL,
	[MobileNumber] NCHAR(10) NOT NULL,
	[EmailAddress] NVARCHAR(80) NOT NULL,
    [SSCUni] VARCHAR(60) NOT NULL, 
    [SSCInstitute] VARCHAR(60) NOT NULL, 
    [HSCUni] VARCHAR(60) NOT NULL, 
    [HSCInstitute] VARCHAR(60) NOT NULL, 
    [GradUni] VARCHAR(60) NULL, 
    [GradInstitute] VARCHAR(60) NULL, 
    [ParentMobile] NCHAR(10) NOT NULL, 
    [AadhaarNumber] NCHAR(12) NOT NULL, 
    [MaritalStatus] BIT NOT NULL, 
    [Disability] BIT NOT NULL, 
    [Category] VARCHAR(30) NOT NULL, 
    [Relig] VARCHAR(30) NOT NULL, 
    [CourseName] VARCHAR(40) NULL, 
    [Year] VARCHAR(40) NULL, 
    [Password] NVARCHAR(50) NOT NULL
)

Go
Alter table dbo.UserMaster
Add Constraint [Primary Key]
Primary Key (Id)

Go
Alter Table dbo.UserMaster
Add Constraint [Unique Aadhar Number]
Unique (AadhaarNumber)

Go
Alter Table dbo.UserMaster
Add Constraint [Unique Email Address]
Unique (EmailAddress)

Go
Alter Table dbo.UserMaster
Add Constraint [Unique Mobile Number]
Unique (MobileNumber)