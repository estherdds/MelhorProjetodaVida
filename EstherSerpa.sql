create database Esther_Serpa;
use Esther_Serpa;

create table tbl_Login(
cpf varchar (11) not null primary key,
email varchar (40) not null,
senha int not null
)engine = innodb;

create table tbl_dados(
id int not null auto_increment primary key,
eds varchar (100) not null,
e06 varchar (40) not null,
s19 varchar (40) not null
)engine = innodb;

create table tbl_usuario(
nome varchar (100) not null primary key,
telefone varchar (14) not null,
email varchar (40) not null,
senha varchar (40) not null
) engine = innodb;