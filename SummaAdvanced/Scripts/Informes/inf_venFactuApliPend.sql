--Exec inf_venFactuApliPend '', 'zzz', 1

Drop procedure inf_venFactuApliPend
Go
Create procedure inf_venFactuApliPend
(
@ClienteDesde VarChar(15),
@ClienteHasta VarChar(15),
@Empresa_Id INT
)
As
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Factura, conAsientos.Fecha FechaFactura, venClientes.Cliente_Id, venClientes.RazonSocial,
genMovCuotas.CuotaNro, genMovCuotas.FechaVencimiento, genMovCuotas.Importe, genMovCuotas.Saldo,
dbo.Segmento(genAsiSegmentosCob.Segmento_Id, genAsiSegmentosCob.Segmento1C, genAsiSegmentosCob.Segmento2C,
genAsiSegmentosCob.Segmento3C, genAsiSegmentosCob.Segmento4C, genAsiSegmentosCob.Segmento1N, genAsiSegmentosCob.Segmento2N,
genAsiSegmentosCob.Segmento3N, genAsiSegmentosCob.Segmento4N) Cobranza, conAsientosCob.Fecha
From venMovimientos
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
Inner Join genMovCuotas On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
Inner Join venClientes On venClientes.genEntidades = venMovimientos.Cliente_Id
Left Join (genCancMov
	Inner Join conAsientos conAsientosCob On conAsientosCob.conAsientos = genCancMov.Asiento_Id_Ap
	Inner Join genAsiSegmentos genAsiSegmentosCob On genAsiSegmentosCob.Asiento_Id = conAsientosCob.conAsientos
	) On genCancMov.Asiento_Id = venMovimientos.venMovimientos And genCancMov.CuotaNro = genMovCuotas.CuotaNro
Where venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta And
conAsientos.Empresa_Id = @Empresa_Id And
conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
isNull(conAsientosCob.Anulado, 0) = 0 And isNull(conAsientosCob.Posteado, 1) = 1 And
Exists (Select 1 From genMovCuotas Cuotas Where Cuotas.Asiento_Id = venMovimientos.venMovimientos And CuotaNro > 1)
Order By 2, 1, 5
