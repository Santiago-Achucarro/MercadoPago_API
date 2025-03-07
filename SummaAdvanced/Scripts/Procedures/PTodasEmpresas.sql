DROP Function PTodasEmpresas
GO
CREATE Function PTodasEmpresas(@Empresa_id int=null)
RETURNS bit
Begin
	return Cast(Case When @Empresa_id is null then 1 else 0 end as Bit)
end	

GO