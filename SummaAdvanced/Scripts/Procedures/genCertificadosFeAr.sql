DROP PROCEDURE genCertificadosFeArDatos
GO
CREATE PROCEDURE genCertificadosFeArDatos
(
	@Empresa_Id int
) AS
SELECT (SELECT mValor  FROM genGlobales where
	Nombre_Var = 'GENWSAAPRIVATEKEY' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENWSAAPRIVATEKEY,
(SELECT mValor  FROM genGlobales where
	Nombre_Var = 'GENWSAAPUBLICKEY' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENWSAAPUBLICKEY, 
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'EMPDIRPDFFACT' AND Empresa_Id = genEmpresas.genEmpresas ) AS EMPDIRPDFFACT,
(SELECT fValor  FROM genGlobales where
	Nombre_Var = 'GENWSFECHAVENC' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENWSFECHAVENC

FROM genEmpresas 
WHERE
genEmpresas.genEmpresas = @Empresa_Id
GO






