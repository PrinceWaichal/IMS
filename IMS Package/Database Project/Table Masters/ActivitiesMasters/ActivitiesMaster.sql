CREATE TABLE [dbo].[ActivitiesMaster]
(
	[ActivityID] INT NOT NULL,
	[ActivityName] varchar (25) Not Null,
	[ActivityDescription] varchar(max) Not Null
)

Go
Alter Table dbo.ActivitiesMaster
Add Constraint [Primary ActivityID]
Primary Key (ActivityID)

Go
Alter table dbo.ActivitiesMaster
Add Constraint [Unique Activity]
Unique (ActivityName)
