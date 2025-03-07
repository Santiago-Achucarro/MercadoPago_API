-- INF_stkAFecha '20230414','100-02-01 ','100-02-01',' ','ZZZ',' ','ZZZ',' ','ZZZ',1,'N'

DROP PROCEDURE INF_stkAFecha 
GO
CREATE PROCEDURE INF_stkAFecha (
	@FechaHasta DateTime,
	@DepositoDesde VarChar(15),
	@DepositoHasta VarChar(15),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id int, 
	@Resumen Char(1)
)

AS

-- Resumen N sin resumir, F Familia G = Grupo

SELECT stkProductos.Producto_id, stkProductos.Descripcion, stkUniMed.Medida_Id, 
	stkProductos.CostoUltCompra as CostoProd, 
	ISNULL(stkFamilias.Familia_Id,' ') AS Familia_Id, 
	ISNULL(stkFamilias.Descripcion,' ') as DescripcionFamilia, 
	ISNULL(stkGrupos.Grupo_Id,' ') as Grupo_Id, 
	ISNULL(stkGrupos.Descripcion,' ') as DescripcionGrupo, 
	SUM(case when stkDepositos.Deposito_Id BETWEEN @DepositoDesde and @DepositoHasta 
	then stkMoviCuerpo.Cantidad* stkMoviCabe.Signo else 0 end ) as Cantidad, 
	SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) as CantidadTodos, 
	SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo* stkMoviCuerpo.CostoUnitario) + 
	ISNULL((SELECT  SUM(stkMoviCuerpoReva.ImporteAjuste)--+stkMoviCuerpoReva.ImporteAjusteCosto) 
		FROM stkMoviCuerpoReva INNER JOIN stkMoviCabe ON
			 stkMoviCuerpoReva.stkMoviCabe = stkMoviCabe.stkMoviCabe and
			 stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos
			 INNER JOIN conAsientos ON
			 conAsientos.conAsientos =stkMoviCabe.stkMoviCabe 
			 WHERE
			 conasientos.Anulado = 0 and 
			 conasientos.Posteado = 1 and 
			 conAsientos.Empresa_Id = @Empresa_Id and 
			 conAsientos.Fecha <= @FechaHasta),0) as CostoTodos
	INTO #COSTOS1
	/* Para averiguar el costo sumo t resto de todos los almacenes */
FROM
	stkMoviCabe INNER JOIN stkMoviCuerpo ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN conAsientos ON
	conAsientos.conAsientos =stkMoviCabe.stkMoviCabe 
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER Join stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
	WHERE
		conAsientos.Anulado = 0 and 
		stkProductos.Clase IN ('E','-') and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		conAsientos.Fecha <= @FechaHasta and 
		ISNULL(stkFamilias.Familia_id,' ') between @FamiliaDesde and @FamiliaHasta and 
		ISNULL(stkGrupos.Grupo_Id,' ') between @GrupoDesde and @GrupoHasta and 
		stkProductos.Producto_Id BETWEEN @ProductoDesde AND @ProductoHasta
	GROUP BY stkProductos.Producto_id, stkProductos.Descripcion, stkProductos.stkProductos, 
		stkUniMed.Medida_id, stkProductos.CostoUltCompra,
		stkFamilias.Familia_Id,stkFamilias.Descripcion , 
		stkGrupos.Grupo_Id,stkGrupos.Descripcion

if @Resumen = 'F'
BEGIN
SELECT Familia_Id, DescripcionFamilia, SUM(Cantidad) Cantidad, 
		sum(cONVERT(Numeric(18,2),Case when CantidadTodos=0 then CostoProd else 
		CostoTodos/CantidadTodos end * Cantidad)) as SubTotal
FROM #COSTOS1
Where 		Cantidad <> 0 
GROUP BY Familia_Id, DescripcionFamilia
ORDER BY 1


END
ELSE
IF @Resumen = 'G'
BEGIN
SELECT Familia_Id, DescripcionFamilia, 
	Grupo_Id, DescripcionGrupo,
		SUM(Cantidad) Cantidad, 
		sum(cONVERT(Numeric(18,2),Case when CantidadTodos=0 then CostoProd else 
		CostoTodos/CantidadTodos end * Cantidad)) as SubTotal
FROM #COSTOS1
Where 		Cantidad <> 0 
GROUP BY Familia_Id, DescripcionFamilia, Grupo_Id, DescripcionGrupo
ORDER BY 1
END
ELSE
BEGIN
SELECT Producto_Id, Descripcion, Cantidad,  Medida_Id, 
	Familia_Id, DescripcionFamilia, Grupo_Id, DescripcionGrupo,
	Case when CantidadTodos=0 then CostoProd else 
		CostoTodos/CantidadTodos end as Costo, 
		cONVERT(Numeric(18,2),Case when CantidadTodos=0 then CostoProd else 
		CostoTodos/CantidadTodos end * Cantidad) as SubTotal
FROM #COSTOS1
Where 		Cantidad <> 0 
ORDER BY 1


END
go
