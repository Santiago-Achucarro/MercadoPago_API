DROP PROCEDURE sueConceptosGuardar
GO
CREATE PROCEDURE sueConceptosGuardar
(
@pConcepto_Id int,
@pConcepto_Id_Nuevo int,
@pDescripcion varchar(60),
@pEmpresa_Id int = NULL,
@pFormula varchar(max),
@pLlevaDato Sino,
@pCuentaDebe varchar(25) = NULL,
@pCuentaHaber varchar(25) = NULL,
@pSubCuentaDebe varchar(14) = NULL,
@pSubCuentaHaber varchar(14) = NULL,
@pRetroactivo Sino,
@pExtraordinario Sino,
@pTipoPercepcion varchar(3) = NULL,
@pTipoDeduccion varchar(3) = NULL,
@pTipoOtro varchar(3) = NULL,
@pTipoHora char(1) = NULL,
@pTipoIncapacidad VarChar(2) = NULL,
@pEsExento Sino,
@pObservacion VarChar(max) = Null,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL, 
@pSigno smallInt, 
@pColumnaRecibo smallInt
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueConceptos WHERE (Concepto_Id = @pConcepto_Id)))
BEGIN 
	UPDATE sueConceptos
	SET		@lIdentidad = sueConceptos,
		Concepto_Id = @pConcepto_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Formula = @pFormula,
		LlevaDato = @pLlevaDato,
		CuentaDebe = dbo.FuncFKconCuentas(@pCuentaDebe),
		CuentaHaber = dbo.FuncFKconCuentas(@pCuentaHaber),
		SubCuentaDebe = dbo.FuncFKconSubCuentas(@pSubCuentaDebe),
		SubCuentaHaber = dbo.FuncFKconSubCuentas(@pSubCuentaHaber),
		Retroactivo = @pRetroactivo,
		Extraordinario = @pExtraordinario,
		TipoPercepcion = @pTipoPercepcion,
		TipoDeduccion = @pTipoDeduccion,
		TipoOtro = @pTipoOtro,
		TipoHora = @pTipoHora,
		TipoIncapacidad = @pTipoIncapacidad,
		EsExento = @pEsExento,
		Observacion = @pObservacion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Signo = @pSigno, 
		ColumnaRecibo = @pColumnaRecibo
	WHERE (Concepto_Id = @pConcepto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueConceptos
	(
		Concepto_Id,
		Descripcion,
		Empresa_Id,
		Formula,
		LlevaDato,
		CuentaDebe,
		CuentaHaber,
		SubCuentaDebe,
		SubCuentaHaber,
		Retroactivo,
		Extraordinario,
		TipoPercepcion,
		TipoDeduccion,
		TipoOtro,
		TipoHora,
		TipoIncapacidad,
		EsExento,
		Observacion,
		Inactivo,
		Posteado,
		Usuario_Id, 
		Signo,
		ColumnaRecibo
	)
	VALUES 
	(
		@pConcepto_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pFormula,
		@pLlevaDato,
		dbo.FuncFKconCuentas(@pCuentaDebe),
		dbo.FuncFKconCuentas(@pCuentaHaber),
		dbo.FuncFKconSubCuentas(@pSubCuentaDebe),
		dbo.FuncFKconSubCuentas(@pSubCuentaHaber),
		@pRetroactivo,
		@pExtraordinario,
		@pTipoPercepcion,
		@pTipoDeduccion,
		@pTipoOtro,
		@pTipoHora,
		@pTipoIncapacidad,
		@pEsExento,
		@pObservacion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pSigno,
		@pColumnaRecibo

	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueConceptosDatos
GO
CREATE PROCEDURE sueConceptosDatos
(
@pConcepto_Id int
)
AS
SET NOCOUNT ON 

SELECT sueConceptos.sueConceptos, sueConceptos.Concepto_Id, sueConceptos.Descripcion, 
	sueConceptos.Empresa_Id, Cast( Case When sueConceptos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, sueConceptos.Formula, sueConceptos.LlevaDato,
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe, conCuentasHaber.Cuenta_Id as CuentaHaber,
	conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conSubCuentasDebe.SubCuenta_Id as SubCuentaDebe, conSubCuentasDebe.Descripcion as DescripcionSubCuentasDebe, conSubCuentasHaber.SubCuenta_Id as SubCuentaHaber, 
	conSubCuentasHaber.Descripcion as DescripcionSubCuentasHaber,
	sueConceptos.Retroactivo, sueConceptos.Extraordinario, sueConceptos.TipoPercepcion, DescTipoPercepcion.Descripcion as DescripcionTipoPercepcion, 
	sueConceptos.TipoDeduccion, DescTipoDeduccion.Descripcion as DescripcionTipoDeduccion, sueConceptos.TipoOtro,
	DescTipoOtro.Descripcion as DescripcionTipoOtro, sueConceptos.TipoHora, sueConceptos.TipoIncapacidad as TipoIncapacidad, sueConceptos.EsExento,
	sueConceptos.Inactivo, sueConceptos.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	sueConceptos.Signo, sueConceptos.ColumnaRecibo, sueConceptos.Observacion
	
FROM sueConceptos 
cross join genInstalacion
LEFT JOIN conCuentas conCuentasDebe  ON (conCuentasDebe.conCuentas = sueConceptos.CuentaDebe)
LEFT JOIN conCuentas conCuentasHaber ON (conCuentasHaber.conCuentas = sueConceptos.CuentaHaber)
LEFT JOIN conSubCuentas as conSubCuentasDebe  ON (conSubCuentasDebe.conSubCuentas = sueConceptos.SubCuentaDebe)
LEFT JOIN conSubCuentas conSubCuentasHaber ON (conSubCuentasHaber.conSubCuentas = sueConceptos.SubCuentaHaber)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueConceptos.Usuario_Id)
left join genEntidadesBasicasValor DescTipoPercepcion on DescTipoPercepcion.Clave=sueConceptos.TipoPercepcion and DescTipoPercepcion.Entidad_Id = 1517  and genInstalacion.Dominio_Id = DescTipoPercepcion.Dominio_Id
left join genEntidadesBasicasValor DescTipoDeduccion on DescTipoDeduccion.Clave=sueConceptos.TipoDeduccion and DescTipoDeduccion.Entidad_Id = 1516 and genInstalacion.Dominio_Id = DescTipoDeduccion.Dominio_Id
left join genEntidadesBasicasValor DescTipoOtro on DescTipoOtro.Clave=sueConceptos.TipoOtro and DescTipoOtro.Entidad_Id = 1518 and genInstalacion.Dominio_Id = DescTipoOtro.Dominio_Id
WHERE (Concepto_Id = @pConcepto_Id)

select sueConceptosProp.Propiedad, sueConceptosProp.Descripcion as DescripcionPropiedad, sueConceptosProp.Orden, sueConceptosProp.Agrupamiento, 
sueConceptosPropValor.SiNo from sueConceptosProp
left join sueConceptos on sueConceptos.Concepto_Id=@pConcepto_Id
left join sueConceptosPropValor on sueConceptosPropValor.Propiedad=sueConceptosProp.sueConceptosProp and sueConceptosPropValor.Concepto_Id=sueConceptos.sueConceptos
 


Declare @pidentity bigint= dbo.FuncFKsueConceptos(@pConcepto_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueConceptos'
RETURN @@Error 

GO

DROP PROCEDURE sueConceptosEliminar
GO
CREATE PROCEDURE sueConceptosEliminar
(
@pConcepto_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueConceptos 
WHERE (Concepto_Id = @pConcepto_Id)
 
RETURN @@Error 

GO

DROP FUNCTION FuncFKsueConceptos
GO

CREATE FUNCTION FuncFKsueConceptos
(
@pConcepto_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueConceptos FROM sueConceptos WHERE 
	Concepto_Id = @pConcepto_Id
  RETURN @pIdentity
END


GO
