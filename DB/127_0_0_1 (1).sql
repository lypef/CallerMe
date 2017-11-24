-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-11-2017 a las 01:16:38
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
(1, 23, 'FBHDFGB', 'dsfdsrfvg', 2),
(2, 27, 'DIRECCION', 'REFERENCIA', 5),
(3, 23, '20 DE NOVIEMBRE 306, COLONIA CENTRO LAS CHOAPAS VERACRUZ', 'ZAP. CUERNAVACA FRENTE AL PORTON DE COPPEL', 158),
(4, 22, 'NEZAHUALCOYOTL 614, COLONIA ANAHUAC', 'CASA DURAZNO CON VENTANAS BLANCAS.', 15),
(5, 22, 'WDWWDWD', 'DWDWDWD', 5),
(6, 31, 'WEFEWFEW', 'EWFEWFEF', 5),
(7, 27, 'VFFF', '', 56),
(8, 28, 'EDRFREG', '', 56),
(9, 27, 'WEFEWFEW', 'WEFEWEW', 56),
(10, 28, 'DIRECCION', 'REF', 10290000),
(11, 24, 'DD', 'DD', 1000000000),
(12, 28, '.K', 'IKO', 129254888),
(13, 27, 'DWDW', 'DWDW', 10000000000),
(14, 28, 'WEF', 'WEFEWFE', 147258376192),
(15, 27, 'SD', 'D', 147258369.258),
(16, 27, 'E4FEFEW', 'DFDFWDW', 159),
(17, 28, 'EWRFGEWF', 'FWEFWEE', 1472583639),
(18, 27, 'EDRFGBERG', 'GREGREG', 147258369.258),
(19, 28, 'WDW', 'DWDW', 999999999.99);

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
(22, 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '1992-01-17', 'NMKJK', '/121112017135354.JPG', 'RSOCIAL', 'RFC'),
(23, 'ARLENE GARCIA AGUILAR', '1992-02-15', 'KAKA@HOTMAIL.COM', '/12311201722357', 'GARAGI', 'ADJEGBDCBH'),
(24, 'ANTONIA AGUILAR DE LA CRUZ', '2017-11-21', '', '/12311201722353', '', ''),
(25, 'EDUARDO ASCENCIO MORENO', '2017-11-21', '', '/12311201721756.jpg', '', ''),
(26, 'JOSE GERMAN GARCIA ROSALDO', '2017-11-21', '', '/12311201714814.jpg', '', ''),
(27, 'CANDELARIA DOMINGUEZ DOMINGUEZ', '2017-11-21', '', '/12311201722050', '', ''),
(28, 'CAROLINA ASCENCIO DOMINGUEZ', '2017-11-21', '', '/12311201714910.JPG', '', ''),
(29, 'INES DE LA CRUZ AGUILAR', '2017-11-21', '', '/12311201714941.jpg', '', ''),
(30, 'EL REY DAVID', '2017-11-21', '', '/12311201715046.jpg', '', ''),
(31, 'EDUARDO GARCIA AGUILAR', '2017-11-21', '', '/12311201715101.jpg', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permissions`
--

CREATE TABLE `permissions` (
  `user_id` int(11) NOT NULL,
  `acces_clients` tinyint(1) NOT NULL,
  `acces_registros` tinyint(1) NOT NULL,
  `acces_vehiculos` tinyint(1) NOT NULL,
  `acces_numbersTelephone` tinyint(1) NOT NULL,
  `acces_adresses` tinyint(1) NOT NULL,
  `clients_add` tinyint(1) NOT NULL,
  `clients_edit` tinyint(1) NOT NULL,
  `clients_delete` tinyint(1) NOT NULL,
  `adresses_add` tinyint(1) NOT NULL,
  `adresses_edit` tinyint(1) NOT NULL,
  `adresses_delete` tinyint(1) NOT NULL,
  `telephone_add` tinyint(1) NOT NULL,
  `telephone_edit` tinyint(1) NOT NULL,
  `telephone_delete` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `permissions`
--

INSERT INTO `permissions` (`user_id`, `acces_clients`, `acces_registros`, `acces_vehiculos`, `acces_numbersTelephone`, `acces_adresses`, `clients_add`, `clients_edit`, `clients_delete`, `adresses_add`, `adresses_edit`, `adresses_delete`, `telephone_add`, `telephone_edit`, `telephone_delete`) VALUES
(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1);

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
(13, 23, '445445s', 'EFSEESs', 's', 1, 0),
(14, 22, '54555', 'DWDW', '', 0, 1),
(15, 23, '2155694565', '', '', 0, 1),
(16, 22, '632166', '5654DEWDWEDW', '', 0, 1),
(18, 23, '415210', 'TELCEL', '', 1, 0),
(19, 22, '9231200505', 'TELCEL', 'wedcfewfcewe', 0, 1),
(22, 23, '8888888', 'COMPANY', 'DFEWDFEWDEWDDW', 0, 1),
(23, 29, '92312005052', 'TELCEL', 'LLAMAR SOO DESPUES DE LAS 6 ', 1, 0),
(24, 25, '6656456', '', '', 0, 1),
(25, 25, '65946469', '', '', 0, 1),
(26, 25, '238532858', '', '', 0, 1),
(27, 25, '7874877', '', '', 0, 1),
(28, 25, '52752752', '', '', 0, 1),
(29, 25, '74574574', '', '', 0, 1),
(30, 23, 'dsvgbrfer', '', '', 0, 1),
(31, 23, '9231169091', 'TELCEL', 'LLAMAR DESPUES DE LA 6 AM', 0, 1);

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
(1, 'root', 'root', 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ'),
(2, 'user1', 'user1', 'nombre'),
(3, 'user2', 'user2', 'wdwdw');

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
-- Indices de la tabla `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_id` (`user_id`);

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
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `adresses`
--
ALTER TABLE `adresses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT de la tabla `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT de la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `adresses`
--
ALTER TABLE `adresses`
  ADD CONSTRAINT `CLIENT_ADDRESS` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  ADD CONSTRAINT `client_number` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
