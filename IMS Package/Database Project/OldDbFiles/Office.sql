CREATE TABLE [dbo].[Office]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Pending_Fees] NCHAR(10) NULL, 
    [Total_Fees] NCHAR(10) NULL, 
    [Paid_Fees] NCHAR(10) NULL, 
    [Remaining_Fees] NCHAR(10) NULL, 
    [Scholarship_Eligibility] NCHAR(10) NULL, 
    [Scholarship_Name] NCHAR(10) NULL, 
    [Scholarship_Amount] NCHAR(10) NULL
)
