-- select * from sisNombreTablas 

Create Table sisNombreTablas (
	StoreProcedure VarChar(200) not null, 
	Tabla Int Not null, 
	Nombre VarChar(100) Not Null, 
	Primary Key(StoreProcedure, Tabla))
GO	

CREATE PROCEDURE Sp_ActuTabla(@StoreProcedure VarChar(200), @Tabla int, 
	@Nombre VarChar(100))
as

SET NOCOUNT ON  
IF (EXISTS (SELECT 1 FROM sisNombreTablas WHERE 
	StoreProcedure = @StoreProcedure and 
	Tabla = @Tabla))	
	
Begin

	Update sisNombreTablas Set 
		Nombre = @Nombre 
		Where
		StoreProcedure = @StoreProcedure and 
		Tabla = @Tabla
end
else
begin
	insert into sisNombreTablas (Nombre ,StoreProcedure,Tabla)
	Values(@Nombre ,@StoreProcedure,@Tabla)

end
GO
	