-- exec stkUltimaSalidaDespaDatos 'P3240193','03',1


Drop procedure stkUltimaSalidaDespaDatos
GO
create procedure stkUltimaSalidaDespaDatos(
	@pProducto_Id VarChar(25),
	@pDeposito_Id VarChar(15),
	@pEmpresa_Id INT)
AS

select TOP 1 stkMoviCabe.Signo , CASE WHEN stkDepositos.Deposito_Id = @pDeposito_Id THEN 0 ELSE 1 END EsDepo,
	conAsientos.FechaRegistro, comDespachos.Despacho_Id, stkProductos.Producto_Id , stkDepositos.Deposito_Id
from 
	stkMoviDespa 
		INNER JOIN comDespachos ON  comDespachos.comDespachos =stkMoviDespa.Despacho_Id
		inner join stkMoviCabe ON stkMoviCabe.stkMoviCabe =stkMoviDespa.stkMoviCabe
		inner join stkMoviCuerpo ON  stkMoviCuerpo.stkMoviCabe =stkMoviDespa.stkMoviCabe and 
				stkMoviCuerpo.Renglon =stkMoviDespa.Renglon
		inner join conAsientos ON conAsientos.conAsientos =stkMoviDespa.stkMoviCabe
		INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
		WHERE
			stkProductos.Producto_Id = @pProducto_Id and 
			conAsientos.Empresa_Id = @pEmpresa_Id and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 

ORDER BY 1,2,3 DESC