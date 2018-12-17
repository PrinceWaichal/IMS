CREATE TABLE [dbo].[Student Table]
(
	[Enrollment Number] INT NOT NULL PRIMARY KEY, 
    [Last_Name] VARCHAR(50) NOT NULL, 
    [First_Name] VARCHAR(50) NOT NULL, 
    [Middle_Name] VARCHAR(50) NOT NULL, 
    [Mother_First] VARCHAR(50) NOT NULL, 
    [Mother_Maiden] VARCHAR(50) NOT NULL, 
    [DOB] DATE NULL, 
    [Nationality] VARCHAR(50) NULL, 
    [Gender] VARCHAR(50) NULL, 
    [Corrosponding_add] VARCHAR(50) NULL, 
    [Permanent_Add] VARCHAR(50) NULL, 
    [E_mail] VARCHAR(50) NULL, 
    [Phone] NUMERIC NULL, 
    [Mobile] NUMERIC NULL, 
    [Lanldline] NUMERIC NULL, 
    [Blood_Group] NUMERIC NULL, 
    [Religion] VARCHAR(50) NULL, 
    [Caste] VARCHAR(50) NULL, 
    [Sub_Cast] VARCHAR(50) NULL, 
    [Marital_Status] NCHAR(10) NULL, 
    [Physical_disability] NCHAR(10) NULL
)
