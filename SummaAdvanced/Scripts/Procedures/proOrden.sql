drop procedure proOrdenDatos
go
create procedure proOrdenDatos
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
as
declare @Orden int
set @Orden=(select proOrden from proOrdenSegmento where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N AND
Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and 
Segmento4C=@pSegmento3C and Segmento4C=@pSegmento4C and
Empresa_Id=@pEmpresa_Id
)
select proOrden.proOrden, genSegmentos.Segmento_Id, proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N,
proOrdenSegmento.Segmento1C, proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, proOrden.TamBatch, proRecetas.Receta_Id,
proRecetas.Descripcion as DescripcionReceta, proOrden.Observaciones, Cantidad, CantidadIngresada, FechaEmision, CantidadProgramada, FechaNecesidad, FechaProduccion, FechaFin,
CantidadTerminada, CierreAutomatico, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, Factor ,
	proOrden.Anulado, genUsuarios.Usuario_Id, proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion DescripcionCtroProd
from proOrden
inner join stkProductos on stkProductos=proOrden.Producto_Id
inner join proRecetas on proRecetas=proOrden.Receta_Id
inner join proOrdenSegmento on proOrdenSegmento.proOrden=proOrden.proOrden
inner join genSegmentos on genSegmentos.genSegmentos=proOrdenSegmento.Segmento_Id
left join stkUniMed on stkUniMed.stkUniMed=proOrden.Medida_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = proOrden.Usuario_Id
Left Join proCentroProductivo On proCentroProductivo.proCentroProductivo = proOrden.CtroProd_Id
where proOrden.proOrden=@Orden

select proOrden, Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, EntradaSalida, stkUniMed.Medida_Id,
stkUniMed.Descripcion as DescripcionMedida, Cantidad, PorcentajeCosto, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, TomaDepoT3 
From proOrdenProd
inner join stkProductos on stkProductos=proOrdenProd.Producto_Id
inner join stkUniMed on stkUniMed=proOrdenProd.Medida_Id
inner join stkDepositos on stkDepositos=proOrdenProd.Deposito_Id
where proOrdenProd.proOrden=@Orden

select proOrden, Renglon, proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecurso, Cantidad , 
	proRecursos.UsaSubRecurso
from proOrdenRecursos
inner join proRecursos on proRecursos= proOrdenRecursos.Recurso_Id
where proOrdenRecursos.proOrden=@Orden

select proOrden, Renglon, proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionTrabajo3, comProveedores.Proveed_Id, comProveedores.RazonSocial 
From proOrdenTrabajos3
inner join comProveedores on comProveedores.genEntidades=proOrdenTrabajos3.Proveed_Id
inner join proTrabajo3 on proTrabajo3.proTrabajo3=proOrdenTrabajos3.proTrabajo3
where proOrdenTrabajos3.proOrden=@Orden

select proOrden, Renglon, proSubRecursos.Recurso_Id, proSubRecursos.Descripcion as DescripcionRecurso, 
	Cantidad 
from proOrdenSubRecurso 
inner join proSubRecursos on proSubRecursos= proOrdenSubRecurso.SubRecurso_Id
where proOrdenSubRecurso.proOrden=@Orden

SELECT proOrdenProdSerie.proOrden, proOrdenProdSerie.Renglon, proOrdenProdSerie.Serie,proOrdenProdSerie.Cantidad,stkSerieVencimiento.Vencimiento,
	' ' AS Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia, Cast(0 As bit) Marcado
FROM proOrdenProdSerie 
INNER JOIN proOrdenProd  ON (proOrdenProd.proOrden = proOrdenProdSerie.proOrden) AND (proOrdenProd.Renglon = proOrdenProdSerie.Renglon)
INNER JOIN proOrden ON proOrdenProd.proOrden = proOrden.proOrden
INNER JOIN proOrdenSegmento on	proOrden.proOrden = proOrdenSegmento.proOrden
Left Join stkSerieVencimiento ON stkSerieVencimiento.Serie =  proOrdenProdSerie.Serie And stkSerieVencimiento.Producto_Id = proOrdenProd.Producto_Id And
		stkSerieVencimiento.Empresa_Id = proOrdenSegmento.Empresa_Id
WHERE (proOrdenProdSerie.proOrden = @Orden)
AND (proOrdenProdSerie.Renglon = @Orden)



SELECT venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
	proOrdenPedido.Renglon_Pe
FROM venPediSegmentos 
INNER JOIN venPedidos on venPediSegmentos.venPedidos = venPedidos.venPedidos
INNER JOIN proOrdenPedido ON proOrdenPedido.venPedidos = venPedidos.venPedidos
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = venPediSegmentos.Segmento_Id
WHERE proOrdenPedido.proOrden = @Orden 
ORDER BY 2
GO

DROP PROCEDURE proOrdenGuardar
GO
CREATE PROCEDURE proOrdenGuardar
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
@pProducto_Id varchar(25) = NULL,
@pTamBatch qCantidadD8,
@pReceta_Id varchar(25) = NULL,
@pObservaciones varchar(max),
@pCantidad qCantidadD8,
@pCantidadProgramada qCantidadD8,
@pCantidadTerminada qCantidadD8,
@pCantidadIngresada qCantidadD8,
@pFechaEmision datetime,
@pFechaNecesidad datetime,
@pFechaProduccion datetime = NULL,
@pFechaFin datetime = NULL,
@pMedida_Id varchar(5),
@pFactor qMonedaD8, 
@pAnulado bit, 
@pUsuario_Id Int,
@pCtroProd_Id varchar(8)

)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int= (Select proOrden
 from proOrdenSegmento
 Where
	proOrdenSegmento.Empresa_id = @pEmpresa_Id and 
	proOrdenSegmento.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	proOrdenSegmento.Segmento1N = @pSegmento1N and 
	proOrdenSegmento.Segmento2N = @pSegmento2N and 
	proOrdenSegmento.Segmento3N = @pSegmento3N and 
	proOrdenSegmento.Segmento4N = @pSegmento4N and 
	proOrdenSegmento.Segmento1C = @pSegmento1C and 
	proOrdenSegmento.Segmento2C = @pSegmento2C and 
	proOrdenSegmento.Segmento3C = @pSegmento3C and 
	proOrdenSegmento.Segmento4C = @pSegmento4C )

IF (EXISTS (SELECT 1 FROM proOrden WHERE (proOrden = @lIdentidad)))
BEGIN 
	UPDATE proOrden
			
	SET	@lIdentidad=proOrden.proOrden,
		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		TamBatch = @pTamBatch,
		Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id),
		Observaciones = @pObservaciones,
		Cantidad=@pCantidad,
		CantidadProgramada=@pCantidadProgramada ,
		CantidadTerminada=@pCantidadTerminada ,
		FechaEmision= @pFechaEmision ,
		FechaNecesidad= @pFechaNecesidad ,
		FechaProduccion= @pFechaProduccion ,
		FechaFin= @pFechaFin ,
		Medida_Id= dbo.FuncFKstkUniMed(@pMedida_Id),
		Factor=@pFactor,
		CantidadIngresada =@pCantidadIngresada, 
		Anulado = @pAnulado, 
		Usuario_Id = @pUsuario_Id,
		CtroProd_Id = dbo.FuncFKproCentroProductivo(@pCtroProd_Id)

	WHERE (proOrden = @lIdentidad)
END 
ELSE 
BEGIN 
	INSERT INTO proOrden
	(
		
		Producto_Id,
		TamBatch,
		Receta_Id,
		Observaciones,
		Cantidad,
		CantidadProgramada ,
		CantidadTerminada ,
		FechaEmision ,
		FechaNecesidad ,
		FechaProduccion ,
		FechaFin ,
		Medida_Id ,
		Factor,
		CantidadIngresada, 
		Anulado, 
		Usuario_Id,
		CtroProd_Id
	)
	VALUES 
	(
		
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pTamBatch,
		dbo.FuncFKproRecetas(@pReceta_Id),
		@pObservaciones,
		@pCantidad,
		@pCantidadProgramada ,
		@pCantidadTerminada ,
		@pFechaEmision ,
		@pFechaNecesidad ,
		@pFechaProduccion ,
		@pFechaFin ,
		dbo.FuncFKstkUniMed(@pMedida_Id) ,
		@pFactor,
		@pCantidadIngresada, 
		@pAnulado,
		@pUsuario_Id,
		dbo.FuncFKproCentroProductivo(@pCtroProd_Id)
	)
SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proOrdenEliminar
GO
CREATE PROCEDURE proOrdenEliminar
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int, 
@pUsuario_Id int
)
as

SET NOCOUNT ON 

declare @Orden int
set @Orden=(select proOrden from proOrdenSegmento where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N AND
Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and 
Segmento4C=@pSegmento3C and Segmento4C=@pSegmento4C and
Empresa_Id=@pEmpresa_Id
)

update proOrden set Anulado=1, Usuario_Id = @pUsuario_Id where proOrden=@Orden

 
 RETURN @@Error 

GO

DROP PROCEDURE proOrdenTerminar

GO



CREATE PROCEDURE proOrdenTerminar(
	@proOrden INT, 
	@pCantidad Numeric(18,8),
	@pFechaFin DateTime = NULL
)
AS

Update proOrden SET CantidadTerminada = CantidadTerminada + @pCantidad, 
	FechaFin = @pFechaFin 
	Where
		proOrden = @proOrden

GO

DROP PROCEDURE proOrdenTraeRengPedido
Go
CREATE PROCEDURE proOrdenTraeRengPedido(
	@venPedido INT, 
	@Producto_Id varchar(25)
)
AS

SELECT Renglon_Pe 
FROM venPediCuerpo 
INNER JOIN stkProductos ON venPediCuerpo.Producto_Id = stkProductos.stkProductos
WHERE venPediCuerpo.venPedidos = @venPedido AND
stkProductos.Producto_Id = @Producto_Id
GO


