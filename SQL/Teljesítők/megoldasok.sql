-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 1. feladat:
CREATE DATABASE teljesitok DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;
-- 3. feladat:
SELECT nev FROM teljesites WHERE nevelotag="ifj.";
-- 4. feladat:
SELECT telepules.nev,COUNT(*) as teljesitokszama FROM telepules INNER JOIN teljesites ON telepulesId=telepules.id GROUP BY 1;
-- 5. feladat:

-- 6. feladat:

