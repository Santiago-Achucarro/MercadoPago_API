DROP PROCEDURE stkUniMedGuardar
GO
CREATE PROCEDURE stkUniMedGuardar
(
@pMedida_id varchar(5),
@pMedida_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pDecimales int,
@pMascara varchar(16),
@pCodigoFiscal Varchar(3) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pUniExpor VarChar(5)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkUniMed WHERE (Medida_id = @pMedida_id)))
BEGIN 
	UPDATE stkUniMed
	SET		@lIdentidad = stkUniMed,
		Medida_id = @pMedida_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Decimales = @pDecimales,
		Mascara = @pMascara,
		CodigoFiscal = @pCodigoFiscal,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		UniExpor = @pUniExpor
	WHERE (Medida_id = @pMedida_id)
END 
ELSE 
BEGIN 
	INSERT INTO stkUniMed
	(
		Medida_id,
		Empresa_Id,
		Descripcion,
		Decimales,
		Mascara,
		CodigoFiscal,
		Inactivo,
		Usuario_Id,
		Posteado,
		UniExpor
	)
	VALUES 
	(
		@pMedida_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pDecimales,
		@pMascara,
		@pCodigoFiscal,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pUniExpor
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkUniMedDatos
GO
CREATE PROCEDURE stkUniMedDatos
(
@pMedida_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkUniMed.stkUniMed, stkUniMed.Medida_id, stkUniMed.Empresa_Id, Cast( Case When stkUniMed.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	stkUniMed.Descripcion, stkUniMed.Decimales, stkUniMed.Mascara, stkUniMed.CodigoFiscal,
		genEntidadesBasicasValor.Descripcion as DescripcionFiscal,
	stkUniMed.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	stkUniMed.Posteado, stkUniMed.UniExpor, genEntidadesBasicasValorExp.Descripcion as DescripcionUniExpor
FROM stkUniMed
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkUniMed.Usuario_Id)
CROSS JOIN genInstalacion
LEFT OUTER JOIN genEntidadesBasicasValor ON
	genEntidadesBasicasValor.Entidad_Id = 1 AND 
	genEntidadesBasicasValor.Dominio_Id = genInstalacion.Dominio_Id AND 
	genEntidadesBasicasValor.Clave = stkUniMed.CodigoFiscal 
LEFT OUTER JOIN genEntidadesBasicasValor genEntidadesBasicasValorExp  ON
	genEntidadesBasicasValorExp.Entidad_Id = 2 AND 
	genEntidadesBasicasValorExp.Dominio_Id = genInstalacion.Dominio_Id AND 
	genEntidadesBasicasValorExp.Clave = stkUniMed.UniExpor
WHERE (stkUniMed.Medida_id = @pMedida_id)
 
 
 

 


  Declare @pidentity bigint= dbo.FuncFKstkUniMed(@pMedida_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkUniMed'
 RETURN @@Error 

GO

DROP PROCEDURE stkUniMedEliminar
GO
CREATE PROCEDURE stkUniMedEliminar
(
@pMedida_id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkUniMed 
WHERE (Medida_id = @pMedida_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkUniMed
GO

CREATE FUNCTION FuncFKstkUniMed
(
@pMedida_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkUniMed FROM stkUniMed WHERE 
	Medida_id = @pMedida_id
  RETURN @pIdentity
END


GO
