DROP PROCEDURE genCancMovGuardar
GO
CREATE PROCEDURE genCancMovGuardar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint,
@pUsuario_Id int,
@pFechaAplicacion qFecha,
@pImporte qMonedaD2, 
@pImporte_Ap qMonedaD2, 
@pAsientoApli_Id bigint = NULL, 
@pImportacion bit, 
@pAsieDifCambio_Id bigint = NULL, 
@pEsVentaContado Bit, 
@pEsAplicOriginal Bit

)
AS
SET NOCOUNT ON 
DECLARE @pNroAplicacion int = ISNULL((SELECT Max(NroAplicacion) FROM genCancMov 
		WHERE (Asiento_Id = @pAsiento_Id) AND 
			(CuotaNro = @pCuotaNro) AND 
			(Asiento_Id_Ap = @pAsiento_Id_Ap) AND 
			(CuotaNro_Ap = @pCuotaNro_Ap)),0)+1

BEGIN 
	INSERT INTO genCancMov
	(
		Asiento_Id,
		CuotaNro,
		Asiento_Id_Ap,
		CuotaNro_Ap,
		NroAplicacion, 
		Usuario_Id,
		FechaAplicacion,
		Importe, 
		Importe_Ap, 
		AsientoApli_Id, 
		Importacion,
		AsieDifCambio_Id, 
		EsVentaContado, 
		EsAplicOriginal
	)
	VALUES 
	(
		@pAsiento_Id,
		@pCuotaNro,
		@pAsiento_Id_Ap,
		@pCuotaNro_Ap,
		@pNroAplicacion, 
		@pUsuario_Id,
		@pFechaAplicacion,
		@pImporte, 
		@pImporte_Ap,
		@pAsientoApli_Id, 
		@pImportacion, 
		@pAsieDifCambio_Id, 
		@pEsVentaContado, 
		@pEsAplicOriginal
	)
END 

GO

DROP PROCEDURE genCancMovDatos
GO
CREATE PROCEDURE genCancMovDatos
(
@pAsiento_Id bigint=null,
@pCuotaNro smallint=null,
@pAsiento_Id_Ap bigint=null,
@pCuotaNro_Ap smallint=null, 
@pCambio	QMonedaD8,
@pCambio_ap QMonedaD8,
@pImportacion bit
)
AS
SET NOCOUNT ON 

SELECT @pAsiento_Id as Asiento_Id, @pCuotaNro as CuotaNro , @pAsiento_Id_Ap as Asiento_Id_Ap,
		@pCuotaNro_Ap  as CuotaNro_Ap, @pCambio as Cambio, @pCambio_Ap as Cambio_Ap, 
		@pImportacion as Importacion, Cast(0 As Bit) EsVentaContado, Cast(0 As Bit) EsAplicOriginal, Cast(0 As Bit) LlamarAlWS


SELECT Mov.Empresa_Id, Mov.Segmento1N, Mov.Segmento2N,Mov.Segmento3N,Mov.Segmento4N,
	Mov.Segmento1C, Mov.Segmento2C,Mov.Segmento3C,Mov.Segmento4C,genCancMov.CuotaNro,
	Mov.Asiento_Id, 
	Mov_ap.Segmento1N Segmento1N_ap, Mov_ap.Segmento2N Segmento2N_ap,
	Mov_ap.Segmento3N Segmento3N_ap, Mov_ap.Segmento4N Segmento4N_ap,
	Mov_ap.Segmento1C Segmento1C_ap, Mov_ap.Segmento2C Segmento2C_ap,
	Mov_ap.Segmento3C Segmento3C_ap, Mov_ap.Segmento4C Segmento4C_ap, 
	Mov_Ap.Asiento_Id as Asiento_Id_Ap, genCancMov.CuotaNro_Ap, genCancMov.FechaAplicacion, genCancMov.Importe, genCancMov.Importe_ap,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	dbo.Segmento(Mov.Segmento_Id, Mov.Segmento1C, Mov.Segmento2C, Mov.Segmento3C, Mov.Segmento4C,
		Mov.Segmento1N, Mov.Segmento2N, Mov.Segmento3N, Mov.Segmento4N) AS Segmento,
	dbo.Segmento(Mov_ap.Segmento_Id, Mov_ap.Segmento1C, Mov_ap.Segmento2C, Mov_ap.Segmento3C, Mov_ap.Segmento4C,
		Mov_ap.Segmento1N, Mov_ap.Segmento2N, Mov_ap.Segmento3N, Mov_ap.Segmento4N) AS Segmento_ap, 
	genCancMov.AsientoApli_Id, genCancMov.NroAplicacion as NroAplicacion, genCancMov.Importacion, 
	genCancMov.AsieDifCambio_Id
	--, genCancMov.EsVentaContado, genCancMov.EsAplicOriginal, SegMov.Segmento_Id, SegMov_Ap.Segmento_Id Segmento_Id_Ap
FROM genCancMov 
INNER JOIN genAsiSegmentos as Mov ON (Mov.Asiento_Id = genCancMov.Asiento_Id) 
INNER JOIN genAsiSegmentos as Mov_ap ON (Mov_ap.Asiento_Id = genCancMov.Asiento_Id_Ap) 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genCancMov.Usuario_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = genCancMov.Asiento_Id
INNER JOIN conAsientos conAsientosAp on conAsientosAp.conAsientos = genCancMov.Asiento_Id_Ap
Inner Join genSegmentos SegMov On SegMov.genSegmentos = Mov.Segmento_Id
Inner Join genSegmentos SegMov_Ap On SegMov_Ap.genSegmentos = Mov_ap.Segmento_Id
WHERE 
conAsientos.Anulado = 0 and conAsientosAp.Anulado =0 and 
(genCancMov.Asiento_Id = ISNULL( @pAsiento_Id,genCancMov.Asiento_Id))
AND (genCancMov.CuotaNro = ISNULL(@pCuotaNro,genCancMov.CuotaNro))
AND (genCancMov.Asiento_Id_Ap = ISNULL(@pAsiento_Id_Ap,genCancMov.Asiento_Id_Ap))
AND (genCancMov.CuotaNro_Ap = ISNULL(@pCuotaNro_Ap,genCancMov.CuotaNro_Ap))
union ALL
SELECT Mov.Empresa_Id, Mov.Segmento1N, Mov.Segmento2N,Mov.Segmento3N,Mov.Segmento4N,
	Mov.Segmento1C, Mov.Segmento2C,Mov.Segmento3C,Mov.Segmento4C,genCancMov.CuotaNro,
	Mov.Asiento_Id,
	Mov_ap.Segmento1N Segmento1N_ap, Mov_ap.Segmento2N Segmento2N_ap,
	Mov_ap.Segmento3N Segmento3N_ap, Mov_ap.Segmento4N Segmento4N_ap,
	Mov_ap.Segmento1C Segmento1C_ap, Mov_ap.Segmento2C Segmento2C_ap,
	Mov_ap.Segmento3C Segmento3C_ap, Mov_ap.Segmento4C Segmento4C_ap,
	Mov_Ap.Asiento_Id as Asiento_Id_Ap, genCancMov.CuotaNro_Ap, 
	genCancMov.FechaAplicacion, genCancMov.Importe,genCancMov.Importe_ap,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	dbo.Segmento(Mov.Segmento_Id, Mov.Segmento1C, Mov.Segmento2C, Mov.Segmento3C, Mov.Segmento4C,
		Mov.Segmento1N, Mov.Segmento2N, Mov.Segmento3N, Mov.Segmento4N) AS Segmento,
	dbo.Segmento(Mov_ap.Segmento_Id, Mov_ap.Segmento1C, Mov_ap.Segmento2C, Mov_ap.Segmento3C, Mov_ap.Segmento4C,
		Mov_ap.Segmento1N, Mov_ap.Segmento2N, Mov_ap.Segmento3N, Mov_ap.Segmento4N) AS Segmento_ap, 
		genCancMov.AsientoApli_Id,
		genCancMov.NroAplicacion as NroAplicacion, genCancMov.Importacion, 
		genCancMov.AsieDifCambio_Id
		-- , genCancMov.EsVentaContado, genCancMov.EsAplicOriginal, SegMov.Segmento_Id,  SegMov_Ap.Segmento_Id Segmento_Id_Ap,
FROM genCancMov 
INNER JOIN genAsiSegmentos as Mov ON (Mov.Asiento_Id = genCancMov.Asiento_Id) 
INNER JOIN genAsiSegmentos as Mov_ap ON (Mov_ap.Asiento_Id = genCancMov.Asiento_Id_Ap) 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genCancMov.Usuario_Id)
INNER JOIN conAsientos ON conAsientos.conAsientos = genCancMov.Asiento_Id
INNER JOIN conAsientos conAsientosAp on conAsientosAp.conAsientos = genCancMov.Asiento_Id_Ap
Inner Join genSegmentos SegMov On SegMov.genSegmentos = Mov.Segmento_Id
Inner Join genSegmentos SegMov_Ap On SegMov_Ap.genSegmentos = Mov_ap.Segmento_Id
WHERE 
conAsientos.Anulado = 0 and conAsientosAp.Anulado =0 and 
(genCancMov.Asiento_Id = ISNULL( @pAsiento_Id_Ap,genCancMov.Asiento_Id))
AND (genCancMov.CuotaNro = ISNULL(@pCuotaNro_Ap,genCancMov.CuotaNro))
AND (genCancMov.Asiento_Id_Ap = ISNULL(@pAsiento_Id,genCancMov.Asiento_Id_Ap))
AND (genCancMov.CuotaNro_Ap = ISNULL(@pCuotaNro,genCancMov.CuotaNro_Ap))
-- and genCancMov.Importacion = @pImportacion
Order By FechaAplicacion Desc, NroAplicacion Desc
RETURN @@Error

GO

DROP PROCEDURE genCancMovEliminar
GO
CREATE PROCEDURE genCancMovEliminar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint,
@pNroAplicacion int = NULL, 
@pImportacion bit
)
AS
SET NOCOUNT ON 

DELETE FROM genCancMov WHERE 
(Asiento_Id = @pAsiento_Id)
AND (CuotaNro = @pCuotaNro)
AND (Asiento_Id_Ap = @pAsiento_Id_Ap)
AND (CuotaNro_Ap = @pCuotaNro_Ap) 
AND (NroAplicacion= ISNULL(@pNroAplicacion,NroAplicacion))
and Importacion = @pImportacion
 
RETURN @@Error 


GO


DROP PROCEDURE genCancMovDatosRenglon
GO
CREATE PROCEDURE genCancMovDatosRenglon
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint,
@pNroAplicacion int
)
AS
SET NOCOUNT ON 

SELECT genCancMov.CuotaNro, genCancMov.Asiento_Id_Ap, genCancMov.CuotaNro_Ap, genCancMov.NroAplicacion,
	genCancMov.Usuario_Id, genCancMov.FechaAplicacion, genCancMov.Importe, genCancMov.Importe_Ap,
	genCancMov.AsientoApli_Id, genCancMov.Importacion, genCancMov.AsieDifCambio_Id, genCancMov.EsVentaContado,
	genCancMov.EsAplicOriginal
FROM genCancMov 
WHERE (Asiento_Id = @pAsiento_Id)
AND (CuotaNro = @pCuotaNro)
AND (Asiento_Id_Ap = @pAsiento_Id_Ap)
AND (CuotaNro_Ap = @pCuotaNro_Ap)
AND (NroAplicacion = @pNroAplicacion)
 
 RETURN @@Error 

GO

