-- exec QuePedimento '124NPT101','P',10,'20200811',1
-- este procedure lo uso para asignar el numero de pedimento en ajustes de inventarios
DROP PROCEDURE QuePedimento
GO
CREATE PROCEDURE QuePedimento(
@Producto_Id VarChar(25),
@Deposito_Id VarChar(5), 
@Cantidad Numeric(19,8), 
@Fecha DateTime,
@Empresa_Id Int
)
AS
DECLARE @FechaDesp DATETIME
DECLARE @Despacho_Id VarChar(20)
DECLARE @CantidadDespa Numeric(19,8)


CREATE TABLE #PEDIMENTOS (Despacho_Id VarChar(20), Cantidad Numeric(19,8))

DECLARE curDespachos CURSOR FOR
	SELECT comDespachos.Fecha, comDespachos.Despacho_Id, 
		Convert(Numeric(19,8), sum(stkMoviDespa.Cantidad * stkMoviCabe.Signo)) as Cantidad
	from stkMoviCabe 
	INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN stkMoviDespa  ON stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
								stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
	INNER JOIN stkProductos ON stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
	INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
	INNER JOIN comDespachos ON comDespachos.comDespachos = stkMoviDespa.Despacho_Id
	WHERE
	conAsientos.Anulado= 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha < @Fecha and 
	conAsientos.Empresa_Id = @Empresa_Id
	GROUP BY comDespachos.Fecha, comDespachos.Despacho_Id
	HAVING sum(stkMoviDespa.Cantidad * stkMoviCabe.Signo) < 0
	ORDER BY 1 DESC

OPEN curDespachos  
  
FETCH NEXT FROM curDespachos
INTO @FechaDesp, @Despacho_Id, @CantidadDespa

WHILE @@FETCH_STATUS = 0  and @Cantidad > 0
BEGIN 

	if (@CantidadDespa > @Cantidad)
		SET @CantidadDespa = @Cantidad

	if (@CantidadDespa > 0)
		insert into #PEDIMENTOS (Despacho_Id, Cantidad) VALUES(@Despacho_Id, @CantidadDespa)


	FETCH NEXT FROM curDespachos
	INTO @FechaDesp, @Despacho_Id, @CantidadDespa

END

IF @Cantidad > 0
	insert into #PEDIMENTOS (Despacho_Id, Cantidad) VALUES('1', @Cantidad)

CLOSE curDespachos
DEALLOCATE curDespachos

Select @Producto_Id as Producto_Id, @Deposito_Id as Deposito_Id, @Cantidad as Cantidad, @Fecha as Fecha
SELECT * FROM #PEDIMENTOS
DROP TABLE #PEDIMENTOS

GO



