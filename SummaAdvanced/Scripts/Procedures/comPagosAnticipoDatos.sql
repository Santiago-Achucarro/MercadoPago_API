DROP PROCEDURE comPagosAnticipoGuardar
GO
CREATE PROCEDURE comPagosAnticipoGuardar
(
@pProveed_Id varChar(15),
@pMoneda_Id varChar(5),
@pEmpresa_Id int,
@pImporte qMonedaD2,
@pTipoCtaProv int,
@pCuenta_Id varchar(25),
@pUsuario_Id int,
@ptesMovimientos bigint=NULL, 
@pcomEmbarques bigint=NULL ,
@pFechaPago DateTime
)
AS
	INSERT INTO comPagosAnticipo
	(
		Proveed_Id,
		Moneda_Id,
		Empresa_Id,
		Importe,
		TipoCtaProv,
		Cuenta_Id,
		Usuario_Id,
		tesMovimientos, 
		ComEmbarques, 
		FechaPago
	)
	VALUES 
	(
		dbo.FuncFKcomProveedores(@pProveed_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pEmpresa_Id,
		@pImporte,
		@pTipoCtaProv,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pUsuario_Id,
		@ptesMovimientos, 
		@pComEmbarques,
		@pFechaPago
	)

Select Cast(SCOPE_IDENTITY() as int)  as RetVal 

GO

DROP PROCEDURE comPagosAnticipoDatos
GO
CREATE PROCEDURE comPagosAnticipoDatos
(
@pProveed_Id varChar(15),
@pMoneda_Id varchar(5),
@pEmpresa_Id int, 
@pFechaPago DateTime=NULL
)
AS
SET NOCOUNT ON 

SELECT comProveedores.Proveed_Id, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
	comPagosAnticipo.Importe as ImporteHabilitado, comPagosAnticipo.TipoCtaProv,
	comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo, conCuentas.Cuenta_Id, 
	conCuentas.Descripcion as DescripcionCuentas, genUsuarios.Usuario_Id,
	comPagosAnticipo.FechaPago,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comPagosAnticipo.tesMovimientos,
	comPagosAnticipo.comEmbarques, genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N,  genAsiSegmentos.Segmento4N ,
		dbo.Segmento( genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N,  genAsiSegmentos.Segmento4N ) as SegmentoStr, 
			comPagosAnticipo.comPagosAnticipo 
		
FROM comPagosAnticipo 
INNER JOIN comProveedores ON comProveedores.genEntidades = comPagosAnticipo.Proveed_Id
INNER JOIN comProveedoresTipoPasivo ON comProveedoresTipoPasivo.TipoCtaProv = comPagosAnticipo.TipoCtaProv
INNER JOIN conCuentas ON conCuentas.conCuentas = comPagosAnticipo.Cuenta_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comPagosAnticipo.Usuario_Id
Inner Join genMonedas On genMonedas.genMonedas = comPagosAnticipo.Moneda_Id
LEFT JOIN tesMovimientos ON tesMovimientos.tesMovimientos = comPagosAnticipo.tesMovimientos
LEFT JOIN (genAsiSegmentos inner join genSegmentos ON 
	genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos) ON	
	genAsiSegmentos.Asiento_Id = comPagosAnticipo.comEmbarques
WHERE comPagosAnticipo.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And comPagosAnticipo.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) And
	comPagosAnticipo.Empresa_Id = @pEmpresa_Id AND 
	comPagosAnticipo.FechaPago <= ISNULL(@pFechaPago,comPagosAnticipo.FechaPago) And comPagosAnticipo.tesMovimientos Is Null

RETURN @@Error 

GO


DROP PROCEDURE comPagosAnticipoEliminar
GO
CREATE PROCEDURE comPagosAnticipoEliminar
(
@pProveed_Id varChar(15),
@pMoneda_Id varChar(3),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM comPagosAnticipo 
WHERE Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And comPagosAnticipo.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) And
	Empresa_Id = @pEmpresa_Id and tesMovimientos IS NULL
 
RETURN @@Error 

GO


DROP PROCEDURE comPagosAnticipoMarcarPagado
GO
CREATE PROCEDURE comPagosAnticipoMarcarPagado
(
	@pcomPagosAnticipo bigint,
	@ptesMovimietnos bigint
)
AS
	UPDATE comPagosAnticipo SET tesMovimientos = @ptesMovimietnos 
	WHERE
		comPagosAnticipo = @pcomPagosAnticipo


GO
