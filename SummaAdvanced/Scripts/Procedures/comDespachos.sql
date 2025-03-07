DROP PROCEDURE comDespachosGuardar
GO
CREATE PROCEDURE comDespachosGuardar
(
@pEmpresa_Id int,
@pDespacho_Id varchar(20),
@pDespacho_Id_Nuevo varchar(20),
@pOrigen varchar(35) = NULL,
@pAduana varchar(35) = NULL,
@pFecha qFecha = NULL,
@pUsuario_Id int, 
@pAduana_Id Char(2)=NULL,
@pAnio Char(2)=NULL,
@pPatente Char(4)=NULL,
@pPedimento NUMERIC(7,0)=NULL, 
@pCambio Numeric(18,4), 
@pMoneda_Id VarChar(5), 
@pTomaCambioTes Bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comDespachos WHERE (Despacho_Id = @pDespacho_Id)))
BEGIN 
	UPDATE comDespachos
	SET	@lIdentidad = comDespachos,
		Empresa_Id = @pEmpresa_Id,
		Despacho_Id = @pDespacho_Id_Nuevo,
		Origen = @pOrigen,
		Aduana = @pAduana,
		Fecha = @pFecha,
		Usuario_Id = @pUsuario_Id, 
		Aduana_Id =@pAduana_Id, 
		Anio = @pAnio, 
		Patente = @pPatente,
		Pedimento = @pPedimento, 
		Cambio = @pCambio , 
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id), 
		TomaCambioTes = @pTomaCambioTes
	WHERE (Despacho_Id = @pDespacho_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comDespachos
	(
		Empresa_Id,
		Despacho_Id,
		Origen,
		Aduana,
		Fecha,
		Usuario_Id, 
		Aduana_Id, 
		Anio,
		Patente, 
		Pedimento, 
		Cambio, 
		Moneda_Id ,
		FechaModificacion, 
		TomaCambioTes
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pDespacho_Id,
		@pOrigen,
		@pAduana,
		@pFecha,
		@pUsuario_Id,
		@pAduana_Id, 
		@pAnio, 
		@pPatente, 
		@pPedimento,
		@pCambio,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FechaActual(), 
		@pTomaCambioTes
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comDespachosDatos
GO
CREATE PROCEDURE comDespachosDatos
(
@pDespacho_Id varchar(20)
)
AS
SET NOCOUNT ON 

SELECT comDespachos.comDespachos, comDespachos.Empresa_Id, comDespachos.Despacho_Id, comDespachos.Origen,
	comDespachos.Aduana, comDespachos.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	comDespachos.Aduana_Id, comDespachos.Anio, comDespachos.Patente, comDespachos.Pedimento, 
		comDespachos.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
		comDespachos.FechaModificacion, comDespachos.TomaCambioTes
FROM comDespachos 
Inner JOIN genUsuarios  ON (genUsuarios.genUsuarios = comDespachos.Usuario_Id)
inner join genMonedas on genMonedas.genMonedas = comDespachos.Moneda_Id
WHERE (Despacho_Id = @pDespacho_Id)
 
 Declare @pidentity bigint= dbo.FuncFKcomDespachos(@pDespacho_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comDespachos'
 RETURN @@Error 

GO

DROP PROCEDURE comDespachosEliminar
GO
CREATE PROCEDURE comDespachosEliminar
(
@pDespacho_Id varchar(20)
)
AS
SET NOCOUNT ON 

DELETE FROM comDespachos 
WHERE (Despacho_Id = @pDespacho_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomDespachos
GO

CREATE FUNCTION FuncFKcomDespachos
(
@pDespacho_Id varchar (20)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comDespachos FROM comDespachos WHERE 
	Despacho_Id = @pDespacho_Id
  RETURN @pIdentity
END


GO
