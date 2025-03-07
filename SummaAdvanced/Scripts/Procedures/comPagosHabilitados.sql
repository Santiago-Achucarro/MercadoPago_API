DROP PROCEDURE comPagosHabilitadosGuardar
GO
CREATE PROCEDURE comPagosHabilitadosGuardar
(
@pcomMovProv bigint,
@pCuotaNro Int,
@pSecuencia int,
@pUsuario_Id int,
@pFechaHabilitacion qFechaHora,
@pImporteHabilitado qMonedaD2,
@ptesMovimientos bigint = NULL,
@pImporte1 qMonedaD2,
@pImporte2 qMonedaD2,
@pImporte3 qMonedaD2
)
AS
SET NOCOUNT ON

Declare @lSecuencia int
Set @lSecuencia = @pSecuencia

If @pSecuencia = 0
	Select @lSecuencia = IsNull(Max(Secuencia), 0) + 1 From comPagosHabilitados Where comMovProv = @pcomMovProv and CuotaNro = @pCuotaNro


IF (EXISTS (SELECT 1 FROM comPagosHabilitados WHERE (comMovProv = @pcomMovProv) AND (Secuencia = @lSecuencia) and CuotaNro = @pCuotaNro))
BEGIN 
	UPDATE comPagosHabilitados
	SET Usuario_Id = @pUsuario_Id,
		FechaHabilitacion = @pFechaHabilitacion,
		ImporteHabilitado = @pImporteHabilitado,
		tesMovimientos = @ptesMovimientos,
		Importe1 = @pImporte1,
		Importe2 = @pImporte2,
		Importe3 = @pImporte3
	WHERE (comMovProv = @pcomMovProv) AND (Secuencia = @pSecuencia) and CuotaNro = @pCuotaNro
END 
ELSE 
BEGIN 
	INSERT INTO comPagosHabilitados
	(
		comMovProv,
		CuotaNro,
		Secuencia,
		Usuario_Id,
		FechaHabilitacion,
		ImporteHabilitado,
		tesMovimientos,
		Importe1,
		Importe2,
		Importe3
	)
	VALUES 
	(
		@pcomMovProv,
		@pCuotaNro,
		@lSecuencia,
		@pUsuario_Id,
		@pFechaHabilitacion,
		@pImporteHabilitado,
		@ptesMovimientos,
		@pImporte1,
		@pImporte2,
		@pImporte3
	)
END 

GO
--EXEC comPagosHabilitadosDatos 'A001','PES',0,1
DROP PROCEDURE comPagosHabilitadosDatos
GO
CREATE PROCEDURE comPagosHabilitadosDatos
(
@pProveed_Id varChar(15),
@pMoneda_Id varChar(5),
@pSoloHabilitados bit,
@pEmpresa_Id int, 
@pFechaPago DateTime=NULL
)
AS
SET NOCOUNT ON 
-- Comprobantes pendientes --
SELECT comMovProv.comMovProv, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento4C,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, conAsientos.Cambio,
	0 Secuencia, 0 Usuario_Id, ' ' Apellido_y_Nombres, conCuentas.Cuenta_Id, comMovProv.TipoCtaProv, comMovProv.Fecha_CCP,
	dbo.FechaActual() FechaHabilitacion, genMovCuotas.Saldo * 0 ImporteHabilitado, Cast(0 as bigint) tesMovimientos,
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @pEmpresa_Id) as CambioPago,
	genMovCuotas.Saldo * 0 Importe1, genMovCuotas.Saldo * 0 Importe2, genMovCuotas.Saldo * 0 Importe3, genMovCuotas.FechaVencimiento, 
	genSucursalesEmpr.Sucursal
FROM comMovProv
INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'PRO'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=conAsientos.Sucursal
WHERE comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)
And conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)
And genMovCuotas.Saldo > 0 And comMovTipos.Signo = -1 And conAsientos.Anulado = 0
And Not exists (Select 1 From comPagosHabilitados 
	Where 
		tesMovimientos Is Null and 
		comPagosHabilitados.comMovProv = genMovCuotas.Asiento_Id and 
		comPagosHabilitados.CuotaNro = genMovCuotas.CuotaNro)
And @pSoloHabilitados = 0 And tesRengMovicomMovProv.tesMovimientos Is Null And
conAsientos.Anulado = 0

Union All
-- Comprobantes ya habilitados --
SELECT comMovProv.comMovProv, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento4C,dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, conAsientos.Cambio,
	comPagosHabilitados.Secuencia, genUsuarios.genUsuarios Usuario_Id, genUsuarios.Apellido_y_Nombres, conCuentas.Cuenta_Id, comMovProv.TipoCtaProv,
	comMovProv.Fecha_CCP, comPagosHabilitados.FechaHabilitacion, comPagosHabilitados.ImporteHabilitado, Cast(0 as bigint) tesMovimientos,
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @pEmpresa_Id) as CambioPago,
	comPagosHabilitados.Importe1, comPagosHabilitados.Importe2, comPagosHabilitados.Importe3, genMovCuotas.FechaVencimiento,
	genSucursalesEmpr.Sucursal
FROM comMovProv
INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'PRO'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
Inner JOIN comPagosHabilitados ON genMovCuotas.Asiento_Id = comPagosHabilitados.comMovProv and 
	genMovCuotas.CuotaNro = comPagosHabilitados.CuotaNro
Inner JOIN genUsuarios  ON (genUsuarios.genUsuarios = comPagosHabilitados.Usuario_Id)
inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=conAsientos.Sucursal
WHERE comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And comPagosHabilitados.tesMovimientos Is Null
And conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) and 
comPagosHabilitados.FechaHabilitacion <= ISNULL(@pFechaPago,comPagosHabilitados.FechaHabilitacion) And
conAsientos.Anulado = 0
order by 24,2,3 
RETURN @@Error 

GO

DROP PROCEDURE comPagosHabilitadosEliminar
GO
CREATE PROCEDURE comPagosHabilitadosEliminar
(
@pProveed_Id varChar(15),
@pEmpresa_Id int,
@pSecuencia int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comPagosHabilitados 
From comMovProv, conAsientos Where 
comMovProv.comMovProv = conAsientos.conAsientos
And comMovProv.comMovProv = comPagosHabilitados.comMovProv
And comPagosHabilitados.tesMovimientos Is Null
AND (Secuencia = ISNULL(@pSecuencia, Secuencia))
And comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)
And conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0
 
RETURN @@Error 

GO


DROP PROCEDURE comPagosHabilitadosVolveraHabi
GO
CREATE PROCEDURE comPagosHabilitadosVolveraHabi
(
	@pTesMovimientos bigint
)
AS
SET NOCOUNT ON 

Update comPagosHabilitados set tesMovimientos = null where
	tesMovimientos = @pTesMovimientos

Update comPagosAnticipo set tesMovimientos = null where
	tesMovimientos = @pTesMovimientos
 
RETURN @@Error 

GO


DROP PROCEDURE comPagosHabilitadosEliminarFact
GO
CREATE PROCEDURE comPagosHabilitadosEliminarFact
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comPagosHabilitados 
From comMovProv Where comMovProv.comMovProv = @pcomMovProv
RETURN @@Error 

GO