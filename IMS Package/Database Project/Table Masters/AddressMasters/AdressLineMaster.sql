CREATE TABLE [dbo].[AdressLineMaster]
(
	[AddressID] INT NOT NULL PRIMARY KEY, 
    [AddressLineOne] NVARCHAR(50) NOT NULL, 
    [AddressLineTwo] NVARCHAR(50) NULL, 
    [Landmark] INT NOT NULL, 
    [City] INT NOT NULL, 
    [Pin] INT NOT NULL, 
    [State] INT NOT NULL
)
