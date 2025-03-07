-- exec comProveedoresCtasPasivoDatos 1, 1, 'PES'
DROP PROCEDURE comProveedoresCtasPasivoInsertar
GO
CREATE PROCEDURE comProveedoresCtasPasivoInsertar
(
@pgenEntidades bigint,
@pTipoCtaProv int,
@pMoneda_Id VarChar(5),
@pCuenta_Id varchar(25),
@pctaPagoXAdelantado varchar(25),
@pCtaAnticipo varchar(25)
)
AS
SET NOCOUNT ON 
	INSERT INTO comProveedoresCtasPasivo
	(
		genEntidades,
		TipoCtaProv,
		Moneda_Id,
		Cuenta_Id,
		ctaPagoXAdelantado,
		CtaAnticipo
	)
	VALUES 
	(
		@pgenEntidades,
		@pTipoCtaProv,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCuentas(@pctaPagoXAdelantado),
		dbo.FuncFKconCuentas(@pCtaAnticipo)
	)

GO

DROP PROCEDURE comProveedoresCtasPasivoDatos
GO
CREATE PROCEDURE comProveedoresCtasPasivoDatos
(
@pgenEntidades bigint,
@pTipoCtaProv int=null,
@pMoneda_Id VarChar(5)=null
)
AS
SET NOCOUNT ON 

SELECT comProveedoresCtasPasivo.genEntidades, 
	comProveedoresCtasPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	ctaPagoXAdelantado.Cuenta_Id AS ctaPagoXAdelantado, ctaPagoXAdelantado.Descripcion as DescripcionctaPagoXAdelantado,
	conCuentasAnt.Cuenta_Id CtaAnticipo, conCuentasAnt.Descripcion DescripcionCtaAnticipo
FROM comProveedoresCtasPasivo 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comProveedoresCtasPasivo.genEntidades)
INNER JOIN comProveedoresTipoPasivo  ON (comProveedoresTipoPasivo.TipoCtaProv = comProveedoresCtasPasivo.TipoCtaProv)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = comProveedoresCtasPasivo.Moneda_Id)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = comProveedoresCtasPasivo.Cuenta_Id)
Left Join conCuentas conCuentasAnt On conCuentasAnt.conCuentas = comProveedoresCtasPasivo.CtaAnticipo
LEFT JOIN conCuentas ctaPagoXAdelantado ON (ctaPagoXAdelantado.conCuentas = comProveedoresCtasPasivo.ctaPagoXAdelantado)
WHERE (comProveedoresCtasPasivo.genEntidades = @pgenEntidades)
AND (comProveedoresCtasPasivo.TipoCtaProv = ISNULL(@pTipoCtaProv,comProveedoresCtasPasivo.TipoCtaProv))
AND (comProveedoresCtasPasivo.Moneda_Id =  dbo.FuncFKgenMonedas(@pMoneda_Id) or @pMoneda_Id IS NULL)
 
 RETURN @@Error 

GO

DROP PROCEDURE comProveedoresCtasPasivoEliminar
GO
CREATE PROCEDURE comProveedoresCtasPasivoEliminar
(
@pgenEntidades bigint,
@pTipoCtaProv int=NULL,
@pMoneda_Id varchar(3)=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comProveedoresCtasPasivo 
WHERE (genEntidades = @pgenEntidades)
AND (TipoCtaProv = ISNULL(@pTipoCtaProv,TipoCtaProv))
AND (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) OR @pMoneda_Id IS NULL)
 
RETURN @@Error 

GO

