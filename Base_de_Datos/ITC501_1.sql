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

SELECT title FROM sakila.film WHERE title LIKE '%family%'; -- muestra de film todos los títulos que contengan la palabra familia
SELECT title, actors FROM sakila.film_list WHERE actors LIKE 'Nat_%';-- muestra los actores con prefijo "Nat"
SELECT sakila.film_list.title
FROM sakila.film_list
WHERE sakila.film_list.category 
LIKE 'Sci-Fi' AND sakila.film_list.rating LIKE 'PG'; -- dame las películas de Sci-Fi con rating de PG
-- otra opcion menos eficiente, pero más "sencilla"
SELECT title FROM sakila.film_list WHERE category LIKE 'Sci-Fi' AND rating LIKE 'PG';

-- Order by y limit 
-- order by: tipo de agrupación de elementos en un formato específico
-- limit: cuantos datos a dar
SELECT name FROM sakila.customer_list ORDER BY name LIMIT 10; -- as ascendente
SELECT name FROM sakila.customer_list ORDER BY name DESC LIMIT 10; -- desc descendente

SELECT address, district FROM sakila.address ORDER BY district, address; -- dirección y distrito de las personas que compraron, primero ordena por distrito y luego por dirección

SELECT address, district FROM sakila.address ORDER BY district ASC, address DESC LIMIT 10; 

SELECT id, name FROM sakila.customer_list ORDER BY id ASC LIMIT 10, 5; -- a partir del 10 dame 5 datos

-- INSERT se usa para agregar nuevos datos a una tabla existente
INSERT INTO sakila.language
VALUES (NULL,'Japanese',NOW());
SELECT * FROM sakila.language;

-- SELECT MAX(language_id) FROM sakila.language -- MAX me da el último id 
INSERT INTO sakila.language
VALUES (9,'Russian','2020-09-26 10:35:00');