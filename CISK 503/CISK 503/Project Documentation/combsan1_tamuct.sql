-- phpMyAdmin SQL Dump
-- version 4.3.8
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 24, 2017 at 02:37 PM
-- Server version: 5.6.32-78.1-log
-- PHP Version: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `combsan1_tamuct`
--

-- --------------------------------------------------------

--
-- Table structure for table `AccountLevel`
--

CREATE TABLE IF NOT EXISTS `AccountLevel` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `AccountLevel`
--

INSERT INTO `AccountLevel` (`ID`, `Name`) VALUES
(2, 'Administation'),
(1, 'Circulation'),
(0, 'User');

-- --------------------------------------------------------

--
-- Table structure for table `Author`
--

CREATE TABLE IF NOT EXISTS `Author` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=132 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Author`
--

INSERT INTO `Author` (`ID`, `Name`) VALUES
(120, 'Ackroyd, Peter'),
(85, 'Aczel, Amir'),
(37, 'Archer, Jeffery'),
(87, 'Bach, Richard'),
(103, 'Baz-Zohar, Michael'),
(48, 'BBC'),
(113, 'Bell, E T'),
(77, 'Bodanis, David'),
(53, 'Bradsky, Gary'),
(88, 'Braithwaite'),
(60, 'Brown, Dan'),
(28, 'Camus, Albert'),
(33, 'Capra, Fritjof'),
(130, 'Card, Orson Scott'),
(23, 'Conway, Drew'),
(104, 'Corbett, Jim'),
(26, 'Cormen, Thomas'),
(40, 'Crichton, Michael'),
(67, 'Dalrymple, William'),
(114, 'Dawkins, Richard'),
(27, 'Deb, Siddhartha'),
(106, 'Deshpande P L'),
(44, 'Deshpande, P L'),
(66, 'Deshpande, Sunita'),
(96, 'Devlin, Keith'),
(129, 'Dickens, Charles'),
(123, 'Dickinson, Peter'),
(59, 'Dostoevsky, Fyodor'),
(109, 'Downey, Allen'),
(29, 'Doyle, Arthur Conan'),
(76, 'Drucker, Peter'),
(4, 'Dubner, Stephen'),
(94, 'Duda, Hart'),
(43, 'Durant, Will'),
(91, 'Durrell, Gerald'),
(49, 'Dylan, Bob'),
(128, 'Eddins, Steve'),
(15, 'Eraly, Abraham'),
(34, 'Feynman, Richard'),
(84, 'Fisk, Robert'),
(31, 'Follett, Ken'),
(2, 'Foreman, John'),
(55, 'Forsyth, David'),
(36, 'Forsyth, Frederick'),
(108, 'Franco, Sergio'),
(95, 'Friedman, Thomas'),
(75, 'Gardner, Earle Stanley'),
(69, 'Garg, Sanjay'),
(131, 'George Foreman'),
(62, 'Ghosh, Amitav'),
(97, 'Gleick, James'),
(79, 'Gordon, Richard'),
(1, 'Goswami, Jaideva'),
(52, 'Greene, W. H.'),
(45, 'Grisham, John'),
(50, 'Gupta, Madan'),
(63, 'Hansberry, Lorraine'),
(74, 'Harris, Sam'),
(3, 'Hawking, Stephen'),
(101, 'Haykin, Simon'),
(20, 'Heisenberg, Werner'),
(47, 'Heller, Joseph'),
(35, 'Hemingway, Ernest'),
(32, 'Hitler, Adolf'),
(78, 'Hugo, Victor'),
(86, 'Huntington, Samuel'),
(125, 'Huxley, Aldous'),
(81, 'Iacoca, Lee'),
(111, 'Janert, Phillip'),
(16, 'Kafka, Frank'),
(70, 'Kale, V P'),
(57, 'Kanetkar, Yashwant'),
(116, 'Kautiyla'),
(10, 'Konnikova, Maria'),
(72, 'Lapierre, Dominique'),
(127, 'Larsson, Steig'),
(124, 'Machiavelli'),
(82, 'Maugham, William S'),
(25, 'McKinney, Wes'),
(7, 'Menon, V P'),
(8, 'Mlodinow, Leonard'),
(100, 'Mohan, Ned'),
(89, 'Naipaul, V S'),
(46, 'Naipaul, V. S.'),
(121, 'Nariman'),
(65, 'Nayar, Kuldip'),
(90, 'Nehru, Jawaharlal'),
(18, 'Nisbet, Robert'),
(21, 'Oram, Andy'),
(80, 'Orwell, George'),
(117, 'Palkhivala'),
(38, 'Pausch, Randy'),
(83, 'Pirsig, Robert'),
(42, 'Poe, Edgar Allen'),
(17, 'Pratt, John'),
(39, 'Rand, Ayn'),
(115, 'Ranjan, Sudhanshu'),
(99, 'Rashid, Muhammad'),
(107, 'Raymond, Eric'),
(126, 'Rowling, J K'),
(73, 'Russell, Bertrand'),
(102, 'Rutherford, Alex'),
(112, 'Sagan, Carl'),
(5, 'Said, Edward'),
(122, 'Sassoon, Jean'),
(11, 'Sebastian Gutierrez'),
(61, 'Sen, Amartya'),
(9, 'Shih, Frank'),
(24, 'Silver, Nate'),
(93, 'Singh, Simon'),
(30, 'Smith, Adam'),
(118, 'Sorabjee'),
(41, 'Steinbeck, John'),
(51, 'Stonier, Alfred'),
(58, 'Stroud, Jonathan'),
(14, 'Sussman, Gerald'),
(54, 'Tanenbaum, Andrew'),
(22, 'Tao, Terence'),
(56, 'Taub, Schilling'),
(71, 'Tharoor, Shashi'),
(98, 'Thomas, Joy'),
(6, 'Vapnik, Vladimir'),
(68, 'Various'),
(105, 'Verne, Jules'),
(13, 'Villani, Cedric'),
(12, 'Vonnegut, Kurt'),
(92, 'Wells, H G'),
(19, 'Wells, H. G.'),
(110, 'West, Morris'),
(64, 'Woodward, Bob'),
(119, 'Zaidi, Hussain');

-- --------------------------------------------------------

--
-- Table structure for table `Book`
--

CREATE TABLE IF NOT EXISTS `Book` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Genre` int(11) NOT NULL COMMENT 'FK to Genre Table',
  `Author` int(11) NOT NULL COMMENT 'FK to Author Table',
  `Publisher` int(11) NOT NULL COMMENT 'FK to Publisher Table',
  `User` int(11) NOT NULL COMMENT 'FK to User Table'
) ENGINE=InnoDB AUTO_INCREMENT=116 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Book`
--

INSERT INTO `Book` (`ID`, `Name`, `Genre`, `Author`, `Publisher`, `User`) VALUES
(1, 'Fundamentals of Wavelets', 1, 1, 1, 1),
(2, 'Data Smart', 1, 2, 1, 1),
(3, 'God Created the Integers', 1, 3, 2, 1),
(4, 'Signal and the Noise, The', 1, 24, 2, 1),
(5, 'Freakonomics', 2, 4, 2, 1),
(6, 'Drunkard''s Walk, The', 2, 8, 2, 1),
(7, 'Tao of Physics, The', 2, 33, 2, 1),
(8, 'New Markets & Other Essays', 2, 76, 2, 1),
(9, 'Electric Universe', 2, 77, 2, 1),
(10, 'Orientalism', 3, 5, 2, 1),
(11, 'How to Think Like Sherlock Holmes', 3, 10, 2, 1),
(12, 'Age of Wrath, The', 3, 15, 2, 1),
(13, 'Beautiful and the Damned, The', 3, 27, 2, 1),
(14, 'Russian Journal, A', 3, 41, 2, 1),
(15, 'Once There Was a War', 3, 41, 2, 1),
(16, 'Last Mughal, The', 3, 67, 2, 1),
(17, 'India from Midnight to Milennium', 3, 71, 2, 1),
(18, 'Bookless in Baghdad', 3, 71, 2, 1),
(19, 'Down and Out in Paris & London', 3, 80, 2, 1),
(20, 'New Machiavelli, The', 4, 19, 2, 1),
(21, 'Outsider, The', 4, 28, 2, 1),
(22, 'We the Living', 4, 39, 2, 1),
(23, 'Journal of a Novel', 4, 41, 2, 1),
(24, 'Moon is Down, The', 4, 41, 2, 1),
(25, 'Winter of Our Discontent, The', 4, 41, 2, 1),
(26, 'Burning Bright', 4, 41, 2, 1),
(27, 'Crime and Punishment', 4, 59, 2, 1),
(28, 'Sea of Poppies', 4, 62, 2, 1),
(29, 'Raisin in the Sun, A', 4, 63, 2, 1),
(30, 'Great Indian Novel, The', 4, 71, 2, 1),
(31, 'Doctor in the Nude', 4, 79, 2, 1),
(32, 'To Sir With Love', 4, 88, 2, 1),
(33, 'Physics & Philosophy', 5, 20, 2, 1),
(34, 'Return of the Primitive', 5, 39, 2, 1),
(35, 'Idea of Justice, The', 5, 61, 2, 1),
(36, 'Identity & Violence', 5, 61, 2, 1),
(37, 'Superfreakonomics', 2, 4, 3, 1),
(38, 'Hidden Connections, The', 2, 33, 3, 1),
(39, 'Scoop!', 3, 65, 3, 1),
(40, 'Great War for Civilization, The', 3, 84, 3, 1),
(41, 'Tales of Mystery and Imagination', 4, 42, 3, 1),
(42, 'Nature of Statistical Learning Theory, The', 1, 6, 4, 1),
(43, 'Social Choice & Welfare, Vol 39 No. 1', 1, 68, 4, 1),
(44, 'Rationality & Freedom', 2, 61, 4, 1),
(45, 'Integration of the Indian States', 3, 7, 5, 1),
(46, 'Image Processing & Mathematical Morphology', 1, 9, 6, 1),
(47, 'Data Scientists at Work', 1, 11, 7, 1),
(48, 'Data Mining Handbook', 1, 18, 7, 1),
(49, 'Wealth of Nations, The', 2, 30, 8, 1),
(50, 'Surely You''re Joking Mr Feynman', 2, 34, 8, 1),
(51, 'Dylan on Dylan', 3, 49, 8, 1),
(52, 'All the President''s Men', 3, 64, 8, 1),
(53, 'Beyond the Three Seas', 3, 67, 8, 1),
(54, 'Age of Discontuinity, The', 3, 76, 8, 1),
(55, 'Slaughterhouse Five', 4, 12, 8, 1),
(56, 'Trial, The', 4, 16, 8, 1),
(57, 'Complete Sherlock Holmes, The - Vol I', 4, 29, 8, 1),
(58, 'Complete Sherlock Holmes, The - Vol II', 4, 29, 8, 1),
(59, 'Pillars of the Earth, The', 4, 31, 8, 1),
(60, 'Jurassic Park', 4, 40, 8, 1),
(61, 'Brethren, The', 4, 45, 8, 1),
(62, 'Catch 22', 4, 47, 8, 1),
(63, 'Amulet of Samarkand, The', 4, 58, 8, 1),
(64, 'Angels & Demons', 4, 60, 8, 1),
(65, 'Hunchback of Notre Dame, The', 4, 78, 8, 1),
(66, 'Birth of a Theorem', 2, 13, 9, 1),
(67, 'Structure & Interpretation of Computer Programs', 1, 14, 10, 1),
(68, 'Statistical Decision Theory''', 1, 17, 10, 1),
(69, 'Introduction to Algorithms', 1, 26, 10, 1),
(70, 'Making Software', 1, 21, 11, 1),
(71, 'Machine Learning for Hackers', 1, 23, 11, 1),
(72, 'Python for Data Analysis', 1, 25, 11, 1),
(73, 'Learning OpenCV', 1, 53, 11, 1),
(74, 'Analysis, Vol I', 1, 22, 12, 1),
(75, 'Mein Kampf', 3, 32, 13, 1),
(76, 'Farewell to Arms, A', 4, 35, 13, 1),
(77, 'In a Free State', 4, 46, 13, 1),
(78, 'Veteran, The', 4, 36, 14, 1),
(79, 'False Impressions', 4, 37, 15, 1),
(80, 'Prisoner of Birth, A', 4, 37, 15, 1),
(81, 'Last Lecture, The', 3, 38, 16, 1),
(82, 'Story of Philosophy, The', 5, 43, 17, 1),
(83, 'Radiowaril Bhashane & Shrutika', 3, 44, 18, 1),
(84, 'Gun Gayin Awadi', 3, 44, 18, 1),
(85, 'Aghal Paghal', 3, 44, 18, 1),
(86, 'Ahe Manohar Tari', 3, 66, 18, 1),
(87, 'Maqta-e-Ghalib', 3, 69, 18, 1),
(88, 'Manasa', 3, 70, 18, 1),
(89, 'Asami Asami', 4, 44, 18, 1),
(90, 'Complete Mastermind, The', 3, 48, 19, 1),
(91, 'Soft Computing & Intelligent Systems', 1, 50, 20, 1),
(92, 'Textbook of Economic Theory', 1, 51, 21, 1),
(93, 'Econometric Analysis', 1, 52, 21, 1),
(94, 'Computer Vision, A Modern Approach', 1, 55, 21, 1),
(95, 'Data Structures Using C & C++', 1, 54, 22, 1),
(96, 'Let Us C', 1, 57, 22, 1),
(97, 'Principles of Communication Systems', 1, 56, 23, 1),
(98, 'Argumentative Indian, The', 3, 61, 24, 1),
(99, 'O Jerusalem!', 3, 72, 25, 1),
(100, 'Freedom at Midnight', 3, 72, 25, 1),
(101, 'City of Joy, The', 4, 72, 25, 1),
(102, 'On Education', 5, 73, 26, 1),
(103, 'History of Western Philosophy', 5, 73, 26, 1),
(104, 'Free Will', 3, 74, 27, 1),
(105, 'Theory of Everything, The', 2, 3, 28, 1),
(106, 'Maugham''s Collected Short Stories, Vol 3', 4, 82, 29, 1),
(107, 'Ashenden of The British Agent', 4, 82, 29, 1),
(108, 'Zen & The Art of Motorcycle Maintenance', 5, 83, 29, 1),
(109, 'Artist and the Mathematician, The', 2, 85, 30, 1),
(110, 'Clash of Civilizations and Remaking of the World Order', 3, 86, 31, 1),
(111, 'Uncommon Wisdom', 3, 33, 32, 1),
(112, 'One', 3, 87, 33, 1),
(113, 'Ender''s Game', 7, 130, 3, 1),
(114, 'Ender in Exile', 7, 130, 3, 1),
(115, 'Curious Stephen Tizley', 3, 131, 34, 1);

-- --------------------------------------------------------

--
-- Table structure for table `Genre`
--

CREATE TABLE IF NOT EXISTS `Genre` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Genre`
--

INSERT INTO `Genre` (`ID`, `Name`) VALUES
(4, 'Fiction'),
(3, 'NonFiction'),
(5, 'Philosophy'),
(6, 'Romance'),
(7, 'Sci-Fi'),
(2, 'Science'),
(1, 'Tech');

-- --------------------------------------------------------

--
-- Table structure for table `History`
--

CREATE TABLE IF NOT EXISTS `History` (
  `Book` int(11) NOT NULL,
  `User` int(11) NOT NULL,
  `Due_Date` date NOT NULL,
  `Fees_Paid` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Hold`
--

CREATE TABLE IF NOT EXISTS `Hold` (
  `Book` int(11) NOT NULL,
  `User` int(11) NOT NULL,
  `Hold_Until` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Hold`
--

INSERT INTO `Hold` (`Book`, `User`, `Hold_Until`) VALUES
(39, 12, '2017-07-31'),
(105, 23, '2017-07-31'),
(93, 24, '2017-07-31');

-- --------------------------------------------------------

--
-- Table structure for table `LateFees`
--

CREATE TABLE IF NOT EXISTS `LateFees` (
  `days_late` int(11) NOT NULL,
  `fee_amount` decimal(10,0) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Publisher`
--

CREATE TABLE IF NOT EXISTS `Publisher` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Publisher`
--

INSERT INTO `Publisher` (`ID`, `Name`) VALUES
(7, 'Apress'),
(19, 'BBC'),
(9, 'Bodley Head'),
(6, 'CRC'),
(33, 'Dell'),
(20, 'Elsevier'),
(32, 'Fontana'),
(27, 'FreePress'),
(3, 'HarperCollins'),
(12, 'HBA'),
(30, 'High Stakes'),
(16, 'Hyperion'),
(28, 'Jaico'),
(18, 'Mauj'),
(10, 'MIT Press'),
(11, 'O''Reilly'),
(5, 'Orient Blackswan'),
(15, 'Pan'),
(21, 'Pearson'),
(2, 'Penguin'),
(24, 'Picador'),
(17, 'Pocket'),
(22, 'Prentice Hall'),
(8, 'Random House'),
(26, 'Routledge'),
(13, 'Rupa'),
(31, 'Simon & Schuster'),
(4, 'Springer'),
(34, 'TAMUCT'),
(23, 'TMH'),
(14, 'Transworld'),
(25, 'Vikas'),
(29, 'Vintage'),
(1, 'Wiley');

-- --------------------------------------------------------

--
-- Table structure for table `Reservations`
--

CREATE TABLE IF NOT EXISTS `Reservations` (
  `Book` int(11) NOT NULL,
  `User` int(11) NOT NULL,
  `Due_Date` date NOT NULL,
  `Late_Fees` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Reservations`
--

INSERT INTO `Reservations` (`Book`, `User`, `Due_Date`, `Late_Fees`) VALUES
(41, 23, '2017-07-23', '0'),
(113, 24, '2017-07-31', '0');

-- --------------------------------------------------------

--
-- Table structure for table `User`
--

CREATE TABLE IF NOT EXISTS `User` (
  `ID` int(11) NOT NULL,
  `Created_Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Last_Login` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `Password` varchar(256) NOT NULL,
  `Username` varchar(64) NOT NULL,
  `Account_Level` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `User`
--

INSERT INTO `User` (`ID`, `Created_Date`, `Last_Login`, `Password`, `Username`, `Account_Level`) VALUES
(1, '2017-06-14 21:01:39', '0000-00-00 00:00:00', 'adminhashed', 'admin', 2),
(12, '2017-07-03 14:39:36', '0000-00-00 00:00:00', 'pathashed', 'pat', 0),
(13, '2017-07-03 14:41:15', '0000-00-00 00:00:00', 'libhashed', 'lib', 1),
(23, '2017-07-24 20:19:57', '0000-00-00 00:00:00', 'openhashed', 'Brian', 0),
(24, '2017-07-24 20:22:12', '0000-00-00 00:00:00', 'ahashed', 'Seigle', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AccountLevel`
--
ALTER TABLE `AccountLevel`
  ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Name` (`Name`), ADD KEY `ID` (`ID`);

--
-- Indexes for table `Author`
--
ALTER TABLE `Author`
  ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Name` (`Name`), ADD KEY `ID` (`ID`);

--
-- Indexes for table `Book`
--
ALTER TABLE `Book`
  ADD UNIQUE KEY `ID` (`ID`), ADD KEY `ID_2` (`ID`), ADD KEY `Genre` (`Genre`), ADD KEY `Author` (`Author`), ADD KEY `Publisher` (`Publisher`), ADD KEY `User` (`User`);

--
-- Indexes for table `Genre`
--
ALTER TABLE `Genre`
  ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Name` (`Name`), ADD KEY `ID` (`ID`);

--
-- Indexes for table `History`
--
ALTER TABLE `History`
  ADD PRIMARY KEY (`Book`,`User`,`Due_Date`), ADD KEY `Book` (`Book`,`User`,`Due_Date`), ADD KEY `User` (`User`);

--
-- Indexes for table `Hold`
--
ALTER TABLE `Hold`
  ADD PRIMARY KEY (`Book`,`User`,`Hold_Until`), ADD KEY `Book` (`Book`,`User`,`Hold_Until`), ADD KEY `User` (`User`);

--
-- Indexes for table `LateFees`
--
ALTER TABLE `LateFees`
  ADD PRIMARY KEY (`days_late`);

--
-- Indexes for table `Publisher`
--
ALTER TABLE `Publisher`
  ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Name` (`Name`), ADD KEY `ID` (`ID`);

--
-- Indexes for table `Reservations`
--
ALTER TABLE `Reservations`
  ADD PRIMARY KEY (`Book`,`User`,`Due_Date`), ADD KEY `Book` (`Book`,`User`,`Due_Date`), ADD KEY `User` (`User`);

--
-- Indexes for table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Username` (`Username`), ADD KEY `ID` (`ID`), ADD KEY `Account_Level` (`Account_Level`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AccountLevel`
--
ALTER TABLE `AccountLevel`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `Author`
--
ALTER TABLE `Author`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=132;
--
-- AUTO_INCREMENT for table `Book`
--
ALTER TABLE `Book`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=116;
--
-- AUTO_INCREMENT for table `Genre`
--
ALTER TABLE `Genre`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `Publisher`
--
ALTER TABLE `Publisher`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=35;
--
-- AUTO_INCREMENT for table `User`
--
ALTER TABLE `User`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=27;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Book`
--
ALTER TABLE `Book`
ADD CONSTRAINT `Book_ibfk_1` FOREIGN KEY (`Genre`) REFERENCES `Genre` (`ID`) ON UPDATE NO ACTION,
ADD CONSTRAINT `Book_ibfk_2` FOREIGN KEY (`Author`) REFERENCES `Author` (`ID`) ON UPDATE NO ACTION,
ADD CONSTRAINT `Book_ibfk_3` FOREIGN KEY (`Publisher`) REFERENCES `Publisher` (`ID`) ON UPDATE NO ACTION,
ADD CONSTRAINT `Book_ibfk_4` FOREIGN KEY (`User`) REFERENCES `User` (`ID`);

--
-- Constraints for table `History`
--
ALTER TABLE `History`
ADD CONSTRAINT `History_ibfk_1` FOREIGN KEY (`Book`) REFERENCES `Book` (`ID`) ON UPDATE NO ACTION,
ADD CONSTRAINT `History_ibfk_2` FOREIGN KEY (`User`) REFERENCES `User` (`ID`) ON UPDATE NO ACTION;

--
-- Constraints for table `Hold`
--
ALTER TABLE `Hold`
ADD CONSTRAINT `Hold_ibfk_1` FOREIGN KEY (`Book`) REFERENCES `Book` (`ID`) ON UPDATE NO ACTION,
ADD CONSTRAINT `Hold_ibfk_2` FOREIGN KEY (`User`) REFERENCES `User` (`ID`) ON UPDATE NO ACTION;

--
-- Constraints for table `Reservations`
--
ALTER TABLE `Reservations`
ADD CONSTRAINT `Reservations_ibfk_1` FOREIGN KEY (`Book`) REFERENCES `Book` (`ID`),
ADD CONSTRAINT `Reservations_ibfk_2` FOREIGN KEY (`User`) REFERENCES `User` (`ID`) ON UPDATE NO ACTION;

--
-- Constraints for table `User`
--
ALTER TABLE `User`
ADD CONSTRAINT `User_ibfk_1` FOREIGN KEY (`Account_Level`) REFERENCES `AccountLevel` (`ID`) ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
