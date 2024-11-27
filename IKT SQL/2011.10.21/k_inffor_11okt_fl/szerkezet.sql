
CREATE TABLE fa (
  azon int(11) NOT NULL,
  faj varchar(100) NOT NULL,
  kormeret int(11) NOT NULL,
  telepules varchar(100) NOT NULL,
  megyeid int(11) NOT NULL,
  meres int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

CREATE TABLE megye (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE fa
  ADD PRIMARY KEY (azon);

ALTER TABLE megye
  ADD PRIMARY KEY (id);


ALTER TABLE fa
  MODIFY azon int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE megye
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
