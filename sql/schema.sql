CREATE SCHEMA dbo;

    CREATE TABLE dbo."PERSON"
("Id" serial NOT NULL PRIMARY KEY,
 "name" text,
 "surname" text,
 "age" real,
 "city" text,
 "height" real );

drop table dbo."VISIT";
create table dbo."VISIT"
(
    "Id"  serial NOT NULL PRIMARY KEY,
    "PatientId"                   integer,
    "IzmeklejumaNr"             text,
    "IzmeklejumaDatums"         date,
    "VizitesAtkartojums"        text,
    "SkriningaNr"               text,
    "Anamneze"                  text,
    "IepriekshVeiktaTerapija"   text,
    "Alergijas"                 boolean,
    "TrnsformacijasZonasTips"   text,
    "Rezultati"                 text,
    "Sledziens"                 text,
    "NakosaKolposkopijasKontrole" date,
    p1 				boolean,
    p2 				boolean,
    p3 				boolean,
    p4 				boolean,
    p5 				boolean,
    m1 				boolean,
    m2 				boolean,
    m3 				boolean,
    FOREIGN KEY ("PatientId") REFERENCES dbo."PERSON"("Id")
);
insert into dbo."VISIT" ("PatientId",Alergijas)
values (1,false);

alter table dbo."VISIT" add column (VizitePirmreizejaAtkartota boolean);









DROP TABLE dbo."IMAGE";
CREATE TABLE dbo."IMAGE"
(
    "Id" serial NOT NULL PRIMARY KEY,
    "VisitId" integer,
    "ImagePath" text,
    FOREIGN KEY ("VisitId") REFERENCES dbo."VISIT"("Id")
);
