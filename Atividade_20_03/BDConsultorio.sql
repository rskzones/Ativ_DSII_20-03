use master

drop database BdConsultorio

create database BdConsultorio

use BdConsultorio

create table tbFuncionario(
	idFunc int not null primary key identity (1,1),
	tipoFunc varchar,
)

create table tbUsuario (
	idUsuario int not null primary key identity (1,1),
	nomeDeUsuario nvarchar not null,
	senha nvarchar not null,
	idFunc int REFERENCES tbFuncionario(idFunc)
)

create table tbPaciente (
	idPaciente int not null primary key identity (1,1),
	nomePaciente nvarchar not null,
	dataNasc datetime,
	RG nvarchar,
    CPF nvarchar,
    telefone nvarchar,
    celular nvarchar,
    endereco nvarchar,
	tipoSanguineo varchar(4)
)

create table tbMedico(
	idMedico int not null primary key identity (1,1),
	nomeMedico nvarchar,
	dataNasc datetime,
	RG varchar,
    CPF nvarchar,
    telefone nvarchar,
    celular nvarchar,
    endereco nvarchar,
    salario nvarchar,
    idFunc int REFERENCES tbFuncionario(idFunc)
    
)

create table tbAtendente(
	idAtendente int not null primary key identity (1,1),
	nomeAtendente nvarchar,
	dataNasc datetime,
	RG varchar,
    CPF nvarchar,
    telefone nvarchar,
    endereco nvarchar,
    salario nvarchar,
    idFunc int REFERENCES tbFuncionario(idFunc),
) 

create table tbEspecialidade( 
	idEspec int not null primary key identity (1,1),
	nomeEspec nvarchar
)

create table tbFichaPaciente(
	idFicha int not null primary key identity (1,1),
	idPaciente int REFERENCES tbPaciente(idPaciente),
	idMedico int REFERENCES tbMedico(idMedico),
	idAtendente int REFERENCES tbAtendente(idAtendente),
	dataAtendimento datetime,
	dataSaida datetime,
	observacao nvarchar
)

create table tbMedicoEspecialidade(
	idMedEsp int not null primary key identity (1,1),
	idMedico int REFERENCES tbMedico(idMedico),
	idEspecialidade int REFERENCES tbEspecialidade(idEspec)
)

select * from tbUsuario;
select * from tbFichaPaciente;
select * from tbPaciente;
select * from tbAtendente;
select * from tbMedicoEspecialidade;