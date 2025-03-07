DROP PROCEDURE inf_comProveListaNegra
GO
CREATE PROCEDURE inf_comProveListaNegra
(
	@Empresa_Id Int
)

AS

select comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.Cuit, 
	comListaNegraMX.Situacion, comProveedores.Inactivo
From comProveedores 
	inner join genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
	INNER JOIN comListaNegraMX ON comListaNegraMX.RFC =genEntidades.Cuit
WHERE
	ISNULL(comProveedores.Empresa_Id,@Empresa_Id)= @Empresa_Id
order by 1
GO