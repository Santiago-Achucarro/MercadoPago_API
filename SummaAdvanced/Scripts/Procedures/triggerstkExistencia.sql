drop trigger stkExistenciaModifcacion 
go
create trigger stkExistenciaModifcacion on stkExistencia after update, insert
as
update stkExistencia set UltimaModificacion=getdate()
from stkexistencia
inner join inserted on inserted.Producto_Id=stkExistencia.Producto_Id and inserted.Deposito_Id=stkExistencia.Deposito_Id
go