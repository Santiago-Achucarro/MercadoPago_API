DROP Function EnOtroLenguaje
GO
CREATE Function EnOtroLenguaje(
	@Cultura VarChar(5) = NULL
	)
	RETURNS BIT

BEGIN
	Declare @Dominio VarChar(2)
	if @Cultura is not null
		begin
			select @Dominio = Dominio_Id from genInstalacion
			if @Dominio IN ('AR','MX') 
				if LEFT(@Cultura,2) != 'es'
					return cast(1 as bit)
				else
					return cast(0 as bit)
			else
				if LEFT(@Cultura,2) = 'es'
					return cast(1 as bit)
			end
	
	return cast(0 as bit)

end	
