DROP PROCEDURE stkCOTArLimites
GO
CREATE PROCEDURE stkCOTArLimites
(
@pEmpresa_id int
)
AS
SELECT (SELECT nValor FROM genGlobales WHERE Nombre_Var = 'STKCOTLIMITE1' AND 
Empresa_Id = @pEmpresa_id) CotLimiteKG, 
(SELECT nValor FROM genGlobales WHERE Nombre_Var = 'STKCOTLIMITE2' AND 
Empresa_Id = @pEmpresa_id) CotLimitePES,
(SELECT cValor FROM genGlobales WHERE Nombre_Var = 'STKCODKILOGRAMOS' AND 
Empresa_Id = @pEmpresa_id) CodKilos, 
(SELECT nValor FROM genGlobales WHERE Nombre_Var = 'STKCOTATRI' AND
Empresa_Id = @pEmpresa_id) Atributo
GO




