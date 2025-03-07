DROP PROCEDURE sueLiqPersImportesGuardar
GO
CREATE PROCEDURE sueLiqPersImportesGuardar
(
@pLegajo int,
@pImporte_Id int,
@pFecha_Hasta qFecha,
@pFecha_Desde qFecha,
@pValor qMonedaD4,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
--si no cambio nada del valor actual no hago nada
IF (not EXISTS (SELECT 1 FROM sueLiqPersImportes WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND (Importe_Id = @pImporte_Id) And 
	Fecha_Hasta = @pFecha_Hasta and (Valor=@pValor)))
 begin
-- si no existe un valor para este importe asigno la fecha de ingreso del legajo a fecha desde
set @pFecha_Desde = case when exists(select 1 from sueLiqPersImportes where Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Importe_Id=@pImporte_Id) then @pFecha_Desde else (select FechaIngreso from suePersonal where Legajo=@pLegajo)end
 -- si solo cambio el valor hago un update
 if exists(select 1 from sueLiqPersImportes where Fecha_Hasta='29990101' and Fecha_Desde=@pFecha_Desde and Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Importe_Id=@pImporte_Id)
 begin
 update sueLiqPersImportes set Valor=@pValor where Fecha_Hasta='29990101' and Fecha_Desde=@pFecha_Desde and Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Importe_Id=@pImporte_Id
 end
 else
 begin
 update sueLiqPersImportes set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Fecha_Hasta='29990101' and Importe_Id=@pImporte_Id
	INSERT INTO sueLiqPersImportes
	(
		Legajo,
		Importe_Id,
		Fecha_Hasta,
		Fecha_Desde,
		Valor,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKsuePersonal(@pLegajo),
		@pImporte_Id,
		@pFecha_Hasta,
		@pFecha_Desde,
		@pValor,
		@pUsuario_Id
	)
 end
 end
GO

-- sueLiqPersImportesDatos 373, '20201024'
DROP PROCEDURE sueLiqPersImportesDatos
GO
CREATE PROCEDURE sueLiqPersImportesDatos
(
@pLegajo int,
@pFecha qFecha
)
AS
SET NOCOUNT ON 

select Legajo, ApellidoPaterno as DescripcionLegajo, @pFecha as Fecha from suePersonal
where Legajo=@pLegajo
select suePersonal.Legajo, suePersonal.ApellidoPaterno as DescripcionLegajo, 
	sueImpNombre.Importe_Id, sueImpNombre.Descripcion as DescripcionImporte, 
	Fecha_Desde, isnull(sueLiqPersImportes.Valor,0) as Valor, sueLiqPersImportes.Usuario_Id, 0 as Empresa_Id 
from sueImpNombre 
left join suePersonal on suePersonal.Legajo= @pLegajo
left join sueLiqPersImportes on 
	sueImpNombre.Importe_Id=sueLiqPersImportes.Importe_Id and 
	@pFecha between sueLiqPersImportes.Fecha_Desde and sueLiqPersImportes.Fecha_Hasta and 
	sueLiqPersImportes.Legajo= suePersonal.genEntidades
Order By sueImpNombre.Importe_Id

 RETURN @@Error 

GO


DROP PROCEDURE sueLiqPersImportesEliminar
GO
CREATE PROCEDURE sueLiqPersImportesEliminar
(
@pLegajo bigint,
@pImporte_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM sueLiqPersImportes 
WHERE (Legajo = dbo.funcfksuePersonal(@pLegajo))
AND (Importe_Id = @pImporte_Id)	
 
 RETURN @@Error 

GO
drop procedure sueLiqPersImportesHistorico
go
create procedure sueLiqPersImportesHistorico
(
@pLegajo int,
@pImporte_Id int
)
as
select Legajo, ApellidoPaterno as DescripcionLegajo, sueImpNombre.Importe_Id, sueImpNombre.Descripcion as DescripcionImporte from suePersonal
inner join sueImpNombre on sueImpNombre.Importe_Id=@pImporte_Id
where Legajo=@pLegajo
select suePersonal.Legajo, suePersonal.ApellidoPaterno as DescripcionLegajo, sueImpNombre.Importe_Id, sueImpNombre.Descripcion as DescripcionImporte, 
Fecha_Desde, Valor, sueLiqPersImportes.Usuario_Id, 0 as Empresa_Id from sueLiqPersImportes
inner join suePersonal on suePersonal.genEntidades=sueLiqPersImportes.Legajo
inner join sueImpNombre on sueImpNombre.Importe_Id=sueLiqPersImportes.Importe_Id
where suePersonal.Legajo=@pLegajo and
sueImpNombre.Importe_Id=@pImporte_Id
GO
