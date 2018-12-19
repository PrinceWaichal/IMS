CREATE TABLE [dbo].[Attendance]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Course_Year] DATE NULL, 
    [Course_Name] VARCHAR(50) NULL, 
    [Course_YearDivision] VARCHAR(50) NULL, 
    [add forKey] NCHAR(10) NULL, 
    [Calender(With-Checkbox)] DATETIME NULL, 
    [Course_Subject] VARCHAR(50) NULL
)
