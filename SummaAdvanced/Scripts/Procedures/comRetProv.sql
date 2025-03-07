DROP PROCEDURE comRetProvInsertar
GO
CREATE PROCEDURE comRetProvInsertar
(
@pProveed_Id VarChar(15),
@pCartera_Id VarChar(5),
@pExencion qPorcentaje,
@pHasta qFecha
)
AS
SET NOCOUNT ON 
BEGIN 
	INSERT INTO comRetProv
	(
		Proveed_Id,
		Cartera_Id,
		Exencion,
		Hasta
	)
	VALUES 
	(
		dbo.FuncFKcomProveedores(@pProveed_Id),
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pExencion,
		@pHasta
	)
END 

GO

DROP PROCEDURE comRetProvDatos
GO
CREATE PROCEDURE comRetProvDatos
(
@pProveed_Id VarChar(15),
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	comRetProv.Exencion, comRetProv.Hasta
FROM comRetProv 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comRetProv.Proveed_Id)
INNER JOIN tesIdRetProv  ON (tesIdRetProv.Cartera_Id = comRetProv.Cartera_Id)
INNER JOIN tesIdentifica  ON tesIdentifica.tesIdentifica =comRetProv.Cartera_Id

WHERE (comProveedores.Proveed_Id = @pProveed_Id)
AND (tesIdentifica.Cartera_Id = @pCartera_Id)
ORDER BY 3
 
RETURN @@Error 

GO

DROP PROCEDURE comRetProvEliminar
GO
CREATE PROCEDURE comRetProvEliminar
(
@pProveed_Id VarChar(15),
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM comRetProv 
WHERE (Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id))
AND (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
 
 RETURN @@Error 

GO

GO
