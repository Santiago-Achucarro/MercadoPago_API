DROP PROCEDURE afiResponsablesGuardar
GO
CREATE PROCEDURE afiResponsablesGuardar
(
@pResponsable_Id varchar(15) = NULL,
@pResponsable_Id_Nuevo varchar(15),
@pDescripcion varchar(200) = NULL,
@pEmpresa_Id int = NULL,
@pPosteado Sino,
@pInactivo Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM afiResponsables WHERE (Responsable_Id = @pResponsable_Id)))
BEGIN 
	UPDATE afiResponsables
	SET		Responsable_Id = @pResponsable_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Posteado = @pPosteado,
		Inactivo = @pInactivo
	WHERE (Responsable_Id = @pResponsable_Id)
END 
ELSE 
BEGIN 
	INSERT INTO afiResponsables
	(
		
		Responsable_Id,
		Descripcion,
		Empresa_Id,
		Posteado,
		Inactivo
	)
	VALUES 
	(
		
		@pResponsable_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pPosteado,
		@pInactivo
	)
END 

GO

DROP PROCEDURE afiResponsablesDatos
GO
CREATE PROCEDURE afiResponsablesDatos
(
@pResponsable_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT afiResponsables.afiResponsables, afiResponsables.Responsable_Id, afiResponsables.Descripcion, afiResponsables.afiResponsables afiResponsables_Nueva,
	afiResponsables.Empresa_Id, Cast( Case When afiResponsables.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, afiResponsables.Posteado, afiResponsables.Inactivo
FROM afiResponsables 
WHERE (Responsable_Id = @pResponsable_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE afiResponsablesEliminar
GO
CREATE PROCEDURE afiResponsablesEliminar
(
@pResponsable_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM afiResponsables 
WHERE (afiResponsables = @pResponsable_Id)
 
 RETURN @@Error 

GO

drop function dbo.FuncFKafiResponsables
go
create function dbo.FuncFKafiResponsables
(
	@pResponsable_Id varchar(15)
)
returns int
as
begin
declare @lIdentity int=(select afiResponsables from afiResponsables where Responsable_Id=@pResponsable_Id)
return @lIdentity
end
GO
