use Notas_Prueva
create proc buscar_alumno
@nombre varchar(10)
as 
begin
select* from Alumno  inner join Responsable on Alumno.Cod_Responsable =Responsable.Cod_Responsable
 where PrimerNombre  like @nombre or SegundoNombre like @nombre or CodigoAlumno like @nombre or
 PrimerApellido like @nombre or SegundoApellido like @nombre
end

drop proc buscar_alumno_nombre
exec buscar_alumno'Carcamo';

