USE sakila
SELECT DATABASE(); -- para visualizar mi database 
SHOW TABLES; -- Sirve para visualizar las tablas disponibles 
SHOW COLUMNS FROM actor; -- me enseña las columnas de la tabla, con sus restricciones
-- Otro ejemplo 
SHOW COLUMNS FROM inventory; 
DESC film;-- desglosa  function noRepetido(str)
SELECT * FROM language; -- Selecciona todas las columnas y filas de la tabla lenguaje, es una proyección
SELECT * FROM city;
SELECT city, city FROM city;-- selecciona una columna en específico de una tabla
SELECT sakila.city.city, sakila.city.city -- Selecciona del esquema city, la tabla city, la columna city
FROM sakila.city;
SELECT city, last_update FROM sakila.city; -- Selección/proyección de dos columnas de una tabla

-- 
SELECT * FROM ITC501.prueba;

SELECT * FROM sakila.language WHERE name="English"; -- es una selección, presenta de la tabla lenguaje las filas en donde name sea equivalente a English
SELECT first_name FROM sakila.actor WHERE actor_id=3; -- selecciona cuando el id es 4 y luedo presenta solo la columna de first_name

-- Diferentes coincidencias
SELECT city FROM city WHERE country_id = 15;

SELECT language_id, name FROM sakila.language WHERE language_id <> 2; 
SELECT language_id, name FROM sakila.language WHERE language_id != 2; 
SELECT language_id, name FROM sakila.language WHERE NOT language_id = 2; -- Mejor opción
