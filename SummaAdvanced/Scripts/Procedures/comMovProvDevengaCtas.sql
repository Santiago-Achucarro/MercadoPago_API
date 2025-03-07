DROP PROCEDURE comMovProvDevengaCtasGuardar
GO
CREATE PROCEDURE comMovProvDevengaCtasGuardar
(
@pcomMovProv bigint,
@pCuenta_Id varchar(25),
@pCentro1_Id varchar(8),
@pCentro2_Id varchar(8),
@pPorcentaje qPorcentaje
)
AS
SET NOCOUNT ON 

INSERT INTO comMovProvDevengaCtas
(
	comMovProv,
	Cuenta_Id,
	Centro1_Id,
	Centro2_Id,
	Porcentaje
)
VALUES 
(
	@pcomMovProv,
	dbo.FuncFKconCuentas(@pCuenta_Id),
	dbo.FuncFKconCentro1(@pCentro1_Id),
	dbo.FuncFKconCentro2(@pCentro2_Id),
	@pPorcentaje
)

GO

DROP PROCEDURE comMovProvDevengaCtasDatos
GO
CREATE PROCEDURE comMovProvDevengaCtasDatos
(
@pcomMovProv bigint,
@pCuenta_Id varchar(25) = Null,
@pCentro1_Id varchar(8) = Null,
@pCentro2_Id varchar(8) = Null
)
AS
SET NOCOUNT ON 

SELECT comMovProvDevengaCtas.comMovProv, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	comMovProvDevengaCtas.Porcentaje
FROM comMovProvDevengaCtas 
INNER JOIN comMovProvDevenga  ON (comMovProvDevenga.comMovProv = comMovProvDevengaCtas.comMovProv)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = comMovProvDevengaCtas.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = comMovProvDevengaCtas.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = comMovProvDevengaCtas.Centro2_Id)
WHERE (comMovProvDevengaCtas.comMovProv = @pcomMovProv)
AND conCuentas.Cuenta_Id = isNull(@pCuenta_Id, conCuentas.Cuenta_Id)
AND conCentro1.Centro1_Id = isNull(@pCentro1_Id, conCentro1.Centro1_Id)
AND conCentro2.Centro2_Id = isNull(@pCentro2_Id, conCentro2.Centro2_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE comMovProvDevengaCtasEliminar
GO
CREATE PROCEDURE comMovProvDevengaCtasEliminar
(
@pcomMovProv bigint,
@pCuenta_Id varchar(25) = Null,
@pCentro1_Id varchar(8) = Null,
@pCentro2_Id varchar(8) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvDevengaCtas 
WHERE (comMovProv = @pcomMovProv)
AND Cuenta_Id = isNull(dbo.FuncFKconCuentas(@pCuenta_Id), Cuenta_Id)
AND Centro1_Id = isNull(dbo.FuncFKconCentro1(@pCentro1_Id), Centro1_Id)
AND Centro2_Id = isNull(dbo.FuncFKconCentro2(@pCentro2_Id), Centro2_Id)
 
RETURN @@Error 

GO
