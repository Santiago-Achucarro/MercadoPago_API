-- 23/05/2023 FM Traje el sp de Ariel que tenía corregido el caso PPP para Teadit y agregué el If de PUC --
-- AJ Filtro por Familia y Grupo
-- INF_stkAnamoviStock  1, '20221201','20221231', '10-GELATINA220','10-GELATINA220', ' ','ZZZZ', 1,' ',' ', 'ZZZ',' ','ZZZ'
-- FM 10/04/2020 Visto con Ariel. stkMoviCuerpoReva.ImporteAjuste es solo BC. stkMoviCuerpoReva.ImporteAjusteCosto se refiere al ajuste del costo --
drop PROCEDURE INF_stkAnamoviStock 
go
CREATE PROCEDURE INF_stkAnamoviStock (
	@Empresa_Id int, 
	@FechaDesde DateTime, 
	@FechaHasta  DateTime, 
	@ProductoDesde VarChar(25), 
	@ProductoHasta VarChar(25), 
	@DepositoDesde VarChar(15), 
	@DepositoHasta VarChar(15), 
	@ConSaldoIni bit, 
	@SubTipomov VarChar(5),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15)
)
AS

SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	 stkUniMed.Medida_Id, 
	conAsientos.Fecha, conAsientos.FechaRegistro, stkmovicabe.stkMoviCabe,
	stkDepositos.Deposito_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as SegmentoStr,
		stkSubTipoMov.SubTipoMov_Id,
		stkSubTipoMov.Descripcion  as DescripcionSubTipo	,
		CASE 
		WHEN  EmbSegmento.Asiento_Id IS NOT NULL THEN 
		dbo.Segmento(EmbSegmento.Segmento_Id, EmbSegmento.Segmento1C, 
		EmbSegmento.Segmento2C, EmbSegmento.Segmento3C,
		EmbSegmento.Segmento4C, EmbSegmento.Segmento1N,
		EmbSegmento.Segmento2N, EmbSegmento.Segmento3N,
		EmbSegmento.Segmento4N)
		WHEN comOCSegmentos.comOrdenComp IS NOT NULL THEN 
		dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, 
		comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C,
		comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N,
		comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N,
		comOCSegmentos.Segmento4N) 
		WHEN FactSegmento.Asiento_Id IS NOT NULL THEN
		dbo.Segmento(FactSegmento.Segmento_Id, FactSegmento.Segmento1C, 
		FactSegmento.Segmento2C, FactSegmento.Segmento3C,
		FactSegmento.Segmento4C, FactSegmento.Segmento1N,
		FactSegmento.Segmento2N, FactSegmento.Segmento3N,
		FactSegmento.Segmento4N) 
		When stkInvenSegmentos.stkInventarios IS NOT NULL THEN
		dbo.Segmento(stkInvenSegmentos.Segmento_Id, stkInvenSegmentos.Segmento1C, 
		stkInvenSegmentos.Segmento2C, stkInvenSegmentos.Segmento3C,
		stkInvenSegmentos.Segmento4C, stkInvenSegmentos.Segmento1N,
		stkInvenSegmentos.Segmento2N, stkInvenSegmentos.Segmento3N,
		stkInvenSegmentos.Segmento4N) 
		ELSE
		 ' ' END Detalle,
		 ISNULL(venClientes.Cliente_Id, ISNULL(PROVOC.Proveed_id, ISNULL(comProveedores.Proveed_Id, isnull(STR(suePersonal.Legajo,8),ISNULL(venClientesR.Cliente_Id,' '))))) as Entidad, 
		ISNULL(venClientes.RazonSocial, ISNULL(PROVOC.RazonSocial, ISNULL(comProveedores.RazonSocial, ISNULL(suePersonal.Nombres+','+suePersonal.ApellidoPaterno, isnull(venClientesR.RazonSocial, ' '))))) as RazonSocial,
		isnull(venClieHabitual.NombreFantasia, isnull(venClieHabitualR.NombreFantasia, ' ')) NombreFantasia,
		Convert(Numeric(18,4), case When stkMoviCabe.Signo = 1 THEN stkMoviCuerpo.Cantidad ELSE 0 END ) AS CantEntrada,
		Convert(Numeric(18,4),case When stkMoviCabe.Signo = 1 THEN stkMoviCuerpo.CostoUnitario ELSE 0 END)  AS CostoUEntrada,
		Convert(Numeric(18,2),round(case When stkMoviCabe.Signo = 1 THEN 	stkMoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario ELSE 0 END,2))  AS TotalEntrada,
		Convert(Numeric(18,4),case When stkMoviCabe.Signo = -1 THEN stkMoviCuerpo.Cantidad ELSE 0 END)  AS CantSalida,
		Convert(Numeric(18,4),case When stkMoviCabe.Signo = -1 THEN stkMoviCuerpo.CostoUnitario ELSE 0 END)  AS CostoUSalida,
		Convert(Numeric(18,2),round(case When stkMoviCabe.Signo = -1 THEN 	stkMoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario ELSE 0 END,2))  AS TotalSalida, 
		Convert(Numeric(18,4),0) Cantidad, Convert(Numeric(18,4),0) Costo,  Convert(Numeric(18,2),0) Total,
		genUsuarios.Usuario_Id,  ISNULL(stkMoviCuerpo.Observaciones+'-','') + conAsientos.Observaciones AS Observaciones, disFormularios.Descripcion as Formulario,
		conAsientos.conAsientos, stkMoviCuerpo.Renglon, 0 esRV
	into #temp1
from stkMoviCabe INNER JOIN conAsientos ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos =stkMoviCuerpo.Producto_Id
	INNER JOIN stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	inner join stkSubTipoMov ON
	stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
	LEFT JOIN (stkMoviEmbarque inner join genAsiSegmentos as EmbSegmento  ON
			stkMoviEmbarque.comEmbarques = EmbSegmento.Asiento_Id) ON
			stkMoviEmbarque.stkMoviCabe = stkMoviCabe.stkMoviCabe
	LEFT JOIN (stkMoviOC inner join comOCSegmentos ON
		stkMoviOC.comOrdenComp = comOCSegmentos.comOrdenComp
		INNER JOIN comOrdenComp ON
		comOrdenComp.comOrdenComp =stkMoviOC.comOrdenComp 
		inner join comProveedores AS PROVOC ON
		PROVOC.genEntidades = comOrdenComp.Proveed_Id) ON
		stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
		stkMoviOC.Renglon = stkMoviCuerpo.Renglon
	LEFT JOIN (venMovStkHist INNER JOIN genAsiSegmentos as FactSegmento ON
		venMovStkHist.venMovimientos =FactSegmento.Asiento_Id
		INNER JOIN venMovimientos ON
		venMovimientos.venMovimientos = venMovStkHist.venMovimientos 
		INNER JOIN venClientes ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
		iNNER JOIN venClieHabitual ON  venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
		venClieHabitual.Sucursal = venMovimientos.Sucursal
		INNER JOIn conAsientos conAsientosF ON conAsientosF.conAsientos = FactSegmento.Asiento_Id  and 
		conAsientosF.Anulado = 0 ) ON
		venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
		venMovStkHist.Renglon = stkMoviCuerpo.Renglon
	LEFT JOIN (stkMoviProv INNER JOIN comProveedores ON
		stkMoviProv.Proveed_Id = comProveedores.genEntidades) ON
		stkMoviProv.stkMoviCabe = stkMoviCabe.stkMoviCabe
	LEFT JOIN (stkInvenSegmentos INNER JOIN stkInvMoviStk ON 
		stkInvenSegmentos.stkInventarios = stkInvMoviStk.stkInventarios) ON 
			stkInvMoviStk.stkMoviCabe = stkMoviCabe.stkMoviCabe

	LEFT JOIN (stkRemitos INNER JOIN venClientes venClientesR ON 
		stkRemitos.Cliente_Id = venClientesR.genEntidades
		iNNER JOIN venClieHabitual venClieHabitualR ON  venClieHabitualR.genEntidades = stkRemitos.Cliente_Id and 
		venClieHabitualR.Sucursal = stkRemitos.Sucursal) ON 
			stkRemitos.stkMoviCabe = stkMoviCabe.stkMoviCabe
		
	INNER JOIN genUsuarios on genUsuarios.genUsuarios = conAsientos.Usuario_Id
	INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
	Left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	Left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	left join (stkMoviLega INNER JOIN suePersonal ON stkMoviLega.Legajo = suePersonal.genEntidades) ON
	stkMoviLega.stkMoviCabe = stkMoviCabe.stkMoviCabe
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta	and 
	stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta and 
	(stkMoviCabe.SubTipoMov_Id = @SubTipomov or @SubTipoMov=' ') and 
	ISNULL(stkFamilias.Familia_Id, ' ') between @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id, ' ') between @GrupoDesde and @GrupoHasta 
UNION ALL
SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	 stkUniMed.Medida_Id, 
	conAsientos.Fecha, conAsientos.FechaRegistro, stkmovicabe.stkMoviCabe,
	' ' Deposito_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as SegmentoStr,
		stkSubTipoMov.SubTipoMov_Id,
		stkSubTipoMov.Descripcion  ,
		CASE 
		WHEN  EmbSegmento.Asiento_Id IS NOT NULL THEN 
		dbo.Segmento(EmbSegmento.Segmento_Id, EmbSegmento.Segmento1C, 
		EmbSegmento.Segmento2C, EmbSegmento.Segmento3C,
		EmbSegmento.Segmento4C, EmbSegmento.Segmento1N,
		EmbSegmento.Segmento2N, EmbSegmento.Segmento3N,
		EmbSegmento.Segmento4N) else ' ' end  	Detalle, ' ' AS Entidad, ' ' as RazonSocial,
		' ' NombreFantasia,
		0 AS CantEntrada,
		Convert(Numeric(18,4),case When stkMoviCuerpoReva.ImporteAjuste > 0 
			THEN stkMoviCuerpoReva.ImporteAjuste ELSE 0 END ) AS CostoUEntrada,
		Convert(Numeric(18,2),case When stkMoviCuerpoReva.ImporteAjuste > 0 
			THEN round(stkMoviCuerpoReva.ImporteAjuste,2) ELSE 0 END )  AS TotalEntrada,
		0 AS CantSalida,
		case When stkMoviCuerpoReva.ImporteAjuste < 0 
			THEN -stkMoviCuerpoReva.ImporteAjuste ELSE 0 END   AS CostoUSalida,
		Convert(Numeric(18,2),case When stkMoviCuerpoReva.ImporteAjuste < 0 
			THEN round(-stkMoviCuerpoReva.ImporteAjuste,2) ELSE 0 END)  AS TotalSalida,
			Convert(Numeric(18,4),0) Cantidad, Convert(Numeric(18,4),0) Costo,  Convert(Numeric(18,2),0) Total,
		genUsuarios.Usuario_Id, conAsientos.Observaciones AS Observaciones, disFormularios.Descripcion as Formulario,
				conAsientos.conAsientos, stkMoviCuerpoReva.Renglon, 1 esRV
from stkMoviCabe INNER JOIN conAsientos ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN stkMoviCuerpoReva ON
	stkMoviCuerpoReva.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos =stkMoviCuerpoReva.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	inner join stkSubTipoMov ON
	stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
	LEFT JOIN (comEmbAsiCierre INNER JOIN genAsiSegmentos AS EmbSegmento ON
	 comEmbAsiCierre.comEmbarques = EmbSegmento.Asiento_Id) ON
	 comEmbAsiCierre.stkMoviCabe = stkMoviCabe.stkMoviCabe
	 inner join genSucursalesEmpr ON
	 genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	 left join stkDepositos ON
	 stkDepositos.stkDepositos = genSucursalesEmpr.DepositoVentas
	INNER JOIN genUsuarios on genUsuarios.genUsuarios = conAsientos.Usuario_Id
	INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
	Left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	Left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
Where
	stkMoviCuerpoReva.ImporteAjuste <> 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta	and 
	ISNULL(stkDepositos.Deposito_Id, ' ') between @DepositoDesde AND @DepositoHasta and 
	(stkMoviCabe.SubTipoMov_Id = @SubTipomov or @SubTipoMov=' ') and 
	ISNULL(stkFamilias.Familia_Id, ' ') between @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id, ' ') between @GrupoDesde and @GrupoHasta 
UNION ALL
SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	 stkUniMed.Medida_Id, 
	dateadd(dd,-1,@FechaDesde) as Fecha,  dateadd(dd,-1,@FechaDesde) FechaRegistro,  0,
	' ' Deposito_Id, 
	' ',
	' ' as SegmentoStr, 'Saldo_Inicial',
	' ' Detalle, ' ' AS Entidad, ' ' as RazonSocial, ' ' NombreFantasia,
		Convert(Numeric(18,4),SUM(stkMoviCuerpo.Cantidad*stkMoviCabe.Signo )) AS CantEntrada,
		Convert(Numeric(18,4),case when SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo ) = 0 then 0 else 
		(SUM(stkMoviCuerpo.Cantidad* stkMoviCuerpo.CostoUnitario * stkMoviCabe.Signo) +
		ISNULL((SELECT SUM(round(stkMoviCuerpoReva.ImporteAjuste,2))--+stkMoviCuerpoReva.ImporteAjusteCosto) 
			from stkMoviCuerpoReva inner join conAsientos conAsientosA on
			stkMoviCuerpoReva.stkmovicabe =conAsientosA.conasientos and
			stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos 
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = conAsientosA.Sucursal 
			left join stkDepositos stkDepositosA ON 
			stkDepositosA.stkDepositos = genSucursalesEmpr.DepositoVentas
			Where
			ISNULL(stkDepositosA.Deposito_Id, ' ') between @DepositoDesde AND @DepositoHasta and 
			conAsientosA.Anulado = 0 and conAsientosA.Empresa_Id = @Empresa_Id And conAsientosA.Fecha < @FechaDesde And
			conAsientosA.Posteado = 1),0))
		/SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo ) end)  AS CostoUEntrada,
		Convert(Numeric(18,2),SUM(round(stkMoviCuerpo.Cantidad* stkMoviCuerpo.CostoUnitario * stkMoviCabe.Signo,2))+
		ISNULL((SELECT SUM(round(stkMoviCuerpoReva.ImporteAjuste,2))--+stkMoviCuerpoReva.ImporteAjusteCosto) 
			from stkMoviCuerpoReva inner join conAsientos conAsientosA on
			stkMoviCuerpoReva.stkmovicabe =conAsientosA.conasientos and
			stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos 
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = conAsientosA.Sucursal 
			left join stkDepositos stkDepositosA ON 
			stkDepositosA.stkDepositos = genSucursalesEmpr.DepositoVentas
			Where
			ISNULL(stkDepositosA.Deposito_Id, ' ') between @DepositoDesde AND @DepositoHasta and 
			conAsientosA.Anulado = 0 and conAsientosA.Empresa_Id = @Empresa_Id And conAsientosA.Fecha < @FechaDesde And
			conAsientosA.Posteado = 1),0)) AS TotalEntrada,
		0 AS CantSalida,
		0 AS CostoUSalida,
		0 AS TotalSalida,
		Convert(Numeric(18,4),0) Cantidad, Convert(Numeric(18,4),0) Costo,  Convert(Numeric(18,2),0) Total,
		' ' Usuario_Id, ' ' Observaciones, ' ' Formulario,
		0 conAsientos, 0 Renglon, 0 esRV

from stkMoviCabe INNER JOIN conAsientos ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos =stkMoviCuerpo.Producto_Id
	INNER JOIN stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	Left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	Left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	
Where	
	@ConSaldoIni = 1 AND 
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa_Id and
	conAsientos.Fecha < @FechaDesde  and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta	and 
	stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta and 
	@SubTipoMov=' ' and 
	ISNULL(stkFamilias.Familia_Id, ' ') between @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id, ' ') between @GrupoDesde and @GrupoHasta 
	GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion,  stkUniMed.Medida_Id, 
	stkProductos.stkProductos
	HAVING Convert(Numeric(18,2),SUM(round(stkMoviCuerpo.Cantidad* stkMoviCuerpo.CostoUnitario * stkMoviCabe.Signo,2))+
		ISNULL((SELECT SUM(round(stkMoviCuerpoReva.ImporteAjuste,2))--+stkMoviCuerpoReva.ImporteAjusteCosto) 
			from stkMoviCuerpoReva inner join conAsientos conAsientosA on
			stkMoviCuerpoReva.stkmovicabe =conAsientosA.conasientos and
			stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos 
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = conAsientosA.Sucursal 
			left join stkDepositos stkDepositosA ON 
			stkDepositosA.stkDepositos = genSucursalesEmpr.DepositoVentas
			Where
			ISNULL(stkDepositosA.Deposito_Id, ' ') between @DepositoDesde AND @DepositoHasta and 
			conAsientosA.Anulado = 0 and conAsientosA.Empresa_Id = @Empresa_Id And conAsientosA.Fecha < @FechaDesde And
			conAsientosA.Posteado = 1),0)) <> 0
ORDER BY 1,4, 5, 6
OPTION (RECOMPILE)

DECLARE @Producto_Id VarChar(25)
DECLARE @ProductoAct VarChar(25)
DECLARE @CantEntrada Numeric(18,4)
DECLARE @CantSalida Numeric(18,4)
DECLARE @CostoUEntrada Numeric(18,4)
DECLARE @CostoUSalida Numeric(18,4)
DECLARE @Cantidad Numeric(18,4)
DECLARE @Total Numeric(18,4)
DECLARE @conAsientos bigint
DECLARE @Renglon int
DECLARE @Fecha DateTime
DECLARE @FechaRegistro DateTime
Declare @esRV int
Declare @lTipoCosto char(1)
DECLARE @SubTipomov1 VarChar(3)
DECLARE @TotalEntrada Numeric(18,2)
DECLARE @TotalSalida Numeric(18,2)

Select @lTipoCosto = TipoCosto From genEmpresas Where genEmpresas.genEmpresas = @Empresa_Id

DECLARE @IDX VARCHAR(15)  
SET @IDX = 'IDX'+ CONVERT(VARCHAR(10),CONVERT(INT,RAND()*100000))
DECLARE @SQL VARCHAR(MAX) 
SET @SQL = 'CREATE INDEX '+@IDX+' ON #Temp1 (conAsientos, Renglon, Producto_Id) '
exec sp_sqlexec @sql

DECLARE curStock CURSOR  FOR
select Producto_Id, Fecha, FechaRegistro, CantEntrada, CantSalida, CostoUEntrada, CostoUSalida, 
	conAsientos, Renglon, SubTipoMov_Id, TotalEntrada, TotalSalida, esRV
FROM #temp1
order by Producto_Id, Fecha, FechaRegistro

OPEN curStock

FETCH NEXT FROM curStock
INTO @Producto_Id, @Fecha, @FechaRegistro, @CantEntrada, @CantSalida, @CostoUEntrada, @CostoUSalida, 
	@conAsientos, @Renglon, @SubTipomov1, @TotalEntrada, @TotalSalida, @esRV
  
WHILE @@FETCH_STATUS = 0  
BEGIN  

set @ProductoAct = @Producto_Id
set @Cantidad = 0
set @Total = 0
WHILE @@FETCH_STATUS = 0  and @ProductoAct = @Producto_Id
BEGIN

	If @lTipoCosto = 'U'
	-- Si es ultima compra hago una excepcion con los RV para no acumular Cantidad --
	Begin
		If @esRV = 0
		Begin
			Set @Cantidad = @Cantidad + @CantEntrada - @CantSalida
			Set @Total = @Cantidad * (@CostoUEntrada + @CostoUSalida)
			Update #temp1 Set Cantidad = @Cantidad , Total = @Total, Costo = @CostoUEntrada + @CostoUSalida
				WHERE conAsientos = @conAsientos AND Renglon = @Renglon and Producto_Id = @Producto_Id
		End
		Else
		Begin
			Set @Total = @CostoUEntrada - @CostoUSalida
			Update #temp1 Set Cantidad = 0, Total = @Total, Costo = @CostoUEntrada - @CostoUSalida
				WHERE conAsientos = @conAsientos AND Renglon = @Renglon and Producto_Id = @Producto_Id
		End
	End
	Else
	Begin
		set @Cantidad = @Cantidad + @CantEntrada - @CantSalida
		set @Total = @Total +  @TotalEntrada - @TotalSalida 
	End

	update #temp1 set Cantidad = @Cantidad , Total = @Total, Costo = CASE WHEN @Cantidad != 0 THEN  @Total / @Cantidad ELSE 0 END
				WHERE conAsientos = @conAsientos AND Renglon = @Renglon and Producto_Id = @Producto_Id


	FETCH NEXT FROM curStock
	INTO @Producto_Id, @Fecha, @FechaRegistro, @CantEntrada, @CantSalida, @CostoUEntrada, @CostoUSalida, 
		@conAsientos, @Renglon, @SubTipomov1, @TotalEntrada, @TotalSalida, @esRV

end

end
CLOSE curStock
DEALLOCATE curStock

select * from #temp1 ORDER BY 1,4, 5, 6
GO



