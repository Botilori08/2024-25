CREATE TABLE alkoto (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE kapcsolat (
  id int(11) NOT NULL,
  muid int(11) NOT NULL,
  tipus varchar(100) NOT NULL,
  alkotoid int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


CREATE TABLE mu (
  id int(11) NOT NULL,
  cim varchar(100) NOT NULL,
  eredeti varchar(100) NOT NULL,
  szinhaz varchar(100) NOT NULL,
  ev int(4) DEFAULT NULL,
  felvonas int(11) DEFAULT NULL,
  kep varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE alkoto
  ADD PRIMARY KEY (id);

ALTER TABLE kapcsolat
  ADD PRIMARY KEY (id);

ALTER TABLE mu
  ADD PRIMARY KEY (id);

ALTER TABLE alkoto
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE kapcsolat
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE mu
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;