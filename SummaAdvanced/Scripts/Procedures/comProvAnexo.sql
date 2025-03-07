DROP PROCEDURE comProvAnexoGuardar
GO
CREATE PROCEDURE comProvAnexoGuardar
(
@pgenEntidades bigint,
@pRazonSocial varchar(120),
@pDireccion1 varchar(35),
@pDireccion2 varchar(35),
@pLocalidad varchar(35),
@pCod_Postal varchar(10),
@pProvincia_Id varchar(5) = NULL,
@pCondFiscal_Id varchar(5) = NULL,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comProvAnexo WHERE (genEntidades = @pgenEntidades)))
BEGIN 
	UPDATE comProvAnexo
	SET		RazonSocial = @pRazonSocial,
		Direccion1 = @pDireccion1,
		Direccion2 = @pDireccion2,
		Localidad = @pLocalidad,
		Cod_Postal = @pCod_Postal,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		CondFiscal_Id = dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (genEntidades = @pgenEntidades)
END 
ELSE 
BEGIN 
	INSERT INTO comProvAnexo
	(
		genEntidades,
		RazonSocial,
		Direccion1,
		Direccion2,
		Localidad,
		Cod_Postal,
		Provincia_Id,
		CondFiscal_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pgenEntidades,
		@pRazonSocial,
		@pDireccion1,
		@pDireccion2,
		@pLocalidad,
		@pCod_Postal,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE comProvAnexoDatos
GO
CREATE PROCEDURE comProvAnexoDatos
(
@pCuit VarChar(25)
)
AS
SET NOCOUNT ON 

SELECT genEntidades.genEntidades, genEntidades.CUIT , comProvAnexo.RazonSocial, comProvAnexo.Direccion1, comProvAnexo.Direccion2,
	comProvAnexo.Localidad, comProvAnexo.Cod_Postal, genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionProvincias,
	comCondFiscal.CondFiscal_Id, comCondFiscal.Descripcion as DescripcionCondFiscal,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM comProvAnexo 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = comProvAnexo.genEntidades)
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = comProvAnexo.Provincia_Id)
LEFT JOIN comCondFiscal  ON (comCondFiscal.comCondFiscal = comProvAnexo.CondFiscal_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comProvAnexo.Usuario_Id)
WHERE (genEntidades.Cuit = @pCuit)
 
 RETURN @@Error 

GO

DROP PROCEDURE comProvAnexoEliminar
GO
CREATE PROCEDURE comProvAnexoEliminar
(
@pgenEntidades bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comProvAnexo 
WHERE (genEntidades = @pgenEntidades)
 
 RETURN @@Error 

GO


