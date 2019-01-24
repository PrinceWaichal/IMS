CREATE TABLE [dbo].[NationalityMaster]
(
	[NationalityID] INT NOT NULL,
	[Nationality] varchar(20) not null
)

Go
Alter Table NationalityMaster
Add Constraint [Primary Key]
Primary Key (NationalityID)
