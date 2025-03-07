drop procedure INF_CatProv
GO
CREATE PROCEDURE INF_CatProv
(
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Empresa Int
)
AS
SELECT comProveedores.genEntidades, comProveedores.Proveed_Id, 
	comProveedores.RazonSocial, comProveedores.NombreLegal, comProveedores.Direccion1, 
	comProveedores.Direccion2, comProveedores.Localidad, 
	comProveedores.CodigoPostal, genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionPcia,
	genPaises.Pais_id Pais, genPaises.Descripcion as DescripcionPais,
	comProveedores.Telefono, comRegiones.Region_Id, comConPago.CondPago_Id, 
	comForEntre.FormaEnt_Id, comProveedores.Origen_Id, comProveedores.Contacto, 
	comProveedores.EMail, comProveedores.Fax, comProveedores.Fecha_Alta, comProveedores.FechaUltActiv, 
	comProveedores.Letra_Fact, comProveedores.Observaciones, 
	comCondFiscal.CondFiscal_Id, comProveedores.Ganancias, comProveedores.IBrutos, 
	comProveedores.EsAduana,  comProveedores.TipoCuenta, 
	comProveedores.NroCuenta, comProveedores.CBU, --comProveedores.Interbanking, 
	ISNULL(tesBancos.Banco_Id, ' ') as Banco_Id, comProveedores.Inactivo, 
	genUsuarios.Usuario_Id, comProveedores.Posteado, comProvTipos.ProvTipo_Id, 
	comProvTipos.Descripcion DescripcionTipo
FROM comProveedores inner join genProvincias ON
genProvincias.genProvincias = comProveedores.Provincia_Id
inner join genPaises ON 
genPaises.genPaises = comProveedores.Pais
INNER JOIN comRegiones ON
comRegiones.comRegiones = comProveedores.Region_Id
inner join comConPago ON
comConPago.comConPago = comProveedores.CondPago_Id
inner join comForEntre ON
comForEntre.comForEntre = comProveedores.FormaEnt_Id
inner join comCondFiscal ON
comCondFiscal.comCondFiscal =comProveedores.CondFiscal_Id
LEFT OUTER JOIN tesBancos ON
tesBancos.tesBancos = comProveedores.Banco_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = comProveedores.Usuario_Id
left join comProvTipos ON comProvTipos.comProvTipos = comProveedores.ProvTipo_Id
Where
comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta  
order by 2

GO


