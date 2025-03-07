DROP procedure genAtributosGeneralesIdentityDatos
GO
Create procedure genAtributosGeneralesIdentityDatos
(
@pIdentity bigint, 
@pTabla varchar(60)
)
As
Select genAtributosGenerales.AtributoNro, genAtributosGenerales.Descripcion,
   genAtributosValores.ValorN, genAtributosValores.ValorC, genAtributosValores.ValorF, genAtributosGenerales.Tipo
FROM genAtributosGenerales 
LEFT OUTER JOIN genAtributosValores ON 
   genAtributosGenerales.Tabla_Id = genAtributosValores.Tabla_Id and 
   genAtributosGenerales.AtributoNro = genAtributosValores.AtributoNro and 
    genAtributosValores.Identity_id = @pIdentity 
WHERE
   genAtributosGenerales.Tabla_Id = @pTabla --And genAtributosGenerales.EnGrilla = 1
Order by 1
RETURN @@Error 

GO


DROP procedure genAtributosGeneralesIdentityEspDatos
GO
Create procedure genAtributosGeneralesIdentityEspDatos
(
@pIdentity bigint, 
@pTabla varchar(60)
)
As
Select genAtributosGenerales.AtributoNro, genAtributosGenerales.Descripcion,
   genAtributosValores.ValorN, genAtributosValores.ValorC, genAtributosValores.ValorF, genAtributosGenerales.Tipo
FROM genAtributosGenerales 
LEFT OUTER JOIN genAtributosValores ON 
   genAtributosGenerales.Tabla_Id = genAtributosValores.Tabla_Id and 
   genAtributosGenerales.AtributoNro = genAtributosValores.AtributoNro and 
    genAtributosValores.Identity_id = @pIdentity 
WHERE
   genAtributosGenerales.Tabla_Id = @pTabla And genAtributosGenerales.EnGrilla = 0
Order by 1
RETURN @@Error 

GO
