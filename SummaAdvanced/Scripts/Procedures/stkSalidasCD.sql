drop procedure stkSalidasCDDatos
go
create procedure stkSalidasCDDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec stkMoviCabeDatos @pstkMoviCabe

select stkEnTransito.stkMoviCabe,stkEnTransito.stkMoviCabeEntr,stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito
from stkEnTransito inner join stkDepositos on stkEnTransito.Deposito_Id=stkDepositos.stkDepositos
where stkEnTransito.stkMoviCabe=@pstkMoviCabe

select genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C from stkSolicitudCDSalida 
inner join stkSolicitudCDSegmento on stkSolicitudCDSegmento.stkSolicitudCD=stkSolicitudCDSalida.stkSolicitudCD
inner join genSegmentos on genSegmentos.genSegmentos=stkSolicitudCDSegmento.Segmento_Id
where stkMoviCabe=@pstkMoviCabe


-- SI USA REMITO TRAIGO LOS DATOS PARA LA CARTA PORTE
SELECT Cast(Case when stkRemitos.stkMoviCabe IS NULL THEN 0 ELSE 1 END as Bit) as GeneraRemito,
venCompCartaPorte.venmovimientos, venCompCartaPorte.TranspInternac, venCompCartaPorte.EntradaSalidaMerc, venCompCartaPorte.ViaEntradaSalida, 
	venCompCartaPorte.TotalDistRec, venCompCartaPorte.PesoBrutoTotal, venCompCartaPorte.UnidadPeso, venCompCartaPorte.PesoNetoTotal, 
	venCompCartaPorte.CargoPorTasacion, venCamiones.Patente_Id as Camion_Id, Remolque1.Patente_Id as Remolque1, 
	Remolque2.Patente_Id as Remolque2, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega, 
	venOperadores.Operador_Id, venOperadores.NombreOperador, 
	(select min(venCompCartaPorteOrigen.FechaHoraSalida) from venCompCartaPorteOrigen
		where
		venCompCartaPorteOrigen.venmovimientos = venCompCartaPorte.venmovimientos)  FechaHoraSalida,
	(select MAX(venCompCartaPorteDestino.FechaHoraProgLlegada) from venCompCartaPorteDestino
		where
		venCompCartaPorteDestino.venmovimientos = venCompCartaPorte.venmovimientos) FechaHoraProgLlegada

From stkRemitos
	left JOIN (venCompCartaPorte INNER JOIN 
			venCamiones ON venCamiones.venCamiones = venCompCartaPorte.Camion_Id
			LEFT JOIN venCamiones as Remolque1 ON Remolque1.venCamiones = venCompCartaPorte.Remolque1
			LEFT JOIN venCamiones as Remolque2 ON Remolque2.venCamiones = venCompCartaPorte.Remolque2
			LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
			) ON 
	stkRemitos.stkMoviCabe = venCompCartaPorte.venmovimientos
	LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = stkRemitos.FormaEntrega_Id
	where  stkRemitos.stkMoviCabe=@pstkMoviCabe

-- FM 18/03/2022 Estos 2 últimos Select los agregué a mano porque al rehacer el DS desaparecieron --

-- DT OrdenProd --
Select '' Segmento_Id, 0 Segmento1N, 0 Segmento2N, 0 Segmento3N, 0 Segmento4N, '' Segmento1C, '' Segmento2C, '' Segmento3C, '' Segmento4C

-- DT Descargas --
Select '' Archivo, '' Extension
go
