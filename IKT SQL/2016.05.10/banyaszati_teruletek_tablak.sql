CREATE TABLE kapcsolo (
  telekid int(11) NOT NULL,
  nyersanyagid int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE nyersanyag (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE telek (
  id int(11) NOT NULL,
  telepules varchar(100) NOT NULL,
  muvmod varchar(100) NOT NULL,
  allapot varchar(2) NOT NULL,
  fedoszint double NOT NULL,
  fekuszint double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE nyersanyag
  ADD PRIMARY KEY (id);

ALTER TABLE telek
  ADD PRIMARY KEY (id);


ALTER TABLE nyersanyag
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE telek
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;