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
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily`
--

LOCK TABLES `daily` WRITE;
/*!40000 ALTER TABLE `daily` DISABLE KEYS */;
INSERT INTO `daily` VALUES (1,'MEM290320220519','Mayeth Pagalan','Daily','March 29, 2022','5:39:13 PM','5:40:24 PM'),(4,'MEM020520221244','Aileen Petilla','Daily','May 02, 2022','12:58:26 AM','3:55:36 PM'),(5,'MEM020520220317','Aileen Jay','Daily','May 02, 2022','3:54:54 PM',NULL),(6,'MEM020520221244','Aileen Joy','Daily','May 02, 2022','3:55:29 PM','3:55:36 PM');
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
  `DateRegistered` date DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`MemberID`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `FullName_UNIQUE` (`FullName`),
  KEY `MembershipType_UNIQUE` (`MembershipType`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (15,'MEM020520220222','Dann Beloro','Female','2000-11-06',231312,'sad','Daily','2022-02-02',NULL),(19,'MEM020520220317','Aileen Jay','Female','2000-05-02',987654321,'Quezon City','Daily','2022-05-02',NULL),(16,'MEM020520220320','Andrea Rafael','Female','2000-05-02',9421234567,'Manila','Monthly','2022-03-30',NULL),(12,'MEM020520221244','Aileen Joy','Female','2000-05-02',987654321,'Quezon City','Daily','2022-05-02',NULL),(20,'MEM030520220350','Ninna Napao','Female','2004-12-14',2312312,'asd','Daily','2022-05-03',NULL),(21,'MEM030520220614','Carla Gob','Female','1994-04-11',987654321,'Rizal','Monthly','2022-05-03',NULL);
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
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monthly`
--

LOCK TABLES `monthly` WRITE;
/*!40000 ALTER TABLE `monthly` DISABLE KEYS */;
INSERT INTO `monthly` VALUES (3,'MEM290320220545','Danilo Beloro','Monthly','March 30, 2022','11:16:04 AM','12:58:12 AM');
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (2,'USER290320220640','Andrea Mae Nicole Rafael','admin','admin','What is your favorite color?','yellow',1),(15,'USER310320221136','Mayeth Pagalan','user','1234','In what city were you born?','idk',2);
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

-- Dump completed on 2022-05-03 10:35:25
