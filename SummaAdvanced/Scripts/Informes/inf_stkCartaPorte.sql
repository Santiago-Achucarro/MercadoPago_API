drop procedure inf_stkCartaPorte
go
create procedure inf_stkCartaPorte
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

SELECT venCamiones.Patente_Id as Camion_Id,  venCamiones.ConfVehicular, venCamiones.Marca, venCamiones.Modelo, 
	venCamiones.NroPermisoSCT, venCamiones.NroPoliza, venCamiones.NombreAseg,
	ISNULL(Remolque1.Patente_Id,'') Remolque1, Remolque1.Marca MarcaR1, Remolque1.Modelo ModeloR1, Remolque1.ConfVehicular ConfVehicularR1,
	ISNULL(Remolque2.Patente_Id,'') Remolque2, Remolque2.Marca MarcaR2, Remolque2.Modelo ModeloR2, Remolque2.ConfVehicular ConfVehicularR2,
	venOperadores.Operador_Id, venOperadores.RfcOperador, venOperadores.NombreOperador, 
	venOperadores.NumLicencia, venOperadores.Calle, venOperadores.NumeroExterior, venOperadores.Numerointerior, 
	venOperadores.Colonia, venOperadores.Localidad, venOperadores.Municipio, venOperadores.Estado, genPaises.CodFiscal Pais
FROM venCompCartaPorte 
	inner join venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	left join venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
	left join venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
	inner join venOperadores ON venOperadores.venOperadores =venCompCartaPorte.Operador_Id
	INNER JOIN genPaises ON genPaises.genPaises = venOperadores.Pais
WHERE 
	venCompCartaPorte.venmovimientos = @pstkMoviCabe


go



drop procedure inf_stkCartaPorteOrigenes
go
create procedure inf_stkCartaPorteOrigenes
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

select  venCompCartaPorteOrigen.venMovimientos, venCompCartaPorteOrigen.Ubicacion, venCompCartaPorteOrigen.idOrigen, 
venCompCartaPorteOrigen.RFCRemitente, venCompCartaPorteOrigen.NombreRemitente, 
venCompCartaPorteOrigen.NumRegIdTrib, genPaises.CodFiscal as ResidenciaFiscal, venCompCartaPorteOrigen.NumEstacion, 
venCompCartaPorteOrigen.FechaHoraSalida, venCompCartaPorteOrigen.Calle, venCompCartaPorteOrigen.NumeroExterior, 
venCompCartaPorteOrigen.Numerointerior, venCompCartaPorteOrigen.Colonia as c_Colonia, 
	isnull(genColonias.NombreAsentamiento,'') as NombreAsentamiento, 
	venCompCartaPorteOrigen.Localidad as c_Localidad, ISNULL(genlocalidades.Descripcion,'') AS Localidad, 
	venCompCartaPorteOrigen.Municipio as c_Municipio, ISNULL(genMunicipios.Descripcion,'')  as Municipio,
	venCompCartaPorteOrigen.Estado, venCompCartaPorteOrigen.CodigoPostal, 
	genPaisesD.Descripcion Pais
from venCompCartaPorteOrigen
	inner join  genPaises on  genPaises.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	left join genColonias on  genColonias.c_Colonia = venCompCartaPorteOrigen.Colonia and 
		venCompCartaPorteOrigen.CodigoPostal = genColonias.c_CodigoPostal
	left join  genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteOrigen.Localidad and 
		genlocalidades.c_Estado = venCompCartaPorteOrigen.Estado
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteOrigen.Municipio and
		genMunicipios.c_Estado = venCompCartaPorteOrigen.Estado
	inner join  genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteOrigen.Pais
where 
venCompCartaPorteOrigen.venMovimientos = @pstkMoviCabe


go


drop procedure inf_stkCartaPorteDestinos
go
create procedure inf_stkCartaPorteDestinos
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

select  venCompCartaPorteDestino.venMovimientos, venCompCartaPorteDestino.Ubicacion, venCompCartaPorteDestino.IdDestino, 
venCompCartaPorteDestino.RFCDestinatario, venCompCartaPorteDestino.NombreDestinatario, 
venCompCartaPorteDestino.NumRegIdTrib, genPaises.CodFiscal as ResidenciaFiscal, venCompCartaPorteDestino.NumEstacion, 
venCompCartaPorteDestino.FechaHoraProgLlegada, venCompCartaPorteDestino.Calle, venCompCartaPorteDestino.NumeroExterior, 
venCompCartaPorteDestino.Numerointerior, venCompCartaPorteDestino.Colonia as c_Colonia, 
	isnull(genColonias.NombreAsentamiento,'') as NombreAsentamiento, 
	venCompCartaPorteDestino.Localidad as c_Localidad, ISNULL(genlocalidades.Descripcion,'') AS Localidad, 
	venCompCartaPorteDestino.Municipio as c_Municipio, ISNULL(genMunicipios.Descripcion,'')  as Municipio,
	venCompCartaPorteDestino.Estado, venCompCartaPorteDestino.CodigoPostal, 
	genPaisesD.Descripcion Pais
from venCompCartaPorteDestino
	inner join  genPaises on  genPaises.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	left join genColonias on  genColonias.c_Colonia = venCompCartaPorteDestino.Colonia and 
		venCompCartaPorteDestino.CodigoPostal = genColonias.c_CodigoPostal
	left join  genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteDestino.Localidad and 
		genlocalidades.c_Estado = venCompCartaPorteDestino.Estado
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteDestino.Municipio and 
		genMunicipios.c_Estado = venCompCartaPorteDestino.Estado
	inner join  genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteDestino.Pais
where 
venCompCartaPorteDestino.venMovimientos = @pstkMoviCabe

go

drop procedure inf_stkCartaPorteCFDI
go
create procedure inf_stkCartaPorteCFDI
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

select ClaveFiscal, Fecha, SelloDigital, FechaString AS FechaTimbrado, SelloFiscal, NoCertificadoFiscal, NoCertificadoPropio, RfcProvCertif 
from  venMovimientosFiscal 
where
	venMovimientos = @pStkMovicabe

go


drop procedure inf_stkCartaPorteCFDIR
go
create procedure inf_stkCartaPorteCFDIR
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

select venMovimientosFiscal.ClaveFiscal, venMovimientosCFDIR.TipoRelacion
from  venMovimientosCFDIR
INNER JOIN  venMovimientosFiscal ON venMovimientosFiscal.venMovimientos =venMovimientosCFDIR.venMovimientosR
where
	venMovimientosCFDIR.venMovimientos = @pStkMovicabe

go
