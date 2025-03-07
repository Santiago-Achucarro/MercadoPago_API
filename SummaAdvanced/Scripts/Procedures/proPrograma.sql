
-- proProgramaDatos 1, '20190807', '20190808', 'H', ' ', 'ZIN'
drop procedure proProgramaDatos
go
create procedure proProgramaDatos
(
    @pEmpresa int,
    @pFechaDesde datetime,
    @pFechaHasta datetime,
    @pPendHist char,
    @pProveedor_Id varchar(15),
    @pTrabajo3_Id varchar(25), 
	@pSoloEnProd Bit
)
as
select proTrabajo3.Trabajo3_Id, protrabajo3.Descripcion as DescripcionTrabajo3,
comProveedores.Proveed_Id as Proveedor_Id,comProveedores.RazonSocial as DescripcionProveedor,
@pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta, @pPendHist as  PendHist, 
	@pSoloEnProd as SoloEnProd
 from proTrabajo3
 left join comProveedores on comProveedores.Proveed_Id=@pProveedor_Id
  where Trabajo3_Id=@pTrabajo3_Id

select proOrden.proOrden, dbo.Segmento( Segmento_Id, Segmento1C, Segmento2C, 
Segmento3C, Segmento4C,Segmento1N, Segmento2N, Segmento3N, Segmento4N) as SegmentoSTR, 
comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveed,
proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionTrabajo3, 
CantidadIngresada, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, 
FechaEmision, FechaNecesidad, FechaProduccion, FechaFin, proOrdenTrabajos3.Renglon
from proOrden
inner join proOrdenSegmento on proOrden.proOrden=proOrdenSegmento.proOrden
inner join proOrdenTrabajos3 on proOrdenTrabajos3.proOrden=proOrden.proOrden
left join comProveedores on comProveedores.genEntidades=proOrdenTrabajos3.Proveed_Id
inner join proTrabajo3 on proTrabajo3.proTrabajo3=proOrdenTrabajos3.proTrabajo3
inner join proOrdenProd on proOrdenProd.proOrden=proOrden.proOrden
inner join stkUniMed on stkUniMed.stkUniMed=proOrdenProd.Medida_Id
where 
((proOrden.FechaProduccion BETWEEN @pFechaDesde and @pFechaHasta and @pPendHist='H') OR
(@pPendHist='P' and proOrdenTrabajos3.Proveed_Id is null)) and
proTrabajo3.Trabajo3_Id  = @pTrabajo3_Id AND
proOrdenSegmento.Empresa_Id=@pEmpresa and 
(@pSoloEnProd=0 or proOrden.FechaProduccion is null)

go

drop  procedure proProgramaGuardar
go
create procedure proProgramaGuardar
(
    @pOrden int,
    @pRenlon int,
    @pProveed_Id varchar(15)
)
as

update proOrdenTrabajos3 
	set Proveed_Id= dbo.FuncFkComProveedores(@pProveed_Id) 
		where proOrdenTrabajos3.proOrden=@pOrden and proOrdenTrabajos3.Renglon=@pRenlon
go