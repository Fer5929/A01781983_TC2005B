


-- 1: Apellidos y nombre de los participantes de nacionalidad mexicana.
SELECT nombre, apellido
FROM Deportista
WHERE pais = 'Mexico';

-- 2:Apellidos, nombre y puntos acumulados de los participantes de USA.
-- Se usó Argentina pues vi que no tenía un valor con USA
SELECT d.apellido, d.nombre, SUM(r.mat_Oro + r.mat_Pl + r.mat_Br) AS puntos_acumulados -- Cuenta el total de puntos aka medallas ganadas
FROM Deportista d
JOIN Resultado r ON d.matricula = r.matricula
WHERE d.pais = 'Argentina'
GROUP BY d.apellido, d.nombre;

-- 3:Apellidos y nombre de los participantes que se clasificaron en primer lugar en al menos una competencia.
SELECT d.apellido, d.nombre
FROM Deportista d -- Revisa deportista
WHERE EXISTS (
  SELECT *
  FROM Resultado r -- revisa Resultado 
  WHERE d.matricula = r.matricula AND r.mat_Oro > 0 -- si tiene alguna medalla de oro significa que si o si tiene un primer lugar
);-- d.matricula = r.matricula hace el match con la matricula para obtención de datos

-- 4: Nombre de las competencias en las que intervinieron los participantes mexicanos.
SELECT  pr.disciplina
FROM Prueba pr
JOIN Resultado r ON pr.id = r.disciplina
JOIN Deportista d ON r.matricula = d.matricula
WHERE d.pais = 'Mexico';

-- 5:Apellidos y nombre de los participantes que nunca se clasificaron en primer lugar en alguna competencia.
SELECT d.apellido, d.nombre
FROM Deportista d
WHERE NOT EXISTS ( -- lo contrario a 3
  SELECT *
  FROM Resultado r
  WHERE d.matricula = r.matricula AND r.mat_Oro > 0
);
-- 6: Apellidos y nombre de los participantes siempre se clasificaron en alguna competencia.
SELECT d.apellido, d.nombre
FROM Deportista d
WHERE NOT EXISTS (
  SELECT *
  FROM Prueba pr -- seleccion de prueba con alias pr
  LEFT JOIN Resultado r ON pr.id = r.disciplina AND d.matricula = r.matricula
  -- uso de left joun para disciplina y resultado conservando todas las filas de la tabla izquierda y mostrando los valores coincidentes de la tabla derecha.
  WHERE r.matricula IS NULL
);


-- 7:Nombre de la competencia que aporta el máximo de puntos. 
-- disciplina con el mayor numero de medallas de oro 
SELECT disciplina
FROM Resultado
WHERE mat_Oro = (
  SELECT MAX(mat_Oro)
  FROM Resultado
);
-- 8: Países (nacionalidades) que participaron en todas las competencias.


-- 9:promedio medallas de plata
SELECT AVG(mat_Pl) AS promedio_plata
FROM Resultado;
 
-- 10:número de participantes por país
SELECT p.nombre AS pais, COUNT(*) AS total_participantes -- contar participantes
FROM Pais p
JOIN Deportista d ON p.nombre = d.pais -- unión de tablas
GROUP BY p.nombre; -- agrupar datos por el nombre del país
















