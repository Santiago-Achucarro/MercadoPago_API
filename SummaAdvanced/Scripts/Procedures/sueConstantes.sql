
drop Procedure sueConstantesDatos
go
Create Procedure sueConstantesDatos
as



select distinct sueTabla.Tabla_Id,sueTabla.Ver,Descripcion,sueTabTitulo.Codigo from sueTabla
inner join sueTabTitulo on sueTabTitulo.Tabla_Id=sueTabla.Tabla_Id
where 
Codigo != NULL and Codigo!=''

select distinct sueGanTitulo.TabGan_Id,Descripcion,Codigo,Ver from sueGanTitulo
inner join sueGanancias on sueGanancias.TabGan_Id=sueGanTitulo.TabGan_Id
where 
Codigo != NULL and Codigo!=''

select distinct sueVarGlobales.VarGlobal_Id,Descripcion,PorEmpresa,Codigo,Fecha_Hasta,Fecha_Desde,Ver from sueVarGlobales
inner join sueLiqVarGlobales on sueLiqVarGlobales.VarGlobal_Id=sueVarGlobales.VarGlobal_Id
where 
Codigo != NULL and Codigo!=''
go
