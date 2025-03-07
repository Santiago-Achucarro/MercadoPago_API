DROP PROCEDURE proRecetasTrabajo3Guardar
GO
CREATE PROCEDURE proRecetasTrabajo3Guardar
(
@pReceta_Id varchar(25),
@pTrabajo3_Id varchar(25)
)
AS
SET NOCOUNT ON 

	INSERT INTO proRecetasTrabajo3
	(
		Receta_Id,
		Trabajo3_Id
	)
	VALUES 
	(
		dbo.FuncFKproRecetas(@pReceta_Id),
		dbo.FuncFKproTrabajo3(@pTrabajo3_Id)
	)


GO

DROP PROCEDURE proRecetasTrabajo3Datos
GO
CREATE PROCEDURE proRecetasTrabajo3Datos
(
@pReceta_Id varchar(25),
@pTrabajo3_Id varchar(25)=null
)
AS
SET NOCOUNT ON 

SELECT proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionRecetas, 
proTrabajo3.Trabajo3_Id,proTrabajo3.Descripcion as DescripcionTrabajo3
FROM proRecetasTrabajo3 
INNER JOIN proRecetas  ON (proRecetas.proRecetas = proRecetasTrabajo3.Receta_Id)
inner join proTrabajo3 on proTrabajo3=proRecetasTrabajo3.Trabajo3_Id
WHERE (proRecetas.Receta_Id = @pReceta_Id)
AND (proTrabajo3.Trabajo3_Id = isnull(@pTrabajo3_Id,proTrabajo3.Trabajo3_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE proRecetasTrabajo3Eliminar
GO
CREATE PROCEDURE proRecetasTrabajo3Eliminar
(
@pReceta_Id varchar(25),
@pTrabajo3_Id varchar(25)=null
)
AS
SET NOCOUNT ON 

DELETE FROM proRecetasTrabajo3 
WHERE (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id))
AND (Trabajo3_Id = isnull(dbo.FuncFKproTrabajo3(@pTrabajo3_Id),Trabajo3_Id))
 
 RETURN @@Error 

GO

GO
