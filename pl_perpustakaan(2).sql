-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2022 at 07:30 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pl_perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggota`
--

CREATE TABLE `anggota` (
  `kd_anggota` int(3) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `anggota`
--

INSERT INTO `anggota` (`kd_anggota`, `nama`, `password`) VALUES
(10, 'arman maulana', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `kd_buku` int(11) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `kd_jenis_buku` int(3) NOT NULL,
  `kd_penerbit` int(3) NOT NULL,
  `kd_pengarang` int(3) NOT NULL,
  `stok` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`kd_buku`, `judul`, `kd_jenis_buku`, `kd_penerbit`, `kd_pengarang`, `stok`) VALUES
(34, 'piknik seru', 4, 4, 21, 1),
(35, 'beruang kutub dan panda', 4, 6, 20, 10),
(37, 'menyederhanakan cinta', 4, 6, 19, 100);

-- --------------------------------------------------------

--
-- Table structure for table `jenis_buku`
--

CREATE TABLE `jenis_buku` (
  `kd_jenis_buku` int(3) NOT NULL,
  `nama` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jenis_buku`
--

INSERT INTO `jenis_buku` (`kd_jenis_buku`, `nama`) VALUES
(3, 'SCIENCE'),
(4, 'KOMEDI');

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `kd_peminjaman` int(11) NOT NULL,
  `kd_anggota` int(3) NOT NULL,
  `kd_buku` int(11) NOT NULL,
  `jumlah_pinjam` int(1) NOT NULL,
  `tanggal_pinjam` date DEFAULT current_timestamp(),
  `date_kmbali` date DEFAULT NULL,
  `jumlah_kembali` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `peminjaman`
--

INSERT INTO `peminjaman` (`kd_peminjaman`, `kd_anggota`, `kd_buku`, `jumlah_pinjam`, `tanggal_pinjam`, `date_kmbali`, `jumlah_kembali`) VALUES
(18, 10, 34, 4, '2022-04-22', '2022-04-22', 4),
(19, 10, 34, 3, '2022-04-22', '2022-04-22', 3);

--
-- Triggers `peminjaman`
--
DELIMITER $$
CREATE TRIGGER `buku_keluar` AFTER INSERT ON `peminjaman` FOR EACH ROW BEGIN
UPDATE buku set stok = stok - new.jumlah_pinjam
WHERE kd_buku = NEW.kd_buku;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `kmbali` AFTER INSERT ON `peminjaman` FOR EACH ROW BEGIN
UPDATE buku set stok = stok + new.jumlah_kembali
WHERE kd_buku = NEW.kd_buku
and date_kmbali = now();
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `penerbit`
--

CREATE TABLE `penerbit` (
  `kd_penerbit` int(3) NOT NULL,
  `nama` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penerbit`
--

INSERT INTO `penerbit` (`kd_penerbit`, `nama`) VALUES
(3, 'Gramedia Pustaka Utama'),
(4, 'Mizan Pustaka'),
(5, 'Bentang Pustaka'),
(6, 'erlangga'),
(7, 'Republika');

-- --------------------------------------------------------

--
-- Table structure for table `pengarang`
--

CREATE TABLE `pengarang` (
  `kd_pengarang` int(3) NOT NULL,
  `nama` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pengarang`
--

INSERT INTO `pengarang` (`kd_pengarang`, `nama`) VALUES
(18, 'GRIYA STATISTIK'),
(19, 'Dewi Lestari.'),
(20, 'Raditya Dika'),
(21, 'Andrea Hirata');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `kd_users` int(3) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `status` int(1) NOT NULL,
  `level` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`kd_users`, `nama`, `username`, `password`, `status`, `level`) VALUES
(4, 'andre', 'andreskak', 'polibek22', 1, 2),
(5, 'kepala', 'kepala', 'kepala', 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`kd_anggota`);

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`kd_buku`),
  ADD KEY `kd_jenis_buku` (`kd_jenis_buku`),
  ADD KEY `kd_penerbit` (`kd_penerbit`),
  ADD KEY `kd_penerbit_2` (`kd_penerbit`),
  ADD KEY `kd_pengarang` (`kd_pengarang`);

--
-- Indexes for table `jenis_buku`
--
ALTER TABLE `jenis_buku`
  ADD PRIMARY KEY (`kd_jenis_buku`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`kd_peminjaman`),
  ADD KEY `kd_anggota` (`kd_anggota`),
  ADD KEY `kd_buku` (`kd_buku`);

--
-- Indexes for table `penerbit`
--
ALTER TABLE `penerbit`
  ADD PRIMARY KEY (`kd_penerbit`);

--
-- Indexes for table `pengarang`
--
ALTER TABLE `pengarang`
  ADD PRIMARY KEY (`kd_pengarang`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`kd_users`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `anggota`
--
ALTER TABLE `anggota`
  MODIFY `kd_anggota` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `buku`
--
ALTER TABLE `buku`
  MODIFY `kd_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `jenis_buku`
--
ALTER TABLE `jenis_buku`
  MODIFY `kd_jenis_buku` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `peminjaman`
--
ALTER TABLE `peminjaman`
  MODIFY `kd_peminjaman` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `penerbit`
--
ALTER TABLE `penerbit`
  MODIFY `kd_penerbit` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `pengarang`
--
ALTER TABLE `pengarang`
  MODIFY `kd_pengarang` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `kd_users` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `buku`
--
ALTER TABLE `buku`
  ADD CONSTRAINT `buku_ibfk_1` FOREIGN KEY (`kd_penerbit`) REFERENCES `penerbit` (`kd_penerbit`),
  ADD CONSTRAINT `buku_ibfk_2` FOREIGN KEY (`kd_pengarang`) REFERENCES `pengarang` (`kd_pengarang`),
  ADD CONSTRAINT `buku_ibfk_3` FOREIGN KEY (`kd_jenis_buku`) REFERENCES `jenis_buku` (`kd_jenis_buku`);

--
-- Constraints for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD CONSTRAINT `kdbk_ibfk4` FOREIGN KEY (`kd_buku`) REFERENCES `buku` (`kd_buku`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `peminjaman_ibfk_1` FOREIGN KEY (`kd_anggota`) REFERENCES `anggota` (`kd_anggota`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
