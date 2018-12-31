create proc BuscarResponsable 
@Nombre varchar
as
Begin
select * from Responsable where Nombre_R like '%'+@Nombre+'%' or Cod_Responsable like @nombre or Ocupacion like @Nombre
end

exec InsertarResponsable 'Jose Leonidas Carcamo Urbina','84528987','Programador';
select * from Responsable
exec BuscarResponsable 'Leonidas';