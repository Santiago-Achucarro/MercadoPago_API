DROP PROCEDURE genTipoCambioGuardar
GO
CREATE PROCEDURE genTipoCambioGuardar
(
@pMoneda_Id VarChar(3),
@pFecha qFecha,
@pEmpresa_Id int = NULL,
@pCambioCompra qMonedaD8,
@pCambioVenta qMonedaD8,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTipoCambio WHERE (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)) AND (Fecha = @pFecha) and 
	Empresa_id = isnull(@pEmpresa_Id,Empresa_id) ))
BEGIN 
	UPDATE genTipoCambio
	SET		Empresa_Id = @pEmpresa_Id,
		CambioCompra = @pCambioCompra,
		CambioVenta = @pCambioVenta,
		Usuario_Id = @pUsuario_Id
	WHERE (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)) AND (Fecha = @pFecha) and Empresa_id = isnull(@pEmpresa_Id,Empresa_id)
END 
ELSE 
BEGIN 
	INSERT INTO genTipoCambio
	(
		Moneda_Id,
		Fecha,
		Empresa_Id,
		CambioCompra,
		CambioVenta,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pFecha,
		@pEmpresa_Id,
		@pCambioCompra,
		@pCambioVenta,
		@pUsuario_Id
	)
END 
GO

DROP PROCEDURE genTipoCambioDatos
GO
CREATE PROCEDURE genTipoCambioDatos
(
@pMoneda_Id VarChar(3),
@pFecha qFecha, 
@pEmpresa_Id int 
)
AS
SET NOCOUNT ON 

SET @pFecha = DATEADD(dd, ISNULL((SELECT nValor from genGlobales where Nombre_Var = 'GENDIASCAMBIO' AND Empresa_Id = @pEmpresa_Id),0),@pFecha)

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, genTipoCambio.Fecha, genTipoCambio.Empresa_Id,
	Cast( Case When genTipoCambio.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, genTipoCambio.CambioCompra, genTipoCambio.CambioVenta, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM genTipoCambio 
INNER JOIN genMonedas  ON (genMonedas.genMonedas = genTipoCambio.Moneda_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genTipoCambio.Usuario_Id)
WHERE genMonedas.Moneda_Id = @pMoneda_Id and 
isnull(genTipoCambio.Empresa_Id, @pEmpresa_id) =@pEmpresa_id  AND 
genTipoCambio.Fecha = (SELECT MAX(Fecha) from genTipoCambio genTipoCambio1 where
		genTipoCambio1.Moneda_id =   dbo.FuncFKgenMonedas(@pMoneda_Id) and 
		isnull(genTipoCambio1.Empresa_Id, @pEmpresa_id) =@pEmpresa_id and 
		genTipoCambio1.Fecha <= @pFecha)

		
 
 RETURN @@Error 

GO

DROP PROCEDURE genTipoCambioEliminar
GO
CREATE PROCEDURE genTipoCambioEliminar
(
@pMoneda_Id varchar(3),
@pFecha qFecha,
@pEmpresa_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genTipoCambio 
WHERE (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))
AND Fecha = @pFecha AND 
Empresa_id = isnull(@pEmpresa_Id,Empresa_id)
 
 RETURN @@Error 

GO

DROP PROCEDURE genTipoCambioPostDatos
GO
CREATE PROCEDURE genTipoCambioPostDatos
(
@pMoneda_Id VarChar(3),
@pFecha qFecha, 
@pEmpresa_Id int 
)
AS
SET NOCOUNT ON 

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, genTipoCambio.Fecha, genTipoCambio.Empresa_Id,
	Cast( Case When genTipoCambio.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, genTipoCambio.CambioCompra, genTipoCambio.CambioVenta, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM genTipoCambio 
INNER JOIN genMonedas  ON (genMonedas.genMonedas = genTipoCambio.Moneda_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genTipoCambio.Usuario_Id)
WHERE genMonedas.Moneda_Id = @pMoneda_Id and 
isnull(genTipoCambio.Empresa_Id, @pEmpresa_id) = @pEmpresa_id AND 
genTipoCambio.Fecha = (SELECT Min(Fecha) from genTipoCambio genTipoCambio1 where
		genTipoCambio1.Moneda_id = dbo.FuncFKgenMonedas(@pMoneda_Id) and 
		isnull(genTipoCambio1.Empresa_Id, @pEmpresa_id) = @pEmpresa_id and 
		genTipoCambio1.Fecha >= @pFecha)
 
 RETURN @@Error 

GO
