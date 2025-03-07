
DROP FUNCTION [dbo].[SegmentoSP]
go

CREATE FUNCTION [dbo].[SegmentoSP](@Segmento_id int, 
	@Segmento1C VarChar(20),@Segmento2C VarChar(20),
	@Segmento3C VarChar(20), @Segmento4C VarChar(20),
	@Segmento1N int,@Segmento2N int,
	@Segmento3N int, @Segmento4N int)
RETURNS VarChar(120)
as
BEGIN

DECLARE @Orden1C INT
DECLARE @Orden2C INT
DECLARE @Orden3C INT
DECLARE @Orden4C INT
DECLARE @Orden1N INT
DECLARE @Orden2N INT
DECLARE @Orden3N INT
DECLARE @Orden4N INT
DECLARE @Ret VarChar(120)		
DECLARE @I INT
DECLARE @Sepa Char(1) 


DECLARE @Orden1CEP BIT
DECLARE @Orden2CEP BIT
DECLARE @Orden3CEP BIT
DECLARE @Orden4CEP BIT
DECLARE @Digitos1N Int

SET @Ret=''

SELECT @Orden1C = Orden1C , @Orden2C = Orden2C , @Orden3C = Orden3C , @Orden4C = Orden4C ,
	@Orden1N = Orden1N , @Orden2N = Orden2N , @Orden3N = Orden3N , @Orden4N = Orden4N,
	@Orden1CEP = case when Origen1C = 9 then 1 else 0 end, 
	@Orden2CEP = case when Origen2C = 9 then 1 else 0 end, 
	@Orden3CEP = case when Origen3C = 9 then 1 else 0 end, 
	@Orden4CEP = case when Origen4C = 9 then 1 else 0 end
	from genSegmentos 
	where
	genSegmentos.genSegmentos = @Segmento_Id

SET @I= 1
SET @Sepa=''
WHILE @I <= 8
BEGIN 
	IF @Orden1C = @I
	BEGIN
		IF @Segmento1C <> '' and @Orden1CEP = 0
		BEGIN
			SET @Ret = @Ret + @Sepa + @Segmento1C
			SET @Sepa = '-'
		END
	END	
	
	IF @Orden2C = @I
	BEGIN
		IF @Segmento2C <> '' and @Orden2CEP = 0
		BEGIN
		SET @Ret = @Ret + @Sepa + @Segmento2C
		SET @Sepa = '-'
		END
	END	
	
	IF @Orden3C = @I 
	BEGIN
		IF @Segmento3C <> '' and @Orden3CEP = 0
		BEGIN
		SET @Ret = @Ret + @Sepa + @Segmento3C
		SET @Sepa = '-'
		END
	END	
	
	IF @Orden4C = @I
	BEGIN
		IF @Segmento4C <> '' and @Orden4CEP = 0
		BEGIN
		SET @Ret = @Ret + @Sepa + @Segmento4C
		SET @Sepa = '-'
		END
	END	
	
	IF @Orden1N = @I
	BEGIN
		SET @Ret = @Ret + @Sepa + case when @Segmento1N<0 then '*' else '' end + 
			Left('0000000000',@Digitos1N-len(ltrim(STR(abs(@Segmento1N),@Digitos1N))))+ltrim(STR(abs(@Segmento1N),@Digitos1N))
		SET @Sepa = '-'
	END	
	
	IF @Orden2N = @I
	BEGIN
		SET @Ret = @Ret + @Sepa + case when @Segmento2N<0 then '*' else '' end +ltrim(STR(abs(@Segmento2N),10))
		SET @Sepa = '-'
	END	
	
	IF @Orden3N = @I
	BEGIN
		SET @Ret = @Ret + @Sepa +case when @Segmento3N<0 then '*' else '' end + ltrim(STR(Abs(@Segmento3N),10))
		SET @Sepa = '-'
	END	
	
	IF @Orden4N = @I
	BEGIN
		SET @Ret = @Ret + @Sepa +case when @Segmento4N<0 then '*' else '' end + ltrim(STR(Abs(@Segmento4N),10))
		SET @Sepa = '-'
	END	
	
	SET @I = @I+1
	
END
RETURN @Ret	

END	

GO


