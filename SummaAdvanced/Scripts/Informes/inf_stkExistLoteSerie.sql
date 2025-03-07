-- inf_stkExistLoteSerie ' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz',1
DROP PROCEDURE inf_stkExistLoteSerie
GO
CREATE PROCEDURE inf_stkExistLoteSerie
(

@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pDepositoDesde varchar(5),
@pDepositoHasta varchar(5),
@pLoteDesde varchar(25),
@pLoteHasta varchar(25),
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@Empresa_Id Int

)

as

SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepo, 
	stkExistenciaSerie.Serie, stkExistenciaSerie.Cantidad, 
	ISNULL(Convert(Char(10),stkSerieVencimiento.Vencimiento,103), ' ') as Vencimiento
	FROM stkProductos 
		INNER JOIN stkExistenciaSerie ON stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
		INNER JOIN stkDepositos ON stkDepositos.stkDepositos=stkExistenciaSerie.Deposito_Id
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id 
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
		LEFT JOIN stkSerieVencimiento ON stkSerieVencimiento.Empresa_Id = stkExistenciaSerie.Empresa_Id and 
			stkSerieVencimiento.Serie = stkExistenciaSerie.Serie and
			stkSerieVencimiento.Producto_Id = stkExistenciaSerie.Producto_Id
WHERE
	stkExistenciaSerie.Cantidad > 0 AND
	stkDepositos.Deposito_Id BETWEEN @pDepositoDesde and @pDepositoHasta  and 
	stkProductos.Producto_Id BETWEEN @pProductoDesde and @pProductoHasta and 
	stkExistenciaSerie.Serie BETWEEN @pLoteDesde and @pLoteHasta and 
	ISNULL(stkFamilias.Familia_Id, ' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id,' ') Between @pGrupoDesde and @pGrupoHasta and  
	stkExistenciaSerie.Empresa_Id = @Empresa_Id 
ORDER BY 1,3,5
GO

