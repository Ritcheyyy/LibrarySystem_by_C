-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: library_db
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `reader_info`
--

DROP TABLE IF EXISTS `reader_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reader_info` (
  `RID` int NOT NULL AUTO_INCREMENT,
  `RCID` int DEFAULT NULL,
  `RPwd` varchar(30) DEFAULT NULL,
  `RName` varchar(15) DEFAULT NULL,
  `Sex` int DEFAULT NULL,
  `Phone` varchar(30) DEFAULT NULL,
  `RegisterDate` date DEFAULT NULL,
  `ValidDate` date DEFAULT NULL,
  `CurrentBookNum` int DEFAULT NULL,
  `TotalBookNum` int DEFAULT NULL,
  `Lost` int DEFAULT NULL,
  `ViolationNum` int DEFAULT NULL,
  `Remark` text,
  PRIMARY KEY (`RID`),
  KEY `FK_Reference_1` (`RCID`),
  CONSTRAINT `FK_Reference_1` FOREIGN KEY (`RCID`) REFERENCES `readerclass_info` (`RCID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=1235 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reader_info`
--

LOCK TABLES `reader_info` WRITE;
/*!40000 ALTER TABLE `reader_info` DISABLE KEYS */;
INSERT INTO `reader_info` VALUES (1,1,'1','陈东',1,'111','2024-01-25','2028-01-25',9,18,0,2,NULL),(2,1,'2','叶楚琪',2,'111','2024-01-25','2028-01-25',1,1,0,0,NULL),(3,2,'3','马东',1,'111','2024-01-25','2028-01-25',0,0,0,0,NULL),(4,2,'4','陈舒婷',2,'111','2024-01-25','2028-01-25',0,0,0,0,NULL),(5,2,'5','郭浩',1,'111','2024-01-25','2028-01-25',0,0,0,0,NULL),(11,1,'11','陈浩',1,'111','2024-01-25','2028-01-25',0,0,0,0,NULL),(23,1,'23','李东',1,'23','2024-01-26','2028-01-26',0,0,0,0,NULL),(234,2,'234','马东',1,'2345','2024-01-26','2028-01-26',0,1,0,0,NULL);
/*!40000 ALTER TABLE `reader_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-27  1:32:40
