DROP PROCEDURE sueFormExisteSemana
GO
CREATE PROCEDURE sueFormExisteSemana(
	@Anio INT, 
	@Semana INT
)
	AS

	IF EXISTS(SELECT 1 FROM sueLiquidacion WHERE
		Anio = @Anio and 
		Semana = @Semana )
		SELECT  1
SELECT 0

GO


	DROP PROCEDURE sueFormHora
	GO
	CREATE PROCEDURE sueFormHora
	(
		@Categoria_Id VarChar(5),
		@Fecha DateTime, 
		@nImporte Int,
		@Empresa_Id Int  
	)
	as
	DECLARE @Valor as Numeric(18,4)
	select @Valor = A.Valor FROM 
		(SELECT Valor from sueliqimpCatego inner join sueCategorias ON 
		sueliqimpCatego.Categoria_Id = sueCategorias.sueCategorias
		Where
			sueCategorias.Categoria_Id = @Categoria_Id and
			@Fecha between sueLiqImpCatego.Fecha_Desde and sueLiqImpCatego.Fecha_Hasta and 
			sueLiqImpCatego.CateNombre_Id = @nImporte
		UNION ALL
		SELECT Valor from sueLiqEmpCatego inner join sueCategorias ON 
		sueLiqEmpCatego.Categoria_Id = sueCategorias.sueCategorias
		Where
			sueCategorias.Categoria_Id = @Categoria_Id and
			@Fecha between sueLiqEmpCatego.Fecha_Desde and sueLiqEmpCatego.Fecha_Hasta and 
			sueLiqEmpCatego.CateNombre_Id = @nImporte AND
			sueLiqEmpCatego.Empresa_Id = @Empresa_Id) A

	SELECT isnull(@Valor, 0)
	GO



DROP PROCEDURE sueFormIMP
GO

CREATE PROCEDURE sueFormIMP
(
	@Legajo int,
	@Fecha DateTime, 
	@nImporte Int
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = Valor 
	from sueLiqPersImportes inner join suePersonal ON 
	sueLiqPersImportes.Legajo = suePersonal.genEntidades
	Where
		suepersonal.Legajo = @Legajo and
		@Fecha between sueLiqPersImportes.Fecha_Desde and sueLiqPersImportes.Fecha_Hasta and 
		sueLiqPersImportes.Importe_Id = @nImporte

SELECT isnull(@Valor, 0)

GO


DROP PROCEDURE sueFormCOD
GO

CREATE PROCEDURE sueFormCOD
(
	@Legajo int,
	@Concepto INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	Where
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id = @Concepto and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO



DROP PROCEDURE sueFormVAR
GO

CREATE PROCEDURE sueFormVAR
(
	@nVariable Int,
	@Fecha DateTime, 
	@Empresa_Id Int
)
as
DECLARE @Valor as Numeric(18,4)

if Exists(SELECT 1 FROM sueVarGlobales where
	VarGlobal_Id = @nVariable and 
	PorEmpresa = 1)

begin
select @Valor = Valor 
	from sueVarGlobales INNER JOIN sueLiqVarEmpGlobales on
	sueVarGlobales.VarGlobal_Id = sueLiqVarEmpGlobales.VarGlobal_Id
	Where
		sueVarGlobales.VarGlobal_Id = @nVariable and
		@Fecha between sueLiqVarEmpGlobales.Fecha_Desde and sueLiqVarEmpGlobales.Fecha_Hasta and 
		sueLiqVarEmpGlobales.Empresa_Id = @Empresa_Id
end

Else

begin
select @Valor = Valor 
	from sueVarGlobales INNER JOIN sueLiqVarGlobales on
	sueVarGlobales.VarGlobal_Id = sueLiqVarGlobales.VarGlobal_Id
	Where
		sueVarGlobales.VarGlobal_Id = @nVariable and
		@Fecha between sueLiqVarGlobales.Fecha_Desde and sueLiqVarGlobales.Fecha_Hasta 
end

SELECT isnull(@Valor, 0)

GO



DROP PROCEDURE sueFormACUM
GO

CREATE PROCEDURE sueFormACUM
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@AnioDesde INT, 
	@MesDesde INT, 
	@AnioHasta INT, 
	@MesHasta INT
)
as


DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	left JOIN conAsientos on
	conAsientos.conasientos = sueLiquidacion.sueLiquidacion
	Where
		ISNULL(conAsientos.Anulado,0) = 0 AND 
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id Between @ConceptoDesde and @ConceptoHasta and 
			sueliquidacion.Anio*100 + sueliquidacion.Mes between 
			@AnioDesde * 100 +@MesDesde and 
			@AnioHasta * 100 +@MesHasta
			 

SELECT isnull(@Valor, 0)

GO

DROP PROCEDURE sueFormNETO
GO

CREATE PROCEDURE sueFormNETO
(
	@Legajo int,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe*sueTerminada.Signo)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	Where
			suePersonal.Legajo = @Legajo and 
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO



DROP PROCEDURE sueFormSCANT
GO

CREATE PROCEDURE sueFormSCANT
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@AnioDesde INT, 
	@MesDesde INT, 
	@AnioHasta INT, 
	@MesHasta INT
)
as

-- Suama las cantidades de SueDato 
DECLARE @Valor as Numeric(18,4)

select @Valor = SUM(sueDato.Dato) 
	from sueLiquidacion INNER JOIN sueDato ON 
	sueLiquidacion.sueLiquidacion =  sueDato.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueDato.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueDato.Legajo
	Where
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id Between @ConceptoDesde and @ConceptoHasta and 
			sueLiquidacion.FechaFinal >= suePersonal.FechaIngreso and 
			sueliquidacion.Anio*100 + sueliquidacion.Mes between 
			@AnioDesde * 100 +@MesDesde and 
			@AnioHasta * 100 +@MesHasta
			 

SELECT  isnull(@Valor, 0) AS Dato

GO

DROP PROCEDURE sueFormSCANTERMI
GO
CREATE PROCEDURE sueFormSCANTERMI
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@AnioDesde INT, 
	@MesDesde INT, 
	@AnioHasta INT, 
	@MesHasta INT
)
as

-- Suama las cantidades de sueTerminada
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Dato)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	Where
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id Between @ConceptoDesde and @ConceptoHasta and 
			sueLiquidacion.FechaFinal >= suePersonal.FechaIngreso and 
			sueliquidacion.Anio*100 + sueliquidacion.Mes between 
			@AnioDesde * 100 +@MesDesde and 
			@AnioHasta * 100 +@MesHasta
			 

SELECT isnull(@Valor, 0)

GO



DROP PROCEDURE sueFormCANT
GO

CREATE PROCEDURE sueFormCANT
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Dato)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Where
			ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO

DROP PROCEDURE sueFormSDATO
GO

CREATE PROCEDURE sueFormSDATO
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueDato.Dato)
	from sueLiquidacion INNER JOIN sueDato ON 
	sueLiquidacion.sueLiquidacion =  sueDato.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueDato.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueDato.Legajo
	inner join conAsientos ON  conAsientos.conAsientos = sueliquidacion.sueLiquidacion
	Where
			conAsientos.Anulado = 0 AND 
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO


DROP PROCEDURE sueFormSUMA
GO

CREATE PROCEDURE sueFormSUMA
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Where
			ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO



DROP PROCEDURE sueFormSUMAP
GO
CREATE PROCEDURE sueFormSUMAP
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
DECLARE @Valor2 as Numeric(18,4)
DECLARE @Valor3 as Numeric(18,4)

select @Valor = SUM(sueTerminada.Importe)
from sueLiquidacion 
	INNER JOIN sueTerminada ON sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
	LEFT JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
Where ISNULL(conAsientos.Anulado,0) = 0 and
	suePersonal.Legajo = @Legajo and 
	sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
	sueliquidacion.Anio = @Anio and 
	(sueliquidacion.Mes = @Mes OR @Mes =0) AND
	(sueliquidacion.Quincena = @Quin OR @Quin =0) AND
	(sueliquidacion.Decena = @Decena OR @Decena =0) AND
	(sueliquidacion.Semana = @Semana OR @Semana =0) AND
	(sueliquidacion.Vez = @Vez OR @Vez =0) 

SELECT @Valor2 = SUM(sueTerminadaRetro.Importe)
	from sueLiquidacion INNER JOIN sueTerminadaRetro ON 
	sueLiquidacion.sueLiquidacion = sueTerminadaRetro.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminadaRetro.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminadaRetro.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Where ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0) AND
			 (sueTerminadaRetro.MesRetro <> @Mes OR sueTerminadaRetro.AnioRetro <> @Anio)

SELECT @Valor3 = SUM(sueTerminadaRetro.Importe)
	from sueLiquidacion INNER JOIN sueTerminadaRetro ON 
	sueLiquidacion.sueLiquidacion = sueTerminadaRetro.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminadaRetro.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminadaRetro.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Where ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueTerminadaRetro.AnioRetro = @Anio and 
			 (sueTerminadaRetro.MesRetro = @Mes OR @Mes =0) AND
			 (sueLiquidacion.Mes <> @Mes OR sueLiquidacion.Anio <> @Anio)

SELECT isnull(@Valor, 0) - isnull(@Valor2, 0) + isnull(@Valor3, 0)

GO




DROP PROCEDURE sueFormDATO
GO

CREATE PROCEDURE sueFormDATO
(
	@Legajo int,
	@Concepto INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
DECLARE @Valor2 as Numeric(18,4)
select @Valor = sueDato.Dato,
		@Valor2 = sueDato.Dato2
	from sueLiquidacion INNER JOIN sueDato ON 
	sueLiquidacion.sueLiquidacion =  sueDato.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueDato.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueDato.Legajo
	Where
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id = @Concepto and
			sueliquidacion.Anio = @Anio and 
			 sueliquidacion.Mes = @Mes AND
			 sueliquidacion.Quincena = @Quin  AND
			 sueliquidacion.Decena = @Decena AND
			 sueliquidacion.Semana = @Semana  AND
			 sueliquidacion.Vez = @Vez 

SELECT isnull(@Valor, 0), isnull(@Valor2, 0)

GO



DROP PROCEDURE sueFormSUMAA
GO

CREATE PROCEDURE sueFormSUMAA
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT, 
	@Propiedad VarChar(10)
)
as
-- DEBE TOMAR EN CUENTA EL SIGNO
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe*sueTerminada.Signo)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	INNER JOIN sueConceptosPropValor ON 
		sueConceptosPropValor.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.SiNo = 1 
	INNER JOIN sueConceptosProp ON
	sueConceptosProp.sueConceptosProp = sueConceptosPropValor.Propiedad 
	Where
			sueConceptosProp.Propiedad = @Propiedad and 
			ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO

DROP PROCEDURE sueFormTablaGan
GO
CREATE PROCEDURE sueFormTablaGan   
(  
 @Tabla_Id Int,   
 @Valor Numeric(18,4)  
)  
AS
IF @Valor <= 0
	SELECT 0.00 Desde, 0.00 Hasta, 0.00 Porcentaje, 0.00 Minimo
ELSE
	SELECT TOP 1   
		ISNULL((SELECT MAX(Hasta) From sueGanancias sueGananciasD   
	WHERE  
		sueGananciasD.TabGan_Id = sueGanancias.TabGan_Id AND   
		sueGananciasD.Hasta < sueGanancias.Hasta),0) as Desde,  
		 Hasta, Porcentaje, Minimo  
	FROM sueGanancias   
	WHERE  
		sueGanancias.TabGan_Id = @Tabla_Id and   
		sueGanancias.Hasta >= @Valor  
	ORDER BY 1
GO




DROP PROCEDURE sueFormTabla
go
CREATE PROCEDURE sueFormTabla
(
	@Tabla_Id Int, 
	@Valor Numeric(18,4)
)
AS
	SELECT TOP 1 Fila, Valor
	FROM sueTabla
		Where
			sueTabla.Tabla_Id = @Tabla_Id and 
			sueTabla.Fila >= @Valor
			ORDER BY 1
go

	
DROP PROCEDURE sueFormCONCACUM
GO
CREATE PROCEDURE sueFormCONCACUM
(
	@Concepto_Id INT, 
	@Legajo INT, 
	@Fecha DateTime,
	@Empresa_Id int
)

as

SELECT sueConcAcum.sueConcAcum, MontoTope, Descuento, Acumulado
FROM sueConcAcum 
	INNER JOIN suePersonal ON suePersonal.genEntidades = sueConcAcum.Legajo 
	INNER JOIN sueConceptos ON sueConceptos.sueConceptos = sueConcAcum.Concepto_Id
	INNER JOIN sueConcAcumSegmento ON sueConcAcumSegmento.sueConcAcum = sueConcAcum.sueConcAcum
Where
		sueConcAcumSegmento.Empresa_Id = @Empresa_Id and 
		sueConcAcum.Anulado = 0 and 
		sueConcAcum.Fecha <= @Fecha and 
		sueConcAcum.MontoTope >  sueConcAcum.Acumulado and 
		suePersonal.Legajo = @Legajo and 
		sueConceptos.Concepto_Id = @Concepto_Id
GO



DROP PROCEDURE sueFormSUMAAFPago
GO

CREATE PROCEDURE sueFormSUMAAFPago
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT, 
	@Propiedad VarChar(10)
)
as
DECLARE @Valor as Numeric(18,4)
Select @Valor = SUM(sueTerminada.Importe)
	From sueTerminada
	Inner Join sueLiquidacion ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion --sueLiqFechaPago.FechaPago >= sueLiquidacion.FechaPago And sueLiquidacion.Anio = @Anio  
	Inner Join sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	Inner Join suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
	Cross Join (sueLiquidacion sueLiqFechaPago Inner Join conAsientos CA On CA.conAsientos = sueLiqFechaPago.sueLiquidacion And
		CA.Anulado = 0)--On sueLiqFechaPago.sueLiquidacion = sueLiquidacion.sueLiquidacion
	Left Join conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Inner Join sueConceptosPropValor ON sueConceptosPropValor.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.SiNo = 1 
	Inner Join sueConceptosProp ON sueConceptosProp.sueConceptosProp = sueConceptosPropValor.Propiedad 
	Where
			sueConceptosProp.Propiedad = @Propiedad and 
			ISNULL(conAsientos.Anulado,0) = 0 and 
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueLiqFechaPago.Anio = @Anio and 
			sueLiqFechaPago.Mes = @Mes AND
			sueLiqFechaPago.Quincena = @Quin AND
			sueLiqFechaPago.Decena = @Decena AND
			sueLiqFechaPago.Semana = @Semana AND
			sueLiqFechaPago.Vez = @Vez And
			sueLiquidacion.FechaPago <= sueLiqFechaPago.FechaPago And
			--sueLiquidacion.Anio = @Anio
			Year(sueLiquidacion.FechaPago) = Year(sueLiqFechaPago.FechaPago)


SELECT isnull(@Valor, 0)

GO

Drop Procedure sueFormEnvac
Go
Create Procedure sueFormEnvac
(
@pLegajo int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
Select FechaDesde, FechaHasta 
FROM sueVacTomadas
Inner Join suePersonal On suePersonal.genEntidades = sueVacTomadas.Legajo
WHERE suePersonal.Legajo = @pLegajo AND
	(FechaDesde Between @pFechaDesde And @pFechaHasta Or
	FechaHasta Between @pFechaDesde And @pFechaHasta Or
	FechaDesde <= @pFechaDesde And FechaHasta >= @pFechaDesde Or
	FechaHasta >= @pFechaHasta And @pFechaDesde <= @pFechaHasta)
Go

Drop procedure sueFormGanCony
Go
Create procedure sueFormGanCony
(
@pLegajo int
)
As
Select ACargoDesde, FechaBaja 
From sueFamiliares
Where
Legajo = dbo.FuncFKsuePersonal(@pLegajo) And Relacion In ('C','O') And Ganancias = 1
Go

Drop procedure sueFormGanOtro
Go
Create procedure sueFormGanOtro
(
@pLegajo int
)
As
Select ACargoDesde, FechaBaja 
From sueFamiliares
Where
Legajo = dbo.FuncFKsuePersonal(@pLegajo) And Relacion <> 'C' And Relacion <> 'H' And Ganancias = 1
Go



DROP PROCEDURE sueFormSUMSGN
GO

CREATE PROCEDURE sueFormSUMSGN
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
select @Valor = SUM(sueTerminada.Importe* sueConceptos.Signo)
	from sueLiquidacion INNER JOIN sueTerminada ON 
	sueLiquidacion.sueLiquidacion =  sueTerminada.sueLiquidacion
	inner join sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON 
	suePersonal.genEntidades = sueTerminada.Legajo
	LEFT JOIN conAsientos ON 
	conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	Where
			ISNULL(conAsientos.Anulado,0) = 0 and
			suePersonal.Legajo = @Legajo and 
			sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
			sueliquidacion.Anio = @Anio and 
			 (sueliquidacion.Mes = @Mes OR @Mes =0) AND
			 (sueliquidacion.Quincena = @Quin OR @Quin =0) AND
			 (sueliquidacion.Decena = @Decena OR @Decena =0) AND
			 (sueliquidacion.Semana = @Semana OR @Semana =0) AND
			 (sueliquidacion.Vez = @Vez OR @Vez =0)

SELECT isnull(@Valor, 0)

GO

DROP PROCEDURE sueFormDVac
GO
CREATE PROCEDURE sueFormDVac
(
	@Legajo Int,
	@FechaDesde DateTime, 
	@FechaHasta DateTime
)
AS
DECLARE @Valor as Numeric(18,4)
SELECT @Valor = SUM(Dias) FROM sueVacTomadas
	INNER JOIN suePersonal ON sueVacTomadas.Legajo = suePersonal.genEntidades
	WHERE suePersonal.Legajo = @Legajo AND
	sueVacTomadas.FechaDesde BETWEEN @FechaDesde AND @FechaHasta
	
SELECT ISNULL(@Valor, 0)
GO


DROP PROCEDURE sueFormGanHijo  
GO
CREATE PROCEDURE sueFormGanHijo  
(  
@pLegajo int  
)  
As  
Select ACargoDesde, FechaBaja, Incapacitado, FechaNacimiento   
From sueFamiliares 
Where Legajo = dbo.FuncFKsuePersonal(@pLegajo) And Relacion = 'H' And Ganancias = 1 AND
Incapacitado = 1
UNION 
Select ACargoDesde, FechaBaja, Incapacitado, FechaNacimiento   
From sueFamiliares 
Where Legajo = dbo.FuncFKsuePersonal(@pLegajo) And Relacion = 'H' And Ganancias = 1 
Go

DROP PROCEDURE sueFormSUMH
GO

CREATE PROCEDURE sueFormSUMH
(
	@Legajo int,
	@ConceptoDesde INT,
	@ConceptoHasta INT,
	@Anio INT, 
	@Mes INT, 
	@Quin Int, 
	@Decena Int,
	@Semana Int, 
	@Vez INT
	
)
as
DECLARE @Valor as Numeric(18,4)
Select @Valor = SUM(sueTerminada.Importe)
From sueLiquidacion 
INNER JOIN sueTerminada ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
inner join sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
LEFT JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
Where
		ISNULL(conAsientos.Anulado,0) = 0 and
		suePersonal.Legajo = @Legajo and 
		sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
		((sueliquidacion.Anio = @Anio And sueliquidacion.Mes = @Mes And sueliquidacion.Quincena = @Quin AND
		sueliquidacion.Vez <= @Vez And @Quin = 1)
		Or (( @Quin = 2 And (sueliquidacion.Anio = @Anio And sueliquidacion.Mes = @Mes And sueliquidacion.Quincena = @Quin And
		sueliquidacion.Vez <= @Vez)
		Or sueliquidacion.Anio = @Anio And sueliquidacion.Mes = @Mes And sueliquidacion.Quincena = 1 And @Quin = 2)))

SELECT isnull(@Valor, 0)

GO

