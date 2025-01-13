CREATE TABLE kapcsolo (
  telekid int(11) NOT NULL,
  nyersanyagid int(11) NOT NULL
);

CREATE TABLE nyersanyag (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
);

CREATE TABLE telek (
  id int(11) NOT NULL,
  telepules varchar(100) NOT NULL,
  muvmod varchar(100) NOT NULL,
  allapot varchar(2) NOT NULL,
  fedoszint double NOT NULL,
  fekuszint double NOT NULL
);


ALTER TABLE nyersanyag
  ADD PRIMARY KEY (id);

ALTER TABLE telek
  ADD PRIMARY KEY (id);


ALTER TABLE nyersanyag
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE telek
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;