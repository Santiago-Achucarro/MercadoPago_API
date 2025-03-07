DROP function ArmarValorCampoArchivo
GO
Create function ArmarValorCampoArchivo(
@pNombreCliente varchar(250),
@pNombreServidor varchar(250)
)
returns varchar(350)
as
begin
return ('X|'+ @pNombreCliente + '|' + @pNombreServidor)
end
Go
