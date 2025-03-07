
DROP PROCEDURE genLocalidadesDatos
go
CREATE PROCEDURE genLocalidadesDatos(
	@c_Localidad VarChar(4), 
	@Estado VarChar(5)
)
as
SELECT genlocalidades.c_Localidad, genlocalidades.c_Estado, genlocalidades.Descripcion
from genlocalidades
	inner join genProvincias ON genlocalidades.c_Estado = genProvincias.CodFiscal
where
	genlocalidades.c_Localidad = @c_Localidad and 
	genProvincias.Provincia_Id = @Estado
GO
	
DROP PROCEDURE genMunicipiosDatos
go
CREATE PROCEDURE genMunicipiosDatos(
	@c_Municipio VarChar(3), 
	@Estado VarChar(5)
)
as
SELECT genMunicipios.c_Municipio, genMunicipios.c_Estado, genMunicipios.Descripcion
from genMunicipios
	inner join genProvincias ON genMunicipios.c_Estado = genProvincias.CodFiscal
where
	genMunicipios.c_Municipio = @c_Municipio and 
	genProvincias.Provincia_Id = @Estado
GO
	
		