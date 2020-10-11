-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-10-2020 a las 04:26:39
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
(5, 1, 'direccion nueva', '', 1),
(6, 3, '', '', 1),
(7, 3, 'DIRECCIUON 1', '', 1);

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
(1, 'PUBLICO EN GENERAL', '2018-01-06', '', '/106012018222600', '', ''),
(2, 'NOMBRE DEL NUEVO CLIENTE', '1992-01-24', '', '', '', ''),
(3, 'CLIENTE SIN NOMBRE', '1992-01-24', '', '', '', '');

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
(2730, 1, '01800', '', '', 0, 0),
(2731, 2, '464646466', '', '', 0, 1),
(2732, 3, '4646464664', '', '', 0, 1);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `drivers`
--
ALTER TABLE `drivers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `logs_login`
--
ALTER TABLE `logs_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
-- AUTO_INCREMENT de la tabla `registros_omitidos`
--
ALTER TABLE `registros_omitidos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `telephone_numbers`
--
ALTER TABLE `telephone_numbers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2733;

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
