CREATE DATABASE  IF NOT EXISTS `AMSDb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `AMSDb`;
-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: AMSDb
-- ------------------------------------------------------
-- Server version	8.0.15

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
-- Table structure for table `DOBTable`
--

DROP TABLE IF EXISTS `DOBTable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `DOBTable` (
  `idDOBTable` int(11) NOT NULL AUTO_INCREMENT,
  `DOB` date NOT NULL,
  `UserNameID` int(11) NOT NULL COMMENT 'To Link the date of birth with the username and indirectly with the user.',
  PRIMARY KEY (`idDOBTable`),
  KEY `FK to DOB_idx` (`UserNameID`),
  CONSTRAINT `FK to DOB` FOREIGN KEY (`UserNameID`) REFERENCES `unandpw` (`idUNandPW`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=201900401 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='To Store Date of Birth of users.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DOBTable`
--

LOCK TABLES `DOBTable` WRITE;
/*!40000 ALTER TABLE `DOBTable` DISABLE KEYS */;
/*!40000 ALTER TABLE `DOBTable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ForgePass`
--

DROP TABLE IF EXISTS `ForgePass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ForgePass` (
  `idForgePass` int(11) NOT NULL AUTO_INCREMENT,
  `MobileNumber` char(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `AadhaarNumber` char(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `EmailAddress` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`idForgePass`),
  UNIQUE KEY `MobileNumber_UNIQUE` (`MobileNumber`),
  UNIQUE KEY `AadhaarNumber_UNIQUE` (`AadhaarNumber`),
  UNIQUE KEY `EmailAddress_UNIQUE` (`EmailAddress`)
) ENGINE=InnoDB AUTO_INCREMENT=201900201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Table for validating details before updating the table in the UNandPW';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ForgePass`
--

LOCK TABLES `ForgePass` WRITE;
/*!40000 ALTER TABLE `ForgePass` DISABLE KEYS */;
/*!40000 ALTER TABLE `ForgePass` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `MobileMaster`
--

DROP TABLE IF EXISTS `MobileMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `MobileMaster` (
  `idMobileMaster` int(11) NOT NULL AUTO_INCREMENT,
  `MobileNumber` char(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UsernameID` int(11) NOT NULL COMMENT 'To Link the Number with the Username',
  PRIMARY KEY (`idMobileMaster`),
  UNIQUE KEY `MobileNumber_UNIQUE` (`MobileNumber`),
  KEY `FK for MobileNumber_idx` (`UsernameID`),
  CONSTRAINT `FK for MobileNumber` FOREIGN KEY (`UsernameID`) REFERENCES `unandpw` (`idUNandPW`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=201900501 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `MobileMaster`
--

LOCK TABLES `MobileMaster` WRITE;
/*!40000 ALTER TABLE `MobileMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `MobileMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `NameMaster`
--

DROP TABLE IF EXISTS `NameMaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `NameMaster` (
  `idNameMaster` int(11) NOT NULL AUTO_INCREMENT,
  `LastName` varchar(30) NOT NULL,
  `MiddleName` varchar(30) NOT NULL,
  `FirstName` varchar(30) NOT NULL,
  `UserNameID` int(11) NOT NULL COMMENT 'To Link the Username with the Name Table',
  PRIMARY KEY (`idNameMaster`),
  KEY `FK to NameMaster_idx` (`UserNameID`),
  CONSTRAINT `FK to NameMaster` FOREIGN KEY (`UserNameID`) REFERENCES `unandpw` (`idUNandPW`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=201900301 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `NameMaster`
--

LOCK TABLES `NameMaster` WRITE;
/*!40000 ALTER TABLE `NameMaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `NameMaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UNandPW`
--

DROP TABLE IF EXISTS `UNandPW`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `UNandPW` (
  `idUNandPW` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Password` varchar(18) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserType` varchar(10) NOT NULL COMMENT 'To enter and store the whether the user is student or teacher',
  PRIMARY KEY (`idUNandPW`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=201900101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci PACK_KEYS=1 COMMENT='Username and Password Table for Login Check';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UNandPW`
--

LOCK TABLES `UNandPW` WRITE;
/*!40000 ALTER TABLE `UNandPW` DISABLE KEYS */;
/*!40000 ALTER TABLE `UNandPW` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'AMSDb'
--

--
-- Dumping routines for database 'AMSDb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-25  0:32:17
