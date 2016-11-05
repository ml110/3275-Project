-- phpMyAdmin SQL Dump
-- version 4.0.10deb1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 04, 2016 at 10:55 PM
-- Server version: 5.5.53-0ubuntu0.14.04.1
-- PHP Version: 5.5.9-1ubuntu4.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `HI-TEC`
--

-- --------------------------------------------------------

--
-- Table structure for table `ADDRESS`
--

CREATE TABLE IF NOT EXISTS `ADDRESS` (
  `address_id` int(11) NOT NULL,
  `address_street_number` varchar(45) NOT NULL,
  `city_id` int(11) NOT NULL,
  PRIMARY KEY (`address_id`),
  KEY `address_fk_01_idx` (`city_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `AISLE`
--

CREATE TABLE IF NOT EXISTS `AISLE` (
  `aisle_id` int(11) NOT NULL,
  `aisle_number` int(3) NOT NULL,
  `section_id` int(11) NOT NULL,
  PRIMARY KEY (`aisle_id`),
  KEY `aisle_fk_01_idx` (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `CATEGORY`
--

CREATE TABLE IF NOT EXISTS `CATEGORY` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(45) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `CATEGORY`
--

INSERT INTO `CATEGORY` (`category_id`, `category_name`) VALUES
(1, 'Memory'),
(2, 'Motherboards'),
(3, 'GPUs'),
(4, 'CPUs'),
(5, 'Storage'),
(6, 'PSUs'),
(7, 'Displays'),
(8, 'Keyboards'),
(9, 'Mice'),
(10, 'Desktop'),
(11, 'Accessories');

-- --------------------------------------------------------

--
-- Table structure for table `CITY`
--

CREATE TABLE IF NOT EXISTS `CITY` (
  `city_id` int(11) NOT NULL,
  `city_name` varchar(45) NOT NULL,
  PRIMARY KEY (`city_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `CITY`
--

INSERT INTO `CITY` (`city_id`, `city_name`) VALUES
(1, 'Vancouver'),
(2, 'Port Coquitlam'),
(3, 'Coquitlam'),
(4, 'New Westminister'),
(5, 'Surrey'),
(6, 'Pitt Meadows'),
(7, 'Maple Ridge'),
(8, 'White Rock'),
(9, 'Delta'),
(10, 'Port Moody'),
(11, 'Hope'),
(12, 'Abbotsford'),
(13, 'Richmond'),
(14, 'Chilliwack'),
(15, 'Burnaby'),
(16, 'West Vancouver'),
(17, 'North Vancouver'),
(18, 'Langley');

-- --------------------------------------------------------

--
-- Table structure for table `CLIENT`
--

CREATE TABLE IF NOT EXISTS `CLIENT` (
  `client_id` int(11) NOT NULL,
  `client_name` varchar(45) NOT NULL,
  `client_contact` varchar(45) NOT NULL,
  `client_email` tinytext NOT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `CLIENT`
--

INSERT INTO `CLIENT` (`client_id`, `client_name`, `client_contact`, `client_email`) VALUES
(1, 'Wolf, Block and Ledner', 'Samuel Porter', 'sporter0@symantec.com'),
(2, 'Friesen Inc', 'Gerald Cook', 'gcook1@bluehost.com'),
(3, 'Franecki Group', 'Howard Turner', 'hturner2@arstechnica.com'),
(4, 'Hirthe, Cartwright and Brown', 'Evelyn Reyes', 'ereyes3@reddit.com'),
(5, 'Becker, Schmeler and Kihn', 'Dorothy James', 'djames4@taobao.com'),
(6, 'Lueilwitz and Sons', 'Brenda Dixon', 'bdixon5@vimeo.com'),
(7, 'Boyer-Bergnaum', 'Fred Alexander', 'falexander6@utexas.edu');

-- --------------------------------------------------------

--
-- Table structure for table `CLIENT_LOCATION`
--

CREATE TABLE IF NOT EXISTS `CLIENT_LOCATION` (
  `client_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  PRIMARY KEY (`client_id`,`location_id`),
  KEY `clientLoc_fk_02_idx` (`location_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `EMPLOYEE`
--

CREATE TABLE IF NOT EXISTS `EMPLOYEE` (
  `employee_id` int(11) NOT NULL,
  `employee_fname` varchar(45) NOT NULL,
  `employee_lname` varchar(45) NOT NULL,
  `employee_email` tinytext NOT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `EMPLOYEE`
--

INSERT INTO `EMPLOYEE` (`employee_id`, `employee_fname`, `employee_lname`, `employee_email`) VALUES
(1, 'Elizabeth', 'Nichols', 'enichols0@dell.com'),
(2, 'Susan', 'Burton', 'sburton1@theguardian.com'),
(3, 'Katherine', 'Austin', 'kaustin2@miitbeian.gov.cn'),
(4, 'Brenda', 'Hart', 'bhart3@wikipedia.org'),
(5, 'Diane', 'Morales', 'dmorales4@youku.com'),
(6, 'Henry', 'Gardner', 'hgardner5@biglobe.ne.jp'),
(7, 'Thomas', 'Vasquez', 'tvasquez6@drupal.org'),
(8, 'Lois', 'Sanchez', 'lsanchez7@apache.org'),
(9, 'Cynthia', 'Kelly', 'ckelly8@amazonaws.com'),
(10, 'Philip', 'Walker', 'pwalker9@ft.com'),
(11, 'Patricia', 'Spencer', 'pspencera@foxnews.com'),
(12, 'Jeremy', 'Wells', 'jwellsb@microsoft.com'),
(13, 'Rachel', 'Gardner', 'rgardnerc@hostgator.com'),
(14, 'Raymond', 'Hunter', 'rhunterd@shop-pro.jp'),
(15, 'Christina', 'Peterson', 'cpetersone@ezinearticles.com'),
(16, 'Louise', 'Montgomery', 'lmontgomeryf@barnesandnoble.com'),
(17, 'Diana', 'Schmidt', 'dschmidtg@cdc.gov'),
(18, 'John', 'Frazier', 'jfrazierh@infoseek.co.jp'),
(19, 'Shirley', 'Frazier', 'sfrazieri@home.pl'),
(20, 'Martha', 'Stone', 'mstonej@bigcartel.com');

-- --------------------------------------------------------

--
-- Table structure for table `EMPLOYEE_CREDS`
--

CREATE TABLE IF NOT EXISTS `EMPLOYEE_CREDS` (
  `employee_id` int(11) NOT NULL,
  `employee_password` varchar(45) NOT NULL,
  `permission_id` int(11) NOT NULL,
  PRIMARY KEY (`employee_id`),
  KEY `empCred_fk_02_idx` (`permission_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `EMPLOYEE_PHONE`
--

CREATE TABLE IF NOT EXISTS `EMPLOYEE_PHONE` (
  `employee_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`employee_id`,`phone_id`),
  KEY `empPhone_fk_02_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `LOCATION`
--

CREATE TABLE IF NOT EXISTS `LOCATION` (
  `location_id` int(11) NOT NULL,
  `location_name` varchar(45) NOT NULL,
  `client_id` int(11) NOT NULL,
  `contact_name` varchar(45) NOT NULL,
  `address_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`location_id`),
  KEY `location_fk_01_idx` (`client_id`),
  KEY `location_fk_02_idx` (`address_id`),
  KEY `location_fk_03_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `MANUFACTURER`
--

CREATE TABLE IF NOT EXISTS `MANUFACTURER` (
  `manufacturer_id` int(11) NOT NULL,
  `manufacturer_name` varchar(45) NOT NULL,
  PRIMARY KEY (`manufacturer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `MANUFACTURER`
--

INSERT INTO `MANUFACTURER` (`manufacturer_id`, `manufacturer_name`) VALUES
(1, 'Nanite Systems'),
(2, 'ACME'),
(3, 'AZEUS'),
(4, 'MegaSoft'),
(5, 'Orange Inc.'),
(6, 'Moon Macrosystems'),
(7, 'Pressman Manufacturing'),
(8, 'Maxim Ltd.'),
(9, 'Arabica'),
(10, 'IDK Manufacturing');

-- --------------------------------------------------------

--
-- Table structure for table `ORDER`
--

CREATE TABLE IF NOT EXISTS `ORDER` (
  `order_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `order_date` date NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `order_fk_01_idx` (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `ORDER_PRODUCT`
--

CREATE TABLE IF NOT EXISTS `ORDER_PRODUCT` (
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`order_id`,`product_id`),
  KEY `orderProduct_fk_02_idx` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `PERMISSION_GROUP`
--

CREATE TABLE IF NOT EXISTS `PERMISSION_GROUP` (
  `permission_id` int(11) NOT NULL,
  `permission_group_name` varchar(45) NOT NULL,
  PRIMARY KEY (`permission_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `PERMISSION_GROUP`
--

INSERT INTO `PERMISSION_GROUP` (`permission_id`, `permission_group_name`) VALUES
(1, 'Warehouse Employee'),
(2, 'Receiving'),
(3, 'Supplier'),
(4, 'Operations Supervisor'),
(5, 'Warehouse Manager'),
(6, 'Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `PHONE`
--

CREATE TABLE IF NOT EXISTS `PHONE` (
  `phone_id` int(11) NOT NULL,
  `phone_number` tinytext NOT NULL,
  PRIMARY KEY (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `PHONE`
--

INSERT INTO `PHONE` (`phone_id`, `phone_number`) VALUES
(1, '66-(580)533-4290'),
(2, '27-(154)371-0267'),
(3, '86-(854)735-1190'),
(4, '62-(553)397-1996'),
(5, '686-(680)212-8791'),
(6, '387-(376)269-7822'),
(7, '48-(769)140-5402'),
(8, '963-(146)534-7673'),
(9, '255-(264)306-8677'),
(10, '62-(426)152-8570'),
(11, '51-(717)395-8025'),
(12, '685-(536)629-7658'),
(13, '593-(140)233-4202'),
(14, '55-(851)946-0093'),
(15, '212-(681)813-8404'),
(16, '58-(646)947-8242'),
(17, '86-(948)918-0644'),
(18, '212-(898)363-8566'),
(19, '420-(196)807-6307'),
(20, '351-(270)129-6109'),
(21, '92-(604)438-0748'),
(22, '49-(668)393-3328'),
(23, '380-(120)396-2963'),
(24, '1-(703)766-1583'),
(25, '54-(197)125-8800'),
(26, '850-(689)640-2186'),
(27, '62-(215)123-1925'),
(28, '7-(375)732-9065'),
(29, '62-(914)311-8373'),
(30, '968-(860)754-6951'),
(31, '33-(384)607-2719'),
(32, '357-(583)716-2756'),
(33, '7-(925)294-1557'),
(34, '46-(153)575-1258'),
(35, '965-(513)584-4581'),
(36, '86-(871)440-0104'),
(37, '62-(633)206-0690'),
(38, '507-(836)223-3156'),
(39, '48-(382)371-6216'),
(40, '55-(863)390-9536'),
(41, '62-(783)464-1035'),
(42, '7-(411)767-5431'),
(43, '63-(890)610-7147'),
(44, '82-(581)348-7579'),
(45, '1-(860)400-9218'),
(46, '380-(335)427-3993'),
(47, '351-(197)115-7452'),
(48, '86-(917)932-1937'),
(49, '86-(591)896-7629'),
(50, '48-(816)350-8478');

-- --------------------------------------------------------

--
-- Table structure for table `PRODUCT`
--

CREATE TABLE IF NOT EXISTS `PRODUCT` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(45) NOT NULL,
  `product_price` double NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `manufacturer_id` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  `shelf_id` int(11) NOT NULL,
  `product_img_path` text NOT NULL,
  PRIMARY KEY (`product_id`),
  KEY `product_fk_01_idx` (`supplier_id`),
  KEY `product_fk_02_idx` (`manufacturer_id`),
  KEY `product_fk_03_idx` (`category_id`),
  KEY `product_fk_04_idx` (`shelf_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SECTION`
--

CREATE TABLE IF NOT EXISTS `SECTION` (
  `section_id` int(3) NOT NULL,
  `section_name` varchar(45) NOT NULL,
  PRIMARY KEY (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SHELF`
--

CREATE TABLE IF NOT EXISTS `SHELF` (
  `shelf_id` int(3) NOT NULL,
  `shelf_number` int(11) NOT NULL,
  `aisle_id` int(11) NOT NULL,
  PRIMARY KEY (`shelf_id`),
  KEY `shelf_fk_01_idx` (`aisle_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SHIPMENT`
--

CREATE TABLE IF NOT EXISTS `SHIPMENT` (
  `shipment_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  `shipment_date` date NOT NULL,
  `hasShipped` tinyint(1) NOT NULL,
  PRIMARY KEY (`shipment_id`),
  KEY `shipment_fk_01_idx` (`location_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SHIPMENT_PRODUCT`
--

CREATE TABLE IF NOT EXISTS `SHIPMENT_PRODUCT` (
  `shipment_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`shipment_id`,`product_id`),
  KEY `shipProduct_fk_02_idx` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SUPPLIER`
--

CREATE TABLE IF NOT EXISTS `SUPPLIER` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(45) NOT NULL,
  `supplier_contact` varchar(45) NOT NULL,
  `address_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  `supplier_email` varchar(45) NOT NULL,
  PRIMARY KEY (`supplier_id`),
  KEY `supplier_fk_01_idx` (`address_id`),
  KEY `supplier_fk_02_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ADDRESS`
--
ALTER TABLE `ADDRESS`
  ADD CONSTRAINT `address_fk_01` FOREIGN KEY (`city_id`) REFERENCES `CITY` (`city_id`) ON UPDATE CASCADE;

--
-- Constraints for table `AISLE`
--
ALTER TABLE `AISLE`
  ADD CONSTRAINT `aisle_fk_01` FOREIGN KEY (`section_id`) REFERENCES `SECTION` (`section_id`) ON UPDATE CASCADE;

--
-- Constraints for table `CLIENT_LOCATION`
--
ALTER TABLE `CLIENT_LOCATION`
  ADD CONSTRAINT `clientLoc_fk_01` FOREIGN KEY (`client_id`) REFERENCES `CLIENT` (`client_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `clientLoc_fk_02` FOREIGN KEY (`location_id`) REFERENCES `LOCATION` (`location_id`) ON UPDATE CASCADE;

--
-- Constraints for table `EMPLOYEE_CREDS`
--
ALTER TABLE `EMPLOYEE_CREDS`
  ADD CONSTRAINT `empCred_fk_01` FOREIGN KEY (`employee_id`) REFERENCES `EMPLOYEE` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `empCred_fk_02` FOREIGN KEY (`permission_id`) REFERENCES `PERMISSION_GROUP` (`permission_id`) ON UPDATE CASCADE;

--
-- Constraints for table `EMPLOYEE_PHONE`
--
ALTER TABLE `EMPLOYEE_PHONE`
  ADD CONSTRAINT `empPhone_fk_01` FOREIGN KEY (`employee_id`) REFERENCES `EMPLOYEE` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `empPhone_fk_02` FOREIGN KEY (`phone_id`) REFERENCES `PHONE` (`phone_id`) ON UPDATE CASCADE;

--
-- Constraints for table `LOCATION`
--
ALTER TABLE `LOCATION`
  ADD CONSTRAINT `location_fk_01` FOREIGN KEY (`client_id`) REFERENCES `CLIENT` (`client_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `location_fk_02` FOREIGN KEY (`address_id`) REFERENCES `ADDRESS` (`address_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `location_fk_03` FOREIGN KEY (`phone_id`) REFERENCES `PHONE` (`phone_id`) ON UPDATE CASCADE;

--
-- Constraints for table `ORDER`
--
ALTER TABLE `ORDER`
  ADD CONSTRAINT `order_fk_01` FOREIGN KEY (`supplier_id`) REFERENCES `SUPPLIER` (`supplier_id`) ON UPDATE CASCADE;

--
-- Constraints for table `ORDER_PRODUCT`
--
ALTER TABLE `ORDER_PRODUCT`
  ADD CONSTRAINT `orderProduct_fk_01` FOREIGN KEY (`order_id`) REFERENCES `ORDER` (`order_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `orderProduct_fk_02` FOREIGN KEY (`product_id`) REFERENCES `PRODUCT` (`product_id`) ON UPDATE CASCADE;

--
-- Constraints for table `PRODUCT`
--
ALTER TABLE `PRODUCT`
  ADD CONSTRAINT `product_fk_01` FOREIGN KEY (`supplier_id`) REFERENCES `SUPPLIER` (`supplier_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_02` FOREIGN KEY (`manufacturer_id`) REFERENCES `MANUFACTURER` (`manufacturer_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_03` FOREIGN KEY (`category_id`) REFERENCES `CATEGORY` (`category_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_04` FOREIGN KEY (`shelf_id`) REFERENCES `SHELF` (`shelf_id`) ON UPDATE CASCADE;

--
-- Constraints for table `SHELF`
--
ALTER TABLE `SHELF`
  ADD CONSTRAINT `shelf_fk_01` FOREIGN KEY (`aisle_id`) REFERENCES `AISLE` (`aisle_id`) ON UPDATE CASCADE;

--
-- Constraints for table `SHIPMENT`
--
ALTER TABLE `SHIPMENT`
  ADD CONSTRAINT `shipment_fk_01` FOREIGN KEY (`location_id`) REFERENCES `LOCATION` (`location_id`) ON UPDATE CASCADE;

--
-- Constraints for table `SHIPMENT_PRODUCT`
--
ALTER TABLE `SHIPMENT_PRODUCT`
  ADD CONSTRAINT `shipProduct_fk_01` FOREIGN KEY (`shipment_id`) REFERENCES `SHIPMENT` (`shipment_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `shipProduct_fk_02` FOREIGN KEY (`product_id`) REFERENCES `PRODUCT` (`product_id`) ON UPDATE CASCADE;

--
-- Constraints for table `SUPPLIER`
--
ALTER TABLE `SUPPLIER`
  ADD CONSTRAINT `supplier_fk_01` FOREIGN KEY (`address_id`) REFERENCES `ADDRESS` (`address_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_fk_02` FOREIGN KEY (`phone_id`) REFERENCES `PHONE` (`phone_id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
