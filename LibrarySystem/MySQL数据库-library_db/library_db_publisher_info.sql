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
-- Table structure for table `publisher_info`
--

DROP TABLE IF EXISTS `publisher_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publisher_info` (
  `PID` int NOT NULL AUTO_INCREMENT,
  `PName` varchar(30) DEFAULT NULL,
  `Contact` varchar(15) DEFAULT NULL,
  `Phone` varchar(30) DEFAULT NULL,
  `PFax` text,
  `Province` varchar(15) DEFAULT NULL,
  `City` varchar(15) DEFAULT NULL,
  `Street` varchar(15) DEFAULT NULL,
  `DetailAddress` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`PID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publisher_info`
--

LOCK TABLES `publisher_info` WRITE;
/*!40000 ALTER TABLE `publisher_info` DISABLE KEYS */;
INSERT INTO `publisher_info` VALUES (1,'清华大学出版社','陈老师','010-11','010-11','广东','广州','新港西路','135号中山大学'),(2,'机械工业出版社','李老师','010-12','010-12','湖南','长沙','五一大道','1号'),(3,'人民教育出版社','苏老师','010-13','010-13','广东','珠海','大学路','2号'),(4,'湖南大学出版社','区老师','010-17','010-14','湖南','株洲','株洲大道东','6号'),(5,'北京大学出版社','南老师','010-15','010-15','北京','海淀','中山路','3号'),(6,'中山大学出版社','罗老师','010-16','010-16','广东','珠海','情侣北路','1号'),(7,'华南出版社','1','11','1','广东','佛山','1','1'),(9,'中山出版社','钟老师','1111','111','广东','中山','中山路','2号');
/*!40000 ALTER TABLE `publisher_info` ENABLE KEYS */;
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
