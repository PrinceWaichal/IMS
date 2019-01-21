CREATE TABLE [dbo].[StateMaster]
(
	[StateID] INT NOT NULL PRIMARY KEY, 
    [StateName] NVARCHAR(MAX) NOT NULL, 
    [City] INT NOT NULL, 
    [Pin] INT NOT NULL
)
