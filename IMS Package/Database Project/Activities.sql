CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Participation_In_Sports] NCHAR(10) NULL, 
    [Name] NCHAR(10) NULL, 
    [Place] NCHAR(10) NULL, 
    [Category] NCHAR(10) NULL, 
    [Achievements] NCHAR(10) NULL, 
    [Participation_In_ExtraActi] NCHAR(10) NULL, 
    [Purpose] NCHAR(10) NULL, 
    [Remarks] NCHAR(10) NULL
)
