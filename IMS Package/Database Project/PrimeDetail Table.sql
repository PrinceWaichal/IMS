CREATE TABLE [dbo].[Student Table]
(
	[Enrollment Number] INT NOT NULL PRIMARY KEY, 
    [Last_Name] VARCHAR(50) NOT NULL, 
    [First_Name] VARCHAR(50) NOT NULL, 
    [Middle_Name] VARCHAR(50) NOT NULL, 
    [Mother_First] VARCHAR(50) NOT NULL, 
    [Mother_Maiden] VARCHAR(50) NOT NULL, 
    [DOB] DATE NOT NULL, 
    [Nationality] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [Corrosponding_add] VARCHAR(50) NOT NULL, 
    [Permanent_Add] VARCHAR(50) NOT NULL, 
    [E_mail] VARCHAR(50) NOT NULL, 
    [Phone] NUMERIC NOT NULL, 
    [Mobile] NUMERIC NOT NULL, 
    [Lanldline] NUMERIC NOT NULL, 
    [Blood_Group] NUMERIC NOT NULL, 
    [Religion] VARCHAR(50) NOT NULL, 
    [Caste] VARCHAR(50) NOT NULL, 
    [Sub_Cast] VARCHAR(50) NOT NULL, 
    [Marital_Status] NCHAR(10) NOT NULL, 
    [Physical_disability] NCHAR(10) NOT NULL
)
