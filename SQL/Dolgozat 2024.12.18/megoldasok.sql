-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 1. feladat:
CREATE DATABASE verseny DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;
\C latin2
-- 3. feladat:
DELETE FROM csapat WHERE id=21;

-- 4. feladat:
SELECT nev FROM versenyzo WHERE nemzetiseg='HUN' ORDER BY nev;

-- 5. feladat:
SELECT nemzetiseg, COUNT(*) as indulokSzama FROM versenyzo GROUP BY nemzetiseg ORDER BY 2 desc;

-- 6. feladat:
SELECT szakasz, ido FROM eredmeny INNER JOIN versenyzo ON versenyzoId=versenyzo.id WHERE versenyzo.nev='Valter Attila';
 
-- 7. feladat:
SELECT csapatNev, COUNT(nemzetiseg) as magyarokSzama FROM csapat JOIN versenyzo ON csapat.id=csapatId WHERE nemzetiseg='HUN' GROUP BY 1 HAVING COUNT(2) > 1;
