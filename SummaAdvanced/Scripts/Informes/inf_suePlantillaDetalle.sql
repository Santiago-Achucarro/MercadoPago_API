-- inf_suePlantillaDetalle ' ','ZZZ',1

Drop procedure inf_suePlantillaDetalle
go
create procedure inf_suePlantillaDetalle
(@pCentroDesde varchar(8),
@pCentroHasta varchar(8),
@pEmpresa_Id int
)
as
Select suePuestos.Puesto_id,suePuestos.Descripcion,
	suePersonal.Empresa_Id,suePlantilla.Cantidad,
	conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionC1,
	isnull(SUM(suePersContableDatos.Porcentaje)/100,0)  as CantidadEmpleada,
	suePlantilla.Cantidad-isnull(SUM(suePersContableDatos.Porcentaje)/100,0) as Vacantes ,
	suePersonal.Legajo,
	suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno   from suePlantilla
inner join suePuestos on ( suePuestos.suePuestos=suePlantilla.Puesto_Id)
inner join conCentro1 on (suePlantilla.Centro1_Id=conCentro1.conCentro1)
left join suePersPuestos on (suePuestos.suePuestos=suePersPuestos.Puesto_Id and suePersPuestos.FechaHasta='29990101')
left join suePersContable on (suePersPuestos.Legajo=suePersContable.Legajo and suePersContable.FechaHasta='29990101')
left join suePersonal on (suePersPuestos.Legajo=suePersonal.Legajo)
left join suePersContableDatos on (suePersPuestos.Legajo=suePersContableDatos.Legajo and suePersContableDatos.Centro1_Id=conCentro1.conCentro1 
and suePersContableDatos.FechaDesde= suePersContable.FechaDesde)

where 
suePersonal.Empresa_Id=@pEmpresa_Id or suePersonal.Empresa_Id is null and 
conCentro1.Centro1_Id BETWEEN  @pCentroDesde and @pCentroHasta
group by conCentro1.Centro1_Id,conCentro1.Descripcion ,
suePuestos.Puesto_id,suePuestos.Descripcion,suePlantilla.Cantidad,suePersonal.Empresa_Id,suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno,
suePersonal.Legajo

union

select suePuestos.Puesto_id,suePuestos.Descripcion,suePersonal.Empresa_Id,0,
	conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionC1,
	isnull((suePersContableDatos.Porcentaje)/100,0)  as CantidadEmpleada,0,
	suePersonal.Legajo,suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno  from suePersonal
inner join suePersPuestos on (suePersPuestos.Legajo=suePersonal.genEntidades and suePersPuestos.FechaHasta='29990101')
left join suePersContable on (suePersPuestos.Legajo=suePersContable.Legajo and suePersContable.FechaHasta='29990101')
left join suePuestos on ( suePuestos.suePuestos=suePersPuestos.Puesto_Id)
left join suePlantilla on (suePlantilla.Puesto_Id=suePuestos.suePuestos)
left join conCentro1 on (suePlantilla.Centro1_Id=conCentro1.conCentro1)
left join suePersContableDatos on (suePersPuestos.Legajo=suePersContableDatos.Legajo and suePersContableDatos.Centro1_Id=conCentro1.conCentro1 
and suePersContableDatos.FechaDesde= suePersContable.FechaDesde)

where suePersContableDatos.Porcentaje>0 and suePersonal.Empresa_Id=@pEmpresa_Id or suePersonal.Empresa_Id is null and 
conCentro1.Centro1_Id BETWEEN  @pCentroDesde and @pCentroHasta



group by conCentro1.Centro1_Id,conCentro1.Descripcion ,
suePuestos.Puesto_id,suePuestos.Descripcion,suePlantilla.Cantidad,suePersonal.Empresa_Id,
suePersonal.Legajo,suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno ,suePersContableDatos.Porcentaje
union all
Select suePuestos.Puesto_id,suePuestos.Descripcion,
	suePersonal.Empresa_Id,0 Cantidad,
	conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionC1,
	isnull(SUM(suePersContableDatos.Porcentaje)/100,0)  as CantidadEmpleada,
	-isnull(SUM(suePersContableDatos.Porcentaje)/100,0) as Vacantes ,
	suePersonal.Legajo,suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno   
	from suePersPuestos inner join 	suePuestos 
			on ( suePuestos.suePuestos=suePersPuestos.Puesto_Id)
	INNER join suePersContable on (suePersPuestos.Legajo=suePersContable.Legajo and 
			suePersContable.FechaHasta='29990101')
	left join suePersContableDatos on suePersPuestos.Legajo=suePersContableDatos.Legajo and 
		suePersContable.FechaDesde = suePersContableDatos.FechaDesde 
	inner join conCentro1 on (suePersContableDatos.Centro1_Id=conCentro1.conCentro1)
	INNER join suePersonal on (suePersPuestos.Legajo=suePersonal.genEntidades)

where 
not exists(select 1 from suePlantilla where
	suePlantilla.Puesto_Id = suePuestos.suePuestos and
	suePlantilla.Centro1_Id = conCentro1.conCentro1) 
	and suePersonal.Empresa_Id=@pEmpresa_Id or suePersonal.Empresa_Id is null and 
	conCentro1.Centro1_Id BETWEEN  @pCentroDesde and @pCentroHasta
group by conCentro1.Centro1_Id,conCentro1.Descripcion ,
suePuestos.Puesto_id,suePuestos.Descripcion,suePersonal.Empresa_Id,
	suePersonal.Legajo,suePersonal.Nombres,
	suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno 

ORDER BY conCentro1.Centro1_Id,suePuestos.Puesto_id,suePersonal.Legajo

GO

 --exec inf_suePlantillaDetalle '00000', 'zzzzz' ,1

