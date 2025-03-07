DROP PROCEDURE proMovCierreRecursosInsertar
GO
CREATE PROCEDURE proMovCierreRecursosInsertar
(
@pproMovCierreOrden bigint,
@pRenglon int,
@pRecurso_Id varchar(25),
@pSubRecurso_Id varchar(25) = NULL,
@pCantidad qCantidadD8,
@pCosto qMonedaD4
)
AS
SET NOCOUNT ON 
BEGIN 
	INSERT INTO proMovCierreRecursos
	(
		proMovCierreOrden,
		Renglon,
		Recurso_Id,
		SubRecurso_Id,
		Cantidad,
		Costo
	)
	VALUES 
	(
		@pproMovCierreOrden,
		@pRenglon,
		dbo.FuncFKproRecursos(@pRecurso_Id),
		dbo.FuncFKproSubRecursos(@pSubRecurso_Id),
		@pCantidad,
		@pCosto
	)
END 

GO


DROP PROCEDURE proMovCierreRecursosDatos
GO
CREATE PROCEDURE proMovCierreRecursosDatos
(
@pproMovCierreOrden bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT proMovCierreRecursos.proMovCierreOrden, proMovCierreRecursos.Renglon,
	proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecursos, 
	proSubRecursos.SubRecurso_Id, proSubRecursos.Descripcion as DescripcionSubRecurso,
	proMovCierreRecursos.Cantidad,
	proMovCierreRecursos.Costo
FROM proMovCierreRecursos 
INNER JOIN proMovCierreOrden  ON (proMovCierreOrden.proMovCierreOrden = proMovCierreRecursos.proMovCierreOrden)
INNER JOIN proRecursos  ON (proRecursos.proRecursos = proMovCierreRecursos.Recurso_Id)
LEFT JOIN proSubRecursos ON proSubRecursos.proSubRecursos = proMovCierreRecursos.SubRecurso_Id
WHERE (proMovCierreRecursos.proMovCierreOrden = @pproMovCierreOrden)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE proMovCierreRecursosEliminar
GO
CREATE PROCEDURE proMovCierreRecursosEliminar
(
@pproMovCierreOrden bigint,
@pRenglon int = null
)
AS
SET NOCOUNT ON 

DELETE FROM proMovCierreRecursos 
WHERE (proMovCierreOrden = @pproMovCierreOrden)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

GO
