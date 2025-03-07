DROP PROCEDURE [dbo].[inf_comReqInternoPrincipal]
GO

create procedure [dbo].[inf_comReqInternoPrincipal]
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
DECLARE @pComReqInterno as Int
SET @pComReqInterno = (SELECT comReqInterno 
	FROM comRISegmento WHERE 
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
    print @pcomReqInterno
SELECT
ProvSuc.Descripcion as ProvinciaSucursal, PaisSuc.Descripcion as PaisSucursal, genSucursalesEmpr.Direccion as DireccionSucursal, 
genSucursalesEmpr.Localidad as LocalidadSucursal, genSucursalesEmpr.Telefono as TelefonoSucursal, genSucursalesEmpr.CodigoPostal as CPSucursal,
 genSucursalesEmpr.Descripcion as DescripcionSucursal, dbo.Segmento(comRISegmento.Segmento_Id,
	comRISegmento.Segmento1C,comRISegmento.Segmento2C,
	comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comRISegmento.Segmento1N,comRISegmento.Segmento2N,
	comRISegmento.Segmento3N, comRISegmento.Segmento4N) as Segmento,
	comReqInterno.comReqInterno, comRISegmento.Empresa_Id, genSegmentos.Segmento_Id, 
	comRISegmento.Segmento1N,comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N, 
	comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C, comRISegmento.Segmento4C,
	comReqInterno.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comTipoPermi.TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermi, 

	Autorizo.Usuario_Id as Autorizo, Autorizo.Apellido_y_Nombres as DescripcionUsuarioAutorizo, 
	
	 comReqInterno.Observaciones, 
	comRIEstados.EstadoRI_Id, comRIEstados.Descripcion as DescripcionOcEstados,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	comTipoPermi.TipoCuerpo, 
	ISNULL((SELECT SUM(Cantidad*Precio) from comRICuerpo where
			comRICuerpo.comReqInterno = comReqInterno.comReqInterno),0) as SubTotal,
	ISNULL((SELECT SUM(Cantidad*Precio) from comRICuerpo where
			comRICuerpo.comReqInterno = comReqInterno.comReqInterno),0) as Total
FROM comReqInterno 
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comReqInterno.Proveed_Id)
LEFT JOIN comTipoPermi  ON (comTipoPermi.comTipoPermi = comReqInterno.TipoPermi_Id)
inner join comRIAutorizando on comRIAutorizando.comReqInterno=comReqInterno.comReqInterno
LEFT JOIN genUsuarios  as Autorizo ON (Autorizo.genUsuarios = comRIAutorizando.Usuario_Id)

INNER JOIN comRIEstados  ON (comRIEstados.EstadoRI_Id = comReqInterno.EstadoRI_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = comReqInterno.Usuario_Id)
INNER JOIN comRISegmento ON comRISegmento.comReqInterno = comReqInterno.comReqInterno
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comRISegmento.Segmento_Id)
inner join genEmpresas on comRISegmento.Empresa_Id = genEmpresas.genEmpresas
inner join genSucursalesEmpr on genUsuarios2.Sucursal=genSucursalesEmpr.genSucursalesEmpr
inner join genPaises on genEmpresas.Pais_Id=genPaises.genPaises
inner join genProvincias on genEmpresas.Provincia_Id=genProvincias.genProvincias
inner join genPaises PaisSuc on genSucursalesEmpr.Pais_Id=PaisSuc.genPaises
inner join genProvincias ProvSuc on genSucursalesEmpr.Provincia_Id=ProvSuc.genProvincias
WHERE  
	comReqInterno.comReqInterno = @pComReqInterno
GO



DROP PROCEDURE [dbo].[inf_comReqInternoCuerpo]
GO

create procedure [dbo].[inf_comReqInternoCuerpo]
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
DECLARE @pComReqInterno as Int
SET @pComReqInterno = (SELECT comReqInterno 
	FROM comRISegmento WHERE 
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
SELECT comRIArticulo.comReqInterno, comRIArticulo.Renglon_RI, stkProductos.Producto_Id,
	stkProductos.Descripcion as DescripcionProductos, comRIArticulo.Factor, comRIArticulo.CantidadOriginal, comRIArticulo.PrecioOriginal,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	comRICuerpo.Cantidad, 
	comRICuerpo.FechaNecesidad, comRICuerpo.Precio, comRICuerpo.Pendiente,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2
FROM comRIArticulo 
INNER JOIN comRICuerpo  ON (comRICuerpo.comReqInterno = comRIArticulo.comReqInterno) AND (comRICuerpo.Renglon_RI = comRIArticulo.Renglon_RI)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = comRIArticulo.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = comRIArticulo.Deposito_Id)
INNER JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRICuerpo.comReqInterno)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comRICuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comRICuerpo.Centro2_Id)
where (comRIArticulo.comReqInterno = @pComReqInterno)
AND (comRIArticulo.Renglon_RI = comRIArticulo.Renglon_RI)
union
SELECT comRIMemo.comReqInterno, comRIMemo.Renglon_RI,'' as Producto_Id, comRIMemo.Detalle as DescripcionProductos,1 as Factor,
comRICuerpo.Cantidad as CantidadOriginal,comRICuerpo.Precio as PrecioOriginal,null as Deposito_Id,'' as DescripcionDepositos,
	comRICuerpo.Cantidad, 
	comRICuerpo.FechaNecesidad, comRICuerpo.Precio, comRICuerpo.Pendiente,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2
FROM comRIMemo 
INNER JOIN comRICuerpo  ON (comRICuerpo.comReqInterno = comRIMemo.comReqInterno) AND (comRICuerpo.Renglon_RI = comRIMemo.Renglon_RI)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comRICuerpo.Cuenta_Id)
INNER JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRICuerpo.comReqInterno)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comRICuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comRICuerpo.Centro2_Id)
WHERE (comRIMemo.comReqInterno = @pComReqInterno)
AND (comRIMemo.Renglon_RI = comRIMemo.Renglon_RI)
GO


