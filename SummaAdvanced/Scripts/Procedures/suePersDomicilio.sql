DROP PROCEDURE suePersDomicilioGuardar
GO
CREATE PROCEDURE suePersDomicilioGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pDireccion1 varchar(100),
@pDireccion2 varchar(100),
@pNroExterior varchar(10),
@pNroInterior varchar(10),
@pLocalidad varchar(100),
@pCodigoPostal varchar(40),
@pEntreCalle1 varchar(60),
@pEntreCalle2 varchar(60),
@pProvincia_Id varchar(5) = NULL,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersDomicilio WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersDomicilio
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
			from suePersDomicilio Catego2 where 
				catego2.Legajo = suePersDomicilio.Legajo and 
				Catego2.FechaDesde>suePersDomicilio.FechaDesde),@pFechaHasta),
		Direccion1 = @pDireccion1,
		Direccion2 = @pDireccion2,
		NroExterior = @pNroExterior,
		NroInterior = @pNroInterior,
		Localidad = @pLocalidad,
		CodigoPostal = @pCodigoPostal,
		EntreCalle1 = @pEntreCalle1,
		EntreCalle2 = @pEntreCalle2,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select 1 from suePersDomicilio where (Legajo = @pLegajo) AND (FechaHasta = '29990101') and Direccion1=@pDireccion1 and Direccion2=@pDireccion2 and NroExterior=@pNroExterior and
NroInterior=@pNroInterior and Localidad=@pLocalidad and CodigoPostal=@pCodigoPostal and EntreCalle1=@pEntreCalle1 and @pEntreCalle2=EntreCalle2 and Provincia_Id= dbo.FuncFKgenProvincias(@pProvincia_Id)))
begin
	if not exists (select 1 from suePersDomicilio where Legajo=@pLegajo)
	BEGIN
		set @pFechaDesde =(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
	end
	update suePersDomicilio set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersDomicilio
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Direccion1,
		Direccion2,
		NroExterior,
		NroInterior,
		Localidad,
		CodigoPostal,
		EntreCalle1,
		EntreCalle2,
		Provincia_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pDireccion1,
		@pDireccion2,
		@pNroExterior,
		@pNroInterior,
		@pLocalidad,
		@pCodigoPostal,
		@pEntreCalle1,
		@pEntreCalle2,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		@pUsuario_Id
	)
	END 
end
GO

DROP PROCEDURE suePersDomicilioDatos
GO
CREATE PROCEDURE suePersDomicilioDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersDomicilio.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersDomicilio.FechaDesde, suePersDomicilio.FechaHasta,
	suePersDomicilio.Direccion1, suePersDomicilio.Direccion2, suePersDomicilio.NroExterior, suePersDomicilio.NroInterior,
	suePersDomicilio.Localidad, suePersDomicilio.CodigoPostal, suePersDomicilio.EntreCalle1, suePersDomicilio.EntreCalle2,
	genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionProvincia, suePersDomicilio.Usuario_Id
FROM suePersDomicilio 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersDomicilio.Legajo)
left join genProvincias on genProvincias.genProvincias=suePersDomicilio.Provincia_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersDomicilioEliminar
GO
CREATE PROCEDURE suePersDomicilioEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersDomicilio 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo)
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde)))
 
 RETURN @@Error 

GO

GO
