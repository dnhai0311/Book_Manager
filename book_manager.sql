-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 19, 2024 at 03:34 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `book_manager`

CREATE DATABASE IF NOT EXISTS `book_manager` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `book_manager`;

--

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE `authors` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`id`, `name`) VALUES
(1, 'Nguyễn Nhật Ánh'),
(2, 'Haruki Murakami'),
(3, 'J.K. Rowling'),
(4, 'Marc Levy'),
(5, 'Tô Hoài'),
(6, 'Nguyễn Khải'),
(7, 'Nguyễn Minh Châu'),
(8, 'Nguyễn Ngọc Tư'),
(9, 'Nguyễn Bảo'),
(10, 'Trương Anh Ngọc'),
(11, 'Lê Minh Quốc'),
(12, 'Phan Hồn Nhiên'),
(13, 'Đỗ Bích Thúy'),
(14, 'Lê Lộc'),
(15, 'Vũ Trọng Phụng');

-- --------------------------------------------------------

--
-- Table structure for table `booksales`
--

CREATE TABLE `booksales` (
  `id` int(11) NOT NULL,
  `title` varchar(50) NOT NULL,
  `image` varchar(100) NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `quantity` int(11) NOT NULL,
  `author` int(11) NOT NULL,
  `publisher` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `booksales`
--

INSERT INTO `booksales` (`id`, `title`, `image`, `price`, `quantity`, `author`, `publisher`) VALUES
(1, 'Cô Gái Đến Từ Hôm Qua', '..\\..\\..\\Images\\1.jpg', 150000, 100, 1, 1),
(2, 'Kafka Bên Bờ Biển', '..\\..\\..\\Images\\2.jpg', 180000, 50, 2, 2),
(3, 'Harry Potter và Hòn Đá Phù Thủy', '..\\..\\..\\Images\\3.jpg', 200000, 30, 3, 2),
(4, 'Người Đàn Ông Bán Frites', '..\\..\\..\\Images\\4.jpg', 160000, 20, 4, 3),
(5, 'Dế Mèn Phiêu Lưu Ký', '..\\..\\..\\Images\\5.jpg', 120000, 150, 5, 4),
(6, 'Mắt Biếc', '..\\..\\..\\Images\\6.jpg', 200000, 75, 1, 1),
(7, 'Chuyện Chàng Dại Kỹ', '..\\..\\..\\Images\\7.jpg', 170000, 50, 6, 2),
(8, 'Chiếc Lược Ngà', '..\\..\\..\\Images\\8.jpg', 100000, 120, 5, 3),
(9, 'Người Đàn Ông Đánh Đu', '..\\..\\..\\Images\\default-book-img.jpg', 190000, 40, 4, 4),
(10, 'Đất Rừng Phương Nam', '..\\..\\..\\Images\\default-book-img.jpg', 160000, 80, 8, 5),
(11, 'Cánh Đồng Bất Tận', '..\\..\\..\\Images\\default-book-img.jpg', 150000, 30, 9, 6),
(12, 'Bà Dầu Dành Cho Tâm Hồn', '..\\..\\..\\Images\\default-book-img.jpg', 220000, 25, 10, 7),
(13, 'Về Dưới Mái Nhà', '..\\..\\..\\Images\\default-book-img.jpg', 140000, 60, 11, 8),
(14, 'Dưới Chân Bàn Thờ', '..\\..\\..\\Images\\default-book-img.jpg', 130000, 70, 12, 9),
(15, 'Sống Chậm', '..\\..\\..\\Images\\default-book-img.jpg', 250000, 13, 11, 8);

-- --------------------------------------------------------

--
-- Table structure for table `publishers`
--

CREATE TABLE `publishers` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `publishers`
--

INSERT INTO `publishers` (`id`, `name`) VALUES
(1, 'Nhà xuất bản Trẻ'),
(2, 'Nhà xuất bản Kim Đồng'),
(3, 'Nhà xuất bản Hội Nhà văn'),
(4, 'Nhà xuất bản Phụ nữ'),
(5, 'Nhà xuất bản Văn học'),
(6, 'Nhà xuất bản Giáo dục'),
(7, 'Nhà xuất bản Văn học'),
(8, 'Nhà xuất bản Thanh Niên'),
(9, 'Nhà xuất bản Đại học Quốc gia '),
(10, 'Nhà xuất bản Kim Đồng');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `booksales`
--
ALTER TABLE `booksales`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `authors`
--
ALTER TABLE `authors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `publishers`
--
ALTER TABLE `publishers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
