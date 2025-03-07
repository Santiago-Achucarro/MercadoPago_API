
DROP PROCEDURE afiResponsableActivoGuardar
GO
CREATE PROCEDURE afiResponsableActivoGuardar
(
@pResponsable_Id varchar(15),
@pActivoFijo_Id varchar(15),
@pFechaAsignacion datetime,
@pEmpresa_Id int,
@pCantidad qCantidad
)
AS
SET NOCOUNT ON 

	INSERT INTO afiResponsableActivo
	(
		Responsable_Id,
		ActivoFijo_Id,
		FechaAsignacion,
		Cantidad
	)
	VALUES 
	(
		dbo.funcfkafiResponsables( @pResponsable_Id),
		dbo.FuncFKafiActivoFijo(@pActivoFijo_Id, @pEmpresa_Id),
		@pFechaAsignacion,
		@pCantidad
	)


GO

DROP PROCEDURE afiResponsableActivoDatos
GO
CREATE PROCEDURE afiResponsableActivoDatos
(
@pResponsable_Id varchar(15),
@pActivoFijo_Id varchar(15),
@pFechaAsignacion datetime
)
AS
SET NOCOUNT ON 

SELECT afiResponsables.Responsable_Id, afiResponsables.Descripcion as DescripcionResponsables, afiActivoFijo.Empresa_Id, afiActivoFijo.ActivoFijo_Id,
	afiActivoFijo.Descripcion as DescripcionActivoFijo, afiResponsableActivo.FechaAsignacion, afiResponsableActivo.Cantidad
FROM afiResponsableActivo 
INNER JOIN afiResponsables  ON (afiResponsables.afiResponsables = afiResponsableActivo.Responsable_Id)
INNER JOIN afiActivoFijo  ON (afiActivoFijo.afiActivoFijo = afiResponsableActivo.ActivoFijo_Id)
WHERE (afiResponsables.Responsable_Id = @pResponsable_Id)
AND (afiActivoFijo.ActivoFijo_Id = @pActivoFijo_Id)
AND (FechaAsignacion = @pFechaAsignacion)
 
RETURN @@Error 

GO

DROP PROCEDURE afiResponsableActivoEliminar
GO
CREATE PROCEDURE afiResponsableActivoEliminar
(
@pResponsable_Id varchar(15)=NULL,
@pEmpresa_Id int,
@pActivoFijo_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM afiResponsableActivo 
WHERE 
(Responsable_Id IS NULL OR  Responsable_Id = isnull(dbo.FuncFKafiResponsables(@pResponsable_Id), Responsable_Id))
AND (ActivoFijo_Id = dbo.FuncFKafiActivoFijo(@pActivoFijo_Id,@pEmpresa_Id))
 
 RETURN @@Error 

GO

