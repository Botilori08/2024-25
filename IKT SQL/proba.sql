

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";



DROP TABLE IF EXISTS `eloadas`;
CREATE TABLE `eloadas` (
  `id` int(11) NOT NULL,
  `moziid` int(11) NOT NULL,
  `kezdes` time NOT NULL,
  `szinkron` varchar(100) NOT NULL,
  `szabad` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;



INSERT INTO `eloadas` (`id`, `moziid`, `kezdes`, `szinkron`, `szabad`) VALUES
(1, 23, '20:00:00', 'magyar szinkronnal', -1),
(2, 26, '16:00:00', 'magyar felirattal', -1),
(3, 1, '18:00:00', 'magyar felirattal', -1),
(4, 1, '19:45:00', 'magyar felirattal', 0),
(5, 33, '16:45:00', 'magyar szinkronnal', -1),
(6, 33, '20:45:00', 'magyar szinkronnal', -1),
(7, 36, '14:00:00', 'magyar szinkronnal', -1),
(8, 36, '18:20:00', 'magyar szinkronnal', -1),
(9, 36, '20:15:00', 'magyar szinkronnal', 0),
(10, 36, '22:15:00', 'magyar felirattal', -1),
(11, 2, '10:00:00', 'magyar szinkronnal', -1),
(12, 2, '13:20:00', 'magyar szinkronnal', -1),
(13, 2, '17:15:00', 'magyar szinkronnal', -1),
(14, 2, '19:15:00', 'magyar szinkronnal', 0),
(15, 2, '21:15:00', 'magyar felirattal', -1),
(16, 3, '11:30:00', 'magyar szinkronnal', -1),
(17, 3, '16:10:00', 'magyar szinkronnal', 0),
(18, 3, '20:10:00', 'magyar szinkronnal', 0),
(19, 3, '22:10:00', 'magyar felirattal', -1),
(20, 4, '13:30:00', 'magyar szinkronnal', -1),
(21, 4, '16:30:00', 'magyar szinkronnal', -1),
(22, 4, '18:15:00', 'magyar szinkronnal', -1),
(23, 4, '20:15:00', 'magyar szinkronnal', -1),
(24, 4, '22:15:00', 'magyar felirattal', -1),
(25, 38, '14:00:00', 'magyar szinkronnal', -1),
(26, 38, '18:20:00', 'magyar szinkronnal', -1),
(27, 38, '20:15:00', 'magyar szinkronnal', 0),
(28, 38, '22:15:00', 'magyar felirattal', -1),
(29, 39, '14:00:00', 'magyar szinkronnal', -1),
(30, 39, '18:20:00', 'magyar szinkronnal', -1),
(31, 39, '20:15:00', 'magyar szinkronnal', -1),
(32, 39, '22:15:00', 'eredeti nyelven', -1),
(33, 43, '14:00:00', 'magyar szinkronnal', -1),
(34, 43, '18:20:00', 'magyar szinkronnal', -1),
(35, 43, '20:15:00', 'magyar szinkronnal', 0),
(36, 43, '22:15:00', 'magyar felirattal', -1),
(37, 6, '10:00:00', 'magyar szinkronnal', -1),
(38, 6, '14:30:00', 'magyar szinkronnal', -1),
(39, 6, '18:30:00', 'magyar felirattal', -1),
(40, 6, '20:30:00', 'magyar szinkronnal', -1),
(41, 6, '22:30:00', 'eredeti nyelven', -1),
(42, 56, '16:35:00', 'magyar felirattal', -1),
(43, 59, '16:00:00', 'magyar felirattal', -1),
(44, 62, '20:30:00', 'magyar szinkronnal', -1),
(45, 17, '13:15:00', 'magyar felirattal', -1),
(46, 17, '16:15:00', 'magyar felirattal', -1),
(47, 17, '19:15:00', 'magyar felirattal', -1),
(48, 19, '18:45:00', 'eredeti nyelven', -1),
(49, 70, '18:15:00', 'magyar felirattal', -1),
(50, 20, '21:00:00', 'magyar felirattal', 0),
(51, 48, '20:15:00', 'magyar szinkronnal', -1),
(52, 48, '22:15:00', 'magyar felirattal', -1),
(53, 57, '18:15:00', 'magyar felirattal', -1),
(54, 70, '20:00:00', 'magyar szinkronnal', -1),
(55, 68, '18:20:00', 'magyar szinkronnal', -1),
(56, 68, '20:15:00', 'magyar szinkronnal', 0),
(57, 61, '20:30:00', 'magyar szinkronnal', -1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `mozi`
--

DROP TABLE IF EXISTS `mozi`;
CREATE TABLE `mozi` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `irszam` varchar(4) NOT NULL,
  `varos` varchar(100) NOT NULL,
  `cim` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `mozi`
--

INSERT INTO `mozi` (`id`, `nev`, `irszam`, `varos`, `cim`) VALUES
(1, 'Art+ Cinema', '1073', 'Budapest', 'Erzsébet körút 39.'),
(2, 'Cinema City Allee', '1117', 'Budapest', 'Október huszonharmadika utca 8–10.'),
(3, 'Cinema City Aréna', '1087', 'Budapest', 'Kerepesi út 9.'),
(4, 'Cinema City Campona', '1222', 'Budapest', 'Nagytétényi út 37–43.'),
(5, 'Cinema City Duna Plaza', '1138', 'Budapest', 'Váci út 178.'),
(6, 'Cinema City Westend', '1062', 'Budapest', 'Váci út 1–3.'),
(7, 'Cirko-Gejzír', '1055', 'Budapest', 'Balassi Bálint utca 15–17.'),
(8, 'Corvin Budapest Filmpalota', '1082', 'Budapest', 'Corvin köz 1.'),
(9, 'Csepeli Mozi', '1211', 'Budapest', 'II. Rákóczi Ferenc út 154-170.'),
(10, 'Eurocenter-Sony Mozi', '1037', 'Budapest', 'Bécsi út 154.'),
(11, 'IMAX', '1087', 'Budapest', 'Kerepesi út 9.'),
(12, 'Kino Cafe', '1137', 'Budapest', 'Szent István körút 16.'),
(13, 'Lurdy Mozi', '1092', 'Budapest', 'Könyves Kálmán körút 12–14.'),
(14, 'Művész mozi', '1066', 'Budapest', 'Teréz körút 30.'),
(15, 'Palace Óbuda', '1037', 'Budapest', 'Bécsi út 154.'),
(16, 'Pólus Mozi', '1152', 'Budapest', 'Szentmihályi út 131.'),
(17, 'Puskin', '1053', 'Budapest', 'Kossuth Lajos utca 18.'),
(18, 'Sugár Mozi', '1143', 'Budapest', 'Örs vezér tér 24.'),
(19, 'Tabán Artmozi', '1016', 'Budapest', 'Krisztina körút 87–89.'),
(20, 'Toldi', '1054', 'Budapest', 'Bajcsy-Zsilinszky út 36–38.'),
(21, 'Uránia Nemzeti Filmszínház', '1088', 'Budapest', 'Rákóczi út 21.'),
(22, 'VIP-terem', '1087', 'Budapest', 'Kerepesi út 9.'),
(23, 'AGORA – Savaria Filmszínház', '9700', 'Szombathely', 'Mártírok tere 1.'),
(24, 'Ajkai Mozi', '8400', 'Ajka', 'Szabadság tér 13.'),
(25, 'Apolló Mozi Debrecen', '4025', 'Debrecen', 'Miklós utca 1.'),
(26, 'Apolló Mozi Pécs', '7621', 'Pécs', 'Perczel Mór utca 22.'),
(27, 'Apolló Mozi Salgótarján', '3100', 'Salgótarján', 'Fő tér 5.'),
(28, 'ART mozi', '8900', 'Zalaegerszeg', 'Széchenyi tér 4.'),
(29, 'Babits Mihály Művészetek Háza', '7100', 'Szekszárd', 'Szent István tér 10.'),
(30, 'Balaton Mozi', '8230', 'Balatonfüred', 'Horváth Mihály utca Szabadidő Központ'),
(31, 'Barátság Klubmozi Székesfehérvár', '8000', 'Székesfehérvár', 'III. Béla király tér 1.'),
(32, 'Belvárosi mozi', '6720', 'Szeged', 'Vaszy Viktor tér 3.'),
(33, 'Center Mozi', '5600', 'Békéscsaba', 'Andrássy út 37-43.'),
(34, 'Cinema Agria Mozi', '3300', 'Eger', 'Törvényház út 4.'),
(35, 'Cinema Bridge', '3200', 'Gyöngyös', 'Kiss Szaléz utca 22.'),
(36, 'Cinema City Alba', '8000', 'Székesfehérvár', 'Palotai utca 1.'),
(37, 'Cinema City Balaton', '8200', 'Veszprém', 'Budapest út 20–28.'),
(38, 'Cinema City Debrecen', '4026', 'Debrecen', 'Péterfia utca 18.'),
(39, 'Cinema City Győr Plaza', '9024', 'Győr', 'Vasvári Pál uta 1/a.'),
(40, 'Cinema City Kaposvár', '7400', 'Kaposvár', 'Berzseni Dániel utca 1–3.'),
(41, 'Cinema City Miskolc', '3525', 'Miskolc', 'Szentpáli utca 2–4.'),
(42, 'Cinema City Nyíregyháza', '4400', 'Nyíregyháza', 'Szegfű utca 75.'),
(43, 'Cinema City Pécs', '7632', 'Pécs', 'Megyeri út 76.'),
(44, 'Cinema City Savaria Plaza', '9700', 'Szombathely', 'Körmendi utca 52–54.'),
(45, 'Cinema City Sopron', '9400', 'Sopron', 'Lackner Kristóf utca 35.'),
(46, 'Cinema City Szeged Plaza', '6724', 'Szeged', 'Kossuth Lajos sugárút 119.'),
(47, 'Cinema City Szolnok', '5000', 'Szolnok', 'Ady Endre út 28.'),
(48, 'Cinema City Zala', '8900', 'Zalaegerszeg', 'Stadion út 5.'),
(49, 'Cinema Nagykanizsa', '8800', 'Nagykanizsa', 'Európa Tanács utca 2.'),
(50, 'Dózsa Mozi Centrum', '2400', 'Dunaújváros', 'Dózsa György tér 1.'),
(51, 'Est Mozi', '2890', 'Tata', 'Ady Endre út 21.'),
(52, 'Fontana Mozi Hévíz', '8380', 'Hévíz', 'Rákóczi utca 9.'),
(53, 'Gödöllői Mozi', '2100', 'Gödöllő', 'Szabadság tér 5.'),
(54, 'Jókai Mozi Komárom', '2900', 'Komárom', 'Táncsics Mihály utca 13.'),
(55, 'Kiskunhalasi Mozi', '6400', 'Kiskunhalas', 'Bethlen Gábor tér 1.'),
(56, 'Krúdy mozi', '4400', 'Nyíregyháza', 'Országzászló tér 8.'),
(57, 'Lehel Filmszínház Jászberény', '5100', 'Jászberény', 'Fürdő utca 3.'),
(58, 'Madách Filmszínház Balassagyarmat', '2660', 'Balassagyarmat', 'Bajcsy-Zsilinszky utca 8.'),
(59, 'Makk Kálmán Mozi', '4100', 'Berettyóújfalu', 'Szent István tér 5.'),
(60, 'Malom Mozi', '6000', 'Kecskemét', 'Korona utca 2. '),
(61, 'Mozaik Filmszínház Hódmezővasarhely', '6800', 'Hódmezővasarhely', 'Lánc utca 5.'),
(62, 'Művészetek Háza', '3530', 'Miskolc', ''),
(63, 'Otthon Mozi', '6000', 'Kecskemét', 'Kossuth tér 4.'),
(64, 'P\'Art Mozi', '2000', 'Szentendre', 'Dunakorzó 18.'),
(65, 'Petőfi Mozi Pápa', '8500', 'Pápa', 'Deák Ferenc utca 8.'),
(67, 'Sió Mozi', '8600', 'Siófok', 'Szabadság tér 6.'),
(68, 'Sopron Elit Mozi', '9400', 'Sopron', 'Torna utca 14.'),
(69, 'Szivárvány Kultúrpalota', '7400', 'Kaposvár', 'Noszlopy Gáspár utca 5-7.'),
(70, 'TISZApART mozi', '5000', 'Szolnok', 'Templom utca 4.'),
(71, 'Uránia Mozi Cegléd', '2700', 'Cegléd', 'Batthyány utca 1.'),
(72, 'Városi Mozi', '8300', 'Tapolca', 'Fő tér 1.'),
(73, 'Vértes Center Mozi', '2800', 'Tatabánya', 'Győri út 7–9.');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `eloadas`
--
ALTER TABLE `eloadas`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `mozi`
--
ALTER TABLE `mozi`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `eloadas`
--
ALTER TABLE `eloadas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT a táblához `mozi`
--
ALTER TABLE `mozi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
