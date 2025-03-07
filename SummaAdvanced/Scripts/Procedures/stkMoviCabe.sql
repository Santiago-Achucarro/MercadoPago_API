-- exec stkMoviCabeDatos 1, 'STK',1,0,0,0,'E','0001','',''
-- exec stkMoviCabeDatosCausa 1, 'STK',1,0,0,0,'E','0001','',''

DROP PROCEDURE stkMoviCabeGuardar
GO
CREATE PROCEDURE stkMoviCabeGuardar
(
@pstkMoviCabe bigint, 
@pSubTipoMov_Id varchar(5),
@pModificaCosto Sino,
@pSigno smallint
)
AS
SET NOCOUNT ON 


SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCabe WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviCabe
	SET		SubTipoMov_Id = @pSubTipoMov_Id,
		ModificaCosto = @pModificaCosto,
		Signo = @pSigno
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviCabe
	(
		stkMoviCabe,
		SubTipoMov_Id,
		ModificaCosto,
		Signo
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pSubTipoMov_Id,
		@pModificaCosto,
		@pSigno
	)
END 

GO

DROP PROCEDURE stkMoviCabeSoloDatos
GO
CREATE PROCEDURE stkMoviCabeSoloDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 
	
SELECT stkMoviCabe.stkMoviCabe,
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, Cast(0 As Bit) DistribuyeContrapartida,
	conAsientos.Posteado, conAsientos.Fecha, conAsientos.FechaRegistro, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones,  disFormularios.Formulario_Id Formulario,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	stkMoviCabe.ModificaCosto, 	stkMoviCabe.Signo, stkSubTipoMov.Tipomov, ' ' as Proveed_Id, ' ' Cliente_Id, 
		' ' Sucursal
FROM stkMoviCabe 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = stkMoviCabe.stkMoviCabe)
INNER JOIN stkSubTipoMov  ON (stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
WHERE (stkMoviCabe = @pstkMoviCabe)
go


DROP PROCEDURE stkMoviCabeDatos
GO
CREATE PROCEDURE stkMoviCabeDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

Exec stkMoviCabeSoloDatos @pStkmoviCabe
	
Exec stkMoviCuerpoDatos @pstkMoviCabe

Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 

Exec stkMoviSerieDatos @pstkMoviCabe

Exec stkMoviDespaDatos @pstkMoviCabe
-- PARA V2
Exec stkMoviUbicacionDatos  @pStkMoviCabe

 
RETURN @@Error 

GO




DROP PROCEDURE stkMoviCabeEliminar
GO
CREATE PROCEDURE stkMoviCabeEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCabe 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO
DROP PROCEDURE stkMoviCabeDatosProv 
GO
CREATE PROCEDURE stkMoviCabeDatosProv
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
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
Declare @pstkMoviCabe bigint = (select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
EXEC stkMoviCabeDatos @pstkMoviCabe


SELECT stkMoviProv.RemitoProv, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	' ' Cuenta_Id, stkMoviProv.FechaRemito
FROM stkMoviProv 
INNER JOIN comProveedores ON stkMoviProv.Proveed_Id = comProveedores.genEntidades
WHERE stkMoviProv.stkMoviCabe = @pstkMoviCabe

GO	
		

DROP PROCEDURE stkMoviCabeDatosCausa 
GO
CREATE PROCEDURE stkMoviCabeDatosCausa 
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
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
Declare @pstkMoviCabe bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
EXEC stkMoviCabeDatos @pstkMoviCabe

SELECT stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion,
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM stkMoviCausa 
	INNER JOIN stkCausasMovi ON stkMoviCausa.Causa_Id = stkCausasMovi.stkCausasMovi
	INNER JOIN conCuentas ON stkCausasMovi.Cuenta_Id = conCuentas.conCuentas
	LEFT Join conCentro1 On stkMoviCausa.Centro1_Id = conCentro1.conCentro1
	LEFT Join conCentro2 On stkMoviCausa.Centro2_Id = conCentro2.conCentro2
	WHERE
	stkMoviCausa.stkMoviCabe = @pstkMoviCabe 
GO	


DROP PROCEDURE stkMoviCabeDatosSalidasRemito
GO
CREATE PROCEDURE stkMoviCabeDatosSalidasRemito 
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
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
Declare @pstkMoviCabe bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
EXEC stkMoviCabeDatos @pstkMoviCabe

/*
SELECT stkRemitos.stkMoviCabe, venClientes.Cliente_Id, stkRemitos.Sucursal, 
venClientes.RazonSocial, IsNull(gensegmentos.Segmento_Id, '') Segmento_Id,
venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion DescripcionListasPrecios
FROM stkRemitos
Inner Join venClieHabitual On stkRemitos.Cliente_Id = venClieHabitual.genEntidades And
	stkRemitos.Sucursal = venClieHabitual.Sucursal
Inner Join venClientes On venClientes.genEntidades = stkRemitos.Cliente_Id
Inner Join genSegmentos On stkRemitos.Segmento_Id = genSegmentos.genSegmentos
Left Join venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
WHERE (stkMoviCabe = @pstkMoviCabe)
*/
EXEC stkRemitosDatos @pstkMoviCabe

Select stkMoviCausa.stkMoviCabe, Cast(0 As bit) SoloRemito, Cast(1 As bit) PendienteFacturacion,
stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion DescripcionCausa,
conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
From stkMoviCausa
Inner Join stkCausasMovi On stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
Left Join conCentro1 On conCentro1.conCentro1 = stkMoviCausa.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = stkMoviCausa.Centro2_Id
Where stkMoviCausa.stkMoviCabe = @pstkMoviCabe

SELECT CAST(0 AS bit) AceptaDatosExternos
GO

drop procedure stkMoviCabeDatosSeg
go
create procedure stkMoviCabeDatosSeg
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
as
set nocount on
Declare @pstkMoviCabe bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
exec stkMoviCabeDatos @pstkMoviCabe
go