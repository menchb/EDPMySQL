CREATE DATABASE  IF NOT EXISTS `bookin` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bookin`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bookin
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `author`
--

DROP TABLE IF EXISTS `author`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `author` (
  `AUTHOR_NAME` varchar(50) DEFAULT NULL,
  `ID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `author`
--

LOCK TABLES `author` WRITE;
/*!40000 ALTER TABLE `author` DISABLE KEYS */;
INSERT INTO `author` VALUES ('Pablo Neruda',1),('Franklin D. Lewis',2),('Kristina Mahr',3),('Noor Shirazie',4),('Margaret Atwood',5),('Michael Faudet',6),('John Keats',7),('Mary Oliver',8),('Allen Gisnberg',9),('Trista Mateer',10),('Atticus',11),('Emily Dickinson',12),('Halsey',13),('R.H. Sin',15),('',16);
/*!40000 ALTER TABLE `author` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `bestsellers_by_order`
--

DROP TABLE IF EXISTS `bestsellers_by_order`;
/*!50001 DROP VIEW IF EXISTS `bestsellers_by_order`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bestsellers_by_order` AS SELECT 
 1 AS `TITLE`,
 1 AS `TOTAL_ORDERS`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `bestsellers_by_revenue`
--

DROP TABLE IF EXISTS `bestsellers_by_revenue`;
/*!50001 DROP VIEW IF EXISTS `bestsellers_by_revenue`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bestsellers_by_revenue` AS SELECT 
 1 AS `TITLE`,
 1 AS `REVENUE`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `book`
--

DROP TABLE IF EXISTS `book`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book` (
  `ISBN` int NOT NULL,
  `TITLE` varchar(100) NOT NULL,
  `PUBLICATION_YEAR` int DEFAULT NULL,
  `RETAIL_PRICE` int DEFAULT NULL,
  `STOCKS` int DEFAULT NULL,
  `AUTHOR_ID` int DEFAULT NULL,
  `PUBLISHER_ID` int DEFAULT NULL,
  PRIMARY KEY (`ISBN`),
  KEY `AUTHOR_ID` (`AUTHOR_ID`),
  KEY `PUBLISHER_ID` (`PUBLISHER_ID`),
  CONSTRAINT `book_ibfk_1` FOREIGN KEY (`AUTHOR_ID`) REFERENCES `author` (`ID`),
  CONSTRAINT `book_ibfk_2` FOREIGN KEY (`PUBLISHER_ID`) REFERENCES `publisher` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book`
--

LOCK TABLES `book` WRITE;
/*!40000 ALTER TABLE `book` DISABLE KEYS */;
INSERT INTO `book` VALUES (1234567870,'I Would Leave Me If I Could',2020,500,50,13,11),(1234567880,'Love Poems',2008,525,70,1,10),(1234567890,'Rumi',2003,100,5,2,1),(1234567891,'Say It\'s the Sea',2020,200,10,3,2),(1234567892,'Into the Wildfire',2016,300,15,4,NULL),(1234567893,'In Other Worlds',2011,400,50,5,3),(1234567894,'Smoke & Mirrors',2017,400,30,6,4),(1234567895,'Complete Poems',2009,210,20,7,5),(1234567896,'Felicity',2015,500,25,8,6),(1234567897,'Howl and Other Poems',1979,255,35,9,7),(1234567898,'Honeybee',2018,560,40,10,8),(1234567899,'The Dark Between Stars',2018,600,65,11,9);
/*!40000 ALTER TABLE `book` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `FIRST_NAME` varchar(50) DEFAULT NULL,
  `LAST_NAME` varchar(50) DEFAULT NULL,
  `CITY` varchar(50) DEFAULT NULL,
  `PROVINCE` varchar(50) DEFAULT NULL,
  `ZIP` int DEFAULT NULL,
  `PHONE` varchar(50) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `TOTAL_SPENT` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Menchie','Belarmino','Tabaco City','Albay',4511,'09001122334','mench@email.com',1000),(2,'Jane','Doe','Legazpi City','Albay',4500,'09012345678','janedoe@email.com',3700),(3,'John','Doe','Legazpi City','Albay',4500,'09123456789','johndoe@email.com',400),(4,'John','Smith','Sorsogon City','Sorsogon',4700,'09234567891','johnsmith@email.com',800),(5,'Jane','Smith','Sorsogon City','Sorsogon',4700,'09345678912','janesmith@email.com',630),(6,'Juan','Delacruz','Camalig','Albay',4502,'09456789123','juandelacruz@email.com',2000),(7,'Juanita','Delacruz','Bato','Camarines Sur',4435,'09567891234','juanitadelacruz@email.com',1375),(8,'James','Potter','Daet','Camarines Norte',4600,'09678901234','jamespotter@email.com',3900),(9,'Lily','Potter','Daet','Camarines Norte',4600,'09001112222','lilypotter@email.com',100),(10,'Harry','Potter','Daet','Camarines Norte',4600,'9112223333','harrypotter@gmail.com',100);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `CUSTOMER_ID` int NOT NULL,
  `ORDER_DATE` date DEFAULT NULL,
  `ORDER_FILLED` int DEFAULT '0',
  PRIMARY KEY (`order_id`),
  KEY `CUSTOMER_ID` (`CUSTOMER_ID`),
  CONSTRAINT `order_ibfk_1` FOREIGN KEY (`CUSTOMER_ID`) REFERENCES `customer` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,1,'2023-01-01',1),(2,2,'2023-01-02',1),(3,3,'2023-01-03',1),(4,4,'2023-01-06',1),(5,5,'2023-01-06',1),(6,6,'2023-01-08',1),(7,7,'2023-01-12',1),(8,8,'2023-01-18',1),(9,9,'2023-01-25',1),(10,10,'2023-02-02',1),(11,1,'2023-02-06',1),(12,2,'2023-02-14',1),(14,5,'2023-03-09',1);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `UPDATE_TOTAL_SPENT2` AFTER UPDATE ON `order` FOR EACH ROW BEGIN
	IF OLD.ORDER_FILLED = 0 AND NEW.ORDER_FILLED = 1 THEN
		UPDATE CUSTOMER
		SET TOTAL_SPENT = TOTAL_SPENT + (SELECT SUM(COST_LINE)
											FROM ORDER_LINE
											WHERE NEW.ORDER_ID = ORDER_LINE.ORDER_ID)
		WHERE NEW.ORDER_FILLED = 1 AND NEW.CUSTOMER_ID = CUSTOMER.ID; 
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `order_line`
--

DROP TABLE IF EXISTS `order_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_line` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ISBN` int NOT NULL,
  `ORDER_ID` int DEFAULT NULL,
  `COST_EACH` int NOT NULL,
  `COST_LINE` int NOT NULL,
  `QUANTITY` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ISBN` (`ISBN`),
  KEY `ORDER_ID` (`ORDER_ID`),
  CONSTRAINT `order_line_ibfk_1` FOREIGN KEY (`ISBN`) REFERENCES `book` (`ISBN`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_line`
--

LOCK TABLES `order_line` WRITE;
/*!40000 ALTER TABLE `order_line` DISABLE KEYS */;
INSERT INTO `order_line` VALUES (1,1234567890,1,100,100,1),(2,1234567891,1,200,400,2),(3,1234567892,2,300,900,3),(4,1234567893,3,400,400,1),(5,1234567894,4,400,800,2),(6,1234567895,5,210,630,3),(7,1234567896,6,500,2000,4),(8,1234567897,7,255,255,1),(9,1234567898,7,560,1120,2),(10,1234567899,8,600,1800,3),(11,1234567880,8,525,2100,4),(12,1234567890,9,100,100,1),(13,1234567891,10,100,100,1),(14,1234567896,11,500,500,1),(15,1234567896,12,500,1000,2),(22,1234567892,13,300,300,1),(23,1234567894,14,400,800,2);
/*!40000 ALTER TABLE `order_line` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `UPDATE_TOTAL_SPENT` AFTER INSERT ON `order_line` FOR EACH ROW BEGIN
	IF NEW.ORDER_ID IS NOT NULL AND (SELECT ORDER_FILLED FROM `ORDER` WHERE ORDER_ID = NEW.ORDER_ID) = 1 THEN
		UPDATE CUSTOMER
		SET TOTAL_SPENT = TOTAL_SPENT + NEW.COST_LINE
        WHERE CUSTOMER.ID = (SELECT CUSTOMER_ID 
										FROM `ORDER`
										WHERE NEW.ORDER_ID = `ORDER`.ORDER_ID);
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `DEL_ORDER` BEFORE DELETE ON `order_line` FOR EACH ROW BEGIN
	-- If the deleted order line is the last one referencing the order_id, delete the order_id row from the order table as well.
	IF (SELECT COUNT(*) FROM ORDER_LINE WHERE ORDER_ID = OLD.ORDER_ID) = 1 THEN
		DELETE FROM `ORDER`
		WHERE `ORDER`.ORDER_ID = OLD.ORDER_ID;
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `orders_to_ship`
--

DROP TABLE IF EXISTS `orders_to_ship`;
/*!50001 DROP VIEW IF EXISTS `orders_to_ship`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `orders_to_ship` AS SELECT 
 1 AS `ORDER_ID`,
 1 AS `ORDER_FILLED`,
 1 AS `TITLE`,
 1 AS `QUANTITY`,
 1 AS `ID`,
 1 AS `FIRST_NAME`,
 1 AS `LAST_NAME`,
 1 AS `CITY`,
 1 AS `PROVINCE`,
 1 AS `ZIP`,
 1 AS `PHONE`,
 1 AS `EMAIL`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `publisher`
--

DROP TABLE IF EXISTS `publisher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publisher` (
  `PUBLISHER_NAME` varchar(50) DEFAULT NULL,
  `ID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publisher`
--

LOCK TABLES `publisher` WRITE;
/*!40000 ALTER TABLE `publisher` DISABLE KEYS */;
INSERT INTO `publisher` VALUES ('Oneworld Publications',1),('Independent',2),('Knopf Doubleday Publishing Group',3),('Andrews McMeel Publishing',4),('Random House Publishing Group',5),('Penguin Press',6),('City Lights Books',7),('Central Avenue Publishing',8),('Atria Books',9),('New Directions',10),('Simon & Schuster UK',11),('',12);
/*!40000 ALTER TABLE `publisher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `username` varchar(25) NOT NULL,
  `password` varchar(126) DEFAULT NULL,
  `id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('menchie','97382320af3286e352cf74d3f7ef8418',1),('assistant','f549cd73f694aa6f5541b4ae30894eea',2);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bookin'
--

--
-- Dumping routines for database 'bookin'
--
/*!50003 DROP FUNCTION IF EXISTS `OFFER_DISCOUNT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `OFFER_DISCOUNT`(OLD_PRICE INT, PERCENT DOUBLE) RETURNS double
    DETERMINISTIC
BEGIN
		DECLARE NEW_PRICE DOUBLE;
        SET NEW_PRICE = OLD_PRICE - (OLD_PRICE * PERCENT);
        RETURN NEW_PRICE;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UPDATE_CUSTOMER_SPENT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_CUSTOMER_SPENT`()
BEGIN
		DECLARE DONE INT DEFAULT 0;
		DECLARE CURRENT_CUST_ID INT;
		DECLARE CUST_ID_CUR CURSOR FOR SELECT ID FROM CUSTOMER;
		DECLARE CONTINUE HANDLER FOR NOT FOUND SET DONE = 1;
		
		OPEN CUST_ID_CUR;
		REPEAT
			FETCH CUST_ID_CUR INTO CURRENT_CUST_ID;
			UPDATE CUSTOMER
			SET TOTAL_SPENT = (SELECT SUM(COST_LINE) FROM ORDER_LINE, `ORDER`
								WHERE ORDER_LINE.ORDER_ID = `ORDER`.ORDER_ID  AND `ORDER`.CUSTOMER_ID = CURRENT_CUST_ID AND `ORDER`.ORDER_FILLED = 1)
			WHERE ID = CURRENT_CUST_ID;
		UNTIL DONE
		END REPEAT;
		CLOSE CUST_ID_CUR;
	END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `bestsellers_by_order`
--

/*!50001 DROP VIEW IF EXISTS `bestsellers_by_order`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bestsellers_by_order` AS select `book`.`TITLE` AS `TITLE`,sum(`order_line`.`QUANTITY`) AS `TOTAL_ORDERS` from (`book` join `order_line`) where (`book`.`ISBN` = `order_line`.`ISBN`) group by `order_line`.`ISBN` order by `TOTAL_ORDERS` desc limit 5 */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `bestsellers_by_revenue`
--

/*!50001 DROP VIEW IF EXISTS `bestsellers_by_revenue`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bestsellers_by_revenue` AS select `book`.`TITLE` AS `TITLE`,sum(`order_line`.`COST_LINE`) AS `REVENUE` from (`book` join `order_line`) where (`book`.`ISBN` = `order_line`.`ISBN`) group by `order_line`.`ISBN` order by `REVENUE` desc limit 5 */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `orders_to_ship`
--

/*!50001 DROP VIEW IF EXISTS `orders_to_ship`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `orders_to_ship` AS select `order`.`order_id` AS `ORDER_ID`,`order`.`ORDER_FILLED` AS `ORDER_FILLED`,`book`.`TITLE` AS `TITLE`,`order_line`.`QUANTITY` AS `QUANTITY`,`customer`.`ID` AS `ID`,`customer`.`FIRST_NAME` AS `FIRST_NAME`,`customer`.`LAST_NAME` AS `LAST_NAME`,`customer`.`CITY` AS `CITY`,`customer`.`PROVINCE` AS `PROVINCE`,`customer`.`ZIP` AS `ZIP`,`customer`.`PHONE` AS `PHONE`,`customer`.`EMAIL` AS `EMAIL` from (((`order` join `order_line` on((`order_line`.`ORDER_ID` = `order`.`order_id`))) join `book` on((`book`.`ISBN` = `order_line`.`ISBN`))) join `customer` on((`customer`.`ID` = `order`.`CUSTOMER_ID`))) where (`order`.`ORDER_FILLED` = false) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-09 20:25:38
