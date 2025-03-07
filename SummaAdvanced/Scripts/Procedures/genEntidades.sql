Drop Procedure genEntidadesGuardar
GO
Create Procedure genEntidadesGuardar
(
@pgenEntidades bigint,
@pFechaAlta qFechaHora, 
@pUsuario_Id int, 
@pCuit varchar(25) , 
@pTipoDoc char(1),
@pidFiscal varchar(25)
) 
AS 
if (@pgenEntidades > 0)

BEGIN 
	UPDATE genEntidades SET 
	FechaAlta = @pFechaAlta, 
	Usuario_Id = @pUsuario_Id, 
	Cuit = @pCuit , 
	TipoDoc = @pTipoDoc,
	idFiscal = @pidFiscal
	WHERE 
	genEntidades.genEntidades = @pGenEntidades
END 
ELSE
BEGIN
	INSERT INTO  genEntidades
	(FechaAlta , 
	Usuario_Id , 
	Cuit,
	TipoDoc,
	idFiscal ) 
	Values 
	(@pFechaAlta , 
	@pUsuario_Id , 
	@pCuit, 
	@pTipoDoc,
	@pidFiscal ) 
	SET @pgenEntidades =  Cast(SCOPE_IDENTITY() as bigint) 
END

SELECT @pgenEntidades AS RetVal



GO
Drop Procedure genEntidadesDatos
GO
CREATE PROCEDURE genEntidadesDatos(
@pgenEntidades bigint
)
AS
SELECT genEntidades.genEntidades, genEntidades.FechaAlta, genEntidades.Usuario_Id, 
genEntidades.Cuit, genEntidades.TipoDoc, genEntidades.idFiscal, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
IsNull(venVendedores.Vendedor_Id, '') Vendedor_Id, IsNull(venVendedores.Nombre, '') VenNombre,
IsNull(venCobradores.Cobrador_Id, '') Cobrador_Id, IsNull( venCobradores.Nombre, '') CobNombre,
IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre
 FROM genEntidades
 INNER JOIN genUsuarios	ON genUsuarios.genUsuarios=genEntidades.Usuario_Id
 Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
 Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
 Left Outer Join venVendedores On venVendedores.venVendedores = genEntidades.genEntidades
 Left Outer Join venCobradores On venCobradores.venCobradores = genEntidades.genEntidades
 Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
 Where 
 genEntidades.genEntidades = @pgenEntidades
GO

Drop Procedure genEntidadesDatosCuit
Go
Create Procedure genEntidadesDatosCuit(
@pCuit varChar(25),
@pTipoDoc char(1),
@pidFiscal varChar(20)
)
As
SELECT genEntidades.genEntidades, genEntidades.FechaAlta, genEntidades.Usuario_Id, 
genEntidades.Cuit, genEntidades.TipoDoc, genEntidades.idFiscal, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
IsNull(venVendedores.Vendedor_Id, '') Vendedor_Id, IsNull(venVendedores.Nombre, '') VenNombre,
IsNull(venCobradores.Cobrador_Id, '') Cobrador_Id, IsNull( venCobradores.Nombre, '') CobNombre,
IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre
 FROM genEntidades
 INNER JOIN genUsuarios	ON genUsuarios.genUsuarios=genEntidades.Usuario_Id
 Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
 Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
 Left Outer Join venVendedores On venVendedores.venVendedores = genEntidades.genEntidades
 Left Outer Join venCobradores On venCobradores.venCobradores = genEntidades.genEntidades
 Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
 Where genEntidades.Cuit = @pCuit And genEntidades.TipoDoc = @pTipoDoc And genEntidades.IdFiscal = @pidFiscal
 Go

Drop Procedure genEntidadesEliminar
GO
Create Procedure genEntidadesEliminar(
@pgenEntidades bigint 
) 
AS 
SET NOCOUNT ON  
DELETE FROM genEntidades 
	 Where 
 genEntidades.genEntidades = @pgenEntidades
 RETURN @@Error 

GO

Drop Procedure genEntidadesDatosTipoyCuit
Go
Create Procedure genEntidadesDatosTipoyCuit
(
@pCuit varChar(25),
@pTipoDoc char(1)
)
As
SELECT genEntidades.genEntidades, genEntidades.FechaAlta, genEntidades.Usuario_Id, 
genEntidades.Cuit, genEntidades.TipoDoc, genEntidades.idFiscal, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
IsNull(venVendedores.Vendedor_Id, '') Vendedor_Id, IsNull(venVendedores.Nombre, '') VenNombre,
IsNull(venCobradores.Cobrador_Id, '') Cobrador_Id, IsNull( venCobradores.Nombre, '') CobNombre,
IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre
 FROM genEntidades
 INNER JOIN genUsuarios	ON genUsuarios.genUsuarios=genEntidades.Usuario_Id
 Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
 Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
 Left Outer Join venVendedores On venVendedores.venVendedores = genEntidades.genEntidades
 Left Outer Join venCobradores On venCobradores.venCobradores = genEntidades.genEntidades
 Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
 Where genEntidades.Cuit = @pCuit And genEntidades.TipoDoc = @pTipoDoc
 Go
	