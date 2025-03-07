DROP PROCEDURE sueFamiliaresGuardar
GO
CREATE PROCEDURE sueFamiliaresGuardar
(
@pLegajo int,
@pTipoDoc char(1),
@pNroDoc varchar(25),
@pRelacion char(1),
@pApellidoyNombre varchar(50),
@pSexo char(1),
@pFechaNacimiento qFecha,
@pACargoDesde qFecha,
@pFechaBaja qFecha = NULL,
@pFechaCarga qFecha,
@pGanancias Sino,
@pIncapacitado Sino,
@pAdhObSocial Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueFamiliares WHERE Legajo = dbo.FuncFKsuePersonal(@pLegajo) AND TipoDoc = @pTipoDoc AND NroDoc = @pNroDoc))
BEGIN 
	UPDATE sueFamiliares
	SET Relacion = @pRelacion,
		ApellidoyNombre = @pApellidoyNombre,
		Sexo = @pSexo,
		FechaNacimiento = @pFechaNacimiento,
		ACargoDesde = @pACargoDesde,
		FechaBaja = @pFechaBaja,
		FechaCarga = GetDate(),
		Ganancias = @pGanancias,
		Incapacitado = @pIncapacitado,
		AdhObSocial = @pAdhObSocial,
		Usuario_Id = @pUsuario_Id
	WHERE Legajo = dbo.FuncFKsuePersonal(@pLegajo) AND TipoDoc = @pTipoDoc AND NroDoc = @pNroDoc
END 
ELSE 
BEGIN 
	INSERT INTO sueFamiliares
	(
		Legajo,
		TipoDoc,
		NroDoc,
		Relacion,
		ApellidoyNombre,
		Sexo,
		FechaNacimiento,
		ACargoDesde,
		FechaBaja,
		FechaCarga,
		Ganancias,
		Incapacitado,
		AdhObSocial,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKsuePersonal(@pLegajo),
		@pTipoDoc,
		@pNroDoc,
		@pRelacion,
		@pApellidoyNombre,
		@pSexo,
		@pFechaNacimiento,
		@pACargoDesde,
		@pFechaBaja,
		getdate(),
		@pGanancias,
		@pIncapacitado,
		@pAdhObSocial,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE sueFamiliaresDatos
GO
CREATE PROCEDURE sueFamiliaresDatos
(
@pLegajo int,
@pTipoDoc char(1) = Null,
@pNroDoc varchar(25) = Null
)
AS
SET NOCOUNT ON 

SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno, sueFamiliares.TipoDoc, genTiposDoc.Descripcion DescripcionTipoDoc, sueFamiliares.NroDoc,
	sueFamiliares.Relacion, sueFamiliares.ApellidoyNombre, sueFamiliares.Sexo, sueFamiliares.FechaNacimiento,
	sueFamiliares.ACargoDesde, sueFamiliares.FechaBaja, sueFamiliares.FechaCarga, sueFamiliares.Ganancias,
	sueFamiliares.Incapacitado, sueFamiliares.AdhObSocial, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM sueFamiliares
INNER JOIN suePersonal ON (suePersonal.genEntidades = sueFamiliares.Legajo)
LEFT JOIN genUsuarios ON (genUsuarios.genUsuarios = sueFamiliares.Usuario_Id)
Cross Join genInstalacion
Inner Join genTiposDoc On genTiposDoc.TipoDoc = sueFamiliares.TipoDoc And genTiposDoc.Dominio_Id = genInstalacion.Dominio_Id
WHERE suePersonal.Legajo = @pLegajo
AND sueFamiliares.TipoDoc = isNull(@pTipoDoc, sueFamiliares.TipoDoc)
AND NroDoc = isNull(@pNroDoc, NroDoc)

RETURN @@Error 

GO

DROP PROCEDURE sueFamiliaresEliminar
GO
CREATE PROCEDURE sueFamiliaresEliminar
(
@pLegajo int,
@pTipoDoc char(1) = NULL,
@pNroDoc varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueFamiliares 
WHERE Legajo = dbo.FuncFKsuePersonal(@pLegajo)
AND TipoDoc = ISNULL(@pTipoDoc, TipoDoc)
AND NroDoc = ISNULL(@pNroDoc, NroDoc)
 
RETURN @@Error 

GO

DROP PROCEDURE sueLegajoFamiliaresDatos
GO
CREATE PROCEDURE sueLegajoFamiliaresDatos
(
@pLegajo int
)
AS
SET NOCOUNT ON

Select suePersonal.Legajo, suePersonal.ApellidoPaterno
From suePersonal
Where suePersonal.Legajo = @pLegajo

Exec sueFamiliaresDatos @pLegajo

RETURN @@Error 

GO