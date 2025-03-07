DROP PROCEDURE stkMoviCuerpoCambiarCosto
GO
CREATE PROCEDURE stkMoviCuerpoCambiarCosto
(
	@pstkMoviCabe BigInt, 
	@pRenglon Int, 
	@pCosto Numeric(18,4)
)
as

Update stkMoviCuerpo set CostoUnitario = @pCosto 
	Where	
	stkMoviCabe = @pstkMoviCabe and 
	Renglon = @pRenglon
GO