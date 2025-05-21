--2.feladat--
SELECT cim,eredeti FROM film WHERE magyarszoveg="Heltai Olga";
--3.feladat--
SELECT DISTINCT rendezo,szinkronrendezo FROM film WHERE ev > 2000;
--4.feladat--
SELECT magyarszoveg, cim FROM film WHERE rendezo="Christopher Nolan" AND studio="Mafilm Audio Kft." ORDER BY 1;
--5.feladat--
 SELECT eredeti, cim, szinesz, szerep FROM film INNER JOIN szinkron ON film.filmaz = szinkron.filmaz WHERE hang="Anger Zsolt";
--6.feladat--
SELECT eredeti, cim, COUNT(szinkid) FROM film INNER JOIN szinkron ON film.filmaz = szinkron.filmaz GROUP BY film.filmaz;
--7.feladat--
SELECT szerep, szinesz, hang FROM film INNER JOIN szinkron ON film.filmaz = szinkron.filmaz WHERE szerep LIKE "rab%" OR szerep LIKE "% rab%";