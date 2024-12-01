-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2024 at 05:15 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentrecord`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `ID` int(11) NOT NULL,
  `Idno` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Gender` varchar(255) NOT NULL,
  `College` varchar(255) NOT NULL,
  `Course` varchar(255) NOT NULL,
  `Yearlevel` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`ID`, `Idno`, `Name`, `Gender`, `College`, `Course`, `Yearlevel`, `Password`) VALUES
(8, '123', 'Avien', 'Female', 'CCS', 'BSIT', '4', '123'),
(9, '246', 'Ashton', 'Female', 'CBA', 'BSMT', '1', '123'),
(10, '24-0000-247', 'Ainsley', 'Male', 'CBA', 'BSA', '1', 'f6ead54f'),
(11, '24-0000-248', 'AAAA', 'Male', 'CBA', 'BSA', '2', 'cdcb20af'),
(12, '24-0000-249', 'asdasd', 'Male', 'CCS', 'MMA', '3', '$2y$10$.Nwr/zoSZiHxMhoFkm3b7OdQzoGd3lwSofdI7Cj4kBJExtCZok8US'),
(13, '24-0000-250', 'BAAA', 'Female', 'CON', 'BSN', '1', '$2y$10$JhdEwYk9PYqlqqjIkoZzke72mXiG6Em2jEui.nDuf8ZdVgPEACA8e');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblstudents`
--
ALTER TABLE `tblstudents`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblstudents`
--
ALTER TABLE `tblstudents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
