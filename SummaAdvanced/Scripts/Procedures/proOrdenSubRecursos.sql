DROP PROCEDURE proOrdenSubRecursoGuardar
GO
CREATE PROCEDURE proOrdenSubRecursoGuardar
(
@pproOrden int,
@pRenglon int,
@pSubRecurso_Id varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenSubRecurso WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon) AND (SubRecurso_Id = @pSubRecurso_Id)))
BEGIN 
	UPDATE proOrdenSubRecurso
	SET		Cantidad = @pCantidad
	WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon) AND (SubRecurso_Id = @pSubRecurso_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenSubRecurso
	(
		proOrden,
		Renglon,
		SubRecurso_Id,
		Cantidad
	)
	VALUES 
	(
		@pproOrden,
		@pRenglon,
		dbo.FuncFKproSubRecursos(@pSubRecurso_Id),
		@pCantidad
	)
END 

GO

DROP PROCEDURE proOrdenSubRecursoDatos
GO
CREATE PROCEDURE proOrdenSubRecursoDatos
(
@pproOrden int,
@pRenglon int,
@pSubRecurso_Id int
)
AS
SET NOCOUNT ON 

SELECT proOrdenSubRecurso.proOrden, proOrdenSubRecurso.Renglon, proSubRecursos.Descripcion as DescripcionOrdenRecursos, proSubRecursos.SubRecurso_Id,
	proSubRecursos.Descripcion as DescripcionSubRecursos, proOrdenSubRecurso.Cantidad
FROM proOrdenSubRecurso 
INNER JOIN proOrdenRecursos  ON (proOrdenRecursos.proOrden = proOrdenSubRecurso.proOrden) AND (proOrdenRecursos.Renglon = proOrdenSubRecurso.Renglon)
INNER JOIN proSubRecursos  ON (proSubRecursos.proSubRecursos = proOrdenSubRecurso.SubRecurso_Id)
WHERE (proOrdenSubRecurso.proOrden = @pproOrden)
AND (proOrdenSubRecurso.Renglon = @pRenglon)
AND (proOrdenSubRecurso.SubRecurso_Id = @pSubRecurso_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE proOrdenSubRecursoEliminar
GO
CREATE PROCEDURE proOrdenSubRecursoEliminar
(
@pproOrden int,
@pRenglon int,
@pSubRecurso_Id varchar(25)
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenSubRecurso 
WHERE (proOrden = @pproOrden)
AND (Renglon = @pRenglon)
AND (SubRecurso_Id = dbo.FuncFKproSubRecursos(@pSubRecurso_Id))
 
 RETURN @@Error 

GO

GO
