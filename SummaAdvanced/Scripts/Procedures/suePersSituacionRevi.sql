DROP PROCEDURE suePersSituacionReviGuardar
GO
CREATE PROCEDURE suePersSituacionReviGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pSituacion_Id varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersSituacionRevi WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersSituacionRevi
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersSituacionRevi Catego2 
		where 
		Catego2.Legajo = suePersSituacionRevi.Legajo and
		Catego2.FechaDesde>suePersSituacionRevi.FechaDesde),@pFechaHasta),
		Situacion_Id = @pSituacion_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Situacion_Id from suePersSituacionRevi where (Legajo = @pLegajo) AND (FechaDesde = '29990101')and Situacion_Id=@pSituacion_Id))
begin
if not exists (select 1 from suePersSituacionRevi where Legajo=@pLegajo)
begin
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersSituacionRevi set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersSituacionRevi
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Situacion_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pSituacion_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersSituacionReviDatos
GO
CREATE PROCEDURE suePersSituacionReviDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersSituacionRevi.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersSituacionRevi.FechaDesde, suePersSituacionRevi.FechaHasta,
	suePersSituacionRevi.Situacion_Id, genEntidadesBasicasValor.Descripcion as DescripcionSituacion, suePersSituacionRevi.Usuario_Id
FROM suePersSituacionRevi 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersSituacionRevi.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1508 and genEntidadesBasicasValor.Clave=suePersSituacionRevi.Situacion_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersSituacionReviEliminar
GO
CREATE PROCEDURE suePersSituacionReviEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersSituacionRevi 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

Drop procedure suePersSituaRevisHistoria
Go
Create procedure suePersSituaRevisHistoria
(
@pLegajo int,
@pFechaDesde Datetime,
@pFechaHasta Datetime
)
As

Select Situacion_Id, suePersSituacionRevi.FechaDesde, suePersSituacionRevi.FechaHasta
From suePersSituacionRevi
Inner Join suePersonal On suePersonal.genEntidades = suePersSituacionRevi.Legajo
Where suePersonal.Legajo = @pLegajo And
(FechaDesde Between @pFechaDesde And @pFechaHasta Or
FechaHasta Between @pFechaDesde And @pFechaHasta Or
FechaDesde >= @pFechaDesde AND FechaHasta <= @pFechaHasta Or
FechaDesde <= @pFechaDesde AND FechaHasta >= @pFechaHasta)
Order by FechaDesde
Go
