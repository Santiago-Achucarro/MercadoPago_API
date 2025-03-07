drop procedure inf_suePlantilla
go
create procedure inf_suePlantilla
(@pCentroDesde varchar(8),
@pCentroHasta varchar(8),
@pEmpresa_Id int
)
as
select conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionC1,
suePuestos.Puesto_id,suePuestos.Descripcion,suePlantilla.Cantidad,
suePuestos.Empresa_Id,isnull(SUM(suePersContableDatos.Porcentaje)/100,0)  as CantidadEmpleada,
suePlantilla.Cantidad-isnull(SUM(suePersContableDatos.Porcentaje)/100,0) as Vacantes  
from suePlantilla
inner join suePuestos on ( suePuestos.suePuestos=suePlantilla.Puesto_Id)
inner join conCentro1 on (suePlantilla.Centro1_Id=conCentro1.conCentro1)
left join suePersPuestos on (suePuestos.suePuestos=suePersPuestos.Puesto_Id and suePersPuestos.FechaHasta='29990101')
left join suePersContable on (suePersPuestos.Legajo=suePersContable.Legajo and suePersContable.FechaHasta='29990101')
left join suePersContableDatos on (suePersPuestos.Legajo=suePersContableDatos.Legajo and suePersContableDatos.Centro1_Id=conCentro1.conCentro1 
and suePersContableDatos.FechaDesde= suePersContable.FechaDesde)
where 
isnull(suePuestos.Empresa_Id,@pEmpresa_Id)=@pEmpresa_Id  and 
conCentro1.Centro1_Id BETWEEN  @pCentroDesde and @pCentroHasta
group by conCentro1.Centro1_Id,
suePuestos.Puesto_id,suePuestos.Descripcion,suePlantilla.Cantidad,suePuestos.Empresa_Id, 
conCentro1.Descripcion 
UNION ALL
select conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionC1,
suePuestos.Puesto_id,suePuestos.Descripcion,0 Cantidad,
suePuestos.Empresa_Id,isnull(SUM(suePersContableDatos.Porcentaje)/100,0)  as CantidadEmpleada,-isnull(SUM(suePersContableDatos.Porcentaje)/100,0) as Vacantes  
from suePuestos 
INNER join suePersPuestos on (suePuestos.suePuestos=suePersPuestos.Puesto_Id and suePersPuestos.FechaHasta='29990101')
INNER join suePersContable on (suePersPuestos.Legajo=suePersContable.Legajo and suePersContable.FechaHasta='29990101')
INNER join suePersContableDatos on suePersPuestos.Legajo=suePersContableDatos.Legajo  
	and suePersContableDatos.FechaDesde= suePersContable.FechaDesde
inner join conCentro1 on (suePersContableDatos.Centro1_Id=conCentro1.conCentro1)
where 
	not exists(select 1 from suePlantilla
	where
		suePlantilla.Centro1_Id = conCentro1.conCentro1 and 
		suePlantilla.Puesto_Id =suePuestos.suePuestos) and 
isnull(suePuestos.Empresa_Id,@pEmpresa_Id)=@pEmpresa_Id  and 
conCentro1.Centro1_Id BETWEEN  @pCentroDesde and @pCentroHasta
group by conCentro1.Centro1_Id,
suePuestos.Puesto_id,suePuestos.Descripcion,suePuestos.Empresa_Id, 
conCentro1.Descripcion
ORDER BY 1,3