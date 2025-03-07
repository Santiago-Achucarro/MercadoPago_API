-- exec stkConsKardex '06607',' ','ZZZZZZZZZZZZZZZ','20200101' , '20200630',1,1
DROP Procedure stkConsKardex
GO
Create Procedure stkConsKardex(
	@Producto_Id VarChar(25),
	@DepositoDesde VarChar(15),
	@DepositoHasta VarChar(15),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@IncluCanc Bit,
	@Empresa_Id Int)
as

select stkProductos.Producto_Id, stkProductos.Descripcion, 
		@DepositoDesde  DepositoDesde, @DepositoHasta  DepositoHasta, 
		@FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
		@IncluCanc as IncluCanc
from stkProductos 
Where
	stkProductos.Producto_Id = @Producto_Id




SELECT conAsientos.Fecha, conAsientos.FechaRegistro, conAsientos.conAsientos,
	stkInvenSegmentos.stkInventarios, 
	case when stkInvenSegmentos.stkInventarios IS NOT NULL THEN
		'frmstkInventario'
		
		when stkMoviCabe.SubTipoMov_Id = 'CDE' 
			THEN 'frmstkEntradasCD' 
			
		when stkMoviCabe.SubTipoMov_Id = 'ECO' or stkMoviCabe.SubTipoMov_Id = 'SCO'
			THEN 'Interface' 
		ELSE
		disFormularios.Formulario_Id end Formulario_Id,
	CASE WHEN venMovimientos.venMovimientos IS NOT NULL THEN 
			dbo.Segmento(Factura.Segmento_Id, Factura.Segmento1C, Factura.Segmento2C, 
		Factura.Segmento3C, Factura.Segmento4C,  Factura.Segmento1N, Factura.Segmento2N, Factura.Segmento3N, Factura.Segmento4N) 
		when stkInvenSegmentos.stkInventarios IS NOT NULL THEN
			dbo.Segmento(stkInvenSegmentos.Segmento_Id, stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, 
		stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C, 
		stkInvenSegmentos.Segmento1N, stkInvenSegmentos.Segmento2N, 
		stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N) 
		ELSE		
		dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) END AS Comprobante, 
		ISNULL(ISNULL(Isnull(Isnull(isnull(venClientes.Cliente_Id, comProveedores.Proveed_Id),stkDepositosO.Deposito_Id), stkDepositosS.Deposito_Id),venClientesR.Cliente_Id), ' ') as Codigo , 
		ISNULL(ISNULL(Isnull(Isnull(Isnull(venClientes.RazonSocial, comProveedores.RazonSocial),stkDepositosO.Descripcion), stkDepositosS.Descripcion),venClientesR.RazonSocial), ' ') as Descripcion, 
		CASE WHEN venMovimientos.venMovimientos IS NOT NULL THEN 
			dbo.Segmento(Factura.Segmento_Id, Factura.Segmento1C, Factura.Segmento2C, 
			Factura.Segmento3C, Factura.Segmento4C,  Factura.Segmento1N, Factura.Segmento2N, Factura.Segmento3N, Factura.Segmento4N) 
		when comOCSegmentos.comOrdenComp IS NOT NULL THEN 
				dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, 
				comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,  comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, 
				comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) 
				ELSE ' ' END AS Comprobante2,
		case  
		when stkMoviCabe.SubTipoMov_Id = 'ECO' or stkMoviCabe.SubTipoMov_Id = 'SCO'
			THEN stkSubTipoMov.Descripcion
		ELSE
		disFormularios.Descripcion END as Formulario, 
		CASE WHEN stkMoviCabe.Signo = 1 THEN isnull(venMovStkHist.Cantidad, stkMoviCuerpo.Cantidad) else 0 end as Entradas, 
		CASE WHEN stkMoviCabe.Signo = -1 THEN isnull(venMovStkHist.Cantidad, stkMoviCuerpo.Cantidad) else 0 end as Salidas, 
		stkMoviCuerpo.CostoUnitario , 
		CONVERT(numeric(18,2) , stkMoviCuerpo.Cantidad *stkMoviCuerpo.CostoUnitario *stkMoviCabe.Signo) as Total,
		CONVERT(numeric(18,4) , isnull( conasientosf.Cambio * venMovConStockCr.PrecioVenta,0)) as PrecioVenta,
		stkMoviCuerpo.CostoUnitario*0 as SaldoCant,
		stkMoviCuerpo.CostoUnitario*0 as AcumEntradas,
		stkMoviCuerpo.CostoUnitario*0 as AcumSalidas,
		stkMoviCuerpo.CostoUnitario*0 as Saldo,
		case when conAsientos.Anulado=1 then 'Rojo' else '' end as Color, 
		stkDepositos.Deposito_Id
From conAsientos inner join stkMoviCabe ON 
conAsientos.conAsientos =stkMoviCabe.stkMoviCabe
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos 
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN stkSubTipoMov ON  stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
INNER JOIN stkMoviCuerpo ON  stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
INNER JOIN stkDepositos ON  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
left join (venMovStkHist inner join venMovimientos ON 
		venMovStkHist.venMovimientos = venMovimientos.venMovimientos 
		inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN genAsiSegmentos AS Factura ON Factura.Asiento_Id = venMovimientos.venMovimientos
		inner join venMovConStockCr ON venMovConStockCr.venMovimientos = venMovStkHist.venMovimientos and
			venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
			venMovStkHist.FacturaRemito != 'F' 
		INNER JOIN conAsientos as conasientosf on conasientosf.conAsientos = venMovimientos.venMovimientos )
	ON venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
	   venMovStkHist.Renglon = stkMoviCuerpo.Renglon
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
left join (stkMoviProv 	inner join comProveedores ON comProveedores.genEntidades = stkmoviprov.Proveed_Id
	) ON stkMoviProv.stkMoviCabe = stkMoviCabe.stkMoviCabe 
left join (stkMoviOC inner join comOCSegmentos ON  stkMoviOC.comOrdenComp = comOCSegmentos.comOrdenComp) ON
	stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND
	stkMoviOC.Renglon = stkMoviCuerpo.Renglon
Left join (stkEnTransito INNER JOIN stkDepositos stkDepositosO ON 
	stkEnTransito.Deposito_Id = stkDepositosO.stkDepositos ) ON 
	stkEnTransito.stkMoviCabe = stkMoviCabe.stkMoviCabe 
Left join (stkEnTransito stkEnTransitoS INNER JOIN stkDepositos stkDepositosS ON 
	stkEnTransitoS.Deposito_Id = stkDepositosS.stkDepositos ) ON 
	stkEnTransito.stkMoviCabeEntr = stkMoviCabe.stkMoviCabe 
left join (stkRemitos  INNER JOIN venClientes venClientesR ON stkRemitos.Cliente_Id = venClientesR.genEntidades) ON 
	stkRemitos.stkMoviCabe = stkMoviCabe.stkMoviCabe
Left join (stkInvMoviStk INNER JOIN stkInvenSegmentos ON stkInvMoviStk.stkInventarios = stkInvenSegmentos.stkInventarios) on
		stkInvMoviStk.stkMoviCabe = stkMoviCabe.stkMoviCabe
WHERE
	(@IncluCanc=1 or conAsientos.Anulado = 0) and 
	conAsientos.Empresa_Id = @Empresa_Id and
	conAsientos.Posteado = 1 and
	stkProductos.Producto_Id = @Producto_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and
	stkDepositos.Deposito_Id Between @DepositoDesde and @DepositoHasta
UNION ALL
SELECT Dateadd(dd,-1, @FechaDesde) as Fecha, Dateadd(dd,-1, @FechaDesde) as Fecha, 0 as conAsientos,
	0 as stkInventarios, ' ' Formulario_Id, 'Saldo Inicial'  as Comprobante,
	' ' as Deposito_Id,  ' ' as Codigo,' ' as Comprobante2, ' ' Formulario, 
	SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) as Entradas, 0 as Salidas, 
	Case when SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) != 0 then
	SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo* stkMoviCuerpo.CostoUnitario)/
		SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) end 	as Costo, 
	SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo * stkMoviCuerpo.CostoUnitario) as Total, 
	0 as PrecioVenta,
	0 as SaldoCant,
	0 as AcumEntradas,
	0 as AcumSalidas,
	0 as Saldo,
	'' as Color, ''
From stkMoviCabe 
	INNER JOIN conAsientos ON stkMoviCabe.stkMoviCabe= conAsientos.conAsientos
	INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe= stkMoviCuerpo.stkMoviCabe
	INNER JOIN stkProductos ON  stkProductos.stkProductos =stkMoviCuerpo.Producto_Id
	INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and
	stkProductos.Producto_Id = @Producto_Id and 
	conAsientos.Fecha <= @FechaDesde and
	stkDepositos.Deposito_Id Between @DepositoDesde and @DepositoHasta
	HAVING SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) <> 0
order by 1,2,3



