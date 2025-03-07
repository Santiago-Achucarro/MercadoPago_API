-- PRINT dbo.AfinuevoCondigo('DEPG',1)
-- AfiActivoFijoDatos 'ECO00001', 1

DROP function AfinuevoCondigo
GO
create function AfinuevoCondigo(@Rubro_id VarChar(5), @pEmpresa_Id INT)
RETURNS VarChar(15)
as
bEGIN
Declare  @Maximo int 
Declare @Digitos int
Declare @Maxstr VarChar(10)

SELECT  @Maximo = isnull(Convert(int,MAX(Right(ActivoFijo_id, AfiRubros.Digitos))),0)+1 , 
		@Digitos = AfiRubros.Digitos
		from AfiRubros  LEFT JOIN afiActivoFijo ON
		afiActivoFijo.Rubro_Id = AfiRubros.AfiRubros AND 
		afiActivoFijo.Empresa_Id = @pEmpresa_Id AND
		ActivoFijo_id like @Rubro_id+'%'
		Where
			AfiRubros.Rubro_Id = @Rubro_id  
	GROUP BY AfiRubros.Digitos

SET @Maxstr = LTRIM(STR(@Maximo,10))

Return (@Rubro_id + SUBSTRING('0000000000',1,@Digitos -LEN(@Maxstr))+@MaxStr)

END
GO

DROP PROCEDURE afiActivoFijoGuardar
GO
CREATE PROCEDURE afiActivoFijoGuardar
(
@pActivoFijo_Id varchar(15),
@pActivoFijo_Id_Nuevo varchar(15),
@pEmpresa_Id Int,
@pDescripcion QMemo = NULL,
@pFechaAlta qFecha,
@pFechaIniDepre qFecha,
@pFechaBaja qFecha = NULL,
@pValorInicial qMonedaD2,
@pValorFiscal qMonedaD2,
@pVidaUtil int,
@pVidaUtilRestante int,
@pPorResidual qPorcentaje,
@pAmortAcumulada qMonedaD2,
@pRubro_Id varchar(5) = NULL,
@pCantidad QCantidad,
@pCtaValorOrigen_Id varchar(25) = NULL,
@pCtaAmortAcum_Id varchar(25) = NULL,
@pCtaAmortizacion_Id varchar(25) = NULL,
@pTipo varchar(2),
@pValorInicialSI qMonedaD2,
@pAmortAcumSI qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM afiActivoFijo WHERE ActivoFijo_Id=@pActivoFijo_Id and Empresa_Id =@pEmpresa_Id))
BEGIN 
	UPDATE afiActivoFijo
	SET		@lIdentidad = AfiActivoFijo,
		ActivoFijo_Id = @pActivoFijo_Id_Nuevo,
		Descripcion = @pDescripcion,
		FechaAlta = @pFechaAlta,
		FechaIniDepre = @pFechaIniDepre,
		FechaBaja = @pFechaBaja,
		ValorInicial = @pValorInicial,
		ValorFiscal = @pValorFiscal,
		VidaUtil = @pVidaUtil,
		VidaUtilRestante = @pVidaUtilRestante,
		PorResidual = @pPorResidual,
		AmortAcumulada = @pAmortAcumulada,
		Rubro_Id = dbo.FuncFKAfiRubros( @pRubro_Id),
		Cantidad = @pCantidad,
		CtaValorOrigen_Id = dbo.FuncFKconCuentas(@pCtaValorOrigen_Id),
		CtaAmortAcum_Id = dbo.FuncFKconCuentas(@pCtaAmortAcum_Id),
		CtaAmortizacion_Id = dbo.FuncFKconCuentas(@pCtaAmortizacion_Id),
		Tipo = @pTipo,
		ValorInicialSI = @pValorInicialSI,
		AmortAcumSI = @pAmortAcumSI,
		Usuario_Id = @pUsuario_Id
	WHERE 
	ActivoFijo_Id=@pActivoFijo_Id  and 
	Empresa_Id = @pEmpresa_Id
END 
ELSE 
BEGIN 

	if (rtrim(@pActivoFijo_Id_Nuevo) ='')
	begin
		SET @pActivoFijo_Id_Nuevo = dbo.AfinuevoCondigo(@pRubro_Id, @pEmpresa_Id)
	end
	INSERT INTO afiActivoFijo
	(
		ActivoFijo_Id,
		Descripcion,
		FechaAlta,
		FechaIniDepre,
		FechaBaja,
		ValorInicial,
		ValorFiscal,
		VidaUtil,
		VidaUtilRestante,
		PorResidual,
		AmortAcumulada,
		Rubro_Id,
		Cantidad,
		CtaValorOrigen_Id,
		CtaAmortAcum_Id,
		CtaAmortizacion_Id,
		Tipo,
		ValorInicialSI,
		AmortAcumSI,
		Usuario_Id,
		FechaCarga, 
		Empresa_Id
	)
	VALUES 
	(
		@pActivoFijo_Id_Nuevo,
		@pDescripcion,
		@pFechaAlta,
		@pFechaIniDepre,
		@pFechaBaja,
		@pValorInicial,
		@pValorFiscal,
		@pVidaUtil,
		@pVidaUtilRestante,
		@pPorResidual,
		@pAmortAcumulada,
		dbo.FuncFKAfiRubros( @pRubro_Id),
		@pCantidad,
		dbo.FuncFKconCuentas(@pCtaValorOrigen_Id),
		dbo.FuncFKconCuentas(@pCtaAmortAcum_Id),
		dbo.FuncFKconCuentas(@pCtaAmortizacion_Id),
		@pTipo,
		@pValorInicialSI,
		@pAmortAcumSI,
		@pUsuario_Id,
		dbo.FechaActual(),
		@pEmpresa_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE afiActivoFijoDatos
GO
CREATE PROCEDURE afiActivoFijoDatos
(
	@pActivoFijo_Id varchar(15), 
	@pEmpresa Int 
)
AS
SET NOCOUNT ON 

SELECT afiActivoFijo.AfiActivoFijo, afiActivoFijo.ActivoFijo_Id, afiActivoFijo.Descripcion, afiActivoFijo.FechaAlta,
	afiActivoFijo.FechaIniDepre, afiActivoFijo.FechaBaja, afiActivoFijo.ValorInicial, afiActivoFijo.ValorFiscal,
	afiActivoFijo.VidaUtil, afiActivoFijo.VidaUtilRestante, afiActivoFijo.PorResidual, afiActivoFijo.AmortAcumulada,AfiRubros.Rubro_Id,
	AfiRubros.Descripcion as DescripcionRubros, afiActivoFijo.Cantidad,  conCuentas.Cuenta_Id 
	as CtaValorOrigen_Id, conCuentas.Descripcion as DescripcionCuentasOrigen,
	conCuentas2.Cuenta_Id as CtaAmortAcum_Id, conCuentas2.Descripcion as DescripcionCtaAmortAcum_Id, conCuentas3.Cuenta_Id as CtaAmortizacion
	, conCuentas3.Descripcion as DescripcionCtaAmortizacion,
	afiActivoFijo.Tipo, afiActivoFijo.ValorInicialSI, afiActivoFijo.AmortAcumSI, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, afiActivoFijo.FechaCarga, 
		afiActivoFijo.Empresa_Id, 
			CAST( case when exists(select 1 from AfiMovimientos inner join conAsientos on
				AfiMovimientos.conAsientos = conAsientos.conAsientos And
				AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo And 
				conAsientos.Anulado = 0) then 1 else 0 end as bit) as TieneMovimientos, 
				aficonMovCont.conASientos AsientoOrigen , aficonMovCont.Renglon RenglonOrigen, '' as Origen
FROM afiActivoFijo 
LEFT JOIN AfiRubros  ON (AfiRubros.AfiRubros = afiActivoFijo.Rubro_Id)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = afiActivoFijo.CtaValorOrigen_Id)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = afiActivoFijo.CtaAmortAcum_Id)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = afiActivoFijo.CtaAmortizacion_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = afiActivoFijo.Usuario_Id)
LEFT JOIN aficonMovCont ON aficonMovCont.ActivoFijo_Id = afiActivoFijo.afiActivoFijo
WHERE  
afiActivoFijo.ActivoFijo_Id=@pActivoFijo_Id and 
afiActivoFijo.Empresa_Id = @pEmpresa


 Declare @pidentity int= dbo.FuncFKafiActivoFijo(@pActivoFijo_Id, @pEmpresa)
 Exec   AfiCentrosDatos @pidentity, null, null
 select afiActivoFijo.ActivoFijo_Id, afiActivoFijo.Descripcion as DescripcionActivoFijo, afiResponsables.Responsable_Id, afiResponsables.Descripcion as DescripcionResponsable,
 afiResponsableActivo.Cantidad from afiResponsableActivo 
 inner join afiResponsables on afiResponsables.afiResponsables=afiResponsableActivo.Responsable_Id
inner join afiActivoFijo on afiActivoFijo.afiActivoFijo=afiResponsableActivo.ActivoFijo_Id
where
afiActivoFijo.ActivoFijo_Id=@pActivoFijo_Id and 
afiActivoFijo.Empresa_Id = @pEmpresa

 Exec genAtributosGeneralesIdentityDatos @pidentity, 'afiActivoFijo'
 exec genAdjuntosIdentityDatos 'afiActivoFijo',@pidentity
 RETURN @@Error 

GO

DROP PROCEDURE afiActivoFijoEliminar
GO
CREATE PROCEDURE afiActivoFijoEliminar
(
@pActivoFijo_Id varchar(15), 
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM afiActivoFijo 
WHERE  
	ActivoFijo_Id=@pActivoFijo_Id and Empresa_Id =@pEmpresa_Id
RETURN @@Error 

GO

drop FUNCTION FuncFKafiActivoFijo

GO
CREATE FUNCTION FuncFKafiActivoFijo
(
@pActivoFijo_Id varchar(15), 
@pEmpresa_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = afiActivoFijo 
	FROM afiActivoFijo 
	Where 
	ActivoFijo_Id=@pActivoFijo_Id and 
	Empresa_Id = @pEmpresa_Id
  RETURN @pIdentity
END
GO

DROP PROCEDURE afiActivoFijoDatosInt
GO
CREATE PROCEDURE afiActivoFijoDatosInt
(
	@pActivoFijo int
)
AS
SET NOCOUNT ON 

SELECT afiActivoFijo.ActivoFijo_Id
FROM afiActivoFijo 
WHERE  
afiActivoFijo.AfiActivoFijo =@pActivoFijo

 RETURN @@Error 

GO

DROP PROCEDURE afiActivoFijoActuDepAcum
GO
CREATE PROCEDURE afiActivoFijoActuDepAcum
(
	@pActivoFijo_Id varchar(15),
	@pEmpresa_Id Int,
	@pVidaUtil int,
	@pAmortAcumulada qMonedaD2
)
AS
	UPDATE afiActivoFijo
	SET		
		VidaUtilRestante = VidaUtilRestante - @pVidaUtil,
		AmortAcumulada = AmortAcumulada + @pAmortAcumulada
	WHERE 
	ActivoFijo_Id=@pActivoFijo_Id  and 
	Empresa_Id = @pEmpresa_Id
GO




-- afiActivoFijoAmortDatos '20181130',1,'BU'
DROP PROCEDURE afiActivoFijoAmortDatos
GO
CREATE PROCEDURE afiActivoFijoAmortDatos
(
	@pFechaHasta DateTime,
	@pEmpresa_Id Int, 
	@pTipo VarChar(2)
	
)
AS

	SELECT conAsientos.conAsientos,
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, conAsientos.Fecha, @pTipo as Tipo
	from conAsientos inner join genAsiSegmentos ON
		conAsientos.conAsientos =  genAsiSegmentos.Asiento_id
		INNER JOIN genSegmentos ON
		genSegmentos.genSegmentos =  genAsiSegmentos.Segmento_Id
	where Exists(select 1 from AfiMovimientos INNER JOIN afiActivoFijo on
		AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo 
	 WHERE
		afiActivoFijo.Tipo = @pTipo and 
		AfiMovimientos.conAsientos = conAsientos.conAsientos AND 
		AfiMovimientos.TipoMov = 'AM') and 
		conAsientos.Fecha = @pFechaHasta and 
		conAsientos.Empresa_Id = @pEmpresa_Id and 
		conAsientos.Anulado = 0

		

	SELECT  conAsientos.conAsientos,  afiActivoFijo.ActivoFijo_Id, 
		AfiMovimientos.AfiActivoFijo,
		conMovCont.Importe , conMovCont.Clase 
	from conAsientos INNER JOIN conMovCont ON
	conAsientos.conAsientos = conMovCont.conAsientos 
	INNER JOIN AfiMovimientos ON
	AfiMovimientos.conAsientos = conMovCont.conAsientos AND 
	AfiMovimientos.Renglon = conMovCont.Renglon 
	INNER JOIN afiActivoFijo ON
	afiActivoFijo.AfiActivoFijo =  AfiMovimientos.AfiActivoFijo
	Where
		conAsientos.Anulado = 0 AND 
		conAsientos.Empresa_Id = @pEmpresa_Id and 
		conMovCont.Clase = 'AM' AND 
		AfiMovimientos.TipoMov = 'AM' and
		conAsientos.Fecha = @pFechaHasta
GO



DROP PROCEDURE afiActivoFijoOtrosDatos
GO
CREATE PROCEDURE afiActivoFijoOtrosDatos
(
	@pActivoFijo_Id varchar(15), 
	@pEmpresa Int 
)
AS


exec afiActivoFijoDatos @pActivoFijo_Id,@pEmpresa
exec AficonMovcontPendDatos @pEmpresa

GO


DROP PROCEDURE afiActivoFijoDatosInt
GO
CREATE PROCEDURE afiActivoFijoDatosInt
(
	@pActivoFijo_Id int
)
AS
SET NOCOUNT ON 

SELECT afiActivoFijo.AfiActivoFijo, afiActivoFijo.ActivoFijo_Id, afiActivoFijo.ActivoFijo_Id as ActivoFijo_Id_Nueva, afiActivoFijo.Descripcion, afiActivoFijo.FechaAlta,
	afiActivoFijo.FechaIniDepre, afiActivoFijo.FechaBaja, afiActivoFijo.ValorInicial, afiActivoFijo.ValorFiscal,
	afiActivoFijo.VidaUtil, afiActivoFijo.VidaUtilRestante, afiActivoFijo.PorResidual, afiActivoFijo.AmortAcumulada,AfiRubros.Rubro_Id,
	AfiRubros.Descripcion as DescripcionRubros, afiActivoFijo.Cantidad,  conCuentas.Cuenta_Id 
	as CtaValorOrigen_Id, conCuentas.Descripcion as DescripcionCuentasOrigen,
	conCuentas2.Cuenta_Id as CtaAmortAcum_Id, conCuentas2.Descripcion as DescripcionCtaAmortAcum_Id, conCuentas3.Cuenta_Id as CtaAmortizacion
	, conCuentas3.Descripcion as DescripcionCtaAmortizacion,
	afiActivoFijo.Tipo, afiActivoFijo.ValorInicialSI, afiActivoFijo.AmortAcumSI, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, afiActivoFijo.FechaCarga, 
		afiActivoFijo.Empresa_Id, 
			CAST( case when exists(select 1 from AfiMovimientos inner join conAsientos on
				AfiMovimientos.conAsientos = conAsientos.conAsientos And
				AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo And 
				conAsientos.Anulado = 0) then 1 else 0 end as bit) as TieneMovimientos, 
				aficonMovCont.conASientos AsientoOrigen , aficonMovCont.Renglon RenglonOrigen, '' as Origen
FROM afiActivoFijo 
LEFT JOIN AfiRubros  ON (AfiRubros.AfiRubros = afiActivoFijo.Rubro_Id)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = afiActivoFijo.CtaValorOrigen_Id)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = afiActivoFijo.CtaAmortAcum_Id)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = afiActivoFijo.CtaAmortizacion_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = afiActivoFijo.Usuario_Id)
LEFT JOIN aficonMovCont ON aficonMovCont.ActivoFijo_Id = afiActivoFijo.afiActivoFijo
WHERE  
afiActivoFijo.afiActivoFijo =@pActivoFijo_Id


 
 Exec   AfiCentrosDatos @pActivoFijo_Id, null, null
 Exec genAtributosGeneralesIdentityDatos @pActivoFijo_Id, 'afiActivoFijo'
 RETURN @@Error 

GO

--afiActivoFijoOtrosDatos ' ',1