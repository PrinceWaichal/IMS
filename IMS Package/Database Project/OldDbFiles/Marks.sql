CREATE TABLE [dbo].[Marks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Course_Name] NCHAR(10) NULL, 
    [Course_Year] NCHAR(10) NULL, 
    [Course_Subject] NCHAR(10) NULL, 
    [Exam_Duration] NCHAR(10) NULL, 
    [Ex_Mrk_Internal] NCHAR(10) NULL, 
    [Ex_Mrk_External] NCHAR(10) NULL, 
    [Ex_Mrk_Written] NCHAR(10) NULL, 
    [Ex_Mrk_Total] NCHAR(10) NULL 
)
