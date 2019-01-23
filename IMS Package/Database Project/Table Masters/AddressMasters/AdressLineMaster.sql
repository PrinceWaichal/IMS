CREATE TABLE [dbo].[AdressLineMaster]
(
	[AddressID] INT NOT NULL, 
    [AddressLineOne] NVARCHAR(50) NOT NULL, 
    [AddressLineTwo] NVARCHAR(50) NULL, 
    [LandmarkID] INT NOT NULL, 
    [CityID] INT NOT NULL, 
    [PinID] INT NOT NULL, 
    [StateID] INT NOT NULL
)
