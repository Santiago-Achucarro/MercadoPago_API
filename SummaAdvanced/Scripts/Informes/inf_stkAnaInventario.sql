-- EXEC inf_stkAnaInventario '20210801', '20210816',1,'','ZZZZ','','ZZZZ','','ZZZZ','','ZZZZZ'
DROP PROCEDURE inf_stkAnaInventario
GO
CREATE PROCEDURE inf_stkAnaInventario
(
	@FechaDesde Datetime, 
	@FechaHasta Datetime, 
	@Empresa_Id Int,
	@DepositoDesde varchar(25),
	@DepositoHasta varchar(25),
	@FamiliaDesde varchar(25),
	@FamiliaHasta varchar(25),
	@GrupoDesde varchar(25),
	@GrupoHasta varchar(25),
	@ProductoDesde varchar(25),
	@ProductoHasta varchar(25)
)
as
SELECT Producto_Id, Descripcion, SaldoInicial, SaldoInicialCosto, Entradas, EntradasVal, 
	Salidas, SalidasVal, Ajustes, SaldoInicial + Entradas - Salidas as SaldoFinal, 
	SaldoInicialCosto + EntradasVal - SalidasVal + Ajustes as SaldoFinalCosto

FROM 
(

Select stkproductos.Producto_Id, stkProductos.Descripcion, 
	ISNULL((SELECT SUM(stkMoviCabe.Signo* stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario)
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1  and

		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha < @FechaDesde and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0) +
	ISNULL((SELECT SUM(stkMoviCuerpoReva.ImporteAjuste)
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpoReva ON stkMoviCabe.stkMoviCabe = stkMoviCuerpoReva.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			
	WHERE
		stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha < @FechaDesde and
		@DepositoDesde=''),0) as SaldoInicialCosto, 

ISNULL((SELECT SUM(stkMoviCabe.Signo* stkMoviCuerpo.Cantidad )
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha < @FechaDesde and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0 ) SaldoInicial,

 ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario)
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCabe.Signo = 1 and 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha between @FechaDesde and @FechaHasta and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0)  EntradasVal,

		ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad )
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCabe.Signo = 1 and 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha between @FechaDesde and @FechaHasta and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0)  Entradas,

ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario)
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCabe.Signo = -1 and 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha between @FechaDesde and @FechaHasta and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0)  SalidasVal,
	ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad )
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			inner join stkDepositos on stkDepositos.stkDepositos=stkMoviCuerpo.Deposito_Id
	WHERE
		stkMoviCabe.Signo = -1 and 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha between @FechaDesde and @FechaHasta and
		stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta),0)  Salidas,
ISNULL((SELECT SUM(stkMoviCuerpoReva.ImporteAjuste)
		FROM stkMoviCabe 
			INNER JOIN stkMoviCuerpoReva ON stkMoviCabe.stkMoviCabe = stkMoviCuerpoReva.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
	WHERE
		stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos and 
		conAsientos.Anulado = 0 AND
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		conAsientos.Fecha between @FechaDesde and @FechaHasta and @DepositoDesde=''),0) Ajustes
from stkProductos 

			left join stkGrupos on stkGrupos.stkGrupos=stkProductos.Grupo_Id
			left join stkFamilias on stkFamilias.stkFamilias=stkProductos.Familia_Id
Where
	stkProductos.Clase IN ('E','-')  and
		stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and
		isnull(stkGrupos.Grupo_Id,'') between @GrupoDesde and @GrupoHasta and
		isnull(stkFamilias.Familia_Id,'') between @FamiliaDesde and @FamiliaHasta 
)AS XXX
	
WHERE
	(SaldoInicial <> 0 OR SaldoInicialCosto <> 0 OR
		Entradas <> 0 OR EntradasVal <> 0 OR 
		Salidas <> 0 OR SalidasVal <>0 OR 
		ajustes <> 0) 
ORDER BY 1