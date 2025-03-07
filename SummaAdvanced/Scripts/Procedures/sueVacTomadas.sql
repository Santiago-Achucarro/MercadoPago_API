DROP PROCEDURE sueVacTomadasGuardar
GO
CREATE PROCEDURE sueVacTomadasGuardar
(
@pLegajo INT,
@pAnio int,
@pFechaDesde qFecha,
@pDias int,
@pFechaHasta qFecha,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM sueVacTomadas WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo)) AND (Anio = @pAnio) AND (FechaDesde = @pFechaDesde)))
BEGIN 

	UPDATE sueVacTomadas 
	SET		
		Dias = @pDias,
		FechaHasta = @pFechaHasta,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo)) AND (Anio = @pAnio) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	INSERT INTO sueVacTomadas
	(
		Legajo,
		Anio,
		FechaDesde,
		Dias,
		FechaHasta,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFksuePersonal(@pLegajo),
		@pAnio,
		@pFechaDesde,
		@pDias,
		@pFechaHasta,
		@pUsuario_Id
	)

	update sueVacCorresponden set Saldo=Dias-(select sum(Dias) from sueVacTomadas  where sueVacTomadas.Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Anio=@pAnio) where sueVacCorresponden.Legajo=dbo.FuncFKsuePersonal(@pLegajo) and Anio=@pAnio
END 

GO

DROP PROCEDURE sueVacTomadasDatos
GO
CREATE PROCEDURE sueVacTomadasDatos
(
@pLegajo INT,
@pAnio int,
@pFechaDesde qFecha = null
)
AS
SET NOCOUNT ON 

SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as DescripcionPersonal, @pAnio as Anio
From suePersonal 
WHERE
	suePersonal.Legajo = @pLegajo

SELECT sueVacTomadas.FechaDesde, sueVacTomadas.Dias, sueVacTomadas.FechaHasta, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM sueVacTomadas 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = sueVacTomadas.Legajo)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueVacTomadas.Usuario_Id)
WHERE (suePersonal.Legajo = @pLegajo)
AND (sueVacTomadas.Anio = @pAnio)
AND (sueVacTomadas.FechaDesde = ISNULL(@pFechaDesde,sueVacTomadas.FechaDesde))
 
RETURN @@Error 

GO

drop  procedure sueVacTomadasDatosDetallado
go
create procedure sueVacTomadasDatosDetallado
(
    @pLegajo int,
    @pAnio int
)
AS
if not len(cast(@pAnio as char(4)))=4
BEGIN
set @pAnio=year(getdate())
end
select suePersonal.Legajo, ApellidoPaterno+'; '+ApellidoMaterno+'; '+Nombres as DescripcionLegajo, @pAnio as Anio,
@pAnio-Year(DATEADD(MONTH,suePersonal.MesesReconocidos,DATEADD(YY,suePersonal.AniosReconocidos,suePersonal.FechaIngreso))) as Antiguedad,
suePersonal.FechaIngreso, sueConvenio.Convenio_Id, sueConvenio.Descripcion as DescripcionConvenio, sueVacCorresponden.Dias, sueVacCorresponden.Saldo
from suePersonal
left join sueVacCorresponden on suePersonal.genEntidades=sueVacCorresponden.Legajo and sueVacCorresponden.Anio=@pAnio
left join suePersConvenio on suePersConvenio.Legajo=suePersonal.genEntidades and 
cast(Anio as char(4))+'1231'between suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
left join sueConvenio on sueConvenio.sueConvenio=suePersConvenio.Convenio_Id
 where suePersonal.Legajo=@pLegajo
 select FechaDesde, Dias, FechaHasta from sueVacTomadas where Legajo=dbo.FuncFKsuePersonal(@pLegajo) and sueVacTomadas.Anio=@pAnio
 GO



DROP PROCEDURE sueVacTomadasEliminar
GO
CREATE PROCEDURE sueVacTomadasEliminar
(
@pLegajo INT,
@pAnio int ,
@pFechaDesde qFecha = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueVacTomadas 
WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo))
AND (Anio = @pAnio)
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

