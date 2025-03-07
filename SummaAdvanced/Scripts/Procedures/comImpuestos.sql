DROP PROCEDURE comImpuestosGuardar
GO
CREATE PROCEDURE comImpuestosGuardar
(
@pImpuesto_Id varchar(5),
@pImpuesto_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion char(35),
@pTipoImpuesto int,
@pFormulacalc char(200),
@pCtaDebe varchar(25) = NULL,
@pCtaHaber varchar(25) = NULL,
@pCtaReversion varchar(25) = NULL,
@pPorcentaje numeric(5,2),
@pFecha_Desde datetime,
@pFecha_Hasta datetime,
@pDepende_de char(3),
@pVaAlCosto bit,
@pPorAcreditacion bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comImpuestos WHERE (Impuesto_Id = @pImpuesto_Id)))
BEGIN 
	UPDATE comImpuestos
	SET		@lIdentidad = comImpuestos,
		Impuesto_Id = @pImpuesto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		TipoImpuesto = @pTipoImpuesto,
		Formulacalc = @pFormulacalc,
		CtaDebe = dbo.FuncFKconCuentas(@pCtaDebe),
		CtaHaber = dbo.FuncFKconCuentas(@pCtaHaber),
		CtaReversion = dbo.FuncFKconCuentas(@pCtaReversion),
		Porcentaje = @pPorcentaje,
		Fecha_Desde = @pFecha_Desde,
		Fecha_Hasta = @pFecha_Hasta,
		Depende_de = @pDepende_de,
		VaAlCosto = @pVaAlCosto,
		PorAcreditacion = @pPorAcreditacion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Impuesto_Id = @pImpuesto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comImpuestos
	(
		Impuesto_Id,
		Empresa_Id,
		Descripcion,
		TipoImpuesto,
		Formulacalc,
		CtaDebe,
		CtaHaber,
		CtaReversion,
		Porcentaje,
		Fecha_Desde,
		Fecha_Hasta,
		Depende_de,
		VaAlCosto,
		PorAcreditacion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pImpuesto_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pTipoImpuesto,
		@pFormulacalc,
		dbo.FuncFKconCuentas(@pCtaDebe),
		dbo.FuncFKconCuentas(@pCtaHaber),
		dbo.FuncFKconCuentas(@pCtaReversion),
		@pPorcentaje,
		@pFecha_Desde,
		@pFecha_Hasta,
		@pDepende_de,
		@pVaAlCosto,
		@pPorAcreditacion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comImpuestosDatos
GO
CREATE PROCEDURE comImpuestosDatos
(
@pImpuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comImpuestos.comImpuestos, comImpuestos.Impuesto_Id, comImpuestos.Empresa_Id, Cast( Case When comImpuestos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comImpuestos.Descripcion, comImpuestos.TipoImpuesto, impTipoImpuesto.Descripcion as DescripcionTipoImpuesto, comImpuestos.Formulacalc,
	conCuentas.Cuenta_Id as CtaDebe, conCuentas.Descripcion as DescripcionCtaDebe, 
	conCuentas2.Cuenta_Id as CtaHaber, conCuentas2.Descripcion as DescripcionCtaHaber,
	conCuentas3.Cuenta_Id as CtaReversion, conCuentas3.Descripcion as DescripcionCtaReversion, 
	comImpuestos.Porcentaje, comImpuestos.Fecha_Desde,
	comImpuestos.Fecha_Hasta, comImpuestos.Depende_de, comImpuestos.VaAlCosto, comImpuestos.PorAcreditacion,
	comImpuestos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	comImpuestos.Posteado
FROM comImpuestos 
INNER JOIN impTipoImpuesto  ON (impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comImpuestos.CtaDebe)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = comImpuestos.CtaHaber)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = comImpuestos.CtaReversion)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comImpuestos.Usuario_Id)
WHERE (Impuesto_Id = @pImpuesto_Id)
 


 Declare @pidentity bigint= dbo.FuncFKcomImpuestos(@pImpuesto_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comImpuestos'
 RETURN @@Error 

GO

DROP PROCEDURE comImpuestosEliminar
GO
CREATE PROCEDURE comImpuestosEliminar
(
@pImpuesto_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comImpuestos 
WHERE (Impuesto_Id = @pImpuesto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomImpuestos
GO

CREATE FUNCTION FuncFKcomImpuestos
(
@pImpuesto_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comImpuestos FROM comImpuestos WHERE 
	Impuesto_Id = @pImpuesto_Id
  RETURN @pIdentity
END


GO


DROP PROCEDURE comImpuestosPorTipoDatos
GO
CREATE PROCEDURE comImpuestosPorTipoDatos
(
	@pTipo int,
	@pPorcentaje Numeric(5,2),
	@pFecha DateTime,
	@pEmpresa_Id int

)
AS
SET NOCOUNT ON 

SELECT comImpuestos.comImpuestos, comImpuestos.Impuesto_Id, comImpuestos.Empresa_Id, Cast( Case When comImpuestos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comImpuestos.Descripcion, comImpuestos.TipoImpuesto, impTipoImpuesto.Descripcion as DescripcionTipoImpuesto, comImpuestos.Formulacalc,
	conCuentas.Cuenta_Id as CtaDebe, conCuentas.Descripcion as DescripcionCtaDebe, 
	conCuentas2.Cuenta_Id as CtaHaber, conCuentas2.Descripcion as DescripcionCtaHaber,
	conCuentas3.Cuenta_Id as CtaReversion, conCuentas3.Descripcion as DescripcionCtaReversion, 
	comImpuestos.Porcentaje, comImpuestos.Fecha_Desde,
	comImpuestos.Fecha_Hasta, comImpuestos.Depende_de, comImpuestos.VaAlCosto, comImpuestos.PorAcreditacion,
	comImpuestos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	comImpuestos.Posteado
FROM comImpuestos 
INNER JOIN impTipoImpuesto  ON (impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comImpuestos.CtaDebe)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = comImpuestos.CtaHaber)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = comImpuestos.CtaReversion)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comImpuestos.Usuario_Id)
WHERE comImpuestos.TipoImpuesto = @pTipo and 
	(comImpuestos.Porcentaje = @pPorcentaje or @pPorcentaje =0) AND
	comImpuestos.Inactivo = 0 and 
	@pFecha between comImpuestos.Fecha_Desde and comImpuestos.Fecha_Hasta and 
	isnull(comImpuestos.Empresa_Id,@pEmpresa_Id) = @pEmpresa_Id
 


 --Declare @pidentity bigint= dbo.FuncFKcomImpuestos(@pImpuesto_Id)
 --Exec genAtributosGeneralesIdentityDatos @pidentity, 'comImpuestos'

 RETURN @@Error 

GO
