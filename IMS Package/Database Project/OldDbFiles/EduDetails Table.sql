CREATE TABLE [dbo].[TSTable]
(
	[Id] INT NOT NULL, 
    [Primary] VARCHAR(50) NULL, 
    [Secondary] VARCHAR(50) NULL, 
    [Higher_Secondary] VARCHAR(50) NULL, 
    [Graduation/Degree] VARCHAR(50) NULL, 
    [Post_Graduation] VARCHAR(50) NULL, 
    [Professional_Degree] VARCHAR(50) NULL, 
    [Others(Please_specify)] NCHAR(10) NULL, 
    [to add forKey] NCHAR(10) NULL 
)
