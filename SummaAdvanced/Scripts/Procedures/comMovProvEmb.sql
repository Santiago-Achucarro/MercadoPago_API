DROP PROCEDURE comMovProvEmbInsertar
GO
CREATE PROCEDURE comMovProvEmbInsertar
(
@pcomEmbarques bigint,
@pcomMovProv bigint
)
AS
	INSERT INTO comMovProvEmb
	(
		comEmbarques,
		comMovProv
	)
	VALUES 
	(
		@pcomEmbarques,
		@pcomMovProv
	)

GO

DROP PROCEDURE comMovProvEmbDatos
GO
CREATE PROCEDURE comMovProvEmbDatos
(
@pcomMovProv bigint,
@pcomEmbarques bigint=NULL
)
AS
SET NOCOUNT ON 

SELECT comMovProvEmb.comMovProv, comEmbarques
FROM comMovProvEmb 
WHERE (comMovProv = @pcomMovProv)
 
RETURN @@Error 

GO

DROP PROCEDURE comMovProvEmbEliminar
GO
CREATE PROCEDURE comMovProvEmbEliminar
(
@pcomMovProv bigint,
@pcomEmbarques bigint=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvEmb 
WHERE (comMovProv = @pcomMovProv)
 
RETURN @@Error

GO
drop procedure comMovProvEmbDatosFull
go
create procedure comMovProvEmbDatosFull
(
@pcomMovProv bigint
)
as
set nocount on
select conAsientos.conAsientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, 
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, dbo.Segmento(genAsiSegmentos.Segmento_Id,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS SegmentoSTR
from conAsientos
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
inner join genSegmentos on genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
where conAsientos.conAsientos=@pcomMovProv
go
