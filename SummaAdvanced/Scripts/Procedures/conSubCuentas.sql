-- AJ FEB 2020 Cambie para que el modificar cambie las cuentas tambien

DROP PROCEDURE conSubCuentasGuardar
GO
CREATE PROCEDURE conSubCuentasGuardar
(
@pSubCuenta_Id varchar(14),
@pSubCuenta_Id_Nuevo varchar(14),
@pEmpresa_Id int,
@pDescripcion varchar(50),
@pCuadro1Fila_Id int,
@pBase_Id varchar(5) = NULL,
@pAjustable Sino,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino, 
@pDescription VarChar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
DECLARE @Digitos int 

IF (EXISTS (SELECT 1 FROM conSubCuentas WHERE (SubCuenta_Id = @pSubCuenta_Id)))
BEGIN 
	UPDATE conSubCuentas
	SET		@lIdentidad = conSubCuentas,
		SubCuenta_Id = @pSubCuenta_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Base_Id = dbo.FuncFKconBaseDistri(@pBase_Id),
		Cuadro1Fila_Id = dbo.FuncFKconCuadro1Filas(@pCuadro1Fila_Id),
		Ajustable = @pAjustable,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		Description = @pDescription
	WHERE (SubCuenta_Id = @pSubCuenta_Id)
	SET @Digitos = isnull((SELECT conDigiCta FROM genInstalacion),5)
	Update conCuentas SET Descripcion = RTRIM(isnull((select conCuentasSinSc.Descripcion
		from conCuentas conCuentas1, conCuentasSinSc
		where
			conCuentasSinSc.Cuenta_Id = conCuentas1.conCuentas and 
			  conCuentas.Cuenta_Id LIKE LEFT(conCuentas1.Cuenta_id,@Digitos)+'%'),''))+@pDescripcion
	where	conCuentas.SubCuenta_Id = @lIdentidad
	if @pSubCuenta_Id != @pSubCuenta_Id_Nuevo
	begin
		Update conCuentas SET Cuenta_Id = LEFT(conCuentas.Cuenta_id,@Digitos)+@pSubCuenta_Id_Nuevo
			where	conCuentas.SubCuenta_Id = @lIdentidad
	end

	
END 
ELSE 
BEGIN 
	INSERT INTO conSubCuentas
	(
		SubCuenta_Id,
		Empresa_Id,
		Descripcion,
		Base_Id,
		Cuadro1Fila_Id,
		Ajustable,
		Inactivo,
		Usuario_Id,
		Posteado, 
		Description
	)
	VALUES 
	(
		@pSubCuenta_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconBaseDistri(@pBase_Id),
		dbo.FuncFKconCuadro1Filas(@pCuadro1Fila_Id),
		@pAjustable,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pDescription
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO





DROP PROCEDURE conSubCuentasDatos
GO
CREATE PROCEDURE conSubCuentasDatos
(
@pSubCuenta_Id varchar(14)
)
AS
SET NOCOUNT ON 

SELECT conSubCuentas.conSubCuentas, conSubCuentas.SubCuenta_Id, 
Cast(case when conSubCuentas.Empresa_Id is null then 1 else 0 end  as bit) PTodasEmpresas,
conSubCuentas.Empresa_Id, conSubCuentas.Descripcion,
	conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBaseDistri, conCuadro1Filas.Cuadro1Fila_Id, 
	conCuadro1Filas.Descripcion as DescripcionCuadro1Filas,
	conSubCuentas.Ajustable, conSubCuentas.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	conSubCuentas.Posteado, conSubCuentas.Description
FROM conSubCuentas 
LEFT JOIN conBaseDistri  ON (conBaseDistri.conBaseDistri = conSubCuentas.Base_Id)
LEFT  JOIN conCuadro1Filas  ON (conCuadro1Filas.conCuadro1Filas = conSubCuentas.Cuadro1Fila_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conSubCuentas.Usuario_Id)
WHERE (SubCuenta_Id = @pSubCuenta_Id)
 


  Declare @pidentity bigint= dbo.FuncFKconSubCuentas(@pSubCuenta_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conSubCuentas'
 RETURN @@Error 

GO

DROP PROCEDURE conSubCuentasEliminar
GO
CREATE PROCEDURE conSubCuentasEliminar
(
@pSubCuenta_Id varchar(14) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conSubCuentas 
WHERE (SubCuenta_Id = @pSubCuenta_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconSubCuentas
GO

CREATE FUNCTION FuncFKconSubCuentas
(
@pSubCuenta_Id varchar (14)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conSubCuentas FROM conSubCuentas WHERE 
	SubCuenta_Id = @pSubCuenta_Id
  RETURN @pIdentity
END


GO
