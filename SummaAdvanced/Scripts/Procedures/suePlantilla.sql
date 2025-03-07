DROP PROCEDURE suePlantillaGuardar
GO
CREATE PROCEDURE suePlantillaGuardar
(
@pCentro1_Id varchar(8),
@pPuesto_Id varchar(5),
@pCantidad qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM suePlantilla WHERE (Centro1_Id = 	dbo.FuncFKconCentro1( @pCentro1_Id)) AND (Puesto_Id = dbo.FuncFKsuePuestos( @pPuesto_Id))))
BEGIN 
	UPDATE suePlantilla
	SET		Cantidad = @pCantidad
	WHERE (Centro1_Id = dbo.FuncFKconCentro1( @pCentro1_Id)) AND (Puesto_Id = dbo.FuncFKsuePuestos( @pPuesto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO suePlantilla
	(
		Centro1_Id,
		Puesto_Id,
		Cantidad
	)
	VALUES 
	(
		dbo.FuncFKconCentro1( @pCentro1_Id),
	dbo.FuncFKsuePuestos( @pPuesto_Id),
		@pCantidad
	)
END 


GO

DROP PROCEDURE suePlantillaDatos
GO
CREATE PROCEDURE suePlantillaDatos
(
@pCentro1_Id varchar(8),
@pPuesto_Id varchar(5)=null
)
AS
SET NOCOUNT ON 
select conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1
from conCentro1 where conCentro1.Centro1_Id=@pCentro1_Id

SELECT suePuestos.Puesto_Id, suePuestos.Descripcion as DescripcionPuestos, suePlantilla.Cantidad
FROM suePlantilla 
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = suePlantilla.Centro1_Id)
INNER JOIN suePuestos  ON (suePuestos.suePuestos = suePlantilla.Puesto_Id)
WHERE (conCentro1.Centro1_Id = @pCentro1_Id)
AND (suePuestos.Puesto_Id = isnull(@pPuesto_Id,suePuestos.Puesto_Id))
 
 RETURN @@Error 


GO

DROP PROCEDURE suePlantillaEliminar
GO
CREATE PROCEDURE suePlantillaEliminar
(
@pCentro1_Id varchar(8),
@pPuesto_Id int=null
)
AS
SET NOCOUNT ON 

DELETE FROM suePlantilla 
WHERE (Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id))
AND (Puesto_Id = isnull(@pPuesto_Id,Puesto_id))
 
 RETURN @@Error 

GO

GO
