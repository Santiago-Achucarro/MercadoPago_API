drop procedure Borrar_Form
go
create procedure Borrar_Form (
	@Formulario_id VarChar(30)
)
as

exec Borra_cuerpoForm @Formulario_id
delete from disControles where Formulario_Id = dbo.FuncFKdisFormularios(@Formulario_id)
delete from disFormularios where Formulario_Id = @Formulario_id

go

