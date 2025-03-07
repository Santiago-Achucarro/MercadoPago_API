DROP procedure genAdjuntosIdentityDatos
GO

Create procedure genAdjuntosIdentityDatos
(
@pTabla_Id varchar(60),
@pIdentity_Id bigint 
)
As

SELECT genAdjuntos.Renglon, genAdjuntos.Guid, genAdjuntos.NombreArchivo, genAdjuntos.Extension, '' as ArchivoBase64, '' as Estado
FROM genAdjuntos 
WHERE (genAdjuntos.Tabla_Id = @pTabla_Id)
AND (Identity_Id = @pIdentity_Id)
Order by 1
RETURN @@Error 

GO

DROP procedure genAdjuntosIdentityDevolverDatos
GO

Create procedure genAdjuntosIdentityDevolverDatos
(
@pTabla_Id varchar(60),
@pIdentity_Id bigint 
)
As

SELECT @pTabla_Id as Tabla_Id, @pIdentity_Id as Identity_Id


SELECT genAdjuntos.Renglon, genAdjuntos.Guid, genAdjuntos.NombreArchivo, genAdjuntos.Extension, '' as ArchivoBase64, '' as Estado
FROM genAdjuntos 
WHERE (genAdjuntos.Tabla_Id = @pTabla_Id)
AND (Identity_Id = @pIdentity_Id)
Order by 1
RETURN @@Error 

GO
