DROP PROCEDURE sueCateNombreGuardar
GO
CREATE PROCEDURE sueCateNombreGuardar
(
@pCateNombre_Id int,
@pDescripcion varchar(60),
@pPorEmpresa Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueCateNombre WHERE (CateNombre_Id = @pCateNombre_Id)))
BEGIN 
	UPDATE sueCateNombre
	SET		Descripcion = @pDescripcion,
		PorEmpresa = @pPorEmpresa,
		Usuario_Id = @pUsuario_Id
	WHERE (CateNombre_Id = @pCateNombre_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueCateNombre
	(
		CateNombre_Id,
		Descripcion,
		PorEmpresa,
		Usuario_Id
	)
	VALUES 
	(
		@pCateNombre_Id,
		@pDescripcion,
		@pPorEmpresa,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE sueCateNombreDatos
GO
CREATE PROCEDURE sueCateNombreDatos
(
@pCateNombre_Id int
)
AS
SET NOCOUNT ON 

SELECT sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion, sueCateNombre.PorEmpresa, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM sueCateNombre 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueCateNombre.Usuario_Id)
WHERE (CateNombre_Id = @pCateNombre_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueCateNombreEliminar
GO
CREATE PROCEDURE sueCateNombreEliminar
(
@pCateNombre_Id int 
)
AS
SET NOCOUNT ON 

DELETE FROM sueCateNombre 
WHERE (CateNombre_Id = @pCateNombre_Id)
 
 RETURN @@Error 

GO
drop procedure sueCateNombreEditable
go
create procedure sueCateNombreEditable
(
@pCateNombre int
)
as
declare @lEditable bit= case when exists (select 1 from sueLiqImpCatego where CateNombre_Id=@pCateNombre) then 1 else 0 end
set @lEditable= case when @lEditable=1 then 1 else case when exists (select 1 from sueLiqEmpCatego where CateNombre_Id=@pCateNombre) then 1 else 0 end end
select @lEditable
GO

GO
