-- INF_stkMaxMin ' ','ZZZ',' ','ZZZZZ', 1,' ','ZZZ',' ','ZZZ'

DROP PROCEDURE INF_stkMaxMin
GO
CREATE PROCEDURE INF_stkMaxMin
(
	@DepositoDesde VarChar(5),
	@DepositoHasta VarChar(5),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa Int,
	@FamiliaDesde varchar(15),
	@FamiliaHasta varchar(15),
	@GrupoDesde varchar(15),
	@GrupoHasta varchar(15)
)

as

SELECT stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepo,
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
		stkMaxMin.Minimo, stkMaxMin.Maximo
FROM stkMaxMin INNER JOIN stkDepositos ON
	stkMaxMin.Deposito_Id = stkDepositos.stkDepositos
		INNER JOIN stkProductos ON	stkMaxMin.Producto_Id = stkProductos.stkProductos
		left join stkFamilias on stkProductos.Familia_Id= stkFamilias.stkFamilias
		left join stkGrupos on stkProductos.Grupo_Id=stkGrupos.stkGrupos
	WHERE
		stkMaxMin.Empresa_Id = @Empresa and 
		stkProductos.Producto_Id between @ProductoDesde And @ProductoHasta and
		stkDepositos.Deposito_Id between @DepositoDesde And @DepositoHasta AND 
		isnull(stkFamilias.Familia_Id,'') between @FamiliaDesde and @FamiliaHasta and
		isnull(stkGrupos.Grupo_Id,'') between @GrupoDesde and @GrupoHasta and
		stkProductos.Inactivo = 0 and stkProductos.Posteado = 1 and 
		stkDepositos.Inactivo = 0 and stkDepositos.Posteado = 1 and 
		ISNULL(stkProductos.Empresa_Id,@Empresa) =  @Empresa and 
		ISNULL(stkDepositos.Empresa_Id,@Empresa) =  @Empresa 
ORDER BY 1, 3
GO