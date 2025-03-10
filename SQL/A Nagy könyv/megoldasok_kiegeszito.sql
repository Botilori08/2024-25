-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- A. feladat:
SELECT nev,(SELECT MIN(helyezes) FROM konyv WHERE szerzo.id=szerzoId) FROM szerzo;
SELECT nev,helyezes FROM szerzo INNER JOIN konyv ON szerzo.id=szerzoId GROUP BY 1;
-- B. feladat:
SELECT nev, (SELECT COUNT(*) FROM konyv WHERE szerzo.id=szerzoId) FROM szerzo;
SELECT nev, COUNT(*) FROM szerzo INNER JOIN konyv ON szerzo.id=szerzoId GROUP BY 1;
-- C. feladat:
SELECT nev,szulEv FROM szerzo WHERE nev != 'Kertész Imre' AND szulEv IN (SELECT szulEv FROM szerzo WHERE nev='Kertész Imre');

-- D. feladat:
SELECT nev,szulEv FROM szerzo WHERE nemzetiseg!='magyar' AND szulEv IN (SELECT szulEv FROM szerzo WHERE nemzetiseg='magyar');

-- E. feladat:

