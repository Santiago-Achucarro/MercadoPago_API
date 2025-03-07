DROP PROCEDURE genLexicoDatos
GO
CREATE PROCEDURE genLexicoDatos
(
@pSetFunciones varchar(20)
)
AS
SET NOCOUNT ON 

SELECT genLexico.SetFunciones, genLexico.Funcion, genLexico.Descripcion, genLexico.Token,
	genLexico.TipoDato
FROM genLexico 
WHERE SetFunciones = @pSetFunciones Or SetFunciones = ''
 
RETURN @@Error 

GO
