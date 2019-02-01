create database UserMasterDb;
create table UserMaster
(
UserNameID INT Not Null, 
UserName NCHAR(15) NOT NULL,
UserPasswordID INT NOT NULL);

insert into UserMaster values(101, 'Admin', 'Pass');