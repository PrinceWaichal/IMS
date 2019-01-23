CREATE TABLE [dbo].[GenderTable]
(
	[GenderID] INT NOT NULL, 
    [Gender] TEXT NOT NULL 
)

go
Alter table dbo.GenderTable
Add Constraint [PrimaryKeyGenderID]
Primary Key (GenderID)

go
Alter Table dbo.GenderTable
Add Constraint [UniqueGender]
Unique (Gender)