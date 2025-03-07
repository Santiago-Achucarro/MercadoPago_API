--genCertificadosDatos 1
DROP PROCEDURE genCertificadosDatos
GO
CREATE PROCEDURE genCertificadosDatos
(
	@Empresa_Id int
)
AS
	
SELECT (SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENNOCERTIFICADO' AND Empresa_Id = genEmpresas.genEmpresas ) AS NoCertificado,
(SELECT mValor  FROM genGlobales where
	Nombre_Var = 'GENWSAAPRIVATEKEY' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENWSAAPRIVATEKEY,
(SELECT mValor  FROM genGlobales where
	Nombre_Var = 'GENWSAAPUBLICKEY' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENWSAAPUBLICKEY, 
' ' ClavePubKey  , 
' ' as ArchivoKey, ' ' as ArchivoCer,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENPAC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENPAC, 
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENCLAVEPAC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENCLAVEPAC,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENUSUARIOPAC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENUSUARIOPAC,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENCLAVEPACCANC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENCLAVEPACCANC,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENUSUARIOPACANC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENUSUARIOPACANC,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'EMPDIRPDFFACT' AND Empresa_Id = genEmpresas.genEmpresas ) AS EMPDIRPDFFACT,
cast((SELECT nValor  FROM genGlobales where
	Nombre_Var = 'VENLLAMAPAC' AND Empresa_Id = genEmpresas.genEmpresas ) as Bit) AS VENLLAMAPAC,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'CLAVEPRIVATEKEY' AND Empresa_Id = genEmpresas.genEmpresas ) AS CLAVEPRIVATEKEY,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'VENCLAPFXCANC' AND Empresa_Id = genEmpresas.genEmpresas ) AS VENCLAPFXCANC,
CAST((SELECT nValor  FROM genGlobales where
	Nombre_Var = 'VENCANCCONTRA' AND Empresa_Id = genEmpresas.genEmpresas ) AS Bit) AS VENCANCCONTRA,
(SELECT cValor  FROM genGlobales where
	Nombre_Var = 'GENVERSIONCFDI' AND Empresa_Id = genEmpresas.genEmpresas ) AS GENVERSIONCFDI
	
FROM genEmpresas 
where 
genEmpresas.genEmpresas = @Empresa_Id

GO

