CREATE DATABASE  IF NOT EXISTS `sms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `sms`;
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
-- Table structure for table `studentdetails`
--

DROP TABLE IF EXISTS `studentdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `studentdetails` (
  `studentdet_id` int(11) NOT NULL AUTO_INCREMENT,
  `studlastname` varchar(45) NOT NULL,
  `studfirstname` varchar(45) NOT NULL,
  `studmidname` varchar(45) NOT NULL,
  `studdob` date NOT NULL,
  `studgender` varchar(20) NOT NULL,
  `studaddress` varchar(50) NOT NULL,
  `studcity` varchar(45) NOT NULL,
  `studpin` int(6) NOT NULL,
  `studstate` varchar(45) NOT NULL,
  `studmobile` int(10) NOT NULL,
  `studemail` varchar(80) NOT NULL,
  `studsscuni` varchar(45) NOT NULL,
  `studsscinsti` varchar(45) NOT NULL,
  `studhscuni` varchar(45) NOT NULL,
  `studhscinsti` varchar(45) NOT NULL,
  `studgraduni` varchar(45) NOT NULL,
  `studgradinsti` varchar(45) NOT NULL,
  `studparentmob` int(10) NOT NULL,
  `studphysichandicap` varchar(10) NOT NULL,
  `studaadharno` int(12) NOT NULL,
  `studcat` varchar(12) NOT NULL,
  `studrelig` varchar(20) NOT NULL,
  `studmarried` binary(2) NOT NULL,
  `studentusernameid` int(11) NOT NULL,
  PRIMARY KEY (`studentdet_id`),
  UNIQUE KEY `studmobile_UNIQUE` (`studmobile`),
  UNIQUE KEY `studemail_UNIQUE` (`studemail`),
  UNIQUE KEY `studaadharno_UNIQUE` (`studaadharno`),
  KEY `FK for Username_idx` (`studentusernameid`),
  CONSTRAINT `FK for Username` FOREIGN KEY (`studentusernameid`) REFERENCES `studentusermaster` (`studentid`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=201900301 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentdetails`
--

LOCK TABLES `studentdetails` WRITE;
/*!40000 ALTER TABLE `studentdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `studentdetails` ENABLE KEYS */;
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
  PRIMARY KEY (`studentid`),
  UNIQUE KEY `studname_UNIQUE` (`studname`)
) ENGINE=InnoDB AUTO_INCREMENT=201900202 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentusermaster`
--

LOCK TABLES `studentusermaster` WRITE;
/*!40000 ALTER TABLE `studentusermaster` DISABLE KEYS */;
INSERT INTO `studentusermaster` VALUES (201900201,'tes','tes@123');
/*!40000 ALTER TABLE `studentusermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachdetails`
--

DROP TABLE IF EXISTS `teachdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `teachdetails` (
  `teachdet_id` int(11) NOT NULL AUTO_INCREMENT,
  `teachlastname` varchar(45) NOT NULL,
  `teachfirstname` varchar(45) NOT NULL,
  `teachmidname` varchar(45) NOT NULL,
  `teachdob` date NOT NULL,
  `teachgender` varchar(20) NOT NULL,
  `teachaddress` varchar(50) NOT NULL,
  `teachcity` varchar(45) NOT NULL,
  `teachpin` int(6) NOT NULL,
  `teachstate` varchar(45) NOT NULL,
  `teachmob` int(10) NOT NULL,
  `teachemail` varchar(80) NOT NULL,
  `teachsscuni` varchar(45) NOT NULL,
  `teachsscinsti` varchar(45) NOT NULL,
  `teachhscuni` varchar(45) NOT NULL,
  `teachhscinsti` varchar(45) NOT NULL,
  `teachgraduni` varchar(45) NOT NULL,
  `teachgradinsti` varchar(45) NOT NULL,
  `teachparentmob` int(10) NOT NULL,
  `teachphysichandicap` varchar(10) NOT NULL,
  `teachaadharno` int(12) NOT NULL,
  `teachcat` varchar(12) NOT NULL,
  `teachrelig` varchar(20) NOT NULL,
  `teachmarried` binary(2) NOT NULL,
  `teachusernameid` int(11) NOT NULL,
  PRIMARY KEY (`teachdet_id`),
  UNIQUE KEY `teachaadharno_UNIQUE` (`teachaadharno`),
  UNIQUE KEY `teachemail_UNIQUE` (`teachemail`),
  UNIQUE KEY `teachmob_UNIQUE` (`teachmob`),
  KEY `FK for TeacherName_idx` (`teachusernameid`),
  CONSTRAINT `FK for TeacherName` FOREIGN KEY (`teachusernameid`) REFERENCES `teacherusermaster` (`teacherid`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=201900401 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachdetails`
--

LOCK TABLES `teachdetails` WRITE;
/*!40000 ALTER TABLE `teachdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `teachdetails` ENABLE KEYS */;
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
  PRIMARY KEY (`teacherid`),
  UNIQUE KEY `teachname_UNIQUE` (`teachname`)
) ENGINE=InnoDB AUTO_INCREMENT=201900102 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacherusermaster`
--

LOCK TABLES `teacherusermaster` WRITE;
/*!40000 ALTER TABLE `teacherusermaster` DISABLE KEYS */;
INSERT INTO `teacherusermaster` VALUES (201900101,'test','test1');
/*!40000 ALTER TABLE `teacherusermaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sms'
--

--
-- Dumping routines for database 'sms'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-24 19:39:09
