-- INF_StockxUbicacion ' ','zzz',' ','zzz',1
Drop Procedure INF_StockxUbicacion
GO
CREATE Procedure INF_StockxUbicacion
(
	@DepositoDesde VarChar(5),
	@DepositoHasta VarChar(5),
    @UbicacionDesde VarChar(25),
	@UbicacionHasta VarChar(25), 
	@Empresa int
)

AS
SELECT stkProductos.Producto_id, stkProductos.Descripcion, 
	stkDepositos.Deposito_id, stkDepositos.Descripcion as DescripcionDeposito,
	SUM(stkExistenciaUbiSerie.Cantidad) as Cantidad, stkUbicaciones.Ubicacion_Id, 
	stkExistenciaUbiSerie.Serie
From stkProductos 
inner join stkExistenciaSerie ON stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
inner join stkDepositos ON stkDepositos.stkDepositos = stkExistenciaSerie.Deposito_Id
inner join stkExistenciaUbiSerie on stkExistenciaSerie.Producto_Id = stkExistenciaUbiSerie.Producto_Id and stkExistenciaSerie.Deposito_Id=stkExistenciaUbiSerie.Deposito_Id AND
	stkExistenciaSerie.Empresa_Id = stkExistenciaUbiSerie.Empresa_Id AND stkExistenciaSerie.Serie = stkExistenciaUbiSerie.Serie
inner join stkUbicaciones on stkExistenciaUbiSerie.Ubicacion_Id = stkUbicaciones.stkUbicaciones
WHERE
stkDepositos.Deposito_id between @DepositoDesde and @DepositoHasta AND 
stkExistenciaUbiSerie.Cantidad <> 0 and 
stkExistenciaUbiSerie.Empresa_id = @Empresa and
stkUbicaciones.Ubicacion_Id BETWEEN @UbicacionDesde and @UbicacionHasta
GROUP BY stkProductos.Producto_id, stkProductos.Descripcion, 
stkDepositos.Deposito_id, stkDepositos.Descripcion,stkUbicaciones.Ubicacion_Id, 
stkExistenciaUbiSerie.Serie
UNION ALL
SELECT stkProductos.Producto_id, stkProductos.Descripcion, 
	stkDepositos.Deposito_id, stkDepositos.Descripcion as DescripcionDeposito,
	SUM(stkExistenciaUbi.Cantidad) as Cantidad, stkUbicaciones.Ubicacion_Id, ' ' Serie
From stkProductos 
inner join stkExistencia ON stkProductos.stkProductos = stkExistencia.Producto_Id
inner join stkDepositos ON stkDepositos.stkDepositos = stkExistencia.Deposito_Id
inner join stkExistenciaUbi on stkExistencia.Producto_Id=stkExistenciaUbi.Producto_Id and stkExistencia.Deposito_Id=stkExistenciaUbi.Deposito_Id
inner join stkUbicaciones on stkExistenciaUbi.Ubicacion_Id=stkUbicaciones.stkUbicaciones
WHERE
stkDepositos.Deposito_id between @DepositoDesde and @DepositoHasta AND 
stkExistencia.Cantidad <> 0 and 
stkExistencia.Empresa_id = @Empresa and
stkUbicaciones.Ubicacion_Id BETWEEN @UbicacionDesde and @UbicacionHasta
GROUP BY stkProductos.Producto_id, stkProductos.Descripcion, 
stkDepositos.Deposito_id, stkDepositos.Descripcion ,stkUbicaciones.Ubicacion_Id
union all
SELECT stkProductos.Producto_id, stkProductos.Descripcion, 
	stkDepositos.Deposito_id, stkDepositos.Descripcion as DescripcionDeposito,
	SUM(stkExistencia.Cantidad) as Cantidad, stkUbicaciones.Ubicacion_Id, ' ' Serie
From stkProductos 
inner join stkExistencia ON stkProductos.stkProductos = stkExistencia.Producto_Id
inner join stkDepositos ON stkDepositos.stkDepositos = stkExistencia.Deposito_Id
inner join stkUbiAlmacenDefecto ON  stkUbiAlmacenDefecto.Producto_Id = stkProductos.stkProductos and 
	stkUbiAlmacenDefecto.Deposito_Id = stkDepositos.stkDepositos
inner join stkUbicaciones on stkUbiAlmacenDefecto.Ubicacion_Id=stkUbicaciones.stkUbicaciones
WHERE
stkDepositos.Deposito_id between @DepositoDesde and @DepositoHasta AND 
stkExistencia.Cantidad <> 0 and 
stkExistencia.Empresa_id = @Empresa and
stkUbicaciones.Ubicacion_Id BETWEEN @UbicacionDesde and @UbicacionHasta
GROUP BY stkProductos.Producto_id, stkProductos.Descripcion, 
stkDepositos.Deposito_id, stkDepositos.Descripcion ,stkUbicaciones.Ubicacion_Id
ORDER BY 3,1

GO

