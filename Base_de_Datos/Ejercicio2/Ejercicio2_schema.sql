USE Ejercicio2

-- Table structure for table `País`
--

CREATE TABLE `ejercicio2`.`Pais` (
  `nombre` VARCHAR(45) NOT NULL,
  `n_participantes` INT UNSIGNED NOT NULL,
  `n_medallas` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`nombre`));
  
CREATE TABLE Deportista (
  matricula SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  apellido VARCHAR(45) NOT NULL,
  sexo VARCHAR(45) NOT NULL,
  pais VARCHAR(45) NOT NULL,
  PRIMARY KEY  (matricula)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

