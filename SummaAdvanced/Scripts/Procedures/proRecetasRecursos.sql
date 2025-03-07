DROP PROCEDURE proRecetasRecursosGuardar
GO
CREATE PROCEDURE proRecetasRecursosGuardar
(
@pRecetas_Id varchar(25),
@pRenglon int,
@pRecurso_Id varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 

	INSERT INTO proRecetasRecursos
	(
		proRecetas,
		Renglon,
		Recurso_Id,
		Cantidad
	)
	VALUES 
	(
		dbo.FuncFKproRecetas(@pRecetas_Id),
		@pRenglon,
		dbo.FuncFKproRecursos(@pRecurso_Id),
		@pCantidad
	)


GO

DROP PROCEDURE proRecetasRecursosDatos
GO
CREATE PROCEDURE proRecetasRecursosDatos
(
@pproRecetas int,
@pRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionRecetas, proRecetasRecursos.Renglon, proRecursos.Recurso_Id,
	proRecursos.Descripcion as DescripcionRecursos,proRecetasRecursos.Cantidad
FROM proRecetasRecursos 
INNER JOIN proRecetas  ON (proRecetas.proRecetas = proRecetasRecursos.proRecetas)
left join proRecursos on proRecursos.proRecursos=proRecetasRecursos.Recurso_Id
WHERE (proRecetas.proRecetas = @pproRecetas)
AND (Renglon = isnull(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE proRecetasRecursosEliminar
GO
CREATE PROCEDURE proRecetasRecursosEliminar
(
@pReceta_Id varchar(25),
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proRecetasRecursos 
WHERE (proRecetas = dbo.FuncFKproRecetas(@pReceta_Id))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
