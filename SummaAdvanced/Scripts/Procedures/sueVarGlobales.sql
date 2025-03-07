DROP PROCEDURE sueVarGlobalesGuardar
GO
CREATE PROCEDURE sueVarGlobalesGuardar
(
@pVarGlobal_Id int,
@pDescripcion varchar(60),
@pPorEmpresa Sino,
@pUsuario_Id int = NULL,
@pCodigo varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueVarGlobales WHERE (VarGlobal_Id = @pVarGlobal_Id)))
BEGIN 
	UPDATE sueVarGlobales
	SET		Descripcion = @pDescripcion,
		PorEmpresa = @pPorEmpresa,
		Usuario_Id = @pUsuario_Id,
		Codigo=@pCodigo
	WHERE (VarGlobal_Id = @pVarGlobal_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueVarGlobales
	(
		VarGlobal_Id,
		Descripcion,
		PorEmpresa,
		Usuario_Id,
		Codigo
	)
	VALUES 
	(
		@pVarGlobal_Id,
		@pDescripcion,
		@pPorEmpresa,
		@pUsuario_Id,
		@pCodigo
	)
END 

GO

DROP PROCEDURE sueVarGlobalesDatos
GO
CREATE PROCEDURE sueVarGlobalesDatos
(
@pVarGlobal_Id int
)
AS
SET NOCOUNT ON 

SELECT sueVarGlobales.VarGlobal_Id, sueVarGlobales.Descripcion, sueVarGlobales.PorEmpresa, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario,sueVarGlobales.Codigo, GETDATE() as FechaCodigo
FROM sueVarGlobales 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueVarGlobales.Usuario_Id)
WHERE (VarGlobal_Id = @pVarGlobal_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueVarGlobalesEliminar
GO
CREATE PROCEDURE sueVarGlobalesEliminar
(
@pVarGlobal_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueVarGlobales 
WHERE (VarGlobal_Id = ISNULL(@pVarGlobal_Id, VarGlobal_Id))
 
 RETURN @@Error 

GO
drop procedure sueVarGlobalesEditable
go
create procedure sueVarGlobalesEditable
(
@pVarGlobal int
)
as
declare @lEditable bit= case when exists (select 1 from sueLiqVarEmpGlobales where VarGlobal_Id=@pVarGlobal) then 1 else 0 end
set @lEditable= case when @lEditable=1 then 1 else case when exists (select 1 from sueLiqVarGlobales where VarGlobal_Id=@pVarGlobal) then 1 else 0 end end
select @lEditable
GO
