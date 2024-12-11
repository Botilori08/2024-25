
CREATE TABLE fajta (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE gyujt (
  helyid int(11) NOT NULL,
  fajtaid int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE hely (
  id int(11) NOT NULL,
  kerulet varchar(100) NOT NULL,
  cim varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE fajta
  ADD PRIMARY KEY (id);

ALTER TABLE hely
  ADD PRIMARY KEY (id);


ALTER TABLE fajta
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE hely
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
