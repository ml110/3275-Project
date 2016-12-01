-- phpMyAdmin SQL Dump
-- version 4.0.10deb1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 01, 2016 at 08:39 AM
-- Server version: 5.5.53-0ubuntu0.14.04.1
-- PHP Version: 5.5.9-1ubuntu4.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hi-tec`
--

-- --------------------------------------------------------

--
-- Table structure for table `address`
--

CREATE TABLE IF NOT EXISTS `address` (
  `address_id` int(11) NOT NULL,
  `address_unit_number` varchar(35) NOT NULL,
  `address_street_number` varchar(45) NOT NULL,
  `address_street_name` varchar(35) NOT NULL,
  `address_postcode` varchar(6) NOT NULL,
  `city_id` int(11) NOT NULL,
  PRIMARY KEY (`address_id`),
  KEY `address_fk_01_idx` (`city_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `address`
--

INSERT INTO `address` (`address_id`, `address_unit_number`, `address_street_number`, `address_street_name`, `address_postcode`, `city_id`) VALUES
(1, '28', '12', 'Grover', 'massa', 3),
(2, '6', '016', 'Cordelia', 'viverr', 5),
(3, '26', '34', 'Annamark', 'pulvin', 3),
(4, '12', '87664', 'Westridge', 'eget', 12),
(5, '24', '8988', 'Atwood', 'diam', 8),
(6, '17', '46315', 'Banding', 'non', 10),
(7, '10', '26', 'Tomscot', 'sit', 17),
(8, '8', '0', '1st', 'sed', 10),
(9, '25', '34', 'Reinke', 'in', 14),
(10, '18', '5', 'Dapin', 'nisi', 16),
(11, '22', '0', 'Warrior', 'lacini', 16),
(12, '6', '617', 'Gale', 'a', 13),
(13, '21', '3', 'Alpine', 'erat', 16),
(14, '2', '32', 'Brickson Park', 'maecen', 3),
(15, '2', '335', 'Porter', 'erat', 1),
(16, '3', '5', 'Shelley', 'elemen', 5),
(17, '8', '8428', 'Schurz', 'libero', 17),
(18, '17', '405', 'Melody', 'velit', 11),
(19, '7', '4', 'Grayhawk', 'dolor', 14),
(20, '20', '1826', 'Forest Dale', 'vivamu', 5),
(21, '4', '8435', 'Macpherson', 'diam', 11),
(22, '20', '89596', 'Vidon', 'tellus', 17),
(23, '5', '97518', 'Grayhawk', 'in', 6),
(24, '12', '652', 'Muir', 'id', 18),
(25, '5', '3378', 'Mallory', 'at', 6),
(26, '16', '897', 'Wayridge', 'lorem', 1),
(27, '28', '67565', 'Little Fleur', 'nec', 4),
(28, '22', '8762', 'Marquette', 'duis', 10),
(29, '14', '8271', 'Pine View', 'varius', 12),
(30, '5', '003', 'Moulton', 'euismo', 13),
(31, '26', '864', '7th', 'interd', 18),
(32, '22', '84', 'Algoma', 'molest', 8),
(33, '18', '1', 'Loeprich', 'faucib', 1),
(34, '19', '408', 'Milwaukee', 'eu', 9),
(35, '17', '514', 'Farragut', 'nec', 3),
(36, '11', '454', 'Gateway', 'rutrum', 3),
(37, '27', '4310', 'Iowa', 'nec', 1),
(38, '14', '08', 'Delaware', 'lacini', 7),
(39, '21', '05', 'Dennis', 'ultric', 4),
(40, '8', '71021', 'Dunning', 'turpis', 13),
(41, '3', '5843', 'Kropf', 'orci', 4),
(42, '6', '8', 'Sage', 'vel', 17),
(43, '27', '165', 'David', 'semper', 13),
(44, '17', '1508', 'Hayes', 'quis', 10),
(45, '22', '4', 'Annamark', 'ipsum', 18),
(46, '20', '06608', 'Twin Pines', 'massa', 5),
(47, '18', '61', 'Cordelia', 'id', 9),
(48, '23', '7', 'Northfield', 'varius', 11),
(49, '11', '03272', 'Cottonwood', 'posuer', 9),
(50, '26', '9', 'Daystar', 'dolor', 12);

-- --------------------------------------------------------

--
-- Table structure for table `aisle`
--

CREATE TABLE IF NOT EXISTS `aisle` (
  `aisle_id` int(11) NOT NULL,
  `aisle_number` int(3) NOT NULL,
  `section_id` int(11) NOT NULL,
  PRIMARY KEY (`aisle_id`),
  KEY `aisle_fk_01_idx` (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aisle`
--

INSERT INTO `aisle` (`aisle_id`, `aisle_number`, `section_id`) VALUES
(1, 101, 1),
(2, 102, 1),
(3, 103, 1),
(4, 104, 1),
(5, 105, 1),
(6, 106, 1),
(7, 107, 1),
(8, 108, 1),
(9, 109, 1),
(10, 110, 1),
(11, 111, 1),
(12, 112, 1),
(13, 113, 1),
(14, 114, 1),
(15, 115, 1),
(16, 201, 2),
(17, 202, 2),
(18, 203, 2),
(19, 204, 2),
(20, 205, 2),
(21, 301, 3),
(22, 302, 3),
(23, 303, 3),
(24, 304, 3),
(25, 305, 3),
(26, 306, 3),
(27, 307, 3),
(28, 308, 3),
(29, 309, 3),
(30, 310, 3),
(31, 401, 4),
(32, 402, 4),
(33, 403, 4),
(34, 404, 4),
(35, 405, 4),
(36, 406, 4),
(37, 407, 4),
(38, 408, 4),
(39, 409, 4),
(40, 410, 4);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(45) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_id`, `category_name`) VALUES
(1, 'RAM'),
(2, 'Motherboards'),
(3, 'GPUs'),
(4, 'CPUs'),
(5, 'Storage'),
(6, 'PSUs'),
(7, 'Displays'),
(8, 'Keyboards'),
(9, 'Mouse'),
(10, 'Desktop'),
(11, 'Accessories');

-- --------------------------------------------------------

--
-- Table structure for table `city`
--

CREATE TABLE IF NOT EXISTS `city` (
  `city_id` int(11) NOT NULL,
  `city_name` varchar(45) NOT NULL,
  PRIMARY KEY (`city_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `city`
--

INSERT INTO `city` (`city_id`, `city_name`) VALUES
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
-- Table structure for table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `client_id` int(11) NOT NULL,
  `client_name` varchar(45) NOT NULL COMMENT 'The name of the business we do business with.',
  `client_rep` varchar(70) NOT NULL COMMENT 'Client - Person responsible for business communications.',
  `client_email` varchar(255) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`client_id`),
  KEY `client_fk_01_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`client_id`, `client_name`, `client_rep`, `client_email`, `phone_id`) VALUES
(1, 'Rath-Frami', 'Helen King', 'hking0@gmpg.org', 43),
(2, 'Batz LLC', 'Louis Powell', 'lpowell1@rambler.ru', 37),
(3, 'Turner Inc', 'Gary Russell', 'grussell2@squidoo.com', 49),
(4, 'Stroman-O''Reilly', 'Bonnie Graham', 'bgraham3@geocities.jp', 46),
(5, 'Roob-Pfannerstill', 'Jennifer Campbell', 'jcampbell4@yandex.ru', 35),
(6, 'Hayes-Reynolds', 'Kathy Cole', 'kcole5@elegantthemes.com', 44),
(7, 'Berge-Auer', 'Lori Roberts', 'lroberts6@upenn.edu', 40);

-- --------------------------------------------------------

--
-- Table structure for table `client_location`
--

CREATE TABLE IF NOT EXISTS `client_location` (
  `client_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  PRIMARY KEY (`client_id`,`location_id`),
  KEY `clientLoc_fk_02_idx` (`location_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `employee_id` int(11) NOT NULL,
  `employee_fname` varchar(45) NOT NULL,
  `employee_lname` varchar(45) NOT NULL,
  `employee_email` tinytext NOT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_id`, `employee_fname`, `employee_lname`, `employee_email`) VALUES
(1, 'Matt', 'Lai', 'mlai0@dell.com'),
(2, 'Manveer', 'Sidhu', 'msidhu@theguardian.com'),
(3, 'Sam', 'Zhou', 'szhou@miitbeian.gov.cn'),
(4, 'Curtis', 'Windsor', 'cwindsor@wikipedia.org'),
(5, 'Manjot', 'Sangha', 'msangha@youku.com'),
(6, 'Nelson', 'Eng', 'neng@biglobe.ne.jp'),
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
-- Table structure for table `employee_creds`
--

CREATE TABLE IF NOT EXISTS `employee_creds` (
  `employee_id` int(11) NOT NULL,
  `employee_password` varchar(45) NOT NULL,
  `permission_id` int(11) NOT NULL,
  PRIMARY KEY (`employee_id`),
  KEY `empCred_fk_02_idx` (`permission_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee_creds`
--

INSERT INTO `employee_creds` (`employee_id`, `employee_password`, `permission_id`) VALUES
(1, 'Yellow', 1),
(2, 'Crimson', 2),
(3, 'Green', 3),
(4, 'Teal', 4),
(5, 'Green', 5),
(6, 'Maroon', 6),
(7, 'Khaki', 1),
(8, 'Khaki', 1),
(9, 'Turquoise', 1),
(10, 'Crimson', 1),
(11, 'Mauv', 3),
(12, 'Purple', 2),
(13, 'Puce', 1),
(14, 'Puce', 1),
(15, 'Blue', 3),
(16, 'Aquamarine', 1),
(17, 'Orange', 1),
(18, 'Yellow', 1),
(19, 'Pink', 1),
(20, 'Pink', 1);

-- --------------------------------------------------------

--
-- Table structure for table `employee_phone`
--

CREATE TABLE IF NOT EXISTS `employee_phone` (
  `employee_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`employee_id`,`phone_id`),
  KEY `empPhone_fk_02_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee_phone`
--

INSERT INTO `employee_phone` (`employee_id`, `phone_id`) VALUES
(20, 1),
(19, 2),
(18, 3),
(17, 4),
(12, 5),
(16, 5),
(15, 6),
(16, 6),
(14, 7),
(13, 8),
(12, 9),
(20, 9),
(9, 10),
(11, 10),
(10, 11),
(9, 12),
(8, 13),
(18, 13),
(7, 14),
(6, 15),
(5, 16),
(4, 17),
(7, 17),
(3, 18),
(2, 19),
(1, 20),
(13, 20),
(19, 20),
(11, 22),
(14, 22),
(4, 23),
(1, 29),
(5, 36),
(3, 39),
(15, 39),
(10, 42),
(6, 43),
(8, 44),
(17, 44),
(2, 49);

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

CREATE TABLE IF NOT EXISTS `location` (
  `location_id` int(11) NOT NULL,
  `location_name` varchar(45) NOT NULL,
  `location_rep` varchar(45) NOT NULL COMMENT 'Location - Person responsible for business communications.',
  `address_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`location_id`),
  KEY `location_fk_01_idx` (`client_id`),
  KEY `location_fk_02_idx` (`address_id`),
  KEY `location_fk_03_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`location_id`, `location_name`, `location_rep`, `address_id`, `client_id`, `phone_id`) VALUES
(1, 'Store 1', 'William Lawrence', 23, 4, 47),
(2, 'Store 2', 'Philip Garcia', 37, 2, 41),
(3, 'Store 3', 'Jason Rose', 19, 1, 5),
(4, 'Store 4', 'Sean Ryan', 16, 4, 8),
(5, 'Store 5', 'Richard Smith', 10, 4, 39),
(6, 'Store 6', 'Keith Jacobs', 10, 5, 47),
(7, 'Store 7', 'Carlos Flores', 49, 6, 27),
(8, 'Store 8', 'Sharon Sims', 33, 1, 2),
(9, 'Store 9', 'Gloria Alvarez', 12, 5, 21),
(10, 'Store 10', 'Marie Carter', 42, 4, 41),
(11, 'Store 11', 'Laura Davis', 12, 1, 39),
(12, 'Store 12', 'Brandon Carr', 23, 2, 34),
(13, 'Store 13', 'Deborah Kennedy', 29, 1, 45),
(14, 'Store 14', 'George Andrews', 30, 4, 16),
(15, 'Store 15', 'Diane Simpson', 18, 5, 28),
(16, 'Store 16', 'Lawrence Ruiz', 1, 4, 28),
(17, 'Store 17', 'Jeremy Lewis', 31, 5, 32),
(18, 'Store 18', 'Shawn Alvarez', 33, 7, 24),
(19, 'Store 19', 'Pamela Hughes', 37, 6, 3),
(20, 'Store 20', 'Russell Burton', 30, 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE IF NOT EXISTS `manufacturer` (
  `manufacturer_id` int(11) NOT NULL,
  `manufacturer_name` varchar(45) NOT NULL,
  PRIMARY KEY (`manufacturer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `manufacturer`
--

INSERT INTO `manufacturer` (`manufacturer_id`, `manufacturer_name`) VALUES
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
-- Table structure for table `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `order_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `order_date` date NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `order_fk_01_idx` (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`order_id`, `supplier_id`, `order_date`) VALUES
(1, 3, '2016-07-08'),
(2, 1, '2016-09-25'),
(3, 4, '2016-08-15'),
(4, 5, '2016-09-25'),
(5, 5, '2016-07-06'),
(6, 9, '2016-09-04'),
(7, 9, '2016-10-06'),
(8, 2, '2016-09-04'),
(9, 2, '2016-07-28'),
(10, 5, '2016-08-05'),
(11, 4, '2016-08-06'),
(12, 4, '2016-09-05'),
(13, 6, '2016-10-01'),
(14, 6, '2016-07-20'),
(15, 10, '2016-08-20'),
(16, 9, '2016-07-12'),
(17, 8, '2016-10-12'),
(18, 1, '2016-08-22'),
(19, 8, '2016-10-01'),
(20, 10, '2016-10-15');

-- --------------------------------------------------------

--
-- Table structure for table `order_product`
--

CREATE TABLE IF NOT EXISTS `order_product` (
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `isDamaged` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`order_id`,`product_id`),
  KEY `orderProduct_fk_02_idx` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `order_product`
--

INSERT INTO `order_product` (`order_id`, `product_id`, `quantity`, `isDamaged`) VALUES
(1, 2, 397, 0),
(1, 9, 437, 1),
(1, 15, 224, 1),
(1, 16, 423, 1),
(1, 18, 370, 1),
(1, 21, 204, 1),
(1, 26, 217, 1),
(1, 30, 316, 1),
(2, 30, 262, 0),
(3, 1, 200, 0),
(3, 10, 319, 0),
(3, 13, 146, 0),
(3, 16, 175, 0),
(4, 5, 197, 0),
(4, 7, 412, 0),
(4, 18, 470, 0),
(4, 26, 427, 0),
(5, 18, 188, 0),
(5, 19, 236, 0),
(5, 29, 372, 0),
(6, 3, 279, 0),
(6, 16, 283, 0),
(6, 18, 381, 0),
(6, 19, 351, 0),
(6, 28, 220, 0),
(6, 29, 460, 0),
(7, 5, 259, 0),
(7, 8, 493, 0),
(7, 9, 432, 0),
(7, 15, 121, 0),
(7, 16, 79, 0),
(7, 17, 400, 0),
(7, 24, 388, 0),
(8, 2, 174, 0),
(8, 9, 498, 0),
(8, 12, 376, 0),
(8, 28, 244, 0),
(9, 10, 317, 0),
(9, 16, 85, 0),
(9, 25, 345, 0),
(10, 18, 433, 0),
(10, 24, 142, 0),
(10, 25, 268, 0),
(11, 8, 177, 0),
(11, 13, 410, 0),
(11, 16, 98, 0),
(11, 23, 170, 0),
(12, 2, 108, 0),
(12, 15, 216, 0),
(12, 16, 77, 0),
(12, 18, 130, 0),
(12, 24, 264, 0),
(13, 11, 349, 0),
(13, 27, 248, 0),
(14, 10, 432, 0),
(14, 17, 142, 0),
(14, 21, 421, 0),
(15, 1, 328, 0),
(15, 13, 163, 0),
(15, 20, 117, 0),
(16, 2, 369, 0),
(16, 9, 175, 0),
(16, 10, 100, 0),
(16, 12, 489, 0),
(17, 12, 142, 0),
(17, 14, 243, 0),
(17, 26, 415, 0),
(17, 29, 157, 0),
(18, 2, 402, 0),
(18, 4, 135, 0),
(18, 12, 220, 0),
(18, 28, 377, 0),
(19, 1, 107, 0),
(19, 2, 130, 0),
(19, 7, 234, 0),
(19, 13, 500, 0),
(19, 14, 123, 0),
(20, 23, 327, 0);

-- --------------------------------------------------------

--
-- Table structure for table `permission_group`
--

CREATE TABLE IF NOT EXISTS `permission_group` (
  `permission_id` int(11) NOT NULL,
  `permission_group_name` varchar(45) NOT NULL,
  PRIMARY KEY (`permission_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `permission_group`
--

INSERT INTO `permission_group` (`permission_id`, `permission_group_name`) VALUES
(1, 'Warehouse Employee'),
(2, 'Receiving'),
(3, 'Shipping'),
(4, 'Operations Supervisor'),
(5, 'Warehouse Manager'),
(6, 'Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `phone`
--

CREATE TABLE IF NOT EXISTS `phone` (
  `phone_id` int(11) NOT NULL,
  `phone_number` tinytext NOT NULL,
  PRIMARY KEY (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `phone`
--

INSERT INTO `phone` (`phone_id`, `phone_number`) VALUES
(1, '(580)533-4290'),
(2, '(154)371-0267'),
(3, '(854)735-1190'),
(4, '(553)397-1996'),
(5, '(680)212-8791'),
(6, '(376)269-7822'),
(7, '(769)140-5402'),
(8, '(146)534-7673'),
(9, '(264)306-8677'),
(10, '(426)152-8570'),
(11, '(717)395-8025'),
(12, '(536)629-7658'),
(13, '(140)233-4202'),
(14, '(851)946-0093'),
(15, '(681)813-8404'),
(16, '(646)947-8242'),
(17, '(948)918-0644'),
(18, '(898)363-8566'),
(19, '(196)807-6307'),
(20, '(270)129-6109'),
(21, '(604)438-0748'),
(22, '(668)393-3328'),
(23, '(120)396-2963'),
(24, '(703)766-1583'),
(25, '(197)125-8800'),
(26, '(689)640-2186'),
(27, '(215)123-1925'),
(28, '(375)732-9065'),
(29, '(914)311-8373'),
(30, '(860)754-6951'),
(31, '(384)607-2719'),
(32, '(583)716-2756'),
(33, '(925)294-1557'),
(34, '(153)575-1258'),
(35, '(513)584-4581'),
(36, '(871)440-0104'),
(37, '(633)206-0690'),
(38, '(836)223-3156'),
(39, '(382)371-6216'),
(40, '(863)390-9536'),
(41, '(783)464-1035'),
(42, '(411)767-5431'),
(43, '(890)610-7147'),
(44, '(581)348-7579'),
(45, '(860)400-9218'),
(46, '(335)427-3993'),
(47, '(197)115-7452'),
(48, '(917)932-1937'),
(49, '(591)896-7629'),
(50, '(816)350-8478');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(45) NOT NULL,
  `product_price` double NOT NULL,
  `product_img_path` text NOT NULL,
  `product_stock` int(11) NOT NULL DEFAULT '100',
  `category_id` int(11) NOT NULL,
  `manufacturer_id` int(11) NOT NULL,
  `shelf_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  PRIMARY KEY (`product_id`),
  KEY `product_fk_01_idx` (`supplier_id`),
  KEY `product_fk_02_idx` (`manufacturer_id`),
  KEY `product_fk_03_idx` (`category_id`),
  KEY `product_fk_04_idx` (`shelf_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_id`, `product_name`, `product_price`, `product_img_path`, `product_stock`, `category_id`, `manufacturer_id`, `shelf_id`, `supplier_id`) VALUES
(1, '2x4GB Nature Valley DDR3 RAM', 23.97, 'ram.jpg', 70, 1, 2, 161, 5),
(2, '2x8GB KitKat DDR3 RAM', 31.36, 'ram.jpg', 0, 1, 1, 199, 3),
(3, '2x8GB Coffee Crisp DDR4 RAM', 42.54, 'ram.jpg', 21, 1, 10, 64, 3),
(4, 'Enterprise 4-Slot Motherboard', 83.29, 'motherboard.jpg', 137, 2, 4, 163, 8),
(5, 'Nimitz 4-Slot Motherboard', 133.45, 'motherboard.jpg', 64, 2, 9, 129, 8),
(6, 'Kitty Hawk 2-Slot Motherboard', 51.15, 'motherboard.jpg', 20, 2, 5, 85, 3),
(7, 'ATD Senna 6GB Video Card', 522.41, 'gpu.jpg', 331, 3, 6, 1, 6),
(8, 'GTZi Vettel 8GB Video Card', 823.43, 'gpu.jpg', 253, 3, 7, 172, 4),
(9, 'GTZ Clarkson 8GB Video Card', 781.09, 'gpu.jpg', 99, 3, 8, 41, 3),
(10, 'Quad-core 4.0GHz Socrates Processor', 691.23, 'cpu.jpg', 179, 4, 2, 238, 1),
(11, 'Quad-core 3.5GHz Plato Processor', 472.3, 'cpu.jpg', 336, 4, 2, 74, 2),
(12, 'Quad-core 4.0GHz Nietzsche Processor', 763.88, 'cpu.jpg', 340, 4, 9, 185, 6),
(13, 'Hummingbird 120GB SSD', 51.16, 'storage.jpg', 161, 5, 6, 6, 6),
(14, 'Pelican 2TB HDD', 82.23, 'storage.jpg', 372, 5, 1, 146, 4),
(15, 'Falcon 500GB SSD', 201.66, 'storage.jpg', 25, 5, 7, 19, 7),
(16, 'Franklin 650W PSU', 83.2, 'psu.jpg', 238, 6, 9, 225, 5),
(17, 'Faraday 450W PSU', 41.24, 'psu.jpg', 208, 6, 4, 211, 6),
(18, 'Tesla 650W PSU', 100.94, 'psu.jpg', 117, 6, 1, 170, 5),
(19, 'Redeemer 24" 1920x1080 Monitor', 333.42, 'display.jpg', 265, 7, 3, 183, 4),
(20, 'Liberty 27" 2560x1440 Monitor', 403.88, 'display.jpg', 206, 7, 2, 173, 6),
(21, 'Rushmore 24" 1920x1080 Monitor', 343.1, 'display.jpg', 129, 7, 4, 115, 5),
(22, 'Changdao Cherry MX Red Keyboard', 110.27, 'keyboard.jpg', 257, 8, 1, 150, 10),
(23, 'Claymore Cherry MX Brown Keyboard', 150.58, 'keyboard.jpg', 139, 8, 7, 73, 7),
(24, 'Scimitar Cherry MX Red Keyboard', 131.9, 'keyboard.jpg', 14, 8, 10, 221, 1),
(25, 'Rhino Optical Wired Mouse', 60.61, 'mouse.jpg', 275, 9, 8, 159, 4),
(26, 'Stag Optical Wired Mouse', 21.32, 'mouse.jpg', 147, 9, 7, 206, 10),
(27, 'Hercules Optical Wireless Mouse', 51.97, 'mouse.jpg', 127, 9, 8, 4, 5),
(28, 'XenoWare Gaming PC', 2501.53, 'desktop.jpg', 197, 10, 2, 53, 8),
(29, 'AZUZ Workstation PC', 1402, 'desktop.jpg', 43, 10, 3, 133, 9),
(30, 'Pewlett Hackard Tower PC', 1503.13, 'desktop.jpg', 311, 10, 10, 216, 7),
(31, 'Blasterman Speakers', 32.61, 'accessory.jpg', 100, 11, 6, 45, 1),
(32, 'Big Brother Webcam', 23.21, 'accessory.jpg', 100, 11, 8, 56, 1),
(33, 'NSA Headphones', 52.29, 'accessory.jpg', 100, 11, 7, 98, 4);

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE IF NOT EXISTS `section` (
  `section_id` int(11) NOT NULL,
  `section_name` varchar(35) NOT NULL,
  PRIMARY KEY (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`section_id`, `section_name`) VALUES
(1, 'CENTRAL'),
(2, 'NORTH'),
(3, 'WEST'),
(4, 'SOUTH');

-- --------------------------------------------------------

--
-- Table structure for table `shelf`
--

CREATE TABLE IF NOT EXISTS `shelf` (
  `shelf_id` int(11) NOT NULL,
  `shelf_number` int(3) NOT NULL,
  `aisle_id` int(11) NOT NULL,
  PRIMARY KEY (`shelf_id`),
  KEY `shelf_fk_01_idx` (`aisle_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `shelf`
--

INSERT INTO `shelf` (`shelf_id`, `shelf_number`, `aisle_id`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 1),
(6, 6, 1),
(7, 1, 1),
(8, 2, 1),
(9, 3, 1),
(10, 4, 1),
(11, 5, 1),
(12, 6, 1),
(13, 1, 1),
(14, 2, 1),
(15, 3, 1),
(16, 4, 1),
(17, 5, 1),
(18, 6, 1),
(19, 1, 1),
(20, 2, 1),
(21, 3, 1),
(22, 4, 1),
(23, 5, 1),
(24, 6, 1),
(25, 1, 1),
(26, 2, 1),
(27, 3, 1),
(28, 4, 1),
(29, 5, 1),
(30, 6, 1),
(31, 1, 1),
(32, 2, 1),
(33, 3, 1),
(34, 4, 1),
(35, 5, 1),
(36, 6, 1),
(37, 1, 1),
(38, 2, 1),
(39, 3, 1),
(40, 4, 1),
(41, 5, 1),
(42, 6, 1),
(43, 1, 1),
(44, 2, 1),
(45, 3, 1),
(46, 4, 1),
(47, 5, 1),
(48, 6, 1),
(49, 1, 1),
(50, 2, 1),
(51, 3, 1),
(52, 4, 1),
(53, 5, 1),
(54, 6, 1),
(55, 1, 1),
(56, 2, 1),
(57, 3, 1),
(58, 4, 1),
(59, 5, 1),
(60, 6, 1),
(61, 1, 1),
(62, 2, 1),
(63, 3, 1),
(64, 4, 1),
(65, 5, 1),
(66, 6, 1),
(67, 1, 1),
(68, 2, 1),
(69, 3, 1),
(70, 4, 1),
(71, 5, 1),
(72, 6, 1),
(73, 1, 1),
(74, 2, 1),
(75, 3, 1),
(76, 4, 1),
(77, 5, 1),
(78, 6, 1),
(79, 1, 1),
(80, 2, 1),
(81, 3, 1),
(82, 4, 1),
(83, 5, 1),
(84, 6, 1),
(85, 1, 1),
(86, 2, 1),
(87, 3, 1),
(88, 4, 1),
(89, 5, 1),
(90, 6, 1),
(91, 1, 2),
(92, 2, 2),
(93, 3, 2),
(94, 4, 2),
(95, 5, 2),
(96, 6, 2),
(97, 1, 2),
(98, 2, 2),
(99, 3, 2),
(100, 4, 2),
(101, 5, 2),
(102, 6, 2),
(103, 1, 2),
(104, 2, 2),
(105, 3, 2),
(106, 4, 2),
(107, 5, 2),
(108, 6, 2),
(109, 1, 2),
(110, 2, 2),
(111, 3, 2),
(112, 4, 2),
(113, 5, 2),
(114, 6, 2),
(115, 1, 2),
(116, 2, 2),
(117, 3, 2),
(118, 4, 2),
(119, 5, 2),
(120, 6, 3),
(121, 1, 3),
(122, 2, 3),
(123, 3, 3),
(124, 4, 3),
(125, 5, 3),
(126, 6, 3),
(127, 1, 3),
(128, 2, 3),
(129, 3, 3),
(130, 4, 3),
(131, 5, 3),
(132, 6, 3),
(133, 1, 3),
(134, 2, 3),
(135, 3, 3),
(136, 4, 3),
(137, 5, 3),
(138, 6, 3),
(139, 1, 3),
(140, 2, 3),
(141, 3, 3),
(142, 4, 3),
(143, 5, 3),
(144, 6, 3),
(145, 1, 3),
(146, 2, 3),
(147, 3, 3),
(148, 4, 3),
(149, 5, 3),
(150, 6, 3),
(151, 1, 3),
(152, 2, 3),
(153, 3, 3),
(154, 4, 3),
(155, 5, 3),
(156, 6, 3),
(157, 1, 3),
(158, 2, 3),
(159, 3, 3),
(160, 4, 3),
(161, 5, 3),
(162, 6, 3),
(163, 1, 3),
(164, 2, 3),
(165, 3, 3),
(166, 4, 3),
(167, 5, 3),
(168, 6, 3),
(169, 1, 3),
(170, 2, 3),
(171, 3, 3),
(172, 4, 3),
(173, 5, 3),
(174, 6, 3),
(175, 1, 3),
(176, 2, 3),
(177, 3, 3),
(178, 4, 3),
(179, 5, 3),
(180, 6, 4),
(181, 1, 4),
(182, 2, 4),
(183, 3, 4),
(184, 4, 4),
(185, 5, 4),
(186, 6, 4),
(187, 1, 4),
(188, 2, 4),
(189, 3, 4),
(190, 4, 4),
(191, 5, 4),
(192, 6, 4),
(193, 1, 4),
(194, 2, 4),
(195, 3, 4),
(196, 4, 4),
(197, 5, 4),
(198, 6, 4),
(199, 1, 4),
(200, 2, 4),
(201, 3, 4),
(202, 4, 4),
(203, 5, 4),
(204, 6, 4),
(205, 1, 4),
(206, 2, 4),
(207, 3, 4),
(208, 4, 4),
(209, 5, 4),
(210, 6, 4),
(211, 1, 4),
(212, 2, 4),
(213, 3, 4),
(214, 4, 4),
(215, 5, 4),
(216, 6, 4),
(217, 1, 4),
(218, 2, 4),
(219, 3, 4),
(220, 4, 4),
(221, 5, 4),
(222, 6, 4),
(223, 1, 4),
(224, 2, 4),
(225, 3, 4),
(226, 4, 4),
(227, 5, 4),
(228, 6, 4),
(229, 1, 4),
(230, 2, 4),
(231, 3, 4),
(232, 4, 4),
(233, 5, 4),
(234, 6, 4),
(235, 1, 4),
(236, 2, 4),
(237, 3, 4),
(238, 4, 4),
(239, 5, 4),
(240, 6, 4);

-- --------------------------------------------------------

--
-- Table structure for table `shipment`
--

CREATE TABLE IF NOT EXISTS `shipment` (
  `shipment_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  `shipment_date` date NOT NULL,
  `hasShipped` tinyint(1) NOT NULL,
  PRIMARY KEY (`shipment_id`),
  KEY `shipment_fk_01_idx` (`location_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `shipment`
--

INSERT INTO `shipment` (`shipment_id`, `location_id`, `shipment_date`, `hasShipped`) VALUES
(1, 4, '2016-08-16', 1),
(2, 4, '2016-08-01', 1),
(3, 8, '2016-07-19', 1),
(4, 3, '2016-07-25', 1),
(5, 8, '2016-08-01', 1),
(6, 4, '2016-10-16', 1),
(7, 6, '2016-10-11', 1),
(8, 15, '2016-09-17', 1),
(9, 9, '2016-08-19', 1),
(10, 13, '2016-08-08', 1),
(11, 9, '2016-09-19', 1),
(12, 20, '2016-08-16', 1),
(13, 16, '2016-08-08', 1),
(14, 16, '2016-09-26', 1),
(15, 4, '2016-08-21', 1),
(16, 18, '2016-10-25', 1),
(17, 10, '2016-08-31', 1),
(18, 12, '2016-10-02', 1),
(19, 17, '2016-09-13', 1),
(20, 14, '2016-09-14', 1),
(21, 4, '2016-11-11', 1),
(22, 10, '2016-11-08', 1),
(23, 19, '2016-11-23', 0),
(24, 12, '2016-11-06', 0),
(25, 1, '2016-11-28', 0),
(26, 1, '2016-11-23', 1),
(27, 9, '2016-11-23', 1),
(28, 1, '2016-11-23', 1),
(29, 13, '2016-11-23', 0),
(30, 16, '2016-11-24', 1),
(31, 1, '2016-11-24', 0);

-- --------------------------------------------------------

--
-- Table structure for table `shipment_product`
--

CREATE TABLE IF NOT EXISTS `shipment_product` (
  `shipment_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`shipment_id`,`product_id`),
  KEY `shipProduct_fk_02_idx` (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `shipment_product`
--

INSERT INTO `shipment_product` (`shipment_id`, `product_id`, `quantity`) VALUES
(1, 2, 169),
(1, 17, 305),
(1, 19, 298),
(1, 23, 411),
(1, 29, 267),
(1, 30, 293),
(2, 1, 195),
(2, 2, 390),
(2, 3, 276),
(2, 12, 420),
(2, 14, 496),
(2, 21, 115),
(2, 27, 394),
(3, 5, 158),
(3, 11, 483),
(3, 15, 464),
(4, 4, 448),
(4, 7, 61),
(4, 16, 431),
(4, 23, 225),
(5, 7, 235),
(5, 17, 82),
(6, 3, 253),
(6, 24, 139),
(6, 25, 229),
(6, 29, 100),
(7, 3, 235),
(7, 13, 475),
(7, 17, 211),
(8, 12, 100),
(9, 8, 421),
(9, 29, 435),
(10, 6, 254),
(10, 29, 306),
(10, 30, 188),
(11, 24, 143),
(12, 12, 256),
(12, 17, 121),
(12, 21, 305),
(12, 29, 53),
(13, 11, 412),
(13, 14, 152),
(13, 18, 185),
(14, 4, 180),
(14, 10, 62),
(14, 23, 270),
(14, 30, 215),
(15, 2, 64),
(15, 6, 432),
(15, 18, 445),
(15, 21, 317),
(16, 3, 409),
(16, 6, 208),
(16, 18, 182),
(16, 21, 390),
(17, 15, 300),
(18, 3, 55),
(18, 10, 472),
(18, 20, 464),
(19, 7, 280),
(19, 16, 80),
(19, 19, 140),
(19, 20, 435),
(20, 5, 383),
(20, 8, 360),
(20, 15, 423),
(20, 16, 356),
(20, 17, 310),
(20, 21, 403),
(20, 29, 261),
(21, 1, 140),
(21, 16, 74),
(21, 17, 452),
(21, 20, 482),
(21, 23, 300),
(22, 4, 494),
(22, 18, 201),
(22, 19, 265),
(23, 3, 121),
(23, 13, 166),
(23, 22, 271),
(23, 24, 434),
(23, 27, 271),
(23, 28, 99),
(24, 7, 236),
(24, 9, 381),
(24, 10, 209),
(24, 11, 417),
(24, 13, 88),
(24, 25, 250),
(24, 26, 314),
(25, 3, 300),
(25, 15, 139),
(25, 16, 195),
(25, 17, 441),
(25, 27, 240),
(26, 1, 45),
(26, 2, 23),
(26, 12, 23),
(27, 12, 23),
(28, 1, 10),
(29, 11, 423),
(29, 12, 456),
(30, 1, 10),
(31, 1, 12),
(31, 3, 23);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(45) NOT NULL,
  `supplier_rep` varchar(45) NOT NULL COMMENT 'Supplier - Person responsible for business communications.',
  `supplier_email` varchar(45) NOT NULL,
  `address_id` int(11) NOT NULL,
  `phone_id` int(11) NOT NULL,
  PRIMARY KEY (`supplier_id`),
  KEY `supplier_fk_01_idx` (`address_id`),
  KEY `supplier_fk_02_idx` (`phone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `supplier_name`, `supplier_rep`, `supplier_email`, `address_id`, `phone_id`) VALUES
(1, 'Towne-Auer', 'Debra Bryant', 'dbryant0@furl.net', 16, 36),
(2, 'Stoltenberg, Bernier and Blick', 'Clarence Rivera', 'crivera1@alibaba.com', 46, 13),
(3, 'Collier, Quigley and Weber', 'Edward Davis', 'edavis2@studiopress.com', 12, 6),
(4, 'Ortiz-Kub', 'Alice Thomas', 'athomas3@virginia.edu', 1, 24),
(5, 'Bednar, Purdy and Rempel', 'Kevin Willis', 'kwillis4@csmonitor.com', 34, 11),
(6, 'Rau-Daniel', 'Paul Diaz', 'pdiaz5@wordpress.com', 31, 39),
(7, 'Mueller Group', 'Betty White', 'bwhite6@gmpg.org', 19, 34),
(8, 'Shanahan and Sons', 'Shawn Sims', 'ssims7@abc.net.au', 48, 9),
(9, 'Stamm Group', 'Debra Adams', 'dadams8@myspace.com', 12, 47),
(10, 'Hermann LLC', 'Justin Rogers', 'jrogers9@360.cn', 14, 29);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `address`
--
ALTER TABLE `address`
  ADD CONSTRAINT `address_fk_01` FOREIGN KEY (`city_id`) REFERENCES `city` (`city_id`) ON UPDATE CASCADE;

--
-- Constraints for table `aisle`
--
ALTER TABLE `aisle`
  ADD CONSTRAINT `aisle_fk_01` FOREIGN KEY (`section_id`) REFERENCES `section` (`section_id`) ON UPDATE CASCADE;

--
-- Constraints for table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_fk_01` FOREIGN KEY (`phone_id`) REFERENCES `phone` (`phone_id`) ON UPDATE CASCADE;

--
-- Constraints for table `client_location`
--
ALTER TABLE `client_location`
  ADD CONSTRAINT `clientLoc_fk_01` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `clientLoc_fk_02` FOREIGN KEY (`location_id`) REFERENCES `location` (`location_id`) ON UPDATE CASCADE;

--
-- Constraints for table `employee_creds`
--
ALTER TABLE `employee_creds`
  ADD CONSTRAINT `empCred_fk_01` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `empCred_fk_02` FOREIGN KEY (`permission_id`) REFERENCES `permission_group` (`permission_id`) ON UPDATE CASCADE;

--
-- Constraints for table `employee_phone`
--
ALTER TABLE `employee_phone`
  ADD CONSTRAINT `empPhone_fk_01` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `empPhone_fk_02` FOREIGN KEY (`phone_id`) REFERENCES `phone` (`phone_id`) ON UPDATE CASCADE;

--
-- Constraints for table `location`
--
ALTER TABLE `location`
  ADD CONSTRAINT `location_fk_01` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `location_fk_02` FOREIGN KEY (`address_id`) REFERENCES `address` (`address_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `location_fk_03` FOREIGN KEY (`phone_id`) REFERENCES `phone` (`phone_id`) ON UPDATE CASCADE;

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_fk_01` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`) ON UPDATE CASCADE;

--
-- Constraints for table `order_product`
--
ALTER TABLE `order_product`
  ADD CONSTRAINT `orderProduct_fk_01` FOREIGN KEY (`order_id`) REFERENCES `order` (`order_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `orderProduct_fk_02` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON UPDATE CASCADE;

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_fk_01` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_02` FOREIGN KEY (`manufacturer_id`) REFERENCES `manufacturer` (`manufacturer_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_03` FOREIGN KEY (`category_id`) REFERENCES `category` (`category_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `product_fk_04` FOREIGN KEY (`shelf_id`) REFERENCES `shelf` (`shelf_id`) ON UPDATE CASCADE;

--
-- Constraints for table `shelf`
--
ALTER TABLE `shelf`
  ADD CONSTRAINT `shelf_fk_01` FOREIGN KEY (`aisle_id`) REFERENCES `aisle` (`aisle_id`) ON UPDATE CASCADE;

--
-- Constraints for table `shipment`
--
ALTER TABLE `shipment`
  ADD CONSTRAINT `shipment_fk_01` FOREIGN KEY (`location_id`) REFERENCES `location` (`location_id`) ON UPDATE CASCADE;

--
-- Constraints for table `shipment_product`
--
ALTER TABLE `shipment_product`
  ADD CONSTRAINT `shipProduct_fk_01` FOREIGN KEY (`shipment_id`) REFERENCES `shipment` (`shipment_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `shipProduct_fk_02` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON UPDATE CASCADE;

--
-- Constraints for table `supplier`
--
ALTER TABLE `supplier`
  ADD CONSTRAINT `supplier_fk_01` FOREIGN KEY (`address_id`) REFERENCES `address` (`address_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_fk_02` FOREIGN KEY (`phone_id`) REFERENCES `phone` (`phone_id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
