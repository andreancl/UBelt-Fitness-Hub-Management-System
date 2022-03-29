-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: gymmdb
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
  `FullName` char(45) NOT NULL,
  `MembershipType` char(10) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `TimeLogIn` varchar(45) NOT NULL,
  `TimeLogOut` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `MemberId_idx` (`MemberId`),
  KEY `FullName_idx` (`FullName`),
  KEY `MembershipType_idx` (`MembershipType`),
  CONSTRAINT `FullName` FOREIGN KEY (`FullName`) REFERENCES `members` (`FullName`),
  CONSTRAINT `MemberId` FOREIGN KEY (`MemberId`) REFERENCES `members` (`MemberID`),
  CONSTRAINT `MembershipType` FOREIGN KEY (`MembershipType`) REFERENCES `members` (`MembershipType`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily`
--

LOCK TABLES `daily` WRITE;
/*!40000 ALTER TABLE `daily` DISABLE KEYS */;
INSERT INTO `daily` VALUES (1,'MEM290320220519','Mayeth Pagalan','Daily','March 29, 2022','5:39:13 PM','5:40:24 PM');
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
  `MemberID` varchar(45) NOT NULL,
  `FullName` char(45) NOT NULL,
  `Sex` char(10) NOT NULL,
  `Birthdate` date NOT NULL,
  `ContactNumber` bigint NOT NULL,
  `Address` varchar(45) NOT NULL,
  `MembershipType` char(10) NOT NULL,
  `DateRegistered` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`MemberID`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `FullName_UNIQUE` (`FullName`),
  KEY `MembershipType_UNIQUE` (`MembershipType`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (1,'MEM290320220519','Mayeth Pagalan','Female','2002-03-29',987654321,'Mandaluyong','Daily','March 29, 2022',NULL),(2,'MEM290320220545','Danilo Beloro','Male','1998-03-23',1234560212,'Caloocan City','Monthly','March 29, 2022',NULL);
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
  `FullName` char(45) NOT NULL,
  `MembershipType` char(10) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `TimeLogIn` varchar(45) NOT NULL,
  `TimeLogOut` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `MembersId_idx` (`MemberId`),
  KEY `FullNames_idx` (`FullName`),
  KEY `MembershipTypes_idx` (`MembershipType`),
  CONSTRAINT `FullNames` FOREIGN KEY (`FullName`) REFERENCES `members` (`FullName`),
  CONSTRAINT `MembershipTypes` FOREIGN KEY (`MembershipType`) REFERENCES `members` (`MembershipType`),
  CONSTRAINT `MembersId` FOREIGN KEY (`MemberId`) REFERENCES `members` (`MemberID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monthly`
--

LOCK TABLES `monthly` WRITE;
/*!40000 ALTER TABLE `monthly` DISABLE KEYS */;
INSERT INTO `monthly` VALUES (2,'MEM290320220545','Danilo Beloro','Monthly','March 29, 2022','5:42:58 PM','6:26:41 PM');
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
  `UserId` varchar(45) DEFAULT NULL,
  `FullName` char(45) DEFAULT NULL,
  `Username` varchar(12) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `SecretQuestion` varchar(45) DEFAULT NULL,
  `SecretAnswer` varchar(45) DEFAULT NULL,
  `UserTypeId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserId_UNIQUE` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (2,'USER290320220640','Andrea Mae Nicole Rafael','admin','1111','What things that makes you mad?','you',1),(3,'USER300320221255','Mayeth Pagalan','user','1234','What is your favorite band?','nts',1);
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

-- Dump completed on 2022-03-30  0:44:09
