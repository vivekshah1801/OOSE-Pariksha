-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2020 at 10:09 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `parikshav1`
--

-- --------------------------------------------------------

--
-- Table structure for table `exam`
--

CREATE TABLE `exam` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `code` varchar(10) NOT NULL,
  `description` varchar(800) NOT NULL,
  `qcount` int(5) NOT NULL,
  `duration` int(5) NOT NULL,
  `marks` int(3) NOT NULL,
  `negativemarks` int(3) DEFAULT NULL,
  `isActive` int(11) NOT NULL DEFAULT 1,
  `createdtime` datetime NOT NULL DEFAULT current_timestamp(),
  `userid` int(11) DEFAULT NULL,
  `starttime` datetime NOT NULL,
  `endtime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `exam`
--

INSERT INTO `exam` (`id`, `name`, `code`, `description`, `qcount`, `duration`, `marks`, `negativemarks`, `isActive`, `createdtime`, `userid`, `starttime`, `endtime`) VALUES
(3, 'NIS', 'NISs1', 'this is desc of nis exam', 10, 30, 1, 0, 1, '2020-04-19 02:34:13', 1, '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(4, 'OOSe', 'oose1', 'jsgdfhhdb', 10, 20, 2, -1, 1, '2020-04-19 12:22:12', 1, '0000-00-00 00:00:00', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `id` int(11) NOT NULL,
  `q` varchar(200) NOT NULL,
  `op1` varchar(100) NOT NULL,
  `op2` varchar(100) NOT NULL,
  `op3` varchar(100) DEFAULT NULL,
  `op4` varchar(100) DEFAULT NULL,
  `opCorrect` varchar(100) NOT NULL,
  `examid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE `tb_user` (
  `UserId` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `UserEmail` varchar(50) NOT NULL,
  `UserPassword` varchar(50) NOT NULL,
  `UserLastLogin` datetime NOT NULL DEFAULT current_timestamp(),
  `UserType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`UserId`, `UserName`, `UserEmail`, `UserPassword`, `UserLastLogin`, `UserType`) VALUES
(1, 'vivek', 'vivek@gmail.com', 'vivek123', '2020-04-17 21:27:33', 'student'),
(2, 'vivek', 'vivek@vivek.com', 'vivek123', '2020-04-18 12:04:40', 'student'),
(3, 'ami', 'ami@ami.com', 'ami123', '2020-04-18 19:10:33', 'student'),
(4, 'admin', 'admin@admin.com', 'admin123', '2020-04-18 19:11:15', 'admin'),
(5, 'hemant', 'hemant@hemant.com', 'hemant123', '2020-04-18 20:26:03', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `userexam`
--

CREATE TABLE `userexam` (
  `id` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `examid` int(11) NOT NULL,
  `marksScored` int(11) NOT NULL DEFAULT -1,
  `examTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `exam`
--
ALTER TABLE `exam`
  ADD PRIMARY KEY (`id`),
  ADD KEY `UserFK` (`userid`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ExamFK` (`examid`);

--
-- Indexes for table `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `userexam`
--
ALTER TABLE `userexam`
  ADD PRIMARY KEY (`id`),
  ADD KEY `UserFKuserexam` (`userid`),
  ADD KEY `ExamFKuserexam` (`examid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `exam`
--
ALTER TABLE `exam`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_user`
--
ALTER TABLE `tb_user`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `userexam`
--
ALTER TABLE `userexam`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `exam`
--
ALTER TABLE `exam`
  ADD CONSTRAINT `UserFK` FOREIGN KEY (`userid`) REFERENCES `tb_user` (`UserId`) ON DELETE SET NULL;

--
-- Constraints for table `question`
--
ALTER TABLE `question`
  ADD CONSTRAINT `ExamFK` FOREIGN KEY (`examid`) REFERENCES `exam` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `userexam`
--
ALTER TABLE `userexam`
  ADD CONSTRAINT `ExamFKuserexam` FOREIGN KEY (`examid`) REFERENCES `exam` (`id`),
  ADD CONSTRAINT `UserFKuserexam` FOREIGN KEY (`userid`) REFERENCES `tb_user` (`UserId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
