--EXEC Inf_comEmbarques 1, 'EMB', 1, 0, 0, 0, '0004', '', '', ''
--EXEC Inf_comEmbarquesCuerpo 1, 'EMB', 1, 0, 0, 0, '0004', '', '', ''
--EXEC Inf_comEmbarquesGastos 1, 'EMB', 1, 0, 0, 0, '0004', '', '', ''  
--EXEC Inf_comEmbarquesSegmento 1, 'EMB', 1, 0, 0, 0, '0004', '', '', ''  

DROP PROCEDURE Inf_comEmbarques
GO
CREATE PROCEDURE Inf_comEmbarques
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
@Segmento4C VarChar(20))
AS
SET NOCOUNT ON 

DECLARE @lIdentity int = (select Asiento_Id From genAsiSegmentos
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
	genAsiSegmentos.Segmento4C = @Segmento4C)

EXEC comEmbarquesDatosIdentity @lIdentity 

RETURN @@Error
GO


DROP PROCEDURE Inf_comEmbarquesCuerpo
GO
CREATE PROCEDURE Inf_comEmbarquesCuerpo
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
@Segmento4C VarChar(20))
AS
SET NOCOUNT ON 

DECLARE @lIdentity int = (select Asiento_Id From genAsiSegmentos
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
	genAsiSegmentos.Segmento4C = @Segmento4C)

EXEC comEmbCuerpoDatos @lIdentity 

RETURN @@Error
GO

DROP PROCEDURE Inf_comEmbarquesGastos
GO
CREATE PROCEDURE Inf_comEmbarquesGastos
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
@Segmento4C VarChar(20))
AS
SET NOCOUNT ON 

DECLARE @lIdentity int = (select Asiento_Id From genAsiSegmentos
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
	genAsiSegmentos.Segmento4C = @Segmento4C)

EXEC comEmbGastosDatos @lIdentity 

RETURN @@Error
GO


DROP PROCEDURE Inf_comEmbarquesSegmento
GO
CREATE PROCEDURE Inf_comEmbarquesSegmento
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
@Segmento4C VarChar(20))  
AS  
SET NOCOUNT ON   
  
SELECT dbo.Segmento(dbo.FuncFKgenSegmentos(@Segmento_id), @Segmento1C,@Segmento2C,@Segmento3C,@Segmento4C,
	@Segmento1N,@Segmento2N, @Segmento3N, @Segmento4N) AS SegmentoStrEmb 
 
RETURN @@Error



