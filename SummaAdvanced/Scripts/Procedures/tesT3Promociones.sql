DROP PROCEDURE tesT3PromocionesGuardar
GO
CREATE PROCEDURE tesT3PromocionesGuardar
(
@pPromocion_Id int,
@pPromocion_Id_Nuevo int,
@pDescripcion varchar(100),
@pEmpresa_Id int = NULL,
@pVigenciaDesde qFecha,
@pVigenciaHasta qFecha,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesT3Promociones WHERE (Promocion_Id = @pPromocion_Id)))
BEGIN 
	UPDATE tesT3Promociones
	SET		@lIdentidad = tesT3Promociones,
		Promocion_Id = @pPromocion_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		VigenciaDesde = @pVigenciaDesde,
		VigenciaHasta = @pVigenciaHasta,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Promocion_Id = @pPromocion_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesT3Promociones
	(
		Promocion_Id,
		Descripcion,
		Empresa_Id,
		VigenciaDesde,
		VigenciaHasta,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pPromocion_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pVigenciaDesde,
		@pVigenciaHasta,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesT3PromocionesDatos
GO
CREATE PROCEDURE tesT3PromocionesDatos
(
@pPromocion_Id int
)
AS
SET NOCOUNT ON 

SELECT tesT3Promociones.tesT3Promociones, tesT3Promociones.Promocion_Id, tesT3Promociones.Descripcion, tesT3Promociones.Promocion_Id Promocion_Id_Nueva,
	tesT3Promociones.Empresa_Id, Cast( Case When tesT3Promociones.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, tesT3Promociones.VigenciaDesde, tesT3Promociones.VigenciaHasta,
	tesT3Promociones.Inactivo, tesT3Promociones.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM tesT3Promociones 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesT3Promociones.Usuario_Id)
WHERE (Promocion_Id = @pPromocion_Id)
 
Exec tesT3PromocionesCuotasDatos @pPromocion_Id
Exec tesTarjetasPromocionesDatos Null, @pPromocion_Id

Declare @pidentity bigint= dbo.FuncFKtesT3Promociones(@pPromocion_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesT3Promociones'
RETURN @@Error 

GO

DROP PROCEDURE tesT3PromocionesEliminar
GO
CREATE PROCEDURE tesT3PromocionesEliminar
(
@pPromocion_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesT3Promociones 
WHERE (Promocion_Id = @pPromocion_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesT3Promociones
GO

CREATE FUNCTION FuncFKtesT3Promociones
(
@pPromocion_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesT3Promociones FROM tesT3Promociones WHERE 
	Promocion_Id = @pPromocion_Id
  RETURN @pIdentity
END

GO

Drop Procedure tesT3PromocionesVigentes
Go
Create Procedure tesT3PromocionesVigentes
(
@pEmpresa_Id int,
@pFecha datetime,
@pCartera_Id varchar(5)
)
As
SELECT tesT3Promociones.Promocion_Id, tesT3Promociones.Descripcion, getDate() Fecha, '' Cartera_Id
FROM tesT3Promociones 
Where isNull(tesT3Promociones.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And @pFecha Between tesT3Promociones.VigenciaDesde And tesT3Promociones.VigenciaHasta And
Exists (Select 1 From tesTarjetasPromociones Where tesTarjetasPromociones.Promocion_Id = tesT3Promociones.tesT3Promociones And
				tesTarjetasPromociones.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
Go

