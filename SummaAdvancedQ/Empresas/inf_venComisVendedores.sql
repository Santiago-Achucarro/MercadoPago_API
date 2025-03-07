USE [SummaAdv]
GO

/****** Object:  StoredProcedure [dbo].[inf_venComisVendedores]    Script Date: 6/11/2024 9:54:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[inf_venComisVendedores]
(
    @VendedorDesde varchar(5),
    @VendedorHasta varchar(5),
    @FechaDesde datetime,
    @FechaHasta datetime,
    @SobreCobrado SiNo,
    @Empresa_Id int
)
as
if(@SobreCobrado=0)
	begin
	select venVendedores.Vendedor_Id, venVendedores.Nombre, dbo.Segmento(Segmento_Id, Segmento1C, Segmento2C, Segmento3C, 
	Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) as Asiento, venClientes.RazonSocial,
	Fecha, venTipoMov.Signo*SubTotalBonif as SubTotal, venTipoMov.Signo*(Importe-SubTotalBonif) as Impuestos, 
	venTipoMov.Signo*Importe as Total, venTipoMov.Signo*round(SubTotalBonif*venMovimientos.Comision1/100,2) as Comision, 
	venMovimientos.Comision1 as Porcentaje 
	from venMovimientos
	inner join conAsientos on conAsientos.conAsientos=venMovimientos.venMovimientos
	inner join venVendedores on venMovimientos.Vendedor_Id=venVendedores.venVendedores
	inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
	inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
	inner join venSubTipoMov on venMovimientos.venSubTipoMov_Id=venSubTipoMov.venSubTipoMov
	INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
	where venMovimientos.venTipoMov in('F','R') and 
	venSubTipoMov.AfectaComVenta = 1 and
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and 
	conAsientos.Empresa_Id = @Empresa_Id and conAsientos.Posteado=1 and conAsientos.Anulado=0
	ORDER BY 1,5
	END
else
	BEGIN
	SELECT A.Vendedor_Id, A.Nombre, A.Asiento, A.RazonSocial, A.Fecha, SUM(A.SubTotal) SubTotal,
	SUM(A.Impuestos) Impuestos, SUM(A.Comision) Comision, A.Porcentaje
	FROM (SELECT venVendedores.Vendedor_Id, venVendedores.Nombre, dbo.Segmento(Segmento_Id, Segmento1C, Segmento2C, Segmento3C, 
	Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) as Asiento, venClientes.RazonSocial, 
	conAsientosFC.Fecha, genCancMov.Importe*venMovimientosAP.SubTotalBonif/venMovimientosAP.Importe as SubTotal,
	gencancmov.Importe*(venMovimientosAP.Importe-venMovimientosAP.SubTotalBonif)/venMovimientosAP.Importe as Impuestos, 
	genCancMov.Importe as Total, 
	round(genCancMov.Importe*venMovimientosAP.SubTotalBonif/venMovimientosAP.Importe*venMovimientosAP.Comision1/100,2) as Comision, 
	venMovimientosAP.Comision1 as Porcentaje 
	from venMovimientos
	inner join conAsientos on conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genCancMov on genCancMov.Asiento_Id_ap = conAsientos.conAsientos 
	inner join venMovimientos venMovimientosAP on venMovimientosAP.venMovimientos = genCancMov.Asiento_Id
	inner join conAsientos conAsientosFC on conAsientosFC.conAsientos = venMovimientosAP.venMovimientos
	inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = conAsientosFC.conAsientos
	inner join venVendedores on venMovimientosAP.Vendedor_Id = venVendedores.venVendedores
	inner join venSubTipoMov on venMovimientosAP.venSubTipoMov_Id = venSubTipoMov.venSubTipoMov
	INNER JOIN venClientes ON venMovimientosAP.Cliente_Id = venClientes.genEntidades
	where venMovimientos.venTipoMov = 'C' AND
	venSubTipoMov.AfectaComVenta = 1 and
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and conAsientos.Empresa_Id=@Empresa_Id AND
	venMovimientosAP.Importe != 0 and conAsientos.Posteado = 1 and conAsientos.Anulado = 0)
	A GROUP BY A.Vendedor_Id, A.Nombre, A.Asiento, A.RazonSocial, A.Fecha, A.Porcentaje
	ORDER BY 1,5
	END



GO


