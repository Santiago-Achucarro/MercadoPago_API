
DROP Procedure   stkDevolucionesClieDatos 
go
create procedure stkDevolucionesClieDatos 
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pSegmento_IdSal VarChar(10), 
@pSegmento1NSal int,
@pSegmento2NSal int,
@pSegmento3NSal int,
@pSegmento4NSal int,
@pSegmento1CSal VarChar(20),
@pSegmento2CSal VarChar(20),
@pSegmento3CSal VarChar(20),
@pSegmento4CSal VarChar(20)

)
AS
Declare @pstkMoviCabe bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_IdSal) and 
	genAsiSegmentos.Segmento1N = @pSegmento1NSal and 
	genAsiSegmentos.Segmento2N = @pSegmento2NSal and 
	genAsiSegmentos.Segmento3N = @pSegmento3NSal and 
	genAsiSegmentos.Segmento4N = @pSegmento4NSal and 
	genAsiSegmentos.Segmento1C = @pSegmento1CSal and 
	genAsiSegmentos.Segmento2C = @pSegmento2CSal and 
	genAsiSegmentos.Segmento3C = @pSegmento3CSal and 
	genAsiSegmentos.Segmento4C = @pSegmento4CSal )

	Declare @pvenMovimientos bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )


select genSegmentos.Segmento_Id ,genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion as DescripcionCausa,
	conCentro1.Centro1_Id,conCentro2.Centro2_Id,'' as Deposito,stkDevolucionesClie.stkMoviCabe, 
	conAsientos.Anulado, stkSubTipoMov.TipoMov
	from genAsiSegmentos
	inner join	genSegmentos on  genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
	inner join stkDevolucionesClie on  stkDevolucionesClie.stkMoviCabe=genAsiSegmentos.Asiento_Id
	inner join stkMoviCausa on stkMoviCausa.stkMoviCabe = stkDevolucionesClie.stkMoviCabe
	INNER JOIN stkCausasMovi ON stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
	LEFT JOIN conCentro1 ON conCentro1.conCentro1 = stkMoviCausa.Centro1_Id
	LEFT JOIN conCentro2 ON conCentro2.conCentro2 = stkMoviCausa.Centro2_Id
	inner join stkMoviCabe ON stkMoviCabe.stkMoviCabe = stkDevolucionesClie.stkMoviCabe
	INNER JOIN stkSubTipoMov ON  stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
	inner join conAsientos ON conAsientos.conAsientos = stkDevolucionesClie.stkMoviCabe
	where
	stkDevolucionesClie.stkMoviCabe=@pstkMoviCabe

if @pstkMoviCabe is not null
	Begin
		


select venMovimientos.venMovimientos,genSegmentos.Segmento_Id ,genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C , conAsientos.Fecha, venClientes.Cliente_Id,venClientes.RazonSocial
	from genAsiSegmentos 
		inner join	genSegmentos on  genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
		inner join stkDevolucionesClie on  stkDevolucionesClie.venMovimientosFact=genAsiSegmentos.Asiento_Id 
		inner join conAsientos ON conAsientos.conAsientos = stkDevolucionesClie.venMovimientosFact
		inner join venMovimientos on venMovimientos.venMovimientos=stkDevolucionesClie.venMovimientosFact
		inner join venClientes on venClientes.genEntidades=venMovimientos.Cliente_Id
		WHERE
			stkDevolucionesClie.stkMoviCabe = @pstkMoviCabe
			

select venMovConStockCr.venMovimientos, venMovConStockCr.RenglonCuerpo,
stkProductos.Producto_Id,stkProductos.Descripcion,stkUniMed.Medida_Id,
venMovConStockCr.CantOriginal, ISNULL(SUM(stkMoviCuerpo.Cantidad),0)  as DevolucionesAnteriores ,
0.00 as Cantidad,venMovConStockCr.PrecioVenta,stkDepositos.Deposito_Id
from stkMoviCuerpo
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id

left Join stkDevolucionesClie on  
	stkMoviCuerpo.stkMoviCabe=stkDevolucionesClie.stkMoviCabe and
	stkMoviCuerpo.Renglon= stkDevolucionesClie.Renglon
left join venMovConStockCr  ON 
	venMovConStockCr.venMovimientos =stkDevolucionesClie.venMovimientosFact	
	inner join stkDepositos on stkDepositos.stkDepositos=venMovConStockCr.Deposito_Id
 where 
 stkMoviCuerpo.stkMoviCabe=@pstkMoviCabe
  
Group by venMovConStockCr.venMovimientos, 
venMovConStockCr.RenglonCuerpo,
stkProductos.Producto_Id,stkProductos.Descripcion,stkUniMed.Medida_Id,
venMovConStockCr.CantOriginal,venMovConStockCr.PrecioVenta,stkDepositos.Deposito_Id
end
else
begin

select venMovimientos.venMovimientos,genSegmentos.Segmento_Id ,genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C  , conAsientos.Fecha, venClientes.Cliente_Id,venClientes.RazonSocial
	from genAsiSegmentos inner join
		genSegmentos on  genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
		inner join venMovimientos on venMovimientos.venMovimientos=genAsiSegmentos.Asiento_Id
		inner join venClientes on venClientes.genEntidades=venMovimientos.Cliente_Id
		inner join conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
		WHERE
		venMovimientos.venMovimientos= @pvenMovimientos

		

select venMovConStockCr.venMovimientos, venMovConStockCr.RenglonCuerpo,
stkProductos.Producto_Id,stkProductos.Descripcion,stkUniMed.Medida_Id,
venMovConStockCr.CantOriginal, ISNULL(SUM(stkMoviCuerpo.Cantidad),0)  as DevolucionesAnteriores ,
0.00 as Cantidad,venMovConStockCr.PrecioVenta,stkDepositos.Deposito_Id
from venMovConStockCr
INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
left Join stkDevolucionesClie on  
	venMovConStockCr.venMovimientos=stkDevolucionesClie.venMovimientosFact
left join stkMoviCuerpo  ON 
	stkMoviCuerpo.stkMoviCabe =stkDevolucionesClie.stkMoviCabe and 
	stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
	inner join stkDepositos on stkDepositos.stkDepositos=venMovConStockCr.Deposito_Id
 where 
 venMovConStockCr.venMovimientos=@pvenMovimientos
  
Group by venMovConStockCr.venMovimientos, 
venMovConStockCr.RenglonCuerpo,
stkProductos.Producto_Id,stkProductos.Descripcion,stkUniMed.Medida_Id,
venMovConStockCr.CantOriginal,venMovConStockCr.PrecioVenta,stkDepositos.Deposito_Id



end
go

drop procedure stkDevolucionesClieGuardar 
go
create procedure stkDevolucionesClieGuardar 
(@pstkMoviCabe bigint ,
@pvenMovimientosFact bigint,
@pvenMovimientosNC bigint = null,
@pRenglon int,
@pRenglonCuerpo int,
@pRenglonNC int)
as

BEGIN 
INSERT INTO stkDevolucionesClie
(
stkMoviCabe,
venMovimientosFact,
venMovimientosNC,
Renglon,
RenglonCuerpo,
RenglonNC
)
values
(
@pstkMoviCabe,
@pvenMovimientosFact ,
@pvenMovimientosNC ,
@pRenglon,
@pRenglonCuerpo,
@pRenglonNC
)
end

go

drop procedure stkDevolucionesClieEliminar 
go
create procedure stkDevolucionesClieEliminar
(@pstkMoviCabe bigint )
as
delete from stkDevolucionesClie where stkMoviCabe=@pstkMoviCabe 

go
