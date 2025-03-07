INSERT INTO genVersion (Version) Values(552.00)
GO

INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) Values(1516,'MX', '107','Aujuste al Subsidio Causado')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) Values(1518,'MX', '007','ISR Causado Subsidio')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) Values(1518,'MX', '008','Subsidio efectivamente entregado que no correspondía')

INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('SUELEXICO','LEGA','Numero de Empelado',103,'N')
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('SUELEXICO','TIPOLEGA','Convenio',103,'C')

GO


