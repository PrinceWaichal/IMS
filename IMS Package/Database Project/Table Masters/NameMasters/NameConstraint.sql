--Adding Primary Keys

--1) Middle Name
Go
Alter Table dbo.MiddleName
Add Constraint [PrimaryKeyMidName]
Primary Key (MidNameID)

--2) First Name
Go
Alter Table dbo.FirstName
Add Constraint [PrimaryKeyFirstName]
Primary Key (FirstNameID)

--3) Last Name 
Go
Alter Table dbo.LastName
Add Constraint [PrimaryKeyLastName]
Primary Key (LastNameID)

--4) Name Table
Go
Alter Table dbo.NameTable
Add Constraint [NamePrimaryKey]
Primary Key (NameID)


--Adding Foreign Keys

--1) Mid Name
Go
Alter Table dbo.NameTable
Add Constraint [MidNameForeignKey]
Foreign Key (MiddleNameID)
References [MiddleName](MidNameID)

--2) First Name
Go
Alter Table dbo.NameTable
Add Constraint [FirstNameForeignKey]
Foreign Key (FirstNameID)
References [FirstName](FirstNameID)

--3) Last Name
Go
Alter Table dbo.NameTable
Add Constraint [LastNameForeignKey]
Foreign Key (LastNameID)
References [LastName](LastNameID)