
CREATE TABLE adatok (
  AZON int(11) NOT NULL,
  versenynev varchar(100) NOT NULL,
  tipus varchar(100) NOT NULL,
  esemeny varchar(100) NOT NULL,
  datum date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE adatok
  ADD PRIMARY KEY (AZON);


ALTER TABLE adatok
  MODIFY AZON int(11) NOT NULL AUTO_INCREMENT;

