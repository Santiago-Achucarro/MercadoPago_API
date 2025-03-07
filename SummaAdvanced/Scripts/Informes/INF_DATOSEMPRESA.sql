
DROP PROCEDURE INF_DATOSEMPRESA  
GO
CREATE PROCEDURE INF_DATOSEMPRESA 
(	
	@pEmpresa_Id INT, 
	@pUsuario_Id Int= NULL
)
	
AS

SELECT genEmpresas, genEmpresas.Empresa_Id, Detalle, ExtensionArchivo,genMonedas.Moneda_Id,genPaises.Descripcion as Pais_Id, Cuit,Calle,NoExterior,NoInterior,Colonia,Localidad,
Municipio,Referencia, genProvincias.Descripcion as Provincia_Id, CodigoPostal,FechaInicioSumma,FechaInicioSociedad,NumeroIIBB,IGJ,Actividad,
Regimen,Telefono,genEmpresas.Usuario_Id,genEmpresas.Inactivo,logo,CarpetaEspecial,UsaCantidadAlterna,UsaDespachoImportacion,UsaSerie,
CtaMercaEnTransitoImpor,RazonSocial,FechaCierreVentas,FechaCierreTesoreria,FechaCierreStock,TipoCosto,TipoCosto2,TipoCosto3,
CodLocalidad,CodColonia,CodMunicipio,CondFiscal,PaginaWeb, 
	genInstalacion.Dominio_Id, genMonedas.Descripcion as DescripcionMoneda, genMonedas.Simbolo, 
	ISNULL(genEmpresas.CuentasDeposito,' ') AS CuentasDeposito, genEmpresas.Correo, 
	ISNULL(genUsuarios.Usuario_Id,' ') as Usuario_Id1, genEmpresas.FirmaSUE, genEmpresas.ImagenFirmaB64SUE, 
	genEmpresas.FirmaTES, genEmpresas.ImagenFirmaB64TES
FROM genEmpresas 
inner join genPaises on genPaises.genPaises=genEmpresas.Pais_Id
inner join genProvincias on genProvincias.genProvincias=genEmpresas.Provincia_Id
inner join genMonedas on genMonedas.genMonedas=genEmpresas.Moneda_Id
Cross join genInstalacion
Left join genUsuarios ON genUsuarios.genUsuarios = @pUsuario_Id
where genEmpresas = @pEmpresa_Id
GO


