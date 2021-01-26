create database SistemaM�dico
go

use SistemaM�dico
go

create table Loguear(
id int not null primary key identity (1,1),
Usuario nvarchar(50),
Contrase�a nvarchar(50)
)

create table M�dicos(
ID int not null identity (1,1),
Nombre nvarchar(100) primary key,
Exequatur nvarchar(50) null,
Especialidad nvarchar(50) null
)

create table Pacientes(
ID int not null identity (1,1),
C�dula bigint not null,
Nombre nvarchar(100) primary key,
Asegurado nvarchar(2)
)

create table Habitaci�n(
ID int not null identity (1,1),
N�mero int,
Tipo nvarchar(50) primary key,
Precio money
)

create table Citas(
ID int not null primary key identity (1,1),
M�dicosFK nvarchar(100) FOREIGN KEY REFERENCES M�dicos (Nombre),
PacienteFK nvarchar(100) FOREIGN KEY REFERENCES Pacientes (Nombre),
Fecha datetime
)

create table Internamientos(
ID int not null primary key identity (1,1),
PacienteFK nvarchar(100) FOREIGN KEY REFERENCES Pacientes (Nombre),
HabtFK nvarchar(50) FOREIGN KEY REFERENCES Habitaci�n (Tipo),
Fecha_Inicio date
)

create table Alta_M�dica(
ID int not null primary key identity (1,1),
InterFK int not null FOREIGN KEY REFERENCES Internamientos (ID),
Fecha_Salida date,
Precio_Pagar money
)

/*INSERT*/

select * from M�dicos

insert into Loguear values ('Bryan', 'madre123')

insert into M�dicos values ('Jos� Manuel', 'Egresado', 'Cirujano')

insert into Pacientes values ('40230287746', 'Bryan', 'Si')

insert into  Habitaci�n values ('69', 'Privada', '250')

insert into Citas values ('1', '', GETDATE())

insert into Internamientos values ('1', '1', GETDATE())

insert into Alta_M�dica(InterFK, Fecha_Salida) values ('1', '2020-08-21')


/*VIEWS*/


create view CitasM AS
select Ci.ID, Pa.Nombre as 'Paciente', Me.Nombre as 'Doctor', Ci.Fecha as 'Fecha de la Cita' from Citas Ci
join Pacientes Pa on Ci.PacienteFK = Pa.ID
join M�dicos Me on Ci.M�dicosFK = Me.ID

create view IngresoI AS
select ING.ID, P.Nombre as 'Paciente', H.Tipo 'Habitaci�n', H.Precio as 'Precio de la Habitaci�n',ING.Fecha_Inicio as 'Fecha inicio de internamiento' from Internamientos ING
join Pacientes P on ING.PacienteFK = P.ID
join Habitaci�n H on ING.HabtFK = H.ID

create view AltaM as 
select I.ID as 'ID Paciente Interno', P.Nombre as 'Paciente', H.Tipo as 'Habitaci�n', H.Precio as 'Precio habitaci�n', I.Fecha_Inicio as 'Fecha de Ingreso', AM.Fecha_Salida as 'Fecha de Salida', sum(datediff(dd, I.Fecha_Inicio, AM.Fecha_Salida)*H.Precio) as Precio_Pagar from Alta_M�dica AM
join Internamientos I on AM.InterFK = I.ID
join Habitaci�n H on I.HabtFK = H.Tipo
join Pacientes P on I.PacienteFK = P.Nombre
Group By (I.ID), (P.Nombre), (H.Tipo), (H.Precio), (I.Fecha_Inicio), (AM.Fecha_Salida), (AM.Precio_Pagar)

Update Alta_M�dica set Fecha_Salida= '20200218'

select * from Alta_M�dica
delete from Pacientes where ID = 1
