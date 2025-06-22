use master;
go
drop database if exists PenjackiVodic;
go
create database PenjackiVodic;
go
use PenjackiVodic;

create table penjalista(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
ocjena int,
prilazMin int,
prilazMax int,
regija varchar(50) not null,
lokacija varchar(100),
orijentacija varchar(20),
nagib varchar(20)
);

create table sezone(
sifra int not null primary key identity(1,1),
naziv varchar(15) not null,
pocetak datetime not null,
kraj datetime not null
);

create table penjalisteSezona(
penjaliste int not null references penjalista(sifra),
sezona int not null references sezone(sifra)
);

create table sektori(
sifra int not null primary key identity(1,1),
naziv varchar(50),
penjaliste int not null references penjalista(sifra)
);

create table smjerovi(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
duzina int,
ocjena varchar(5),
sektor int not null references sektori(sifra)
);