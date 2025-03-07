Drop procedure genAtributosProvinciaDatos
Go
Create procedure genAtributosProvinciaDatos
(
@pProvinciaC varChar(35),
@pProvinciaN int = Null,
@pAtributoNro Int = Null
)
As
Select '' ProvinciaC, 0 ProvinciaN, 0 AtributoNro, genProvincias.Provincia_Id, genProvincias.Descripcion DescripcionProvincia
From genAtributosValores
Inner Join genProvincias On genProvincias.genProvincias = genAtributosValores.Identity_Id
Where Tabla_Id = 'genProvincias' And  genAtributosValores.AtributoNro = @pAtributoNro And 
	(@pProvinciaC Is Null Or ValorC = @pProvinciaC) And (@pProvinciaN Is Null Or ValorN = ValorN)
Go

