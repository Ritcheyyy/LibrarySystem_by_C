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
-- Table structure for table `book_info`
--

DROP TABLE IF EXISTS `book_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_info` (
  `ISBN` int NOT NULL,
  `BName` varchar(15) DEFAULT NULL,
  `BAuthor` varchar(15) DEFAULT NULL,
  `PID` int DEFAULT NULL,
  `PublishNum` int DEFAULT NULL,
  `PublishDate` date DEFAULT NULL,
  `Price` float DEFAULT NULL,
  `BriefIntroduction` text,
  `CurrNum` int DEFAULT NULL,
  `TotalNum` int DEFAULT NULL,
  PRIMARY KEY (`ISBN`),
  KEY `FK_Reference_2` (`PID`),
  CONSTRAINT `FK_Reference_2` FOREIGN KEY (`PID`) REFERENCES `publisher_info` (`PID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_info`
--

LOCK TABLES `book_info` WRITE;
/*!40000 ALTER TABLE `book_info` DISABLE KEYS */;
INSERT INTO `book_info` VALUES (1,'1','1',1,1,'2020-01-01',11,'1',2,2),(1111,'图书十','小东',2,1,'2010-01-01',56.5,'描述了',2,3),(2161,'图书七','大潘',2,2,'2003-11-08',21,NULL,1,2),(2222,'高数','李培',3,3,'2010-01-01',99.5,'讲述了高等数学的理论知识',2,3),(2616,'图书八','大明',2,2,'2004-07-11',61.5,NULL,2,3),(3333,'3333','3333',3,3,'2020-01-01',33.3,'3',3,3),(6488,'图书六','大力',1,3,'2001-12-15',17,NULL,1,2),(8161,'图书三','小潘',2,3,'2013-01-28',28.3,NULL,2,3),(8716,'图书四','小明',2,5,'2014-09-01',98.5,'好',2,3),(9187,'图书五','大王',1,3,'2000-11-01',36.3,NULL,1,2),(9787,'图书一','小王',1,1,'2010-01-01',31.5,'好',2,3),(9788,'图书二','小李',1,1,'2011-02-17',15.8,'',2,4),(9999,'图书九','小刘',1,2,'2020-01-01',23.5,'讲述了图书九以及',0,1);
/*!40000 ALTER TABLE `book_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-27  1:32:41
