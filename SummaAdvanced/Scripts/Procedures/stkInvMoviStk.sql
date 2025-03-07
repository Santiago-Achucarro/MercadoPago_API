drop procedure stkInvMoviStkInsertar
go
create procedure stkInvMoviStkInsertar
(
@pstkMoviCabe bigint,
@pstkInventarios int
)
as
set nocount on
insert into stkInvMoviStk
(
stkMoviCabe,
stkInventarios
)
values
(
@pstkMoviCabe,
@pstkInventarios
)
go

drop procedure stkInvMoviStkDatos
go
create procedure stkInvMoviStkDatos
(
	@pEmpresa_Id int =null
)
AS

select 1 as Algo

select stkInventarios.stkInventarios,FechaInventario,genUsuarios.Apellido_y_Nombres as UsuRespo_Id, 'P' as Estado,
dbo.Segmento(stkInvenSegmentos.Segmento_Id,stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C,
stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C,
stkInvenSegmentos.Segmento1N,stkInvenSegmentos.Segmento2N,
stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N) as SegmentoStr, 
stkInvenSegmentos.Empresa_Id,genSegmentos.Segmento_Id,stkInvenSegmentos.Segmento1N,stkInvenSegmentos.Segmento2N,
stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N, stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C,
stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C, 
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDesposito
from stkInventarios
inner join genUsuarios on UsuRespo_Id=genUsuarios.genUsuarios
inner join stkInvenSegmentos on stkInvenSegmentos.stkInventarios=stkInventarios.stkInventarios 
inner join genSegmentos on stkInvenSegmentos.Segmento_Id=genSegmentos.genSegmentos 
inner join stkDepositos ON stkDepositos.stkDepositos = stkInventarios.Deposito_Id
where 
UsuarioAutorizo is null and stkInventarios.Posteado=1 and stkInvenSegmentos.Empresa_Id=isnull(@pEmpresa_Id, stkInvenSegmentos.Empresa_Id)
go

-- stkAFecha 1
DROP PROCEDURE stkAFecha
GO
CREATE PROCEDURE stkAFecha (
	@pstkInventrios int
)

AS

SELECT stkInventarios.stkInventarios, stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_Id, 
	stkInventCuerpo.Cantidad,stkInventCuerpo.CantidadAlterna, stkProductos.ClaseAlterna, stkProductos.UsaDespachoImportacion,
	stkProductos.Serializable, stkProductos.TrabajaPorLotes, stkProductos.conVencimiento,
	isnull(SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo),0) as CantidadStk ,
	isnull(SUM(stkMoviCuerpo.CantidadAlternaForm* stkMoviCabe.Signo),0) as CantidadAternaStk
	
FROM stkInventarios
inner join stkInventCuerpo on stkInventCuerpo.stkInventarios=stkInventarios.stkInventarios
inner join stkInvenSegmentos on stkInvenSegmentos.stkInventarios=stkInventarios.stkInventarios
left join ( stkMoviCabe INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN conAsientos ON
		conAsientos.conAsientos =stkMoviCabe.stkMoviCabe And
		conAsientos.Anulado = 0 And 
		conAsientos.Posteado = 1 
	) ON
	conAsientos.Empresa_Id = stkInvenSegmentos.Empresa_Id and 
	stkMoviCuerpo.Producto_Id  =stkInventCuerpo.Producto_Id and 
	stkMoviCuerpo.Deposito_Id = stkInventarios.Deposito_Id
	And conAsientos.Fecha <= stkInventarios.FechaInventario
	and conAsientos.Empresa_Id = stkInvenSegmentos.Empresa_Id
INNER JOIN stkProductos ON stkProductos.stkProductos = stkInventCuerpo.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	
WHERE
stkInventarios.stkInventarios = @pstkInventrios and stkProductos.Clase IN ('E','-') 
		
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, stkProductos.stkProductos, 
	stkUniMed.Medida_id, stkInventCuerpo.Cantidad,stkInventCuerpo.CantidadAlterna,
	stkProductos.ClaseAlterna,stkInventarios.stkInventarios, 
	stkProductos.UsaDespachoImportacion, stkProductos.Serializable, stkProductos.TrabajaPorLotes, stkProductos.conVencimiento
ORDER BY 1

Select stkProductos.Producto_Id, stkInventDespacho.Despacho_Id, stkInventDespacho.Cantidad
From stkInventarios
Inner Join stkInventCuerpo On stkInventCuerpo.stkInventarios = stkInventarios.stkInventarios
Inner Join stkProductos On stkProductos.stkProductos = stkInventCuerpo.Producto_Id
Inner Join stkInventDespacho On stkInventDespacho.stkInventarios = stkInventarios.stkInventarios
WHERE
stkInventarios.stkInventarios = @pstkInventrios And stkProductos.Clase In ('E','-') 


Select stkProductos.Producto_Id, stkMoviSerie.Serie, Sum(stkMoviSerie.Cantidad * stkMoviCabe.Signo) Cantidad
From stkInventarios
Inner Join stkInventCuerpo On stkInventCuerpo.stkInventarios = stkInventarios.stkInventarios
Inner Join stkProductos On stkProductos.stkProductos = stkInventCuerpo.Producto_Id
Inner Join stkInvenSegmentos on stkInvenSegmentos.stkInventarios=stkInventarios.stkInventarios
Left Join (stkMoviCabe Inner Join stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	Inner Join conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe And
		conAsientos.Anulado = 0 And 
		conAsientos.Posteado = 1
	Inner Join stkMoviSerie On stkMoviSerie.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And
		stkMoviSerie.Renglon = stkMoviCuerpo.Renglon
	) ON
	conAsientos.Empresa_Id = stkInvenSegmentos.Empresa_Id And 
	stkMoviCuerpo.Producto_Id  =stkInventCuerpo.Producto_Id And 
	stkMoviCuerpo.Deposito_Id = stkInventarios.Deposito_Id And
	conAsientos.Fecha <= stkInventarios.FechaInventario And
	conAsientos.Empresa_Id = stkInvenSegmentos.Empresa_Id
WHERE
stkInventarios.stkInventarios = @pstkInventrios And stkProductos.Clase In ('E','-') 
Group by stkProductos.Producto_Id, stkMoviSerie.Serie

go
