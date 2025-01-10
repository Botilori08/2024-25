-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 9. feladat:
CREATE DATABASE vedettmadarak DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- 11. feladat:
UPDATE faj SET ertek=25 WHERE id=352;

-- 12. feladat:
SELECT nev,latin FROM faj WHERE evszam is NULL ORDER BY nev;

-- 13. feladat:
SELECT evszam, COUNT(nev) as "fajok szama" FROM faj WHERE evszam > 2000 GROUP BY evszam;

-- 14. feladat:
SELECT faj.nev AS faj ,csalad.nev as csalad ,rend.nev as rend, faj.ertek*1000 as "eszmei ertek" FROM  faj INNER JOIN csalad ON csaladId=csalad.id INNER JOIN rend ON rendId=rend.id WHERE ertek>500 ;
 
-- 15. feladat:
 SELECT csalad.nev as nev, AVG(ertek) FROM csalad INNER JOIN faj ON csalad.id=csaladId GROUP BY 1;
