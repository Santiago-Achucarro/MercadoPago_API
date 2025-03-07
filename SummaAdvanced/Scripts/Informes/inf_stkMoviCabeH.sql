drop procedure inf_stkMoviCabeH
go
create procedure inf_stkMoviCabeH
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
	
SELECT stkMoviCabe.stkMoviCabe,dbo.Segmento(genSegmentos.genSegmentos, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as SegmentoSTR, Cast(0 As Bit) DistribuyeContrapartida,
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,  disFormularios.Formulario_Id Formulario,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	stkMoviCabe.ModificaCosto, 	stkMoviCabe.Signo, stkSubTipoMov.Tipomov, ' ' as Proveed_Id, ' ' Cliente_Id,
	disFormularios.Descripcion as DescripcionFormulario, genUsuarios.Apellido_y_Nombres as Usuario
FROM stkMoviCabe 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = stkMoviCabe.stkMoviCabe)
INNER JOIN stkSubTipoMov  ON (stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = stkMoviCabe.stkMoviCabe
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
inner join genUsuarios on genUsuarios.genUsuarios=conAsientos.Usuario_Id
WHERE (stkMoviCabe = @pstkMoviCabe)



go

drop procedure inf_stkMoviCuerpoH
go
create procedure inf_stkMoviCuerpoH
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

	Exec inf_stkMoviCuerpoDatos @pstkMoviCabe
go
drop procedure inf_stkMoviSerieH
go
create procedure inf_stkMoviSerieH
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


	Exec stkMoviSerieDatos @pstkMoviCabe
go
drop procedure inf_stkMoviDespaH
go
create procedure inf_stkMoviDespaH
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

	

Exec stkMoviDespaDatos @pstkMoviCabe
go