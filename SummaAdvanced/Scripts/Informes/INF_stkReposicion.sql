-- INF_stkReposicion ' ','ZZZ',' ','ZZZZ', 1, '', 'zzzz', '', 'zzzzz'
DROP PROCEDURE INF_stkReposicion
GO
CREATE PROCEDURE INF_stkReposicion
(
	@DepositoDesde VarChar(5),
	@DepositoHasta VarChar(5),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa Int,
	@GrupoDesde varchar(15),
	@GrupoHasta varchar(15),
	@FamiliaDesde varchar(15),
	@FamiliaHasta varchar(15)
)
AS

SELECT stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepo, 
	stkProductos.Producto_Id, stkProductos.Descripcion AS DescripcionProducto, 
	ISNULL(stkExistencia.Cantidad,0) as Stock, stkMaxMin.Minimo, 
	stkMaxMin.Minimo - ISNULL(stkExistencia.Cantidad,0) as Faltante, IsNull(stkGrupos.Grupo_Id, '') Grupo_Id, 
	IsNull(stkGrupos.Descripcion, '') as DescripcionGrupo, IsNull(stkFamilias.Familia_Id, '') Familia_Id,
	IsNull(stkFamilias.Descripcion, '') as DescripcionFamilia
FROM stkProductos inner join stkMaxMin ON
stkProductos.stkProductos = stkMaxMin.Producto_Id and 
stkMaxMin.Empresa_Id = @Empresa
inner join stkDepositos ON
stkDepositos.stkDepositos = stkMaxMin.Deposito_Id
left join stkExistencia ON
stkExistencia.Producto_Id = stkProductos.stkProductos and
stkExistencia.Deposito_Id = stkDepositos.stkDepositos and 
stkExistencia.Empresa_Id = @Empresa
left join stkGrupos on stkGrupos.stkGrupos=stkProductos.Grupo_Id
left join stkFamilias on stkFamilias.stkFamilias=stkProductos.Familia_Id
WHERE
	ISNULL(stkProductos.Empresa_Id , @Empresa) = @Empresa and
	stkProductos.Producto_Id between @ProductoDesde And @ProductoHasta AND
	stkDepositos.Deposito_Id between @DepositoDesde And @DepositoHasta and 
	stkProductos.Inactivo = 0 and 
	stkProductos.Posteado = 1 AND 
	stkDepositos.Inactivo = 0 and 
	stkDepositos.Posteado = 1 and 
	stkMaxMin.Minimo > ISNULL(stkExistencia.Cantidad,0) and
	IsNull(stkGrupos.Grupo_Id, '') between @GrupoDesde and @GrupoHasta AND
	IsNull(stkFamilias.Familia_Id, '') between @FamiliaDesde and @FamiliaHasta

ORDER BY 1, 3