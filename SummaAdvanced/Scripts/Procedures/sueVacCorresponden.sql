DROP PROCEDURE sueVacCorrespondenGuardar
GO
CREATE PROCEDURE sueVacCorrespondenGuardar
(
@pLegajo int,
@pAnio int,
@pDias int,
@pSaldo int=null
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueVacCorresponden WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo)) AND (Anio = @pAnio)))
BEGIN 
	UPDATE sueVacCorresponden
	SET		Dias = @pDias, Saldo=isnull(@pSaldo,Saldo)
	WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo)) AND (Anio = @pAnio)
END 
ELSE 
BEGIN 
	INSERT INTO sueVacCorresponden
	(
		Legajo,
		Anio,
		Dias,
		Saldo
	)
	VALUES 
	(
		dbo.FuncFksuePersonal(@pLegajo),
		@pAnio,
		@pDias,
		ISNULL(@pSaldo,@pDias)
	)
END 

GO

DROP PROCEDURE sueVacCorrespondenDatos
GO
CREATE PROCEDURE sueVacCorrespondenDatos
(
@pLegajo int,
@pAnio int,
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as DescripcionPersonal, 
	sueVacCorresponden.Anio, sueVacCorresponden.Dias,Saldo
FROM sueVacCorresponden 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = sueVacCorresponden.Legajo)
WHERE (suePersonal.Legajo = @pLegajo)
AND (Anio = @pAnio) and 
suePersonal.Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE sueVacCorrespondenEliminar
GO
CREATE PROCEDURE sueVacCorrespondenEliminar
(
@pAnio int ,
@pLegajo int = NULL, 
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM sueVacCorresponden 
WHERE (@pLegajo is null or Legajo =  dbo.FuncFksuePersonal(@pLegajo))
AND (Anio = @pAnio) and 
Exists(select 1 from suePersonal where suePersonal.genEntidades = sueVacCorresponden.Legajo and 
suePersonal.Empresa_Id =  @pEmpresa_Id)
 
 RETURN @@Error 

GO

-- sueVacCorrespondenDatosRango 2021,373,1000,1
drop procedure sueVacCorrespondenDatosRango
go
create procedure sueVacCorrespondenDatosRango
(
@pAnio int,
@pLegajoDesde int,
@pLegajoHasta int, 
@pEmpresa_Id Int
)
as
if not LEN(cast(@pAnio as char(4)))=4
BEGIN
	set @pAnio=year(getdate())
end
select @pAnio as Anio, @pLegajoDesde as LegajoDesde, @pLegajoHasta as LegajoHasta

select suePersonal.Legajo, suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno+','+suePersonal.Nombres as DescripcionLegajo, 
isnull(sueVacCorresponden.Anio,@pAnio) as Anio,
isnull(sueVacCorresponden.Dias, (SELECT Dias FROM sueTablaVacReng  
		WHERE 
		Antiguedad = (
			SELECT MIN(Antiguedad) Ant FROM sueTablaVacReng
			INNER JOIN sueTablaVacacion ON sueTablaVacacion.sueTablaVacacion = sueTablaVacReng.TablaVac_Id
			WHERE Antiguedad >= (DATEDIFF(YEAR,DATEADD(MONTH,-suePersonal.MesesReconocidos, DATEADD(YY,-suePersonal.AniosReconocidos,suePersonal.FechaIngreso)), 
				cast(@pAnio as char(4))+'1231'))))) as Dias,
isnull(sueVacCorresponden.Saldo, (SELECT Dias FROM sueTablaVacReng  
		WHERE Antiguedad = (
			SELECT MIN(Antiguedad) Ant FROM sueTablaVacReng
			INNER JOIN sueTablaVacacion ON sueTablaVacacion.sueTablaVacacion = sueTablaVacReng.TablaVac_Id
			WHERE Antiguedad >= (DATEDIFF(YEAR,DATEADD(MONTH,-suePersonal.MesesReconocidos,DATEADD(YY,-suePersonal.AniosReconocidos,suePersonal.FechaIngreso)),
				cast(@pAnio as char(4))+'1231'))))) as Saldo 
From suePersonal
inner join suePersConvenio on suePersConvenio.Legajo=suePersonal.genEntidades and 
	cast(@pAnio as char(4))+'1231' BETWEEN suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
inner join sueConvenio on sueConvenio.sueConvenio=suePersConvenio.Convenio_Id
inner join sueTablaVacacion on sueTablaVacacion=sueConvenio.TablaVac_Id
left join sueVacCorresponden on suePersonal.genEntidades=sueVacCorresponden.Legajo And sueVacCorresponden.Anio = @pAnio
--left join sueVacTomadas on sueVacTomadas.Anio=@pAnio and sueVacTomadas.Legajo=suePersonal.genEntidades
WHERE
	suePersonal.Legajo Between @pLegajoDesde And @pLegajoHasta And
	(suePersonal.FechaBaja IS NULL OR 
	YEAR(suePersonal.FechaBaja)>= @pAnio) and 
	YEAR(suePersonal.FechaIngreso) <= @pAnio and 
	suePersonal.Empresa_Id = @pEmpresa_Id 
	--And isNull(sueVacCorresponden.Saldo, 0) > 0
	ORDER BY 1
go



/*create procedure sueVacCorrespondenDatosRango
(
@pAnio int,
@pLegajoDesde int,
@pLegajoHasta int
)
as
if not LEN(cast(@pAnio as char(4)))=4
BEGIN
set @pAnio=year(getdate())
end
select @pAnio as Anio, @pLegajoDesde as LegajoDesde, @pLegajoHasta as LegajoHasta
select suePersonal.Legajo, suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno+','+suePersonal.Nombres as DescripcionLegajo, 
isnull(sueVacCorresponden.Anio,@pAnio) as Anio,
 isnull(sueVacCorresponden.Dias,sueTablaVacReng.Dias) as Dias, isnull(Saldo,sueTablaVacReng.Dias) as Saldo from suePersonal
left join sueVacCorresponden on suePersonal.genEntidades=sueVacCorresponden.Legajo
inner join suePersConvenio on suePersConvenio.Legajo=suePersonal.genEntidades and 
cast(@pAnio as char(4))+'1231' BETWEEN suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
inner join sueConvenio on sueConvenio.sueConvenio=suePersConvenio.Convenio_Id
inner join sueTablaVacacion on sueTablaVacacion=sueConvenio.TablaVac_Id
inner join sueTablaVacReng 
on @pAnio-sueTablaVacReng.Antiguedad=
YEAR(DATEADD(MONTH,-suePersonal.MesesReconocidos,DATEADD(YY,-suePersonal.AniosReconocidos,suePersonal.FechaIngreso)))
and sueTablaVacacion.sueTablaVacacion=sueTablaVacReng.TablaVac_Id
left join sueVacTomadas on sueVacTomadas.Anio=@pAnio and sueVacTomadas.Legajo=suePersonal.genEntidades
go*/

