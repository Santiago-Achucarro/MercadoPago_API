DROP PROCEDURE stkCOTArGuardar
GO
CREATE PROCEDURE stkCOTArGuardar
(
@pEmpresa_Id int,
@lIdentity int,
@pUsuario_Id int = NULL,
@pCot varchar(Max)
)
AS
SET NOCOUNT ON 

DECLARE @lProvincia INT = (SELECT genSucursalesEmpr.Provincia_Id 
FROM genUsuarios
INNER JOIN genSucursalesEmpr ON genUsuarios.Sucursal = genSucursalesEmpr.genSucursalesEmpr
WHERE genUsuarios.genUsuarios = @pUsuario_Id)

DECLARE @lCotLimiteKG NUMERIC(14,2) = (SELECT nValor FROM genGlobales WHERE Nombre_Var = 'STKCOTLIMITE1' AND 
Empresa_Id = @pEmpresa_id) 

DECLARE @lCotLimitePES NUMERIC(14,2) = (SELECT nValor FROM genGlobales WHERE Nombre_Var = 'STKCOTLIMITE2' AND 
Empresa_Id = @pEmpresa_id) 

BEGIN 

INSERT INTO stkCOTAr
(
	stkHojaDeRuta,
	Provincia_Id,
	Peso,
	Importe,
	COT
)
VALUES 
(
	@lIdentity,
	@lProvincia,
	@lCotLimiteKG,
	@lCotLimitePES,
	@pCot
)
END
SELECT @lIdentity AS RetVal 
GO

DROP PROCEDURE stkCOTArDatos
GO
CREATE PROCEDURE stkCOTArDatos
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT stkCOTAr.stkHojaDeRuta, genProvincias.genProvincias, genProvincias.Provincia_Id,
genProvincias.Descripcion, stkCOTAr.Importe, stkCOTAr.Peso, stkCOTAr.COT
FROM stkCOTAr 
INNER JOIN genProvincias ON stkCOTAr.Provincia_Id = genProvincias.genProvincias
WHERE stkCOTAr.stkHojaDeRuta = @lIdentity
GO
