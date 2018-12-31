ALTER TABLE Alumno add Fecha_nac datetime
select * from Responsable
update Alumno set Fecha_nac ='2018-1-16'
alter table Alumno add Direccion varchar(50)
update Alumno set Direccion='Del rastro dos cuadras al sur 2 cuadras abajo'
alter table Alumno add Cod_Responsable int

create table Responsable
(
Cod_Responsable int identity(1,1) primary key,
Nombre_R varchar(25),
Telefono varchar(10),
Ocupacion varchar(20)
)
alter table Responsable alter column Nombre_R  varchar(50)
insert into Responsable VALUES('Leonidas Carcamo Manzanarez','5845852','Negocio Familiar')
update Responsable set Ocupacion ='negocio ropa' where Cod_Responsable =1
alter table Alumno add foreign key (Cod_Responsable) references Responsable (Cod_Responsable)
Update Alumno set Cod_Responsable= 1 Where CodigoAlumno = 1
select * from Alumno
select * from Responsable