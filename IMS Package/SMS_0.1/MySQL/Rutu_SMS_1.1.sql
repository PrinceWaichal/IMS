-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: sms
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
-- Table structure for table `adminusermaster`
--

DROP TABLE IF EXISTS `adminusermaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `adminusermaster` (
  `adminid` int(11) NOT NULL AUTO_INCREMENT,
  `adminname` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `adminpass` mediumtext NOT NULL,
  PRIMARY KEY (`adminid`),
  UNIQUE KEY `adminname_UNIQUE` (`adminname`)
) ENGINE=InnoDB AUTO_INCREMENT=201903 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adminusermaster`
--

LOCK TABLES `adminusermaster` WRITE;
/*!40000 ALTER TABLE `adminusermaster` DISABLE KEYS */;
INSERT INTO `adminusermaster` VALUES (201901,'Admin','Admin@123'),(201902,'Admin2','Admin@321');
/*!40000 ALTER TABLE `adminusermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_addharmaster`
--

DROP TABLE IF EXISTS `s_addharmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_addharmaster` (
  `ids_addharmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_addharNo` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_addharmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registaadhar_fk` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_addharmaster`
--

LOCK TABLES `s_addharmaster` WRITE;
/*!40000 ALTER TABLE `s_addharmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_addharmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_addressmaster`
--

DROP TABLE IF EXISTS `s_addressmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_addressmaster` (
  `ids_addressmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_adress` varchar(70) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_addressmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`) /*!80000 INVISIBLE */,
  CONSTRAINT `ids_registrationcreationAdd_fk` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_addressmaster`
--

LOCK TABLES `s_addressmaster` WRITE;
/*!40000 ALTER TABLE `s_addressmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_addressmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_birthdatemaster`
--

DROP TABLE IF EXISTS `s_birthdatemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_birthdatemaster` (
  `ids_birthdate` int(11) NOT NULL AUTO_INCREMENT,
  `s_birthdate` date NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_birthdate`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationDoB` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_birthdatemaster`
--

LOCK TABLES `s_birthdatemaster` WRITE;
/*!40000 ALTER TABLE `s_birthdatemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_birthdatemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_categorymaster`
--

DROP TABLE IF EXISTS `s_categorymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_categorymaster` (
  `ids_categorymaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_category` varchar(10) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_categorymaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationcategory` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_categorymaster`
--

LOCK TABLES `s_categorymaster` WRITE;
/*!40000 ALTER TABLE `s_categorymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_categorymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_citymaster`
--

DROP TABLE IF EXISTS `s_citymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_citymaster` (
  `ids_citymaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_city` varchar(10) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_citymaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationcity` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`)
) ENGINE=InnoDB AUTO_INCREMENT=15001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_citymaster`
--

LOCK TABLES `s_citymaster` WRITE;
/*!40000 ALTER TABLE `s_citymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_citymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_emailmaster`
--

DROP TABLE IF EXISTS `s_emailmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_emailmaster` (
  `ids_email` int(11) NOT NULL AUTO_INCREMENT,
  `s_emailadress` varchar(45) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_email`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationemail` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_emailmaster`
--

LOCK TABLES `s_emailmaster` WRITE;
/*!40000 ALTER TABLE `s_emailmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_emailmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_gendermaster`
--

DROP TABLE IF EXISTS `s_gendermaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_gendermaster` (
  `ids_gendermaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_gender` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_gendermaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationgender` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_gendermaster`
--

LOCK TABLES `s_gendermaster` WRITE;
/*!40000 ALTER TABLE `s_gendermaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_gendermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_gradumaster`
--

DROP TABLE IF EXISTS `s_gradumaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_gradumaster` (
  `ids_gradumaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_graduUnivercity` varchar(45) NOT NULL,
  `s_graduYearOfcompletion` date NOT NULL,
  `s_graducollegename` varchar(45) NOT NULL,
  `s_gradumaxmark` int(11) NOT NULL,
  `s_graduobtainedmark` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_gradumaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationGradu` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_gradumaster`
--

LOCK TABLES `s_gradumaster` WRITE;
/*!40000 ALTER TABLE `s_gradumaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_gradumaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_guardiansmaster`
--

DROP TABLE IF EXISTS `s_guardiansmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_guardiansmaster` (
  `ids_guardiansmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_guardianLastname` varchar(20) NOT NULL,
  `s_guardianfirstname` varchar(20) NOT NULL,
  `s_guardianmiddlename` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_guardiansmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationGuardian` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_guardiansmaster`
--

LOCK TABLES `s_guardiansmaster` WRITE;
/*!40000 ALTER TABLE `s_guardiansmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_guardiansmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_hscmaster`
--

DROP TABLE IF EXISTS `s_hscmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_hscmaster` (
  `ids_hscmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_hscUnivrcity` varchar(45) NOT NULL,
  `s_hscYearOfcompletion` date NOT NULL,
  `s_hscschoolname` varchar(45) NOT NULL,
  `s_hscmaximummark` int(11) NOT NULL,
  `s_hscobtainedmark` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_hscmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationHsc` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_hscmaster`
--

LOCK TABLES `s_hscmaster` WRITE;
/*!40000 ALTER TABLE `s_hscmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_hscmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_landmark`
--

DROP TABLE IF EXISTS `s_landmark`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_landmark` (
  `ids_landmark` int(11) NOT NULL AUTO_INCREMENT,
  `s_landmark` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_landmark`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationlandmark` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_landmark`
--

LOCK TABLES `s_landmark` WRITE;
/*!40000 ALTER TABLE `s_landmark` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_landmark` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_maritalstatusmaster`
--

DROP TABLE IF EXISTS `s_maritalstatusmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_maritalstatusmaster` (
  `ids_maritalstatusmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_maritalstatus` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_maritalstatusmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationMarital` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_maritalstatusmaster`
--

LOCK TABLES `s_maritalstatusmaster` WRITE;
/*!40000 ALTER TABLE `s_maritalstatusmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_maritalstatusmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_mobilemaster`
--

DROP TABLE IF EXISTS `s_mobilemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_mobilemaster` (
  `ids_mobilemaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_mobile` int(10) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_mobilemaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationmobile` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_mobilemaster`
--

LOCK TABLES `s_mobilemaster` WRITE;
/*!40000 ALTER TABLE `s_mobilemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_mobilemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_mothernamemaster`
--

DROP TABLE IF EXISTS `s_mothernamemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_mothernamemaster` (
  `ids_mothernamemaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_motherLastname` varchar(20) NOT NULL,
  `s_motherfirstname` varchar(20) NOT NULL,
  `s_mothermiddlename` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_mothernamemaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationmaster` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_mothernamemaster`
--

LOCK TABLES `s_mothernamemaster` WRITE;
/*!40000 ALTER TABLE `s_mothernamemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_mothernamemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_namemaster`
--

DROP TABLE IF EXISTS `s_namemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_namemaster` (
  `ids_name` int(11) NOT NULL AUTO_INCREMENT,
  `s_lastname` varchar(20) NOT NULL,
  `s_firstname` varchar(20) NOT NULL,
  `s_middlename` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_name`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationmaster_fk` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_namemaster`
--

LOCK TABLES `s_namemaster` WRITE;
/*!40000 ALTER TABLE `s_namemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_namemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_nationality`
--

DROP TABLE IF EXISTS `s_nationality`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_nationality` (
  `ids_nationality` int(11) NOT NULL AUTO_INCREMENT,
  `s_nationality` varchar(10) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_nationality`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationNationality` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_nationality`
--

LOCK TABLES `s_nationality` WRITE;
/*!40000 ALTER TABLE `s_nationality` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_nationality` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_parentscontactmaster`
--

DROP TABLE IF EXISTS `s_parentscontactmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_parentscontactmaster` (
  `ids_parentscontactmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_parentscontactNo` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_parentscontactmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationParentContact` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_parentscontactmaster`
--

LOCK TABLES `s_parentscontactmaster` WRITE;
/*!40000 ALTER TABLE `s_parentscontactmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_parentscontactmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_physicaldisabilitymaster`
--

DROP TABLE IF EXISTS `s_physicaldisabilitymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_physicaldisabilitymaster` (
  `ids_physicaldisabilitymaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_physicaldisabilitY` tinyint(4) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_physicaldisabilitymaster`),
  KEY `ids_registrationcreationphysicaldisablity` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationphysicalDis` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_physicaldisabilitymaster`
--

LOCK TABLES `s_physicaldisabilitymaster` WRITE;
/*!40000 ALTER TABLE `s_physicaldisabilitymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_physicaldisabilitymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_pincodemaster`
--

DROP TABLE IF EXISTS `s_pincodemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_pincodemaster` (
  `ids_pincodemaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_pincode` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_pincodemaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationPincode` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_pincodemaster`
--

LOCK TABLES `s_pincodemaster` WRITE;
/*!40000 ALTER TABLE `s_pincodemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_pincodemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_registrationcreationmaster`
--

DROP TABLE IF EXISTS `s_registrationcreationmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_registrationcreationmaster` (
  `ids_registrationcreationmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_registrationcreationUserName` varchar(24) NOT NULL,
  `s_registrationcreationPassword` varchar(18) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ids_registrationcreationmaster`),
  UNIQUE KEY `s_registrationcreationUserName_UNIQUE` (`s_registrationcreationUserName`)
) ENGINE=InnoDB AUTO_INCREMENT=39001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_registrationcreationmaster`
--

LOCK TABLES `s_registrationcreationmaster` WRITE;
/*!40000 ALTER TABLE `s_registrationcreationmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_registrationcreationmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_religion`
--

DROP TABLE IF EXISTS `s_religion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_religion` (
  `ids_religion` int(11) NOT NULL AUTO_INCREMENT,
  `s_religion` varchar(10) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_religion`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationreliigon` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_religion`
--

LOCK TABLES `s_religion` WRITE;
/*!40000 ALTER TABLE `s_religion` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_religion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_sscmaster`
--

DROP TABLE IF EXISTS `s_sscmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_sscmaster` (
  `ids_sscmaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_sscUnivercity` varchar(45) NOT NULL,
  `s_sscYarOfcompletion` date NOT NULL,
  `s_schoolname` varchar(45) NOT NULL,
  `s_sscmaxmark` int(11) NOT NULL,
  `s_sscobtainedmark` int(11) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_sscmaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationsscr` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_sscmaster`
--

LOCK TABLES `s_sscmaster` WRITE;
/*!40000 ALTER TABLE `s_sscmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_sscmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `s_statemaster`
--

DROP TABLE IF EXISTS `s_statemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `s_statemaster` (
  `ids_statemaster` int(11) NOT NULL AUTO_INCREMENT,
  `s_state` varchar(20) NOT NULL,
  `ids_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`ids_statemaster`),
  KEY `ids_registrationcreationmaster` (`ids_registrationcreationmaster`),
  CONSTRAINT `ids_registrationcreationstate` FOREIGN KEY (`ids_registrationcreationmaster`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `s_statemaster`
--

LOCK TABLES `s_statemaster` WRITE;
/*!40000 ALTER TABLE `s_statemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `s_statemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentusermaster`
--

DROP TABLE IF EXISTS `studentusermaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `studentusermaster` (
  `studentid` int(11) NOT NULL AUTO_INCREMENT,
  `studname` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `studpass` mediumtext NOT NULL,
  `ids_registrationcreation` int(11) NOT NULL,
  PRIMARY KEY (`studentid`),
  UNIQUE KEY `studname_UNIQUE` (`studname`),
  KEY `ids_registraioncreationuser_idx` (`ids_registrationcreation`),
  CONSTRAINT `ids_registraioncreationuser` FOREIGN KEY (`ids_registrationcreation`) REFERENCES `s_registrationcreationmaster` (`ids_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=201900201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentusermaster`
--

LOCK TABLES `studentusermaster` WRITE;
/*!40000 ALTER TABLE `studentusermaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `studentusermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_addharmaster`
--

DROP TABLE IF EXISTS `t_addharmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_addharmaster` (
  `idt_addharmaster` int(11) NOT NULL,
  `t_addharNo` int(12) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_addharmaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationaadharr` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_addharmaster`
--

LOCK TABLES `t_addharmaster` WRITE;
/*!40000 ALTER TABLE `t_addharmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_addharmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_adressmaster`
--

DROP TABLE IF EXISTS `t_adressmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_adressmaster` (
  `idt_adressmaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_address` varchar(70) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_adressmaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationmaster` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_adressmaster`
--

LOCK TABLES `t_adressmaster` WRITE;
/*!40000 ALTER TABLE `t_adressmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_adressmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_birthdatemaster`
--

DROP TABLE IF EXISTS `t_birthdatemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_birthdatemaster` (
  `idt_birthdatemaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_birthdate` date NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_birthdatemaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationDOB` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_birthdatemaster`
--

LOCK TABLES `t_birthdatemaster` WRITE;
/*!40000 ALTER TABLE `t_birthdatemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_birthdatemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_categorymaster`
--

DROP TABLE IF EXISTS `t_categorymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_categorymaster` (
  `idt_categorymaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_category` varchar(10) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_categorymaster`),
  KEY `idt_registraitoncreatioinmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationcategory` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=45001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_categorymaster`
--

LOCK TABLES `t_categorymaster` WRITE;
/*!40000 ALTER TABLE `t_categorymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_categorymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_citymaster`
--

DROP TABLE IF EXISTS `t_citymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_citymaster` (
  `idt_citymaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_city` varchar(10) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_citymaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationcity` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_citymaster`
--

LOCK TABLES `t_citymaster` WRITE;
/*!40000 ALTER TABLE `t_citymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_citymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_emailidmaster`
--

DROP TABLE IF EXISTS `t_emailidmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_emailidmaster` (
  `idt_email` int(11) NOT NULL AUTO_INCREMENT,
  `t_emailaddress` varchar(45) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_email`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationemail` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_emailidmaster`
--

LOCK TABLES `t_emailidmaster` WRITE;
/*!40000 ALTER TABLE `t_emailidmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_emailidmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_gendermaster`
--

DROP TABLE IF EXISTS `t_gendermaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_gendermaster` (
  `idt_gendermaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_gender` varchar(20) NOT NULL,
  `idt_registrationcreationmaster` int(11) DEFAULT NULL,
  PRIMARY KEY (`idt_gendermaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationgender` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_gendermaster`
--

LOCK TABLES `t_gendermaster` WRITE;
/*!40000 ALTER TABLE `t_gendermaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_gendermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_guardianmaster`
--

DROP TABLE IF EXISTS `t_guardianmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_guardianmaster` (
  `idt_guardianmaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_guardianLastname` varchar(20) NOT NULL,
  `t_guardianfirstname` varchar(20) NOT NULL,
  `t_guardianmiddlename` varchar(20) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_guardianmaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationgurardian` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_guardianmaster`
--

LOCK TABLES `t_guardianmaster` WRITE;
/*!40000 ALTER TABLE `t_guardianmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_guardianmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_landmarkmaster`
--

DROP TABLE IF EXISTS `t_landmarkmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_landmarkmaster` (
  `idt_landmark` int(11) NOT NULL AUTO_INCREMENT,
  `t_landmark` varchar(20) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_landmark`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationlandmark` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_landmarkmaster`
--

LOCK TABLES `t_landmarkmaster` WRITE;
/*!40000 ALTER TABLE `t_landmarkmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_landmarkmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_mobilemaster`
--

DROP TABLE IF EXISTS `t_mobilemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_mobilemaster` (
  `idt_mobilemaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_mobile` int(10) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_mobilemaster`),
  KEY `idt_registrationcreationmobile` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationmobile` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_mobilemaster`
--

LOCK TABLES `t_mobilemaster` WRITE;
/*!40000 ALTER TABLE `t_mobilemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_mobilemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_namemaster`
--

DROP TABLE IF EXISTS `t_namemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_namemaster` (
  `idt_name` int(11) NOT NULL AUTO_INCREMENT,
  `t_lastname` varchar(20) NOT NULL,
  `t_firstname` varchar(20) NOT NULL,
  `t_middlename` varchar(20) DEFAULT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_name`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationname` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_namemaster`
--

LOCK TABLES `t_namemaster` WRITE;
/*!40000 ALTER TABLE `t_namemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_namemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_nationalitymaster`
--

DROP TABLE IF EXISTS `t_nationalitymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_nationalitymaster` (
  `idt_nationalitymaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_nationality` varchar(10) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_nationalitymaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`) /*!80000 INVISIBLE */,
  CONSTRAINT `idt_registrationcreationnationality` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_nationalitymaster`
--

LOCK TABLES `t_nationalitymaster` WRITE;
/*!40000 ALTER TABLE `t_nationalitymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_nationalitymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_parentscontactmaster`
--

DROP TABLE IF EXISTS `t_parentscontactmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_parentscontactmaster` (
  `idt_parentscontactmaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_parentscontactNo` int(11) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_parentscontactmaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationparentscontact` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_parentscontactmaster`
--

LOCK TABLES `t_parentscontactmaster` WRITE;
/*!40000 ALTER TABLE `t_parentscontactmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_parentscontactmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_physicaldisabilitymaster`
--

DROP TABLE IF EXISTS `t_physicaldisabilitymaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_physicaldisabilitymaster` (
  `idT_physicaldisabilitymaster` int(11) NOT NULL AUTO_INCREMENT,
  `T_physicaldisability` tinyint(4) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idT_physicaldisabilitymaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationphydisability` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_physicaldisabilitymaster`
--

LOCK TABLES `t_physicaldisabilitymaster` WRITE;
/*!40000 ALTER TABLE `t_physicaldisabilitymaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_physicaldisabilitymaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_pincodemaster`
--

DROP TABLE IF EXISTS `t_pincodemaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_pincodemaster` (
  `idt_pincodemaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_pincode` int(8) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_pincodemaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationpintcode` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_pincodemaster`
--

LOCK TABLES `t_pincodemaster` WRITE;
/*!40000 ALTER TABLE `t_pincodemaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_pincodemaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_registrationcreationmaster`
--

DROP TABLE IF EXISTS `t_registrationcreationmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_registrationcreationmaster` (
  `idt_registrationcreationmaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_registrationcreationusername` varchar(24) NOT NULL,
  `t_registrationcreationpassword` varchar(18) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`idt_registrationcreationmaster`),
  UNIQUE KEY `t_registrationcreationUserName_UNIQUE` (`t_registrationcreationusername`) /*!80000 INVISIBLE */
) ENGINE=InnoDB AUTO_INCREMENT=40001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_registrationcreationmaster`
--

LOCK TABLES `t_registrationcreationmaster` WRITE;
/*!40000 ALTER TABLE `t_registrationcreationmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_registrationcreationmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_religionmaster`
--

DROP TABLE IF EXISTS `t_religionmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_religionmaster` (
  `idt_religionmaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_religion` varchar(10) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_religionmaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationreligion` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_religionmaster`
--

LOCK TABLES `t_religionmaster` WRITE;
/*!40000 ALTER TABLE `t_religionmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_religionmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_stateaster`
--

DROP TABLE IF EXISTS `t_stateaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `t_stateaster` (
  `idt_stateaster` int(11) NOT NULL AUTO_INCREMENT,
  `t_state` varchar(20) NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`idt_stateaster`),
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`),
  CONSTRAINT `idt_registrationcreationstate` FOREIGN KEY (`idt_registrationcreationmaster`) REFERENCES `t_registrationcreationmaster` (`idt_registrationcreationmaster`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_stateaster`
--

LOCK TABLES `t_stateaster` WRITE;
/*!40000 ALTER TABLE `t_stateaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_stateaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacherusermaster`
--

DROP TABLE IF EXISTS `teacherusermaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `teacherusermaster` (
  `teacherid` int(11) NOT NULL AUTO_INCREMENT,
  `teachname` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `teachpassword` mediumtext NOT NULL,
  `idt_registrationcreationmaster` int(11) NOT NULL,
  PRIMARY KEY (`teacherid`),
  UNIQUE KEY `teachname_UNIQUE` (`teachname`) /*!80000 INVISIBLE */,
  KEY `idt_registrationcreationmaster` (`idt_registrationcreationmaster`)
) ENGINE=InnoDB AUTO_INCREMENT=201900102 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacherusermaster`
--

LOCK TABLES `teacherusermaster` WRITE;
/*!40000 ALTER TABLE `teacherusermaster` DISABLE KEYS */;
INSERT INTO `teacherusermaster` VALUES (201900101,'test','test1',0);
/*!40000 ALTER TABLE `teacherusermaster` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-23 16:35:10
