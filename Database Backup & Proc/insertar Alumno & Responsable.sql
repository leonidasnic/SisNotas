
create proc InsertarResponsable
@NombreResponsable varchar(50),
@Telefono varchar(10),
@Ocupacion Varchar(20)
as
begin
insert into Responsable values(@NombreResponsable,@Telefono,@Ocupacion)
end

create proc InsertarAlumno
@PrimerNombre varchar(10),
@SegundoNombre varchar(10),
@PrimerApellido varchar(10),
@SegundoApellido varchar(10),
@especialidad Varchar(20),
@FechaNac datetime,
@Direccion varchar(50),
@CodResponsable int
as
begin
insert into Alumno Values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@especialidad,@FechaNac,@Direccion,@CodResponsable)
end