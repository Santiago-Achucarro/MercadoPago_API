DROP PROCEDURE comEmbarquesGuardar
GO
CREATE PROCEDURE comEmbarquesGuardar
(
@pcomEmbarques bigint,
@pTipoTransporte char(1),
@pNroOrdenExterior varchar(20),
@pFechaEmbarque qFecha,
@pFechaArribo qFecha,
@pPesoTotal QCantidad,
@pEstado_Id char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEmbarques WHERE (comEmbarques = @pcomEmbarques)))
BEGIN 
	UPDATE comEmbarques
	SET		TipoTransporte = @pTipoTransporte,
		NroOrdenExterior = @pNroOrdenExterior,
		FechaEmbarque = @pFechaEmbarque,
		FechaArribo = @pFechaArribo,
		PesoTotal = @pPesoTotal,
		Estado_Id = @pEstado_Id
	WHERE (comEmbarques = @pcomEmbarques)
END 
ELSE 
BEGIN 
	INSERT INTO comEmbarques
	(
		comEmbarques,
		TipoTransporte,
		NroOrdenExterior,
		FechaEmbarque,
		FechaArribo,
		PesoTotal,
		Estado_Id
	)
	VALUES 
	(
		@pcomEmbarques,
		@pTipoTransporte,
		@pNroOrdenExterior,
		@pFechaEmbarque,
		@pFechaArribo,
		@pPesoTotal,
		@pEstado_Id
	)
END 

GO



DROP PROCEDURE comEmbarquesDatosIdentity
GO
CREATE PROCEDURE comEmbarquesDatosIdentity
(
@pIdentity int
)
AS
SET NOCOUNT ON 

SELECT comEmbarques.comEmbarques, genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	conAsientos.Fecha, conAsientos.Cambio, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescripcionMonedas, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres,
	comEmbarques.TipoTransporte, comEmbarques.NroOrdenExterior,
	comEmbarques.FechaEmbarque, comEmbarques.FechaArribo, comEmbarques.PesoTotal, comEmbarques.Estado_Id,
	comEmbEstado.Descripcion as DescripcionEmbEstado, conAsientos.Posteado, 
	0.00 as Total, conasientos.Anulado
FROM comEmbarques
Inner Join conAsientos On conAsientos.conAsientos = comEmbarques.comEmbarques
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN comEmbEstado  ON (comEmbEstado.Estado_Id = comEmbarques.Estado_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = conAsientos.Moneda_Id)
Inner Join genUsuarios On genUsuarios.genUsuarios = conAsientos.Usuario_Id
WHERE comEmbarques.comEmbarques = @pIdentity

exec comEmbCuerpoDatos @pIdentity

exec comEmbGastosDatos @pIdentity

Exec genAtributosGeneralesIdentityDatos @pIdentity, 'comEmbarques'

Select ' ' Segmento_Id , Segmento1N, Segmento2N, Segmento3N, Segmento4N, 
	   Segmento1C, Segmento2C, Segmento3C, Segmento4C
	 from comocSegmentos 
	 Where 1 = 2

RETURN @@Error 

GO


DROP PROCEDURE comEmbarquesDatos
GO
CREATE PROCEDURE comEmbarquesDatos
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
SET NOCOUNT ON 

Declare @lIdentity int= (select Asiento_Id From genAsiSegmentos
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
	genAsiSegmentos.Segmento4C = @pSegmento4C)

exec comEmbarquesDatosIdentity @lIdentity

RETURN @@Error 

GO


DROP PROCEDURE comEmbarquesEliminar
GO
CREATE PROCEDURE comEmbarquesEliminar
(
@pIdentity int
)
AS
SET NOCOUNT ON 

DELETE FROM comEmbarques
WHERE comEmbarques = @pIdentity
RETURN @@Error 

GO


DROP PROCEDURE comEmbarquesCambiarEstado
GO
CREATE PROCEDURE comEmbarquesCambiarEstado
(
@pcomEmbarques bigint,
@pEstado Char(1)
)
AS
Update comEmbarques Set Estado_Id = @pEstado WHERE comEmbarques = @pcomEmbarques
GO

