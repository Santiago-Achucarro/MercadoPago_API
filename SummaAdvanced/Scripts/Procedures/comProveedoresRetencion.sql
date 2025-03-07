DROP PROCEDURE comProveedoresRetencionGuardar
GO
CREATE PROCEDURE comProveedoresRetencionGuardar
(
@pProveed_Id bigint,
@pCartera_Id varChar(5),
@pExencion qPorcentaje,
@pFechaHasta qFecha = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comProveedoresRetencion WHERE (Proveed_Id = @pProveed_Id) AND Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)))
BEGIN 
	UPDATE comProveedoresRetencion
	SET Exencion = @pExencion,
		FechaHasta = @pFechaHasta
	WHERE (Proveed_Id = @pProveed_Id) AND Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comProveedoresRetencion
	(
		Proveed_Id,
		Cartera_Id,
		Exencion,
		FechaHasta
	)
	VALUES
	(
		@pProveed_Id,
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pExencion,
		@pFechaHasta
	)
END 

GO

DROP PROCEDURE comProveedoresRetencionDatos
GO
CREATE PROCEDURE comProveedoresRetencionDatos
(
@pProveed_Id bigint,
@pCartera_Id varChar(5) = Null
)
AS
SET NOCOUNT ON 

SELECT comProveedoresRetencion.Proveed_Id, comProveedores.RazonSocial, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdRetProv,
	comProveedoresRetencion.Exencion, comProveedoresRetencion.FechaHasta
FROM comProveedoresRetencion 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comProveedoresRetencion.Proveed_Id)
INNER JOIN tesIdRetProv  ON (tesIdRetProv.Cartera_Id = comProveedoresRetencion.Cartera_Id)
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesIdRetProv.Cartera_Id
WHERE comProveedoresRetencion.Proveed_Id = @pProveed_Id
AND comProveedoresRetencion.Cartera_Id = IsNull(dbo.FuncFKtesIdentifica(@pCartera_Id), comProveedoresRetencion.Cartera_Id)

RETURN @@Error 

GO

DROP PROCEDURE comProveedoresRetencionEliminar
GO
CREATE PROCEDURE comProveedoresRetencionEliminar
(
@pProveed_Id bigint,
@pCartera_Id varChar(5) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comProveedoresRetencion 
WHERE Proveed_Id = @pProveed_Id
AND Cartera_Id = IsNull(dbo.FuncFKtesIdentifica(@pCartera_Id), Cartera_Id)

RETURN @@Error 

GO
