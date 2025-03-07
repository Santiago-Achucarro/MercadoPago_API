drop procedure inf_stkSolicitudCDPrincipal
go
create procedure inf_stkSolicitudCDPrincipal
(
    @Empresa_Id int,
    @Segmento_Id varchar(25),
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
select dbo.Segmento(stkSolicitudCDSegmento.Segmento_Id, Segmento1C, Segmento2C, Segmento3C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) as SegmentoSTR, 
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, stkSolicitudCD.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, Observaciones from stkSolicitudCD
inner join stkSolicitudCDSegmento on stkSolicitudCD.stkSolicitudCD=stkSolicitudCDSegmento.stkSolicitudCD
inner join stkDepositos on stkDepositos.stkDepositos=DepositoDestino
inner join genSegmentos on genSegmentos.genSegmentos=stkSolicitudCDSegmento.Segmento_Id
inner join genusuarios on genusuarios.genUsuarios=stkSolicitudCD.Usuario_Id
WHERE
genSegmentos.Segmento_Id=@Segmento_Id and Segmento1N=@Segmento1N and Segmento2N=@Segmento2N and Segmento3N = @Segmento3N and Segmento4N=@Segmento4N AND
Segmento1C=@Segmento1C and Segmento2C=@Segmento2C and Segmento3C=@Segmento3C and Segmento4C=@Segmento4C
GO

drop procedure inf_stkSolicitudCDCuerpo
go
create procedure inf_stkSolicitudCDCuerpo
(
    @Empresa_Id int,
    @Segmento_Id varchar(25),
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
select stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, stkSolicitudCDCuerpo.Observaciones, Cantidad, CantidadPendiente, 
stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida from stkSolicitudCDCuerpo
inner join stkProductos on stkProductos.stkProductos = stkSolicitudCDCuerpo.Producto_Id
inner join stkUniMed on stkUniMed.stkUniMed=stkSolicitudCDCuerpo.Medida_Id
inner join stkSolicitudCDSegmento on stkSolicitudCDSegmento.stkSolicitudCD=stkSolicitudCDCuerpo.stkSolicitudCD
inner join genSegmentos on genSegmentos.genSegmentos=stkSolicitudCDSegmento.Segmento_Id
WHERE
genSegmentos.Segmento_Id=@Segmento_Id and Segmento1N=@Segmento1N and Segmento2N=@Segmento2N and Segmento3N = @Segmento3N and Segmento4N=@Segmento4N AND
Segmento1C=@Segmento1C and Segmento2C=@Segmento2C and Segmento3C=@Segmento3C and Segmento4C=@Segmento4C
go
