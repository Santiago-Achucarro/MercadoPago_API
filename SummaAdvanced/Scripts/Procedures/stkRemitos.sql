DROP PROCEDURE stkRemitosGuardar
GO
CREATE PROCEDURE stkRemitosGuardar
(
@pstkMoviCabe bigint,
@pCliente_Id varChar(25) = NULL,
@pSucursal SucursalN = NULL,
@pSegmento_Id varchar(10) = NULL,
@pListaPrecio_Id varChar(5) = Null,
@pHojaRuta_Id int = null, 
@pFormaEntrega_Id VarChar(5) = Null
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkRemitos WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkRemitos
	SET	Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Sucursal = @pSucursal,
		Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id),
		ListaPrecio_Id = @pListaPrecio_Id,
		HojaRuta_Id = @pHojaRuta_Id, 
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkRemitos
	(
		stkMoviCabe,
		Cliente_Id,
		Sucursal,
		Segmento_Id,
		ListaPrecio_Id,
		HojaRuta_Id,
		FormaEntrega_Id
	)
	VALUES 
	(
		@pstkMoviCabe,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pSucursal,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		@pHojaRuta_Id,
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id)
	)
END 

GO


DROP PROCEDURE stkRemitosEliminar
GO
CREATE PROCEDURE stkRemitosEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkRemitos 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO


DROP PROCEDURE stkRemitosDatos
GO
CREATE PROCEDURE stkRemitosDatos
(
@pstkMoviCabe bigint
)
AS
SELECT stkRemitos.stkMoviCabe, venClientes.Cliente_Id, stkRemitos.Sucursal, 
venClientes.RazonSocial, IsNull(gensegmentos.Segmento_Id, '') Segmento_Id,
venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion DescripcionListasPrecios,
genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, stkRemitos.HojaRuta_Id,
dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C,
stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, 
stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N) HojaRuta, 
venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega, 
venCamiones.Patente_Id Camion_Id, Remolque1.Patente_Id as Remolque1, Remolque2.Patente_Id as Remolque2, 
	(SELECT MIN(FechaHoraSalida) from venCompCartaPorteOrigen 
	where
		venCompCartaPorteOrigen.venmovimientos = stkRemitos.stkMoviCabe) as FechaHoraSalida, 
	(SELECT MAX(FechaHoraProgLlegada) from venCompCartaPorteDestino
	where
		venCompCartaPorteDestino.venmovimientos = stkRemitos.stkMoviCabe) as FechaHoraProgLlegada, 
		venOperadores.Operador_Id, venOperadores.NombreOperador, venCompCartaPorte.TotalDistRec

FROM stkRemitos
Inner Join venClieHabitual On stkRemitos.Cliente_Id = venClieHabitual.genEntidades And
	stkRemitos.Sucursal = venClieHabitual.Sucursal
Inner Join venClientes On venClientes.genEntidades = stkRemitos.Cliente_Id
Inner Join genSegmentos On stkRemitos.Segmento_Id = genSegmentos.genSegmentos
Left Join venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
Left Join genMonedas On genMonedas.genMonedas = venListasPrecios.Moneda_Id
Left Join stkHojaSegmentos On stkHojaSegmentos.stkHojaDeRuta = stkRemitos.HojaRuta_Id
Left Join venFormaEntrega ON  venFormaEntrega.venFormaEntrega = stkRemitos.FormaEntrega_Id
Left join venCompCartaPorte ON venCompCartaPorte.venMovimientos= stkRemitos.stkMoviCabe
left join venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
left join venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
left join venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
LEFT JOIN  venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
WHERE (stkMoviCabe = @pstkMoviCabe)
Go


Drop procedure stkRemitosAsignarHR
GO
Create procedure stkRemitosAsignarHR
(
@pstkMoviCabe bigint,
@pstkHojaDeRuta int
)
As
Update stkRemitos Set HojaRuta_Id = @pstkHojaDeRuta Where stkMoviCabe = @pstkMoviCabe
Go

Drop procedure stkRemitosDesasignarHR
Go
Create procedure stkRemitosDesasignarHR
(
@pstkHojaDeRuta int, 
@pstkMoviCabe bigint = null
)
As
Update stkRemitos Set HojaRuta_Id = Null Where HojaRuta_Id = @pstkHojaDeRuta and 
	stkMoviCabe = ISNULL(@pstkMoviCabe,stkMoviCabe)
Go
