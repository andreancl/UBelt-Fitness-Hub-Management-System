-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: gymdb
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `daily`
--

DROP TABLE IF EXISTS `daily`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `daily` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MemberId` varchar(45) NOT NULL,
  `FullName` char(50) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `TimeLogIn` varchar(45) NOT NULL,
  `TimeLogOut` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `MemberId_idx` (`MemberId`),
  KEY `FullName_idx` (`FullName`),
  CONSTRAINT `FullName` FOREIGN KEY (`FullName`) REFERENCES `members` (`FullName`),
  CONSTRAINT `MemberId` FOREIGN KEY (`MemberId`) REFERENCES `members` (`MemberId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily`
--

LOCK TABLES `daily` WRITE;
/*!40000 ALTER TABLE `daily` DISABLE KEYS */;
/*!40000 ALTER TABLE `daily` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `members` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MemberId` varchar(45) NOT NULL,
  `FullName` char(50) NOT NULL,
  `Sex` char(10) NOT NULL,
  `Birthdate` date NOT NULL,
  `ContactNumber` bigint NOT NULL,
  `Address` varchar(50) NOT NULL,
  `MembershipType` char(10) NOT NULL,
  `DateRegistered` datetime DEFAULT CURRENT_TIMESTAMP,
  `Age` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`MemberId`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `FullName_UNIQUE` (`FullName`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (1,'MEM210320220310','Andrea Rafael','Female','2000-01-06',9987654321,'Caloocan City','Monthly','2022-03-21 15:43:10',NULL),(2,'MEM210320220318','Danilo Beloro','Male','2000-03-09',920321632,'Quezon City','Daily','2022-03-21 15:49:18',NULL),(5,'MEM220320220232','Aileen Petilla','Female','2000-09-02',987654321,'Quezon City','Daily','2022-03-22 14:12:32',NULL),(6,'MEM220320220555','Mayeth Pagalan','Female','2000-07-19',987654323,'Manila','Monthly','2022-03-22 17:21:55',NULL);
/*!40000 ALTER TABLE `members` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `monthly`
--

DROP TABLE IF EXISTS `monthly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `monthly` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MemberId` varchar(45) NOT NULL,
  `FullName` char(50) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `TimeLogIn` varchar(45) NOT NULL,
  `TimeLogOut` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `MembersId_idx` (`MemberId`),
  KEY `FullNames_idx` (`FullName`),
  CONSTRAINT `FullNames` FOREIGN KEY (`FullName`) REFERENCES `members` (`FullName`),
  CONSTRAINT `MembersId` FOREIGN KEY (`MemberId`) REFERENCES `members` (`MemberId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monthly`
--

LOCK TABLES `monthly` WRITE;
/*!40000 ALTER TABLE `monthly` DISABLE KEYS */;
/*!40000 ALTER TABLE `monthly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(45) NOT NULL,
  `FullName` char(45) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `Password_UNIQUE` (`Password`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'123','Andrea Rafael','admin','0000','2022-03-05 17:24:13','2022-03-05 17:24:13');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-22 20:49:27
