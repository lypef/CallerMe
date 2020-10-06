-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-10-2020 a las 08:14:28
-- Versión del servidor: 10.1.36-MariaDB
-- Versión de PHP: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `caller_me`
--
CREATE DATABASE IF NOT EXISTS `caller_me` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `caller_me`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `adresses`
--

CREATE TABLE `adresses` (
  `id` int(11) NOT NULL,
  `client` int(11) NOT NULL,
  `direccion` varchar(254) NOT NULL,
  `referencia` varchar(254) NOT NULL,
  `kms` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `adresses`
--

INSERT INTO `adresses` (`id`, `client`, `direccion`, `referencia`, `kms`) VALUES
(4, 1, 'ficticia', 'EWFEWFEWFEWF', 1),
(5, 1, 'direccion nueva', '', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `nombre` varchar(254) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `correo_electronico` varchar(254) NOT NULL,
  `foto` varchar(254) NOT NULL,
  `razon_social` varchar(254) NOT NULL,
  `rfc` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clients`
--

INSERT INTO `clients` (`id`, `nombre`, `fecha_nacimiento`, `correo_electronico`, `foto`, `razon_social`, `rfc`) VALUES
(1, 'PUBLICO EN GENERAL', '2018-01-06', '', '/106012018222600', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `drivers`
--

CREATE TABLE `drivers` (
  `id` int(11) NOT NULL,
  `nombre` varchar(254) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `licencia_conducir` varchar(254) NOT NULL,
  `correl_electronico` varchar(254) NOT NULL,
  `foto` varchar(254) NOT NULL,
  `movil` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `drivers`
--

INSERT INTO `drivers` (`id`, `nombre`, `fecha_nacimiento`, `licencia_conducir`, `correl_electronico`, `foto`, `movil`) VALUES
(1, 'CONDUTOR 1', '2020-04-16', '', '', '/116042020024609pm', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `logs_login`
--

CREATE TABLE `logs_login` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT '2019-07-09 00:00:00',
  `login` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `logs_login`
--

INSERT INTO `logs_login` (`id`, `user_id`, `fecha`, `login`) VALUES
(1, 1, '2020-07-24 14:43:59', 1),
(2, 1, '2020-07-24 14:44:13', 0),
(3, 1, '2020-07-29 13:45:27', 1),
(4, 1, '2020-07-29 13:52:14', 0),
(5, 1, '2020-07-29 14:08:36', 1),
(6, 1, '2020-07-29 14:08:44', 0),
(7, 1, '2020-07-30 08:25:42', 1),
(8, 1, '2020-07-30 08:26:10', 1),
(9, 1, '2020-07-30 09:10:57', 1),
(10, 1, '2020-07-30 09:12:00', 1),
(11, 1, '2020-07-30 09:36:00', 1),
(12, 1, '2020-07-30 09:36:14', 1),
(13, 1, '2020-07-30 09:36:43', 1),
(14, 1, '2020-07-30 09:37:37', 1),
(15, 1, '2020-07-30 09:58:18', 1),
(16, 1, '2020-07-30 09:58:58', 1),
(17, 1, '2020-07-30 10:00:43', 1),
(18, 1, '2020-07-30 10:05:56', 1),
(19, 1, '2020-07-30 10:07:36', 1),
(20, 1, '2020-07-30 10:08:35', 1),
(21, 1, '2020-07-30 10:10:12', 1),
(22, 1, '2020-07-30 10:14:06', 1),
(23, 1, '2020-07-30 10:16:05', 1),
(24, 1, '2020-07-30 10:17:39', 1),
(25, 1, '2020-07-30 10:18:04', 1),
(26, 1, '2020-07-30 10:27:06', 1),
(27, 1, '2020-07-30 10:28:12', 1),
(28, 1, '2020-07-30 10:28:43', 1),
(29, 1, '2020-07-30 10:29:59', 1),
(30, 1, '2020-07-30 10:30:29', 1),
(31, 1, '2020-07-30 10:31:27', 1),
(32, 1, '2020-07-30 10:32:27', 1),
(33, 1, '2020-07-30 10:34:33', 1),
(34, 1, '2020-07-30 10:34:59', 1),
(35, 1, '2020-07-30 10:36:32', 1),
(36, 1, '2020-07-30 10:36:54', 1),
(37, 1, '2020-07-30 10:37:01', 0),
(38, 1, '2020-07-30 10:37:09', 1),
(39, 1, '2020-07-30 10:38:42', 1),
(40, 1, '2020-07-30 10:39:55', 1),
(41, 1, '2020-07-30 10:40:18', 1),
(42, 1, '2020-07-30 10:41:32', 1),
(43, 1, '2020-07-30 10:41:50', 1),
(44, 1, '2020-07-30 10:42:32', 1),
(45, 1, '2020-07-30 10:43:04', 1),
(46, 1, '2020-07-30 10:53:25', 1),
(47, 1, '2020-07-30 10:53:32', 0),
(48, 1, '2020-07-30 10:53:36', 1),
(49, 1, '2020-07-30 10:55:47', 1),
(50, 1, '2020-07-30 10:56:53', 1),
(51, 1, '2020-07-30 10:58:24', 1),
(52, 1, '2020-08-11 12:26:46', 1),
(53, 1, '2020-08-11 12:29:43', 1),
(54, 1, '2020-08-11 12:30:09', 1),
(55, 1, '2020-08-11 12:34:59', 1),
(56, 1, '2020-08-11 12:35:41', 1),
(57, 1, '2020-08-11 12:39:32', 1),
(58, 1, '2020-08-11 13:11:31', 1),
(59, 1, '2020-08-11 13:12:04', 1),
(60, 1, '2020-08-11 13:14:37', 1),
(61, 1, '2020-08-14 21:41:40', 1),
(62, 1, '2020-08-14 21:42:20', 0),
(63, 1, '2020-08-14 21:42:24', 1),
(64, 1, '2020-08-14 21:42:33', 0),
(65, 1, '2020-08-14 21:42:36', 1),
(66, 1, '2020-08-14 21:46:30', 0),
(67, 1, '2020-08-14 21:46:33', 1),
(68, 1, '2020-08-14 21:48:25', 1),
(69, 1, '2020-08-14 21:48:39', 1),
(70, 1, '2020-08-14 21:49:09', 1),
(71, 1, '2020-08-14 21:49:23', 0),
(72, 1, '2020-08-14 21:49:26', 1),
(73, 1, '2020-08-14 21:50:09', 1),
(74, 1, '2020-10-05 23:50:41', 1),
(75, 1, '2020-10-05 23:53:55', 1),
(76, 1, '2020-10-05 23:55:50', 1),
(77, 1, '2020-10-05 23:56:56', 1),
(78, 1, '2020-10-06 00:01:36', 1),
(79, 1, '2020-10-06 00:03:59', 1),
(80, 1, '2020-10-06 00:05:29', 1),
(81, 1, '2020-10-06 00:05:42', 1),
(82, 1, '2020-10-06 00:06:28', 1),
(83, 1, '2020-10-06 00:08:35', 1),
(84, 1, '2020-10-06 00:10:49', 1),
(85, 1, '2020-10-06 00:11:17', 1),
(86, 1, '2020-10-06 00:13:00', 1),
(87, 1, '2020-10-06 00:14:18', 1),
(88, 1, '2020-10-06 00:15:20', 1),
(89, 1, '2020-10-06 00:16:04', 1),
(90, 1, '2020-10-06 00:19:54', 1),
(91, 1, '2020-10-06 00:20:52', 1),
(92, 1, '2020-10-06 00:22:49', 1),
(93, 1, '2020-10-06 00:23:53', 1),
(94, 1, '2020-10-06 00:24:44', 1),
(95, 1, '2020-10-06 00:25:14', 1),
(96, 1, '2020-10-06 00:25:39', 1),
(97, 1, '2020-10-06 00:26:37', 1),
(98, 1, '2020-10-06 00:28:31', 1),
(99, 1, '2020-10-06 00:31:15', 1),
(100, 1, '2020-10-06 00:42:48', 1),
(101, 1, '2020-10-06 00:43:52', 1),
(102, 1, '2020-10-06 00:49:56', 1),
(103, 1, '2020-10-06 00:52:10', 1),
(104, 1, '2020-10-06 00:55:53', 1),
(105, 1, '2020-10-06 00:56:38', 1),
(106, 1, '2020-10-06 00:57:38', 1),
(107, 1, '2020-10-06 00:58:05', 1),
(108, 1, '2020-10-06 00:58:30', 1),
(109, 1, '2020-10-06 00:58:48', 1),
(110, 1, '2020-10-06 00:59:04', 1),
(111, 1, '2020-10-06 00:59:53', 1),
(112, 1, '2020-10-06 01:00:54', 1),
(113, 1, '2020-10-06 01:01:32', 1),
(114, 1, '2020-10-06 01:02:19', 1),
(115, 1, '2020-10-06 01:02:50', 1),
(116, 1, '2020-10-06 01:03:51', 1),
(117, 1, '2020-10-06 01:04:14', 1),
(118, 1, '2020-10-06 01:04:30', 1),
(119, 1, '2020-10-06 01:04:51', 1),
(120, 1, '2020-10-06 01:05:35', 1),
(121, 1, '2020-10-06 01:11:04', 1),
(122, 1, '2020-10-06 01:11:20', 1),
(123, 1, '2020-10-06 01:12:21', 1),
(124, 1, '2020-10-06 01:12:56', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permissions`
--

CREATE TABLE `permissions` (
  `user_id` int(11) NOT NULL,
  `acces_clients` tinyint(1) NOT NULL,
  `acces_numbersTelephone` tinyint(1) NOT NULL,
  `acces_adresses` tinyint(1) NOT NULL,
  `acces_drivers` tinyint(1) NOT NULL,
  `acces_vehicles` tinyint(1) NOT NULL,
  `acces_logs` tinyint(1) NOT NULL,
  `clients_add` tinyint(1) NOT NULL,
  `clients_edit` tinyint(1) NOT NULL,
  `clients_delete` tinyint(1) NOT NULL,
  `adresses_add` tinyint(1) NOT NULL,
  `adresses_edit` tinyint(1) NOT NULL,
  `adresses_delete` tinyint(1) NOT NULL,
  `telephone_add` tinyint(1) NOT NULL,
  `telephone_edit` tinyint(1) NOT NULL,
  `telephone_delete` tinyint(1) NOT NULL,
  `drivers_add` tinyint(1) NOT NULL,
  `drivers_edit` tinyint(1) NOT NULL,
  `drivers_delete` tinyint(1) NOT NULL,
  `vehicles_add` tinyint(1) NOT NULL,
  `vehicles_edit` tinyint(1) NOT NULL,
  `vehicles_delete` tinyint(1) NOT NULL,
  `properties` tinyint(1) NOT NULL,
  `logs_add` tinyint(1) NOT NULL,
  `logs_delete` tinyint(1) NOT NULL,
  `logs_clean` tinyint(1) NOT NULL,
  `user_access` tinyint(1) NOT NULL,
  `user_add` tinyint(1) NOT NULL,
  `user_edit` tinyint(1) NOT NULL,
  `user_delete` tinyint(1) NOT NULL,
  `user_permisos` tinyint(1) NOT NULL,
  `delete_omitido` tinyint(1) NOT NULL DEFAULT '0',
  `close_software` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `permissions`
--

INSERT INTO `permissions` (`user_id`, `acces_clients`, `acces_numbersTelephone`, `acces_adresses`, `acces_drivers`, `acces_vehicles`, `acces_logs`, `clients_add`, `clients_edit`, `clients_delete`, `adresses_add`, `adresses_edit`, `adresses_delete`, `telephone_add`, `telephone_edit`, `telephone_delete`, `drivers_add`, `drivers_edit`, `drivers_delete`, `vehicles_add`, `vehicles_edit`, `vehicles_delete`, `properties`, `logs_add`, `logs_delete`, `logs_clean`, `user_access`, `user_add`, `user_edit`, `user_delete`, `user_permisos`, `delete_omitido`, `close_software`) VALUES
(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `properties`
--

CREATE TABLE `properties` (
  `id` int(11) NOT NULL,
  `name_enterprise` varchar(254) NOT NULL,
  `direccion` varchar(254) NOT NULL,
  `rfc` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `properties`
--

INSERT INTO `properties` (`id`, `name_enterprise`, `direccion`, `rfc`) VALUES
(1, 'RADIO TAXIS ROJOS CGT', 'YUCATAN 2175,COL. MIGUEL HIDALGO', 'SRS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registros`
--

CREATE TABLE `registros` (
  `id` int(11) NOT NULL,
  `client` int(11) NOT NULL,
  `telefono` int(11) NOT NULL,
  `hora_llamada` datetime NOT NULL,
  `atencion_llamada` datetime NOT NULL,
  `finaliza_llamada` datetime NOT NULL,
  `usuario` int(11) NOT NULL,
  `direccion` int(11) NOT NULL,
  `vehicle` varchar(254) NOT NULL,
  `driver` varchar(254) NOT NULL,
  `asistido` tinyint(1) NOT NULL DEFAULT '1',
  `observacion` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `registros`
--

INSERT INTO `registros` (`id`, `client`, `telefono`, `hora_llamada`, `atencion_llamada`, `finaliza_llamada`, `usuario`, `direccion`, `vehicle`, `driver`, `asistido`, `observacion`) VALUES
(36, 1, 2730, '2020-10-05 23:51:05', '2020-10-05 23:51:05', '2020-10-05 23:51:10', 1, 4, 'aaaa', 'aaa', 1, ''),
(37, 1, 2730, '2020-10-05 23:58:28', '2020-10-05 23:58:28', '2020-10-05 23:58:32', 1, 4, 'regergreg', 'gerergre', 1, ''),
(38, 1, 2730, '2020-10-06 00:02:28', '2020-10-06 00:02:28', '2020-10-06 00:02:40', 1, 4, 'vehiculo numero', 'conductor maneja', 1, ''),
(39, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(40, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(41, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(42, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(43, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(44, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(45, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(46, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(47, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(48, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(49, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(50, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(51, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(52, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(53, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(54, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(55, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(56, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(57, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(58, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(59, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(60, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(61, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(62, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(63, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(64, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(65, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(66, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(67, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(68, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(69, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(70, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(71, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(72, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(73, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(74, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(75, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(76, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(77, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(78, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(79, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(80, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(81, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(82, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(83, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(84, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(85, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(86, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(87, 1, 2730, '2020-10-06 00:05:45', '2020-10-06 00:05:45', '2020-10-06 00:05:49', 1, 4, 'dwdwdw', 'wdwdwdwd', 1, ''),
(88, 1, 2730, '2020-10-06 00:14:21', '2020-10-06 00:14:21', '2020-10-06 00:14:37', 1, 4, 'hola_uuue', 'conduce_uuu', 1, ''),
(89, 1, 2730, '2020-10-06 00:15:24', '2020-10-06 00:15:24', '2020-10-06 00:15:33', 1, 4, 'VEHICULO', 'CONDUCTOR', 1, ''),
(91, 1, 2730, '2020-10-06 00:15:24', '2020-10-06 00:15:24', '2020-10-06 00:15:33', 1, 4, '', '', 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registros_omitidos`
--

CREATE TABLE `registros_omitidos` (
  `id` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `numero` varchar(254) NOT NULL,
  `f_llamada` datetime NOT NULL,
  `usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `registros_omitidos`
--

INSERT INTO `registros_omitidos` (`id`, `cliente`, `numero`, `f_llamada`, `usuario`) VALUES
(19, 1, 'Telefono: CLIENTE SIN NOMBRE', '2020-07-13 22:49:16', 1),
(26, 1, '923120050544', '2020-07-13 22:57:06', 1),
(27, 1, '923120050544', '2020-07-13 22:57:12', 1),
(28, 1, '923120050544', '2020-07-13 22:57:21', 1),
(29, 1, '923120050544', '2020-07-13 22:57:25', 1),
(30, 1, '2222', '2020-07-30 00:00:00', 1),
(31, 1, '01800', '0000-00-00 00:00:00', 1),
(32, 1, '01800', '0000-00-00 00:00:00', 1),
(33, 1, '01800', '0000-00-00 00:00:00', 1),
(34, 1, '01800', '0000-00-00 00:00:00', 1),
(35, 1, '01800', '0000-00-00 00:00:00', 1),
(36, 1, '01800', '0000-00-00 00:00:00', 1),
(37, 1, '01800', '0000-00-00 00:00:00', 1),
(38, 1, '01800', '2020-07-30 09:18:44', 1),
(39, 1, '01800', '2020-07-30 10:53:41', 1),
(40, 1, '01800', '2020-07-30 10:56:08', 1),
(41, 1, '01800', '2020-07-30 10:58:29', 1),
(42, 1, '01800', '2020-08-11 12:35:21', 1),
(43, 1, '01800', '2020-08-11 12:35:27', 1),
(44, 1, '9231200505', '2020-10-05 23:51:24', 1),
(45, 1, '9231200505', '2020-10-05 23:57:46', 1),
(46, 1, '9231200505', '2020-10-05 23:58:24', 1),
(47, 1, '9231200505', '2020-10-05 23:58:26', 1),
(48, 1, '9231200505', '2020-10-06 00:01:57', 1),
(49, 1, '9231200505', '2020-10-06 00:11:47', 1),
(50, 1, '9231200505', '2020-10-06 00:11:54', 1),
(51, 1, '9231200505', '2020-10-06 00:12:34', 1),
(52, 1, '01800', '2020-10-06 00:15:24', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telephone_numbers`
--

CREATE TABLE `telephone_numbers` (
  `id` int(11) NOT NULL,
  `client` int(11) NOT NULL,
  `numero` varchar(254) NOT NULL,
  `compañia` varchar(254) NOT NULL,
  `ref_note` varchar(254) NOT NULL,
  `fijo` tinyint(1) NOT NULL,
  `movil` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `telephone_numbers`
--

INSERT INTO `telephone_numbers` (`id`, `client`, `numero`, `compañia`, `ref_note`, `fijo`, `movil`) VALUES
(2730, 1, '01800', '', '', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL,
  `name` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`) VALUES
(1, 'root', '63a9f0ea7bb98050796b649e85481845', 'USUARIO ADMINISTRADOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehicles`
--

CREATE TABLE `vehicles` (
  `id` int(11) NOT NULL,
  `modelo` varchar(254) NOT NULL,
  `placas` varchar(254) NOT NULL,
  `driver` int(11) NOT NULL,
  `numero` varchar(254) NOT NULL,
  `caracteristicas` varchar(254) NOT NULL,
  `id_gps` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vehicles`
--

INSERT INTO `vehicles` (`id`, `modelo`, `placas`, `driver`, `numero`, `caracteristicas`, `id_gps`) VALUES
(1, 'VEHICULO 1', 'MATRICULA', 1, '1', '', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `adresses`
--
ALTER TABLE `adresses`
  ADD PRIMARY KEY (`id`),
  ADD KEY `CLIENT_ADDRESS` (`client`);

--
-- Indices de la tabla `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `drivers`
--
ALTER TABLE `drivers`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `logs_login`
--
ALTER TABLE `logs_login`
  ADD PRIMARY KEY (`id`),
  ADD KEY `log_login` (`user_id`);

--
-- Indices de la tabla `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- Indices de la tabla `properties`
--
ALTER TABLE `properties`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `registros`
--
ALTER TABLE `registros`
  ADD PRIMARY KEY (`id`),
  ADD KEY `r_usuario` (`usuario`),
  ADD KEY `r_direccion` (`direccion`),
  ADD KEY `r_client` (`client`),
  ADD KEY `r_telefono` (`telefono`);

--
-- Indices de la tabla `registros_omitidos`
--
ALTER TABLE `registros_omitidos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cliente_omitido` (`cliente`),
  ADD KEY `omitido_usuario` (`usuario`);

--
-- Indices de la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `numero` (`numero`),
  ADD KEY `client_number` (`client`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indices de la tabla `vehicles`
--
ALTER TABLE `vehicles`
  ADD PRIMARY KEY (`id`),
  ADD KEY `driver_vehicle` (`driver`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `adresses`
--
ALTER TABLE `adresses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `drivers`
--
ALTER TABLE `drivers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `logs_login`
--
ALTER TABLE `logs_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;

--
-- AUTO_INCREMENT de la tabla `properties`
--
ALTER TABLE `properties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `registros`
--
ALTER TABLE `registros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;

--
-- AUTO_INCREMENT de la tabla `registros_omitidos`
--
ALTER TABLE `registros_omitidos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT de la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2731;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `vehicles`
--
ALTER TABLE `vehicles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `adresses`
--
ALTER TABLE `adresses`
  ADD CONSTRAINT `CLIENT_ADDRESS` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `logs_login`
--
ALTER TABLE `logs_login`
  ADD CONSTRAINT `log_login` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `registros`
--
ALTER TABLE `registros`
  ADD CONSTRAINT `r_client` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_direccion` FOREIGN KEY (`direccion`) REFERENCES `adresses` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_telefono` FOREIGN KEY (`telefono`) REFERENCES `telephone_numbers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_usuario` FOREIGN KEY (`usuario`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `registros_omitidos`
--
ALTER TABLE `registros_omitidos`
  ADD CONSTRAINT `cliente_omitido` FOREIGN KEY (`cliente`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `omitido_usuario` FOREIGN KEY (`usuario`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  ADD CONSTRAINT `client_number` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `vehicles`
--
ALTER TABLE `vehicles`
  ADD CONSTRAINT `driver_vehicle` FOREIGN KEY (`driver`) REFERENCES `drivers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
