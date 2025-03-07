Drop procedure venMovimientosPreGuardadosDatos
Go
Create procedure venMovimientosPreGuardadosDatos
(
@pEmpresa_Id int
)
As

Select dbo.FechaActual() Fecha, Cast(1 As Bit) RespetaFechaOriginal
 
Select Cast(0 As  bit) Marcado, conAsientos.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial, venMovimientos.Importe,
venMovimientos.venMovimientos, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante,
genSucursalesEmpr.Sucursal SucursalAfip, Case When venMovimientosPreTimbrados.Segmento1N < 0 Then 0 Else venMovimientosPreTimbrados.Segmento1N End ComprobanteAfip, 
venMovimientosPreTimbrados.Comprobante_Id TipoCompAfip,
venMovimientosPreTimbrados.Detalle DetalleAfip, venSubTipoMov.SubTipoMov_Id
From venMovimientos
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join genSucursalesEmpr SucuComprob On SucuComprob.Sucursal = genAsiSegmentos.Segmento2C
Inner Join venClientes On venClientes.genEntidades = venMovimientos.Cliente_Id
Left Join (venMovimientosPreTimbrados Inner Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = venMovimientosPreTimbrados.Sucursal /*And
			venMovimientosPreTimbrados.Segmento1N < 0*/) On venMovimientosPreTimbrados.venMovimientos = venMovimientos.venMovimientos
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And conAsientos.Posteado = 0 
And SucuComprob.FacturaElectronica = 1 And SucuComprob.UsaWS = 1 And SucuComprob.TipoFE = 'FEV1'
Go
