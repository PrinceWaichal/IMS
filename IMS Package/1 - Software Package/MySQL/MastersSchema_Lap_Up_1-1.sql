CREATE DATABASE  IF NOT EXISTS `MastersSchema` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `MastersSchema`;
-- MySQL dump 10.13  Distrib 8.0.14, for Win64 (x86_64)
--
-- Host: localhost    Database: MastersSchema
-- ------------------------------------------------------
-- Server version	8.0.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `AadharMaster`
--

DROP TABLE IF EXISTS `AadharMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `AadharMaster` (
  `AadharID` int(11) NOT NULL AUTO_INCREMENT,
  `AadharNumber` int(12) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`AadharID`),
  UNIQUE KEY `AadharNumber_UNIQUE` (`AadharNumber`),
  KEY `FK for Aadhar_idx` (`UserNameID`),
  CONSTRAINT `FK for Aadhar` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Table to hold Aadhar numbers';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AadharMaster`
--

LOCK TABLES `AadharMaster` WRITE;
/*!40000 ALTER TABLE `AadharMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `AadharMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ActivitiesMaster`
--

DROP TABLE IF EXISTS `ActivitiesMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ActivitiesMaster` (
  `ActivityID` int(11) NOT NULL AUTO_INCREMENT,
  `ActivityName` varchar(50) NOT NULL,
  `ActivityDescription` longtext,
  `ActivityPurpose` binary(1) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`ActivityID`),
  UNIQUE KEY `ActivityName_UNIQUE` (`ActivityName`),
  KEY `Activity FK_idx` (`UsernameID`),
  CONSTRAINT `FK for Activity` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ActivitiesMaster`
--

LOCK TABLES `ActivitiesMaster` WRITE;
/*!40000 ALTER TABLE `ActivitiesMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `ActivitiesMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AddressMaster`
--

DROP TABLE IF EXISTS `AddressMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `AddressMaster` (
  `AddressID` int(11) NOT NULL AUTO_INCREMENT,
  `AddressLineOne` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `AddressLineTwo` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `LadnmarkID` int(11) NOT NULL,
  `CityID` int(11) NOT NULL,
  `StateID` int(11) NOT NULL,
  `PostalCodeID` int(11) NOT NULL,
  `UsernameID` int(11) DEFAULT NULL,
  PRIMARY KEY (`AddressID`),
  UNIQUE KEY `AddressLineOne_UNIQUE` (`AddressLineOne`),
  UNIQUE KEY `AddressLineTwo_UNIQUE` (`AddressLineTwo`),
  KEY `Username FK_idx` (`UsernameID`),
  CONSTRAINT `FK for Address` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AddressMaster`
--

LOCK TABLES `AddressMaster` WRITE;
/*!40000 ALTER TABLE `AddressMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `AddressMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `BirthDateMaster`
--

DROP TABLE IF EXISTS `BirthDateMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `BirthDateMaster` (
  `BirthDateID` int(11) NOT NULL AUTO_INCREMENT,
  `BirthDate` date NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`BirthDateID`),
  KEY `FK for Birthdate_idx` (`UserNameID`),
  CONSTRAINT `FK for Birthdate` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BirthDateMaster`
--

LOCK TABLES `BirthDateMaster` WRITE;
/*!40000 ALTER TABLE `BirthDateMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `BirthDateMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `BooksMaster`
--

DROP TABLE IF EXISTS `BooksMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `BooksMaster` (
  `BookID` int(11) NOT NULL AUTO_INCREMENT,
  `BookName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `BookGiven` date NOT NULL,
  `BookReturn` date NOT NULL,
  `Fine` int(11) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`BookID`),
  UNIQUE KEY `BookName_UNIQUE` (`BookName`),
  KEY `FK for Book_idx` (`UserNameID`),
  CONSTRAINT `FK for Book` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Books Information Table';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BooksMaster`
--

LOCK TABLES `BooksMaster` WRITE;
/*!40000 ALTER TABLE `BooksMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `BooksMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CasteMaster`
--

DROP TABLE IF EXISTS `CasteMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `CasteMaster` (
  `CasteID` int(11) NOT NULL AUTO_INCREMENT,
  `Caste` varchar(20) NOT NULL,
  PRIMARY KEY (`CasteID`),
  UNIQUE KEY `Caste_UNIQUE` (`Caste`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Caste Information';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CasteMaster`
--

LOCK TABLES `CasteMaster` WRITE;
/*!40000 ALTER TABLE `CasteMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `CasteMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CategoryMaster`
--

DROP TABLE IF EXISTS `CategoryMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `CategoryMaster` (
  `CategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(45) NOT NULL,
  PRIMARY KEY (`CategoryID`),
  UNIQUE KEY `Category_UNIQUE` (`Category`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CategoryMaster`
--

LOCK TABLES `CategoryMaster` WRITE;
/*!40000 ALTER TABLE `CategoryMaster` DISABLE KEYS */;
INSERT INTO `CategoryMaster` VALUES (104,'NT'),(102,'OBC'),(101,'Open'),(103,'SC');
/*!40000 ALTER TABLE `CategoryMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CourseMaster`
--

DROP TABLE IF EXISTS `CourseMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `CourseMaster` (
  `CourseID` int(11) NOT NULL AUTO_INCREMENT,
  `CourseName` varchar(45) NOT NULL,
  PRIMARY KEY (`CourseID`),
  UNIQUE KEY `CourseName_UNIQUE` (`CourseName`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CourseMaster`
--

LOCK TABLES `CourseMaster` WRITE;
/*!40000 ALTER TABLE `CourseMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `CourseMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eMailDomainMaster`
--

DROP TABLE IF EXISTS `eMailDomainMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `eMailDomainMaster` (
  `eMailDomainID` int(11) NOT NULL AUTO_INCREMENT,
  `eMailDomain` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`eMailDomainID`),
  UNIQUE KEY `eMailDomain_UNIQUE` (`eMailDomain`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Email Domain Master';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eMailDomainMaster`
--

LOCK TABLES `eMailDomainMaster` WRITE;
/*!40000 ALTER TABLE `eMailDomainMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `eMailDomainMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eMailMaster`
--

DROP TABLE IF EXISTS `eMailMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `eMailMaster` (
  `eMailMasterID` int(11) NOT NULL AUTO_INCREMENT,
  `eMailAddress` varchar(50) NOT NULL,
  `eMailDomainID` int(11) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`eMailMasterID`),
  UNIQUE KEY `eMailAddress_UNIQUE` (`eMailAddress`),
  KEY `FK for Email_idx` (`UserNameID`),
  KEY `FK for Domain_idx` (`eMailDomainID`),
  CONSTRAINT `FK for Domain` FOREIGN KEY (`eMailDomainID`) REFERENCES `emaildomainmaster` (`eMailDomainID`) ON DELETE RESTRICT,
  CONSTRAINT `FK for Email` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Email Address Table';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eMailMaster`
--

LOCK TABLES `eMailMaster` WRITE;
/*!40000 ALTER TABLE `eMailMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `eMailMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ExamMaster`
--

DROP TABLE IF EXISTS `ExamMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ExamMaster` (
  `ExamID` int(11) NOT NULL AUTO_INCREMENT,
  `ExamName` varchar(25) NOT NULL,
  `ExamDate` date NOT NULL,
  `UsernameID` int(11) DEFAULT NULL,
  `CourseID` int(11) NOT NULL,
  `ExamStatus` binary(1) NOT NULL COMMENT 'Regluar should be set to 0\nRepeater sohuld be set to 1\nBinary',
  PRIMARY KEY (`ExamID`),
  UNIQUE KEY `ExamName_UNIQUE` (`ExamName`),
  UNIQUE KEY `ExamDate_UNIQUE` (`ExamDate`),
  KEY `FK for Exam_idx` (`UsernameID`),
  KEY `FK for Course_idx` (`CourseID`),
  CONSTRAINT `FK for Course` FOREIGN KEY (`CourseID`) REFERENCES `coursemaster` (`CourseID`) ON DELETE RESTRICT,
  CONSTRAINT `FK for Exam` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Exam related Data';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ExamMaster`
--

LOCK TABLES `ExamMaster` WRITE;
/*!40000 ALTER TABLE `ExamMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `ExamMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ExternalMarksMaster`
--

DROP TABLE IF EXISTS `ExternalMarksMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ExternalMarksMaster` (
  `ExternalEvalID` int(11) NOT NULL AUTO_INCREMENT,
  `ExternalMarkOne` decimal(4,0) NOT NULL,
  `ExternalMarkTwo` decimal(4,0) DEFAULT NULL,
  `ExamNameID` int(11) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`ExternalEvalID`),
  KEY `FK for Ext Marks_idx` (`UsernameID`),
  KEY `FK For Exam Name_idx` (`ExamNameID`),
  CONSTRAINT `FK For Exam Name` FOREIGN KEY (`ExamNameID`) REFERENCES `exammaster` (`ExamID`) ON DELETE RESTRICT,
  CONSTRAINT `FK for Ext Marks` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Examination Marking Table for External Evaluators';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ExternalMarksMaster`
--

LOCK TABLES `ExternalMarksMaster` WRITE;
/*!40000 ALTER TABLE `ExternalMarksMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `ExternalMarksMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `FeeMaster`
--

DROP TABLE IF EXISTS `FeeMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `FeeMaster` (
  `FeeID` int(11) NOT NULL AUTO_INCREMENT,
  `TotalFee` decimal(8,2) NOT NULL,
  `PaidFee` decimal(8,2) NOT NULL,
  `Scholarship` binary(1) NOT NULL COMMENT '0 for Ineligible\n1 for Eligible',
  `ScholarshipName` varchar(45) NOT NULL,
  `ScholarshipAmount` decimal(8,2) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`FeeID`),
  KEY `FK for Fees_idx` (`UserNameID`),
  CONSTRAINT `FK for Fees` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Fee records';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `FeeMaster`
--

LOCK TABLES `FeeMaster` WRITE;
/*!40000 ALTER TABLE `FeeMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `FeeMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `GenderMaster`
--

DROP TABLE IF EXISTS `GenderMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `GenderMaster` (
  `GenderID` int(11) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`GenderID`),
  UNIQUE KEY `Gender_UNIQUE` (`Gender`),
  KEY `FK for Gender_idx` (`UsernameID`),
  CONSTRAINT `FK for Gender` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Gender Information Table';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `GenderMaster`
--

LOCK TABLES `GenderMaster` WRITE;
/*!40000 ALTER TABLE `GenderMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `GenderMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `HSCMaster`
--

DROP TABLE IF EXISTS `HSCMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `HSCMaster` (
  `HSCID` int(11) NOT NULL AUTO_INCREMENT,
  `HSCMax` int(11) NOT NULL,
  `HSCObtained` decimal(10,0) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`HSCID`),
  KEY `FK for HSC_idx` (`UsernameID`),
  CONSTRAINT `FK for HSC` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Table for 12 Standard Marks';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `HSCMaster`
--

LOCK TABLES `HSCMaster` WRITE;
/*!40000 ALTER TABLE `HSCMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `HSCMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `InstitutionMaster`
--

DROP TABLE IF EXISTS `InstitutionMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `InstitutionMaster` (
  `InstitutionID` int(11) NOT NULL AUTO_INCREMENT,
  `InstitutionName` varchar(50) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`InstitutionID`),
  UNIQUE KEY `InstitutionName_UNIQUE` (`InstitutionName`),
  KEY `FK for Institution_idx` (`UserNameID`),
  CONSTRAINT `FK for Institution` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Institute Table to hold institution names';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `InstitutionMaster`
--

LOCK TABLES `InstitutionMaster` WRITE;
/*!40000 ALTER TABLE `InstitutionMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `InstitutionMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `InternalMarksMaster`
--

DROP TABLE IF EXISTS `InternalMarksMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `InternalMarksMaster` (
  `InMarksID` int(11) NOT NULL AUTO_INCREMENT,
  `InternMarksOne` decimal(4,0) NOT NULL,
  `InternMarksTwo` decimal(4,0) NOT NULL,
  `ExamNameID` int(11) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`InMarksID`),
  KEY `FK for Internal Marks_idx` (`UsernameID`),
  KEY `FK for Exam Name_idx` (`ExamNameID`),
  CONSTRAINT `FK for Examination Name` FOREIGN KEY (`ExamNameID`) REFERENCES `exammaster` (`ExamID`) ON DELETE RESTRICT,
  CONSTRAINT `FK for Internal Marks` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Internal Marks Master';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `InternalMarksMaster`
--

LOCK TABLES `InternalMarksMaster` WRITE;
/*!40000 ALTER TABLE `InternalMarksMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `InternalMarksMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `NameMaster`
--

DROP TABLE IF EXISTS `NameMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `NameMaster` (
  `NameID` int(11) NOT NULL AUTO_INCREMENT,
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(45) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`NameID`),
  KEY `FK for Name_idx` (`UsernameID`),
  CONSTRAINT `FK for Name` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Table for the name details';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `NameMaster`
--

LOCK TABLES `NameMaster` WRITE;
/*!40000 ALTER TABLE `NameMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `NameMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `NationalityMaster`
--

DROP TABLE IF EXISTS `NationalityMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `NationalityMaster` (
  `NationalityID` int(11) NOT NULL AUTO_INCREMENT,
  `Nationality` varchar(25) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`NationalityID`),
  UNIQUE KEY `Nationality_UNIQUE` (`Nationality`),
  KEY `FK for Nationality_idx` (`UsernameID`),
  CONSTRAINT `FK for Nationality` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Nationaliy Information which will be linked with the STD';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `NationalityMaster`
--

LOCK TABLES `NationalityMaster` WRITE;
/*!40000 ALTER TABLE `NationalityMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `NationalityMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `NumberMaster`
--

DROP TABLE IF EXISTS `NumberMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `NumberMaster` (
  `MobileID` int(11) NOT NULL,
  `MobileNumber` int(10) NOT NULL,
  `NationalityID` int(11) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`MobileID`),
  UNIQUE KEY `MobileNumber_UNIQUE` (`MobileNumber`),
  KEY `FK for Mobile Number_idx` (`UsernameID`),
  CONSTRAINT `FK for Mobile Number` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Mobile Phone';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `NumberMaster`
--

LOCK TABLES `NumberMaster` WRITE;
/*!40000 ALTER TABLE `NumberMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `NumberMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `OtherCourseMaster`
--

DROP TABLE IF EXISTS `OtherCourseMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `OtherCourseMaster` (
  `OthCorID` int(11) NOT NULL AUTO_INCREMENT,
  `CourseName` varchar(45) NOT NULL,
  `CourseScore` varchar(6) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`OthCorID`),
  UNIQUE KEY `CourseName_UNIQUE` (`CourseName`),
  KEY `FK for OtherCourse_idx` (`UserNameID`),
  CONSTRAINT `FK for OtherCourse` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OtherCourseMaster`
--

LOCK TABLES `OtherCourseMaster` WRITE;
/*!40000 ALTER TABLE `OtherCourseMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `OtherCourseMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ParentNumberMaster`
--

DROP TABLE IF EXISTS `ParentNumberMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ParentNumberMaster` (
  `ParentNumberID` int(11) NOT NULL AUTO_INCREMENT,
  `ParentContact` int(10) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`ParentNumberID`),
  UNIQUE KEY `ParentContact_UNIQUE` (`ParentContact`),
  KEY `FK for ParentNumber_idx` (`UserNameID`),
  CONSTRAINT `FK for ParentNumber` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ParentNumberMaster`
--

LOCK TABLES `ParentNumberMaster` WRITE;
/*!40000 ALTER TABLE `ParentNumberMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `ParentNumberMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ReligionMaster`
--

DROP TABLE IF EXISTS `ReligionMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ReligionMaster` (
  `ReligionID` int(11) NOT NULL AUTO_INCREMENT,
  `Religion` varchar(45) NOT NULL,
  PRIMARY KEY (`ReligionID`),
  UNIQUE KEY `Religion_UNIQUE` (`Religion`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ReligionMaster`
--

LOCK TABLES `ReligionMaster` WRITE;
/*!40000 ALTER TABLE `ReligionMaster` DISABLE KEYS */;
INSERT INTO `ReligionMaster` VALUES (103,'Buddhist'),(104,'Christan'),(101,'Hindu'),(102,'Muslim');
/*!40000 ALTER TABLE `ReligionMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `SportsMaster`
--

DROP TABLE IF EXISTS `SportsMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `SportsMaster` (
  `SportID` int(11) NOT NULL AUTO_INCREMENT,
  `SportName` varchar(20) NOT NULL,
  `SportPlace` varchar(40) NOT NULL,
  `SportsAchivement` varchar(45) DEFAULT NULL,
  `SportsParticipation` binary(1) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`SportID`),
  UNIQUE KEY `SportName_UNIQUE` (`SportName`),
  KEY `FK for Sports_idx` (`UserNameID`),
  CONSTRAINT `FK for Sports` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Sports information';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `SportsMaster`
--

LOCK TABLES `SportsMaster` WRITE;
/*!40000 ALTER TABLE `SportsMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `SportsMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `SSCMaster`
--

DROP TABLE IF EXISTS `SSCMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `SSCMaster` (
  `SSCID` int(11) NOT NULL AUTO_INCREMENT,
  `SSCMax` int(11) NOT NULL,
  `SSCObtained` decimal(10,0) NOT NULL,
  `UsernameID` int(11) NOT NULL,
  PRIMARY KEY (`SSCID`),
  KEY `FK for SSC_idx` (`UsernameID`),
  CONSTRAINT `FK for SSC` FOREIGN KEY (`UsernameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Table to contain marks and percentage of 10 Standard';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `SSCMaster`
--

LOCK TABLES `SSCMaster` WRITE;
/*!40000 ALTER TABLE `SSCMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `SSCMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UserMaster`
--

DROP TABLE IF EXISTS `UserMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `UserMaster` (
  `UsernameID` int(10) NOT NULL,
  `UserName` varchar(18) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserPassword` varchar(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`UsernameID`),
  UNIQUE KEY `UserName_UNIQUE` (`UserName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Username Master Table';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UserMaster`
--

LOCK TABLES `UserMaster` WRITE;
/*!40000 ALTER TABLE `UserMaster` DISABLE KEYS */;
INSERT INTO `UserMaster` VALUES (10001,'Admin','Admin@321');
/*!40000 ALTER TABLE `UserMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `WorkExpMaster`
--

DROP TABLE IF EXISTS `WorkExpMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `WorkExpMaster` (
  `WorkExpID` int(11) NOT NULL AUTO_INCREMENT,
  `WorkPlace` varchar(45) NOT NULL,
  `WorkingYears` int(2) NOT NULL,
  `UserNameID` int(11) NOT NULL,
  PRIMARY KEY (`WorkExpID`),
  UNIQUE KEY `WorkPlace_UNIQUE` (`WorkPlace`),
  KEY `FK for WorkExperience_idx` (`UserNameID`),
  CONSTRAINT `FK for WorkExperience` FOREIGN KEY (`UserNameID`) REFERENCES `usermaster` (`UsernameID`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Work Experience Table';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `WorkExpMaster`
--

LOCK TABLES `WorkExpMaster` WRITE;
/*!40000 ALTER TABLE `WorkExpMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `WorkExpMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'MastersSchema'
--

--
-- Dumping routines for database 'MastersSchema'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-19 14:06:24
