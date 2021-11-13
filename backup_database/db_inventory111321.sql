-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: db_inventory
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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CreatedBy` bigint NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `CategoryName_UNIQUE` (`CategoryName`),
  KEY `FK_Category_Users_idx` (`CreatedBy`),
  CONSTRAINT `FK_Category_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Drinks',1,'2011-03-21 00:00:00','Active'),(2,'Foods',1,'2011-04-21 00:00:00','Active');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ProductId` bigint NOT NULL,
  `InventoryDate` datetime NOT NULL,
  `Quantity` decimal(18,0) NOT NULL,
  `CreatedBy` bigint NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Inventory_Users_idx` (`CreatedBy`),
  KEY `FK_Inventory_Products_idx` (`ProductId`),
  CONSTRAINT `FK_Inventory_Products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`),
  CONSTRAINT `FK_Inventory_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,1,'2021-11-03 17:39:36',8,1,'2021-11-03 17:39:51','Active'),(2,1,'2021-11-03 19:37:54',5,1,'2021-11-03 19:38:13','Active'),(3,2,'2021-11-04 23:14:26',10,1,'2021-11-04 23:14:37','Active'),(4,2,'2021-11-04 23:31:02',3,1,'2021-11-04 23:31:21','Active'),(5,3,'2021-11-05 10:59:49',10,1,'2021-11-05 11:00:01','Active'),(6,4,'2021-11-10 22:57:52',5,1,'2021-11-10 22:58:42','Active');
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `OrderId` bigint NOT NULL,
  `ProductId` bigint NOT NULL,
  `Quantity` decimal(18,0) NOT NULL,
  `Price` decimal(18,0) NOT NULL,
  `Total` decimal(18,0) NOT NULL,
  `CreatedBy` bigint NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_OrderDetails_Users_idx` (`CreatedBy`),
  KEY `FK_OrderDetails_Orders_idx` (`OrderId`),
  KEY `FK_OrderDetails_Products_idx` (`ProductId`),
  CONSTRAINT `FK_OrderDetails_Orders` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`Id`),
  CONSTRAINT `FK_OrderDetails_Products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`),
  CONSTRAINT `FK_OrderDetails_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (5,3,3,3,45,135,1,'2021-11-05 11:01:51','Active'),(6,3,2,2,8,16,1,'2021-11-05 11:01:51','Active'),(9,1,1,3,90,270,1,'2021-11-10 21:43:24','Active'),(10,1,2,3,8,24,1,'2021-11-10 21:43:24','Active'),(15,2,1,2,90,180,1,'2021-11-10 22:42:14','Active'),(16,2,2,3,8,24,1,'2021-11-10 22:42:14','Active'),(19,4,4,3,46,138,1,'2021-11-10 23:02:32','Active'),(20,4,2,2,8,16,1,'2021-11-10 23:02:32','Active'),(23,5,1,2,90,180,1,'2021-11-10 23:40:11','Active'),(24,5,2,3,8,24,1,'2021-11-10 23:40:11','Active');
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `OrderNo` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `OrderDate` datetime NOT NULL,
  `TotalAmount` decimal(18,0) NOT NULL,
  `CreatedBy` bigint NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Orders_Users_idx` (`CreatedBy`),
  CONSTRAINT `FK_Orders_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'50910','2021-11-04 23:14:47',294,1,'2021-11-04 23:15:25','Active'),(2,'23008','2021-11-04 23:28:32',204,1,'2021-11-04 23:29:15','Active'),(3,'44134','2021-11-05 11:00:26',151,1,'2021-11-05 11:01:51','Active'),(4,'4710','2021-11-10 22:59:08',154,1,'2021-11-10 23:00:39','Active'),(5,'37806','2021-11-10 23:03:40',204,2,'2021-11-10 23:04:07','Active');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Name` varchar(300) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Description` varchar(300) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `QuantityOnHand` decimal(18,0) NOT NULL,
  `QuantitySold` decimal(18,0) NOT NULL,
  `QuantityOrdered` decimal(18,0) NOT NULL,
  `Price` decimal(18,0) NOT NULL,
  `CreatedBy` bigint NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  `CategoryId` bigint NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Products_Users_idx` (`CreatedBy`),
  KEY `FK_Products_Category_idx` (`CategoryId`),
  CONSTRAINT `FK_Products_Category` FOREIGN KEY (`CategoryId`) REFERENCES `category` (`Id`),
  CONSTRAINT `FK_Products_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Selecta Fortified Milk','1 Liter',6,7,0,90,1,'2021-11-03 17:39:21','Active',1),(2,'Sky Flakes','1 pc',0,13,0,8,1,'2021-11-04 23:14:20','Active',2),(3,'Pepsi','1 Liter',7,3,0,45,1,'2021-11-05 10:59:42','Active',1),(4,'Coke','1 Liter',2,3,0,46,1,'2021-11-10 22:57:22','Active',1);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `DisplayName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Username` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Password` longtext NOT NULL,
  `UserAccess` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Position` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `CreatedBy` bigint DEFAULT NULL,
  `CreatedOn` datetime NOT NULL,
  `RecordStatus` varchar(9) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  KEY `FK_Users_Users_idx` (`CreatedBy`),
  CONSTRAINT `FK_Users_Users` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Administrator','admin','admin123','Admin','CEO',NULL,'2011-03-21 00:00:00','Active'),(2,'User 1','user1','user123','Standard','Manager',1,'2021-11-03 17:38:43','Active'),(3,'User 2','user2','user123','Standard','Staff',1,'2021-11-10 22:56:14','Active');
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

-- Dump completed on 2021-11-13 16:45:26
