-- genSegmentoStr 'TES','E','0001',' ',' ',10,0,0,0

DROP Procedure genSegmentoStr
GO
CREATE Procedure genSegmentoStr(
	@Segmento_Id VarChar(10), 
	@Segmento1C VarChar(25), 
	@Segmento2C VarChar(25), 
	@Segmento3C VarChar(25), 
	@Segmento4C VarChar(25), 
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int
)

AS
SELECT dbo.Segmento(genSegmentos.genSegmentos, 
		@Segmento1C, @Segmento2C, @Segmento3C, @Segmento4C,
		@Segmento1N, @Segmento2N, @Segmento3N, @Segmento4N) AS SegmentoSTR, 
		genSegmentos.Segmento_Id, 
		@Segmento1C as Segmento1C, @Segmento2C as Segmento2C, 
		@Segmento3C as Segmento3C, @Segmento4C as Segmento4C, 
		@Segmento1N as Segmento1N, @Segmento2N as Segmento2N, 
		@Segmento3N as Segmento3N, @Segmento4N as Segmento4N
FROM genSegmentos 
WHERE
	genSegmentos.Segmento_Id = @Segmento_Id
	
GO
