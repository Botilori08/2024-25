
DROP TABLE IF EXISTS hallgato;
CREATE TABLE hallgato (
  id varchar(100) NOT NULL,
  nev varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

DROP TABLE IF EXISTS jelentkezes;
CREATE TABLE jelentkezes (
  id int(11) NOT NULL,
  hallgatoid varchar(100) NOT NULL,
  vizsgaid int(11) NOT NULL,
  jeldatum date NOT NULL,
  ledatum date DEFAULT NULL,
  igazolt tinyint(1) DEFAULT NULL,
  jegy int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


DROP TABLE IF EXISTS vizsga;
CREATE TABLE vizsga (
  id int(11) NOT NULL,
  datum date NOT NULL,
  targy varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

ALTER TABLE hallgato
  ADD PRIMARY KEY (id);

ALTER TABLE jelentkezes
  ADD PRIMARY KEY (id);

ALTER TABLE jelentkezes
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;