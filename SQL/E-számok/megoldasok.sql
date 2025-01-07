---1.feladat---
CREATE DATABASE eszam DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;
---2.feladat---
SELECT nev FROM adalek WHERE mellekhatas=True;
---3.feladat---
SELECT DISTINCT fnev FROM adalek INNER JOIN funkcio ON adalek.kod=funkcio.kod WHERE adalek.nev like "%karamell";
---4.feladat---
SELECT nev,COUNT(fnev) FROM adalek INNER JOIN funkcio ON adalek.kod=funkcio.kod GROUP BY nev ORDER BY 2 desc LIMIT 1;
---5.feladat---

---6.feladat---

---7.feladat---
SELECT fnev as feladat,COUNT(az) as 'Vegyuletek-szama' FROM funkcio GROUP BY 1 ORDER BY 2 desc;