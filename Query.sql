create database SistemaMédico
go

use SistemaMédico
go

create table Loguear(
id int not null primary key identity (1,1),
Usuario nvarchar(50),
Contraseña nvarchar(50)
)

create table Médicos(
ID int not null identity (1,1),
Nombre nvarchar(100) primary key,
Exequatur nvarchar(50) null,
Especialidad nvarchar(50) null
)

create table Pacientes(
ID int not null identity (1,1),
Cédula bigint not null,
Nombre nvarchar(100) primary key,
Asegurado nvarchar(2)
)

create table Habitación(
ID int not null identity (1,1),
Número int,
Tipo nvarchar(50) primary key,
Precio money
)

create table Citas(
ID int not null primary key identity (1,1),
MédicosFK nvarchar(100) FOREIGN KEY REFERENCES Médicos (Nombre),
PacienteFK nvarchar(100) FOREIGN KEY REFERENCES Pacientes (Nombre),
Fecha datetime
)

create table Internamientos(
ID int not null primary key identity (1,1),
PacienteFK nvarchar(100) FOREIGN KEY REFERENCES Pacientes (Nombre),
HabtFK nvarchar(50) FOREIGN KEY REFERENCES Habitación (Tipo),
Fecha_Inicio date
)

create table Alta_Médica(
ID int not null primary key identity (1,1),
InterFK int not null FOREIGN KEY REFERENCES Internamientos (ID),
Fecha_Salida date,
Precio_Pagar money
)

/*INSERT*/

select * from Médicos

insert into Loguear values ('Bryan', 'madre123')

insert into Médicos values ('José Manuel', 'Egresado', 'Cirujano')

insert into Pacientes values ('40230287746', 'Bryan', 'Si')

insert into  Habitación values ('69', 'Privada', '250')

insert into Citas values ('1', '', GETDATE())

insert into Internamientos values ('1', '1', GETDATE())

insert into Alta_Médica(InterFK, Fecha_Salida) values ('1', '2020-08-21')


/*VIEWS*/


create view CitasM AS
select Ci.ID, Pa.Nombre as 'Paciente', Me.Nombre as 'Doctor', Ci.Fecha as 'Fecha de la Cita' from Citas Ci
join Pacientes Pa on Ci.PacienteFK = Pa.ID
join Médicos Me on Ci.MédicosFK = Me.ID

create view IngresoI AS
select ING.ID, P.Nombre as 'Paciente', H.Tipo 'Habitación', H.Precio as 'Precio de la Habitación',ING.Fecha_Inicio as 'Fecha inicio de internamiento' from Internamientos ING
join Pacientes P on ING.PacienteFK = P.ID
join Habitación H on ING.HabtFK = H.ID

create view AltaM as 
select I.ID as 'ID Paciente Interno', P.Nombre as 'Paciente', H.Tipo as 'Habitación', H.Precio as 'Precio habitación', I.Fecha_Inicio as 'Fecha de Ingreso', AM.Fecha_Salida as 'Fecha de Salida', sum(datediff(dd, I.Fecha_Inicio, AM.Fecha_Salida)*H.Precio) as Precio_Pagar from Alta_Médica AM
join Internamientos I on AM.InterFK = I.ID
join Habitación H on I.HabtFK = H.Tipo
join Pacientes P on I.PacienteFK = P.Nombre
Group By (I.ID), (P.Nombre), (H.Tipo), (H.Precio), (I.Fecha_Inicio), (AM.Fecha_Salida), (AM.Precio_Pagar)

Update Alta_Médica set Fecha_Salida= '20200218'

select * from Alta_Médica
delete from Pacientes where ID = 1
