-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:
CREATE DATABASE halozat DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- 12. feladat:
INSERT INTO megallok VALUES(198,"Kőbányai garázs");

-- 13. feladat:
UPDATE jaratok SET elsoAjtos=False WHERE id=20;

-- 14. feladat:
SELECT jaratSzam FROM jaratok WHERE elsoAjtos=True;

-- 15. feladat:
SELECT nev FROM megallok WHERE nev LIKE "%sétány%" ORDER BY nev;

-- 16. feladat:
SELECT sorszam, nev FROM megallok INNER JOIN halozat ON megallok.id=megallo INNER JOIN jaratok ON halozat.jarat=jaratok.id WHERE irany='A' AND jaratSzam ='CITY' ORDER BY 1;

-- 17. feladat:
SELECT nev as sorszam, COUNT(nev) AS jaratokSzama FROM megallok INNER JOIN halozat ON megallok.id=megallo GROUP BY 1 HAVING COUNT(nev)>3;


