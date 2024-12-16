-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
create database euroskills default charset=utf8 collate=utf8_hungarian_ci;
\C latin2
-- 3. feladat:
select count(id) as ermek from versenyzo where pont >=700;

-- 4. feladat:
SELECT DISTINCT orszagNev FROM versenyzo INNER JOIN orszag ON orszagId = orszag.id order by orszagNev;

-- 5. feladat:
SELECT szakmaNev, COUNT(*) as 'versenyzok szama' from szakma INNER JOIN versenyzo ON szakma.id=szakmaId group by 1 order by 2 desc;

-- 6. feladat:
SELECT nev,orszagNev,szakmaNev,pont FROM versenyzo INNER JOIN szakma ON szakma.id=szakmaId INNER JOIN orszag ON orszag.id=orszagId order by pont desc, nev limit 25;
