create database Notas_Prueva
use Notas_Prueva

create table Alumno
(
CodigoAlumno int identity(1,1) primary key,
PrimerNombre varchar(10),
SegundoNombre varchar(10),
PrimerApellido varchar(10),
SegundoApellido varchar(10),
especialidad varchar(20)
) 

create table grado(
Codgrado int identity(1,1) primary key,
grado char(1),
secccion char(1),
)

create table notas
(
Codigoaalumno int ,
Codgrado int,
codigoasignatura int,
notafinal int,
)

create table Asignatura (
CodAsignatura int identity (1,1) primary key,
NombreAsignatura varchar(20),
)
 
alter table notas add foreign key (Codigoaalumno) references Alumno(CodigoAlumno)
alter table notas add foreign key (Codgrado) references grado(Codgrado)
alter table notas add foreign key (codigoasignatura ) references Asignatura(CodAsignatura)

create proc notasalumno
@codalumno int
as 
begin
select PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido, grado, Asignatura.NombreAsignatura,notafinal from notas inner join Alumno on notas.Codigoaalumno=Alumno.CodigoAlumno inner join Asignatura on notas.codigoasignatura = Asignatura.CodAsignatura inner join grado on notas.Codgrado =grado.Codgrado where notas.Codigoaalumno=@codalumno
end

create
exec notasalumno "1"