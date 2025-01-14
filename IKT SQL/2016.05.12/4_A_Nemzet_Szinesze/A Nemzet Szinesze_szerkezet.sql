
CREATE TABLE elismeres (
  id int(11) NOT NULL,
  szoveg varchar(100) NOT NULL
);


CREATE TABLE kapott (
  id int(11) NOT NULL,
  ev int(11) NOT NULL,
  szineszid int(11) NOT NULL,
  elismeresid int(11) NOT NULL
);


CREATE TABLE szinesz (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL,
  szuletesinev varchar(100) NOT NULL,
  valasztas date NOT NULL,
  szuletett date NOT NULL,
  szuletesihely varchar(100) NOT NULL,
  elhunyt date DEFAULT NULL,
  halalozasihely varchar(100) NOT NULL
);


ALTER TABLE elismeres
  ADD PRIMARY KEY (id);


ALTER TABLE kapott
  ADD PRIMARY KEY (id);

ALTER TABLE szinesz
  ADD PRIMARY KEY (id);


ALTER TABLE elismeres
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE kapott
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;


ALTER TABLE szinesz
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
