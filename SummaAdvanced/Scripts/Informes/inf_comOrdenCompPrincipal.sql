drop procedure inf_comOrdenCompPrincipal
go
create procedure inf_comOrdenCompPrincipal
(
@Empresa_Id int,
@Segmento_Id VarChar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
set nocount on
DECLARE @pComOrdenComp as Int
SET @pComOrdenComp = (SELECT comOrdenComp 
	FROM comOCSegmentos WHERE 
	(Empresa_Id = @Empresa_Id) AND 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@Segmento_Id)) AND 
	(Segmento1N = @Segmento1N) AND 
	(Segmento2N = @Segmento2N) AND 
	(Segmento3N = @Segmento3N) AND 
	(Segmento4N = @Segmento4N) AND 
	(Segmento1C = @Segmento1C) AND 
	(Segmento2C = @Segmento2C) AND 
	(Segmento3C = @Segmento3C) AND 
	(Segmento4C = @Segmento4C))
SELECT
ProvSuc.Descripcion as ProvinciaSucursal, PaisSuc.Descripcion as PaisSucursal, genSucursalesEmpr.Direccion as DireccionSucursal, 
genSucursalesEmpr.Localidad as LocalidadSucursal, genSucursalesEmpr.Telefono as TelefonoSucursal, genSucursalesEmpr.CodigoPostal as CPSucursal,
 genSucursalesEmpr.Descripcion as DescripcionSucursal, dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento,
	comOrdenComp.comOrdenComp, comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comTipoPermi.TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermi, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, comOrdenComp.Autorizo as NroUsuAuto,
	Autorizo.Usuario_Id as Autorizo, Autorizo.Apellido_y_Nombres as DescripcionUsuarioAutorizo, 
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionConPago,
	comOrdenComp.Impreso, comOrdenComp.Observaciones, 
	comOcEstados.Estado_Id, comOcEstados.Descripcion as DescripcionOcEstados,
	comOrdenComp.Saldo_Anticipo, comOrdenComp.ImporteImpuestos, 
	comOrdenComp.Saldo_NC, comOrdenComp.Cambio,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	comOrdenComp.Posteado, comTipoPermi.TipoCuerpo, 
	ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as SubTotal,
	comOrdenComp.ImporteImpuestos + ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as Total, 
			comproveedores.Direccion1, comproveedores.Direccion2, comproveedores.Localidad, 
			comproveedores.CodigoPostal, genProvinciasP.Provincia_Id, 
			genProvinciasP.Descripcion DescripcionPrincia, 
			genPaisesP.Pais_Id, genPaisesP.Descripcion DescripcionPais, 
			comProveedores.Contacto, comProveedores.Telefono, 
			genEntidades.Cuit
FROM comOrdenComp 
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comOrdenComp.Proveed_Id)
LEFT JOIN comTipoPermi  ON (comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = comOrdenComp.Moneda_Id)
left join comOCAutorizando on comOCAutorizando.comOrdenComp=comOrdenComp.comOrdenComp and comOCAutorizando.TipoApro='A'
LEFT JOIN genUsuarios  as Autorizo ON (Autorizo.genUsuarios = comOCAutorizando.Usuario_Id)
LEFT JOIN comConPago  ON (comConPago.comConPago = comOrdenComp.CondPago_Id)
INNER JOIN comOcEstados  ON (comOcEstados.Estado_Id = comOrdenComp.Estado_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = comOrdenComp.Usuario_Id)
INNER JOIN comOcSegmentos ON comOcSegmentos.comOrdencomp = comOrdencomp.comOrdenComp
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id)
inner join genEmpresas on comOCSegmentos.Empresa_Id = genEmpresas.genEmpresas
inner join genSucursalesEmpr on genUsuarios2.Sucursal=genSucursalesEmpr.genSucursalesEmpr
inner join genPaises on genEmpresas.Pais_Id=genPaises.genPaises
inner join genProvincias on genEmpresas.Provincia_Id=genProvincias.genProvincias
inner join genPaises PaisSuc on genSucursalesEmpr.Pais_Id=PaisSuc.genPaises
inner join genProvincias ProvSuc on genSucursalesEmpr.Provincia_Id=ProvSuc.genProvincias
inner join genPaises genPaisesp on comProveedores.Pais=genPaisesp.genPaises
inner join genProvincias genProvinciasP on comProveedores.Provincia_Id=genProvinciasP.genProvincias
inner join genEntidades on genEntidades.genEntidades =comProveedores.genEntidades
WHERE  
	comOrdenComp.comOrdenComp = @pComOrdenComp
go
