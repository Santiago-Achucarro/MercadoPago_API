-- stkProductosExistenciaaFecha 1, 'RCUK1005KG','20221129','20221208 16:03:49.540', '0001',138822,1,0
-- stkProductosExistenciaaFecha 1, 'RCUK1005KG','20221129','20221208 16:03:49.540', '0001',138822,1,1

drop PROCEDURE stkProductosExistenciaaFecha
go
CREATE PROCEDURE stkProductosExistenciaaFecha(
@Empresa_Id int, 
@Producto_id VarChar(25),
@Fecha DateTime, 
@FechaRegistro DateTime, 
@pSucursal VarChar(4)=NULL,
@pStkMoviCabe Bigint,
@pRenglon Int , 
@pRenglonReva Int
)

AS
-- si es costo por sucursal solo filtro los de la sucursal acutal
DECLARE @pSucursalI int = dbo.funcFkgenSucursalesEmpr(@pSucursal)
--PRINT @pSucursalI
SELECT  ISNULL( Sum(stkMoviCuerpo.Cantidad *stkMoviCabe.Signo),0) Cantidad, 
	ISNULL(	Sum(stkMoviCuerpo.Cantidad *stkMoviCabe.Signo* stkMoviCuerpo.CostoUnitario),0) +
		ISNULL((SELECT SUM(stkMoviCuerpoReva.ImporteAjuste) 
			From stkMoviCabe 
			INNER JOIN stkMoviCuerpoReva ON stkMoviCabe.stkMoviCabe = stkMoviCuerpoReva.stkMoviCabe
			INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			Where
				conAsientos.Anulado = 0 AND 	
				conAsientos.Posteado = 1 AND 
				stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos and 
				(conAsientos.Fecha < @Fecha or  
				(conAsientos.Fecha = @Fecha and  
				conAsientos.FechaRegistro < @FechaRegistro) OR
				(conAsientos.conAsientos = @pStkMoviCabe) and 
				stkMoviCuerpoReva.Renglon < @pRenglonReva) and 
				conAsientos.Empresa_Id = @Empresa_Id and 
				conAsientos.Sucursal = ISNULL(@pSucursalI,conAsientos.Sucursal)),0) as 	Costo
From stkMoviCuerpo 
INNER JOIN stkMoviCabe ON stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Where
	(conAsientos.Fecha < @Fecha or  
	(conAsientos.Fecha = @Fecha and  conAsientos.FechaRegistro < @FechaRegistro) or
	(conAsientos.Fecha = @Fecha and stkMoviCuerpo.stkMoviCabe = @pStkMoviCabe and stkMoviCuerpo.Renglon < @pRenglon) 
	 --OR
	 --(conAsientos.Fecha = @Fecha and  conAsientos.FechaRegistro = @FechaRegistro and 
	 --stkMoviCuerpo.stkMoviCabe < @pStkMoviCabe)
	 ) and 
	stkDepositos.Consignacion = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	stkProductos.Producto_Id = @Producto_id  and 
	conAsientos.Sucursal = ISNULL(@pSucursalI,conAsientos.Sucursal)
group by stkProductos.stkProductos


GO