CREATE TABLE [dbo].[Attendance]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Course_Year] NCHAR(10) NULL, 
    [Course_Name] NCHAR(10) NULL, 
    [Course_YearDivision] NCHAR(10) NULL, 
    [add forKey] NCHAR(10) NULL, 
    [Calender(With-Checkbox)] NCHAR(10) NULL, 
    [Course_Subject] NCHAR(10) NULL
)
