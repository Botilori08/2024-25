----1.feladat----
create database oregfak default character set=utf8 collate=utf8_hungarian_ci;
----2.feladat----
select faj,kormeret/100 as kormeret from fa where kormeret/100 > 9 order by faj;
----3.feladat----
select faj,kormeret,meres from fa order by kormeret desc limit 1;
----4.feladat----
select telepules, count(azon) as fadarabszam from fa group by telepules order by fadarabszam desc, telepules;
----5.feladat----
select nev, count(faj) as fak_szama from megye inner join fa on id=megyeid group by megye.nev;
----6.feladat----
