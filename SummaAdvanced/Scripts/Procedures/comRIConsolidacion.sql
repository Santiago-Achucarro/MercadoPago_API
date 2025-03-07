-- exec comRIConsolidacion '20220901', '20220930', ' ', 'NP', '0', 'PES', ' ', 'zz', 1

drop procedure comRIConsolidacion
go
create procedure comRIConsolidacion
(
@pFechaDesde datetime,
@pFechaHasta datetime,
@pProveed_Id varchar(15),
@pTipoPermi_Id varchar(5),
@pCondPago_Id varchar(5),
@pMoneda_Id varchar(3),
@pFamiliaDesde VarChar(15),
@pFamiliaHasta VarChar(15),
@pEmpresa_Id int
)
as

Select @pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta, @pProveed_Id as Proveed_Id, comProveedores.RazonSocial as DescripcionProveed, 
@pTipoPermi_Id as TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermiRI, @pCondPago_Id as CondPago_Id, comConPago.Descripcion as DescripcionCondPago,
@pMoneda_Id as Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, Convert(Numeric(18,2),0.00) as Total , 
	@pFamiliaDesde  FamiliaDesde, @pFamiliaHasta FamiliaHasta, '' as Observaciones
from 
comTipoPermi
left join comProveedores on comProveedores.Proveed_Id=@pProveed_Id
left join comConPago on comConPago.CondPago_Id=@pCondPago_Id
left join genMonedas on genMonedas.Moneda_Id=@pMoneda_Id
where comTipoPermi.TipoPermi_Id=@pTipoPermi_Id


Select dbo.Segmento(comRISegmento.Segmento_Id, comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N) as SegmentoSTR,
comRISegmento.Empresa_Id, comReqInterno.comReqInterno, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial as DescripcionProveed, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, cast(0 as bit) as Marca,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida,
conCentro1.Centro1_Id, concentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, comRICuerpo.Renglon_RI,
comTipoPermiRI.GeneraOC,comRICuerpo.Observaciones ,
isnull(sum(comOCCuerpo.Cantidad),0) as CantidadComprada, 
comRICuerpo.Cantidad-isnull(sum(comOCCuerpo.Cantidad),0) as Faltante,
comRICuerpo.Cantidad-isnull(sum(comOCCuerpo.Cantidad),0) as Comprar, 
ISNULL((SELECT sum(comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida) 
	from comOCCuerpo, comOCArticulo, comOrdenComp, comOCSegmentos
	where
	comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp and 
	comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and 
	comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC and 
	comOCArticulo.Producto_Id = stkProductos.stkProductos and 
	comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp and 
	comOrdenComp.Estado_Id IN ('P','A') AND 
	comOCCuerpo.Pendiente = 1 AND 
	comOCCuerpo.Cantidad > comOCCuerpo.Cantidad_Recibida AND 
	comOcArticulo.Deposito_Id = stkDepositos.stkDepositos and 
	comOCSegmentos.Empresa_Id = @pEmpresa_Id),0) as PorRecibir,
genUsuarios.Apellido_y_Nombres as Usuario, comReqInterno.Observaciones ObservacionCabe
from comReqInterno
right join comRICuerpo on comRICuerpo.comReqInterno=comReqInterno.comReqInterno
inner join comRIArticulo on comRIArticulo.comReqInterno=comReqInterno.comReqInterno and comRIArticulo.Renglon_RI=comRICuerpo.Renglon_RI
inner join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
left join comOCRI on comOCRI.comReqInterno=comReqInterno.comReqInterno and comOCRI.Renglon_RI = comRICuerpo.Renglon_RI
left join comOrdenComp on comOrdenComp.comOrdenComp=comOCRI.comOrdenComp
--inner join genSegmentos on genSegmentos.genSegmentos=comRISegmento.Segmento_Id
left join stkProductos on stkProductos.stkProductos=comRIArticulo.Producto_Id
left join comProveedores on comProveedores.genEntidades=comReqInterno.Proveed_Id
inner join comTipoPermiRI on comReqInterno.TipoPermi_Id=comTipoPermiRI.comTipoPermiRI
left join comOCArticulo on comOCArticulo.comOrdenComp=comOCRI.comOrdenComp and 
	comOCArticulo.Renglon_OC=comOCRI.Renglon_OC
left join comOCCuerpo on comOCCuerpo.comOrdenComp=comOrdenComp.comOrdenComp and 
	comOCCuerpo.Renglon_OC=comOCArticulo.Renglon_OC
left join stkDepositos on comRIArticulo.Deposito_Id=stkDepositos.stkDepositos
left join stkUniMed on stkUniMed.stkUniMed=comRICuerpo.Medida_Id
left join conCentro1 on conCentro1.conCentro1=comRICuerpo.Centro1_Id
left join conCentro2 on concentro2.conCentro2=comRICuerpo.Centro2_Id
inner join comTipoPermi on comTipoPermi.TipoPermi_Id=@pTipoPermi_Id
Left join stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = comReqInterno.Usuario_Id
where comReqInterno.Fecha between @pFechaDesde and @pFechaHasta and
comTipoPermiRI.GeneraOC=1 and comRICuerpo.Pendiente=1 and
comTipoPermi.TipoCuerpo in ('A','P') and 
ISNULL(stkFamilias.Familia_Id, ' ') between @pFamiliaDesde and @pFamiliaHasta
group by
comRISegmento.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N,
comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
comRISegmento.Empresa_Id, comReqInterno.comReqInterno, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial, stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Deposito_Id, stkDepositos.Descripcion,
stkUniMed.Medida_Id, stkUniMed.Descripcion, conCentro1.Centro1_Id, conCentro1.Descripcion, conCentro2.Centro2_Id, conCentro2.Descripcion, comRICuerpo.Renglon_RI,
comTipoPermiRI.GeneraOC, genUsuarios.Apellido_y_Nombres , stkProductos.stkProductos, stkDepositos.stkDepositos, comReqInterno.Observaciones,comRICuerpo.Observaciones
Having comRICuerpo.Cantidad >isnull(sum(comOCCuerpo.Cantidad),0)


Select dbo.Segmento(comRISegmento.Segmento_Id, 
comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N) as SegmentoSTR, comReqInterno.comReqInterno,
comRISegmento.Empresa_Id, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial as DescripcionProveed, comRIMemo.Detalle, cast(0 as bit) as Marca, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida,
conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as  DescripcionCentro2,
conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, comRICuerpo.Renglon_RI, comTipoPermiRI.GeneraOC,
isnull(sum(comOCCuerpo.Cantidad),0) as CantidadComprada, comRICuerpo.Cantidad-isnull(sum(comOCCuerpo.Cantidad),0) as Faltante,
comRICuerpo.Cantidad-isnull(sum(comOCCuerpo.Cantidad),0) as Comprar,
genUsuarios.Apellido_y_Nombres as Usuario,comRiCuerpo.Observaciones, comReqInterno.Observaciones ObservacionCabe
from comReqInterno
right join comRICuerpo on comRICuerpo.comReqInterno=comReqInterno.comReqInterno
inner join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
left join comOCRI on comOCRI.comReqInterno=comReqInterno.comReqInterno
left join comOrdenComp on comOrdenComp.comOrdenComp=comOCRI.comOrdenComp
--inner join genSegmentos on genSegmentos.genSegmentos=comRISegmento.Segmento_Id
left join comProveedores on comProveedores.genEntidades=comReqInterno.Proveed_Id
inner join comTipoPermiRI on comReqInterno.TipoPermi_Id=comTipoPermiRI.comTipoPermiRI
inner join comRIMemo on comRIMemo.comReqInterno=comReqInterno.comReqInterno and comRIMemo.Renglon_RI=comRICuerpo.Renglon_RI
left join comOCMemo on comOCMemo.comOrdenComp=comOrdenComp.comOrdenComp and comOCMemo.Detalle=comRIMemo.Detalle
left join comOCCuerpo on comOCCuerpo.comOrdenComp=comOrdenComp.comOrdenComp and comOCCuerpo.Renglon_OC=comOCMemo.Renglon_OC
left join stkUniMed on stkUniMed.stkUniMed=comRICuerpo.Medida_Id
left join conCentro1 on conCentro1.conCentro1=comRICuerpo.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=comRICuerpo.Centro2_Id
left join conCuentas on conCuentas.conCuentas=comRICuerpo.Cuenta_Id
inner join comTipoPermi on comTipoPermi.TipoPermi_Id=@pTipoPermi_Id
INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = comReqInterno.Usuario_Id
where comReqInterno.Fecha between @pFechaDesde and @pFechaHasta and
comTipoPermiRI.GeneraOC=1 and comRICuerpo.Pendiente=1 and
comTipoPermi.TipoCuerpo in ('A','M') and comReqInterno.EstadoRI_Id='A'  
group by
comRISegmento.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N,
comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C, comReqInterno.comReqInterno,
comRISegmento.Empresa_Id, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial, stkUniMed.Medida_Id, stkUniMed.Descripcion, comRIMemo.Detalle, conCentro1.Centro1_Id, conCentro1.Descripcion, conCentro2.Centro2_Id,
conCentro2.Descripcion, conCuentas.Cuenta_Id, conCuentas.Descripcion, comRICuerpo.Renglon_RI, comTipoPermiRI.GeneraOC, 
genUsuarios.Apellido_y_Nombres , comReqInterno.Observaciones,comRiCuerpo.Observaciones
HAVING comRICuerpo.Cantidad> isnull(sum(comOCCuerpo.Cantidad),0)

select dbo.Segmento(comRISegmento.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N,
comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C) as SegmentoSTR,
comRISegmento.Empresa_Id, comReqInterno.comReqInterno, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial as DescripcionProveed, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, cast(0 as bit) as Marca,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida,
conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, comRICuerpo.Renglon_RI,
comTipoPermiRI.GeneraOC,
isnull(sum(RIGeneraOC.CantidadOriginal),0) + 
	isnull(sum(comRIArticulo.CantidadOriginal),0) + isnull(sum(stkExistencia.Cantidad),0) as StockVirtual, 
ISNULL((SELECT sum(comOCCuerpo.Cantidad - comOCCuerpo.Cantidad_Recibida)
	from comOCCuerpo, comOCArticulo, comOrdenComp, comOCSegmentos
	where
	comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp and 
	comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and 
	comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC and 
	comOCArticulo.Producto_Id = stkProductos.stkProductos and 
	comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp and 
	comOrdenComp.Estado_Id IN ('P','A') AND 
	comOCCuerpo.Pendiente = 1 AND 
	comOCCuerpo.Cantidad > comOCCuerpo.Cantidad_Recibida AND 
	comOcArticulo.Deposito_Id = stkDepositos.stkDepositos and 
	comOCSegmentos.Empresa_Id = @pEmpresa_Id),0) as PorRecibir,
genUsuarios.Apellido_y_Nombres as Usuario
from comReqInterno
right join comRICuerpo on comRICuerpo.comReqInterno=comReqInterno.comReqInterno
inner join comRIArticulo on comRIArticulo.comReqInterno=comReqInterno.comReqInterno and comRIArticulo.Renglon_RI=comRICuerpo.Renglon_RI
inner join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
left join stkProductos on stkProductos.stkProductos=comRIArticulo.Producto_Id
left join comProveedores on comProveedores.genEntidades=comReqInterno.Proveed_Id
inner join comTipoPermiRI on comReqInterno.TipoPermi_Id=comTipoPermiRI.comTipoPermiRI
left join stkDepositos on stkDepositos.stkDepositos=comRIArticulo.Deposito_Id
left join stkUniMed on stkUniMed.stkUniMed=comRICuerpo.Medida_Id
left join conCentro1 on conCentro1.conCentro1=comRICuerpo.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=comRICuerpo.Centro2_Id
left join comTipoPermi on comTipoPermi.TipoPermi_Id=@pTipoPermi_Id
Left join stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = comReqInterno.Usuario_Id
--Requesiciones Existentes que Generan Ordenes de Compra
left join comRIArticulo RIGeneraOC on RIGeneraOC.Producto_Id=comRIArticulo.Producto_Id and RIGeneraOC.Deposito_Id=comRIArticulo.Deposito_Id and
exists(select 1 from comRICuerpo where comRICuerpo.Renglon_RI=RIGeneraOC.Renglon_RI and 
comRICuerpo.comReqInterno= comRIArticulo.comReqInterno and comRICuerpo.Cantidad<comRICuerpo.CantidadRecibida) and
exists(select 1 from comRISegmento where comRISegmento.Empresa_Id=@pEmpresa_Id and comRISegmento.comReqInterno=RIGeneraOC.comReqInterno)
-- Ordenes de Compra Existentes
left join (comOCArticulo  INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp=comOCArticulo.comOrdenComp and 
	comOrdenComp.Estado_Id  != 'R' 
	inner join comOCSegmentos on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp and
	comOCSegmentos.Empresa_Id=@pEmpresa_Id) ON 
	comOCArticulo.Producto_Id=comRIArticulo.Producto_Id and 
	comOCArticulo.Deposito_Id= comRIArticulo.Deposito_Id  
--Existencia
left join stkExistencia on stkExistencia.Producto_Id=comRIArticulo.Producto_Id and comRIArticulo.Deposito_Id= stkExistencia.Deposito_Id and 
stkExistencia.Empresa_Id=@pEmpresa_Id
where comReqInterno.Fecha between @pFechaDesde and @pFechaHasta and
comTipoPermiRI.GeneraOC=0 and comTipoPermi.TipoCuerpo in ('A','P') and comReqInterno.EstadoRI_Id='A' and 
ISNULL(stkFamilias.Familia_Id, ' ') between @pFamiliaDesde and @pFamiliaHasta
group by
comRISegmento.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N,
comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
comRISegmento.Empresa_Id, comReqInterno.comReqInterno, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad, comRICuerpo.Precio, comProveedores.Proveed_Id, 
comProveedores.RazonSocial , stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Deposito_Id, stkDepositos.Descripcion,
stkUniMed.Medida_Id, stkUniMed.Descripcion, conCentro1.Centro1_Id, conCentro1.Descripcion, conCentro2.Centro2_Id, conCentro2.Descripcion, comRICuerpo.Renglon_RI,
comTipoPermiRI.GeneraOC, genUsuarios.Apellido_y_Nombres, stkProductos.stkProductos, stkDepositos.stkDepositos
go


DROP PROCEDURE comOCRIGuardar
GO
CREATE PROCEDURE comOCRIGuardar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pcomReqInterno int,
@pRenglon_RI int,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOCRI WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC) AND (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)))
BEGIN 
	UPDATE comOCRI
	SET		Cantidad = @pCantidad
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC) AND (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)
END 
ELSE 
BEGIN 
	INSERT INTO comOCRI
	(
		comOrdenComp,
		Renglon_OC,
		comReqInterno,
		Renglon_RI,
		Cantidad
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pRenglon_OC,
		@pcomReqInterno,
		@pRenglon_RI,
		@pCantidad
	)
END 

GO

drop procedure comRICambiarPendiente
go
create procedure comRICambiarPendiente
(
@pcomReqInterno int,
@pRenglon_RI int, 
@pPendiente Bit
)
as
update comRICuerpo
set Pendiente=@pPendiente
where comRICuerpo.comReqInterno=@pcomReqInterno and comRICuerpo.Renglon_RI=@pRenglon_RI
go


Drop Procedure comOCRIDatos
GO
CREATE Procedure comOCRIDatos
(
	@comOrdenComp int = NULL, 
	@Renglon_OC Int = NULL,
	@comReqInterno int = NULL,
	@Renglon_Ri Int = NULL
)
AS

SELECT comOrdenComp, Renglon_OC, comReqInterno, Renglon_RI
from comOCRI 
Where
comOrdenComp = ISNULL(@comOrdenComp,comOrdenComp) AND
Renglon_OC = ISNULL(@Renglon_OC, Renglon_OC) AND 
comReqInterno = ISNULL(@comReqInterno, comReqInterno) AND 
Renglon_RI = ISNULL(@Renglon_RI, Renglon_RI)
ORDER BY 1,2,3,4

GO 

Drop Procedure comOCRIEliminar
GO
CREATE Procedure comOCRIEliminar
(
	@comOrdenComp int , 
	@Renglon_OC Int = NULL,
	@comReqInterno int = NULL,
	@Renglon_Ri Int = NULL
)
AS

DELETE from comOCRI 
Where
comOrdenComp = @comOrdenComp AND
Renglon_OC = ISNULL(@Renglon_OC, Renglon_OC) AND 
comReqInterno = ISNULL(@comReqInterno, comReqInterno) AND 
Renglon_RI = ISNULL(@Renglon_RI, Renglon_RI)
GO 