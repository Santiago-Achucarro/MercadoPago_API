Drop procedure stkExistenciasXDepositoXLote
go

Create procedure stkExistenciasXDepositoXLote
(
@pEmpresa_Id Int,
@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pDepositoDesde varchar(15),
@pDepositoHasta varchar(15),
@pLoteDesde varchar(15),
@pLoteHasta varchar(15),
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@pFecha DateTime
)
As
Select @pProductoDesde As ProductoDesde, @pProductoHasta As ProductoHasta, 
	@pDepositoDesde As DepositoDesde, @pDepositoHasta As DepositoHasta, 
	@pLoteDesde As LoteDesde, @pLoteHasta As LoteHasta, getdate() Fecha, 
	@pFamiliaDesde FamiliaDesde, @pFamiliaHasta FamiliaHasta, 
	@pGrupoDesde GrupoDesde, @pGrupoHasta GrupoHasta
	

Select Distinct stkDepositos.Deposito_Id
From stkMoviSerie
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Inner Join stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Left Join stkSerieVencimiento On stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
	stkSerieVencimiento.Serie = stkMoviSerie.Serie
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
Where conAsientos.Fecha <= @pFecha
And conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id
And stkProductos.Producto_Id Between @pProductoDesde And @pProductoHasta
And stkDepositos.Deposito_Id Between @pDepositoDesde And @pDepositoHasta
And stkMoviSerie.Serie Between @pLoteDesde And @pLoteHasta and 
ISNULL(stkFamilias.Familia_Id,' ') Between @pFamiliaDesde and @pFamiliaHasta and 
ISNULL(stkGrupos.Grupo_Id,' ') Between @pGrupoDesde and @pGrupoHasta
Group by stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Deposito_Id, stkMoviSerie.Serie, stkSerieVencimiento.Vencimiento
Having Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) <> 0


Select stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Deposito_Id, stkMoviSerie.Serie, stkSerieVencimiento.Vencimiento,
	Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) Cantidad
From stkMoviSerie
Inner Join stkMoviCuerpo On stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe And stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Inner Join stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Left Join stkSerieVencimiento On stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
	stkSerieVencimiento.Serie = stkMoviSerie.Serie
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
Where conAsientos.Fecha <= @pFecha
And conAsientos.Posteado = 1 And conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id
And stkProductos.Producto_Id Between @pProductoDesde And @pProductoHasta
And stkDepositos.Deposito_Id Between @pDepositoDesde And @pDepositoHasta
And stkMoviSerie.Serie Between @pLoteDesde And @pLoteHasta and 
ISNULL(stkFamilias.Familia_Id,' ') Between @pFamiliaDesde and @pFamiliaHasta and 
ISNULL(stkGrupos.Grupo_Id,' ') Between @pGrupoDesde and @pGrupoHasta
Group by stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Deposito_Id, stkMoviSerie.Serie, stkSerieVencimiento.Vencimiento
Having Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) <> 0

-- ojo al generar resultado debe quedar vacio
Select '' Producto_Id, '' Descripcion, '' Lote, getdate() Vencimiento, Cast(0 As Decimal) Total
Go

