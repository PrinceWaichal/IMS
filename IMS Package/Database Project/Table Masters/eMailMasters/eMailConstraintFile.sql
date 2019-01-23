--Foreign Key Constraint Addition
--eMailMaster Table
Go
Alter Table dbo.eMailMaster
Add Constraint [DomainForeignKey]
Foreign Key (eMailDomain)
References [DomainMaster](DomainID)

--Unique Key for eMailAddress
Go
Alter Table dbo.eMailMaster
Add Constraint [UniqueEMAIL]
Unique (eMailAddress)

Go
Alter Table dbo.eMailMaster
Add Constraint [eMailIDPrimeKey]
Primary Key (eMailID)
Go

Go
Alter Table dbo.DomainMaster
Add Constraint [DomainIDPrimeKey]
Primary Key (DomainID)
Go