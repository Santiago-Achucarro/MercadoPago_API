DROP PROCEDURE proOrdenRecursosGuardar
GO
CREATE PROCEDURE proOrdenRecursosGuardar
(
@pproOrden int,
@pRenglon int,
@pRecurso_Id varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenRecursos WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proOrdenRecursos
	SET		Recurso_Id = dbo.FuncFKproRecursos(@pRecurso_Id),
		Cantidad = @pCantidad
	WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenRecursos
	(
		proOrden,
		Renglon,
		Recurso_Id,
		Cantidad
	)
	VALUES 
	(
		@pproOrden,
		@pRenglon,
		dbo.FuncFKproRecursos(@pRecurso_Id),
		@pCantidad
	)
END 

GO

DROP PROCEDURE proOrdenRecursosDatos
GO
CREATE PROCEDURE proOrdenRecursosDatos
(
@pproOrden int,
@pRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT proOrdenRecursos.proOrden, proOrdenRecursos.Renglon, proRecursos.Recurso_Id,
	proRecursos.Descripcion as DescripcionRecursos, proOrdenRecursos.Cantidad
FROM proOrdenRecursos 
INNER JOIN proOrden  ON (proOrden.proOrden = proOrdenRecursos.proOrden)
inner join proRecursos on proRecursos.proRecursos=proOrdenRecursos.Recurso_Id
WHERE (proOrden.proOrden = @pproOrden)
AND (Renglon = isnull(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE proOrdenRecursosEliminar
GO
CREATE PROCEDURE proOrdenRecursosEliminar
(
@pproOrden int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenRecursos 
WHERE (proOrden = @pproOrden)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
