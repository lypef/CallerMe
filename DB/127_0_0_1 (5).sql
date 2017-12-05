-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-12-2017 a las 00:33:22
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
(2, 29, 'DIRECCIONs', 'REFERENCIAs', 50),
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
(18, 31, 'EDRFGBERGUPDATE', 'GREGREG UPDATE', 1500.258);

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
(22, 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '1992-01-17', 'NMKJK', '/101122017221127.JPG', 'RSOCIAL', 'RFC'),
(23, 'ARLENE GARCIA AGUILAR', '1992-02-15', 'KAKA@HOTMAIL.COM', '/101122017230025.jpg', 'GARAGI', 'ADJEGBDCBH'),
(24, 'ANTONIA AGUILAR DE LA CRUZ', '2017-11-21', '', '/123112017234820.jpg', '', ''),
(25, 'EDUARDO ASCENCIO MORENO', '2017-11-21', '', '/101122017230119.jpg', '', ''),
(26, 'JOSE GERMAN GARCIA ROSALDO', '2017-11-21', '', '/101122017220219.jpg', '', ''),
(27, 'CANDELARIA DOMINGUEZ DOMINGUEZ', '2017-11-21', '', '/101122017230050.jpg', '', ''),
(28, 'CAROLINA ASCENCIO DOMINGUEZ', '2017-11-21', '', '/101122017230105.jpg', '', ''),
(29, 'INES DE LA CRUZ AGUILAR', '2017-11-21', '', '/101122017220206.jpg', '', ''),
(31, 'EDUARDO GARCIA AGUILAR', '2017-11-21', '', '/101122017230137.jpg', '', ''),
(32, 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '1992-01-24', 'AAA@CYBERCHOALA.COM', '/127112017230715.JPG', 'R SOCIAL', 'RFC');

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
(1, 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '1992-01-24', 'TIPO A - NIC', 'VENTAS@CYBERCHOAPAS.COM', '/12411201701236.jpg', '9231200505'),
(4, 'UUUUUUU', '1992-01-25', 'UUUUU', 'UUU', '/12411201700102.jpg', ''),
(5, 'YO', '2017-11-25', 'AAAA', 'aaa', '/125112017121134', '00001111'),
(6, 'FHN FGTNTGFNGY', '2017-11-27', 'TBHNEDTRFHBGERWFG', 'gyndrftg', '/127112017225408.jpg', 'NDRTGNTGRD');

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
  `user_permisos` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `permissions`
--

INSERT INTO `permissions` (`user_id`, `acces_clients`, `acces_numbersTelephone`, `acces_adresses`, `acces_drivers`, `acces_vehicles`, `acces_logs`, `clients_add`, `clients_edit`, `clients_delete`, `adresses_add`, `adresses_edit`, `adresses_delete`, `telephone_add`, `telephone_edit`, `telephone_delete`, `drivers_add`, `drivers_edit`, `drivers_delete`, `vehicles_add`, `vehicles_edit`, `vehicles_delete`, `properties`, `logs_add`, `logs_delete`, `logs_clean`, `user_access`, `user_add`, `user_edit`, `user_delete`, `user_permisos`) VALUES
(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(38, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

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
(1, 'RADIO TAXI LA NUEVA ESTACION S.A DE C.V', 'TULIPANES 615 EXTERIOS 123,COL AVIACION OBREGON ', 'AEDF9201245G3');

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
  `vehicle` int(11) NOT NULL,
  `driver` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(31, 23, '9231169091', 'TELCEL', 'LLAMAR DESPUES DE LA 6 AM', 0, 1),
(32, 22, '41524545646546546', 'TELCEL', 'SDWSDWDW', 1, 0),
(34, 22, '92312005050', 'TELCEL', 'LLAMAR DESPUES DE LAS 7U ', 0, 1);

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
(37, 'demo0', 'pppp', 'ROOT'),
(38, 'jkljklklj', 'kljkljkljkl', 'LKIJLKJHKLI');

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
  `caracteristicas` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vehicles`
--

INSERT INTO `vehicles` (`id`, `modelo`, `placas`, `driver`, `numero`, `caracteristicas`) VALUES
(2, 'MODELODD', 'MODELODDD', 5, '21444DD', 'CARADDD'),
(3, 'MOD', 'MAT', 4, '12145', 'ERGER5G'),
(4, 'NISSAN NP 300', 'MAHS-CC-333', 1, '154', 'CAMIONETA COLOR BLANCO'),
(5, 'JETTA', 'MAT98987987', 1, '99', 'JETTA COLOR ROJO CON PLACAS NUEVAS');

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
  ADD KEY `r_vehicle` (`vehicle`),
  ADD KEY `r_driver` (`driver`),
  ADD KEY `r_client` (`client`),
  ADD KEY `r_telefono` (`telefono`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT de la tabla `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT de la tabla `drivers`
--
ALTER TABLE `drivers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `properties`
--
ALTER TABLE `properties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `registros`
--
ALTER TABLE `registros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;
--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
--
-- AUTO_INCREMENT de la tabla `vehicles`
--
ALTER TABLE `vehicles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `adresses`
--
ALTER TABLE `adresses`
  ADD CONSTRAINT `CLIENT_ADDRESS` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `registros`
--
ALTER TABLE `registros`
  ADD CONSTRAINT `r_client` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_direccion` FOREIGN KEY (`direccion`) REFERENCES `adresses` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_driver` FOREIGN KEY (`driver`) REFERENCES `drivers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_telefono` FOREIGN KEY (`telefono`) REFERENCES `telephone_numbers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_usuario` FOREIGN KEY (`usuario`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `r_vehicle` FOREIGN KEY (`vehicle`) REFERENCES `vehicles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
