DROP PROCEDURE sueConvenioGuardar
GO
CREATE PROCEDURE sueConvenioGuardar
(
@pConvenio_Id varchar(5),
@pConvenio_Id_Nueva varchar(5),
@pDescripcion varchar(100),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pEmpresa_Id int =null,
@pTablaVac_Id varchar(5),
@pSindicalizado SiNo
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueConvenio WHERE Convenio_Id=@pConvenio_Id))
BEGIN 
	UPDATE sueConvenio
	SET		@lIdentidad = sueConvenio,
		Convenio_Id = @pConvenio_Id_Nueva,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id=@pEmpresa_Id,
		Sindicalizdo=@pSindicalizado,
		TablaVac_Id=dbo.FuncFKsueTablaVacacion(@pTablaVac_Id)
	WHERE Convenio_Id=@pConvenio_Id
END 
ELSE 
BEGIN 
	INSERT INTO sueConvenio
	(
		Convenio_Id,
		Descripcion,
		Inactivo,
		Posteado,
		Usuario_Id,
		Empresa_Id,
		Sindicalizdo,
		TablaVac_Id
	)
	VALUES 
	(
		@pConvenio_Id_Nueva,
		@pDescripcion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pEmpresa_Id,
		@pSindicalizado,
		dbo.FuncFKsueTablaVacacion(@pTablaVac_Id)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueConvenioDatos
GO
CREATE PROCEDURE sueConvenioDatos
(
@pConvenio_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT sueConvenio.sueConvenio, sueConvenio.Convenio_Id, sueConvenio.Convenio_Id as Convenio_Id_Nueva, sueConvenio.Descripcion, sueConvenio.Inactivo,
	sueConvenio.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	cast(case when sueConvenio.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas, sueTablaVacacion.TablaVac_Id,
	sueTablaVacacion.Descripcion as DescripcionVacacion, Sindicalizdo
FROM sueConvenio 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueConvenio.Usuario_Id)
left join sueTablaVacacion on sueTablaVacacion.sueTablaVacacion=sueConvenio.TablaVac_Id
WHERE  
@pConvenio_Id=Convenio_Id

  Declare @pidentity bigint= dbo.FuncFKsueConvenio(@pConvenio_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueConvenio'
 RETURN @@Error 

GO

DROP PROCEDURE sueConvenioEliminar
GO
CREATE PROCEDURE sueConvenioEliminar
(
@pConvenio_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM sueConvenio 
WHERE  Convenio_Id=@pConvenio_Id
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueConvenio
GO

CREATE FUNCTION FuncFKsueConvenio
(
@pConvenio_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueConvenio FROM sueConvenio WHERE 
	Convenio_Id = @pConvenio_Id
  RETURN @pIdentity
END


GO
