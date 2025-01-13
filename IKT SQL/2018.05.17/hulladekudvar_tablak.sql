
CREATE TABLE fajta (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL
);

CREATE TABLE gyujt (
  helyid int(11) NOT NULL,
  fajtaid int(11) NOT NULL
);

CREATE TABLE hely (
  id int(11) NOT NULL,
  kerulet varchar(100) NOT NULL,
  cim varchar(100) NOT NULL
);


ALTER TABLE fajta
  ADD PRIMARY KEY (id);

ALTER TABLE hely
  ADD PRIMARY KEY (id);


ALTER TABLE fajta
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE hely
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
