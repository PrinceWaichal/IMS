CREATE TABLE [dbo].[Simple_Table]
(
	[ID] int not null,
    [Name] NCHAR(10) NOT NULL, 
    [Number] NUMERIC NOT NULL, 
    [Birthday] DATETIME NOT NULL, 
    [Gender] CHAR(10) NOT NULL, 
    PRIMARY KEY ([ID])
)
