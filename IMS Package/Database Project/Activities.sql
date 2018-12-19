CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Participation_In_Sports] NCHAR(10) NULL, 
    [Name] VARCHAR(50) NULL, 
    [Place] VARCHAR(50) NULL, 
    [Category] VARCHAR(50) NULL, 
    [Achievements] VARCHAR(50) NULL, 
    [Participation_In_ExtraActi] NCHAR(10) NULL, 
    [Purpose] VARCHAR(50) NULL, 
    [Remarks] NCHAR(10) NULL
)
