/*1. feladat--
create database oregfak default character set=utf8 collate=utf8_hungarian_ci;
/*2. feladat*/
select faj,kormeret/100 as kormeret from fa where kormeret/100 > 9 order by faj;
/*3. feladat*/
select faj,kormeret,meres from fa order by kormeret desc limit 1;
/*4. feladat*/
select telepules, count(faj) as fadarabszam from fa group by faj order by fadarabszam desc,telepules asc;
/*2. feladat*/