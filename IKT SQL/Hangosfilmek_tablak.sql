
CREATE TABLE feladat (
  id int(11) NOT NULL,
  filmid int(11) NOT NULL,
  szemelyid int(11) NOT NULL,
  megnevezes varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE film (
  id int(11) NOT NULL,
  cim varchar(100) NOT NULL,
  gyartas int(4) NOT NULL,
  hossz int(11) DEFAULT NULL,
  bemutato date NOT NULL,
  youtube tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE szemely (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL,
  nem varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE feladat
  ADD PRIMARY KEY (id);

ALTER TABLE film
  ADD PRIMARY KEY (id);

ALTER TABLE szemely
  ADD PRIMARY KEY (id);


ALTER TABLE feladat
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE film
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE szemely
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
