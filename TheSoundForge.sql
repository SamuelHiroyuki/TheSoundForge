create database dbTheSoundForger;
go
use dbTheSoundForger;

drop table tbFuncionario;
go
create table tbFuncionario(
	ID_func int primary key identity(1,1),
	Nome_func varchar(50) not null,
	End_func varchar(50) not null,
	Cidade_func varchar(50) not null,
	UF_func char(2) not null,
	CEP_func char(8) not null,
	Tel_func char(8),
	Cel_func char(9),
	usuario varchar(20) not null,
	senha varchar(10) not null
);
go
insert into tbFuncionario(Nome_func, End_func, Cidade_func, UF_func, CEP_func, Tel_func, Cel_func, usuario, senha)
values ('Samuel H.', 'Rua Sala 2', 'Bginfo', 'BG', '12345678', '99998888', '988889999', 'AdmSam', '123'),
('Lucas C.', 'Rua Sala 2', 'Bginfo', 'BG', '87654321', '77773333', '933337777', 'UserClaro', '123'),
('Pedro H.', 'Rua Sala 2', 'Bginfo', 'BG', '12348765', '11112222', '922221111', 'UserPH', '123')

select * from tbFuncionario