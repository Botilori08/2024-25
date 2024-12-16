-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
 create database nagykonyv default charset=utf8 collate=utf8_hungarian_ci;

-- 3. feladat:
SELECT DISTINCT nemzetiseg FROM szerzo WHERE nemzetiseg!='magyar';

-- 4. feladat:
SELECT nev, 2005-szulEv as kor FROM szerzo WHERE halEv is NULL;

-- 5. feladat:


-- 6. feladat:

