--Primary Key Constraint
--All Table Masters

Go
Alter table dbo.AdressLineMaster
Add Constraint [PrimaryKeyAddress]
Primary Key (AddressID)
Go

Go
Alter table dbo.CityMaster
Add Constraint [PrimaryKeyCity]
Primary Key (CityID)
Go

	--Unique Constraint:
Go
Alter table dbo.CityMaster
Add Constraint [UniqueCity]
Unique (CityName)
Go

Go
Alter table dbo.PINMaster
Add Constraint [PrimaryKeyPIN]
Primary Key (PINID)
Go

Go
Alter Table dbo.LandmarkMaster
Add Constraint [PrimaryKeyLandmark]
Primary Key (LandmarkID)
Go

Go
Alter Table dbo.StateMaster
Add Constraint [PrimaryKeyState]
Primary Key (StateID)
Go

--Unique Constraint:
GO
ALTER TABLE [dbo].[StateMaster]
Add Constraint [StateNameUnique]
Unique (StateName)
Go

	--Foreign Key Constraint:
	
	--StateMaster Update of FK
ALTER TABLE [dbo].[StateMaster]
ADD CONSTRAINT [PinIDFK]
FOREIGN KEY (Pin)
REFERENCES [PINMaster] (PINID)

GO
ALTER TABLE [dbo].[StateMaster]
ADD CONSTRAINT [CityIDFK]
FOREIGN KEY (City)
REFERENCES [CityMaster](CityID)

Go
ALTER TABLE [dbo].[StateMaster]
Add Constraint [LandmarkFK]
Foreign Key (Landmark)
References [LandmarkMaster](LandmarkID)


	-- Adress Line Update of FK
Go
Alter Table dbo.AdressLineMaster
ADD CONSTRAINT [CityIDForKey]
FOREIGN KEY ([LandmarkID])
REFERENCES [CityMaster](CityID)

Go
Alter Table dbo.AdressLineMaster
ADD CONSTRAINT [PinIDForKey]
FOREIGN KEY ([CityID])
REFERENCES [PINMaster] (PINID)

Go
Alter Table dbo.AdressLineMaster
Add Constraint [LandmarkForKey]
Foreign Key ([LandmarkID])
References [LandmarkMaster](LandmarkID)

Go
Alter Table dbo.AdressLineMaster
Add Constraint [StateForKey]
Foreign Key ([StateID])
References [StateMaster](StateID)