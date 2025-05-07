-- CRIANDO O BANCO DE DADOS
-- drop database dbExemplo;
create database dbExemplo;

-- USANDO O BANCO DE DADOS
use dbExemplo;

-- CRIANDO AS TABELAS DO BANCO
create table Usuarios(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null 
);

-- CONSULTANDO OS DADOS DO BANCO
select * from Usuarios