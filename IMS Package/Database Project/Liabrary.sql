CREATE TABLE [dbo].[Liabrary]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Book_Pending] NCHAR(10) NULL, 
    [Book_Name] NCHAR(10) NULL, 
    [Book_GivenDate] NCHAR(10) NULL, 
    [FinePerDay] NCHAR(10) NULL, 
    [FineToBeReceived] NCHAR(10) NULL, 
    [Book_Optional] NCHAR(10) NULL
)
