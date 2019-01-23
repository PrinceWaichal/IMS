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
	FOREIGN KEY ([Landmark])
	REFERENCES [CityMaster](CityID)

	Go
	Alter Table dbo.AdressLineMaster
	ADD CONSTRAINT [PinIDForKey]
	FOREIGN KEY ([City])
	REFERENCES [PINMaster] (PINID)

	Go
	Alter Table dbo.AdressLineMaster
	Add Constraint [LandmarkForKey]
	Foreign Key (Landmark)
	References [LandmarkMaster](LandmarkID)

	Go
	Alter Table dbo.AdressLineMaster
	Add Constraint [StateForKey]
	Foreign Key (State)
	References [StateMaster](StateID)

	--Unique Constraints:
	GO
	ALTER TABLE [dbo].[StateMaster]
	Add Constraint [StateNameUnique]
	Unique (StateName)

	/*Go
	Alter table [dbo].[StateMaster]
	--Add Constraint []
	--Unique ()
	*/