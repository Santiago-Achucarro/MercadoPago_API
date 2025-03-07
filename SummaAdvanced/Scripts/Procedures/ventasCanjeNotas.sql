-- ventasCanjeNotasDatos '0001','20180501','20180531',' ','ZZZZ', 1
DROP PROCEDURE ventasCanjeNotasDatos
GO
CREATE PROCEDURE ventasCanjeNotasDatos
(
 @Sucursal VarChar(25),
 @FechaDesde DateTime, 
 @FechaHasta DateTime, 
 @ClienteDesde VarChar(15),
 @ClienteHasta VarChar(15),
 @Empresa Int
)
as
SET NOCOUNT ON 

select @Sucursal as SucursalEmpr, @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@ClienteDesde as ClienteDesde, @ClienteHasta as ClienteHasta,
	Convert(VarChar(15), ' ') as Cliente_Id, Convert(int, 1) as Sucursal, 
	' ' as CondFiscal_Id, 'P01' AS UsoCfdi, '01' AS FormaPago, Cast(1 as Bit) PorNota, 
	Cast(0 as Numeric(18,2)) as Total, ' ' as CFVenta_Id, 
	dbo.FechaActual() as Fecha, 
		' ' as Segmento_Id, 0 as Segmento1N, 0 as Segmento2N, 0 as Segmento3N, 0 as Segmento4N,
		' ' as Segmento1C, ' ' as Segmento2C, ' ' as Segmento3C, ' ' as Segmento4C, 
		' ' ArchivoPDF, ' ' ArchivoXML


SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 
	dbo.Segmento( genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr , 
	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo,
	venMovimientos.Importe- isnull(sum(venMovImpuestos.Importe),0)  as SubTotal, 
	isnull(sum(venMovImpuestos.Importe),0) as Impuestos
From venMovimientos INNER JOIN genAsiSegmentos ON
	venMovimientos.venMovimientos =  genAsiSegmentos.Asiento_Id 
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSucursalesEmpr ON
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	inner join venSubTipoMov ON
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venCondFiscal ON
	venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
	INNER JOIN venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	LEFT JOIN (venMovImpuestos inner join venImpuestos ON
	venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos)  ON
	venMovImpuestos.venMovimientos = venMovimientos.venMovimientos

	WHERE
		1 = 2
group by genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo, genAsiSegmentos.Segmento_Id

SELECT venMovimientosCFDIR.venMovimientos, venMovimientosCFDIR.venMovimientosR, 
                        venMovimientosCFDIR.TipoRelacion, genSegmentos.Segmento_Id, 
						genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
                        genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
						genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
						dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
						genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
						genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
                        genAsiSegmentos.Segmento4N) as Segmento			
FROM venMovimientosCFDIR
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id =venMovimientosCFDIR.venMovimientosR
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
where 1=2

GO

-- ventasCanjeNotasAgregarDatos '0001','20180501','20180531',' ','ZZZZ', 1
DROP PROCEDURE ventasCanjeNotasAgregarDatos
GO
CREATE PROCEDURE ventasCanjeNotasAgregarDatos
(
 @Sucursal VarChar(25),
 @FechaDesde DateTime, 
 @FechaHasta DateTime, 
 @ClienteDesde VarChar(15),
 @ClienteHasta VarChar(15),
 @Empresa Int
)
as
SET NOCOUNT ON 

select @Sucursal as SucursalEmpr, @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@ClienteDesde as ClienteDesde, @ClienteHasta as ClienteHasta,
	Convert(VarChar(15), ' ') as Cliente_Id, Convert(int, 1) as Sucursal

SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 
	dbo.Segmento( genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr , 
	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo,
	venMovimientos.Importe- isnull(sum(venMovImpuestos.Importe),0)  as SubTotal, 
	isnull(sum(venMovImpuestos.Importe),0) as Impuestos
From venMovimientos INNER JOIN genAsiSegmentos ON
	venMovimientos.venMovimientos =  genAsiSegmentos.Asiento_Id 
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSucursalesEmpr ON
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	inner join venSubTipoMov ON
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venCondFiscal ON
	venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
	INNER JOIN venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	LEFT JOIN (venMovImpuestos inner join venImpuestos ON
	venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos)  ON
	venMovImpuestos.venMovimientos = venMovimientos.venMovimientos

	WHERE
		conAsientos.Anulado = 0 AND 
		conAsientos.Empresa_Id = @Empresa and
		conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
		(genSucursalesEmpr.Sucursal = @Sucursal or @Sucursal = ' ') and 
		venMovimientos.venTipoMov = 'F' and
		--venSubTipoMov.MueveStock = 1 AND 
		venCondFiscal.FacturaElectronica = 0 and 
		venClientes.Cliente_Id BETWEEN @ClienteDesde and @ClienteHasta and
		NOT EXISTS(SELECT 1 FROM venCanjeNotas inner join conAsientos ON
			venCanjeNotas.venMovimientosFC = conAsientos.conAsientos
			where
			venCanjeNotas.venMovimientos = venMovimientos.venMovimientos aND
			conAsientos.Anulado = 0)

group by genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo, genAsiSegmentos.Segmento_Id
			
GO
--exec ventasCanjeNotaAgregarDatos @pEmpresa_Id=1,@pSegmento_Id='FC',@pSegmento1N=244858,@pSegmento2N=0,@pSegmento3N=0,@pSegmento4N=0,@pSegmento1C='F',@pSegmento2C='0004',@pSegmento3C='N',@pSegmento4C=''
DROP PROCEDURE ventasCanjeNotaAgregarDatos
GO
CREATE PROCEDURE ventasCanjeNotaAgregarDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
as
SET NOCOUNT ON 

SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 
	dbo.Segmento( genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr , 
	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo,
	venMovimientos.Importe- isnull(sum(venMovImpuestos.Importe),0)  as SubTotal, 
	isnull(sum(venMovImpuestos.Importe),0) as Impuestos
From venMovimientos INNER JOIN genAsiSegmentos ON
	venMovimientos.venMovimientos =  genAsiSegmentos.Asiento_Id 
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSucursalesEmpr ON
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	inner join venSubTipoMov ON
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venCondFiscal ON
	venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
	LEFT JOIN (venMovImpuestos inner join venImpuestos ON
	venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos)  ON
	venMovImpuestos.venMovimientos = venMovimientos.venMovimientos

	WHERE
		conAsientos.Anulado = 0 AND 
		venMovimientos.venTipoMov = 'F' and
		-- venSubTipoMov.MueveStock = 1 AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id and
		genSegmentos.Segmento_Id =@pSegmento_Id and
		genAsiSegmentos.Segmento1N = @pSegmento1N and
		genAsiSegmentos.Segmento2N = @pSegmento2N and
		genAsiSegmentos.Segmento3N = @pSegmento3N and
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Segmento1C = @pSegmento1C and
		genAsiSegmentos.Segmento2C = @pSegmento2C and
		genAsiSegmentos.Segmento3C = @pSegmento3C and
		genAsiSegmentos.Segmento4C = @pSegmento4C and
		venCondFiscal.FacturaElectronica = 0 AND
		NOT EXISTS(SELECT 1 FROM venCanjeNotas inner join conAsientos ON
			venCanjeNotas.venMovimientosFC = conAsientos.conAsientos
			where
			venCanjeNotas.venMovimientos = venMovimientos.venMovimientos aND
			conAsientos.Anulado = 0)
group by genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	venMovimientos.venMovimientos, 	conAsientos.Fecha, 
	venMovimientos.Importe, venMovimientos.Saldo, genAsiSegmentos.Segmento_Id
			
GO




