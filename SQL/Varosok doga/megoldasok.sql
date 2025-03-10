-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
SELECT vnev FROM varos WHERE megyeId IN (SELECT megyeId FROM megye JOIN varos ON megye.id=megyeId WHERE vnev LIKE '%vásár%') AND vnev NOT LIKE '%vásár%';
-- 2. feladat:
SELECT vnev FROM varos WHERE nepesseg+1000 IN (SELECT nepesseg FROM varos);

-- 3. feladat:
SELECT vnev,nepesseg FROM varos WHERE ABS(nepesseg - (SELECT nepesseg FROM varos WHERE vnev='Nagyatád')) < 50 AND vnev!='Nagyatád';

-- 4. feladat:
SELECT vnev FROM varos WHERE vtipid IN (SELECT vtipid FROM varos) AND megyeId IN (SELECT megyeid FROM varos);


