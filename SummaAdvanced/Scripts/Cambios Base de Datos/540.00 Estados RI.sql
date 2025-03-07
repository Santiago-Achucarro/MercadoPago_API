Insert into comriestados (EstadoRI_Id, Descripcion) Values('A','Autorizado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('E','Entregado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('P','Pendiente de Autorizacion') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('R','Rechazado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('T','Terminado') 

GO

if not exists(select 1 from genLexico where SetFunciones = 'ESQUEMAOC')
begin
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'IIF', 'Condicional', 113, 'U')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'MONTO', 'Monto', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'SIEMPRE', 'Requiere autorización Siempre', 103, 'L')
end
go

INSERT INTO genVersion (Version) Values(540.000)
GO