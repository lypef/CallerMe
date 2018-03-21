-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-03-2018 a las 06:04:17
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cltaestacionamiento`
--
CREATE DATABASE IF NOT EXISTS `cltaestacionamiento` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cltaestacionamiento`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `name` varchar(254) NOT NULL,
  `address` varchar(254) NOT NULL,
  `phone` varchar(254) NOT NULL,
  `mail` varchar(254) NOT NULL,
  `rfc` varchar(254) NOT NULL,
  `razonsocial` varchar(254) NOT NULL,
  `foto` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clients`
--

INSERT INTO `clients` (`id`, `name`, `address`, `phone`, `mail`, `rfc`, `razonsocial`, `foto`) VALUES
(1, 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '20 DE NOVIEMBRE 306', '9231200505', 'LYPEF@LIVE.COMS', 'AEDF9201245G3', 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ', '/106032018234242.jpg'),
(5, 'KARINA LOPEZ GUZMAN', 'DIRE', '000', '@', 'RTFRC', 'SOCIAL', '/12601201812240.jpg'),
(6, 'HOLA MUNDO', '', '', '', '', '', '/12601201812320.jpg'),
(7, 'HOLA MUNDO 2 ', '', '', '', '', '', '/12601201812328.jpg'),
(8, 'ME GUSTA QUE LLUEVA PERO NO ME GUSTA EL SONIDO EN LA LAMINA', '', '', '', '', '', '/12601201812353.jpg'),
(9, 'LENE', '', '', '', '', '', '/12601201815718.jpg'),
(10, 'PUBLICO EN GENERAL ', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `delivery_tmp`
--

CREATE TABLE `delivery_tmp` (
  `id` int(11) NOT NULL,
  `product` varchar(254) NOT NULL,
  `vehicle` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permissions`
--

CREATE TABLE `permissions` (
  `user` int(11) NOT NULL,
  `client_access` tinyint(1) NOT NULL,
  `client_add` tinyint(1) NOT NULL,
  `client_edit` tinyint(1) NOT NULL,
  `client_delete` tinyint(1) NOT NULL,
  `vehicle_access` tinyint(1) NOT NULL,
  `vehicle_add` tinyint(1) NOT NULL,
  `vehicle_edit` tinyint(1) NOT NULL,
  `vehicle_delete` tinyint(1) NOT NULL,
  `rate_access` tinyint(1) NOT NULL,
  `rate_add` tinyint(1) NOT NULL,
  `rate_edit` tinyint(1) NOT NULL,
  `rate_delete` tinyint(1) NOT NULL,
  `assign_access` tinyint(1) NOT NULL,
  `vtd_access` tinyint(1) NOT NULL,
  `vtd_add` tinyint(1) NOT NULL,
  `vtd_edit` tinyint(1) NOT NULL,
  `vtd_delete` tinyint(1) NOT NULL,
  `ventas_access` tinyint(1) NOT NULL,
  `user_access` tinyint(1) NOT NULL,
  `user_add` tinyint(1) NOT NULL,
  `user_edit` tinyint(1) NOT NULL,
  `user_delete` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `permissions`
--

INSERT INTO `permissions` (`user`, `client_access`, `client_add`, `client_edit`, `client_delete`, `vehicle_access`, `vehicle_add`, `vehicle_edit`, `vehicle_delete`, `rate_access`, `rate_add`, `rate_edit`, `rate_delete`, `assign_access`, `vtd_access`, `vtd_add`, `vtd_edit`, `vtd_delete`, `ventas_access`, `user_access`, `user_add`, `user_edit`, `user_delete`) VALUES
(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `product_services`
--

CREATE TABLE `product_services` (
  `codebar` varchar(254) NOT NULL,
  `nombre` varchar(254) NOT NULL,
  `descripcion` varchar(254) NOT NULL,
  `precio` float NOT NULL,
  `stock` int(11) NOT NULL,
  `vendidos` int(11) NOT NULL,
  `image` varchar(254) NOT NULL,
  `service` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `product_services`
--

INSERT INTO `product_services` (`codebar`, `nombre`, `descripcion`, `precio`, `stock`, `vendidos`, `image`, `service`) VALUES
('00856750426281593', 'COCA COLA', 'DESCRIPCION', 15, 50, 0, '/106032018235255.jpg', 0),
('0168671089768722', 'AGUA ENBOTELLADA CIEL', 'AGUA 1 LT', 20, 56, 0, '/112032018105722', 0),
('0678450554925227', 'LAVADO Y ASPIRADO', 'LAVADO Y ASPIRADO EN INTERIORES PARA MEJORAR INFECCIONES', 50, 0, 0, '/112032018105643', 1),
('0959775507897034', 'SERVICIO', 'DESCRUIPOC', 15, 0, 0, '/108032018101647.jpg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarifas`
--

CREATE TABLE `tarifas` (
  `id` int(11) NOT NULL,
  `name` varchar(254) NOT NULL,
  `tolerance_minutes` int(11) NOT NULL,
  `costo_minimo` double NOT NULL,
  `price_hora` double NOT NULL,
  `price_dia` double NOT NULL,
  `price_pension` double NOT NULL,
  `dias_pencion` int(11) NOT NULL,
  `use_fraccion` tinyint(1) NOT NULL,
  `horas_dias` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tarifas`
--

INSERT INTO `tarifas` (`id`, `name`, `tolerance_minutes`, `costo_minimo`, `price_hora`, `price_dia`, `price_pension`, `dias_pencion`, `use_fraccion`, `horas_dias`) VALUES
(1, 'VEHICULOS COMPACTOS', 20, 20, 19, 85, 1100, 30, 1, 12),
(2, 'CAMIONETAS 3 TONELADAS', 15, 25, 25, 95, 1500, 30, 1, 12),
(3, 'MOTOCICLETAS', 15, 15, 10, 45, 450, 30, 1, 8),
(5, 'CAMIONES PESADOS 1 EJE', 25, 40, 35, 150, 1800, 30, 1, 12),
(6, 'CAMIONES PESADOS 2 EJES', 25, 60, 40, 180, 2800, 30, 1, 24),
(7, 'CAMIONETAS 1.5 - 2 TONELADAS', 25, 25, 20, 130, 1400, 30, 1, 12);

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
(1, 'root', '63a9f0ea7bb98050796b649e85481845', 'FRANCISCO EDUARDO ASCENCIO DOMINGUEZ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehicles`
--

CREATE TABLE `vehicles` (
  `matricula` varchar(254) NOT NULL,
  `client` int(11) NOT NULL,
  `tarifa` int(11) NOT NULL,
  `modelo` varchar(254) NOT NULL,
  `color` varchar(254) NOT NULL,
  `estado` varchar(254) NOT NULL,
  `rfid` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `fecha_ingreso` datetime NOT NULL,
  `fecha_salida` datetime NOT NULL,
  `tarifa_hora` tinyint(1) NOT NULL,
  `tarifa_dia` tinyint(1) NOT NULL,
  `tarifa_pension` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vehicles`
--

INSERT INTO `vehicles` (`matricula`, `client`, `tarifa`, `modelo`, `color`, `estado`, `rfid`, `status`, `fecha_ingreso`, `fecha_salida`, `tarifa_hora`, `tarifa_dia`, `tarifa_pension`) VALUES
('AEFT', 1, 2, 'RAM 3.5', 'ROJA', '', 5953908, 0, '2018-02-07 00:42:58', '2018-04-08 00:42:55', 0, 0, 1),
('APOE', 5, 5, 'PETERBILT', 'VERDE', '', 16521612, 0, '2018-03-17 04:49:43', '2018-03-11 01:06:16', 1, 0, 0),
('DWQDQWDW', 6, 6, 'WQDWQDWD', 'WQDWQD', 'WQDWQD', 0, 0, '2018-03-12 10:45:31', '2018-04-08 00:25:52', 1, 0, 0),
('EWFEW3FE', 9, 1, 'CHEVY C2', 'AZUL', '', 0, 0, '2018-03-10 14:14:27', '2018-03-11 02:14:26', 0, 1, 0),
('IKLOJIKLJHK', 7, 6, 'TRAILER 2 EJES CARGADP', 'VERDE', 'FRUTAS Y VERDURAS', 5935244, 1, '2018-03-12 11:00:15', '2018-03-08 23:19:30', 1, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_ticket` int(11) NOT NULL,
  `concepto` varchar(254) NOT NULL,
  `monto` float NOT NULL,
  `date` datetime NOT NULL,
  `producto` tinyint(1) NOT NULL,
  `service` tinyint(1) NOT NULL,
  `membresia` tinyint(1) NOT NULL,
  `cut_x` tinyint(1) NOT NULL,
  `cut_z` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id`, `id_cliente`, `id_usuario`, `id_ticket`, `concepto`, `monto`, `date`, `producto`, `service`, `membresia`, `cut_x`, `cut_z`) VALUES
(58, 1, 1, 0, 'pago de un producto x', 0, '2018-03-01 04:00:00', 1, 0, 0, 0, 0),
(79, 1, 1, 1, 'COCA COLA', 15, '2018-03-11 13:12:06', 1, 0, 0, 0, 0),
(80, 1, 1, 1, 'SERVICIO', 15, '2018-03-11 13:12:06', 0, 1, 0, 0, 0),
(81, 1, 1, 2, 'COCA COLA', 15, '2018-03-11 13:17:24', 1, 0, 0, 0, 0),
(82, 1, 1, 2, 'SERVICIO', 15, '2018-03-11 13:17:25', 0, 1, 0, 0, 0),
(83, 1, 1, 2, 'COCA COLA', 15, '2018-03-11 13:17:25', 1, 0, 0, 0, 0),
(84, 1, 1, 2, 'SERVICIO', 15, '2018-03-11 13:17:25', 0, 1, 0, 0, 0),
(85, 5, 1, 3, 'COCA COLA', 15, '2018-03-11 13:18:15', 1, 0, 0, 0, 0),
(86, 5, 1, 3, 'SERVICIO', 15, '2018-03-11 13:18:15', 0, 1, 0, 0, 0),
(88, 1, 1, 4, 'COBRO TIEMPO', 40, '2018-03-11 13:26:12', 0, 0, 1, 0, 0),
(93, 5, 1, 5, 'COBRO TIEMPO', 40, '2018-03-11 13:36:14', 0, 0, 1, 0, 0),
(94, 5, 1, 6, 'COCA COLA', 15, '2018-03-11 13:36:43', 1, 0, 0, 0, 0),
(95, 5, 1, 6, 'COBRO TIEMPO', 40, '2018-03-11 13:36:44', 0, 0, 1, 0, 0),
(96, 5, 1, 7, 'COCA COLA', 15, '2018-03-11 13:38:08', 1, 0, 0, 0, 0),
(97, 5, 1, 7, 'COCA COLA', 15, '2018-03-11 13:38:08', 1, 0, 0, 0, 0),
(98, 5, 1, 7, 'COCA COLA', 15, '2018-03-11 13:38:08', 1, 0, 0, 0, 0),
(99, 5, 1, 7, 'COCA COLA', 15, '2018-03-11 13:38:08', 1, 0, 0, 0, 0),
(100, 5, 1, 7, 'SERVICIO', 15, '2018-03-11 13:38:08', 0, 1, 0, 0, 0),
(101, 5, 1, 7, 'SERVICIO', 15, '2018-03-11 13:38:08', 0, 1, 0, 0, 0),
(102, 5, 1, 7, 'SERVICIO', 15, '2018-03-11 13:38:08', 0, 1, 0, 0, 0),
(103, 5, 1, 7, 'COBRO TIEMPO', 40, '2018-03-11 13:38:08', 0, 0, 1, 0, 0),
(104, 10, 1, 8, 'COCA COLA', 15, '2018-03-12 10:37:54', 1, 0, 0, 0, 0),
(105, 6, 1, 9, 'COCA COLA', 15, '2018-03-12 10:38:54', 1, 0, 0, 0, 0),
(106, 6, 1, 9, 'COBRO TIEMPO', 60, '2018-03-12 10:38:54', 0, 0, 1, 0, 0),
(107, 10, 1, 10, 'COCA COLA', 15, '2018-03-12 10:45:36', 1, 0, 0, 0, 0),
(108, 10, 1, 10, 'SERVICIO', 15, '2018-03-12 10:45:36', 0, 1, 0, 0, 0),
(109, 1, 1, 11, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 10:58:04', 1, 0, 0, 0, 0),
(110, 1, 1, 11, 'LAVADO Y ASPIRADO', 50, '2018-03-12 10:58:04', 0, 1, 0, 0, 0),
(111, 1, 1, 11, 'COBRO TIEMPO', 0, '2018-03-12 10:58:04', 0, 0, 1, 0, 0),
(112, 7, 1, 12, 'SERVICIO', 15, '2018-03-12 10:58:18', 0, 1, 0, 0, 0),
(113, 7, 1, 12, 'COCA COLA', 15, '2018-03-12 10:58:18', 1, 0, 0, 0, 0),
(114, 7, 1, 12, 'COBRO TIEMPO', 60, '2018-03-12 10:58:18', 0, 0, 1, 0, 0),
(115, 6, 1, 13, 'COCA COLA', 15, '2018-03-12 10:58:45', 1, 0, 0, 0, 0),
(116, 6, 1, 13, 'SERVICIO', 15, '2018-03-12 10:58:45', 0, 1, 0, 0, 0),
(117, 6, 1, 13, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 10:58:45', 1, 0, 0, 0, 0),
(118, 6, 1, 13, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 10:58:45', 1, 0, 0, 0, 0),
(119, 6, 1, 13, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 10:58:45', 1, 0, 0, 0, 0),
(120, 6, 1, 13, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 10:58:45', 1, 0, 0, 0, 0),
(121, 6, 1, 13, 'COBRO TIEMPO', 60, '2018-03-12 10:58:45', 0, 0, 1, 0, 0),
(122, 1, 1, 14, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 11:01:14', 1, 0, 0, 0, 0),
(123, 1, 1, 14, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 11:01:15', 1, 0, 0, 0, 0),
(124, 1, 1, 14, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 11:01:15', 1, 0, 0, 0, 0),
(125, 1, 1, 14, 'AGUA ENBOTELLADA CIEL', 20, '2018-03-12 11:01:16', 1, 0, 0, 0, 0),
(126, 1, 1, 14, 'COBRO TIEMPO', 0, '2018-03-12 11:01:16', 0, 0, 1, 0, 0),
(127, 5, 1, 15, 'COCA COLA', 15, '2018-03-17 04:50:39', 1, 0, 0, 0, 0),
(128, 5, 1, 15, 'COBRO TIEMPO', 40, '2018-03-17 04:50:39', 0, 0, 1, 0, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `delivery_tmp`
--
ALTER TABLE `delivery_tmp`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vehicle_matricula` (`vehicle`),
  ADD KEY `product_id` (`product`);

--
-- Indices de la tabla `permissions`
--
ALTER TABLE `permissions`
  ADD UNIQUE KEY `user` (`user`);

--
-- Indices de la tabla `product_services`
--
ALTER TABLE `product_services`
  ADD PRIMARY KEY (`codebar`);

--
-- Indices de la tabla `tarifas`
--
ALTER TABLE `tarifas`
  ADD PRIMARY KEY (`id`);

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
  ADD PRIMARY KEY (`matricula`),
  ADD UNIQUE KEY `matricula` (`matricula`),
  ADD UNIQUE KEY `matricula_2` (`matricula`),
  ADD UNIQUE KEY `matricula_3` (`matricula`),
  ADD UNIQUE KEY `matricula_4` (`matricula`,`rfid`),
  ADD KEY `client_vehiculo` (`client`),
  ADD KEY `tarifa_vehiculo` (`tarifa`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_usuarios` (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `delivery_tmp`
--
ALTER TABLE `delivery_tmp`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tarifas`
--
ALTER TABLE `tarifas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `delivery_tmp`
--
ALTER TABLE `delivery_tmp`
  ADD CONSTRAINT `product_id` FOREIGN KEY (`product`) REFERENCES `product_services` (`codebar`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `vehicle_matricula` FOREIGN KEY (`vehicle`) REFERENCES `vehicles` (`matricula`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `permissions`
--
ALTER TABLE `permissions`
  ADD CONSTRAINT `user_permission` FOREIGN KEY (`user`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `vehicles`
--
ALTER TABLE `vehicles`
  ADD CONSTRAINT `client_vehiculo` FOREIGN KEY (`client`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tarifa_vehiculo` FOREIGN KEY (`tarifa`) REFERENCES `tarifas` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `id_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `id_usuarios` FOREIGN KEY (`id_usuario`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
