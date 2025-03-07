drop procedure comPFXDatos
go
create procedure comPFXDatos
(
@pEmpresa_Id int
)
as
select genGlobales.cValor as ArchivoPFX, Clave.cValor as ClavePFX, '' as UploadCer, '' as UploadKey, '' as ClaveKey ,
CAST(0 AS Bit) as EsCSD
from genGlobales
inner join genGlobales Clave on Clave.Empresa_Id=@pEmpresa_Id and Clave.Nombre_Var='ClavePFX' 
where genGlobales.Nombre_Var='ArchivoPFX' and genGlobales.Empresa_Id=@pEmpresa_Id
go