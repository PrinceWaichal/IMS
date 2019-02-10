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
-- Table structure for table `ActivitiesMaster`
--

DROP TABLE IF EXISTS `ActivitiesMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ActivitiesMaster` (
  `ActivityID` int(11) NOT NULL AUTO_INCREMENT,
  `ActivityName` varchar(50) NOT NULL,
  `ActivityDescription` longtext,
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
  PRIMARY KEY (`ExamID`),
  UNIQUE KEY `ExamName_UNIQUE` (`ExamName`),
  UNIQUE KEY `ExamDate_UNIQUE` (`ExamDate`),
  KEY `FK for Exam_idx` (`UsernameID`),
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

-- Dump completed on 2019-02-10 19:31:56
