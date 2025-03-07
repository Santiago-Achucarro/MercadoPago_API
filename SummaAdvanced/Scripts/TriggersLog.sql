 DROP TRIGGER afiActivoFijoins
GO

 CREATE TRIGGER afiActivoFijoins
ON afiActivoFijo
AFTER INSERT
AS
 BEGIN
INSERT INTO afiActivoFijo_log(
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
GETDATE(),
'ins'
FROM inserted where afiActivoFijo=inserted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiActivoFijodel
GO

 CREATE TRIGGER afiActivoFijodel
ON afiActivoFijo
AFTER DELETE
AS
 BEGIN
INSERT INTO afiActivoFijo_log(
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
GETDATE(),
'del'
FROM deleted where afiActivoFijo=deleted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiActivoFijoupd
GO

 CREATE TRIGGER afiActivoFijoupd
ON afiActivoFijo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiActivoFijo_log(
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
ActivoFijo_Id,
Empresa_Id,
Descripcion,
FechaAlta,
FechaIniDepre,
FechaBaja,
ValorInicial,
ValorFiscal,
VidaUtil,
VidaUtilRestante,
PorResidual,
AmortAcumulada,
Rubro_Id,
Cantidad,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
ValorInicialSI,
AmortAcumSI,
Usuario_Id,
FechaCarga,
GETDATE(),
'upd'
FROM inserted where afiActivoFijo=inserted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiBajasins
GO

 CREATE TRIGGER afiBajasins
ON afiBajas
AFTER INSERT
AS
 BEGIN
INSERT INTO afiBajas_log(
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER afiBajasdel
GO

 CREATE TRIGGER afiBajasdel
ON afiBajas
AFTER DELETE
AS
 BEGIN
INSERT INTO afiBajas_log(
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER afiBajasupd
GO

 CREATE TRIGGER afiBajasupd
ON afiBajas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiBajas_log(
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Causa,
Cantidad,
Monto,
MontoFiscal,
MontoDepreciacion,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER afiCentrosins
GO

 CREATE TRIGGER afiCentrosins
ON afiCentros
AFTER INSERT
AS
 BEGIN
INSERT INTO afiCentros_log(
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'ins'
FROM inserted where ActivoFijo_Id=inserted.ActivoFijo_Id)
 END
GO

 DROP TRIGGER afiCentrosdel
GO

 CREATE TRIGGER afiCentrosdel
ON afiCentros
AFTER DELETE
AS
 BEGIN
INSERT INTO afiCentros_log(
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'del'
FROM deleted where ActivoFijo_Id=deleted.ActivoFijo_Id)
 END
GO

 DROP TRIGGER afiCentrosupd
GO

 CREATE TRIGGER afiCentrosupd
ON afiCentros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiCentros_log(
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
ActivoFijo_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'upd'
FROM inserted where ActivoFijo_Id=inserted.ActivoFijo_Id)
 END
GO

 DROP TRIGGER AficonMovcontins
GO

 CREATE TRIGGER AficonMovcontins
ON AficonMovcont
AFTER INSERT
AS
 BEGIN
INSERT INTO AficonMovcont_log(
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER AficonMovcontdel
GO

 CREATE TRIGGER AficonMovcontdel
ON AficonMovcont
AFTER DELETE
AS
 BEGIN
INSERT INTO AficonMovcont_log(
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER AficonMovcontupd
GO

 CREATE TRIGGER AficonMovcontupd
ON AficonMovcont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO AficonMovcont_log(
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
ActivoFijo_Id,
Inactivo,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER afiModulosins
GO

 CREATE TRIGGER afiModulosins
ON afiModulos
AFTER INSERT
AS
 BEGIN
INSERT INTO afiModulos_log(
Asiento_Id,
Renglon,
ActivoFijo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
ActivoFijo_Id,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER afiModulosdel
GO

 CREATE TRIGGER afiModulosdel
ON afiModulos
AFTER DELETE
AS
 BEGIN
INSERT INTO afiModulos_log(
Asiento_Id,
Renglon,
ActivoFijo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
ActivoFijo_Id,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER afiModulosupd
GO

 CREATE TRIGGER afiModulosupd
ON afiModulos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiModulos_log(
Asiento_Id,
Renglon,
ActivoFijo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
ActivoFijo_Id,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER afiMovimientosins
GO

 CREATE TRIGGER afiMovimientosins
ON afiMovimientos
AFTER INSERT
AS
 BEGIN
INSERT INTO afiMovimientos_log(
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
GETDATE(),
'ins'
FROM inserted where afiActivoFijo=inserted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiMovimientosdel
GO

 CREATE TRIGGER afiMovimientosdel
ON afiMovimientos
AFTER DELETE
AS
 BEGIN
INSERT INTO afiMovimientos_log(
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
GETDATE(),
'del'
FROM deleted where afiActivoFijo=deleted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiMovimientosupd
GO

 CREATE TRIGGER afiMovimientosupd
ON afiMovimientos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiMovimientos_log(
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
afiActivoFijo,
Renglon,
conAsientos,
TipoMov,
GETDATE(),
'upd'
FROM inserted where afiActivoFijo=inserted.afiActivoFijo)
 END
GO

 DROP TRIGGER afiRubrosins
GO

 CREATE TRIGGER afiRubrosins
ON afiRubros
AFTER INSERT
AS
 BEGIN
INSERT INTO afiRubros_log(
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
GETDATE(),
'ins'
FROM inserted where afiRubros=inserted.afiRubros)
 END
GO

 DROP TRIGGER afiRubrosdel
GO

 CREATE TRIGGER afiRubrosdel
ON afiRubros
AFTER DELETE
AS
 BEGIN
INSERT INTO afiRubros_log(
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
GETDATE(),
'del'
FROM deleted where afiRubros=deleted.afiRubros)
 END
GO

 DROP TRIGGER afiRubrosupd
GO

 CREATE TRIGGER afiRubrosupd
ON afiRubros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO afiRubros_log(
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
afiRubros,
Rubro_Id,
Descripcion,
Empresa_Id,
VidaUtil,
VidaUtilFiscal,
CtaValorOrigen_Id,
CtaAmortAcum_Id,
CtaAmortizacion_Id,
Tipo,
Digitos,
Usuario_Id,
FechaAlta,
Posteado,
GETDATE(),
'upd'
FROM inserted where afiRubros=inserted.afiRubros)
 END
GO

 DROP TRIGGER comAsiCierreins
GO

 CREATE TRIGGER comAsiCierreins
ON comAsiCierre
AFTER INSERT
AS
 BEGIN
INSERT INTO comAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiCierredel
GO

 CREATE TRIGGER comAsiCierredel
ON comAsiCierre
AFTER DELETE
AS
 BEGIN
INSERT INTO comAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiCierreupd
GO

 CREATE TRIGGER comAsiCierreupd
ON comAsiCierre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiCierreCrins
GO

 CREATE TRIGGER comAsiCierreCrins
ON comAsiCierreCr
AFTER INSERT
AS
 BEGIN
INSERT INTO comAsiCierreCr_log(
Asiento_Id,
conRenglon,
Proveed_id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Proveed_id,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiCierreCrdel
GO

 CREATE TRIGGER comAsiCierreCrdel
ON comAsiCierreCr
AFTER DELETE
AS
 BEGIN
INSERT INTO comAsiCierreCr_log(
Asiento_Id,
conRenglon,
Proveed_id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Proveed_id,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiCierreCrupd
GO

 CREATE TRIGGER comAsiCierreCrupd
ON comAsiCierreCr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comAsiCierreCr_log(
Asiento_Id,
conRenglon,
Proveed_id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Proveed_id,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comAsiSegmentosAnulins
GO

 CREATE TRIGGER comAsiSegmentosAnulins
ON comAsiSegmentosAnul
AFTER INSERT
AS
 BEGIN
INSERT INTO comAsiSegmentosAnul_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comAsiSegmentosAnuldel
GO

 CREATE TRIGGER comAsiSegmentosAnuldel
ON comAsiSegmentosAnul
AFTER DELETE
AS
 BEGIN
INSERT INTO comAsiSegmentosAnul_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER comAsiSegmentosAnulupd
GO

 CREATE TRIGGER comAsiSegmentosAnulupd
ON comAsiSegmentosAnul
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comAsiSegmentosAnul_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaAnulacion,
Usuario_Id,
Asiento_Id,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comCategoriasins
GO

 CREATE TRIGGER comCategoriasins
ON comCategorias
AFTER INSERT
AS
 BEGIN
INSERT INTO comCategorias_log(
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
GETDATE(),
'ins'
FROM inserted where comCategorias=inserted.comCategorias)
 END
GO

 DROP TRIGGER comCategoriasdel
GO

 CREATE TRIGGER comCategoriasdel
ON comCategorias
AFTER DELETE
AS
 BEGIN
INSERT INTO comCategorias_log(
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
GETDATE(),
'del'
FROM deleted where comCategorias=deleted.comCategorias)
 END
GO

 DROP TRIGGER comCategoriasupd
GO

 CREATE TRIGGER comCategoriasupd
ON comCategorias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comCategorias_log(
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
comCategorias,
Categoria_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
Empresa_id,
GETDATE(),
'upd'
FROM inserted where comCategorias=inserted.comCategorias)
 END
GO

 DROP TRIGGER comCFDISatins
GO

 CREATE TRIGGER comCFDISatins
ON comCFDISat
AFTER INSERT
AS
 BEGIN
INSERT INTO comCFDISat_log(
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
GETDATE(),
'ins'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER comCFDISatdel
GO

 CREATE TRIGGER comCFDISatdel
ON comCFDISat
AFTER DELETE
AS
 BEGIN
INSERT INTO comCFDISat_log(
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
GETDATE(),
'del'
FROM deleted where UUID=deleted.UUID)
 END
GO

 DROP TRIGGER comCFDISatupd
GO

 CREATE TRIGGER comCFDISatupd
ON comCFDISat
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comCFDISat_log(
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCEmisor,
Fecha,
Monto,
Folio,
Serie,
Subido,
XML,
Usuario,
FechaCarga,
TipoDeComprobante,
GETDATE(),
'upd'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER comCFDISatPagoins
GO

 CREATE TRIGGER comCFDISatPagoins
ON comCFDISatPago
AFTER INSERT
AS
 BEGIN
INSERT INTO comCFDISatPago_log(
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
GETDATE(),
'ins'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER comCFDISatPagodel
GO

 CREATE TRIGGER comCFDISatPagodel
ON comCFDISatPago
AFTER DELETE
AS
 BEGIN
INSERT INTO comCFDISatPago_log(
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
GETDATE(),
'del'
FROM deleted where UUID=deleted.UUID)
 END
GO

 DROP TRIGGER comCFDISatPagoupd
GO

 CREATE TRIGGER comCFDISatPagoupd
ON comCFDISatPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comCFDISatPago_log(
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Renglon,
UUIDR,
Monto,
Moneda,
GETDATE(),
'upd'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER comCondFiscalins
GO

 CREATE TRIGGER comCondFiscalins
ON comCondFiscal
AFTER INSERT
AS
 BEGIN
INSERT INTO comCondFiscal_log(
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comCondFiscal=inserted.comCondFiscal)
 END
GO

 DROP TRIGGER comCondFiscaldel
GO

 CREATE TRIGGER comCondFiscaldel
ON comCondFiscal
AFTER DELETE
AS
 BEGIN
INSERT INTO comCondFiscal_log(
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comCondFiscal=deleted.comCondFiscal)
 END
GO

 DROP TRIGGER comCondFiscalupd
GO

 CREATE TRIGGER comCondFiscalupd
ON comCondFiscal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comCondFiscal_log(
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comCondFiscal,
CondFiscal_Id,
Empresa_Id,
Descripcion,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comCondFiscal=inserted.comCondFiscal)
 END
GO

 DROP TRIGGER comConPagoins
GO

 CREATE TRIGGER comConPagoins
ON comConPago
AFTER INSERT
AS
 BEGIN
INSERT INTO comConPago_log(
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comConPago=inserted.comConPago)
 END
GO

 DROP TRIGGER comConPagodel
GO

 CREATE TRIGGER comConPagodel
ON comConPago
AFTER DELETE
AS
 BEGIN
INSERT INTO comConPago_log(
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comConPago=deleted.comConPago)
 END
GO

 DROP TRIGGER comConPagoupd
GO

 CREATE TRIGGER comConPagoupd
ON comConPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comConPago_log(
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comConPago,
CondPago_Id,
Empresa_Id,
Descripcion,
Desde,
Dias,
CantidadCuotas,
AplicaFactCredito,
AdmiteFactPagoAdel,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comConPago=inserted.comConPago)
 END
GO

 DROP TRIGGER comDespachosins
GO

 CREATE TRIGGER comDespachosins
ON comDespachos
AFTER INSERT
AS
 BEGIN
INSERT INTO comDespachos_log(
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where comDespachos=inserted.comDespachos)
 END
GO

 DROP TRIGGER comDespachosdel
GO

 CREATE TRIGGER comDespachosdel
ON comDespachos
AFTER DELETE
AS
 BEGIN
INSERT INTO comDespachos_log(
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where comDespachos=deleted.comDespachos)
 END
GO

 DROP TRIGGER comDespachosupd
GO

 CREATE TRIGGER comDespachosupd
ON comDespachos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comDespachos_log(
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comDespachos,
Empresa_Id,
Despacho_Id,
Origen,
Aduana,
Fecha,
Aduana_Id,
Anio,
Patente,
Pedimento,
Cambio,
FechaModificacion,
Moneda_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where comDespachos=inserted.comDespachos)
 END
GO

 DROP TRIGGER comEliminaPendOCins
GO

 CREATE TRIGGER comEliminaPendOCins
ON comEliminaPendOC
AFTER INSERT
AS
 BEGIN
INSERT INTO comEliminaPendOC_log(
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comEliminaPendOCdel
GO

 CREATE TRIGGER comEliminaPendOCdel
ON comEliminaPendOC
AFTER DELETE
AS
 BEGIN
INSERT INTO comEliminaPendOC_log(
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comEliminaPendOCupd
GO

 CREATE TRIGGER comEliminaPendOCupd
ON comEliminaPendOC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEliminaPendOC_log(
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
Asiento_Id,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comEmbarquesins
GO

 CREATE TRIGGER comEmbarquesins
ON comEmbarques
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbarques_log(
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
GETDATE(),
'ins'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbarquesdel
GO

 CREATE TRIGGER comEmbarquesdel
ON comEmbarques
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbarques_log(
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
GETDATE(),
'del'
FROM deleted where comEmbarques=deleted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbarquesupd
GO

 CREATE TRIGGER comEmbarquesupd
ON comEmbarques
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbarques_log(
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
TipoTransporte,
NroOrdenExterior,
FechaEmbarque,
FechaArribo,
PesoTotal,
Estado_Id,
GETDATE(),
'upd'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbAsiCierreins
GO

 CREATE TRIGGER comEmbAsiCierreins
ON comEmbAsiCierre
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbAsiCierre_log(
comEmbarques,
stkMoviCabe,
Cambio,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
stkMoviCabe,
Cambio,
GETDATE(),
'ins'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbAsiCierredel
GO

 CREATE TRIGGER comEmbAsiCierredel
ON comEmbAsiCierre
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbAsiCierre_log(
comEmbarques,
stkMoviCabe,
Cambio,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
stkMoviCabe,
Cambio,
GETDATE(),
'del'
FROM deleted where comEmbarques=deleted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbAsiCierreupd
GO

 CREATE TRIGGER comEmbAsiCierreupd
ON comEmbAsiCierre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbAsiCierre_log(
comEmbarques,
stkMoviCabe,
Cambio,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
stkMoviCabe,
Cambio,
GETDATE(),
'upd'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbCuerpoins
GO

 CREATE TRIGGER comEmbCuerpoins
ON comEmbCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbCuerpo_log(
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
GETDATE(),
'ins'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbCuerpodel
GO

 CREATE TRIGGER comEmbCuerpodel
ON comEmbCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbCuerpo_log(
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
GETDATE(),
'del'
FROM deleted where comEmbarques=deleted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbCuerpoupd
GO

 CREATE TRIGGER comEmbCuerpoupd
ON comEmbCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbCuerpo_log(
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
CantidadRecibida,
CantidadFacturada,
PrecioCalculadoOriginal,
PrecioCalculado,
RenglonDebe,
RenglonHaber,
GETDATE(),
'upd'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbEstadoins
GO

 CREATE TRIGGER comEmbEstadoins
ON comEmbEstado
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER comEmbEstadodel
GO

 CREATE TRIGGER comEmbEstadodel
ON comEmbEstado
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Estado_Id=deleted.Estado_Id)
 END
GO

 DROP TRIGGER comEmbEstadoupd
GO

 CREATE TRIGGER comEmbEstadoupd
ON comEmbEstado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER comEmbGastoMovProvins
GO

 CREATE TRIGGER comEmbGastoMovProvins
ON comEmbGastoMovProv
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbGastoMovProv_log(
comMovProv,
comRenglon,
comEmbarques,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comRenglon,
comEmbarques,
Renglon,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comEmbGastoMovProvdel
GO

 CREATE TRIGGER comEmbGastoMovProvdel
ON comEmbGastoMovProv
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbGastoMovProv_log(
comMovProv,
comRenglon,
comEmbarques,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comRenglon,
comEmbarques,
Renglon,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comEmbGastoMovProvupd
GO

 CREATE TRIGGER comEmbGastoMovProvupd
ON comEmbGastoMovProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbGastoMovProv_log(
comMovProv,
comRenglon,
comEmbarques,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comRenglon,
comEmbarques,
Renglon,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comEmbGastosins
GO

 CREATE TRIGGER comEmbGastosins
ON comEmbGastos
AFTER INSERT
AS
 BEGIN
INSERT INTO comEmbGastos_log(
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
GETDATE(),
'ins'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbGastosdel
GO

 CREATE TRIGGER comEmbGastosdel
ON comEmbGastos
AFTER DELETE
AS
 BEGIN
INSERT INTO comEmbGastos_log(
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
GETDATE(),
'del'
FROM deleted where comEmbarques=deleted.comEmbarques)
 END
GO

 DROP TRIGGER comEmbGastosupd
GO

 CREATE TRIGGER comEmbGastosupd
ON comEmbGastos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEmbGastos_log(
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
FechaModifLog,
TipoModificacion
)
(Select 
comEmbarques,
Renglon,
Detalle,
ImporteOriginal,
Importe,
Moneda_Id,
CantidadImporte,
GETDATE(),
'upd'
FROM inserted where comEmbarques=inserted.comEmbarques)
 END
GO

 DROP TRIGGER comEsquemaAutoins
GO

 CREATE TRIGGER comEsquemaAutoins
ON comEsquemaAuto
AFTER INSERT
AS
 BEGIN
INSERT INTO comEsquemaAuto_log(
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where comEsquemaAuto=inserted.comEsquemaAuto)
 END
GO

 DROP TRIGGER comEsquemaAutodel
GO

 CREATE TRIGGER comEsquemaAutodel
ON comEsquemaAuto
AFTER DELETE
AS
 BEGIN
INSERT INTO comEsquemaAuto_log(
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where comEsquemaAuto=deleted.comEsquemaAuto)
 END
GO

 DROP TRIGGER comEsquemaAutoupd
GO

 CREATE TRIGGER comEsquemaAutoupd
ON comEsquemaAuto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEsquemaAuto_log(
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where comEsquemaAuto=inserted.comEsquemaAuto)
 END
GO

 DROP TRIGGER comEsquemaAutoRengins
GO

 CREATE TRIGGER comEsquemaAutoRengins
ON comEsquemaAutoReng
AFTER INSERT
AS
 BEGIN
INSERT INTO comEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
GETDATE(),
'ins'
FROM inserted where EsquemaAuto_Id=inserted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER comEsquemaAutoRengdel
GO

 CREATE TRIGGER comEsquemaAutoRengdel
ON comEsquemaAutoReng
AFTER DELETE
AS
 BEGIN
INSERT INTO comEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
GETDATE(),
'del'
FROM deleted where EsquemaAuto_Id=deleted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER comEsquemaAutoRengupd
GO

 CREATE TRIGGER comEsquemaAutoRengupd
ON comEsquemaAutoReng
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
NivelAuto_Id,
Formula,
GETDATE(),
'upd'
FROM inserted where EsquemaAuto_Id=inserted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER comFactuReceOcins
GO

 CREATE TRIGGER comFactuReceOcins
ON comFactuReceOc
AFTER INSERT
AS
 BEGIN
INSERT INTO comFactuReceOc_log(
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comFactuReceOcdel
GO

 CREATE TRIGGER comFactuReceOcdel
ON comFactuReceOc
AFTER DELETE
AS
 BEGIN
INSERT INTO comFactuReceOc_log(
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comFactuReceOcupd
GO

 CREATE TRIGGER comFactuReceOcupd
ON comFactuReceOc
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comFactuReceOc_log(
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
comOcRecepcion,
conRenglon,
Cantidad,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comFactuReceStkins
GO

 CREATE TRIGGER comFactuReceStkins
ON comFactuReceStk
AFTER INSERT
AS
 BEGIN
INSERT INTO comFactuReceStk_log(
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comFactuReceStkdel
GO

 CREATE TRIGGER comFactuReceStkdel
ON comFactuReceStk
AFTER DELETE
AS
 BEGIN
INSERT INTO comFactuReceStk_log(
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comFactuReceStkupd
GO

 CREATE TRIGGER comFactuReceStkupd
ON comFactuReceStk
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comFactuReceStk_log(
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
stkMoviCabe,
Renglon,
Cantidad,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comForEntreins
GO

 CREATE TRIGGER comForEntreins
ON comForEntre
AFTER INSERT
AS
 BEGIN
INSERT INTO comForEntre_log(
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comForEntre=inserted.comForEntre)
 END
GO

 DROP TRIGGER comForEntredel
GO

 CREATE TRIGGER comForEntredel
ON comForEntre
AFTER DELETE
AS
 BEGIN
INSERT INTO comForEntre_log(
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comForEntre=deleted.comForEntre)
 END
GO

 DROP TRIGGER comForEntreupd
GO

 CREATE TRIGGER comForEntreupd
ON comForEntre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comForEntre_log(
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comForEntre,
FormaEnt_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comForEntre=inserted.comForEntre)
 END
GO

 DROP TRIGGER comImpuestosins
GO

 CREATE TRIGGER comImpuestosins
ON comImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO comImpuestos_log(
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comImpuestos=inserted.comImpuestos)
 END
GO

 DROP TRIGGER comImpuestosdel
GO

 CREATE TRIGGER comImpuestosdel
ON comImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO comImpuestos_log(
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comImpuestos=deleted.comImpuestos)
 END
GO

 DROP TRIGGER comImpuestosupd
GO

 CREATE TRIGGER comImpuestosupd
ON comImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comImpuestos_log(
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
Formulacalc,
CtaDebe,
CtaHaber,
CtaReversion,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
VaAlCosto,
PorAcreditacion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comImpuestos=inserted.comImpuestos)
 END
GO

 DROP TRIGGER comLIbrosins
GO

 CREATE TRIGGER comLIbrosins
ON comLIbros
AFTER INSERT
AS
 BEGIN
INSERT INTO comLIbros_log(
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comLIbrosdel
GO

 CREATE TRIGGER comLIbrosdel
ON comLIbros
AFTER DELETE
AS
 BEGIN
INSERT INTO comLIbros_log(
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where comLibros=deleted.comLibros)
 END
GO

 DROP TRIGGER comLIbrosupd
GO

 CREATE TRIGGER comLIbrosupd
ON comLIbros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comLIbros_log(
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comLibrosColumnasins
GO

 CREATE TRIGGER comLibrosColumnasins
ON comLibrosColumnas
AFTER INSERT
AS
 BEGIN
INSERT INTO comLibrosColumnas_log(
comLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
Titulo,
GETDATE(),
'ins'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comLibrosColumnasdel
GO

 CREATE TRIGGER comLibrosColumnasdel
ON comLibrosColumnas
AFTER DELETE
AS
 BEGIN
INSERT INTO comLibrosColumnas_log(
comLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
Titulo,
GETDATE(),
'del'
FROM deleted where comLibros=deleted.comLibros)
 END
GO

 DROP TRIGGER comLibrosColumnasupd
GO

 CREATE TRIGGER comLibrosColumnasupd
ON comLibrosColumnas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comLibrosColumnas_log(
comLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
Titulo,
GETDATE(),
'upd'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comLibrosImpuestosins
GO

 CREATE TRIGGER comLibrosImpuestosins
ON comLibrosImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO comLibrosImpuestos_log(
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
GETDATE(),
'ins'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comLibrosImpuestosdel
GO

 CREATE TRIGGER comLibrosImpuestosdel
ON comLibrosImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO comLibrosImpuestos_log(
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
GETDATE(),
'del'
FROM deleted where comLibros=deleted.comLibros)
 END
GO

 DROP TRIGGER comLibrosImpuestosupd
GO

 CREATE TRIGGER comLibrosImpuestosupd
ON comLibrosImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comLibrosImpuestos_log(
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comLibros,
Columna,
TipoRenglon,
Impuesto_Id,
GETDATE(),
'upd'
FROM inserted where comLibros=inserted.comLibros)
 END
GO

 DROP TRIGGER comListaNegraMXins
GO

 CREATE TRIGGER comListaNegraMXins
ON comListaNegraMX
AFTER INSERT
AS
 BEGIN
INSERT INTO comListaNegraMX_log(
RFC,
RazonSocial,
Situacion,
FechaModifLog,
TipoModificacion
)
(Select 
RFC,
RazonSocial,
Situacion,
GETDATE(),
'ins'
FROM inserted where RFC=inserted.RFC)
 END
GO

 DROP TRIGGER comListaNegraMXdel
GO

 CREATE TRIGGER comListaNegraMXdel
ON comListaNegraMX
AFTER DELETE
AS
 BEGIN
INSERT INTO comListaNegraMX_log(
RFC,
RazonSocial,
Situacion,
FechaModifLog,
TipoModificacion
)
(Select 
RFC,
RazonSocial,
Situacion,
GETDATE(),
'del'
FROM deleted where RFC=deleted.RFC)
 END
GO

 DROP TRIGGER comListaNegraMXupd
GO

 CREATE TRIGGER comListaNegraMXupd
ON comListaNegraMX
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comListaNegraMX_log(
RFC,
RazonSocial,
Situacion,
FechaModifLog,
TipoModificacion
)
(Select 
RFC,
RazonSocial,
Situacion,
GETDATE(),
'upd'
FROM inserted where RFC=inserted.RFC)
 END
GO

 DROP TRIGGER comMovDetalleins
GO

 CREATE TRIGGER comMovDetalleins
ON comMovDetalle
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovDetalle_log(
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovDetalledel
GO

 CREATE TRIGGER comMovDetalledel
ON comMovDetalle
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovDetalle_log(
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovDetalleupd
GO

 CREATE TRIGGER comMovDetalleupd
ON comMovDetalle
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovDetalle_log(
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
Detalle,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovDetalleContins
GO

 CREATE TRIGGER comMovDetalleContins
ON comMovDetalleCont
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovDetalleCont_log(
comMovProv,
Renglon,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
conRenglon,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovDetalleContdel
GO

 CREATE TRIGGER comMovDetalleContdel
ON comMovDetalleCont
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovDetalleCont_log(
comMovProv,
Renglon,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
conRenglon,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovDetalleContupd
GO

 CREATE TRIGGER comMovDetalleContupd
ON comMovDetalleCont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovDetalleCont_log(
comMovProv,
Renglon,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
conRenglon,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovImpAcreditains
GO

 CREATE TRIGGER comMovImpAcreditains
ON comMovImpAcredita
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovImpAcredita_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovImpAcreditadel
GO

 CREATE TRIGGER comMovImpAcreditadel
ON comMovImpAcredita
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovImpAcredita_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovImpAcreditaupd
GO

 CREATE TRIGGER comMovImpAcreditaupd
ON comMovImpAcredita
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovImpAcredita_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
comMovProv,
tesMovimientos,
Impuesto_Id,
Cartera_Id,
BaseImponible,
Monto,
TotalPago,
Origen,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovImpuestosins
GO

 CREATE TRIGGER comMovImpuestosins
ON comMovImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovImpuestos_log(
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovImpuestosdel
GO

 CREATE TRIGGER comMovImpuestosdel
ON comMovImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovImpuestos_log(
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovImpuestosupd
GO

 CREATE TRIGGER comMovImpuestosupd
ON comMovImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovImpuestos_log(
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovpAnexoins
GO

 CREATE TRIGGER comMovpAnexoins
ON comMovpAnexo
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovpAnexo_log(
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexodel
GO

 CREATE TRIGGER comMovpAnexodel
ON comMovpAnexo
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovpAnexo_log(
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoupd
GO

 CREATE TRIGGER comMovpAnexoupd
ON comMovpAnexo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovpAnexo_log(
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
ProvAnexo,
tesRengMovi_Id,
RenglonRengMovi,
Fecha_Ane,
FechaFiscal,
CondFiscal_Id,
Origen_Id,
VieneDeFiscal,
XMLFiscal,
ClaveFiscal,
conRenglonProv,
TipoCompFE,
tesMovimientos,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoContins
GO

 CREATE TRIGGER comMovpAnexoContins
ON comMovpAnexoCont
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovpAnexoCont_log(
Asiento_Id,
conRenglon,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Renglon,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoContdel
GO

 CREATE TRIGGER comMovpAnexoContdel
ON comMovpAnexoCont
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovpAnexoCont_log(
Asiento_Id,
conRenglon,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Renglon,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoContupd
GO

 CREATE TRIGGER comMovpAnexoContupd
ON comMovpAnexoCont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovpAnexoCont_log(
Asiento_Id,
conRenglon,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Renglon,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoDetalleins
GO

 CREATE TRIGGER comMovpAnexoDetalleins
ON comMovpAnexoDetalle
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovpAnexoDetalle_log(
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoDetalledel
GO

 CREATE TRIGGER comMovpAnexoDetalledel
ON comMovpAnexoDetalle
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovpAnexoDetalle_log(
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovpAnexoDetalleupd
GO

 CREATE TRIGGER comMovpAnexoDetalleupd
ON comMovpAnexoDetalle
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovpAnexoDetalle_log(
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Renglon,
Importe,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Base_Id,
Detalle,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovPOCins
GO

 CREATE TRIGGER comMovPOCins
ON comMovPOC
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovPOC_log(
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovPOCdel
GO

 CREATE TRIGGER comMovPOCdel
ON comMovPOC
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovPOC_log(
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovPOCupd
GO

 CREATE TRIGGER comMovPOCupd
ON comMovPOC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovPOC_log(
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comOrdenComp,
Renglon_OC,
Cantidad,
CantidadOriginal,
Factor,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvins
GO

 CREATE TRIGGER comMovProvins
ON comMovProv
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovProv_log(
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvdel
GO

 CREATE TRIGGER comMovProvdel
ON comMovProv
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovProv_log(
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvupd
GO

 CREATE TRIGGER comMovProvupd
ON comMovProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovProv_log(
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Proveed_Id,
TipoMov,
TipoCtaProv,
Fecha_CCP,
Base_Ganancias,
Importacion,
ComCondPago_Id,
CondFiscal_Id,
Origen_Id,
FechaFiscal,
ClaveFiscal,
VieneDeFiscal,
XMLFiscal,
Importe,
Saldo,
TipoCompFE,
FacturaTesoreria,
RenglonDtoFin,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvAnexoImpins
GO

 CREATE TRIGGER comMovProvAnexoImpins
ON comMovProvAnexoImp
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovProvAnexoImp_log(
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovProvAnexoImpdel
GO

 CREATE TRIGGER comMovProvAnexoImpdel
ON comMovProvAnexoImp
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovProvAnexoImp_log(
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovProvAnexoImpupd
GO

 CREATE TRIGGER comMovProvAnexoImpupd
ON comMovProvAnexoImp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovProvAnexoImp_log(
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Impuesto_Id,
Porcentaje,
Base_Imponible,
Importe_Impuesto,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER comMovProvDPreFactDirins
GO

 CREATE TRIGGER comMovProvDPreFactDirins
ON comMovProvDPreFactDir
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovProvDPreFactDir_log(
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvDPreFactDirdel
GO

 CREATE TRIGGER comMovProvDPreFactDirdel
ON comMovProvDPreFactDir
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovProvDPreFactDir_log(
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvDPreFactDirupd
GO

 CREATE TRIGGER comMovProvDPreFactDirupd
ON comMovProvDPreFactDir
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovProvDPreFactDir_log(
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
stkMoviCabe,
RenglonStk,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvDPreOCins
GO

 CREATE TRIGGER comMovProvDPreOCins
ON comMovProvDPreOC
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovProvDPreOC_log(
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvDPreOCdel
GO

 CREATE TRIGGER comMovProvDPreOCdel
ON comMovProvDPreOC
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovProvDPreOC_log(
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvDPreOCupd
GO

 CREATE TRIGGER comMovProvDPreOCupd
ON comMovProvDPreOC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovProvDPreOC_log(
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Renglon,
comMovProvFactOrig,
comOrdenComp,
Renglon_OC,
CantidadOriginal,
Cantidad,
Descuento,
Monto,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvEmbins
GO

 CREATE TRIGGER comMovProvEmbins
ON comMovProvEmb
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovProvEmb_log(
comMovProv,
comEmbarques,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comEmbarques,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvEmbdel
GO

 CREATE TRIGGER comMovProvEmbdel
ON comMovProvEmb
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovProvEmb_log(
comMovProv,
comEmbarques,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comEmbarques,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comMovProvEmbupd
GO

 CREATE TRIGGER comMovProvEmbupd
ON comMovProvEmb
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovProvEmb_log(
comMovProv,
comEmbarques,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
comEmbarques,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comMovTiposins
GO

 CREATE TRIGGER comMovTiposins
ON comMovTipos
AFTER INSERT
AS
 BEGIN
INSERT INTO comMovTipos_log(
TipoMov,
Descripcion,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
GETDATE(),
'ins'
FROM inserted where TipoMov=inserted.TipoMov)
 END
GO

 DROP TRIGGER comMovTiposdel
GO

 CREATE TRIGGER comMovTiposdel
ON comMovTipos
AFTER DELETE
AS
 BEGIN
INSERT INTO comMovTipos_log(
TipoMov,
Descripcion,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
GETDATE(),
'del'
FROM deleted where TipoMov=deleted.TipoMov)
 END
GO

 DROP TRIGGER comMovTiposupd
GO

 CREATE TRIGGER comMovTiposupd
ON comMovTipos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comMovTipos_log(
TipoMov,
Descripcion,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
GETDATE(),
'upd'
FROM inserted where TipoMov=inserted.TipoMov)
 END
GO

 DROP TRIGGER comNivelesAutoins
GO

 CREATE TRIGGER comNivelesAutoins
ON comNivelesAuto
AFTER INSERT
AS
 BEGIN
INSERT INTO comNivelesAuto_log(
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where comNivelesAuto=inserted.comNivelesAuto)
 END
GO

 DROP TRIGGER comNivelesAutodel
GO

 CREATE TRIGGER comNivelesAutodel
ON comNivelesAuto
AFTER DELETE
AS
 BEGIN
INSERT INTO comNivelesAuto_log(
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where comNivelesAuto=deleted.comNivelesAuto)
 END
GO

 DROP TRIGGER comNivelesAutoupd
GO

 CREATE TRIGGER comNivelesAutoupd
ON comNivelesAuto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comNivelesAuto_log(
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where comNivelesAuto=inserted.comNivelesAuto)
 END
GO

 DROP TRIGGER comNivelesAutoUsuins
GO

 CREATE TRIGGER comNivelesAutoUsuins
ON comNivelesAutoUsu
AFTER INSERT
AS
 BEGIN
INSERT INTO comNivelesAutoUsu_log(
NivelAuto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
NivelAuto_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where NivelAuto_Id=inserted.NivelAuto_Id)
 END
GO

 DROP TRIGGER comNivelesAutoUsudel
GO

 CREATE TRIGGER comNivelesAutoUsudel
ON comNivelesAutoUsu
AFTER DELETE
AS
 BEGIN
INSERT INTO comNivelesAutoUsu_log(
NivelAuto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
NivelAuto_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where NivelAuto_Id=deleted.NivelAuto_Id)
 END
GO

 DROP TRIGGER comNivelesAutoUsuupd
GO

 CREATE TRIGGER comNivelesAutoUsuupd
ON comNivelesAutoUsu
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comNivelesAutoUsu_log(
NivelAuto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
NivelAuto_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where NivelAuto_Id=inserted.NivelAuto_Id)
 END
GO

 DROP TRIGGER comOcAntiRecepcionins
GO

 CREATE TRIGGER comOcAntiRecepcionins
ON comOcAntiRecepcion
AFTER INSERT
AS
 BEGIN
INSERT INTO comOcAntiRecepcion_log(
comAntiRecepcion,
comOcRecepcion,
FechaModifLog,
TipoModificacion
)
(Select 
comAntiRecepcion,
comOcRecepcion,
GETDATE(),
'ins'
FROM inserted where comAntiRecepcion=inserted.comAntiRecepcion)
 END
GO

 DROP TRIGGER comOcAntiRecepciondel
GO

 CREATE TRIGGER comOcAntiRecepciondel
ON comOcAntiRecepcion
AFTER DELETE
AS
 BEGIN
INSERT INTO comOcAntiRecepcion_log(
comAntiRecepcion,
comOcRecepcion,
FechaModifLog,
TipoModificacion
)
(Select 
comAntiRecepcion,
comOcRecepcion,
GETDATE(),
'del'
FROM deleted where comAntiRecepcion=deleted.comAntiRecepcion)
 END
GO

 DROP TRIGGER comOcAntiRecepcionupd
GO

 CREATE TRIGGER comOcAntiRecepcionupd
ON comOcAntiRecepcion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOcAntiRecepcion_log(
comAntiRecepcion,
comOcRecepcion,
FechaModifLog,
TipoModificacion
)
(Select 
comAntiRecepcion,
comOcRecepcion,
GETDATE(),
'upd'
FROM inserted where comAntiRecepcion=inserted.comAntiRecepcion)
 END
GO

 DROP TRIGGER comOCArticuloins
GO

 CREATE TRIGGER comOCArticuloins
ON comOCArticulo
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCArticulo_log(
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCArticulodel
GO

 CREATE TRIGGER comOCArticulodel
ON comOCArticulo
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCArticulo_log(
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCArticuloupd
GO

 CREATE TRIGGER comOCArticuloupd
ON comOCArticulo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCArticulo_log(
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCAutorizandoins
GO

 CREATE TRIGGER comOCAutorizandoins
ON comOCAutorizando
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCAutorizando_log(
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCAutorizandodel
GO

 CREATE TRIGGER comOCAutorizandodel
ON comOCAutorizando
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCAutorizando_log(
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCAutorizandoupd
GO

 CREATE TRIGGER comOCAutorizandoupd
ON comOCAutorizando
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCAutorizando_log(
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCCuerpoins
GO

 CREATE TRIGGER comOCCuerpoins
ON comOCCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCCuerpo_log(
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCCuerpodel
GO

 CREATE TRIGGER comOCCuerpodel
ON comOCCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCCuerpo_log(
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCCuerpoupd
GO

 CREATE TRIGGER comOCCuerpoupd
ON comOCCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCCuerpo_log(
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Cantidad,
Cantidad_Recibida,
Cantidad_Embarcada,
Cantidad_Facturada,
Cantidad_Creditos,
Fecha_Entrega,
Precio,
Pendiente,
Medida_Id,
Centro1_Id,
Centro2_Id,
CantidadConsignada,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOcEstadosins
GO

 CREATE TRIGGER comOcEstadosins
ON comOcEstados
AFTER INSERT
AS
 BEGIN
INSERT INTO comOcEstados_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER comOcEstadosdel
GO

 CREATE TRIGGER comOcEstadosdel
ON comOcEstados
AFTER DELETE
AS
 BEGIN
INSERT INTO comOcEstados_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Estado_Id=deleted.Estado_Id)
 END
GO

 DROP TRIGGER comOcEstadosupd
GO

 CREATE TRIGGER comOcEstadosupd
ON comOcEstados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOcEstados_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER comOCMemoins
GO

 CREATE TRIGGER comOCMemoins
ON comOCMemo
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCMemo_log(
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCMemodel
GO

 CREATE TRIGGER comOCMemodel
ON comOCMemo
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCMemo_log(
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCMemoupd
GO

 CREATE TRIGGER comOCMemoupd
ON comOCMemo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCMemo_log(
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
Detalle,
Cuenta_Id,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOcMovProvins
GO

 CREATE TRIGGER comOcMovProvins
ON comOcMovProv
AFTER INSERT
AS
 BEGIN
INSERT INTO comOcMovProv_log(
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOcMovProvdel
GO

 CREATE TRIGGER comOcMovProvdel
ON comOcMovProv
AFTER DELETE
AS
 BEGIN
INSERT INTO comOcMovProv_log(
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOcMovProvupd
GO

 CREATE TRIGGER comOcMovProvupd
ON comOcMovProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOcMovProv_log(
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
comMovProv,
AnticipoNC,
Importe,
Porcentaje,
DadoRestado,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOcReceCuerpoins
GO

 CREATE TRIGGER comOcReceCuerpoins
ON comOcReceCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO comOcReceCuerpo_log(
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
GETDATE(),
'ins'
FROM inserted where comOcRecepcion=inserted.comOcRecepcion)
 END
GO

 DROP TRIGGER comOcReceCuerpodel
GO

 CREATE TRIGGER comOcReceCuerpodel
ON comOcReceCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO comOcReceCuerpo_log(
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
GETDATE(),
'del'
FROM deleted where comOcRecepcion=deleted.comOcRecepcion)
 END
GO

 DROP TRIGGER comOcReceCuerpoupd
GO

 CREATE TRIGGER comOcReceCuerpoupd
ON comOcReceCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOcReceCuerpo_log(
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
comOcRecepcion,
conRenglon,
comOrdenComp,
Renglon_OC,
Cantidad,
Observaciones,
CantFactPendiente,
GETDATE(),
'upd'
FROM inserted where comOcRecepcion=inserted.comOcRecepcion)
 END
GO

 DROP TRIGGER comOCRIins
GO

 CREATE TRIGGER comOCRIins
ON comOCRI
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCRI_log(
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCRIdel
GO

 CREATE TRIGGER comOCRIdel
ON comOCRI
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCRI_log(
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCRIupd
GO

 CREATE TRIGGER comOCRIupd
ON comOCRI
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCRI_log(
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Renglon_OC,
comReqInterno,
Renglon_RI,
Cantidad,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOCSegmentosins
GO

 CREATE TRIGGER comOCSegmentosins
ON comOCSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO comOCSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comOCSegmentosdel
GO

 CREATE TRIGGER comOCSegmentosdel
ON comOCSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO comOCSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER comOCSegmentosupd
GO

 CREATE TRIGGER comOCSegmentosupd
ON comOCSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOCSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
comOrdenComp,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comOrdenCompins
GO

 CREATE TRIGGER comOrdenCompins
ON comOrdenComp
AFTER INSERT
AS
 BEGIN
INSERT INTO comOrdenComp_log(
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrdenCompdel
GO

 CREATE TRIGGER comOrdenCompdel
ON comOrdenComp
AFTER DELETE
AS
 BEGIN
INSERT INTO comOrdenComp_log(
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrdenCompupd
GO

 CREATE TRIGGER comOrdenCompupd
ON comOrdenComp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOrdenComp_log(
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Fecha,
Proveed_Id,
TipoPermi_Id,
Moneda_Id,
Autorizo,
CondPago_Id,
Impreso,
Observaciones,
Estado_Id,
Saldo_Anticipo,
ImporteImpuestos,
Saldo_NC,
Cambio,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrdenCompDesechadoins
GO

 CREATE TRIGGER comOrdenCompDesechadoins
ON comOrdenCompDesechado
AFTER INSERT
AS
 BEGIN
INSERT INTO comOrdenCompDesechado_log(
comOrdenComp,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
GETDATE(),
'ins'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrdenCompDesechadodel
GO

 CREATE TRIGGER comOrdenCompDesechadodel
ON comOrdenCompDesechado
AFTER DELETE
AS
 BEGIN
INSERT INTO comOrdenCompDesechado_log(
comOrdenComp,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
GETDATE(),
'del'
FROM deleted where comOrdenComp=deleted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrdenCompDesechadoupd
GO

 CREATE TRIGGER comOrdenCompDesechadoupd
ON comOrdenCompDesechado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOrdenCompDesechado_log(
comOrdenComp,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comOrdenComp,
Usuario_Id,
Fecha,
GETDATE(),
'upd'
FROM inserted where comOrdenComp=inserted.comOrdenComp)
 END
GO

 DROP TRIGGER comOrigenesFiscalesins
GO

 CREATE TRIGGER comOrigenesFiscalesins
ON comOrigenesFiscales
AFTER INSERT
AS
 BEGIN
INSERT INTO comOrigenesFiscales_log(
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
GETDATE(),
'ins'
FROM inserted where comOrigenesFiscales=inserted.comOrigenesFiscales)
 END
GO

 DROP TRIGGER comOrigenesFiscalesdel
GO

 CREATE TRIGGER comOrigenesFiscalesdel
ON comOrigenesFiscales
AFTER DELETE
AS
 BEGIN
INSERT INTO comOrigenesFiscales_log(
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
GETDATE(),
'del'
FROM deleted where comOrigenesFiscales=deleted.comOrigenesFiscales)
 END
GO

 DROP TRIGGER comOrigenesFiscalesupd
GO

 CREATE TRIGGER comOrigenesFiscalesupd
ON comOrigenesFiscales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comOrigenesFiscales_log(
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comOrigenesFiscales,
Origen_Id,
Descripcion,
Dominio_Id,
GETDATE(),
'upd'
FROM inserted where comOrigenesFiscales=inserted.comOrigenesFiscales)
 END
GO

 DROP TRIGGER comPagosAnticipoins
GO

 CREATE TRIGGER comPagosAnticipoins
ON comPagosAnticipo
AFTER INSERT
AS
 BEGIN
INSERT INTO comPagosAnticipo_log(
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
FechaModifLog,
TipoModificacion
)
(Select 
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
GETDATE(),
'ins'
FROM inserted where comPagosAnticipo=inserted.comPagosAnticipo)
 END
GO

 DROP TRIGGER comPagosAnticipodel
GO

 CREATE TRIGGER comPagosAnticipodel
ON comPagosAnticipo
AFTER DELETE
AS
 BEGIN
INSERT INTO comPagosAnticipo_log(
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
FechaModifLog,
TipoModificacion
)
(Select 
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
GETDATE(),
'del'
FROM deleted where comPagosAnticipo=deleted.comPagosAnticipo)
 END
GO

 DROP TRIGGER comPagosAnticipoupd
GO

 CREATE TRIGGER comPagosAnticipoupd
ON comPagosAnticipo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comPagosAnticipo_log(
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
FechaModifLog,
TipoModificacion
)
(Select 
comPagosAnticipo,
Proveed_Id,
Importe,
Moneda_Id,
TipoCtaProv,
Empresa_Id,
Cuenta_Id,
Usuario_Id,
tesMovimientos,
comEmbarques,
FechaPago,
GETDATE(),
'upd'
FROM inserted where comPagosAnticipo=inserted.comPagosAnticipo)
 END
GO

 DROP TRIGGER comPagosHabilitadosins
GO

 CREATE TRIGGER comPagosHabilitadosins
ON comPagosHabilitados
AFTER INSERT
AS
 BEGIN
INSERT INTO comPagosHabilitados_log(
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comPagosHabilitadosdel
GO

 CREATE TRIGGER comPagosHabilitadosdel
ON comPagosHabilitados
AFTER DELETE
AS
 BEGIN
INSERT INTO comPagosHabilitados_log(
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comPagosHabilitadosupd
GO

 CREATE TRIGGER comPagosHabilitadosupd
ON comPagosHabilitados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comPagosHabilitados_log(
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
Secuencia,
Usuario_Id,
FechaHabilitacion,
ImporteHabilitado,
tesMovimientos,
Importe1,
Importe2,
Importe3,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comProvAnexoins
GO

 CREATE TRIGGER comProvAnexoins
ON comProvAnexo
AFTER INSERT
AS
 BEGIN
INSERT INTO comProvAnexo_log(
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProvAnexodel
GO

 CREATE TRIGGER comProvAnexodel
ON comProvAnexo
AFTER DELETE
AS
 BEGIN
INSERT INTO comProvAnexo_log(
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER comProvAnexoupd
GO

 CREATE TRIGGER comProvAnexoupd
ON comProvAnexo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProvAnexo_log(
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
RazonSocial,
Direccion1,
Direccion2,
Localidad,
Cod_Postal,
Provincia_Id,
CondFiscal_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProvCtasContrapins
GO

 CREATE TRIGGER comProvCtasContrapins
ON comProvCtasContrap
AFTER INSERT
AS
 BEGIN
INSERT INTO comProvCtasContrap_log(
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
GETDATE(),
'ins'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProvCtasContrapdel
GO

 CREATE TRIGGER comProvCtasContrapdel
ON comProvCtasContrap
AFTER DELETE
AS
 BEGIN
INSERT INTO comProvCtasContrap_log(
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
GETDATE(),
'del'
FROM deleted where Proveed_Id=deleted.Proveed_Id)
 END
GO

 DROP TRIGGER comProvCtasContrapupd
GO

 CREATE TRIGGER comProvCtasContrapupd
ON comProvCtasContrap
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProvCtasContrap_log(
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Detalle,
GETDATE(),
'upd'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresins
GO

 CREATE TRIGGER comProveedoresins
ON comProveedores
AFTER INSERT
AS
 BEGIN
INSERT INTO comProveedores_log(
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresdel
GO

 CREATE TRIGGER comProveedoresdel
ON comProveedores
AFTER DELETE
AS
 BEGIN
INSERT INTO comProveedores_log(
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresupd
GO

 CREATE TRIGGER comProveedoresupd
ON comProveedores
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProveedores_log(
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Proveed_Id,
Empresa_Id,
RazonSocial,
NombreLegal,
Direccion1,
Direccion2,
Localidad,
CodigoPostal,
Provincia_Id,
Pais,
Telefono,
Region_Id,
CondPago_Id,
FormaEnt_Id,
Origen_Id,
Contacto,
EMail,
Fax,
Fecha_Alta,
FechaUltActiv,
Letra_Fact,
Observaciones,
CondFiscal_Id,
Ganancias,
IBrutos,
Especializacion,
EsAduana,
TipoCuenta,
NroCuenta,
CBU,
Interbanking,
Banco_Id,
ProvTipo_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresCtasPasivoins
GO

 CREATE TRIGGER comProveedoresCtasPasivoins
ON comProveedoresCtasPasivo
AFTER INSERT
AS
 BEGIN
INSERT INTO comProveedoresCtasPasivo_log(
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresCtasPasivodel
GO

 CREATE TRIGGER comProveedoresCtasPasivodel
ON comProveedoresCtasPasivo
AFTER DELETE
AS
 BEGIN
INSERT INTO comProveedoresCtasPasivo_log(
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresCtasPasivoupd
GO

 CREATE TRIGGER comProveedoresCtasPasivoupd
ON comProveedoresCtasPasivo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProveedoresCtasPasivo_log(
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
TipoCtaProv,
Moneda_Id,
Cuenta_Id,
ctaPagoXAdelantado,
CtaAnticipo,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER comProveedoresImpuestosins
GO

 CREATE TRIGGER comProveedoresImpuestosins
ON comProveedoresImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO comProveedoresImpuestos_log(
Proveed_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Impuesto_Id,
GETDATE(),
'ins'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresImpuestosdel
GO

 CREATE TRIGGER comProveedoresImpuestosdel
ON comProveedoresImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO comProveedoresImpuestos_log(
Proveed_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Impuesto_Id,
GETDATE(),
'del'
FROM deleted where Proveed_Id=deleted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresImpuestosupd
GO

 CREATE TRIGGER comProveedoresImpuestosupd
ON comProveedoresImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProveedoresImpuestos_log(
Proveed_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Impuesto_Id,
GETDATE(),
'upd'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresRetencionins
GO

 CREATE TRIGGER comProveedoresRetencionins
ON comProveedoresRetencion
AFTER INSERT
AS
 BEGIN
INSERT INTO comProveedoresRetencion_log(
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
GETDATE(),
'ins'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresRetenciondel
GO

 CREATE TRIGGER comProveedoresRetenciondel
ON comProveedoresRetencion
AFTER DELETE
AS
 BEGIN
INSERT INTO comProveedoresRetencion_log(
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
GETDATE(),
'del'
FROM deleted where Proveed_Id=deleted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresRetencionupd
GO

 CREATE TRIGGER comProveedoresRetencionupd
ON comProveedoresRetencion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProveedoresRetencion_log(
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
FechaHasta,
GETDATE(),
'upd'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comProveedoresTipoPasivoins
GO

 CREATE TRIGGER comProveedoresTipoPasivoins
ON comProveedoresTipoPasivo
AFTER INSERT
AS
 BEGIN
INSERT INTO comProveedoresTipoPasivo_log(
TipoCtaProv,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoCtaProv,
Descripcion,
GETDATE(),
'ins'
FROM inserted where TipoCtaProv=inserted.TipoCtaProv)
 END
GO

 DROP TRIGGER comProveedoresTipoPasivodel
GO

 CREATE TRIGGER comProveedoresTipoPasivodel
ON comProveedoresTipoPasivo
AFTER DELETE
AS
 BEGIN
INSERT INTO comProveedoresTipoPasivo_log(
TipoCtaProv,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoCtaProv,
Descripcion,
GETDATE(),
'del'
FROM deleted where TipoCtaProv=deleted.TipoCtaProv)
 END
GO

 DROP TRIGGER comProveedoresTipoPasivoupd
GO

 CREATE TRIGGER comProveedoresTipoPasivoupd
ON comProveedoresTipoPasivo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProveedoresTipoPasivo_log(
TipoCtaProv,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoCtaProv,
Descripcion,
GETDATE(),
'upd'
FROM inserted where TipoCtaProv=inserted.TipoCtaProv)
 END
GO

 DROP TRIGGER comProvTiposins
GO

 CREATE TRIGGER comProvTiposins
ON comProvTipos
AFTER INSERT
AS
 BEGIN
INSERT INTO comProvTipos_log(
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comProvTipos=inserted.comProvTipos)
 END
GO

 DROP TRIGGER comProvTiposdel
GO

 CREATE TRIGGER comProvTiposdel
ON comProvTipos
AFTER DELETE
AS
 BEGIN
INSERT INTO comProvTipos_log(
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comProvTipos=deleted.comProvTipos)
 END
GO

 DROP TRIGGER comProvTiposupd
GO

 CREATE TRIGGER comProvTiposupd
ON comProvTipos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comProvTipos_log(
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comProvTipos,
ProvTipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comProvTipos=inserted.comProvTipos)
 END
GO

 DROP TRIGGER comRegionesins
GO

 CREATE TRIGGER comRegionesins
ON comRegiones
AFTER INSERT
AS
 BEGIN
INSERT INTO comRegiones_log(
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where comRegiones=inserted.comRegiones)
 END
GO

 DROP TRIGGER comRegionesdel
GO

 CREATE TRIGGER comRegionesdel
ON comRegiones
AFTER DELETE
AS
 BEGIN
INSERT INTO comRegiones_log(
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where comRegiones=deleted.comRegiones)
 END
GO

 DROP TRIGGER comRegionesupd
GO

 CREATE TRIGGER comRegionesupd
ON comRegiones
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRegiones_log(
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
comRegiones,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where comRegiones=inserted.comRegiones)
 END
GO

 DROP TRIGGER comRemiPendFactins
GO

 CREATE TRIGGER comRemiPendFactins
ON comRemiPendFact
AFTER INSERT
AS
 BEGIN
INSERT INTO comRemiPendFact_log(
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
GETDATE(),
'ins'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comRemiPendFactdel
GO

 CREATE TRIGGER comRemiPendFactdel
ON comRemiPendFact
AFTER DELETE
AS
 BEGIN
INSERT INTO comRemiPendFact_log(
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
GETDATE(),
'del'
FROM deleted where comMovProv=deleted.comMovProv)
 END
GO

 DROP TRIGGER comRemiPendFactupd
GO

 CREATE TRIGGER comRemiPendFactupd
ON comRemiPendFact
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRemiPendFact_log(
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
FechaModifLog,
TipoModificacion
)
(Select 
comMovProv,
RenglonCuerpo,
stkMoviCabe,
Renglon,
CantidadFacturado,
PrecioFacturado,
CantidadOriginalFact,
GETDATE(),
'upd'
FROM inserted where comMovProv=inserted.comMovProv)
 END
GO

 DROP TRIGGER comReqInternoins
GO

 CREATE TRIGGER comReqInternoins
ON comReqInterno
AFTER INSERT
AS
 BEGIN
INSERT INTO comReqInterno_log(
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comReqInternodel
GO

 CREATE TRIGGER comReqInternodel
ON comReqInterno
AFTER DELETE
AS
 BEGIN
INSERT INTO comReqInterno_log(
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comReqInternoupd
GO

 CREATE TRIGGER comReqInternoupd
ON comReqInterno
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comReqInterno_log(
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Fecha,
TipoPermi_Id,
Observaciones,
Proveed_Id,
EstadoRI_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRetProvins
GO

 CREATE TRIGGER comRetProvins
ON comRetProv
AFTER INSERT
AS
 BEGIN
INSERT INTO comRetProv_log(
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
GETDATE(),
'ins'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comRetProvdel
GO

 CREATE TRIGGER comRetProvdel
ON comRetProv
AFTER DELETE
AS
 BEGIN
INSERT INTO comRetProv_log(
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
GETDATE(),
'del'
FROM deleted where Proveed_Id=deleted.Proveed_Id)
 END
GO

 DROP TRIGGER comRetProvupd
GO

 CREATE TRIGGER comRetProvupd
ON comRetProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRetProv_log(
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Proveed_Id,
Cartera_Id,
Exencion,
Hasta,
GETDATE(),
'upd'
FROM inserted where Proveed_Id=inserted.Proveed_Id)
 END
GO

 DROP TRIGGER comRIArticuloins
GO

 CREATE TRIGGER comRIArticuloins
ON comRIArticulo
AFTER INSERT
AS
 BEGIN
INSERT INTO comRIArticulo_log(
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIArticulodel
GO

 CREATE TRIGGER comRIArticulodel
ON comRIArticulo
AFTER DELETE
AS
 BEGIN
INSERT INTO comRIArticulo_log(
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comRIArticuloupd
GO

 CREATE TRIGGER comRIArticuloupd
ON comRIArticulo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRIArticulo_log(
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
Producto_Id,
Factor,
CantidadOriginal,
PrecioOriginal,
Deposito_Id,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIAutorizandoins
GO

 CREATE TRIGGER comRIAutorizandoins
ON comRIAutorizando
AFTER INSERT
AS
 BEGIN
INSERT INTO comRIAutorizando_log(
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIAutorizandodel
GO

 CREATE TRIGGER comRIAutorizandodel
ON comRIAutorizando
AFTER DELETE
AS
 BEGIN
INSERT INTO comRIAutorizando_log(
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comRIAutorizandoupd
GO

 CREATE TRIGGER comRIAutorizandoupd
ON comRIAutorizando
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRIAutorizando_log(
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Secuencia,
NivelAuto_Id,
Usuario_Id,
Fecha,
TipoApro,
ResultadoFormula,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRICuerpoins
GO

 CREATE TRIGGER comRICuerpoins
ON comRICuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO comRICuerpo_log(
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRICuerpodel
GO

 CREATE TRIGGER comRICuerpodel
ON comRICuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO comRICuerpo_log(
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comRICuerpoupd
GO

 CREATE TRIGGER comRICuerpoupd
ON comRICuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRICuerpo_log(
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
FechaNecesidad,
Cantidad,
Precio,
CantidadRecibida,
Observaciones,
Pendiente,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Medida_Id,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIDesechadoins
GO

 CREATE TRIGGER comRIDesechadoins
ON comRIDesechado
AFTER INSERT
AS
 BEGIN
INSERT INTO comRIDesechado_log(
comReqInterno,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Usuario_Id,
Fecha,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIDesechadodel
GO

 CREATE TRIGGER comRIDesechadodel
ON comRIDesechado
AFTER DELETE
AS
 BEGIN
INSERT INTO comRIDesechado_log(
comReqInterno,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Usuario_Id,
Fecha,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comRIDesechadoupd
GO

 CREATE TRIGGER comRIDesechadoupd
ON comRIDesechado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRIDesechado_log(
comReqInterno,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Usuario_Id,
Fecha,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIEstadosins
GO

 CREATE TRIGGER comRIEstadosins
ON comRIEstados
AFTER INSERT
AS
 BEGIN
INSERT INTO comRIEstados_log(
EstadoRI_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
EstadoRI_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where EstadoRI_Id=inserted.EstadoRI_Id)
 END
GO

 DROP TRIGGER comRIEstadosdel
GO

 CREATE TRIGGER comRIEstadosdel
ON comRIEstados
AFTER DELETE
AS
 BEGIN
INSERT INTO comRIEstados_log(
EstadoRI_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
EstadoRI_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where EstadoRI_Id=deleted.EstadoRI_Id)
 END
GO

 DROP TRIGGER comRIEstadosupd
GO

 CREATE TRIGGER comRIEstadosupd
ON comRIEstados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRIEstados_log(
EstadoRI_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
EstadoRI_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where EstadoRI_Id=inserted.EstadoRI_Id)
 END
GO

 DROP TRIGGER comRIMemoins
GO

 CREATE TRIGGER comRIMemoins
ON comRIMemo
AFTER INSERT
AS
 BEGIN
INSERT INTO comRIMemo_log(
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
GETDATE(),
'ins'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRIMemodel
GO

 CREATE TRIGGER comRIMemodel
ON comRIMemo
AFTER DELETE
AS
 BEGIN
INSERT INTO comRIMemo_log(
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
GETDATE(),
'del'
FROM deleted where comReqInterno=deleted.comReqInterno)
 END
GO

 DROP TRIGGER comRIMemoupd
GO

 CREATE TRIGGER comRIMemoupd
ON comRIMemo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRIMemo_log(
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
FechaModifLog,
TipoModificacion
)
(Select 
comReqInterno,
Renglon_RI,
SubCategoria_Id,
Detalle,
GETDATE(),
'upd'
FROM inserted where comReqInterno=inserted.comReqInterno)
 END
GO

 DROP TRIGGER comRISegmentoins
GO

 CREATE TRIGGER comRISegmentoins
ON comRISegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO comRISegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
GETDATE(),
'ins'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER comRISegmentodel
GO

 CREATE TRIGGER comRISegmentodel
ON comRISegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO comRISegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
GETDATE(),
'del'
FROM deleted where Segmento_Id=deleted.Segmento_Id)
 END
GO

 DROP TRIGGER comRISegmentoupd
GO

 CREATE TRIGGER comRISegmentoupd
ON comRISegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comRISegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
comReqInterno,
GETDATE(),
'upd'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER comSolicitudesSatins
GO

 CREATE TRIGGER comSolicitudesSatins
ON comSolicitudesSat
AFTER INSERT
AS
 BEGIN
INSERT INTO comSolicitudesSat_log(
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comSolicitudesSatdel
GO

 CREATE TRIGGER comSolicitudesSatdel
ON comSolicitudesSat
AFTER DELETE
AS
 BEGIN
INSERT INTO comSolicitudesSat_log(
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER comSolicitudesSatupd
GO

 CREATE TRIGGER comSolicitudesSatupd
ON comSolicitudesSat
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comSolicitudesSat_log(
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaDesde,
FechaHasta,
Emitidos,
Descargados,
Fecha,
UltimaRespuestaSat,
SolicitudSat,
MetaDatos,
Usuario_Id,
Solicitud,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER comSubCategoriasins
GO

 CREATE TRIGGER comSubCategoriasins
ON comSubCategorias
AFTER INSERT
AS
 BEGIN
INSERT INTO comSubCategorias_log(
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where comSubCategorias=inserted.comSubCategorias)
 END
GO

 DROP TRIGGER comSubCategoriasdel
GO

 CREATE TRIGGER comSubCategoriasdel
ON comSubCategorias
AFTER DELETE
AS
 BEGIN
INSERT INTO comSubCategorias_log(
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where comSubCategorias=deleted.comSubCategorias)
 END
GO

 DROP TRIGGER comSubCategoriasupd
GO

 CREATE TRIGGER comSubCategoriasupd
ON comSubCategorias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comSubCategorias_log(
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comSubCategorias,
SubCategoria_Id,
Descripcion,
Categoria_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where comSubCategorias=inserted.comSubCategorias)
 END
GO

 DROP TRIGGER comTipoPermiins
GO

 CREATE TRIGGER comTipoPermiins
ON comTipoPermi
AFTER INSERT
AS
 BEGIN
INSERT INTO comTipoPermi_log(
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
GETDATE(),
'ins'
FROM inserted where comTipoPermi=inserted.comTipoPermi)
 END
GO

 DROP TRIGGER comTipoPermidel
GO

 CREATE TRIGGER comTipoPermidel
ON comTipoPermi
AFTER DELETE
AS
 BEGIN
INSERT INTO comTipoPermi_log(
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
GETDATE(),
'del'
FROM deleted where comTipoPermi=deleted.comTipoPermi)
 END
GO

 DROP TRIGGER comTipoPermiupd
GO

 CREATE TRIGGER comTipoPermiupd
ON comTipoPermi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comTipoPermi_log(
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermi,
TipoPermi_Id,
Empresa_Id,
Descripcion,
TipoCuerpo,
RequiereAutorizacion,
Importaciones,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
GETDATE(),
'upd'
FROM inserted where comTipoPermi=inserted.comTipoPermi)
 END
GO

 DROP TRIGGER comTipoPermiRIins
GO

 CREATE TRIGGER comTipoPermiRIins
ON comTipoPermiRI
AFTER INSERT
AS
 BEGIN
INSERT INTO comTipoPermiRI_log(
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
GETDATE(),
'ins'
FROM inserted where comTipoPermiRI=inserted.comTipoPermiRI)
 END
GO

 DROP TRIGGER comTipoPermiRIdel
GO

 CREATE TRIGGER comTipoPermiRIdel
ON comTipoPermiRI
AFTER DELETE
AS
 BEGIN
INSERT INTO comTipoPermiRI_log(
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
GETDATE(),
'del'
FROM deleted where comTipoPermiRI=deleted.comTipoPermiRI)
 END
GO

 DROP TRIGGER comTipoPermiRIupd
GO

 CREATE TRIGGER comTipoPermiRIupd
ON comTipoPermiRI
AFTER  UPDATE
AS
 BEGIN
INSERT INTO comTipoPermiRI_log(
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
FechaModifLog,
TipoModificacion
)
(Select 
comTipoPermiRI,
TipoPermiRI_Id,
Empresa_Id,
Descripcion,
EsquemaAuto_Id,
TipoCuerpo,
Reporte_Id,
TipoRI,
UsuarioAutorizado_Id,
Inactivo,
Posteado,
Usuario_Id,
GeneraOC,
GETDATE(),
'upd'
FROM inserted where comTipoPermiRI=inserted.comTipoPermiRI)
 END
GO

 DROP TRIGGER conAnexoGrupoTiposins
GO

 CREATE TRIGGER conAnexoGrupoTiposins
ON conAnexoGrupoTipos
AFTER INSERT
AS
 BEGIN
INSERT INTO conAnexoGrupoTipos_log(
GrupoAne_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Tipo_Id,
GETDATE(),
'ins'
FROM inserted where GrupoAne_Id=inserted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexoGrupoTiposdel
GO

 CREATE TRIGGER conAnexoGrupoTiposdel
ON conAnexoGrupoTipos
AFTER DELETE
AS
 BEGIN
INSERT INTO conAnexoGrupoTipos_log(
GrupoAne_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Tipo_Id,
GETDATE(),
'del'
FROM deleted where GrupoAne_Id=deleted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexoGrupoTiposupd
GO

 CREATE TRIGGER conAnexoGrupoTiposupd
ON conAnexoGrupoTipos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAnexoGrupoTipos_log(
GrupoAne_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Tipo_Id,
GETDATE(),
'upd'
FROM inserted where GrupoAne_Id=inserted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexosGruposins
GO

 CREATE TRIGGER conAnexosGruposins
ON conAnexosGrupos
AFTER INSERT
AS
 BEGIN
INSERT INTO conAnexosGrupos_log(
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
GETDATE(),
'ins'
FROM inserted where GrupoAne_Id=inserted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexosGruposdel
GO

 CREATE TRIGGER conAnexosGruposdel
ON conAnexosGrupos
AFTER DELETE
AS
 BEGIN
INSERT INTO conAnexosGrupos_log(
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
GETDATE(),
'del'
FROM deleted where GrupoAne_Id=deleted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexosGruposupd
GO

 CREATE TRIGGER conAnexosGruposupd
ON conAnexosGrupos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAnexosGrupos_log(
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description,
GETDATE(),
'upd'
FROM inserted where GrupoAne_Id=inserted.GrupoAne_Id)
 END
GO

 DROP TRIGGER conAnexosOrigenesins
GO

 CREATE TRIGGER conAnexosOrigenesins
ON conAnexosOrigenes
AFTER INSERT
AS
 BEGIN
INSERT INTO conAnexosOrigenes_log(
Origen,
Descripcion,
TipoRubro,
FechaModifLog,
TipoModificacion
)
(Select 
Origen,
Descripcion,
TipoRubro,
GETDATE(),
'ins'
FROM inserted where Origen=inserted.Origen)
 END
GO

 DROP TRIGGER conAnexosOrigenesdel
GO

 CREATE TRIGGER conAnexosOrigenesdel
ON conAnexosOrigenes
AFTER DELETE
AS
 BEGIN
INSERT INTO conAnexosOrigenes_log(
Origen,
Descripcion,
TipoRubro,
FechaModifLog,
TipoModificacion
)
(Select 
Origen,
Descripcion,
TipoRubro,
GETDATE(),
'del'
FROM deleted where Origen=deleted.Origen)
 END
GO

 DROP TRIGGER conAnexosOrigenesupd
GO

 CREATE TRIGGER conAnexosOrigenesupd
ON conAnexosOrigenes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAnexosOrigenes_log(
Origen,
Descripcion,
TipoRubro,
FechaModifLog,
TipoModificacion
)
(Select 
Origen,
Descripcion,
TipoRubro,
GETDATE(),
'upd'
FROM inserted where Origen=inserted.Origen)
 END
GO

 DROP TRIGGER conAsientosins
GO

 CREATE TRIGGER conAsientosins
ON conAsientos
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsientos_log(
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosdel
GO

 CREATE TRIGGER conAsientosdel
ON conAsientos
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsientos_log(
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosupd
GO

 CREATE TRIGGER conAsientosupd
ON conAsientos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsientos_log(
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Empresa_Id,
Fecha,
FechaRegistro,
Usuario_Id,
Moneda_Id,
Cambio,
CambioMonedaOriginal,
Formulario_Id,
Especial,
Sucursal,
Anulado,
Observaciones,
Posteado,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosAnulins
GO

 CREATE TRIGGER conAsientosAnulins
ON conAsientosAnul
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsientosAnul_log(
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosAnuldel
GO

 CREATE TRIGGER conAsientosAnuldel
ON conAsientosAnul
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsientosAnul_log(
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosAnulupd
GO

 CREATE TRIGGER conAsientosAnulupd
ON conAsientosAnul
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsientosAnul_log(
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
FechaAnulacion,
Usuario_Id,
TipoEnvio,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosConins
GO

 CREATE TRIGGER conAsientosConins
ON conAsientosCon
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsientosCon_log(
conAsientos,
LeyendaLibroDiario,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
LeyendaLibroDiario,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosCondel
GO

 CREATE TRIGGER conAsientosCondel
ON conAsientosCon
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsientosCon_log(
conAsientos,
LeyendaLibroDiario,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
LeyendaLibroDiario,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosConupd
GO

 CREATE TRIGGER conAsientosConupd
ON conAsientosCon
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsientosCon_log(
conAsientos,
LeyendaLibroDiario,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
LeyendaLibroDiario,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conAsientosInverins
GO

 CREATE TRIGGER conAsientosInverins
ON conAsientosInver
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsientosInver_log(
Asiento_Id,
Asiento_Id_Inver,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Id_Inver,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosInverdel
GO

 CREATE TRIGGER conAsientosInverdel
ON conAsientosInver
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsientosInver_log(
Asiento_Id,
Asiento_Id_Inver,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Id_Inver,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosInverupd
GO

 CREATE TRIGGER conAsientosInverupd
ON conAsientosInver
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsientosInver_log(
Asiento_Id,
Asiento_Id_Inver,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Id_Inver,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsientosTipoins
GO

 CREATE TRIGGER conAsientosTipoins
ON conAsientosTipo
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsientosTipo_log(
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where AsiTipo_Id=inserted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conAsientosTipodel
GO

 CREATE TRIGGER conAsientosTipodel
ON conAsientosTipo
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsientosTipo_log(
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where AsiTipo_Id=deleted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conAsientosTipoupd
GO

 CREATE TRIGGER conAsientosTipoupd
ON conAsientosTipo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsientosTipo_log(
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Empresa_Id,
LeyendaLibroDiario,
Reservada,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where AsiTipo_Id=inserted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conAsieReversionins
GO

 CREATE TRIGGER conAsieReversionins
ON conAsieReversion
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsieReversion_log(
Asiento_Id,
Asiento_Rever,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Rever,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsieReversiondel
GO

 CREATE TRIGGER conAsieReversiondel
ON conAsieReversion
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsieReversion_log(
Asiento_Id,
Asiento_Rever,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Rever,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsieReversionupd
GO

 CREATE TRIGGER conAsieReversionupd
ON conAsieReversion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsieReversion_log(
Asiento_Id,
Asiento_Rever,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Asiento_Rever,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER conAsieTipoCuerpoins
GO

 CREATE TRIGGER conAsieTipoCuerpoins
ON conAsieTipoCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO conAsieTipoCuerpo_log(
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
GETDATE(),
'ins'
FROM inserted where AsiTipo_Id=inserted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conAsieTipoCuerpodel
GO

 CREATE TRIGGER conAsieTipoCuerpodel
ON conAsieTipoCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO conAsieTipoCuerpo_log(
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
GETDATE(),
'del'
FROM deleted where AsiTipo_Id=deleted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conAsieTipoCuerpoupd
GO

 CREATE TRIGGER conAsieTipoCuerpoupd
ON conAsieTipoCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conAsieTipoCuerpo_log(
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
FechaModifLog,
TipoModificacion
)
(Select 
AsiTipo_Id,
Renglon,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
LeyendaLibroMayor,
Haber,
Debe,
GETDATE(),
'upd'
FROM inserted where AsiTipo_Id=inserted.AsiTipo_Id)
 END
GO

 DROP TRIGGER conBaseCentroins
GO

 CREATE TRIGGER conBaseCentroins
ON conBaseCentro
AFTER INSERT
AS
 BEGIN
INSERT INTO conBaseCentro_log(
Base_Id,
Centro1_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Base_Id,
Centro1_Id,
Valor,
GETDATE(),
'ins'
FROM inserted where Base_Id=inserted.Base_Id)
 END
GO

 DROP TRIGGER conBaseCentrodel
GO

 CREATE TRIGGER conBaseCentrodel
ON conBaseCentro
AFTER DELETE
AS
 BEGIN
INSERT INTO conBaseCentro_log(
Base_Id,
Centro1_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Base_Id,
Centro1_Id,
Valor,
GETDATE(),
'del'
FROM deleted where Base_Id=deleted.Base_Id)
 END
GO

 DROP TRIGGER conBaseCentroupd
GO

 CREATE TRIGGER conBaseCentroupd
ON conBaseCentro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conBaseCentro_log(
Base_Id,
Centro1_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Base_Id,
Centro1_Id,
Valor,
GETDATE(),
'upd'
FROM inserted where Base_Id=inserted.Base_Id)
 END
GO

 DROP TRIGGER conBaseDistriins
GO

 CREATE TRIGGER conBaseDistriins
ON conBaseDistri
AFTER INSERT
AS
 BEGIN
INSERT INTO conBaseDistri_log(
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where conBaseDistri=inserted.conBaseDistri)
 END
GO

 DROP TRIGGER conBaseDistridel
GO

 CREATE TRIGGER conBaseDistridel
ON conBaseDistri
AFTER DELETE
AS
 BEGIN
INSERT INTO conBaseDistri_log(
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where conBaseDistri=deleted.conBaseDistri)
 END
GO

 DROP TRIGGER conBaseDistriupd
GO

 CREATE TRIGGER conBaseDistriupd
ON conBaseDistri
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conBaseDistri_log(
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conBaseDistri,
Base_Id,
Empresa_Id,
Descripcion,
Medida_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where conBaseDistri=inserted.conBaseDistri)
 END
GO

 DROP TRIGGER conCentro1ins
GO

 CREATE TRIGGER conCentro1ins
ON conCentro1
AFTER INSERT
AS
 BEGIN
INSERT INTO conCentro1_log(
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where conCentro1=inserted.conCentro1)
 END
GO

 DROP TRIGGER conCentro1del
GO

 CREATE TRIGGER conCentro1del
ON conCentro1
AFTER DELETE
AS
 BEGIN
INSERT INTO conCentro1_log(
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where conCentro1=deleted.conCentro1)
 END
GO

 DROP TRIGGER conCentro1upd
GO

 CREATE TRIGGER conCentro1upd
ON conCentro1
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCentro1_log(
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro1,
Centro1_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where conCentro1=inserted.conCentro1)
 END
GO

 DROP TRIGGER conCentro2ins
GO

 CREATE TRIGGER conCentro2ins
ON conCentro2
AFTER INSERT
AS
 BEGIN
INSERT INTO conCentro2_log(
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where conCentro2=inserted.conCentro2)
 END
GO

 DROP TRIGGER conCentro2del
GO

 CREATE TRIGGER conCentro2del
ON conCentro2
AFTER DELETE
AS
 BEGIN
INSERT INTO conCentro2_log(
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where conCentro2=deleted.conCentro2)
 END
GO

 DROP TRIGGER conCentro2upd
GO

 CREATE TRIGGER conCentro2upd
ON conCentro2
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCentro2_log(
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCentro2,
Centro2_Id,
Empresa_Id,
Descripcion,
Nivel,
Imputable,
Notas,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where conCentro2=inserted.conCentro2)
 END
GO

 DROP TRIGGER conCgDatosECins
GO

 CREATE TRIGGER conCgDatosECins
ON conCgDatosEC
AFTER INSERT
AS
 BEGIN
INSERT INTO conCgDatosEC_log(
conCgDatosEC,
DatoEc_id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conCgDatosEC,
DatoEc_id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where conCgDatosEC=inserted.conCgDatosEC)
 END
GO

 DROP TRIGGER conCgDatosECdel
GO

 CREATE TRIGGER conCgDatosECdel
ON conCgDatosEC
AFTER DELETE
AS
 BEGIN
INSERT INTO conCgDatosEC_log(
conCgDatosEC,
DatoEc_id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conCgDatosEC,
DatoEc_id,
Descripcion,
GETDATE(),
'del'
FROM deleted where conCgDatosEC=deleted.conCgDatosEC)
 END
GO

 DROP TRIGGER conCgDatosECupd
GO

 CREATE TRIGGER conCgDatosECupd
ON conCgDatosEC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCgDatosEC_log(
conCgDatosEC,
DatoEc_id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conCgDatosEC,
DatoEc_id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where conCgDatosEC=inserted.conCgDatosEC)
 END
GO

 DROP TRIGGER conCgDatosValorins
GO

 CREATE TRIGGER conCgDatosValorins
ON conCgDatosValor
AFTER INSERT
AS
 BEGIN
INSERT INTO conCgDatosValor_log(
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where DatoEc_id=inserted.DatoEc_id)
 END
GO

 DROP TRIGGER conCgDatosValordel
GO

 CREATE TRIGGER conCgDatosValordel
ON conCgDatosValor
AFTER DELETE
AS
 BEGIN
INSERT INTO conCgDatosValor_log(
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where DatoEc_id=deleted.DatoEc_id)
 END
GO

 DROP TRIGGER conCgDatosValorupd
GO

 CREATE TRIGGER conCgDatosValorupd
ON conCgDatosValor
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCgDatosValor_log(
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
DatoEc_id,
Ejercicio,
Periodo,
Centro1_Id,
Centro2_Id,
Dato,
Usuario_Id,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where DatoEc_id=inserted.DatoEc_id)
 END
GO

 DROP TRIGGER conCuadro1Filasins
GO

 CREATE TRIGGER conCuadro1Filasins
ON conCuadro1Filas
AFTER INSERT
AS
 BEGIN
INSERT INTO conCuadro1Filas_log(
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where conCuadro1Filas=inserted.conCuadro1Filas)
 END
GO

 DROP TRIGGER conCuadro1Filasdel
GO

 CREATE TRIGGER conCuadro1Filasdel
ON conCuadro1Filas
AFTER DELETE
AS
 BEGIN
INSERT INTO conCuadro1Filas_log(
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where conCuadro1Filas=deleted.conCuadro1Filas)
 END
GO

 DROP TRIGGER conCuadro1Filasupd
GO

 CREATE TRIGGER conCuadro1Filasupd
ON conCuadro1Filas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCuadro1Filas_log(
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conCuadro1Filas,
Cuadro1Fila_Id,
Descripcion,
Empresa_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where conCuadro1Filas=inserted.conCuadro1Filas)
 END
GO

 DROP TRIGGER conCuentasins
GO

 CREATE TRIGGER conCuentasins
ON conCuentas
AFTER INSERT
AS
 BEGIN
INSERT INTO conCuentas_log(
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
GETDATE(),
'ins'
FROM inserted where conCuentas=inserted.conCuentas)
 END
GO

 DROP TRIGGER conCuentasdel
GO

 CREATE TRIGGER conCuentasdel
ON conCuentas
AFTER DELETE
AS
 BEGIN
INSERT INTO conCuentas_log(
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
GETDATE(),
'del'
FROM deleted where conCuentas=deleted.conCuentas)
 END
GO

 DROP TRIGGER conCuentasupd
GO

 CREATE TRIGGER conCuentasupd
ON conCuentas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCuentas_log(
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conCuentas,
Cuenta_Id,
Empresa_Id,
Tipo_Id,
Descripcion,
Rubro_Id,
Imputable,
Nivel,
Naturaleza,
Base_Id,
Grupo_Id,
Cuadro1Fila_Id,
ReservadaPor,
Fecha_Reserva,
SubCuenta_Id,
NoSeReserva,
Rubro_Balance,
Ajustable,
Notas,
Moneda_Id,
Indice_Id,
Metodo,
EliminaConsolida,
Inactivo,
TipoSAT_Id,
Usuario_Id,
Posteado,
RubroAxi_Id,
Description,
GETDATE(),
'upd'
FROM inserted where conCuentas=inserted.conCuentas)
 END
GO

 DROP TRIGGER conCuentasSinSCins
GO

 CREATE TRIGGER conCuentasSinSCins
ON conCuentasSinSC
AFTER INSERT
AS
 BEGIN
INSERT INTO conCuentasSinSC_log(
Cuenta_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cuenta_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Cuenta_Id=inserted.Cuenta_Id)
 END
GO

 DROP TRIGGER conCuentasSinSCdel
GO

 CREATE TRIGGER conCuentasSinSCdel
ON conCuentasSinSC
AFTER DELETE
AS
 BEGIN
INSERT INTO conCuentasSinSC_log(
Cuenta_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cuenta_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Cuenta_Id=deleted.Cuenta_Id)
 END
GO

 DROP TRIGGER conCuentasSinSCupd
GO

 CREATE TRIGGER conCuentasSinSCupd
ON conCuentasSinSC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conCuentasSinSC_log(
Cuenta_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cuenta_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Cuenta_Id=inserted.Cuenta_Id)
 END
GO

 DROP TRIGGER conEjercicioins
GO

 CREATE TRIGGER conEjercicioins
ON conEjercicio
AFTER INSERT
AS
 BEGIN
INSERT INTO conEjercicio_log(
Ejercicio,
Fecha,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Ejercicio,
Fecha,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Ejercicio=inserted.Ejercicio)
 END
GO

 DROP TRIGGER conEjerciciodel
GO

 CREATE TRIGGER conEjerciciodel
ON conEjercicio
AFTER DELETE
AS
 BEGIN
INSERT INTO conEjercicio_log(
Ejercicio,
Fecha,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Ejercicio,
Fecha,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Ejercicio=deleted.Ejercicio)
 END
GO

 DROP TRIGGER conEjercicioupd
GO

 CREATE TRIGGER conEjercicioupd
ON conEjercicio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conEjercicio_log(
Ejercicio,
Fecha,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Ejercicio,
Fecha,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Ejercicio=inserted.Ejercicio)
 END
GO

 DROP TRIGGER conGestionIndicesins
GO

 CREATE TRIGGER conGestionIndicesins
ON conGestionIndices
AFTER INSERT
AS
 BEGIN
INSERT INTO conGestionIndices_log(
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
GETDATE(),
'ins'
FROM inserted where conGestionIndices=inserted.conGestionIndices)
 END
GO

 DROP TRIGGER conGestionIndicesdel
GO

 CREATE TRIGGER conGestionIndicesdel
ON conGestionIndices
AFTER DELETE
AS
 BEGIN
INSERT INTO conGestionIndices_log(
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
GETDATE(),
'del'
FROM deleted where conGestionIndices=deleted.conGestionIndices)
 END
GO

 DROP TRIGGER conGestionIndicesupd
GO

 CREATE TRIGGER conGestionIndicesupd
ON conGestionIndices
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conGestionIndices_log(
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
conGestionIndices,
Indice_id,
TipoIndice_Id,
Formula,
IndiceDetalle,
Orden,
GETDATE(),
'upd'
FROM inserted where conGestionIndices=inserted.conGestionIndices)
 END
GO

 DROP TRIGGER conGrupoCentroins
GO

 CREATE TRIGGER conGrupoCentroins
ON conGrupoCentro
AFTER INSERT
AS
 BEGIN
INSERT INTO conGrupoCentro_log(
Grupo_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where Grupo_Id=inserted.Grupo_Id)
 END
GO

 DROP TRIGGER conGrupoCentrodel
GO

 CREATE TRIGGER conGrupoCentrodel
ON conGrupoCentro
AFTER DELETE
AS
 BEGIN
INSERT INTO conGrupoCentro_log(
Grupo_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where Grupo_Id=deleted.Grupo_Id)
 END
GO

 DROP TRIGGER conGrupoCentroupd
GO

 CREATE TRIGGER conGrupoCentroupd
ON conGrupoCentro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conGrupoCentro_log(
Grupo_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where Grupo_Id=inserted.Grupo_Id)
 END
GO

 DROP TRIGGER conGruposContins
GO

 CREATE TRIGGER conGruposContins
ON conGruposCont
AFTER INSERT
AS
 BEGIN
INSERT INTO conGruposCont_log(
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where conGruposCont=inserted.conGruposCont)
 END
GO

 DROP TRIGGER conGruposContdel
GO

 CREATE TRIGGER conGruposContdel
ON conGruposCont
AFTER DELETE
AS
 BEGIN
INSERT INTO conGruposCont_log(
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where conGruposCont=deleted.conGruposCont)
 END
GO

 DROP TRIGGER conGruposContupd
GO

 CREATE TRIGGER conGruposContupd
ON conGruposCont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conGruposCont_log(
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conGruposCont,
Grupo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where conGruposCont=inserted.conGruposCont)
 END
GO

 DROP TRIGGER conIndAjusCuerpoins
GO

 CREATE TRIGGER conIndAjusCuerpoins
ON conIndAjusCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO conIndAjusCuerpo_log(
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
FechaModifLog,
TipoModificacion
)
(Select 
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
GETDATE(),
'ins'
FROM inserted where Indice_Id=inserted.Indice_Id)
 END
GO

 DROP TRIGGER conIndAjusCuerpodel
GO

 CREATE TRIGGER conIndAjusCuerpodel
ON conIndAjusCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO conIndAjusCuerpo_log(
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
FechaModifLog,
TipoModificacion
)
(Select 
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
GETDATE(),
'del'
FROM deleted where Indice_Id=deleted.Indice_Id)
 END
GO

 DROP TRIGGER conIndAjusCuerpoupd
GO

 CREATE TRIGGER conIndAjusCuerpoupd
ON conIndAjusCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conIndAjusCuerpo_log(
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
FechaModifLog,
TipoModificacion
)
(Select 
Indice_Id,
Ejercicio,
Periodo,
Empresa_Id,
Indice,
GETDATE(),
'upd'
FROM inserted where Indice_Id=inserted.Indice_Id)
 END
GO

 DROP TRIGGER conIndicesAjustesins
GO

 CREATE TRIGGER conIndicesAjustesins
ON conIndicesAjustes
AFTER INSERT
AS
 BEGIN
INSERT INTO conIndicesAjustes_log(
conIndicesAjuste,
Indice_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conIndicesAjuste,
Indice_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where conIndicesAjuste=inserted.conIndicesAjuste)
 END
GO

 DROP TRIGGER conIndicesAjustesdel
GO

 CREATE TRIGGER conIndicesAjustesdel
ON conIndicesAjustes
AFTER DELETE
AS
 BEGIN
INSERT INTO conIndicesAjustes_log(
conIndicesAjuste,
Indice_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conIndicesAjuste,
Indice_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where conIndicesAjuste=deleted.conIndicesAjuste)
 END
GO

 DROP TRIGGER conIndicesAjustesupd
GO

 CREATE TRIGGER conIndicesAjustesupd
ON conIndicesAjustes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conIndicesAjustes_log(
conIndicesAjuste,
Indice_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
conIndicesAjuste,
Indice_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where conIndicesAjuste=inserted.conIndicesAjuste)
 END
GO

 DROP TRIGGER conInfDefCuentasins
GO

 CREATE TRIGGER conInfDefCuentasins
ON conInfDefCuentas
AFTER INSERT
AS
 BEGIN
INSERT INTO conInfDefCuentas_log(
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
GETDATE(),
'ins'
FROM inserted where Informe_Id=inserted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefCuentasdel
GO

 CREATE TRIGGER conInfDefCuentasdel
ON conInfDefCuentas
AFTER DELETE
AS
 BEGIN
INSERT INTO conInfDefCuentas_log(
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
GETDATE(),
'del'
FROM deleted where Informe_Id=deleted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefCuentasupd
GO

 CREATE TRIGGER conInfDefCuentasupd
ON conInfDefCuentas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conInfDefCuentas_log(
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
CuentaDesde,
CuentaHasta,
GETDATE(),
'upd'
FROM inserted where Informe_Id=inserted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefFilasins
GO

 CREATE TRIGGER conInfDefFilasins
ON conInfDefFilas
AFTER INSERT
AS
 BEGIN
INSERT INTO conInfDefFilas_log(
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
GETDATE(),
'ins'
FROM inserted where Informe_Id=inserted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefFilasdel
GO

 CREATE TRIGGER conInfDefFilasdel
ON conInfDefFilas
AFTER DELETE
AS
 BEGIN
INSERT INTO conInfDefFilas_log(
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
GETDATE(),
'del'
FROM deleted where Informe_Id=deleted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefFilasupd
GO

 CREATE TRIGGER conInfDefFilasupd
ON conInfDefFilas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conInfDefFilas_log(
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
FechaModifLog,
TipoModificacion
)
(Select 
Informe_Id,
Fila,
Nivel,
Titulo,
Tipo,
Fuente,
InvierteSigno,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
GETDATE(),
'upd'
FROM inserted where Informe_Id=inserted.Informe_Id)
 END
GO

 DROP TRIGGER conInfDefiniblesins
GO

 CREATE TRIGGER conInfDefiniblesins
ON conInfDefinibles
AFTER INSERT
AS
 BEGIN
INSERT INTO conInfDefinibles_log(
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'ins'
FROM inserted where conInfDefinibles=inserted.conInfDefinibles)
 END
GO

 DROP TRIGGER conInfDefiniblesdel
GO

 CREATE TRIGGER conInfDefiniblesdel
ON conInfDefinibles
AFTER DELETE
AS
 BEGIN
INSERT INTO conInfDefinibles_log(
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'del'
FROM deleted where conInfDefinibles=deleted.conInfDefinibles)
 END
GO

 DROP TRIGGER conInfDefiniblesupd
GO

 CREATE TRIGGER conInfDefiniblesupd
ON conInfDefinibles
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conInfDefinibles_log(
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
conInfDefinibles,
Informe_Id,
Descripcion,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'upd'
FROM inserted where conInfDefinibles=inserted.conInfDefinibles)
 END
GO

 DROP TRIGGER conMovContins
GO

 CREATE TRIGGER conMovContins
ON conMovCont
AFTER INSERT
AS
 BEGIN
INSERT INTO conMovCont_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conMovContdel
GO

 CREATE TRIGGER conMovContdel
ON conMovCont
AFTER DELETE
AS
 BEGIN
INSERT INTO conMovCont_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER conMovContupd
GO

 CREATE TRIGGER conMovContupd
ON conMovCont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conMovCont_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
ImporteMonedaOriginal,
TipoMov,
Centro1_Id,
Centro2_Id,
Clase,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conMovContConins
GO

 CREATE TRIGGER conMovContConins
ON conMovContCon
AFTER INSERT
AS
 BEGIN
INSERT INTO conMovContCon_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conMovContCondel
GO

 CREATE TRIGGER conMovContCondel
ON conMovContCon
AFTER DELETE
AS
 BEGIN
INSERT INTO conMovContCon_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER conMovContConupd
GO

 CREATE TRIGGER conMovContConupd
ON conMovContCon
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conMovContCon_log(
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
Cuenta_Id,
LeyendaLibroMayor,
Importe,
TipoMov,
Centro1_Id,
Centro2_Id,
ReferenciaT,
Referencia1,
Referencia2,
Referencia3,
Referencia4,
Referencia5,
Base_Id,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER conOrigAplicCtasins
GO

 CREATE TRIGGER conOrigAplicCtasins
ON conOrigAplicCtas
AFTER INSERT
AS
 BEGIN
INSERT INTO conOrigAplicCtas_log(
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
GETDATE(),
'ins'
FROM inserted where GrupoOAF_Id=inserted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conOrigAplicCtasdel
GO

 CREATE TRIGGER conOrigAplicCtasdel
ON conOrigAplicCtas
AFTER DELETE
AS
 BEGIN
INSERT INTO conOrigAplicCtas_log(
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
GETDATE(),
'del'
FROM deleted where GrupoOAF_Id=deleted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conOrigAplicCtasupd
GO

 CREATE TRIGGER conOrigAplicCtasupd
ON conOrigAplicCtas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conOrigAplicCtas_log(
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Cuenta_Id,
NetoDebeHaber,
GETDATE(),
'upd'
FROM inserted where GrupoOAF_Id=inserted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conOrigAplicRengins
GO

 CREATE TRIGGER conOrigAplicRengins
ON conOrigAplicReng
AFTER INSERT
AS
 BEGIN
INSERT INTO conOrigAplicReng_log(
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
GETDATE(),
'ins'
FROM inserted where GrupoOAF_Id=inserted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conOrigAplicRengdel
GO

 CREATE TRIGGER conOrigAplicRengdel
ON conOrigAplicReng
AFTER DELETE
AS
 BEGIN
INSERT INTO conOrigAplicReng_log(
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
GETDATE(),
'del'
FROM deleted where GrupoOAF_Id=deleted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conOrigAplicRengupd
GO

 CREATE TRIGGER conOrigAplicRengupd
ON conOrigAplicReng
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conOrigAplicReng_log(
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
GrupoOAF_Id,
Empresa_Id,
Destino,
Origen,
Descripcion,
GETDATE(),
'upd'
FROM inserted where GrupoOAF_Id=inserted.GrupoOAF_Id)
 END
GO

 DROP TRIGGER conPeriodosins
GO

 CREATE TRIGGER conPeriodosins
ON conPeriodos
AFTER INSERT
AS
 BEGIN
INSERT INTO conPeriodos_log(
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER conPeriodosdel
GO

 CREATE TRIGGER conPeriodosdel
ON conPeriodos
AFTER DELETE
AS
 BEGIN
INSERT INTO conPeriodos_log(
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER conPeriodosupd
GO

 CREATE TRIGGER conPeriodosupd
ON conPeriodos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conPeriodos_log(
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Fecha_Desde,
Fecha_Hasta,
Estado,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER conRubrosins
GO

 CREATE TRIGGER conRubrosins
ON conRubros
AFTER INSERT
AS
 BEGIN
INSERT INTO conRubros_log(
Rubro_Id,
Descripcion,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Id,
Descripcion,
Tipo,
GETDATE(),
'ins'
FROM inserted where Rubro_Id=inserted.Rubro_Id)
 END
GO

 DROP TRIGGER conRubrosdel
GO

 CREATE TRIGGER conRubrosdel
ON conRubros
AFTER DELETE
AS
 BEGIN
INSERT INTO conRubros_log(
Rubro_Id,
Descripcion,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Id,
Descripcion,
Tipo,
GETDATE(),
'del'
FROM deleted where Rubro_Id=deleted.Rubro_Id)
 END
GO

 DROP TRIGGER conRubrosupd
GO

 CREATE TRIGGER conRubrosupd
ON conRubros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conRubros_log(
Rubro_Id,
Descripcion,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Id,
Descripcion,
Tipo,
GETDATE(),
'upd'
FROM inserted where Rubro_Id=inserted.Rubro_Id)
 END
GO

 DROP TRIGGER conRubrosAxiins
GO

 CREATE TRIGGER conRubrosAxiins
ON conRubrosAxi
AFTER INSERT
AS
 BEGIN
INSERT INTO conRubrosAxi_log(
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
GETDATE(),
'ins'
FROM inserted where conRubrosAxi=inserted.conRubrosAxi)
 END
GO

 DROP TRIGGER conRubrosAxidel
GO

 CREATE TRIGGER conRubrosAxidel
ON conRubrosAxi
AFTER DELETE
AS
 BEGIN
INSERT INTO conRubrosAxi_log(
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
GETDATE(),
'del'
FROM deleted where conRubrosAxi=deleted.conRubrosAxi)
 END
GO

 DROP TRIGGER conRubrosAxiupd
GO

 CREATE TRIGGER conRubrosAxiupd
ON conRubrosAxi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conRubrosAxi_log(
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
conRubrosAxi,
RubroAxi_Id,
Descripcion,
Rubro_Id,
Empresa_Id,
Posteado,
Inactivo,
GETDATE(),
'upd'
FROM inserted where conRubrosAxi=inserted.conRubrosAxi)
 END
GO

 DROP TRIGGER conRubrosPreviins
GO

 CREATE TRIGGER conRubrosPreviins
ON conRubrosPrevi
AFTER INSERT
AS
 BEGIN
INSERT INTO conRubrosPrevi_log(
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
GETDATE(),
'ins'
FROM inserted where RubroPrevi_Id=inserted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conRubrosPrevidel
GO

 CREATE TRIGGER conRubrosPrevidel
ON conRubrosPrevi
AFTER DELETE
AS
 BEGIN
INSERT INTO conRubrosPrevi_log(
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
GETDATE(),
'del'
FROM deleted where RubroPrevi_Id=deleted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conRubrosPreviupd
GO

 CREATE TRIGGER conRubrosPreviupd
ON conRubrosPrevi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conRubrosPrevi_log(
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Empresa_Id,
Descripcion,
ActivoPasivo,
Corriente,
Orden,
GETDATE(),
'upd'
FROM inserted where RubroPrevi_Id=inserted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conRubrosPreviCtasins
GO

 CREATE TRIGGER conRubrosPreviCtasins
ON conRubrosPreviCtas
AFTER INSERT
AS
 BEGIN
INSERT INTO conRubrosPreviCtas_log(
RubroPrevi_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Cuenta_Id,
GETDATE(),
'ins'
FROM inserted where RubroPrevi_Id=inserted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conRubrosPreviCtasdel
GO

 CREATE TRIGGER conRubrosPreviCtasdel
ON conRubrosPreviCtas
AFTER DELETE
AS
 BEGIN
INSERT INTO conRubrosPreviCtas_log(
RubroPrevi_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Cuenta_Id,
GETDATE(),
'del'
FROM deleted where RubroPrevi_Id=deleted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conRubrosPreviCtasupd
GO

 CREATE TRIGGER conRubrosPreviCtasupd
ON conRubrosPreviCtas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conRubrosPreviCtas_log(
RubroPrevi_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
RubroPrevi_Id,
Cuenta_Id,
GETDATE(),
'upd'
FROM inserted where RubroPrevi_Id=inserted.RubroPrevi_Id)
 END
GO

 DROP TRIGGER conSituPatriins
GO

 CREATE TRIGGER conSituPatriins
ON conSituPatri
AFTER INSERT
AS
 BEGIN
INSERT INTO conSituPatri_log(
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
GETDATE(),
'ins'
FROM inserted where Rubro_Balance=inserted.Rubro_Balance)
 END
GO

 DROP TRIGGER conSituPatridel
GO

 CREATE TRIGGER conSituPatridel
ON conSituPatri
AFTER DELETE
AS
 BEGIN
INSERT INTO conSituPatri_log(
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
GETDATE(),
'del'
FROM deleted where Rubro_Balance=deleted.Rubro_Balance)
 END
GO

 DROP TRIGGER conSituPatriupd
GO

 CREATE TRIGGER conSituPatriupd
ON conSituPatri
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conSituPatri_log(
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Rubro_Balance,
Rubro_Id,
Descripcion,
Orden,
GETDATE(),
'upd'
FROM inserted where Rubro_Balance=inserted.Rubro_Balance)
 END
GO

 DROP TRIGGER conSubCuentasins
GO

 CREATE TRIGGER conSubCuentasins
ON conSubCuentas
AFTER INSERT
AS
 BEGIN
INSERT INTO conSubCuentas_log(
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
GETDATE(),
'ins'
FROM inserted where conSubCuentas=inserted.conSubCuentas)
 END
GO

 DROP TRIGGER conSubCuentasdel
GO

 CREATE TRIGGER conSubCuentasdel
ON conSubCuentas
AFTER DELETE
AS
 BEGIN
INSERT INTO conSubCuentas_log(
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
GETDATE(),
'del'
FROM deleted where conSubCuentas=deleted.conSubCuentas)
 END
GO

 DROP TRIGGER conSubCuentasupd
GO

 CREATE TRIGGER conSubCuentasupd
ON conSubCuentas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conSubCuentas_log(
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
FechaModifLog,
TipoModificacion
)
(Select 
conSubCuentas,
SubCuenta_Id,
Empresa_Id,
Descripcion,
Base_Id,
Cuadro1Fila_Id,
Ajustable,
Inactivo,
Usuario_Id,
Posteado,
Description,
GETDATE(),
'upd'
FROM inserted where conSubCuentas=inserted.conSubCuentas)
 END
GO

 DROP TRIGGER conTipoEspecialesins
GO

 CREATE TRIGGER conTipoEspecialesins
ON conTipoEspeciales
AFTER INSERT
AS
 BEGIN
INSERT INTO conTipoEspeciales_log(
TipoEspe_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where TipoEspe_Id=inserted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTipoEspecialesdel
GO

 CREATE TRIGGER conTipoEspecialesdel
ON conTipoEspeciales
AFTER DELETE
AS
 BEGIN
INSERT INTO conTipoEspeciales_log(
TipoEspe_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where TipoEspe_Id=deleted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTipoEspecialesupd
GO

 CREATE TRIGGER conTipoEspecialesupd
ON conTipoEspeciales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conTipoEspeciales_log(
TipoEspe_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where TipoEspe_Id=inserted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTipoEspecialesCuerpoins
GO

 CREATE TRIGGER conTipoEspecialesCuerpoins
ON conTipoEspecialesCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO conTipoEspecialesCuerpo_log(
TipoEspe_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Tipo_Id,
GETDATE(),
'ins'
FROM inserted where TipoEspe_Id=inserted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTipoEspecialesCuerpodel
GO

 CREATE TRIGGER conTipoEspecialesCuerpodel
ON conTipoEspecialesCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO conTipoEspecialesCuerpo_log(
TipoEspe_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Tipo_Id,
GETDATE(),
'del'
FROM deleted where TipoEspe_Id=deleted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTipoEspecialesCuerpoupd
GO

 CREATE TRIGGER conTipoEspecialesCuerpoupd
ON conTipoEspecialesCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conTipoEspecialesCuerpo_log(
TipoEspe_Id,
Tipo_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoEspe_Id,
Tipo_Id,
GETDATE(),
'upd'
FROM inserted where TipoEspe_Id=inserted.TipoEspe_Id)
 END
GO

 DROP TRIGGER conTiposContablesins
GO

 CREATE TRIGGER conTiposContablesins
ON conTiposContables
AFTER INSERT
AS
 BEGIN
INSERT INTO conTiposContables_log(
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
FechaModifLog,
TipoModificacion
)
(Select 
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
GETDATE(),
'ins'
FROM inserted where Tipo_Id=inserted.Tipo_Id)
 END
GO

 DROP TRIGGER conTiposContablesdel
GO

 CREATE TRIGGER conTiposContablesdel
ON conTiposContables
AFTER DELETE
AS
 BEGIN
INSERT INTO conTiposContables_log(
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
FechaModifLog,
TipoModificacion
)
(Select 
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
GETDATE(),
'del'
FROM deleted where Tipo_Id=deleted.Tipo_Id)
 END
GO

 DROP TRIGGER conTiposContablesupd
GO

 CREATE TRIGGER conTiposContablesupd
ON conTiposContables
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conTiposContables_log(
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
FechaModifLog,
TipoModificacion
)
(Select 
Tipo_Id,
Descripcion,
Rubro_Balance,
Destino,
Corriente,
Reservado,
Rubro_Id,
DescripcionUsu,
GETDATE(),
'upd'
FROM inserted where Tipo_Id=inserted.Tipo_Id)
 END
GO

 DROP TRIGGER conTiposSATins
GO

 CREATE TRIGGER conTiposSATins
ON conTiposSAT
AFTER INSERT
AS
 BEGIN
INSERT INTO conTiposSAT_log(
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
FechaModifLog,
TipoModificacion
)
(Select 
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
GETDATE(),
'ins'
FROM inserted where TipoSAT_Id=inserted.TipoSAT_Id)
 END
GO

 DROP TRIGGER conTiposSATdel
GO

 CREATE TRIGGER conTiposSATdel
ON conTiposSAT
AFTER DELETE
AS
 BEGIN
INSERT INTO conTiposSAT_log(
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
FechaModifLog,
TipoModificacion
)
(Select 
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
GETDATE(),
'del'
FROM deleted where TipoSAT_Id=deleted.TipoSAT_Id)
 END
GO

 DROP TRIGGER conTiposSATupd
GO

 CREATE TRIGGER conTiposSATupd
ON conTiposSAT
AFTER  UPDATE
AS
 BEGIN
INSERT INTO conTiposSAT_log(
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
FechaModifLog,
TipoModificacion
)
(Select 
TipoSAT_Id,
Descripcion,
Rubro,
Circulante,
Imputable,
GETDATE(),
'upd'
FROM inserted where TipoSAT_Id=inserted.TipoSAT_Id)
 END
GO

 DROP TRIGGER espAnexomovins
GO

 CREATE TRIGGER espAnexomovins
ON espAnexomov
AFTER INSERT
AS
 BEGIN
INSERT INTO espAnexomov_log(
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER espAnexomovdel
GO

 CREATE TRIGGER espAnexomovdel
ON espAnexomov
AFTER DELETE
AS
 BEGIN
INSERT INTO espAnexomov_log(
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER espAnexomovupd
GO

 CREATE TRIGGER espAnexomovupd
ON espAnexomov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espAnexomov_log(
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RemiOrigen,
DomicilioORIGEN,
RfcOrigen,
Destinatario,
DomicilioDestino,
RfcDestino,
CuotaPorTon,
ValorDeclarado,
Operador,
TractorNEco,
TractorPlacas,
Remolque1NEco,
Remolque1Placas,
Remolque2NEco,
Remolque2Placas,
Referencia,
ColoniaOrigen,
ColoniaDestino,
TipoUnidad,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER espBalanzains
GO

 CREATE TRIGGER espBalanzains
ON espBalanza
AFTER INSERT
AS
 BEGIN
INSERT INTO espBalanza_log(
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
GETDATE(),
'ins'
FROM inserted where Reporte_Id=inserted.Reporte_Id)
 END
GO

 DROP TRIGGER espBalanzadel
GO

 CREATE TRIGGER espBalanzadel
ON espBalanza
AFTER DELETE
AS
 BEGIN
INSERT INTO espBalanza_log(
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
GETDATE(),
'del'
FROM deleted where Reporte_Id=deleted.Reporte_Id)
 END
GO

 DROP TRIGGER espBalanzaupd
GO

 CREATE TRIGGER espBalanzaupd
ON espBalanza
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espBalanza_log(
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte_Id,
Orden,
Tipo,
Titulo,
Indice_Id,
DatoEc_id,
GETDATE(),
'upd'
FROM inserted where Reporte_Id=inserted.Reporte_Id)
 END
GO

 DROP TRIGGER espBalanzaCtasins
GO

 CREATE TRIGGER espBalanzaCtasins
ON espBalanzaCtas
AFTER INSERT
AS
 BEGIN
INSERT INTO espBalanzaCtas_log(
Reporte,
Orden,
CtaDesde,
CtaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte,
Orden,
CtaDesde,
CtaHasta,
GETDATE(),
'ins'
FROM inserted where Reporte=inserted.Reporte)
 END
GO

 DROP TRIGGER espBalanzaCtasdel
GO

 CREATE TRIGGER espBalanzaCtasdel
ON espBalanzaCtas
AFTER DELETE
AS
 BEGIN
INSERT INTO espBalanzaCtas_log(
Reporte,
Orden,
CtaDesde,
CtaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte,
Orden,
CtaDesde,
CtaHasta,
GETDATE(),
'del'
FROM deleted where Reporte=deleted.Reporte)
 END
GO

 DROP TRIGGER espBalanzaCtasupd
GO

 CREATE TRIGGER espBalanzaCtasupd
ON espBalanzaCtas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espBalanzaCtas_log(
Reporte,
Orden,
CtaDesde,
CtaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
Reporte,
Orden,
CtaDesde,
CtaHasta,
GETDATE(),
'upd'
FROM inserted where Reporte=inserted.Reporte)
 END
GO

 DROP TRIGGER espCierreApeTiendains
GO

 CREATE TRIGGER espCierreApeTiendains
ON espCierreApeTienda
AFTER INSERT
AS
 BEGIN
INSERT INTO espCierreApeTienda_log(
Sucursal,
Fecha,
TipoMovimiento,
UUID,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Fecha,
TipoMovimiento,
UUID,
GETDATE(),
'ins'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCierreApeTiendadel
GO

 CREATE TRIGGER espCierreApeTiendadel
ON espCierreApeTienda
AFTER DELETE
AS
 BEGIN
INSERT INTO espCierreApeTienda_log(
Sucursal,
Fecha,
TipoMovimiento,
UUID,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Fecha,
TipoMovimiento,
UUID,
GETDATE(),
'del'
FROM deleted where Sucursal=deleted.Sucursal)
 END
GO

 DROP TRIGGER espCierreApeTiendaupd
GO

 CREATE TRIGGER espCierreApeTiendaupd
ON espCierreApeTienda
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCierreApeTienda_log(
Sucursal,
Fecha,
TipoMovimiento,
UUID,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Fecha,
TipoMovimiento,
UUID,
GETDATE(),
'upd'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCuiAjustesins
GO

 CREATE TRIGGER espCuiAjustesins
ON espCuiAjustes
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiAjustes_log(
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiAjustesdel
GO

 CREATE TRIGGER espCuiAjustesdel
ON espCuiAjustes
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiAjustes_log(
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiAjustesupd
GO

 CREATE TRIGGER espCuiAjustesupd
ON espCuiAjustes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiAjustes_log(
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Tienda,
FechaDeNegocio,
Identificador,
Articulo,
Localidad,
Estado,
MotivoDelAjuste,
Cantidad,
Costounitario,
Empleado,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiApeCierreins
GO

 CREATE TRIGGER espCuiApeCierreins
ON espCuiApeCierre
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiApeCierre_log(
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'ins'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCuiApeCierredel
GO

 CREATE TRIGGER espCuiApeCierredel
ON espCuiApeCierre
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiApeCierre_log(
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'del'
FROM deleted where Sucursal=deleted.Sucursal)
 END
GO

 DROP TRIGGER espCuiApeCierreupd
GO

 CREATE TRIGGER espCuiApeCierreupd
ON espCuiApeCierre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiApeCierre_log(
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
TipoMov,
UUID,
Fechanegocio,
FechaCreacion,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'upd'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCuiCobranzains
GO

 CREATE TRIGGER espCuiCobranzains
ON espCuiCobranza
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiCobranza_log(
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiCobranzadel
GO

 CREATE TRIGGER espCuiCobranzadel
ON espCuiCobranza
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiCobranza_log(
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiCobranzaupd
GO

 CREATE TRIGGER espCuiCobranzaupd
ON espCuiCobranza
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiCobranza_log(
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
FechaNegocio,
UIDDComplemento,
Cuenta,
RFCCliente,
NoPago,
TipoPago,
Factura,
Monto,
Empleado,
FechaReplicacion,
SetReport,
Tesmovimientos,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiNCGlobalins
GO

 CREATE TRIGGER espCuiNCGlobalins
ON espCuiNCGlobal
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiNCGlobal_log(
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'ins'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCuiNCGlobaldel
GO

 CREATE TRIGGER espCuiNCGlobaldel
ON espCuiNCGlobal
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiNCGlobal_log(
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'del'
FROM deleted where Sucursal=deleted.Sucursal)
 END
GO

 DROP TRIGGER espCuiNCGlobalupd
GO

 CREATE TRIGGER espCuiNCGlobalupd
ON espCuiNCGlobal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiNCGlobal_log(
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
UUID,
Transaccion,
FechaNC,
FechaReplicacion,
SetReport,
venMovimientos,
GETDATE(),
'upd'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espCuiReceComprasins
GO

 CREATE TRIGGER espCuiReceComprasins
ON espCuiReceCompras
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiReceCompras_log(
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiReceComprasdel
GO

 CREATE TRIGGER espCuiReceComprasdel
ON espCuiReceCompras
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiReceCompras_log(
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiReceComprasupd
GO

 CREATE TRIGGER espCuiReceComprasupd
ON espCuiReceCompras
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiReceCompras_log(
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
Sucursal,
NoDocumento,
FechaFactura,
FechaRecepcion,
FechaActualizacion,
Estado,
Empleado,
NoFactura,
NoPedido,
RFCProveedor,
Articulo,
UnidadesEnviadas,
UnidadesRecibidas,
CostoUnitario,
CostoEnvio,
CostoPublicidad,
CostoSeguro,
UUID,
TotalSinIVA,
IVA,
TotalconIVA,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiTraspasosins
GO

 CREATE TRIGGER espCuiTraspasosins
ON espCuiTraspasos
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiTraspasos_log(
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'ins'
FROM inserted where TiendaTrans=inserted.TiendaTrans)
 END
GO

 DROP TRIGGER espCuiTraspasosdel
GO

 CREATE TRIGGER espCuiTraspasosdel
ON espCuiTraspasos
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiTraspasos_log(
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'del'
FROM deleted where TiendaTrans=deleted.TiendaTrans)
 END
GO

 DROP TRIGGER espCuiTraspasosupd
GO

 CREATE TRIGGER espCuiTraspasosupd
ON espCuiTraspasos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiTraspasos_log(
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
TiendaTrans,
Transaccion,
Linea,
PtoVenta,
TipoTraspaso,
LineaLocalidad,
FechaNegocio,
Articulo,
TiendaEnvia,
UsuarioEnvia,
CantidadEnviada,
LocalidadOrigen,
EstadoOrigen,
EstadoTraspaso,
TiendaDestino,
FechaDeRecepcion,
UsuarioRecibe,
UnidadesRecibidas,
LocalidadDestino,
EstadoDestino,
CostoUnitario,
FechaCreacion,
FechaReplicacion,
SetReport,
stkMoviCabe,
GETDATE(),
'upd'
FROM inserted where TiendaTrans=inserted.TiendaTrans)
 END
GO

 DROP TRIGGER espCuitzeoMailsins
GO

 CREATE TRIGGER espCuitzeoMailsins
ON espCuitzeoMails
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuitzeoMails_log(
Usuario_Id,
Correo,
Empresa,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Correo,
Empresa,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER espCuitzeoMailsdel
GO

 CREATE TRIGGER espCuitzeoMailsdel
ON espCuitzeoMails
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuitzeoMails_log(
Usuario_Id,
Correo,
Empresa,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Correo,
Empresa,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER espCuitzeoMailsupd
GO

 CREATE TRIGGER espCuitzeoMailsupd
ON espCuitzeoMails
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuitzeoMails_log(
Usuario_Id,
Correo,
Empresa,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Correo,
Empresa,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER espCuiVentasCuerpoins
GO

 CREATE TRIGGER espCuiVentasCuerpoins
ON espCuiVentasCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiVentasCuerpo_log(
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasCuerpodel
GO

 CREATE TRIGGER espCuiVentasCuerpodel
ON espCuiVentasCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiVentasCuerpo_log(
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasCuerpoupd
GO

 CREATE TRIGGER espCuiVentasCuerpoupd
ON espCuiVentasCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiVentasCuerpo_log(
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
LineaProducto,
Articulo,
Cantidad,
LocModSeq,
Localidad,
Estado,
CostoUnitario,
PrecioUnitarioSinIVA,
PrecioUnitarioConIVA,
SubtotalSinIVA,
SubtotalConIVA,
DescuentoPorLinea,
FechaReplicacion,
FechaSumma,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasDevoFormaPins
GO

 CREATE TRIGGER espCuiVentasDevoFormaPins
ON espCuiVentasDevoFormaP
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiVentasDevoFormaP_log(
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasDevoFormaPdel
GO

 CREATE TRIGGER espCuiVentasDevoFormaPdel
ON espCuiVentasDevoFormaP
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiVentasDevoFormaP_log(
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasDevoFormaPupd
GO

 CREATE TRIGGER espCuiVentasDevoFormaPupd
ON espCuiVentasDevoFormaP
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiVentasDevoFormaP_log(
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Linea,
TipoDemovimiento,
Fecha,
FormaDePago,
Cantidad,
Empleado,
FechaReplicacion,
FechaSumma,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasEncabezadoins
GO

 CREATE TRIGGER espCuiVentasEncabezadoins
ON espCuiVentasEncabezado
AFTER INSERT
AS
 BEGIN
INSERT INTO espCuiVentasEncabezado_log(
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
GETDATE(),
'ins'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasEncabezadodel
GO

 CREATE TRIGGER espCuiVentasEncabezadodel
ON espCuiVentasEncabezado
AFTER DELETE
AS
 BEGIN
INSERT INTO espCuiVentasEncabezado_log(
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
GETDATE(),
'del'
FROM deleted where Transaccion=deleted.Transaccion)
 END
GO

 DROP TRIGGER espCuiVentasEncabezadoupd
GO

 CREATE TRIGGER espCuiVentasEncabezadoupd
ON espCuiVentasEncabezado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espCuiVentasEncabezado_log(
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
FechaModifLog,
TipoModificacion
)
(Select 
Transaccion,
Tienda,
NombreDeLaTienda,
Registradora,
FechaDeNegocio,
RFC,
Cuenta,
RazonSocial,
FolioSAT,
RFCFacturado,
CuentaFacturado,
NombreClienteFacturado,
VentaACredito,
PuntosAcumulados,
RedimioPuntos,
Empleado,
Subtotal,
DescuentoGlobal,
TrasladoIVA,
IVARetenido,
MontoIVARetenido,
Total,
FechaCreacion,
FechaReplicacion,
Segmento,
Genero,
Edad,
FechaSumma,
venMovimientos,
SetReport,
TipoMov,
GETDATE(),
'upd'
FROM inserted where Transaccion=inserted.Transaccion)
 END
GO

 DROP TRIGGER espFechasMigins
GO

 CREATE TRIGGER espFechasMigins
ON espFechasMig
AFTER INSERT
AS
 BEGIN
INSERT INTO espFechasMig_log(
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espFechasMigdel
GO

 CREATE TRIGGER espFechasMigdel
ON espFechasMig
AFTER DELETE
AS
 BEGIN
INSERT INTO espFechasMig_log(
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER espFechasMigupd
GO

 CREATE TRIGGER espFechasMigupd
ON espFechasMig
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espFechasMig_log(
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
FechaClientes,
FechaProductos,
FechaVentas,
FechaDevoluciones,
FechaProveedores,
FechaUsuarios,
FechaAjusteInv,
FechaCompras,
FechaTraspasos,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espFormasPagoins
GO

 CREATE TRIGGER espFormasPagoins
ON espFormasPago
AFTER INSERT
AS
 BEGIN
INSERT INTO espFormasPago_log(
FormaPago,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
FormaPago,
Cartera_Id,
GETDATE(),
'ins'
FROM inserted where FormaPago=inserted.FormaPago)
 END
GO

 DROP TRIGGER espFormasPagodel
GO

 CREATE TRIGGER espFormasPagodel
ON espFormasPago
AFTER DELETE
AS
 BEGIN
INSERT INTO espFormasPago_log(
FormaPago,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
FormaPago,
Cartera_Id,
GETDATE(),
'del'
FROM deleted where FormaPago=deleted.FormaPago)
 END
GO

 DROP TRIGGER espFormasPagoupd
GO

 CREATE TRIGGER espFormasPagoupd
ON espFormasPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espFormasPago_log(
FormaPago,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
FormaPago,
Cartera_Id,
GETDATE(),
'upd'
FROM inserted where FormaPago=inserted.FormaPago)
 END
GO

 DROP TRIGGER espPresupuestoins
GO

 CREATE TRIGGER espPresupuestoins
ON espPresupuesto
AFTER INSERT
AS
 BEGIN
INSERT INTO espPresupuesto_log(
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espPresupuestodel
GO

 CREATE TRIGGER espPresupuestodel
ON espPresupuesto
AFTER DELETE
AS
 BEGIN
INSERT INTO espPresupuesto_log(
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER espPresupuestoupd
GO

 CREATE TRIGGER espPresupuestoupd
ON espPresupuesto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espPresupuesto_log(
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Ejercicio,
Periodo,
Cuenta_Id,
Centro1_Id,
Centro2_id,
Importe,
Usuario_Id,
FechaCarga,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espReporteins
GO

 CREATE TRIGGER espReporteins
ON espReporte
AFTER INSERT
AS
 BEGIN
INSERT INTO espReporte_log(
espReporte,
Reporte_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
espReporte,
Reporte_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where espReporte=inserted.espReporte)
 END
GO

 DROP TRIGGER espReportedel
GO

 CREATE TRIGGER espReportedel
ON espReporte
AFTER DELETE
AS
 BEGIN
INSERT INTO espReporte_log(
espReporte,
Reporte_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
espReporte,
Reporte_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where espReporte=deleted.espReporte)
 END
GO

 DROP TRIGGER espReporteupd
GO

 CREATE TRIGGER espReporteupd
ON espReporte
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espReporte_log(
espReporte,
Reporte_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
espReporte,
Reporte_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where espReporte=inserted.espReporte)
 END
GO

 DROP TRIGGER espSaldosDepoins
GO

 CREATE TRIGGER espSaldosDepoins
ON espSaldosDepo
AFTER INSERT
AS
 BEGIN
INSERT INTO espSaldosDepo_log(
Sucursal,
Saldos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Saldos,
GETDATE(),
'ins'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espSaldosDepodel
GO

 CREATE TRIGGER espSaldosDepodel
ON espSaldosDepo
AFTER DELETE
AS
 BEGIN
INSERT INTO espSaldosDepo_log(
Sucursal,
Saldos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Saldos,
GETDATE(),
'del'
FROM deleted where Sucursal=deleted.Sucursal)
 END
GO

 DROP TRIGGER espSaldosDepoupd
GO

 CREATE TRIGGER espSaldosDepoupd
ON espSaldosDepo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSaldosDepo_log(
Sucursal,
Saldos,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Saldos,
GETDATE(),
'upd'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER espSolicitantesins
GO

 CREATE TRIGGER espSolicitantesins
ON espSolicitantes
AFTER INSERT
AS
 BEGIN
INSERT INTO espSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER espSolicitantesdel
GO

 CREATE TRIGGER espSolicitantesdel
ON espSolicitantes
AFTER DELETE
AS
 BEGIN
INSERT INTO espSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER espSolicitantesupd
GO

 CREATE TRIGGER espSolicitantesupd
ON espSolicitantes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER espSolicitudins
GO

 CREATE TRIGGER espSolicitudins
ON espSolicitud
AFTER INSERT
AS
 BEGIN
INSERT INTO espSolicitud_log(
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'ins'
FROM inserted where espSolicitud=inserted.espSolicitud)
 END
GO

 DROP TRIGGER espSolicituddel
GO

 CREATE TRIGGER espSolicituddel
ON espSolicitud
AFTER DELETE
AS
 BEGIN
INSERT INTO espSolicitud_log(
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'del'
FROM deleted where espSolicitud=deleted.espSolicitud)
 END
GO

 DROP TRIGGER espSolicitudupd
GO

 CREATE TRIGGER espSolicitudupd
ON espSolicitud
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSolicitud_log(
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'upd'
FROM inserted where espSolicitud=inserted.espSolicitud)
 END
GO

 DROP TRIGGER espSolPagoins
GO

 CREATE TRIGGER espSolPagoins
ON espSolPago
AFTER INSERT
AS
 BEGIN
INSERT INTO espSolPago_log(
espSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
tesMovimientos,
GETDATE(),
'ins'
FROM inserted where espSolicitud=inserted.espSolicitud)
 END
GO

 DROP TRIGGER espSolPagodel
GO

 CREATE TRIGGER espSolPagodel
ON espSolPago
AFTER DELETE
AS
 BEGIN
INSERT INTO espSolPago_log(
espSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
tesMovimientos,
GETDATE(),
'del'
FROM deleted where espSolicitud=deleted.espSolicitud)
 END
GO

 DROP TRIGGER espSolPagoupd
GO

 CREATE TRIGGER espSolPagoupd
ON espSolPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSolPago_log(
espSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
espSolicitud,
tesMovimientos,
GETDATE(),
'upd'
FROM inserted where espSolicitud=inserted.espSolicitud)
 END
GO

 DROP TRIGGER espSolRendicionins
GO

 CREATE TRIGGER espSolRendicionins
ON espSolRendicion
AFTER INSERT
AS
 BEGIN
INSERT INTO espSolRendicion_log(
tesMovimientos,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
espSolicitud,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER espSolRendiciondel
GO

 CREATE TRIGGER espSolRendiciondel
ON espSolRendicion
AFTER DELETE
AS
 BEGIN
INSERT INTO espSolRendicion_log(
tesMovimientos,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
espSolicitud,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER espSolRendicionupd
GO

 CREATE TRIGGER espSolRendicionupd
ON espSolRendicion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSolRendicion_log(
tesMovimientos,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
espSolicitud,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER espSolSegmentosins
GO

 CREATE TRIGGER espSolSegmentosins
ON espSolSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO espSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espSolSegmentosdel
GO

 CREATE TRIGGER espSolSegmentosdel
ON espSolSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO espSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER espSolSegmentosupd
GO

 CREATE TRIGGER espSolSegmentosupd
ON espSolSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
espSolicitud,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER espUsuarioSurusalins
GO

 CREATE TRIGGER espUsuarioSurusalins
ON espUsuarioSurusal
AFTER INSERT
AS
 BEGIN
INSERT INTO espUsuarioSurusal_log(
Usuario_Id,
Sucursal,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Sucursal,
Empresa_id,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER espUsuarioSurusaldel
GO

 CREATE TRIGGER espUsuarioSurusaldel
ON espUsuarioSurusal
AFTER DELETE
AS
 BEGIN
INSERT INTO espUsuarioSurusal_log(
Usuario_Id,
Sucursal,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Sucursal,
Empresa_id,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER espUsuarioSurusalupd
GO

 CREATE TRIGGER espUsuarioSurusalupd
ON espUsuarioSurusal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espUsuarioSurusal_log(
Usuario_Id,
Sucursal,
Empresa_id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Sucursal,
Empresa_id,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER espUsuariosVendedoresins
GO

 CREATE TRIGGER espUsuariosVendedoresins
ON espUsuariosVendedores
AFTER INSERT
AS
 BEGIN
INSERT INTO espUsuariosVendedores_log(
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
FechaModifLog,
TipoModificacion
)
(Select 
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
GETDATE(),
'ins'
FROM inserted where UsuarioCuitzeo=inserted.UsuarioCuitzeo)
 END
GO

 DROP TRIGGER espUsuariosVendedoresdel
GO

 CREATE TRIGGER espUsuariosVendedoresdel
ON espUsuariosVendedores
AFTER DELETE
AS
 BEGIN
INSERT INTO espUsuariosVendedores_log(
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
FechaModifLog,
TipoModificacion
)
(Select 
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
GETDATE(),
'del'
FROM deleted where UsuarioCuitzeo=deleted.UsuarioCuitzeo)
 END
GO

 DROP TRIGGER espUsuariosVendedoresupd
GO

 CREATE TRIGGER espUsuariosVendedoresupd
ON espUsuariosVendedores
AFTER  UPDATE
AS
 BEGIN
INSERT INTO espUsuariosVendedores_log(
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
FechaModifLog,
TipoModificacion
)
(Select 
UsuarioCuitzeo,
Nombre,
Vendedor_Id,
Centro1_Id,
GETDATE(),
'upd'
FROM inserted where UsuarioCuitzeo=inserted.UsuarioCuitzeo)
 END
GO

 DROP TRIGGER genAdjuntosins
GO

 CREATE TRIGGER genAdjuntosins
ON genAdjuntos
AFTER INSERT
AS
 BEGIN
INSERT INTO genAdjuntos_log(
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
GETDATE(),
'ins'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER genAdjuntosdel
GO

 CREATE TRIGGER genAdjuntosdel
ON genAdjuntos
AFTER DELETE
AS
 BEGIN
INSERT INTO genAdjuntos_log(
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
GETDATE(),
'del'
FROM deleted where Tabla_Id=deleted.Tabla_Id)
 END
GO

 DROP TRIGGER genAdjuntosupd
GO

 CREATE TRIGGER genAdjuntosupd
ON genAdjuntos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genAdjuntos_log(
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Identity_Id,
Renglon,
Guid,
NombreArchivo,
Extension,
GETDATE(),
'upd'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER genAlertasins
GO

 CREATE TRIGGER genAlertasins
ON genAlertas
AFTER INSERT
AS
 BEGIN
INSERT INTO genAlertas_log(
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
FechaModifLog,
TipoModificacion
)
(Select 
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
GETDATE(),
'ins'
FROM inserted where AlertaId=inserted.AlertaId)
 END
GO

 DROP TRIGGER genAlertasdel
GO

 CREATE TRIGGER genAlertasdel
ON genAlertas
AFTER DELETE
AS
 BEGIN
INSERT INTO genAlertas_log(
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
FechaModifLog,
TipoModificacion
)
(Select 
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
GETDATE(),
'del'
FROM deleted where AlertaId=deleted.AlertaId)
 END
GO

 DROP TRIGGER genAlertasupd
GO

 CREATE TRIGGER genAlertasupd
ON genAlertas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genAlertas_log(
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
FechaModifLog,
TipoModificacion
)
(Select 
AlertaId,
Usuario_Id,
FechaEmision,
FechaLeido,
Mensaje,
Liga,
GETDATE(),
'upd'
FROM inserted where AlertaId=inserted.AlertaId)
 END
GO

 DROP TRIGGER genAsiSegmentosins
GO

 CREATE TRIGGER genAsiSegmentosins
ON genAsiSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO genAsiSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genAsiSegmentosdel
GO

 CREATE TRIGGER genAsiSegmentosdel
ON genAsiSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO genAsiSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER genAsiSegmentosupd
GO

 CREATE TRIGGER genAsiSegmentosupd
ON genAsiSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genAsiSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Asiento_Id,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genAtributosGeneralesins
GO

 CREATE TRIGGER genAtributosGeneralesins
ON genAtributosGenerales
AFTER INSERT
AS
 BEGIN
INSERT INTO genAtributosGenerales_log(
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
FechaModifLog,
TipoModificacion
)
(Select 
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
GETDATE(),
'ins'
FROM inserted where AtributoNro=inserted.AtributoNro)
 END
GO

 DROP TRIGGER genAtributosGeneralesdel
GO

 CREATE TRIGGER genAtributosGeneralesdel
ON genAtributosGenerales
AFTER DELETE
AS
 BEGIN
INSERT INTO genAtributosGenerales_log(
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
FechaModifLog,
TipoModificacion
)
(Select 
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
GETDATE(),
'del'
FROM deleted where AtributoNro=deleted.AtributoNro)
 END
GO

 DROP TRIGGER genAtributosGeneralesupd
GO

 CREATE TRIGGER genAtributosGeneralesupd
ON genAtributosGenerales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genAtributosGenerales_log(
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
FechaModifLog,
TipoModificacion
)
(Select 
AtributoNro,
Tabla_Id,
Descripcion,
Tipo,
EnGrilla,
GETDATE(),
'upd'
FROM inserted where AtributoNro=inserted.AtributoNro)
 END
GO

 DROP TRIGGER genAtributosValoresins
GO

 CREATE TRIGGER genAtributosValoresins
ON genAtributosValores
AFTER INSERT
AS
 BEGIN
INSERT INTO genAtributosValores_log(
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
FechaModifLog,
TipoModificacion
)
(Select 
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
GETDATE(),
'ins'
FROM inserted where Identity_Id=inserted.Identity_Id)
 END
GO

 DROP TRIGGER genAtributosValoresdel
GO

 CREATE TRIGGER genAtributosValoresdel
ON genAtributosValores
AFTER DELETE
AS
 BEGIN
INSERT INTO genAtributosValores_log(
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
FechaModifLog,
TipoModificacion
)
(Select 
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
GETDATE(),
'del'
FROM deleted where Identity_Id=deleted.Identity_Id)
 END
GO

 DROP TRIGGER genAtributosValoresupd
GO

 CREATE TRIGGER genAtributosValoresupd
ON genAtributosValores
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genAtributosValores_log(
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
FechaModifLog,
TipoModificacion
)
(Select 
Identity_Id,
AtributoNro,
Tabla_Id,
ValorN,
ValorC,
ValorF,
GETDATE(),
'upd'
FROM inserted where Identity_Id=inserted.Identity_Id)
 END
GO

 DROP TRIGGER genCancMovins
GO

 CREATE TRIGGER genCancMovins
ON genCancMov
AFTER INSERT
AS
 BEGIN
INSERT INTO genCancMov_log(
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genCancMovdel
GO

 CREATE TRIGGER genCancMovdel
ON genCancMov
AFTER DELETE
AS
 BEGIN
INSERT INTO genCancMov_log(
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER genCancMovupd
GO

 CREATE TRIGGER genCancMovupd
ON genCancMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genCancMov_log(
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
Asiento_Id_Ap,
CuotaNro_Ap,
NroAplicacion,
Usuario_Id,
FechaAplicacion,
Importe,
Importe_Ap,
AsientoApli_Id,
Importacion,
AsieDifCambio_Id,
EsVentaContado,
EsAplicOriginal,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genCancMovApliImporins
GO

 CREATE TRIGGER genCancMovApliImporins
ON genCancMovApliImpor
AFTER INSERT
AS
 BEGIN
INSERT INTO genCancMovApliImpor_log(
conAsientos,
Renglon,
EsDelAp,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
EsDelAp,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER genCancMovApliImpordel
GO

 CREATE TRIGGER genCancMovApliImpordel
ON genCancMovApliImpor
AFTER DELETE
AS
 BEGIN
INSERT INTO genCancMovApliImpor_log(
conAsientos,
Renglon,
EsDelAp,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
EsDelAp,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER genCancMovApliImporupd
GO

 CREATE TRIGGER genCancMovApliImporupd
ON genCancMovApliImpor
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genCancMovApliImpor_log(
conAsientos,
Renglon,
EsDelAp,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Renglon,
EsDelAp,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER genClaveComunesins
GO

 CREATE TRIGGER genClaveComunesins
ON genClaveComunes
AFTER INSERT
AS
 BEGIN
INSERT INTO genClaveComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'ins'
FROM inserted where Clave=inserted.Clave)
 END
GO

 DROP TRIGGER genClaveComunesdel
GO

 CREATE TRIGGER genClaveComunesdel
ON genClaveComunes
AFTER DELETE
AS
 BEGIN
INSERT INTO genClaveComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'del'
FROM deleted where Clave=deleted.Clave)
 END
GO

 DROP TRIGGER genClaveComunesupd
GO

 CREATE TRIGGER genClaveComunesupd
ON genClaveComunes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genClaveComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'upd'
FROM inserted where Clave=inserted.Clave)
 END
GO

 DROP TRIGGER genClavesComunesins
GO

 CREATE TRIGGER genClavesComunesins
ON genClavesComunes
AFTER INSERT
AS
 BEGIN
INSERT INTO genClavesComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'ins'
FROM inserted where Clave=inserted.Clave)
 END
GO

 DROP TRIGGER genClavesComunesdel
GO

 CREATE TRIGGER genClavesComunesdel
ON genClavesComunes
AFTER DELETE
AS
 BEGIN
INSERT INTO genClavesComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'del'
FROM deleted where Clave=deleted.Clave)
 END
GO

 DROP TRIGGER genClavesComunesupd
GO

 CREATE TRIGGER genClavesComunesupd
ON genClavesComunes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genClavesComunes_log(
Clave,
FechaModifLog,
TipoModificacion
)
(Select 
Clave,
GETDATE(),
'upd'
FROM inserted where Clave=inserted.Clave)
 END
GO

 DROP TRIGGER genContadorSegmentoins
GO

 CREATE TRIGGER genContadorSegmentoins
ON genContadorSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO genContadorSegmento_log(
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genContadorSegmentodel
GO

 CREATE TRIGGER genContadorSegmentodel
ON genContadorSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO genContadorSegmento_log(
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER genContadorSegmentoupd
GO

 CREATE TRIGGER genContadorSegmentoupd
ON genContadorSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genContadorSegmento_log(
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Segmento_Id,
PrimerNumero,
Cai,
FechaCai,
NumeroDesde,
NumeroHasta,
FechaAutoSRI,
FechaDesde,
Usuario_Id,
TieneColumnaAutomatica,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genCulturasins
GO

 CREATE TRIGGER genCulturasins
ON genCulturas
AFTER INSERT
AS
 BEGIN
INSERT INTO genCulturas_log(
Cultura,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cultura,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Cultura=inserted.Cultura)
 END
GO

 DROP TRIGGER genCulturasdel
GO

 CREATE TRIGGER genCulturasdel
ON genCulturas
AFTER DELETE
AS
 BEGIN
INSERT INTO genCulturas_log(
Cultura,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cultura,
Descripcion,
GETDATE(),
'del'
FROM deleted where Cultura=deleted.Cultura)
 END
GO

 DROP TRIGGER genCulturasupd
GO

 CREATE TRIGGER genCulturasupd
ON genCulturas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genCulturas_log(
Cultura,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Cultura,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Cultura=inserted.Cultura)
 END
GO

 DROP TRIGGER genDiasFestivosins
GO

 CREATE TRIGGER genDiasFestivosins
ON genDiasFestivos
AFTER INSERT
AS
 BEGIN
INSERT INTO genDiasFestivos_log(
Fecha,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Fecha,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Fecha=inserted.Fecha)
 END
GO

 DROP TRIGGER genDiasFestivosdel
GO

 CREATE TRIGGER genDiasFestivosdel
ON genDiasFestivos
AFTER DELETE
AS
 BEGIN
INSERT INTO genDiasFestivos_log(
Fecha,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Fecha,
Descripcion,
GETDATE(),
'del'
FROM deleted where Fecha=deleted.Fecha)
 END
GO

 DROP TRIGGER genDiasFestivosupd
GO

 CREATE TRIGGER genDiasFestivosupd
ON genDiasFestivos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genDiasFestivos_log(
Fecha,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Fecha,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Fecha=inserted.Fecha)
 END
GO

 DROP TRIGGER genDiasLoginins
GO

 CREATE TRIGGER genDiasLoginins
ON genDiasLogin
AFTER INSERT
AS
 BEGIN
INSERT INTO genDiasLogin_log(
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Lunes=inserted.Lunes)
 END
GO

 DROP TRIGGER genDiasLogindel
GO

 CREATE TRIGGER genDiasLogindel
ON genDiasLogin
AFTER DELETE
AS
 BEGIN
INSERT INTO genDiasLogin_log(
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Lunes=deleted.Lunes)
 END
GO

 DROP TRIGGER genDiasLoginupd
GO

 CREATE TRIGGER genDiasLoginupd
ON genDiasLogin
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genDiasLogin_log(
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
Festivos,
HoraDesde,
HoraHasta,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Lunes=inserted.Lunes)
 END
GO

 DROP TRIGGER genDominiosins
GO

 CREATE TRIGGER genDominiosins
ON genDominios
AFTER INSERT
AS
 BEGIN
INSERT INTO genDominios_log(
Dominio_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genDominiosdel
GO

 CREATE TRIGGER genDominiosdel
ON genDominios
AFTER DELETE
AS
 BEGIN
INSERT INTO genDominios_log(
Dominio_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Dominio_Id=deleted.Dominio_Id)
 END
GO

 DROP TRIGGER genDominiosupd
GO

 CREATE TRIGGER genDominiosupd
ON genDominios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genDominios_log(
Dominio_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genEmpresasins
GO

 CREATE TRIGGER genEmpresasins
ON genEmpresas
AFTER INSERT
AS
 BEGIN
INSERT INTO genEmpresas_log(
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
FechaModifLog,
TipoModificacion
)
(Select 
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
GETDATE(),
'ins'
FROM inserted where genEmpresas=inserted.genEmpresas)
 END
GO

 DROP TRIGGER genEmpresasdel
GO

 CREATE TRIGGER genEmpresasdel
ON genEmpresas
AFTER DELETE
AS
 BEGIN
INSERT INTO genEmpresas_log(
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
FechaModifLog,
TipoModificacion
)
(Select 
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
GETDATE(),
'del'
FROM deleted where genEmpresas=deleted.genEmpresas)
 END
GO

 DROP TRIGGER genEmpresasupd
GO

 CREATE TRIGGER genEmpresasupd
ON genEmpresas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genEmpresas_log(
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
FechaModifLog,
TipoModificacion
)
(Select 
genEmpresas,
Empresa_Id,
Detalle,
RazonSocial,
Logo,
ExtensionArchivo,
Moneda_Id,
Pais_Id,
Cuit,
Calle,
NoExterior,
NoInterior,
Colonia,
Localidad,
Municipio,
Referencia,
Provincia_Id,
CodigoPostal,
FechaInicioSumma,
FechaInicioSociedad,
FechaCierreCompras,
FechaCierreVentas,
FechaCierreStock,
FechaCalculoStock,
FechaCierreTesoreria,
FechaCierreImpuestos,
FechaCierreActivoFijo,
FechaCalculoActivoFijo,
FechaCalculoActivoDiferido,
FechaCierreSueldos,
NumeroIIBB,
IGJ,
Actividad,
Regimen,
Telefono,
CarpetaEspecial,
UsaCantidadAlterna,
UsaDespachoImportacion,
UsaSerie,
CtaMercaEnTransitoImpor,
TipoCosto,
TipoCosto2,
TipoCosto3,
CodLocalidad,
CodColonia,
CodMunicipio,
CondFiscal,
PaginaWeb,
SucursalCentral,
CtaMercTransito,
CtaApliImportacion,
Centro1De,
Centro2De,
CtaUtiCambioRealizada,
CtaPerCambioRealizada,
CtaUtiCambioProv,
CtaPerCambioProv,
CtaAjuStockPos,
CtaAjuStockNeg,
Servidor,
Puerto,
Correo,
UsuarioCorreo,
Clave,
Seguridad,
EnviaFacturas,
EnviaRecibo,
EnviaOC,
EnviaPedido,
ConfirmarEnviarPedidos,
ConfirmarEnviarFacturas,
ConfirmarEnviarRecibo,
ConfirmarEnviarOC,
MailClientesSinMail,
CFVenta_Id,
Medida_Id,
CFAjusCtaCte,
TipoDtoFin,
MontoDtoFinanciero,
CtaDtoFinPos,
CtaDtoFinNeg,
Usuario_Id,
Inactivo,
Firma,
ImagenFirmaB64,
CuentasDeposito,
GETDATE(),
'upd'
FROM inserted where genEmpresas=inserted.genEmpresas)
 END
GO

 DROP TRIGGER genEntidadesins
GO

 CREATE TRIGGER genEntidadesins
ON genEntidades
AFTER INSERT
AS
 BEGIN
INSERT INTO genEntidades_log(
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER genEntidadesdel
GO

 CREATE TRIGGER genEntidadesdel
ON genEntidades
AFTER DELETE
AS
 BEGIN
INSERT INTO genEntidades_log(
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER genEntidadesupd
GO

 CREATE TRIGGER genEntidadesupd
ON genEntidades
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genEntidades_log(
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
FechaAlta,
Usuario_Id,
Cuit,
TipoDoc,
IdFiscal,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER genEntidadesBasicasins
GO

 CREATE TRIGGER genEntidadesBasicasins
ON genEntidadesBasicas
AFTER INSERT
AS
 BEGIN
INSERT INTO genEntidadesBasicas_log(
Entidad_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Entidad_Id=inserted.Entidad_Id)
 END
GO

 DROP TRIGGER genEntidadesBasicasdel
GO

 CREATE TRIGGER genEntidadesBasicasdel
ON genEntidadesBasicas
AFTER DELETE
AS
 BEGIN
INSERT INTO genEntidadesBasicas_log(
Entidad_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Entidad_Id=deleted.Entidad_Id)
 END
GO

 DROP TRIGGER genEntidadesBasicasupd
GO

 CREATE TRIGGER genEntidadesBasicasupd
ON genEntidadesBasicas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genEntidadesBasicas_log(
Entidad_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Entidad_Id=inserted.Entidad_Id)
 END
GO

 DROP TRIGGER genEntidadesBasicasValorins
GO

 CREATE TRIGGER genEntidadesBasicasValorins
ON genEntidadesBasicasValor
AFTER INSERT
AS
 BEGIN
INSERT INTO genEntidadesBasicasValor_log(
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Entidad_Id=inserted.Entidad_Id)
 END
GO

 DROP TRIGGER genEntidadesBasicasValordel
GO

 CREATE TRIGGER genEntidadesBasicasValordel
ON genEntidadesBasicasValor
AFTER DELETE
AS
 BEGIN
INSERT INTO genEntidadesBasicasValor_log(
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
GETDATE(),
'del'
FROM deleted where Entidad_Id=deleted.Entidad_Id)
 END
GO

 DROP TRIGGER genEntidadesBasicasValorupd
GO

 CREATE TRIGGER genEntidadesBasicasValorupd
ON genEntidadesBasicasValor
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genEntidadesBasicasValor_log(
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Entidad_Id,
Dominio_Id,
Clave,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Entidad_Id=inserted.Entidad_Id)
 END
GO

 DROP TRIGGER genFavoritosUsuariosins
GO

 CREATE TRIGGER genFavoritosUsuariosins
ON genFavoritosUsuarios
AFTER INSERT
AS
 BEGIN
INSERT INTO genFavoritosUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genFavoritosUsuariosdel
GO

 CREATE TRIGGER genFavoritosUsuariosdel
ON genFavoritosUsuarios
AFTER DELETE
AS
 BEGIN
INSERT INTO genFavoritosUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER genFavoritosUsuariosupd
GO

 CREATE TRIGGER genFavoritosUsuariosupd
ON genFavoritosUsuarios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genFavoritosUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genGlobalesins
GO

 CREATE TRIGGER genGlobalesins
ON genGlobales
AFTER INSERT
AS
 BEGIN
INSERT INTO genGlobales_log(
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genGlobalesdel
GO

 CREATE TRIGGER genGlobalesdel
ON genGlobales
AFTER DELETE
AS
 BEGIN
INSERT INTO genGlobales_log(
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER genGlobalesupd
GO

 CREATE TRIGGER genGlobalesupd
ON genGlobales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genGlobales_log(
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Nombre_Var,
Descripcion,
Tipo,
Longitud,
Decimales,
nValor,
cValor,
fValor,
mValor,
SubSistema,
SoloLectura,
lupIdentidad,
WhereF10,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER genGruposins
GO

 CREATE TRIGGER genGruposins
ON genGrupos
AFTER INSERT
AS
 BEGIN
INSERT INTO genGrupos_log(
Grupo_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Grupo_Id=inserted.Grupo_Id)
 END
GO

 DROP TRIGGER genGruposdel
GO

 CREATE TRIGGER genGruposdel
ON genGrupos
AFTER DELETE
AS
 BEGIN
INSERT INTO genGrupos_log(
Grupo_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Grupo_Id=deleted.Grupo_Id)
 END
GO

 DROP TRIGGER genGruposupd
GO

 CREATE TRIGGER genGruposupd
ON genGrupos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genGrupos_log(
Grupo_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Grupo_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Grupo_Id=inserted.Grupo_Id)
 END
GO

 DROP TRIGGER genInstalacionins
GO

 CREATE TRIGGER genInstalacionins
ON genInstalacion
AFTER INSERT
AS
 BEGIN
INSERT INTO genInstalacion_log(
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
GETDATE(),
'ins'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genInstalaciondel
GO

 CREATE TRIGGER genInstalaciondel
ON genInstalacion
AFTER DELETE
AS
 BEGIN
INSERT INTO genInstalacion_log(
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
GETDATE(),
'del'
FROM deleted where Dominio_Id=deleted.Dominio_Id)
 END
GO

 DROP TRIGGER genInstalacionupd
GO

 CREATE TRIGGER genInstalacionupd
ON genInstalacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genInstalacion_log(
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
Licencias,
RptServidor,
RptCarpeta,
RptUsuario,
RptClave,
RptDominio,
UsoHorario,
Licencia,
Clave,
FechaVencimiento,
PorEmpresa,
TamanioHoja,
LongitudClave,
DiasDuracionClave,
LoginGracia,
CantIntentosFallidos,
ClaveSimbolos,
ClaveNumero,
ClaveMayuscula,
ClaveMinuscula,
ClaveComunes,
conDigiCta,
conDigiSubCta,
contMascaraCuenta,
GETDATE(),
'upd'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genJurisCoeficientesins
GO

 CREATE TRIGGER genJurisCoeficientesins
ON genJurisCoeficientes
AFTER INSERT
AS
 BEGIN
INSERT INTO genJurisCoeficientes_log(
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER genJurisCoeficientesdel
GO

 CREATE TRIGGER genJurisCoeficientesdel
ON genJurisCoeficientes
AFTER DELETE
AS
 BEGIN
INSERT INTO genJurisCoeficientes_log(
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER genJurisCoeficientesupd
GO

 CREATE TRIGGER genJurisCoeficientesupd
ON genJurisCoeficientes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genJurisCoeficientes_log(
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Juris_Id,
Situacion,
Coeficiente,
Exencion,
FechaHasta,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER genLexicoins
GO

 CREATE TRIGGER genLexicoins
ON genLexico
AFTER INSERT
AS
 BEGIN
INSERT INTO genLexico_log(
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
FechaModifLog,
TipoModificacion
)
(Select 
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
GETDATE(),
'ins'
FROM inserted where SetFunciones=inserted.SetFunciones)
 END
GO

 DROP TRIGGER genLexicodel
GO

 CREATE TRIGGER genLexicodel
ON genLexico
AFTER DELETE
AS
 BEGIN
INSERT INTO genLexico_log(
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
FechaModifLog,
TipoModificacion
)
(Select 
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
GETDATE(),
'del'
FROM deleted where SetFunciones=deleted.SetFunciones)
 END
GO

 DROP TRIGGER genLexicoupd
GO

 CREATE TRIGGER genLexicoupd
ON genLexico
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genLexico_log(
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
FechaModifLog,
TipoModificacion
)
(Select 
SetFunciones,
Funcion,
Descripcion,
Token,
TipoDato,
GETDATE(),
'upd'
FROM inserted where SetFunciones=inserted.SetFunciones)
 END
GO

 DROP TRIGGER genLinksAyudains
GO

 CREATE TRIGGER genLinksAyudains
ON genLinksAyuda
AFTER INSERT
AS
 BEGIN
INSERT INTO genLinksAyuda_log(
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
FechaModifLog,
TipoModificacion
)
(Select 
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
GETDATE(),
'ins'
FROM inserted where CodigoLnk=inserted.CodigoLnk)
 END
GO

 DROP TRIGGER genLinksAyudadel
GO

 CREATE TRIGGER genLinksAyudadel
ON genLinksAyuda
AFTER DELETE
AS
 BEGIN
INSERT INTO genLinksAyuda_log(
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
FechaModifLog,
TipoModificacion
)
(Select 
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
GETDATE(),
'del'
FROM deleted where CodigoLnk=deleted.CodigoLnk)
 END
GO

 DROP TRIGGER genLinksAyudaupd
GO

 CREATE TRIGGER genLinksAyudaupd
ON genLinksAyuda
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genLinksAyuda_log(
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
FechaModifLog,
TipoModificacion
)
(Select 
CodigoLnk,
Dominio_Id,
Descripcion,
Link,
GETDATE(),
'upd'
FROM inserted where CodigoLnk=inserted.CodigoLnk)
 END
GO

 DROP TRIGGER genMensajesins
GO

 CREATE TRIGGER genMensajesins
ON genMensajes
AFTER INSERT
AS
 BEGIN
INSERT INTO genMensajes_log(
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
FechaModifLog,
TipoModificacion
)
(Select 
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
GETDATE(),
'ins'
FROM inserted where Mensaje_Id=inserted.Mensaje_Id)
 END
GO

 DROP TRIGGER genMensajesdel
GO

 CREATE TRIGGER genMensajesdel
ON genMensajes
AFTER DELETE
AS
 BEGIN
INSERT INTO genMensajes_log(
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
FechaModifLog,
TipoModificacion
)
(Select 
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
GETDATE(),
'del'
FROM deleted where Mensaje_Id=deleted.Mensaje_Id)
 END
GO

 DROP TRIGGER genMensajesupd
GO

 CREATE TRIGGER genMensajesupd
ON genMensajes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMensajes_log(
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
FechaModifLog,
TipoModificacion
)
(Select 
Mensaje_Id,
Mensaje,
Leido,
Usuario_Id,
UsuarioDestino,
FechaEmision,
FechaDesde,
FechaHasta,
Parametros,
Formulario_Id,
Tipo,
SubTipo,
GETDATE(),
'upd'
FROM inserted where Mensaje_Id=inserted.Mensaje_Id)
 END
GO

 DROP TRIGGER genMenusins
GO

 CREATE TRIGGER genMenusins
ON genMenus
AFTER INSERT
AS
 BEGIN
INSERT INTO genMenus_log(
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
FechaModifLog,
TipoModificacion
)
(Select 
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
GETDATE(),
'ins'
FROM inserted where Orden=inserted.Orden)
 END
GO

 DROP TRIGGER genMenusdel
GO

 CREATE TRIGGER genMenusdel
ON genMenus
AFTER DELETE
AS
 BEGIN
INSERT INTO genMenus_log(
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
FechaModifLog,
TipoModificacion
)
(Select 
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
GETDATE(),
'del'
FROM deleted where Orden=deleted.Orden)
 END
GO

 DROP TRIGGER genMenusupd
GO

 CREATE TRIGGER genMenusupd
ON genMenus
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMenus_log(
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
FechaModifLog,
TipoModificacion
)
(Select 
Orden,
Empresa_Id,
Nivel,
Opcion,
Tipo,
Formulario_Id,
FrmEspecial,
Pais,
Orientacion,
Reporte_Id,
Especial,
genMenus,
GETDATE(),
'upd'
FROM inserted where Orden=inserted.Orden)
 END
GO

 DROP TRIGGER genMenusOrdenins
GO

 CREATE TRIGGER genMenusOrdenins
ON genMenusOrden
AFTER INSERT
AS
 BEGIN
INSERT INTO genMenusOrden_log(
Opcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Opcion,
Orden,
GETDATE(),
'ins'
FROM inserted where Opcion=inserted.Opcion)
 END
GO

 DROP TRIGGER genMenusOrdendel
GO

 CREATE TRIGGER genMenusOrdendel
ON genMenusOrden
AFTER DELETE
AS
 BEGIN
INSERT INTO genMenusOrden_log(
Opcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Opcion,
Orden,
GETDATE(),
'del'
FROM deleted where Opcion=deleted.Opcion)
 END
GO

 DROP TRIGGER genMenusOrdenupd
GO

 CREATE TRIGGER genMenusOrdenupd
ON genMenusOrden
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMenusOrden_log(
Opcion,
Orden,
FechaModifLog,
TipoModificacion
)
(Select 
Opcion,
Orden,
GETDATE(),
'upd'
FROM inserted where Opcion=inserted.Opcion)
 END
GO

 DROP TRIGGER genMonedasins
GO

 CREATE TRIGGER genMonedasins
ON genMonedas
AFTER INSERT
AS
 BEGIN
INSERT INTO genMonedas_log(
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where genMonedas=inserted.genMonedas)
 END
GO

 DROP TRIGGER genMonedasdel
GO

 CREATE TRIGGER genMonedasdel
ON genMonedas
AFTER DELETE
AS
 BEGIN
INSERT INTO genMonedas_log(
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where genMonedas=deleted.genMonedas)
 END
GO

 DROP TRIGGER genMonedasupd
GO

 CREATE TRIGGER genMonedasupd
ON genMonedas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMonedas_log(
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genMonedas,
Moneda_Id,
Empresa_Id,
Descripcion,
Simbolo,
CodigoFiscal,
CtaFactaRecibir,
CtaFactaRecibirImp,
CantidadDigitos,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where genMonedas=inserted.genMonedas)
 END
GO

 DROP TRIGGER genMovCuotasins
GO

 CREATE TRIGGER genMovCuotasins
ON genMovCuotas
AFTER INSERT
AS
 BEGIN
INSERT INTO genMovCuotas_log(
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genMovCuotasdel
GO

 CREATE TRIGGER genMovCuotasdel
ON genMovCuotas
AFTER DELETE
AS
 BEGIN
INSERT INTO genMovCuotas_log(
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER genMovCuotasupd
GO

 CREATE TRIGGER genMovCuotasupd
ON genMovCuotas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMovCuotas_log(
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
CuotaNro,
FechaVencimiento,
Importe,
Saldo,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genMovimientosins
GO

 CREATE TRIGGER genMovimientosins
ON genMovimientos
AFTER INSERT
AS
 BEGIN
INSERT INTO genMovimientos_log(
Asiento_Id,
genEntidades,
CantCuotas,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
genEntidades,
CantCuotas,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genMovimientosdel
GO

 CREATE TRIGGER genMovimientosdel
ON genMovimientos
AFTER DELETE
AS
 BEGIN
INSERT INTO genMovimientos_log(
Asiento_Id,
genEntidades,
CantCuotas,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
genEntidades,
CantCuotas,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER genMovimientosupd
GO

 CREATE TRIGGER genMovimientosupd
ON genMovimientos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genMovimientos_log(
Asiento_Id,
genEntidades,
CantCuotas,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
genEntidades,
CantCuotas,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER genPaisesins
GO

 CREATE TRIGGER genPaisesins
ON genPaises
AFTER INSERT
AS
 BEGIN
INSERT INTO genPaises_log(
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where genPaises=inserted.genPaises)
 END
GO

 DROP TRIGGER genPaisesdel
GO

 CREATE TRIGGER genPaisesdel
ON genPaises
AFTER DELETE
AS
 BEGIN
INSERT INTO genPaises_log(
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where genPaises=deleted.genPaises)
 END
GO

 DROP TRIGGER genPaisesupd
GO

 CREATE TRIGGER genPaisesupd
ON genPaises
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genPaises_log(
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genPaises,
Pais_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Dominio_Id,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where genPaises=inserted.genPaises)
 END
GO

 DROP TRIGGER genPermisosins
GO

 CREATE TRIGGER genPermisosins
ON genPermisos
AFTER INSERT
AS
 BEGIN
INSERT INTO genPermisos_log(
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genPermisosdel
GO

 CREATE TRIGGER genPermisosdel
ON genPermisos
AFTER DELETE
AS
 BEGIN
INSERT INTO genPermisos_log(
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER genPermisosupd
GO

 CREATE TRIGGER genPermisosupd
ON genPermisos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genPermisos_log(
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Formulario_Id,
Empresa_Id,
Consultar,
Actualizar,
Borrar,
Postear,
ModificaCodigos,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genProvinciasins
GO

 CREATE TRIGGER genProvinciasins
ON genProvincias
AFTER INSERT
AS
 BEGIN
INSERT INTO genProvincias_log(
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where genProvincias=inserted.genProvincias)
 END
GO

 DROP TRIGGER genProvinciasdel
GO

 CREATE TRIGGER genProvinciasdel
ON genProvincias
AFTER DELETE
AS
 BEGIN
INSERT INTO genProvincias_log(
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where genProvincias=deleted.genProvincias)
 END
GO

 DROP TRIGGER genProvinciasupd
GO

 CREATE TRIGGER genProvinciasupd
ON genProvincias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genProvincias_log(
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
genProvincias,
Provincia_Id,
Empresa_Id,
Descripcion,
CodFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where genProvincias=inserted.genProvincias)
 END
GO

 DROP TRIGGER genReportesins
GO

 CREATE TRIGGER genReportesins
ON genReportes
AFTER INSERT
AS
 BEGIN
INSERT INTO genReportes_log(
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
GETDATE(),
'ins'
FROM inserted where genReportes=inserted.genReportes)
 END
GO

 DROP TRIGGER genReportesdel
GO

 CREATE TRIGGER genReportesdel
ON genReportes
AFTER DELETE
AS
 BEGIN
INSERT INTO genReportes_log(
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
GETDATE(),
'del'
FROM deleted where genReportes=deleted.genReportes)
 END
GO

 DROP TRIGGER genReportesupd
GO

 CREATE TRIGGER genReportesupd
ON genReportes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genReportes_log(
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Reporte_Id,
Titulo,
Rpt,
Carpeta,
Estandar,
Local,
StoreProcedure,
TamanioHoja,
AnchoHoja,
AltoHoja,
TipoReporte,
GETDATE(),
'upd'
FROM inserted where genReportes=inserted.genReportes)
 END
GO

 DROP TRIGGER genReportesSPins
GO

 CREATE TRIGGER genReportesSPins
ON genReportesSP
AFTER INSERT
AS
 BEGIN
INSERT INTO genReportesSP_log(
genReportes,
Renglon,
StoreProcedure,
DataTable,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Renglon,
StoreProcedure,
DataTable,
GETDATE(),
'ins'
FROM inserted where genReportes=inserted.genReportes)
 END
GO

 DROP TRIGGER genReportesSPdel
GO

 CREATE TRIGGER genReportesSPdel
ON genReportesSP
AFTER DELETE
AS
 BEGIN
INSERT INTO genReportesSP_log(
genReportes,
Renglon,
StoreProcedure,
DataTable,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Renglon,
StoreProcedure,
DataTable,
GETDATE(),
'del'
FROM deleted where genReportes=deleted.genReportes)
 END
GO

 DROP TRIGGER genReportesSPupd
GO

 CREATE TRIGGER genReportesSPupd
ON genReportesSP
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genReportesSP_log(
genReportes,
Renglon,
StoreProcedure,
DataTable,
FechaModifLog,
TipoModificacion
)
(Select 
genReportes,
Renglon,
StoreProcedure,
DataTable,
GETDATE(),
'upd'
FROM inserted where genReportes=inserted.genReportes)
 END
GO

 DROP TRIGGER genSegmentoOrigenesins
GO

 CREATE TRIGGER genSegmentoOrigenesins
ON genSegmentoOrigenes
AFTER INSERT
AS
 BEGIN
INSERT INTO genSegmentoOrigenes_log(
OriSeg_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
OriSeg_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where OriSeg_Id=inserted.OriSeg_Id)
 END
GO

 DROP TRIGGER genSegmentoOrigenesdel
GO

 CREATE TRIGGER genSegmentoOrigenesdel
ON genSegmentoOrigenes
AFTER DELETE
AS
 BEGIN
INSERT INTO genSegmentoOrigenes_log(
OriSeg_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
OriSeg_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where OriSeg_Id=deleted.OriSeg_Id)
 END
GO

 DROP TRIGGER genSegmentoOrigenesupd
GO

 CREATE TRIGGER genSegmentoOrigenesupd
ON genSegmentoOrigenes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genSegmentoOrigenes_log(
OriSeg_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
OriSeg_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where OriSeg_Id=inserted.OriSeg_Id)
 END
GO

 DROP TRIGGER genSegmentosins
GO

 CREATE TRIGGER genSegmentosins
ON genSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO genSegmentos_log(
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
FechaModifLog,
TipoModificacion
)
(Select 
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
GETDATE(),
'ins'
FROM inserted where genSegmentos=inserted.genSegmentos)
 END
GO

 DROP TRIGGER genSegmentosdel
GO

 CREATE TRIGGER genSegmentosdel
ON genSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO genSegmentos_log(
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
FechaModifLog,
TipoModificacion
)
(Select 
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
GETDATE(),
'del'
FROM deleted where genSegmentos=deleted.genSegmentos)
 END
GO

 DROP TRIGGER genSegmentosupd
GO

 CREATE TRIGGER genSegmentosupd
ON genSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genSegmentos_log(
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
FechaModifLog,
TipoModificacion
)
(Select 
genSegmentos,
Segmento_Id,
Descripcion,
Digitos1N,
Digitos2N,
Digitos3N,
Digitos4N,
TieneColumnaAutomatica,
Digitos1C,
Digitos2C,
Digitos3C,
Digitos4C,
Origen1N,
Origen2N,
Origen3N,
Origen4N,
Origen1C,
Origen2C,
Origen3C,
Origen4C,
Orden1N,
Orden2N,
Orden3N,
Orden4N,
Orden1C,
Orden2C,
Orden3C,
Orden4C,
HabilitaEdicion,
TamanioVariable,
Inactivo,
Usuario_Id,
Posteado,
EsSueldos,
GETDATE(),
'upd'
FROM inserted where genSegmentos=inserted.genSegmentos)
 END
GO

 DROP TRIGGER genSegmentosNombresins
GO

 CREATE TRIGGER genSegmentosNombresins
ON genSegmentosNombres
AFTER INSERT
AS
 BEGIN
INSERT INTO genSegmentosNombres_log(
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER genSegmentosNombresdel
GO

 CREATE TRIGGER genSegmentosNombresdel
ON genSegmentosNombres
AFTER DELETE
AS
 BEGIN
INSERT INTO genSegmentosNombres_log(
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Segmento_Id=deleted.Segmento_Id)
 END
GO

 DROP TRIGGER genSegmentosNombresupd
GO

 CREATE TRIGGER genSegmentosNombresupd
ON genSegmentosNombres
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genSegmentosNombres_log(
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Nombre1N,
Nombre2N,
Nombre3N,
Nombre4N,
Nombre1C,
Nombre2C,
Nombre3C,
Nombre4C,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER genSucursalesEmprins
GO

 CREATE TRIGGER genSucursalesEmprins
ON genSucursalesEmpr
AFTER INSERT
AS
 BEGIN
INSERT INTO genSucursalesEmpr_log(
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
FechaModifLog,
TipoModificacion
)
(Select 
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
GETDATE(),
'ins'
FROM inserted where genSucursalesEmpr=inserted.genSucursalesEmpr)
 END
GO

 DROP TRIGGER genSucursalesEmprdel
GO

 CREATE TRIGGER genSucursalesEmprdel
ON genSucursalesEmpr
AFTER DELETE
AS
 BEGIN
INSERT INTO genSucursalesEmpr_log(
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
FechaModifLog,
TipoModificacion
)
(Select 
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
GETDATE(),
'del'
FROM deleted where genSucursalesEmpr=deleted.genSucursalesEmpr)
 END
GO

 DROP TRIGGER genSucursalesEmprupd
GO

 CREATE TRIGGER genSucursalesEmprupd
ON genSucursalesEmpr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genSucursalesEmpr_log(
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
FechaModifLog,
TipoModificacion
)
(Select 
genSucursalesEmpr,
Sucursal,
Empresa_Id,
Descripcion,
Provincia_Id,
Pais_Id,
DepositoVentas,
DepositoPedidos,
DepositoOC,
FechaCaja,
VaConCentral,
FacturaElectronica,
UsaWS,
TipoFE,
Direccion,
Localidad,
Telefono,
CodigoPostal,
SucursalRemito,
SucursalTesoreria,
Serie,
Inactivo,
Usuario_Id,
Posteado,
RegPatronal,
GETDATE(),
'upd'
FROM inserted where genSucursalesEmpr=inserted.genSucursalesEmpr)
 END
GO

 DROP TRIGGER genTamanioHojains
GO

 CREATE TRIGGER genTamanioHojains
ON genTamanioHoja
AFTER INSERT
AS
 BEGIN
INSERT INTO genTamanioHoja_log(
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
FechaModifLog,
TipoModificacion
)
(Select 
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
GETDATE(),
'ins'
FROM inserted where TamanioHoja=inserted.TamanioHoja)
 END
GO

 DROP TRIGGER genTamanioHojadel
GO

 CREATE TRIGGER genTamanioHojadel
ON genTamanioHoja
AFTER DELETE
AS
 BEGIN
INSERT INTO genTamanioHoja_log(
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
FechaModifLog,
TipoModificacion
)
(Select 
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
GETDATE(),
'del'
FROM deleted where TamanioHoja=deleted.TamanioHoja)
 END
GO

 DROP TRIGGER genTamanioHojaupd
GO

 CREATE TRIGGER genTamanioHojaupd
ON genTamanioHoja
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genTamanioHoja_log(
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
FechaModifLog,
TipoModificacion
)
(Select 
TamanioHoja,
Descripcion,
AltoIn,
AnchoIn,
Altocm,
Anchicm,
AltoPx,
AnchoPx,
GETDATE(),
'upd'
FROM inserted where TamanioHoja=inserted.TamanioHoja)
 END
GO

 DROP TRIGGER genTipoCambioins
GO

 CREATE TRIGGER genTipoCambioins
ON genTipoCambio
AFTER INSERT
AS
 BEGIN
INSERT INTO genTipoCambio_log(
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Moneda_Id=inserted.Moneda_Id)
 END
GO

 DROP TRIGGER genTipoCambiodel
GO

 CREATE TRIGGER genTipoCambiodel
ON genTipoCambio
AFTER DELETE
AS
 BEGIN
INSERT INTO genTipoCambio_log(
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Moneda_Id=deleted.Moneda_Id)
 END
GO

 DROP TRIGGER genTipoCambioupd
GO

 CREATE TRIGGER genTipoCambioupd
ON genTipoCambio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genTipoCambio_log(
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Moneda_Id,
Fecha,
Empresa_Id,
CambioCompra,
CambioVenta,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Moneda_Id=inserted.Moneda_Id)
 END
GO

 DROP TRIGGER genTiposCompAfipins
GO

 CREATE TRIGGER genTiposCompAfipins
ON genTiposCompAfip
AFTER INSERT
AS
 BEGIN
INSERT INTO genTiposCompAfip_log(
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaModifLog,
TipoModificacion
)
(Select 
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
GETDATE(),
'ins'
FROM inserted where Comprobante_Id=inserted.Comprobante_Id)
 END
GO

 DROP TRIGGER genTiposCompAfipdel
GO

 CREATE TRIGGER genTiposCompAfipdel
ON genTiposCompAfip
AFTER DELETE
AS
 BEGIN
INSERT INTO genTiposCompAfip_log(
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaModifLog,
TipoModificacion
)
(Select 
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
GETDATE(),
'del'
FROM deleted where Comprobante_Id=deleted.Comprobante_Id)
 END
GO

 DROP TRIGGER genTiposCompAfipupd
GO

 CREATE TRIGGER genTiposCompAfipupd
ON genTiposCompAfip
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genTiposCompAfip_log(
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
FechaModifLog,
TipoModificacion
)
(Select 
Comprobante_Id,
Descripcion,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
GETDATE(),
'upd'
FROM inserted where Comprobante_Id=inserted.Comprobante_Id)
 END
GO

 DROP TRIGGER genTiposDocins
GO

 CREATE TRIGGER genTiposDocins
ON genTiposDoc
AFTER INSERT
AS
 BEGIN
INSERT INTO genTiposDoc_log(
Dominio_Id,
TipoDoc,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
TipoDoc,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genTiposDocdel
GO

 CREATE TRIGGER genTiposDocdel
ON genTiposDoc
AFTER DELETE
AS
 BEGIN
INSERT INTO genTiposDoc_log(
Dominio_Id,
TipoDoc,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
TipoDoc,
Descripcion,
GETDATE(),
'del'
FROM deleted where Dominio_Id=deleted.Dominio_Id)
 END
GO

 DROP TRIGGER genTiposDocupd
GO

 CREATE TRIGGER genTiposDocupd
ON genTiposDoc
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genTiposDoc_log(
Dominio_Id,
TipoDoc,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Dominio_Id,
TipoDoc,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Dominio_Id=inserted.Dominio_Id)
 END
GO

 DROP TRIGGER genUltPaginasVisitadasUsuariosins
GO

 CREATE TRIGGER genUltPaginasVisitadasUsuariosins
ON genUltPaginasVisitadasUsuarios
AFTER INSERT
AS
 BEGIN
INSERT INTO genUltPaginasVisitadasUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genUltPaginasVisitadasUsuariosdel
GO

 CREATE TRIGGER genUltPaginasVisitadasUsuariosdel
ON genUltPaginasVisitadasUsuarios
AFTER DELETE
AS
 BEGIN
INSERT INTO genUltPaginasVisitadasUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER genUltPaginasVisitadasUsuariosupd
GO

 CREATE TRIGGER genUltPaginasVisitadasUsuariosupd
ON genUltPaginasVisitadasUsuarios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genUltPaginasVisitadasUsuarios_log(
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
OrdenFormularioMenu,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER genUsuariosins
GO

 CREATE TRIGGER genUsuariosins
ON genUsuarios
AFTER INSERT
AS
 BEGIN
INSERT INTO genUsuarios_log(
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
FechaModifLog,
TipoModificacion
)
(Select 
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
GETDATE(),
'ins'
FROM inserted where genUsuarios=inserted.genUsuarios)
 END
GO

 DROP TRIGGER genUsuariosdel
GO

 CREATE TRIGGER genUsuariosdel
ON genUsuarios
AFTER DELETE
AS
 BEGIN
INSERT INTO genUsuarios_log(
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
FechaModifLog,
TipoModificacion
)
(Select 
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
GETDATE(),
'del'
FROM deleted where genUsuarios=deleted.genUsuarios)
 END
GO

 DROP TRIGGER genUsuariosupd
GO

 CREATE TRIGGER genUsuariosupd
ON genUsuarios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genUsuarios_log(
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
FechaModifLog,
TipoModificacion
)
(Select 
genUsuarios,
Usuario_Id,
Empresa_Id,
Apellido_y_Nombres,
TipoUsuario,
Sucursal,
Clave_de_Acceso,
Cargo,
UltCambioPass,
Intentos,
Email,
UsuarioCarga,
PtoEmision,
CambiarClave,
MalClave,
EsSupervisor,
Cultura,
MultiplesLogins,
Cliente_Id,
Proveed_Id,
Vendedor_Id,
Cobrador_Id,
Legajo,
RestringeHorarios,
Inactivo,
Posteado,
Firma,
ImagenFirmaB64,
GETDATE(),
'upd'
FROM inserted where genUsuarios=inserted.genUsuarios)
 END
GO

 DROP TRIGGER genUsuariosLogueadosins
GO

 CREATE TRIGGER genUsuariosLogueadosins
ON genUsuariosLogueados
AFTER INSERT
AS
 BEGIN
INSERT INTO genUsuariosLogueados_log(
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
FechaModifLog,
TipoModificacion
)
(Select 
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
GETDATE(),
'ins'
FROM inserted where Token=inserted.Token)
 END
GO

 DROP TRIGGER genUsuariosLogueadosdel
GO

 CREATE TRIGGER genUsuariosLogueadosdel
ON genUsuariosLogueados
AFTER DELETE
AS
 BEGIN
INSERT INTO genUsuariosLogueados_log(
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
FechaModifLog,
TipoModificacion
)
(Select 
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
GETDATE(),
'del'
FROM deleted where Token=deleted.Token)
 END
GO

 DROP TRIGGER genUsuariosLogueadosupd
GO

 CREATE TRIGGER genUsuariosLogueadosupd
ON genUsuariosLogueados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genUsuariosLogueados_log(
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
FechaModifLog,
TipoModificacion
)
(Select 
Token,
Usuario_Id,
UltEmpresa,
FechaLogin,
Caduca,
GETDATE(),
'upd'
FROM inserted where Token=inserted.Token)
 END
GO

 DROP TRIGGER genVersionins
GO

 CREATE TRIGGER genVersionins
ON genVersion
AFTER INSERT
AS
 BEGIN
INSERT INTO genVersion_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'ins'
FROM inserted where Version=inserted.Version)
 END
GO

 DROP TRIGGER genVersiondel
GO

 CREATE TRIGGER genVersiondel
ON genVersion
AFTER DELETE
AS
 BEGIN
INSERT INTO genVersion_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'del'
FROM deleted where Version=deleted.Version)
 END
GO

 DROP TRIGGER genVersionupd
GO

 CREATE TRIGGER genVersionupd
ON genVersion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genVersion_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'upd'
FROM inserted where Version=inserted.Version)
 END
GO

 DROP TRIGGER genVersionEmpresasins
GO

 CREATE TRIGGER genVersionEmpresasins
ON genVersionEmpresas
AFTER INSERT
AS
 BEGIN
INSERT INTO genVersionEmpresas_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'ins'
FROM inserted where Version=inserted.Version)
 END
GO

 DROP TRIGGER genVersionEmpresasdel
GO

 CREATE TRIGGER genVersionEmpresasdel
ON genVersionEmpresas
AFTER DELETE
AS
 BEGIN
INSERT INTO genVersionEmpresas_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'del'
FROM deleted where Version=deleted.Version)
 END
GO

 DROP TRIGGER genVersionEmpresasupd
GO

 CREATE TRIGGER genVersionEmpresasupd
ON genVersionEmpresas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genVersionEmpresas_log(
Version,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
Version,
Fecha,
GETDATE(),
'upd'
FROM inserted where Version=inserted.Version)
 END
GO

 DROP TRIGGER genWSFactElecins
GO

 CREATE TRIGGER genWSFactElecins
ON genWSFactElec
AFTER INSERT
AS
 BEGIN
INSERT INTO genWSFactElec_log(
TipoFE,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoFE,
Descripcion,
GETDATE(),
'ins'
FROM inserted where TipoFE=inserted.TipoFE)
 END
GO

 DROP TRIGGER genWSFactElecdel
GO

 CREATE TRIGGER genWSFactElecdel
ON genWSFactElec
AFTER DELETE
AS
 BEGIN
INSERT INTO genWSFactElec_log(
TipoFE,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoFE,
Descripcion,
GETDATE(),
'del'
FROM deleted where TipoFE=deleted.TipoFE)
 END
GO

 DROP TRIGGER genWSFactElecupd
GO

 CREATE TRIGGER genWSFactElecupd
ON genWSFactElec
AFTER  UPDATE
AS
 BEGIN
INSERT INTO genWSFactElec_log(
TipoFE,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoFE,
Descripcion,
GETDATE(),
'upd'
FROM inserted where TipoFE=inserted.TipoFE)
 END
GO

 DROP TRIGGER impArbaTxtins
GO

 CREATE TRIGGER impArbaTxtins
ON impArbaTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO impArbaTxt_log(
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
GETDATE(),
'ins'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impArbaTxtdel
GO

 CREATE TRIGGER impArbaTxtdel
ON impArbaTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO impArbaTxt_log(
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
GETDATE(),
'del'
FROM deleted where CUIT=deleted.CUIT)
 END
GO

 DROP TRIGGER impArbaTxtupd
GO

 CREATE TRIGGER impArbaTxtupd
ON impArbaTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impArbaTxt_log(
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
Regimen,
FechaVigDesde,
FechaVigHasta,
Alicuota,
Grupo,
GETDATE(),
'upd'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impCfdiMetaDatosins
GO

 CREATE TRIGGER impCfdiMetaDatosins
ON impCfdiMetaDatos
AFTER INSERT
AS
 BEGIN
INSERT INTO impCfdiMetaDatos_log(
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
GETDATE(),
'ins'
FROM inserted where Uuid=inserted.Uuid)
 END
GO

 DROP TRIGGER impCfdiMetaDatosdel
GO

 CREATE TRIGGER impCfdiMetaDatosdel
ON impCfdiMetaDatos
AFTER DELETE
AS
 BEGIN
INSERT INTO impCfdiMetaDatos_log(
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
GETDATE(),
'del'
FROM deleted where Uuid=deleted.Uuid)
 END
GO

 DROP TRIGGER impCfdiMetaDatosupd
GO

 CREATE TRIGGER impCfdiMetaDatosupd
ON impCfdiMetaDatos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impCfdiMetaDatos_log(
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Uuid,
RfcEmisor,
NombreEmisor,
RfcReceptor,
NombreReceptor,
RfcPac,
FechaEmision,
FechaCertificacionSat,
Monto,
EfectoComprobante,
Estatus,
FechaCancelacion,
FechaDescarga,
Usuario_Id,
Empresa_Id,
GETDATE(),
'upd'
FROM inserted where Uuid=inserted.Uuid)
 END
GO

 DROP TRIGGER impFormulasins
GO

 CREATE TRIGGER impFormulasins
ON impFormulas
AFTER INSERT
AS
 BEGIN
INSERT INTO impFormulas_log(
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
GETDATE(),
'ins'
FROM inserted where impImpuestos=inserted.impImpuestos)
 END
GO

 DROP TRIGGER impFormulasdel
GO

 CREATE TRIGGER impFormulasdel
ON impFormulas
AFTER DELETE
AS
 BEGIN
INSERT INTO impFormulas_log(
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
GETDATE(),
'del'
FROM deleted where impImpuestos=deleted.impImpuestos)
 END
GO

 DROP TRIGGER impFormulasupd
GO

 CREATE TRIGGER impFormulasupd
ON impFormulas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impFormulas_log(
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Renglon,
Cuenta_Id,
Detalle,
DebeHaberAmbos,
GETDATE(),
'upd'
FROM inserted where impImpuestos=inserted.impImpuestos)
 END
GO

 DROP TRIGGER impImpuestosins
GO

 CREATE TRIGGER impImpuestosins
ON impImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO impImpuestos_log(
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
GETDATE(),
'ins'
FROM inserted where impImpuestos=inserted.impImpuestos)
 END
GO

 DROP TRIGGER impImpuestosdel
GO

 CREATE TRIGGER impImpuestosdel
ON impImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO impImpuestos_log(
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
GETDATE(),
'del'
FROM deleted where impImpuestos=deleted.impImpuestos)
 END
GO

 DROP TRIGGER impImpuestosupd
GO

 CREATE TRIGGER impImpuestosupd
ON impImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impImpuestos_log(
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
FechaModifLog,
TipoModificacion
)
(Select 
impImpuestos,
Impuesto_Id,
Descripcion,
Empresa_Id,
Posteado,
Inactivo,
TipoVencimiento,
DiaMesVence,
AvisarNDias,
ProximoVencimiento,
CtaHaber_Id,
CtaDebe_Id,
PagoAnticipado,
SePaga,
VaAlCashFlow,
LiquidadoHasta,
GETDATE(),
'upd'
FROM inserted where impImpuestos=inserted.impImpuestos)
 END
GO

 DROP TRIGGER impJurisdiccionesins
GO

 CREATE TRIGGER impJurisdiccionesins
ON impJurisdicciones
AFTER INSERT
AS
 BEGIN
INSERT INTO impJurisdicciones_log(
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where impJurisdicciones=inserted.impJurisdicciones)
 END
GO

 DROP TRIGGER impJurisdiccionesdel
GO

 CREATE TRIGGER impJurisdiccionesdel
ON impJurisdicciones
AFTER DELETE
AS
 BEGIN
INSERT INTO impJurisdicciones_log(
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where impJurisdicciones=deleted.impJurisdicciones)
 END
GO

 DROP TRIGGER impJurisdiccionesupd
GO

 CREATE TRIGGER impJurisdiccionesupd
ON impJurisdicciones
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impJurisdicciones_log(
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
impJurisdicciones,
Juris_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where impJurisdicciones=inserted.impJurisdicciones)
 END
GO

 DROP TRIGGER impLibrosTiposRenglonins
GO

 CREATE TRIGGER impLibrosTiposRenglonins
ON impLibrosTiposRenglon
AFTER INSERT
AS
 BEGIN
INSERT INTO impLibrosTiposRenglon_log(
TipoRenglon,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoRenglon,
Descripcion,
GETDATE(),
'ins'
FROM inserted where TipoRenglon=inserted.TipoRenglon)
 END
GO

 DROP TRIGGER impLibrosTiposRenglondel
GO

 CREATE TRIGGER impLibrosTiposRenglondel
ON impLibrosTiposRenglon
AFTER DELETE
AS
 BEGIN
INSERT INTO impLibrosTiposRenglon_log(
TipoRenglon,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoRenglon,
Descripcion,
GETDATE(),
'del'
FROM deleted where TipoRenglon=deleted.TipoRenglon)
 END
GO

 DROP TRIGGER impLibrosTiposRenglonupd
GO

 CREATE TRIGGER impLibrosTiposRenglonupd
ON impLibrosTiposRenglon
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impLibrosTiposRenglon_log(
TipoRenglon,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
TipoRenglon,
Descripcion,
GETDATE(),
'upd'
FROM inserted where TipoRenglon=inserted.TipoRenglon)
 END
GO

 DROP TRIGGER impLiquidacionins
GO

 CREATE TRIGGER impLiquidacionins
ON impLiquidacion
AFTER INSERT
AS
 BEGIN
INSERT INTO impLiquidacion_log(
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
GETDATE(),
'ins'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER impLiquidaciondel
GO

 CREATE TRIGGER impLiquidaciondel
ON impLiquidacion
AFTER DELETE
AS
 BEGIN
INSERT INTO impLiquidacion_log(
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
GETDATE(),
'del'
FROM deleted where conAsientos=deleted.conAsientos)
 END
GO

 DROP TRIGGER impLiquidacionupd
GO

 CREATE TRIGGER impLiquidacionupd
ON impLiquidacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impLiquidacion_log(
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
conAsientos,
Impuesto_Id,
FechaDesde,
FechaHasta,
FechaPago,
TotalAPagar,
Saldo,
SePaga,
tesMovimientos,
GETDATE(),
'upd'
FROM inserted where conAsientos=inserted.conAsientos)
 END
GO

 DROP TRIGGER impPadronins
GO

 CREATE TRIGGER impPadronins
ON impPadron
AFTER INSERT
AS
 BEGIN
INSERT INTO impPadron_log(
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where impPadron=inserted.impPadron)
 END
GO

 DROP TRIGGER impPadrondel
GO

 CREATE TRIGGER impPadrondel
ON impPadron
AFTER DELETE
AS
 BEGIN
INSERT INTO impPadron_log(
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where impPadron=deleted.impPadron)
 END
GO

 DROP TRIGGER impPadronupd
GO

 CREATE TRIGGER impPadronupd
ON impPadron
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impPadron_log(
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
impPadron,
Padron_Id,
Descripcion,
Empresa_Id,
Tabla,
Periodo,
ColCuit,
ColAnio,
ColPeriodo,
ColBusqueda,
ColBusquedaValor,
ColDevolucion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where impPadron=inserted.impPadron)
 END
GO

 DROP TRIGGER impRentasCapExentosTxtins
GO

 CREATE TRIGGER impRentasCapExentosTxtins
ON impRentasCapExentosTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO impRentasCapExentosTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'ins'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapExentosTxtdel
GO

 CREATE TRIGGER impRentasCapExentosTxtdel
ON impRentasCapExentosTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO impRentasCapExentosTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'del'
FROM deleted where CUIT=deleted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapExentosTxtupd
GO

 CREATE TRIGGER impRentasCapExentosTxtupd
ON impRentasCapExentosTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRentasCapExentosTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'upd'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapGralTxtins
GO

 CREATE TRIGGER impRentasCapGralTxtins
ON impRentasCapGralTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO impRentasCapGralTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'ins'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapGralTxtdel
GO

 CREATE TRIGGER impRentasCapGralTxtdel
ON impRentasCapGralTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO impRentasCapGralTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'del'
FROM deleted where CUIT=deleted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapGralTxtupd
GO

 CREATE TRIGGER impRentasCapGralTxtupd
ON impRentasCapGralTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRentasCapGralTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
Tipo,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'upd'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapMagSupTxtins
GO

 CREATE TRIGGER impRentasCapMagSupTxtins
ON impRentasCapMagSupTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO impRentasCapMagSupTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'ins'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapMagSupTxtdel
GO

 CREATE TRIGGER impRentasCapMagSupTxtdel
ON impRentasCapMagSupTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO impRentasCapMagSupTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'del'
FROM deleted where CUIT=deleted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapMagSupTxtupd
GO

 CREATE TRIGGER impRentasCapMagSupTxtupd
ON impRentasCapMagSupTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRentasCapMagSupTxt_log(
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Mes,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'upd'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapRiesgoTxtins
GO

 CREATE TRIGGER impRentasCapRiesgoTxtins
ON impRentasCapRiesgoTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO impRentasCapRiesgoTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'ins'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapRiesgoTxtdel
GO

 CREATE TRIGGER impRentasCapRiesgoTxtdel
ON impRentasCapRiesgoTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO impRentasCapRiesgoTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'del'
FROM deleted where CUIT=deleted.CUIT)
 END
GO

 DROP TRIGGER impRentasCapRiesgoTxtupd
GO

 CREATE TRIGGER impRentasCapRiesgoTxtupd
ON impRentasCapRiesgoTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRentasCapRiesgoTxt_log(
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
FechaModifLog,
TipoModificacion
)
(Select 
CUIT,
Anio,
Trimestre,
FechaVigDesde,
FechaVigHasta,
AlicuotaPer,
AlicuotaRet,
GrupoPer,
GrupoRet,
GETDATE(),
'upd'
FROM inserted where CUIT=inserted.CUIT)
 END
GO

 DROP TRIGGER impRetCFDIArrendains
GO

 CREATE TRIGGER impRetCFDIArrendains
ON impRetCFDIArrenda
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIArrenda_log(
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIArrendadel
GO

 CREATE TRIGGER impRetCFDIArrendadel
ON impRetCFDIArrenda
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIArrenda_log(
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIArrendaupd
GO

 CREATE TRIGGER impRetCFDIArrendaupd
ON impRetCFDIArrenda
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIArrenda_log(
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
PagProvEfecPorFiduc,
RendimFideicom,
DeduccCorresp,
MontTotRet,
MontResFiscDistFibras,
MontOtrosConceptDistr,
DescrMontOtrosConceptDistr,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDetalleins
GO

 CREATE TRIGGER impRetCFDIDetalleins
ON impRetCFDIDetalle
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIDetalle_log(
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDetalledel
GO

 CREATE TRIGGER impRetCFDIDetalledel
ON impRetCFDIDetalle
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIDetalle_log(
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDetalleupd
GO

 CREATE TRIGGER impRetCFDIDetalleupd
ON impRetCFDIDetalle
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIDetalle_log(
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Renglon,
BaseRet,
TipoImpuesto,
montoRet,
TipoPagoRet,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDividendosins
GO

 CREATE TRIGGER impRetCFDIDividendosins
ON impRetCFDIDividendos
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIDividendos_log(
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDividendosdel
GO

 CREATE TRIGGER impRetCFDIDividendosdel
ON impRetCFDIDividendos
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIDividendos_log(
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIDividendosupd
GO

 CREATE TRIGGER impRetCFDIDividendosupd
ON impRetCFDIDividendos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIDividendos_log(
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
CveTipDivOUtil,
MontISRAcredRetMexico,
MontISRAcredRetExtranjero,
MontRetExtDivExt,
TipoSocDistrDiv,
MontISRAcredNal,
MontDivAcumNal,
MontDivAcumExt,
ProporcionRem,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIEnajAccionins
GO

 CREATE TRIGGER impRetCFDIEnajAccionins
ON impRetCFDIEnajAccion
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIEnajAccion_log(
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIEnajAcciondel
GO

 CREATE TRIGGER impRetCFDIEnajAcciondel
ON impRetCFDIEnajAccion
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIEnajAccion_log(
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIEnajAccionupd
GO

 CREATE TRIGGER impRetCFDIEnajAccionupd
ON impRetCFDIEnajAccion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIEnajAccion_log(
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
ContratoIntermediacion,
Ganancia,
Perdida,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIFiedeEmprins
GO

 CREATE TRIGGER impRetCFDIFiedeEmprins
ON impRetCFDIFiedeEmpr
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIFiedeEmpr_log(
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIFiedeEmprdel
GO

 CREATE TRIGGER impRetCFDIFiedeEmprdel
ON impRetCFDIFiedeEmpr
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIFiedeEmpr_log(
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIFiedeEmprupd
GO

 CREATE TRIGGER impRetCFDIFiedeEmprupd
ON impRetCFDIFiedeEmpr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIFiedeEmpr_log(
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontTotEntradasPeriodo,
PartPropAcumDelFideicom,
PropDelMontTot,
Concepto,
MontTotEgresPeriodo,
PartPropDelFideicom,
PropDelMontTotE,
ConseptoS,
MontRetRelPagFideic,
DescRetRelPagFideic,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIOperConDerivins
GO

 CREATE TRIGGER impRetCFDIOperConDerivins
ON impRetCFDIOperConDeriv
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIOperConDeriv_log(
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIOperConDerivdel
GO

 CREATE TRIGGER impRetCFDIOperConDerivdel
ON impRetCFDIOperConDeriv
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIOperConDeriv_log(
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIOperConDerivupd
GO

 CREATE TRIGGER impRetCFDIOperConDerivupd
ON impRetCFDIOperConDeriv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIOperConDeriv_log(
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
MontGanAcum,
MontPerdDed,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPagosExtrins
GO

 CREATE TRIGGER impRetCFDIPagosExtrins
ON impRetCFDIPagosExtr
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIPagosExtr_log(
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPagosExtrdel
GO

 CREATE TRIGGER impRetCFDIPagosExtrdel
ON impRetCFDIPagosExtr
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIPagosExtr_log(
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPagosExtrupd
GO

 CREATE TRIGGER impRetCFDIPagosExtrupd
ON impRetCFDIPagosExtr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIPagosExtr_log(
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
EsBenefEfectDelCobro,
Pais_Id,
ConceptoPago,
DescripcionConcepto,
BeneRFC,
BeneCURP,
NomDenRazSocB,
BeneConceptoPago,
BeneDescripcionConcepto,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPlanesRetins
GO

 CREATE TRIGGER impRetCFDIPlanesRetins
ON impRetCFDIPlanesRet
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIPlanesRet_log(
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPlanesRetdel
GO

 CREATE TRIGGER impRetCFDIPlanesRetdel
ON impRetCFDIPlanesRet
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIPlanesRet_log(
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPlanesRetupd
GO

 CREATE TRIGGER impRetCFDIPlanesRetupd
ON impRetCFDIPlanesRet
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIPlanesRet_log(
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
SistemaFinanc,
MontTotAportAnioInmAnterior,
MontIntRealesDevengAniooInmAnt,
HuboRetirosAnioInmAntPer,
MontTotRetiradoAnioInmAntPer,
MontTotExentRetiradoAnioInmAnt,
MontTotExedenteAnioInmAnt,
HuboRetirosAnioInmAnt,
MontTotRetiradoAnioInmAnt,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPremiosins
GO

 CREATE TRIGGER impRetCFDIPremiosins
ON impRetCFDIPremios
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDIPremios_log(
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPremiosdel
GO

 CREATE TRIGGER impRetCFDIPremiosdel
ON impRetCFDIPremios
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDIPremios_log(
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDIPremiosupd
GO

 CREATE TRIGGER impRetCFDIPremiosupd
ON impRetCFDIPremios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDIPremios_log(
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Provincia_Id,
MontTotPago,
MontTotPagoGrav,
MontTotPagoExent,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDISecFinanins
GO

 CREATE TRIGGER impRetCFDISecFinanins
ON impRetCFDISecFinan
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetCFDISecFinan_log(
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDISecFinandel
GO

 CREATE TRIGGER impRetCFDISecFinandel
ON impRetCFDISecFinan
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetCFDISecFinan_log(
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetCFDISecFinanupd
GO

 CREATE TRIGGER impRetCFDISecFinanupd
ON impRetCFDISecFinan
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetCFDISecFinan_log(
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
IdFideicom,
NomFideicom,
DescripFideicom,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetencionesCFDIins
GO

 CREATE TRIGGER impRetencionesCFDIins
ON impRetencionesCFDI
AFTER INSERT
AS
 BEGIN
INSERT INTO impRetencionesCFDI_log(
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
GETDATE(),
'ins'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetencionesCFDIdel
GO

 CREATE TRIGGER impRetencionesCFDIdel
ON impRetencionesCFDI
AFTER DELETE
AS
 BEGIN
INSERT INTO impRetencionesCFDI_log(
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
GETDATE(),
'del'
FROM deleted where impRetencionesCFDI=deleted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impRetencionesCFDIupd
GO

 CREATE TRIGGER impRetencionesCFDIupd
ON impRetencionesCFDI
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impRetencionesCFDI_log(
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
FechaModifLog,
TipoModificacion
)
(Select 
impRetencionesCFDI,
Empresa_Id,
Folio,
Sello,
NumCert,
FechaExp,
CveRetenc,
DescRetenc,
Nacionalidad,
RFC,
RazonSocial,
CURP,
NroRegIdTrib,
Ejercicio,
MesIni,
MesFin,
montoTotOperacion,
montoTotGrav,
montoTotExent,
montoTotRet,
Cancelado,
FechaCancelacion,
FechaTimbre,
SelloSAT,
NoCertificadoSAT,
UUID,
RfcProvCertif,
Leyenda,
Usuario_Id,
FechaRegistro,
Xml,
GETDATE(),
'upd'
FROM inserted where impRetencionesCFDI=inserted.impRetencionesCFDI)
 END
GO

 DROP TRIGGER impTipoImpuestoins
GO

 CREATE TRIGGER impTipoImpuestoins
ON impTipoImpuesto
AFTER INSERT
AS
 BEGIN
INSERT INTO impTipoImpuesto_log(
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
GETDATE(),
'ins'
FROM inserted where TipoImpuesto=inserted.TipoImpuesto)
 END
GO

 DROP TRIGGER impTipoImpuestodel
GO

 CREATE TRIGGER impTipoImpuestodel
ON impTipoImpuesto
AFTER DELETE
AS
 BEGIN
INSERT INTO impTipoImpuesto_log(
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
GETDATE(),
'del'
FROM deleted where TipoImpuesto=deleted.TipoImpuesto)
 END
GO

 DROP TRIGGER impTipoImpuestoupd
GO

 CREATE TRIGGER impTipoImpuestoupd
ON impTipoImpuesto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO impTipoImpuesto_log(
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoImpuesto,
Descripcion,
CodigoFiscal,
Juris_Id,
Referencia01,
Referencia02,
Referencia03,
Referencia04,
Referencia05,
Referencia06,
Referencia07,
Referencia08,
Referencia09,
Referencia10,
Dominio_Id,
GETDATE(),
'upd'
FROM inserted where TipoImpuesto=inserted.TipoImpuesto)
 END
GO

 DROP TRIGGER lupIdentidadesins
GO

 CREATE TRIGGER lupIdentidadesins
ON lupIdentidades
AFTER INSERT
AS
 BEGIN
INSERT INTO lupIdentidades_log(
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
FechaModifLog,
TipoModificacion
)
(Select 
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
GETDATE(),
'ins'
FROM inserted where lupIdentidades=inserted.lupIdentidades)
 END
GO

 DROP TRIGGER lupIdentidadesdel
GO

 CREATE TRIGGER lupIdentidadesdel
ON lupIdentidades
AFTER DELETE
AS
 BEGIN
INSERT INTO lupIdentidades_log(
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
FechaModifLog,
TipoModificacion
)
(Select 
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
GETDATE(),
'del'
FROM deleted where lupIdentidades=deleted.lupIdentidades)
 END
GO

 DROP TRIGGER lupIdentidadesupd
GO

 CREATE TRIGGER lupIdentidadesupd
ON lupIdentidades
AFTER  UPDATE
AS
 BEGIN
INSERT INTO lupIdentidades_log(
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
FechaModifLog,
TipoModificacion
)
(Select 
lupIdentidades,
Identidad_Id,
Descripcion,
CamposSelect,
FromSelect,
WhereSelect,
OrderByDefault,
CamposClaves,
CampoDescripcion,
CampoFKTablaSeg,
VistaSeg,
CampoPKVistaSeg,
OrdenMenuFormulario,
GETDATE(),
'upd'
FROM inserted where lupIdentidades=inserted.lupIdentidades)
 END
GO

 DROP TRIGGER lupIdentidadesColVisiblesins
GO

 CREATE TRIGGER lupIdentidadesColVisiblesins
ON lupIdentidadesColVisibles
AFTER INSERT
AS
 BEGIN
INSERT INTO lupIdentidadesColVisibles_log(
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
GETDATE(),
'ins'
FROM inserted where Identidad_Id=inserted.Identidad_Id)
 END
GO

 DROP TRIGGER lupIdentidadesColVisiblesdel
GO

 CREATE TRIGGER lupIdentidadesColVisiblesdel
ON lupIdentidadesColVisibles
AFTER DELETE
AS
 BEGIN
INSERT INTO lupIdentidadesColVisibles_log(
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
GETDATE(),
'del'
FROM deleted where Identidad_Id=deleted.Identidad_Id)
 END
GO

 DROP TRIGGER lupIdentidadesColVisiblesupd
GO

 CREATE TRIGGER lupIdentidadesColVisiblesupd
ON lupIdentidadesColVisibles
AFTER  UPDATE
AS
 BEGIN
INSERT INTO lupIdentidadesColVisibles_log(
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Campo,
Longitud,
CondicionInicial,
GETDATE(),
'upd'
FROM inserted where Identidad_Id=inserted.Identidad_Id)
 END
GO

 DROP TRIGGER lupIdentidadesParamins
GO

 CREATE TRIGGER lupIdentidadesParamins
ON lupIdentidadesParam
AFTER INSERT
AS
 BEGIN
INSERT INTO lupIdentidadesParam_log(
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
GETDATE(),
'ins'
FROM inserted where Identidad_Id=inserted.Identidad_Id)
 END
GO

 DROP TRIGGER lupIdentidadesParamdel
GO

 CREATE TRIGGER lupIdentidadesParamdel
ON lupIdentidadesParam
AFTER DELETE
AS
 BEGIN
INSERT INTO lupIdentidadesParam_log(
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
GETDATE(),
'del'
FROM deleted where Identidad_Id=deleted.Identidad_Id)
 END
GO

 DROP TRIGGER lupIdentidadesParamupd
GO

 CREATE TRIGGER lupIdentidadesParamupd
ON lupIdentidadesParam
AFTER  UPDATE
AS
 BEGIN
INSERT INTO lupIdentidadesParam_log(
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
FechaModifLog,
TipoModificacion
)
(Select 
Identidad_Id,
Orden,
NombreParametro,
TipoParametro,
GETDATE(),
'upd'
FROM inserted where Identidad_Id=inserted.Identidad_Id)
 END
GO

 DROP TRIGGER lupUltConfigFiltrosIdentidadUsuarioins
GO

 CREATE TRIGGER lupUltConfigFiltrosIdentidadUsuarioins
ON lupUltConfigFiltrosIdentidadUsuario
AFTER INSERT
AS
 BEGIN
INSERT INTO lupUltConfigFiltrosIdentidadUsuario_log(
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER lupUltConfigFiltrosIdentidadUsuariodel
GO

 CREATE TRIGGER lupUltConfigFiltrosIdentidadUsuariodel
ON lupUltConfigFiltrosIdentidadUsuario
AFTER DELETE
AS
 BEGIN
INSERT INTO lupUltConfigFiltrosIdentidadUsuario_log(
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER lupUltConfigFiltrosIdentidadUsuarioupd
GO

 CREATE TRIGGER lupUltConfigFiltrosIdentidadUsuarioupd
ON lupUltConfigFiltrosIdentidadUsuario
AFTER  UPDATE
AS
 BEGIN
INSERT INTO lupUltConfigFiltrosIdentidadUsuario_log(
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
Identidad_Id,
Campo,
Operardor,
Valor,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER proCausasins
GO

 CREATE TRIGGER proCausasins
ON proCausas
AFTER INSERT
AS
 BEGIN
INSERT INTO proCausas_log(
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where proCausas=inserted.proCausas)
 END
GO

 DROP TRIGGER proCausasdel
GO

 CREATE TRIGGER proCausasdel
ON proCausas
AFTER DELETE
AS
 BEGIN
INSERT INTO proCausas_log(
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where proCausas=deleted.proCausas)
 END
GO

 DROP TRIGGER proCausasupd
GO

 CREATE TRIGGER proCausasupd
ON proCausas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proCausas_log(
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proCausas,
Causa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where proCausas=inserted.proCausas)
 END
GO

 DROP TRIGGER proCentroProductivoins
GO

 CREATE TRIGGER proCentroProductivoins
ON proCentroProductivo
AFTER INSERT
AS
 BEGIN
INSERT INTO proCentroProductivo_log(
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
FechaModifLog,
TipoModificacion
)
(Select 
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
GETDATE(),
'ins'
FROM inserted where proCentroProductivo=inserted.proCentroProductivo)
 END
GO

 DROP TRIGGER proCentroProductivodel
GO

 CREATE TRIGGER proCentroProductivodel
ON proCentroProductivo
AFTER DELETE
AS
 BEGIN
INSERT INTO proCentroProductivo_log(
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
FechaModifLog,
TipoModificacion
)
(Select 
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
GETDATE(),
'del'
FROM deleted where proCentroProductivo=deleted.proCentroProductivo)
 END
GO

 DROP TRIGGER proCentroProductivoupd
GO

 CREATE TRIGGER proCentroProductivoupd
ON proCentroProductivo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proCentroProductivo_log(
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
FechaModifLog,
TipoModificacion
)
(Select 
proCentroProductivo,
CtroProd_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Inactivo,
Posteado,
Usuario_Id,
CtaProdProceso,
GETDATE(),
'upd'
FROM inserted where proCentroProductivo=inserted.proCentroProductivo)
 END
GO

 DROP TRIGGER proMovCierreOrdenins
GO

 CREATE TRIGGER proMovCierreOrdenins
ON proMovCierreOrden
AFTER INSERT
AS
 BEGIN
INSERT INTO proMovCierreOrden_log(
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
GETDATE(),
'ins'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreOrdendel
GO

 CREATE TRIGGER proMovCierreOrdendel
ON proMovCierreOrden
AFTER DELETE
AS
 BEGIN
INSERT INTO proMovCierreOrden_log(
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
GETDATE(),
'del'
FROM deleted where proMovCierreOrden=deleted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreOrdenupd
GO

 CREATE TRIGGER proMovCierreOrdenupd
ON proMovCierreOrden
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proMovCierreOrden_log(
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
proOrden,
Cantidad,
Parcial,
Causa_Id,
GETDATE(),
'upd'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreRecursosins
GO

 CREATE TRIGGER proMovCierreRecursosins
ON proMovCierreRecursos
AFTER INSERT
AS
 BEGIN
INSERT INTO proMovCierreRecursos_log(
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
GETDATE(),
'ins'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreRecursosdel
GO

 CREATE TRIGGER proMovCierreRecursosdel
ON proMovCierreRecursos
AFTER DELETE
AS
 BEGIN
INSERT INTO proMovCierreRecursos_log(
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
GETDATE(),
'del'
FROM deleted where proMovCierreOrden=deleted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreRecursosupd
GO

 CREATE TRIGGER proMovCierreRecursosupd
ON proMovCierreRecursos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proMovCierreRecursos_log(
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Recurso_Id,
SubRecurso_Id,
Cantidad,
Costo,
GETDATE(),
'upd'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreTrabajos3ins
GO

 CREATE TRIGGER proMovCierreTrabajos3ins
ON proMovCierreTrabajos3
AFTER INSERT
AS
 BEGIN
INSERT INTO proMovCierreTrabajos3_log(
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
GETDATE(),
'ins'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreTrabajos3del
GO

 CREATE TRIGGER proMovCierreTrabajos3del
ON proMovCierreTrabajos3
AFTER DELETE
AS
 BEGIN
INSERT INTO proMovCierreTrabajos3_log(
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
GETDATE(),
'del'
FROM deleted where proMovCierreOrden=deleted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proMovCierreTrabajos3upd
GO

 CREATE TRIGGER proMovCierreTrabajos3upd
ON proMovCierreTrabajos3
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proMovCierreTrabajos3_log(
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
Renglon,
Trabajo3_Id,
Cantidad,
Moneda_Id,
Proveed_Id,
Precio,
PrecioOriginal,
GETDATE(),
'upd'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenins
GO

 CREATE TRIGGER proOrdenins
ON proOrden
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrden_log(
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdendel
GO

 CREATE TRIGGER proOrdendel
ON proOrden
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrden_log(
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where proOrden=deleted.proOrden)
 END
GO

 DROP TRIGGER proOrdenupd
GO

 CREATE TRIGGER proOrdenupd
ON proOrden
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrden_log(
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Producto_Id,
TamBatch,
Receta_Id,
Observaciones,
Anulado,
Cantidad,
CantidadIngresada,
FechaEmision,
CantidadProgramada,
FechaNecesidad,
FechaProduccion,
FechaFin,
CantidadTerminada,
CierreAutomatico,
Medida_Id,
Factor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenProdins
GO

 CREATE TRIGGER proOrdenProdins
ON proOrdenProd
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenProd_log(
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
GETDATE(),
'ins'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenProddel
GO

 CREATE TRIGGER proOrdenProddel
ON proOrdenProd
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenProd_log(
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
GETDATE(),
'del'
FROM deleted where proOrden=deleted.proOrden)
 END
GO

 DROP TRIGGER proOrdenProdupd
GO

 CREATE TRIGGER proOrdenProdupd
ON proOrdenProd
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenProd_log(
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Cantidad,
PorcentajeCosto,
Deposito_Id,
TomaDepoT3,
GETDATE(),
'upd'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenRecursosins
GO

 CREATE TRIGGER proOrdenRecursosins
ON proOrdenRecursos
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenRecursos_log(
proOrden,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenRecursosdel
GO

 CREATE TRIGGER proOrdenRecursosdel
ON proOrdenRecursos
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenRecursos_log(
proOrden,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where proOrden=deleted.proOrden)
 END
GO

 DROP TRIGGER proOrdenRecursosupd
GO

 CREATE TRIGGER proOrdenRecursosupd
ON proOrdenRecursos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenRecursos_log(
proOrden,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenSegmentoins
GO

 CREATE TRIGGER proOrdenSegmentoins
ON proOrdenSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
GETDATE(),
'ins'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER proOrdenSegmentodel
GO

 CREATE TRIGGER proOrdenSegmentodel
ON proOrdenSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
GETDATE(),
'del'
FROM deleted where Segmento_Id=deleted.Segmento_Id)
 END
GO

 DROP TRIGGER proOrdenSegmentoupd
GO

 CREATE TRIGGER proOrdenSegmentoupd
ON proOrdenSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proOrden,
GETDATE(),
'upd'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER proOrdenStockins
GO

 CREATE TRIGGER proOrdenStockins
ON proOrdenStock
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenStock_log(
proMovCierreOrden,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
GETDATE(),
'ins'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenStockdel
GO

 CREATE TRIGGER proOrdenStockdel
ON proOrdenStock
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenStock_log(
proMovCierreOrden,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
GETDATE(),
'del'
FROM deleted where proMovCierreOrden=deleted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenStockupd
GO

 CREATE TRIGGER proOrdenStockupd
ON proOrdenStock
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenStock_log(
proMovCierreOrden,
stkMoviCabe,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
GETDATE(),
'upd'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenStockCostoins
GO

 CREATE TRIGGER proOrdenStockCostoins
ON proOrdenStockCosto
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenStockCosto_log(
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
GETDATE(),
'ins'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenStockCostodel
GO

 CREATE TRIGGER proOrdenStockCostodel
ON proOrdenStockCosto
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenStockCosto_log(
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
GETDATE(),
'del'
FROM deleted where proMovCierreOrden=deleted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenStockCostoupd
GO

 CREATE TRIGGER proOrdenStockCostoupd
ON proOrdenStockCosto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenStockCosto_log(
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
FechaModifLog,
TipoModificacion
)
(Select 
proMovCierreOrden,
stkMoviCabe,
Renglon,
PorcentajeCosto,
GETDATE(),
'upd'
FROM inserted where proMovCierreOrden=inserted.proMovCierreOrden)
 END
GO

 DROP TRIGGER proOrdenSubRecursoins
GO

 CREATE TRIGGER proOrdenSubRecursoins
ON proOrdenSubRecurso
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenSubRecurso_log(
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenSubRecursodel
GO

 CREATE TRIGGER proOrdenSubRecursodel
ON proOrdenSubRecurso
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenSubRecurso_log(
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where proOrden=deleted.proOrden)
 END
GO

 DROP TRIGGER proOrdenSubRecursoupd
GO

 CREATE TRIGGER proOrdenSubRecursoupd
ON proOrdenSubRecurso
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenSubRecurso_log(
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
SubRecurso_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenTrabajos3ins
GO

 CREATE TRIGGER proOrdenTrabajos3ins
ON proOrdenTrabajos3
AFTER INSERT
AS
 BEGIN
INSERT INTO proOrdenTrabajos3_log(
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
GETDATE(),
'ins'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proOrdenTrabajos3del
GO

 CREATE TRIGGER proOrdenTrabajos3del
ON proOrdenTrabajos3
AFTER DELETE
AS
 BEGIN
INSERT INTO proOrdenTrabajos3_log(
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
GETDATE(),
'del'
FROM deleted where proOrden=deleted.proOrden)
 END
GO

 DROP TRIGGER proOrdenTrabajos3upd
GO

 CREATE TRIGGER proOrdenTrabajos3upd
ON proOrdenTrabajos3
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proOrdenTrabajos3_log(
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proOrden,
Renglon,
proTrabajo3,
Proveed_Id,
GETDATE(),
'upd'
FROM inserted where proOrden=inserted.proOrden)
 END
GO

 DROP TRIGGER proProductosRecetains
GO

 CREATE TRIGGER proProductosRecetains
ON proProductosReceta
AFTER INSERT
AS
 BEGIN
INSERT INTO proProductosReceta_log(
Producto_Id,
Receta_Id,
Principal,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Receta_Id,
Principal,
GETDATE(),
'ins'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER proProductosRecetadel
GO

 CREATE TRIGGER proProductosRecetadel
ON proProductosReceta
AFTER DELETE
AS
 BEGIN
INSERT INTO proProductosReceta_log(
Producto_Id,
Receta_Id,
Principal,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Receta_Id,
Principal,
GETDATE(),
'del'
FROM deleted where Producto_Id=deleted.Producto_Id)
 END
GO

 DROP TRIGGER proProductosRecetaupd
GO

 CREATE TRIGGER proProductosRecetaupd
ON proProductosReceta
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proProductosReceta_log(
Producto_Id,
Receta_Id,
Principal,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Receta_Id,
Principal,
GETDATE(),
'upd'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER proProgramaOrdenins
GO

 CREATE TRIGGER proProgramaOrdenins
ON proProgramaOrden
AFTER INSERT
AS
 BEGIN
INSERT INTO proProgramaOrden_log(
proProgramas,
Renglon,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
proOrden,
GETDATE(),
'ins'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramaOrdendel
GO

 CREATE TRIGGER proProgramaOrdendel
ON proProgramaOrden
AFTER DELETE
AS
 BEGIN
INSERT INTO proProgramaOrden_log(
proProgramas,
Renglon,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
proOrden,
GETDATE(),
'del'
FROM deleted where proProgramas=deleted.proProgramas)
 END
GO

 DROP TRIGGER proProgramaOrdenupd
GO

 CREATE TRIGGER proProgramaOrdenupd
ON proProgramaOrden
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proProgramaOrden_log(
proProgramas,
Renglon,
proOrden,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
proOrden,
GETDATE(),
'upd'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasins
GO

 CREATE TRIGGER proProgramasins
ON proProgramas
AFTER INSERT
AS
 BEGIN
INSERT INTO proProgramas_log(
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasdel
GO

 CREATE TRIGGER proProgramasdel
ON proProgramas
AFTER DELETE
AS
 BEGIN
INSERT INTO proProgramas_log(
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where proProgramas=deleted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasupd
GO

 CREATE TRIGGER proProgramasupd
ON proProgramas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proProgramas_log(
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Descripcion,
Empresa_Id,
Fecha,
FechaDesde,
FechaHasta,
Deposito_Id,
ProductoDesde,
ProductoHasta,
Lunes,
Martes,
Miercoles,
Jueves,
Viernes,
Sabado,
Domingo,
GrupoDesde,
GrupoHasta,
FamiliaDesde,
FamiliaHasta,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasCuerpoins
GO

 CREATE TRIGGER proProgramasCuerpoins
ON proProgramasCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO proProgramasCuerpo_log(
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
GETDATE(),
'ins'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasCuerpodel
GO

 CREATE TRIGGER proProgramasCuerpodel
ON proProgramasCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO proProgramasCuerpo_log(
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
GETDATE(),
'del'
FROM deleted where proProgramas=deleted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasCuerpoupd
GO

 CREATE TRIGGER proProgramasCuerpoupd
ON proProgramasCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proProgramasCuerpo_log(
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proProgramas,
Renglon,
Producto_Id,
Cantidad,
Observaciones,
FechaNecesidad,
Confirmado,
Receta_Id,
GETDATE(),
'upd'
FROM inserted where proProgramas=inserted.proProgramas)
 END
GO

 DROP TRIGGER proProgramasSegmentoins
GO

 CREATE TRIGGER proProgramasSegmentoins
ON proProgramasSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO proProgramasSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
GETDATE(),
'ins'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER proProgramasSegmentodel
GO

 CREATE TRIGGER proProgramasSegmentodel
ON proProgramasSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO proProgramasSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
GETDATE(),
'del'
FROM deleted where Segmento_Id=deleted.Segmento_Id)
 END
GO

 DROP TRIGGER proProgramasSegmentoupd
GO

 CREATE TRIGGER proProgramasSegmentoupd
ON proProgramasSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proProgramasSegmento_log(
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Empresa_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
proProgramas,
GETDATE(),
'upd'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER proRecetasins
GO

 CREATE TRIGGER proRecetasins
ON proRecetas
AFTER INSERT
AS
 BEGIN
INSERT INTO proRecetas_log(
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
GETDATE(),
'ins'
FROM inserted where proRecetas=inserted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasdel
GO

 CREATE TRIGGER proRecetasdel
ON proRecetas
AFTER DELETE
AS
 BEGIN
INSERT INTO proRecetas_log(
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
GETDATE(),
'del'
FROM deleted where proRecetas=deleted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasupd
GO

 CREATE TRIGGER proRecetasupd
ON proRecetas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proRecetas_log(
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Receta_Id,
Empresa_Id,
Descripcion,
CtroProd_Id,
TamBatch,
Agrupa,
Corte,
Inactivo,
Posteado,
Usuario_Id,
FechaModificacion,
GETDATE(),
'upd'
FROM inserted where proRecetas=inserted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasProdins
GO

 CREATE TRIGGER proRecetasProdins
ON proRecetasProd
AFTER INSERT
AS
 BEGIN
INSERT INTO proRecetasProd_log(
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
GETDATE(),
'ins'
FROM inserted where Receta_Id=inserted.Receta_Id)
 END
GO

 DROP TRIGGER proRecetasProddel
GO

 CREATE TRIGGER proRecetasProddel
ON proRecetasProd
AFTER DELETE
AS
 BEGIN
INSERT INTO proRecetasProd_log(
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
GETDATE(),
'del'
FROM deleted where Receta_Id=deleted.Receta_Id)
 END
GO

 DROP TRIGGER proRecetasProdupd
GO

 CREATE TRIGGER proRecetasProdupd
ON proRecetasProd
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proRecetasProd_log(
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Renglon,
Producto_Id,
EntradaSalida,
Medida_Id,
Formula,
Cantidad,
PorcentajeCosto,
Deposito_Id,
Observaciones,
TomaDepoT3,
GETDATE(),
'upd'
FROM inserted where Receta_Id=inserted.Receta_Id)
 END
GO

 DROP TRIGGER proRecetasRecursosins
GO

 CREATE TRIGGER proRecetasRecursosins
ON proRecetasRecursos
AFTER INSERT
AS
 BEGIN
INSERT INTO proRecetasRecursos_log(
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where proRecetas=inserted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasRecursosdel
GO

 CREATE TRIGGER proRecetasRecursosdel
ON proRecetasRecursos
AFTER DELETE
AS
 BEGIN
INSERT INTO proRecetasRecursos_log(
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where proRecetas=deleted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasRecursosupd
GO

 CREATE TRIGGER proRecetasRecursosupd
ON proRecetasRecursos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proRecetasRecursos_log(
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
proRecetas,
Renglon,
Recurso_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where proRecetas=inserted.proRecetas)
 END
GO

 DROP TRIGGER proRecetasTrabajo3ins
GO

 CREATE TRIGGER proRecetasTrabajo3ins
ON proRecetasTrabajo3
AFTER INSERT
AS
 BEGIN
INSERT INTO proRecetasTrabajo3_log(
Receta_Id,
Trabajo3_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Trabajo3_Id,
GETDATE(),
'ins'
FROM inserted where Receta_Id=inserted.Receta_Id)
 END
GO

 DROP TRIGGER proRecetasTrabajo3del
GO

 CREATE TRIGGER proRecetasTrabajo3del
ON proRecetasTrabajo3
AFTER DELETE
AS
 BEGIN
INSERT INTO proRecetasTrabajo3_log(
Receta_Id,
Trabajo3_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Trabajo3_Id,
GETDATE(),
'del'
FROM deleted where Receta_Id=deleted.Receta_Id)
 END
GO

 DROP TRIGGER proRecetasTrabajo3upd
GO

 CREATE TRIGGER proRecetasTrabajo3upd
ON proRecetasTrabajo3
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proRecetasTrabajo3_log(
Receta_Id,
Trabajo3_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Receta_Id,
Trabajo3_Id,
GETDATE(),
'upd'
FROM inserted where Receta_Id=inserted.Receta_Id)
 END
GO

 DROP TRIGGER proRecursosins
GO

 CREATE TRIGGER proRecursosins
ON proRecursos
AFTER INSERT
AS
 BEGIN
INSERT INTO proRecursos_log(
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
GETDATE(),
'ins'
FROM inserted where proRecursos=inserted.proRecursos)
 END
GO

 DROP TRIGGER proRecursosdel
GO

 CREATE TRIGGER proRecursosdel
ON proRecursos
AFTER DELETE
AS
 BEGIN
INSERT INTO proRecursos_log(
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
GETDATE(),
'del'
FROM deleted where proRecursos=deleted.proRecursos)
 END
GO

 DROP TRIGGER proRecursosupd
GO

 CREATE TRIGGER proRecursosupd
ON proRecursos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proRecursos_log(
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proRecursos,
Recurso_Id,
Descripcion,
Empresa_Id,
Unidad_Id,
Capacidad,
Costo,
UsaSubRecurso,
Inactivo,
Posteado,
Usuario_Id,
Cuenta_Id,
GETDATE(),
'upd'
FROM inserted where proRecursos=inserted.proRecursos)
 END
GO

 DROP TRIGGER proSubRecursosins
GO

 CREATE TRIGGER proSubRecursosins
ON proSubRecursos
AFTER INSERT
AS
 BEGIN
INSERT INTO proSubRecursos_log(
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
GETDATE(),
'ins'
FROM inserted where proSubRecursos=inserted.proSubRecursos)
 END
GO

 DROP TRIGGER proSubRecursosdel
GO

 CREATE TRIGGER proSubRecursosdel
ON proSubRecursos
AFTER DELETE
AS
 BEGIN
INSERT INTO proSubRecursos_log(
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
GETDATE(),
'del'
FROM deleted where proSubRecursos=deleted.proSubRecursos)
 END
GO

 DROP TRIGGER proSubRecursosupd
GO

 CREATE TRIGGER proSubRecursosupd
ON proSubRecursos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proSubRecursos_log(
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
proSubRecursos,
SubRecurso_Id,
Recurso_Id,
Descripcion,
Capacidad,
Costo,
Predeterminado,
Inactivo,
GETDATE(),
'upd'
FROM inserted where proSubRecursos=inserted.proSubRecursos)
 END
GO

 DROP TRIGGER proTrabajo3ins
GO

 CREATE TRIGGER proTrabajo3ins
ON proTrabajo3
AFTER INSERT
AS
 BEGIN
INSERT INTO proTrabajo3_log(
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where proTrabajo3=inserted.proTrabajo3)
 END
GO

 DROP TRIGGER proTrabajo3del
GO

 CREATE TRIGGER proTrabajo3del
ON proTrabajo3
AFTER DELETE
AS
 BEGIN
INSERT INTO proTrabajo3_log(
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where proTrabajo3=deleted.proTrabajo3)
 END
GO

 DROP TRIGGER proTrabajo3upd
GO

 CREATE TRIGGER proTrabajo3upd
ON proTrabajo3
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proTrabajo3_log(
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
proTrabajo3,
Trabajo3_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where proTrabajo3=inserted.proTrabajo3)
 END
GO

 DROP TRIGGER proTrabajo3Provins
GO

 CREATE TRIGGER proTrabajo3Provins
ON proTrabajo3Prov
AFTER INSERT
AS
 BEGIN
INSERT INTO proTrabajo3Prov_log(
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
GETDATE(),
'ins'
FROM inserted where Trabajo3_Id=inserted.Trabajo3_Id)
 END
GO

 DROP TRIGGER proTrabajo3Provdel
GO

 CREATE TRIGGER proTrabajo3Provdel
ON proTrabajo3Prov
AFTER DELETE
AS
 BEGIN
INSERT INTO proTrabajo3Prov_log(
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
GETDATE(),
'del'
FROM deleted where Trabajo3_Id=deleted.Trabajo3_Id)
 END
GO

 DROP TRIGGER proTrabajo3Provupd
GO

 CREATE TRIGGER proTrabajo3Provupd
ON proTrabajo3Prov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO proTrabajo3Prov_log(
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Trabajo3_Id,
Renglon,
Proveedor_Id,
Moneda_Id,
Precio,
Medida_Id,
Cantidad,
Predeterminado,
Deposito_Id,
GETDATE(),
'upd'
FROM inserted where Trabajo3_Id=inserted.Trabajo3_Id)
 END
GO

 DROP TRIGGER provarGlobalesins
GO

 CREATE TRIGGER provarGlobalesins
ON provarGlobales
AFTER INSERT
AS
 BEGIN
INSERT INTO provarGlobales_log(
Variable_Id,
Descripcion,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Variable_Id,
Descripcion,
Valor,
GETDATE(),
'ins'
FROM inserted where Variable_Id=inserted.Variable_Id)
 END
GO

 DROP TRIGGER provarGlobalesdel
GO

 CREATE TRIGGER provarGlobalesdel
ON provarGlobales
AFTER DELETE
AS
 BEGIN
INSERT INTO provarGlobales_log(
Variable_Id,
Descripcion,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Variable_Id,
Descripcion,
Valor,
GETDATE(),
'del'
FROM deleted where Variable_Id=deleted.Variable_Id)
 END
GO

 DROP TRIGGER provarGlobalesupd
GO

 CREATE TRIGGER provarGlobalesupd
ON provarGlobales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO provarGlobales_log(
Variable_Id,
Descripcion,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Variable_Id,
Descripcion,
Valor,
GETDATE(),
'upd'
FROM inserted where Variable_Id=inserted.Variable_Id)
 END
GO

 DROP TRIGGER RomaUltimaMigracionins
GO

 CREATE TRIGGER RomaUltimaMigracionins
ON RomaUltimaMigracion
AFTER INSERT
AS
 BEGIN
INSERT INTO RomaUltimaMigracion_log(
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where FechaCompras=inserted.FechaCompras)
 END
GO

 DROP TRIGGER RomaUltimaMigraciondel
GO

 CREATE TRIGGER RomaUltimaMigraciondel
ON RomaUltimaMigracion
AFTER DELETE
AS
 BEGIN
INSERT INTO RomaUltimaMigracion_log(
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where FechaCompras=deleted.FechaCompras)
 END
GO

 DROP TRIGGER RomaUltimaMigracionupd
GO

 CREATE TRIGGER RomaUltimaMigracionupd
ON RomaUltimaMigracion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO RomaUltimaMigracion_log(
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
FechaCompras,
FechaVentasDev,
FechaTranspasos,
FechaAjustes,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where FechaCompras=inserted.FechaCompras)
 END
GO

 DROP TRIGGER RomavenDatosCliePredeterins
GO

 CREATE TRIGGER RomavenDatosCliePredeterins
ON RomavenDatosCliePredeter
AFTER INSERT
AS
 BEGIN
INSERT INTO RomavenDatosCliePredeter_log(
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
GETDATE(),
'ins'
FROM inserted where Sucursal_Id=inserted.Sucursal_Id)
 END
GO

 DROP TRIGGER RomavenDatosCliePredeterdel
GO

 CREATE TRIGGER RomavenDatosCliePredeterdel
ON RomavenDatosCliePredeter
AFTER DELETE
AS
 BEGIN
INSERT INTO RomavenDatosCliePredeter_log(
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
GETDATE(),
'del'
FROM deleted where Sucursal_Id=deleted.Sucursal_Id)
 END
GO

 DROP TRIGGER RomavenDatosCliePredeterupd
GO

 CREATE TRIGGER RomavenDatosCliePredeterupd
ON RomavenDatosCliePredeter
AFTER  UPDATE
AS
 BEGIN
INSERT INTO RomavenDatosCliePredeter_log(
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal_Id,
FormaEntrega_Id,
CondFiscal_Id,
Moneda_Id_Contable,
CtaDxVentas_Id_Contable,
CtaAnticipo_Id_Contable,
CtaFactCliente_Id_Contable,
CondPago_Id,
Cobrador_Id,
CategCred_Id,
ListaPrec_Id,
Region_Id,
Zona_Id,
TipoClie_Id,
GETDATE(),
'upd'
FROM inserted where Sucursal_Id=inserted.Sucursal_Id)
 END
GO

 DROP TRIGGER sisAccionesConfigins
GO

 CREATE TRIGGER sisAccionesConfigins
ON sisAccionesConfig
AFTER INSERT
AS
 BEGIN
INSERT INTO sisAccionesConfig_log(
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
FechaModifLog,
TipoModificacion
)
(Select 
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
GETDATE(),
'ins'
FROM inserted where Accion_Id=inserted.Accion_Id)
 END
GO

 DROP TRIGGER sisAccionesConfigdel
GO

 CREATE TRIGGER sisAccionesConfigdel
ON sisAccionesConfig
AFTER DELETE
AS
 BEGIN
INSERT INTO sisAccionesConfig_log(
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
FechaModifLog,
TipoModificacion
)
(Select 
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
GETDATE(),
'del'
FROM deleted where Accion_Id=deleted.Accion_Id)
 END
GO

 DROP TRIGGER sisAccionesConfigupd
GO

 CREATE TRIGGER sisAccionesConfigupd
ON sisAccionesConfig
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sisAccionesConfig_log(
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
FechaModifLog,
TipoModificacion
)
(Select 
Accion_Id,
Descripcion,
Controlador,
ModoTransaccion,
GETDATE(),
'upd'
FROM inserted where Accion_Id=inserted.Accion_Id)
 END
GO

 DROP TRIGGER stkArtiUMins
GO

 CREATE TRIGGER stkArtiUMins
ON stkArtiUM
AFTER INSERT
AS
 BEGIN
INSERT INTO stkArtiUM_log(
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
GETDATE(),
'ins'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkArtiUMdel
GO

 CREATE TRIGGER stkArtiUMdel
ON stkArtiUM
AFTER DELETE
AS
 BEGIN
INSERT INTO stkArtiUM_log(
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
GETDATE(),
'del'
FROM deleted where Producto_Id=deleted.Producto_Id)
 END
GO

 DROP TRIGGER stkArtiUMupd
GO

 CREATE TRIGGER stkArtiUMupd
ON stkArtiUM
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkArtiUM_log(
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Medida_Id,
Factor,
CodigoBarra,
GETDATE(),
'upd'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkCausasMoviins
GO

 CREATE TRIGGER stkCausasMoviins
ON stkCausasMovi
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCausasMovi_log(
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkCausasMovi=inserted.stkCausasMovi)
 END
GO

 DROP TRIGGER stkCausasMovidel
GO

 CREATE TRIGGER stkCausasMovidel
ON stkCausasMovi
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCausasMovi_log(
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkCausasMovi=deleted.stkCausasMovi)
 END
GO

 DROP TRIGGER stkCausasMoviupd
GO

 CREATE TRIGGER stkCausasMoviupd
ON stkCausasMovi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCausasMovi_log(
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCausasMovi,
Causa_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
EntSalAmb,
UsuarioAutorizado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkCausasMovi=inserted.stkCausasMovi)
 END
GO

 DROP TRIGGER stkCFComImpins
GO

 CREATE TRIGGER stkCFComImpins
ON stkCFComImp
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCFComImp_log(
CFComp_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFComp_Id,
Impuesto_Id,
GETDATE(),
'ins'
FROM inserted where CFComp_Id=inserted.CFComp_Id)
 END
GO

 DROP TRIGGER stkCFComImpdel
GO

 CREATE TRIGGER stkCFComImpdel
ON stkCFComImp
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCFComImp_log(
CFComp_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFComp_Id,
Impuesto_Id,
GETDATE(),
'del'
FROM deleted where CFComp_Id=deleted.CFComp_Id)
 END
GO

 DROP TRIGGER stkCFComImpupd
GO

 CREATE TRIGGER stkCFComImpupd
ON stkCFComImp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCFComImp_log(
CFComp_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFComp_Id,
Impuesto_Id,
GETDATE(),
'upd'
FROM inserted where CFComp_Id=inserted.CFComp_Id)
 END
GO

 DROP TRIGGER stkCFVenImpins
GO

 CREATE TRIGGER stkCFVenImpins
ON stkCFVenImp
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCFVenImp_log(
CFVenta_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFVenta_Id,
Impuesto_Id,
GETDATE(),
'ins'
FROM inserted where CFVenta_Id=inserted.CFVenta_Id)
 END
GO

 DROP TRIGGER stkCFVenImpdel
GO

 CREATE TRIGGER stkCFVenImpdel
ON stkCFVenImp
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCFVenImp_log(
CFVenta_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFVenta_Id,
Impuesto_Id,
GETDATE(),
'del'
FROM deleted where CFVenta_Id=deleted.CFVenta_Id)
 END
GO

 DROP TRIGGER stkCFVenImpupd
GO

 CREATE TRIGGER stkCFVenImpupd
ON stkCFVenImp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCFVenImp_log(
CFVenta_Id,
Impuesto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CFVenta_Id,
Impuesto_Id,
GETDATE(),
'upd'
FROM inserted where CFVenta_Id=inserted.CFVenta_Id)
 END
GO

 DROP TRIGGER stkCondFisComprains
GO

 CREATE TRIGGER stkCondFisComprains
ON stkCondFisCompra
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCondFisCompra_log(
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkCondFisCompra=inserted.stkCondFisCompra)
 END
GO

 DROP TRIGGER stkCondFisCompradel
GO

 CREATE TRIGGER stkCondFisCompradel
ON stkCondFisCompra
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCondFisCompra_log(
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkCondFisCompra=deleted.stkCondFisCompra)
 END
GO

 DROP TRIGGER stkCondFisCompraupd
GO

 CREATE TRIGGER stkCondFisCompraupd
ON stkCondFisCompra
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCondFisCompra_log(
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisCompra,
CFComp_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkCondFisCompra=inserted.stkCondFisCompra)
 END
GO

 DROP TRIGGER stkCondFisVentains
GO

 CREATE TRIGGER stkCondFisVentains
ON stkCondFisVenta
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCondFisVenta_log(
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkCondFisVenta=inserted.stkCondFisVenta)
 END
GO

 DROP TRIGGER stkCondFisVentadel
GO

 CREATE TRIGGER stkCondFisVentadel
ON stkCondFisVenta
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCondFisVenta_log(
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkCondFisVenta=deleted.stkCondFisVenta)
 END
GO

 DROP TRIGGER stkCondFisVentaupd
GO

 CREATE TRIGGER stkCondFisVentaupd
ON stkCondFisVenta
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCondFisVenta_log(
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkCondFisVenta,
CFVenta_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkCondFisVenta=inserted.stkCondFisVenta)
 END
GO

 DROP TRIGGER stkCOTArins
GO

 CREATE TRIGGER stkCOTArins
ON stkCOTAr
AFTER INSERT
AS
 BEGIN
INSERT INTO stkCOTAr_log(
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
GETDATE(),
'ins'
FROM inserted where stkHojaDeRuta=inserted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkCOTArdel
GO

 CREATE TRIGGER stkCOTArdel
ON stkCOTAr
AFTER DELETE
AS
 BEGIN
INSERT INTO stkCOTAr_log(
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
GETDATE(),
'del'
FROM deleted where stkHojaDeRuta=deleted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkCOTArupd
GO

 CREATE TRIGGER stkCOTArupd
ON stkCOTAr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkCOTAr_log(
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Provincia_Id,
Peso,
Importe,
COT,
GETDATE(),
'upd'
FROM inserted where stkHojaDeRuta=inserted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkDepositosins
GO

 CREATE TRIGGER stkDepositosins
ON stkDepositos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkDepositos_log(
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
FechaModifLog,
TipoModificacion
)
(Select 
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
GETDATE(),
'ins'
FROM inserted where stkDepositos=inserted.stkDepositos)
 END
GO

 DROP TRIGGER stkDepositosdel
GO

 CREATE TRIGGER stkDepositosdel
ON stkDepositos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkDepositos_log(
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
FechaModifLog,
TipoModificacion
)
(Select 
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
GETDATE(),
'del'
FROM deleted where stkDepositos=deleted.stkDepositos)
 END
GO

 DROP TRIGGER stkDepositosupd
GO

 CREATE TRIGGER stkDepositosupd
ON stkDepositos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkDepositos_log(
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
FechaModifLog,
TipoModificacion
)
(Select 
stkDepositos,
Deposito_Id,
Empresa_Id,
Sucursal,
Descripcion,
Direccion,
GrupoUsuarios,
Centro1_Id,
Centro2_Id,
AdmiteVentas,
Consignacion,
CuentaDeudCons,
CuentaAcredCons,
CtaBienesCambio,
CtaMercEnCons,
DepositoReal,
consCompra_Venta,
Localidad,
CodigoPostal,
Provincia_Id,
Proveed_Id,
Inactivo,
Posteado,
Usuario_Id,
UsaUbicacion,
GETDATE(),
'upd'
FROM inserted where stkDepositos=inserted.stkDepositos)
 END
GO

 DROP TRIGGER stkEliminaRemiPendins
GO

 CREATE TRIGGER stkEliminaRemiPendins
ON stkEliminaRemiPend
AFTER INSERT
AS
 BEGIN
INSERT INTO stkEliminaRemiPend_log(
stkMoviCabe,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Usuario_Id,
Fecha,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkEliminaRemiPenddel
GO

 CREATE TRIGGER stkEliminaRemiPenddel
ON stkEliminaRemiPend
AFTER DELETE
AS
 BEGIN
INSERT INTO stkEliminaRemiPend_log(
stkMoviCabe,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Usuario_Id,
Fecha,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkEliminaRemiPendupd
GO

 CREATE TRIGGER stkEliminaRemiPendupd
ON stkEliminaRemiPend
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkEliminaRemiPend_log(
stkMoviCabe,
Usuario_Id,
Fecha,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Usuario_Id,
Fecha,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkEntradasCancRemiins
GO

 CREATE TRIGGER stkEntradasCancRemiins
ON stkEntradasCancRemi
AFTER INSERT
AS
 BEGIN
INSERT INTO stkEntradasCancRemi_log(
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabeEntrada=inserted.stkMoviCabeEntrada)
 END
GO

 DROP TRIGGER stkEntradasCancRemidel
GO

 CREATE TRIGGER stkEntradasCancRemidel
ON stkEntradasCancRemi
AFTER DELETE
AS
 BEGIN
INSERT INTO stkEntradasCancRemi_log(
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabeEntrada=deleted.stkMoviCabeEntrada)
 END
GO

 DROP TRIGGER stkEntradasCancRemiupd
GO

 CREATE TRIGGER stkEntradasCancRemiupd
ON stkEntradasCancRemi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkEntradasCancRemi_log(
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeEntrada,
RenglonEntrada,
stkMoviCabeRemi,
RenglonRemi,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabeEntrada=inserted.stkMoviCabeEntrada)
 END
GO

 DROP TRIGGER stkEnTransitoins
GO

 CREATE TRIGGER stkEnTransitoins
ON stkEnTransito
AFTER INSERT
AS
 BEGIN
INSERT INTO stkEnTransito_log(
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkEnTransitodel
GO

 CREATE TRIGGER stkEnTransitodel
ON stkEnTransito
AFTER DELETE
AS
 BEGIN
INSERT INTO stkEnTransito_log(
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkEnTransitoupd
GO

 CREATE TRIGGER stkEnTransitoupd
ON stkEnTransito
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkEnTransito_log(
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkMoviCabeEntr,
Deposito_Id,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkExistenciains
GO

 CREATE TRIGGER stkExistenciains
ON stkExistencia
AFTER INSERT
AS
 BEGIN
INSERT INTO stkExistencia_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciadel
GO

 CREATE TRIGGER stkExistenciadel
ON stkExistencia
AFTER DELETE
AS
 BEGIN
INSERT INTO stkExistencia_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaupd
GO

 CREATE TRIGGER stkExistenciaupd
ON stkExistencia
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkExistencia_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaDespains
GO

 CREATE TRIGGER stkExistenciaDespains
ON stkExistenciaDespa
AFTER INSERT
AS
 BEGIN
INSERT INTO stkExistenciaDespa_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaDespadel
GO

 CREATE TRIGGER stkExistenciaDespadel
ON stkExistenciaDespa
AFTER DELETE
AS
 BEGIN
INSERT INTO stkExistenciaDespa_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaDespaupd
GO

 CREATE TRIGGER stkExistenciaDespaupd
ON stkExistenciaDespa
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkExistenciaDespa_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Despacho_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaSerieins
GO

 CREATE TRIGGER stkExistenciaSerieins
ON stkExistenciaSerie
AFTER INSERT
AS
 BEGIN
INSERT INTO stkExistenciaSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaSeriedel
GO

 CREATE TRIGGER stkExistenciaSeriedel
ON stkExistenciaSerie
AFTER DELETE
AS
 BEGIN
INSERT INTO stkExistenciaSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaSerieupd
GO

 CREATE TRIGGER stkExistenciaSerieupd
ON stkExistenciaSerie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkExistenciaSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Cantidad,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbiins
GO

 CREATE TRIGGER stkExistenciaUbiins
ON stkExistenciaUbi
AFTER INSERT
AS
 BEGIN
INSERT INTO stkExistenciaUbi_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbidel
GO

 CREATE TRIGGER stkExistenciaUbidel
ON stkExistenciaUbi
AFTER DELETE
AS
 BEGIN
INSERT INTO stkExistenciaUbi_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbiupd
GO

 CREATE TRIGGER stkExistenciaUbiupd
ON stkExistenciaUbi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkExistenciaUbi_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Ubicacion_Id,
Cantidad,
CantidadReservada,
CantidadAlterna,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbiSerieins
GO

 CREATE TRIGGER stkExistenciaUbiSerieins
ON stkExistenciaUbiSerie
AFTER INSERT
AS
 BEGIN
INSERT INTO stkExistenciaUbiSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbiSeriedel
GO

 CREATE TRIGGER stkExistenciaUbiSeriedel
ON stkExistenciaUbiSerie
AFTER DELETE
AS
 BEGIN
INSERT INTO stkExistenciaUbiSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkExistenciaUbiSerieupd
GO

 CREATE TRIGGER stkExistenciaUbiSerieupd
ON stkExistenciaUbiSerie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkExistenciaUbiSerie_log(
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Deposito_Id,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkFamiliasins
GO

 CREATE TRIGGER stkFamiliasins
ON stkFamilias
AFTER INSERT
AS
 BEGIN
INSERT INTO stkFamilias_log(
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where stkFamilias=inserted.stkFamilias)
 END
GO

 DROP TRIGGER stkFamiliasdel
GO

 CREATE TRIGGER stkFamiliasdel
ON stkFamilias
AFTER DELETE
AS
 BEGIN
INSERT INTO stkFamilias_log(
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where stkFamilias=deleted.stkFamilias)
 END
GO

 DROP TRIGGER stkFamiliasupd
GO

 CREATE TRIGGER stkFamiliasupd
ON stkFamilias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkFamilias_log(
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkFamilias,
Familia_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where stkFamilias=inserted.stkFamilias)
 END
GO

 DROP TRIGGER stkGruposins
GO

 CREATE TRIGGER stkGruposins
ON stkGrupos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkGrupos_log(
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where stkGrupos=inserted.stkGrupos)
 END
GO

 DROP TRIGGER stkGruposdel
GO

 CREATE TRIGGER stkGruposdel
ON stkGrupos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkGrupos_log(
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where stkGrupos=deleted.stkGrupos)
 END
GO

 DROP TRIGGER stkGruposupd
GO

 CREATE TRIGGER stkGruposupd
ON stkGrupos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkGrupos_log(
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where stkGrupos=inserted.stkGrupos)
 END
GO

 DROP TRIGGER stkHojaDeRutains
GO

 CREATE TRIGGER stkHojaDeRutains
ON stkHojaDeRuta
AFTER INSERT
AS
 BEGIN
INSERT INTO stkHojaDeRuta_log(
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
GETDATE(),
'ins'
FROM inserted where stkHojaDeRuta=inserted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkHojaDeRutadel
GO

 CREATE TRIGGER stkHojaDeRutadel
ON stkHojaDeRuta
AFTER DELETE
AS
 BEGIN
INSERT INTO stkHojaDeRuta_log(
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
GETDATE(),
'del'
FROM deleted where stkHojaDeRuta=deleted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkHojaDeRutaupd
GO

 CREATE TRIGGER stkHojaDeRutaupd
ON stkHojaDeRuta
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkHojaDeRuta_log(
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkHojaDeRuta,
Empresa_Id,
Usuario_Id,
FechaRegistro,
Patente_Id,
PatenteAcoplado,
venReparto,
FormaEntrega_Id,
GETDATE(),
'upd'
FROM inserted where stkHojaDeRuta=inserted.stkHojaDeRuta)
 END
GO

 DROP TRIGGER stkHojaSegmentosins
GO

 CREATE TRIGGER stkHojaSegmentosins
ON stkHojaSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkHojaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkHojaSegmentosdel
GO

 CREATE TRIGGER stkHojaSegmentosdel
ON stkHojaSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkHojaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkHojaSegmentosupd
GO

 CREATE TRIGGER stkHojaSegmentosupd
ON stkHojaSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkHojaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkHojaDeRuta,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkInvenSegmentosins
GO

 CREATE TRIGGER stkInvenSegmentosins
ON stkInvenSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkInvenSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkInvenSegmentosdel
GO

 CREATE TRIGGER stkInvenSegmentosdel
ON stkInvenSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkInvenSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkInvenSegmentosupd
GO

 CREATE TRIGGER stkInvenSegmentosupd
ON stkInvenSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkInvenSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
stkInventarios,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkInventariosins
GO

 CREATE TRIGGER stkInventariosins
ON stkInventarios
AFTER INSERT
AS
 BEGIN
INSERT INTO stkInventarios_log(
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkInventarios=inserted.stkInventarios)
 END
GO

 DROP TRIGGER stkInventariosdel
GO

 CREATE TRIGGER stkInventariosdel
ON stkInventarios
AFTER DELETE
AS
 BEGIN
INSERT INTO stkInventarios_log(
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkInventarios=deleted.stkInventarios)
 END
GO

 DROP TRIGGER stkInventariosupd
GO

 CREATE TRIGGER stkInventariosupd
ON stkInventarios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkInventarios_log(
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Deposito_Id,
FechaInventario,
FechaCarga,
FechaAutorizo,
UsuarioAutorizo,
UsuRespo_Id,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkInventarios=inserted.stkInventarios)
 END
GO

 DROP TRIGGER stkInventCuerpoins
GO

 CREATE TRIGGER stkInventCuerpoins
ON stkInventCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkInventCuerpo_log(
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'ins'
FROM inserted where stkInventarios=inserted.stkInventarios)
 END
GO

 DROP TRIGGER stkInventCuerpodel
GO

 CREATE TRIGGER stkInventCuerpodel
ON stkInventCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkInventCuerpo_log(
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'del'
FROM deleted where stkInventarios=deleted.stkInventarios)
 END
GO

 DROP TRIGGER stkInventCuerpoupd
GO

 CREATE TRIGGER stkInventCuerpoupd
ON stkInventCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkInventCuerpo_log(
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkInventarios,
Producto_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'upd'
FROM inserted where stkInventarios=inserted.stkInventarios)
 END
GO

 DROP TRIGGER stkInvMoviStkins
GO

 CREATE TRIGGER stkInvMoviStkins
ON stkInvMoviStk
AFTER INSERT
AS
 BEGIN
INSERT INTO stkInvMoviStk_log(
stkMoviCabe,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkInventarios,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkInvMoviStkdel
GO

 CREATE TRIGGER stkInvMoviStkdel
ON stkInvMoviStk
AFTER DELETE
AS
 BEGIN
INSERT INTO stkInvMoviStk_log(
stkMoviCabe,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkInventarios,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkInvMoviStkupd
GO

 CREATE TRIGGER stkInvMoviStkupd
ON stkInvMoviStk
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkInvMoviStk_log(
stkMoviCabe,
stkInventarios,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
stkInventarios,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMaxMinins
GO

 CREATE TRIGGER stkMaxMinins
ON stkMaxMin
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMaxMin_log(
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
GETDATE(),
'ins'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkMaxMindel
GO

 CREATE TRIGGER stkMaxMindel
ON stkMaxMin
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMaxMin_log(
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
GETDATE(),
'del'
FROM deleted where Producto_Id=deleted.Producto_Id)
 END
GO

 DROP TRIGGER stkMaxMinupd
GO

 CREATE TRIGGER stkMaxMinupd
ON stkMaxMin
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMaxMin_log(
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Deposito_Id,
Empresa_Id,
Minimo,
Maximo,
GETDATE(),
'upd'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkMoviCabeins
GO

 CREATE TRIGGER stkMoviCabeins
ON stkMoviCabe
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCabe_log(
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCabedel
GO

 CREATE TRIGGER stkMoviCabedel
ON stkMoviCabe
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCabe_log(
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCabeupd
GO

 CREATE TRIGGER stkMoviCabeupd
ON stkMoviCabe
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCabe_log(
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
SubTipoMov_Id,
ModificaCosto,
Signo,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCabeCentroins
GO

 CREATE TRIGGER stkMoviCabeCentroins
ON stkMoviCabeCentro
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCabeCentro_log(
stkMoviCabe,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCabeCentrodel
GO

 CREATE TRIGGER stkMoviCabeCentrodel
ON stkMoviCabeCentro
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCabeCentro_log(
stkMoviCabe,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCabeCentroupd
GO

 CREATE TRIGGER stkMoviCabeCentroupd
ON stkMoviCabeCentro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCabeCentro_log(
stkMoviCabe,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCausains
GO

 CREATE TRIGGER stkMoviCausains
ON stkMoviCausa
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCausa_log(
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCausadel
GO

 CREATE TRIGGER stkMoviCausadel
ON stkMoviCausa
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCausa_log(
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCausaupd
GO

 CREATE TRIGGER stkMoviCausaupd
ON stkMoviCausa
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCausa_log(
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Causa_Id,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviConsignains
GO

 CREATE TRIGGER stkMoviConsignains
ON stkMoviConsigna
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviConsigna_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviConsignadel
GO

 CREATE TRIGGER stkMoviConsignadel
ON stkMoviConsigna
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviConsigna_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviConsignaupd
GO

 CREATE TRIGGER stkMoviConsignaupd
ON stkMoviConsigna
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviConsigna_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCRevaluoins
GO

 CREATE TRIGGER stkMoviCRevaluoins
ON stkMoviCRevaluo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCRevaluo_log(
stkMoviCabeReva,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeReva,
conAsientos,
GETDATE(),
'ins'
FROM inserted where stkMoviCabeReva=inserted.stkMoviCabeReva)
 END
GO

 DROP TRIGGER stkMoviCRevaluodel
GO

 CREATE TRIGGER stkMoviCRevaluodel
ON stkMoviCRevaluo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCRevaluo_log(
stkMoviCabeReva,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeReva,
conAsientos,
GETDATE(),
'del'
FROM deleted where stkMoviCabeReva=deleted.stkMoviCabeReva)
 END
GO

 DROP TRIGGER stkMoviCRevaluoupd
GO

 CREATE TRIGGER stkMoviCRevaluoupd
ON stkMoviCRevaluo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCRevaluo_log(
stkMoviCabeReva,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeReva,
conAsientos,
GETDATE(),
'upd'
FROM inserted where stkMoviCabeReva=inserted.stkMoviCabeReva)
 END
GO

 DROP TRIGGER stkMoviCuerpoins
GO

 CREATE TRIGGER stkMoviCuerpoins
ON stkMoviCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCuerpo_log(
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpodel
GO

 CREATE TRIGGER stkMoviCuerpodel
ON stkMoviCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCuerpo_log(
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoupd
GO

 CREATE TRIGGER stkMoviCuerpoupd
ON stkMoviCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCuerpo_log(
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
stkMoviCabeComponente,
RenglonComponente,
Fecha,
Deposito_Id,
Producto_Id,
Medida_Id,
Factor,
Cantidad,
CantidadForm,
CostoUnitario,
PrecioOriginal,
MedidaAlterna,
CantidadAlternaForm,
Observaciones,
Descuento,
conRenglonDebe,
conRenglonHaber,
RenglonCombo,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoComboins
GO

 CREATE TRIGGER stkMoviCuerpoComboins
ON stkMoviCuerpoCombo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCuerpoCombo_log(
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
GETDATE(),
'ins'
FROM inserted where stkMoviCabeComponente=inserted.stkMoviCabeComponente)
 END
GO

 DROP TRIGGER stkMoviCuerpoCombodel
GO

 CREATE TRIGGER stkMoviCuerpoCombodel
ON stkMoviCuerpoCombo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCuerpoCombo_log(
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
GETDATE(),
'del'
FROM deleted where stkMoviCabeComponente=deleted.stkMoviCabeComponente)
 END
GO

 DROP TRIGGER stkMoviCuerpoComboupd
GO

 CREATE TRIGGER stkMoviCuerpoComboupd
ON stkMoviCuerpoCombo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCuerpoCombo_log(
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabeComponente,
RenglonComponente,
stkMoviCabe,
Renglon,
GETDATE(),
'upd'
FROM inserted where stkMoviCabeComponente=inserted.stkMoviCabeComponente)
 END
GO

 DROP TRIGGER stkMoviCuerpoPediCuerpoins
GO

 CREATE TRIGGER stkMoviCuerpoPediCuerpoins
ON stkMoviCuerpoPediCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCuerpoPediCuerpo_log(
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoPediCuerpodel
GO

 CREATE TRIGGER stkMoviCuerpoPediCuerpodel
ON stkMoviCuerpoPediCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCuerpoPediCuerpo_log(
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoPediCuerpoupd
GO

 CREATE TRIGGER stkMoviCuerpoPediCuerpoupd
ON stkMoviCuerpoPediCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCuerpoPediCuerpo_log(
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
venPedidos,
Renglon_Pe,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoRevains
GO

 CREATE TRIGGER stkMoviCuerpoRevains
ON stkMoviCuerpoReva
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviCuerpoReva_log(
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoRevadel
GO

 CREATE TRIGGER stkMoviCuerpoRevadel
ON stkMoviCuerpoReva
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviCuerpoReva_log(
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviCuerpoRevaupd
GO

 CREATE TRIGGER stkMoviCuerpoRevaupd
ON stkMoviCuerpoReva
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviCuerpoReva_log(
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Producto_Id,
PUC_Actual,
PUC_Anterior,
PPP_Actual,
PPP_Anterior,
STD_Actual,
STD_Anterior,
ImporteAjuste,
ImporteAjusteCosto,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviDespains
GO

 CREATE TRIGGER stkMoviDespains
ON stkMoviDespa
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviDespa_log(
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviDespadel
GO

 CREATE TRIGGER stkMoviDespadel
ON stkMoviDespa
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviDespa_log(
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviDespaupd
GO

 CREATE TRIGGER stkMoviDespaupd
ON stkMoviDespa
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviDespa_log(
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Despacho_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviEmbarqueins
GO

 CREATE TRIGGER stkMoviEmbarqueins
ON stkMoviEmbarque
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviEmbarque_log(
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviEmbarquedel
GO

 CREATE TRIGGER stkMoviEmbarquedel
ON stkMoviEmbarque
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviEmbarque_log(
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviEmbarqueupd
GO

 CREATE TRIGGER stkMoviEmbarqueupd
ON stkMoviEmbarque
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviEmbarque_log(
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
comEmbarques,
Proveed_Id,
RemitoProv,
Despacho_Id,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviOCins
GO

 CREATE TRIGGER stkMoviOCins
ON stkMoviOC
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviOC_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviOCdel
GO

 CREATE TRIGGER stkMoviOCdel
ON stkMoviOC
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviOC_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviOCupd
GO

 CREATE TRIGGER stkMoviOCupd
ON stkMoviOC
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviOC_log(
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comOrdenComp,
Renglon_OC,
CantFactPendiente,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviProvins
GO

 CREATE TRIGGER stkMoviProvins
ON stkMoviProv
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviProv_log(
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviProvdel
GO

 CREATE TRIGGER stkMoviProvdel
ON stkMoviProv
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviProv_log(
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviProvupd
GO

 CREATE TRIGGER stkMoviProvupd
ON stkMoviProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviProv_log(
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
RemitoProv,
Proveed_Id,
FechaRemito,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviRIins
GO

 CREATE TRIGGER stkMoviRIins
ON stkMoviRI
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviRI_log(
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviRIdel
GO

 CREATE TRIGGER stkMoviRIdel
ON stkMoviRI
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviRI_log(
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviRIupd
GO

 CREATE TRIGGER stkMoviRIupd
ON stkMoviRI
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviRI_log(
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
comReqInterno,
Renglon_RI,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSerieins
GO

 CREATE TRIGGER stkMoviSerieins
ON stkMoviSerie
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviSerie_log(
stkMoviCabe,
Renglon,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSeriedel
GO

 CREATE TRIGGER stkMoviSeriedel
ON stkMoviSerie
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviSerie_log(
stkMoviCabe,
Renglon,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSerieupd
GO

 CREATE TRIGGER stkMoviSerieupd
ON stkMoviSerie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviSerie_log(
stkMoviCabe,
Renglon,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSerieUbicacionins
GO

 CREATE TRIGGER stkMoviSerieUbicacionins
ON stkMoviSerieUbicacion
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviSerieUbicacion_log(
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSerieUbicaciondel
GO

 CREATE TRIGGER stkMoviSerieUbicaciondel
ON stkMoviSerieUbicacion
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviSerieUbicacion_log(
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviSerieUbicacionupd
GO

 CREATE TRIGGER stkMoviSerieUbicacionupd
ON stkMoviSerieUbicacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviSerieUbicacion_log(
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviUbicacionins
GO

 CREATE TRIGGER stkMoviUbicacionins
ON stkMoviUbicacion
AFTER INSERT
AS
 BEGIN
INSERT INTO stkMoviUbicacion_log(
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviUbicaciondel
GO

 CREATE TRIGGER stkMoviUbicaciondel
ON stkMoviUbicacion
AFTER DELETE
AS
 BEGIN
INSERT INTO stkMoviUbicacion_log(
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkMoviUbicacionupd
GO

 CREATE TRIGGER stkMoviUbicacionupd
ON stkMoviUbicacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkMoviUbicacion_log(
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
Ubicacion_Id,
Cantidad,
CantidadAlterna,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkProductosins
GO

 CREATE TRIGGER stkProductosins
ON stkProductos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductos_log(
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
GETDATE(),
'ins'
FROM inserted where stkProductos=inserted.stkProductos)
 END
GO

 DROP TRIGGER stkProductosdel
GO

 CREATE TRIGGER stkProductosdel
ON stkProductos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductos_log(
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
GETDATE(),
'del'
FROM deleted where stkProductos=deleted.stkProductos)
 END
GO

 DROP TRIGGER stkProductosupd
GO

 CREATE TRIGGER stkProductosupd
ON stkProductos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductos_log(
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductos,
Producto_Id,
Empresa_Id,
Descripcion,
DescripcionDetallada,
Description,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
CodigoBarra,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UmVenta,
CostoPromPond,
CostoUltCompra,
CostoReposicion,
CostoStandard,
CostoUltimoCierre,
MonedaUltCompra,
PrecioUltCompra,
UMCompra,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentaExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
Fcha_Ult_Compra,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFComp_Id,
Acepta_Comis_Vta,
DiasGarantia,
Imagen,
FechaUltModif,
ImagenExtension,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Usuario_Id,
Posteado,
CtaConsumo,
GETDATE(),
'upd'
FROM inserted where stkProductos=inserted.stkProductos)
 END
GO

 DROP TRIGGER stkProductosComboins
GO

 CREATE TRIGGER stkProductosComboins
ON stkProductosCombo
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosCombo_log(
Combo_Id,
Producto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Combo_Id,
Producto_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where Combo_Id=inserted.Combo_Id)
 END
GO

 DROP TRIGGER stkProductosCombodel
GO

 CREATE TRIGGER stkProductosCombodel
ON stkProductosCombo
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosCombo_log(
Combo_Id,
Producto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Combo_Id,
Producto_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where Combo_Id=deleted.Combo_Id)
 END
GO

 DROP TRIGGER stkProductosComboupd
GO

 CREATE TRIGGER stkProductosComboupd
ON stkProductosCombo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosCombo_log(
Combo_Id,
Producto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Combo_Id,
Producto_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where Combo_Id=inserted.Combo_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierreins
GO

 CREATE TRIGGER stkProductosCostoCierreins
ON stkProductosCostoCierre
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosCostoCierre_log(
Empresa_Id,
Fecha,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Producto_Id,
Costo,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierredel
GO

 CREATE TRIGGER stkProductosCostoCierredel
ON stkProductosCostoCierre
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosCostoCierre_log(
Empresa_Id,
Fecha,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Producto_Id,
Costo,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierreupd
GO

 CREATE TRIGGER stkProductosCostoCierreupd
ON stkProductosCostoCierre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosCostoCierre_log(
Empresa_Id,
Fecha,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Producto_Id,
Costo,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierreSucursalins
GO

 CREATE TRIGGER stkProductosCostoCierreSucursalins
ON stkProductosCostoCierreSucursal
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosCostoCierreSucursal_log(
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierreSucursaldel
GO

 CREATE TRIGGER stkProductosCostoCierreSucursaldel
ON stkProductosCostoCierreSucursal
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosCostoCierreSucursal_log(
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostoCierreSucursalupd
GO

 CREATE TRIGGER stkProductosCostoCierreSucursalupd
ON stkProductosCostoCierreSucursal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosCostoCierreSucursal_log(
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Fecha,
Sucursal,
Producto_Id,
Costo,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkProductosCostosins
GO

 CREATE TRIGGER stkProductosCostosins
ON stkProductosCostos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosCostos_log(
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkProductosCostosdel
GO

 CREATE TRIGGER stkProductosCostosdel
ON stkProductosCostos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosCostos_log(
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Producto_Id=deleted.Producto_Id)
 END
GO

 DROP TRIGGER stkProductosCostosupd
GO

 CREATE TRIGGER stkProductosCostosupd
ON stkProductosCostos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosCostos_log(
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Producto_Id=inserted.Producto_Id)
 END
GO

 DROP TRIGGER stkProductosCostosSucursalins
GO

 CREATE TRIGGER stkProductosCostosSucursalins
ON stkProductosCostosSucursal
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosCostosSucursal_log(
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER stkProductosCostosSucursaldel
GO

 CREATE TRIGGER stkProductosCostosSucursaldel
ON stkProductosCostosSucursal
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosCostosSucursal_log(
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Sucursal=deleted.Sucursal)
 END
GO

 DROP TRIGGER stkProductosCostosSucursalupd
GO

 CREATE TRIGGER stkProductosCostosSucursalupd
ON stkProductosCostosSucursal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosCostosSucursal_log(
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Sucursal,
Producto_Id,
Empresa_Id,
MonedaUltCompra,
CostoPromPond,
CostoUltCompra,
CostoStandard,
FechaUltModif,
PrecioUltCompra,
Fecha_Ult_Compra,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Sucursal=inserted.Sucursal)
 END
GO

 DROP TRIGGER stkProductosPlantillains
GO

 CREATE TRIGGER stkProductosPlantillains
ON stkProductosPlantilla
AFTER INSERT
AS
 BEGIN
INSERT INTO stkProductosPlantilla_log(
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
GETDATE(),
'ins'
FROM inserted where stkProductosPlantilla=inserted.stkProductosPlantilla)
 END
GO

 DROP TRIGGER stkProductosPlantilladel
GO

 CREATE TRIGGER stkProductosPlantilladel
ON stkProductosPlantilla
AFTER DELETE
AS
 BEGIN
INSERT INTO stkProductosPlantilla_log(
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
GETDATE(),
'del'
FROM deleted where stkProductosPlantilla=deleted.stkProductosPlantilla)
 END
GO

 DROP TRIGGER stkProductosPlantillaupd
GO

 CREATE TRIGGER stkProductosPlantillaupd
ON stkProductosPlantilla
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkProductosPlantilla_log(
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
FechaModifLog,
TipoModificacion
)
(Select 
stkProductosPlantilla,
Plantilla_Id,
Empresa_Id,
Descripcion,
Medida_Id,
MedidaAlterna,
FactorAlterna,
Clase,
ClaseAlterna,
Tipo_Id,
Familia_Id,
Grupo_Id,
TrabajaPorLotes,
conVencimiento,
Serializable,
UsaDespachoImportacion,
UMVenta_Id,
MonedaUltCompra,
UMCompra_Id,
CtaCompra,
CtaAjuInventario,
CtaVenta,
CtaCredito,
CtaDescuento,
CtaCosto,
CtaVentasExt,
CtaCreditoExt,
CtaDescuentoExt,
CtaCostoExt,
MargenExceso,
TiempoEntrega,
Acepta_Ventas,
CFVenta_Id,
Acepta_Compras,
CFCompra_Id,
Acepta_Comis_Vta,
DiasGarantia,
CodigoFiscal,
FraccionArancelaria,
Inactivo,
Posteado,
Usuario_Id,
CtaConsumo,
GETDATE(),
'upd'
FROM inserted where stkProductosPlantilla=inserted.stkProductosPlantilla)
 END
GO

 DROP TRIGGER stkRemiPendFactins
GO

 CREATE TRIGGER stkRemiPendFactins
ON stkRemiPendFact
AFTER INSERT
AS
 BEGIN
INSERT INTO stkRemiPendFact_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemiPendFactdel
GO

 CREATE TRIGGER stkRemiPendFactdel
ON stkRemiPendFact
AFTER DELETE
AS
 BEGIN
INSERT INTO stkRemiPendFact_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemiPendFactupd
GO

 CREATE TRIGGER stkRemiPendFactupd
ON stkRemiPendFact
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkRemiPendFact_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemiPendFactProins
GO

 CREATE TRIGGER stkRemiPendFactProins
ON stkRemiPendFactPro
AFTER INSERT
AS
 BEGIN
INSERT INTO stkRemiPendFactPro_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemiPendFactProdel
GO

 CREATE TRIGGER stkRemiPendFactProdel
ON stkRemiPendFactPro
AFTER DELETE
AS
 BEGIN
INSERT INTO stkRemiPendFactPro_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemiPendFactProupd
GO

 CREATE TRIGGER stkRemiPendFactProupd
ON stkRemiPendFactPro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkRemiPendFactPro_log(
stkMoviCabe,
Renglon,
CantidadPendiente,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Renglon,
CantidadPendiente,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemitosins
GO

 CREATE TRIGGER stkRemitosins
ON stkRemitos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkRemitos_log(
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
GETDATE(),
'ins'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemitosdel
GO

 CREATE TRIGGER stkRemitosdel
ON stkRemitos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkRemitos_log(
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
GETDATE(),
'del'
FROM deleted where stkMoviCabe=deleted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkRemitosupd
GO

 CREATE TRIGGER stkRemitosupd
ON stkRemitos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkRemitos_log(
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
FechaModifLog,
TipoModificacion
)
(Select 
stkMoviCabe,
Cliente_Id,
Sucursal,
Segmento_Id,
ListaPrecio_Id,
HojaRuta_Id,
GETDATE(),
'upd'
FROM inserted where stkMoviCabe=inserted.stkMoviCabe)
 END
GO

 DROP TRIGGER stkSerieVencimientoins
GO

 CREATE TRIGGER stkSerieVencimientoins
ON stkSerieVencimiento
AFTER INSERT
AS
 BEGIN
INSERT INTO stkSerieVencimiento_log(
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkSerieVencimientodel
GO

 CREATE TRIGGER stkSerieVencimientodel
ON stkSerieVencimiento
AFTER DELETE
AS
 BEGIN
INSERT INTO stkSerieVencimiento_log(
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER stkSerieVencimientoupd
GO

 CREATE TRIGGER stkSerieVencimientoupd
ON stkSerieVencimiento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkSerieVencimiento_log(
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Producto_Id,
Serie,
Vencimiento,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER stkSubTipoMovins
GO

 CREATE TRIGGER stkSubTipoMovins
ON stkSubTipoMov
AFTER INSERT
AS
 BEGIN
INSERT INTO stkSubTipoMov_log(
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
GETDATE(),
'ins'
FROM inserted where SubTipoMov_Id=inserted.SubTipoMov_Id)
 END
GO

 DROP TRIGGER stkSubTipoMovdel
GO

 CREATE TRIGGER stkSubTipoMovdel
ON stkSubTipoMov
AFTER DELETE
AS
 BEGIN
INSERT INTO stkSubTipoMov_log(
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
GETDATE(),
'del'
FROM deleted where SubTipoMov_Id=deleted.SubTipoMov_Id)
 END
GO

 DROP TRIGGER stkSubTipoMovupd
GO

 CREATE TRIGGER stkSubTipoMovupd
ON stkSubTipoMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkSubTipoMov_log(
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
SubTipoMov_Id,
TipoMov,
Descripcion,
Consumo,
CantCopias,
Reporte_Id,
GETDATE(),
'upd'
FROM inserted where SubTipoMov_Id=inserted.SubTipoMov_Id)
 END
GO

 DROP TRIGGER stkTiposins
GO

 CREATE TRIGGER stkTiposins
ON stkTipos
AFTER INSERT
AS
 BEGIN
INSERT INTO stkTipos_log(
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkTipos=inserted.stkTipos)
 END
GO

 DROP TRIGGER stkTiposdel
GO

 CREATE TRIGGER stkTiposdel
ON stkTipos
AFTER DELETE
AS
 BEGIN
INSERT INTO stkTipos_log(
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkTipos=deleted.stkTipos)
 END
GO

 DROP TRIGGER stkTiposupd
GO

 CREATE TRIGGER stkTiposupd
ON stkTipos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkTipos_log(
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkTipos,
Tipo_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkTipos=inserted.stkTipos)
 END
GO

 DROP TRIGGER stkTiposMovins
GO

 CREATE TRIGGER stkTiposMovins
ON stkTiposMov
AFTER INSERT
AS
 BEGIN
INSERT INTO stkTiposMov_log(
TipoMov,
Descripcion,
Signo,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
Reporte_Id,
GETDATE(),
'ins'
FROM inserted where TipoMov=inserted.TipoMov)
 END
GO

 DROP TRIGGER stkTiposMovdel
GO

 CREATE TRIGGER stkTiposMovdel
ON stkTiposMov
AFTER DELETE
AS
 BEGIN
INSERT INTO stkTiposMov_log(
TipoMov,
Descripcion,
Signo,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
Reporte_Id,
GETDATE(),
'del'
FROM deleted where TipoMov=deleted.TipoMov)
 END
GO

 DROP TRIGGER stkTiposMovupd
GO

 CREATE TRIGGER stkTiposMovupd
ON stkTiposMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkTiposMov_log(
TipoMov,
Descripcion,
Signo,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
TipoMov,
Descripcion,
Signo,
Reporte_Id,
GETDATE(),
'upd'
FROM inserted where TipoMov=inserted.TipoMov)
 END
GO

 DROP TRIGGER stkUbicacionesins
GO

 CREATE TRIGGER stkUbicacionesins
ON stkUbicaciones
AFTER INSERT
AS
 BEGIN
INSERT INTO stkUbicaciones_log(
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
GETDATE(),
'ins'
FROM inserted where stkUbicaciones=inserted.stkUbicaciones)
 END
GO

 DROP TRIGGER stkUbicacionesdel
GO

 CREATE TRIGGER stkUbicacionesdel
ON stkUbicaciones
AFTER DELETE
AS
 BEGIN
INSERT INTO stkUbicaciones_log(
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
GETDATE(),
'del'
FROM deleted where stkUbicaciones=deleted.stkUbicaciones)
 END
GO

 DROP TRIGGER stkUbicacionesupd
GO

 CREATE TRIGGER stkUbicacionesupd
ON stkUbicaciones
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkUbicaciones_log(
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
stkUbicaciones,
Ubicacion_Id,
Capacidad,
Usuario_Id,
Inactivo,
GETDATE(),
'upd'
FROM inserted where stkUbicaciones=inserted.stkUbicaciones)
 END
GO

 DROP TRIGGER stkUbicacionProdins
GO

 CREATE TRIGGER stkUbicacionProdins
ON stkUbicacionProd
AFTER INSERT
AS
 BEGIN
INSERT INTO stkUbicacionProd_log(
Deposito_Id,
Ubicacion,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Deposito_Id,
Ubicacion,
Producto_Id,
GETDATE(),
'ins'
FROM inserted where Deposito_Id=inserted.Deposito_Id)
 END
GO

 DROP TRIGGER stkUbicacionProddel
GO

 CREATE TRIGGER stkUbicacionProddel
ON stkUbicacionProd
AFTER DELETE
AS
 BEGIN
INSERT INTO stkUbicacionProd_log(
Deposito_Id,
Ubicacion,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Deposito_Id,
Ubicacion,
Producto_Id,
GETDATE(),
'del'
FROM deleted where Deposito_Id=deleted.Deposito_Id)
 END
GO

 DROP TRIGGER stkUbicacionProdupd
GO

 CREATE TRIGGER stkUbicacionProdupd
ON stkUbicacionProd
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkUbicacionProd_log(
Deposito_Id,
Ubicacion,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Deposito_Id,
Ubicacion,
Producto_Id,
GETDATE(),
'upd'
FROM inserted where Deposito_Id=inserted.Deposito_Id)
 END
GO

 DROP TRIGGER stkUniMedins
GO

 CREATE TRIGGER stkUniMedins
ON stkUniMed
AFTER INSERT
AS
 BEGIN
INSERT INTO stkUniMed_log(
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where stkUniMed=inserted.stkUniMed)
 END
GO

 DROP TRIGGER stkUniMeddel
GO

 CREATE TRIGGER stkUniMeddel
ON stkUniMed
AFTER DELETE
AS
 BEGIN
INSERT INTO stkUniMed_log(
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where stkUniMed=deleted.stkUniMed)
 END
GO

 DROP TRIGGER stkUniMedupd
GO

 CREATE TRIGGER stkUniMedupd
ON stkUniMed
AFTER  UPDATE
AS
 BEGIN
INSERT INTO stkUniMed_log(
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
stkUniMed,
Medida_Id,
Empresa_Id,
Descripcion,
Decimales,
Mascara,
CodigoFiscal,
UniExpor,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where stkUniMed=inserted.stkUniMed)
 END
GO

 DROP TRIGGER sueArchivosTxtins
GO

 CREATE TRIGGER sueArchivosTxtins
ON sueArchivosTxt
AFTER INSERT
AS
 BEGIN
INSERT INTO sueArchivosTxt_log(
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'ins'
FROM inserted where sueArchivosTxt=inserted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueArchivosTxtdel
GO

 CREATE TRIGGER sueArchivosTxtdel
ON sueArchivosTxt
AFTER DELETE
AS
 BEGIN
INSERT INTO sueArchivosTxt_log(
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'del'
FROM deleted where sueArchivosTxt=deleted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueArchivosTxtupd
GO

 CREATE TRIGGER sueArchivosTxtupd
ON sueArchivosTxt
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueArchivosTxt_log(
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Archivo_Id,
Descripcion,
Resumen1,
PosicionResumen1,
Resumen2,
PosicionResumen2,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'upd'
FROM inserted where sueArchivosTxt=inserted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueArchivosTxtCuerpoins
GO

 CREATE TRIGGER sueArchivosTxtCuerpoins
ON sueArchivosTxtCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO sueArchivosTxtCuerpo_log(
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
GETDATE(),
'ins'
FROM inserted where sueArchivosTxt=inserted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueArchivosTxtCuerpodel
GO

 CREATE TRIGGER sueArchivosTxtCuerpodel
ON sueArchivosTxtCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO sueArchivosTxtCuerpo_log(
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
GETDATE(),
'del'
FROM deleted where sueArchivosTxt=deleted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueArchivosTxtCuerpoupd
GO

 CREATE TRIGGER sueArchivosTxtCuerpoupd
ON sueArchivosTxtCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueArchivosTxtCuerpo_log(
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
FechaModifLog,
TipoModificacion
)
(Select 
sueArchivosTxt,
Columna,
Formula,
Tipo,
Longitud,
Decimales,
Relleno,
Descripcion,
Orden,
Formato,
GETDATE(),
'upd'
FROM inserted where sueArchivosTxt=inserted.sueArchivosTxt)
 END
GO

 DROP TRIGGER sueCategoriasins
GO

 CREATE TRIGGER sueCategoriasins
ON sueCategorias
AFTER INSERT
AS
 BEGIN
INSERT INTO sueCategorias_log(
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where sueCategorias=inserted.sueCategorias)
 END
GO

 DROP TRIGGER sueCategoriasdel
GO

 CREATE TRIGGER sueCategoriasdel
ON sueCategorias
AFTER DELETE
AS
 BEGIN
INSERT INTO sueCategorias_log(
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where sueCategorias=deleted.sueCategorias)
 END
GO

 DROP TRIGGER sueCategoriasupd
GO

 CREATE TRIGGER sueCategoriasupd
ON sueCategorias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueCategorias_log(
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueCategorias,
Categoria_Id,
Descripcion,
Empresa_Id,
Periodo_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where sueCategorias=inserted.sueCategorias)
 END
GO

 DROP TRIGGER sueCateNombreins
GO

 CREATE TRIGGER sueCateNombreins
ON sueCateNombre
AFTER INSERT
AS
 BEGIN
INSERT INTO sueCateNombre_log(
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where CateNombre_Id=inserted.CateNombre_Id)
 END
GO

 DROP TRIGGER sueCateNombredel
GO

 CREATE TRIGGER sueCateNombredel
ON sueCateNombre
AFTER DELETE
AS
 BEGIN
INSERT INTO sueCateNombre_log(
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where CateNombre_Id=deleted.CateNombre_Id)
 END
GO

 DROP TRIGGER sueCateNombreupd
GO

 CREATE TRIGGER sueCateNombreupd
ON sueCateNombre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueCateNombre_log(
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
CateNombre_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where CateNombre_Id=inserted.CateNombre_Id)
 END
GO

 DROP TRIGGER sueConcAcumins
GO

 CREATE TRIGGER sueConcAcumins
ON sueConcAcum
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConcAcum_log(
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
FechaModifLog,
TipoModificacion
)
(Select 
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
GETDATE(),
'ins'
FROM inserted where sueConcAcum=inserted.sueConcAcum)
 END
GO

 DROP TRIGGER sueConcAcumdel
GO

 CREATE TRIGGER sueConcAcumdel
ON sueConcAcum
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConcAcum_log(
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
FechaModifLog,
TipoModificacion
)
(Select 
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
GETDATE(),
'del'
FROM deleted where sueConcAcum=deleted.sueConcAcum)
 END
GO

 DROP TRIGGER sueConcAcumupd
GO

 CREATE TRIGGER sueConcAcumupd
ON sueConcAcum
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConcAcum_log(
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
FechaModifLog,
TipoModificacion
)
(Select 
sueConcAcum,
Concepto_Id,
Legajo,
Fecha,
MontoTope,
Descuento,
Acumulado,
Usuario_Id,
Anulado,
GETDATE(),
'upd'
FROM inserted where sueConcAcum=inserted.sueConcAcum)
 END
GO

 DROP TRIGGER sueConcAcumSegmentoins
GO

 CREATE TRIGGER sueConcAcumSegmentoins
ON sueConcAcumSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConcAcumSegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
GETDATE(),
'ins'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER sueConcAcumSegmentodel
GO

 CREATE TRIGGER sueConcAcumSegmentodel
ON sueConcAcumSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConcAcumSegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
GETDATE(),
'del'
FROM deleted where Segmento_Id=deleted.Segmento_Id)
 END
GO

 DROP TRIGGER sueConcAcumSegmentoupd
GO

 CREATE TRIGGER sueConcAcumSegmentoupd
ON sueConcAcumSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConcAcumSegmento_log(
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
FechaModifLog,
TipoModificacion
)
(Select 
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
Empresa_Id,
sueConcAcum,
GETDATE(),
'upd'
FROM inserted where Segmento_Id=inserted.Segmento_Id)
 END
GO

 DROP TRIGGER sueConcDescuentoins
GO

 CREATE TRIGGER sueConcDescuentoins
ON sueConcDescuento
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConcDescuento_log(
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueConcDescuentodel
GO

 CREATE TRIGGER sueConcDescuentodel
ON sueConcDescuento
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConcDescuento_log(
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER sueConcDescuentoupd
GO

 CREATE TRIGGER sueConcDescuentoupd
ON sueConcDescuento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConcDescuento_log(
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Concepto_Id,
sueLiquidacion,
sueConcAcum,
Monto,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueConceptosins
GO

 CREATE TRIGGER sueConceptosins
ON sueConceptos
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConceptos_log(
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
GETDATE(),
'ins'
FROM inserted where sueConceptos=inserted.sueConceptos)
 END
GO

 DROP TRIGGER sueConceptosdel
GO

 CREATE TRIGGER sueConceptosdel
ON sueConceptos
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConceptos_log(
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
GETDATE(),
'del'
FROM deleted where sueConceptos=deleted.sueConceptos)
 END
GO

 DROP TRIGGER sueConceptosupd
GO

 CREATE TRIGGER sueConceptosupd
ON sueConceptos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConceptos_log(
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptos,
Concepto_Id,
Descripcion,
Empresa_Id,
Formula,
LlevaDato,
CuentaDebe,
CuentaHaber,
SubCuentaDebe,
SubCuentaHaber,
Retroactivo,
Extraordinario,
TipoPercepcion,
TipoDeduccion,
TipoOtro,
TipoHora,
TipoIncapacidad,
EsExento,
Inactivo,
Posteado,
Usuario_Id,
Signo,
ColumnaRecibo,
GETDATE(),
'upd'
FROM inserted where sueConceptos=inserted.sueConceptos)
 END
GO

 DROP TRIGGER sueConceptosPropins
GO

 CREATE TRIGGER sueConceptosPropins
ON sueConceptosProp
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConceptosProp_log(
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
GETDATE(),
'ins'
FROM inserted where sueConceptosProp=inserted.sueConceptosProp)
 END
GO

 DROP TRIGGER sueConceptosPropdel
GO

 CREATE TRIGGER sueConceptosPropdel
ON sueConceptosProp
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConceptosProp_log(
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
GETDATE(),
'del'
FROM deleted where sueConceptosProp=deleted.sueConceptosProp)
 END
GO

 DROP TRIGGER sueConceptosPropupd
GO

 CREATE TRIGGER sueConceptosPropupd
ON sueConceptosProp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConceptosProp_log(
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
FechaModifLog,
TipoModificacion
)
(Select 
sueConceptosProp,
Propiedad,
Orden,
Descripcion,
Agrupamiento,
GETDATE(),
'upd'
FROM inserted where sueConceptosProp=inserted.sueConceptosProp)
 END
GO

 DROP TRIGGER sueConceptosPropValorins
GO

 CREATE TRIGGER sueConceptosPropValorins
ON sueConceptosPropValor
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConceptosPropValor_log(
Concepto_Id,
Propiedad,
SiNo,
FechaModifLog,
TipoModificacion
)
(Select 
Concepto_Id,
Propiedad,
SiNo,
GETDATE(),
'ins'
FROM inserted where Concepto_Id=inserted.Concepto_Id)
 END
GO

 DROP TRIGGER sueConceptosPropValordel
GO

 CREATE TRIGGER sueConceptosPropValordel
ON sueConceptosPropValor
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConceptosPropValor_log(
Concepto_Id,
Propiedad,
SiNo,
FechaModifLog,
TipoModificacion
)
(Select 
Concepto_Id,
Propiedad,
SiNo,
GETDATE(),
'del'
FROM deleted where Concepto_Id=deleted.Concepto_Id)
 END
GO

 DROP TRIGGER sueConceptosPropValorupd
GO

 CREATE TRIGGER sueConceptosPropValorupd
ON sueConceptosPropValor
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConceptosPropValor_log(
Concepto_Id,
Propiedad,
SiNo,
FechaModifLog,
TipoModificacion
)
(Select 
Concepto_Id,
Propiedad,
SiNo,
GETDATE(),
'upd'
FROM inserted where Concepto_Id=inserted.Concepto_Id)
 END
GO

 DROP TRIGGER sueConvenioins
GO

 CREATE TRIGGER sueConvenioins
ON sueConvenio
AFTER INSERT
AS
 BEGIN
INSERT INTO sueConvenio_log(
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
GETDATE(),
'ins'
FROM inserted where sueConvenio=inserted.sueConvenio)
 END
GO

 DROP TRIGGER sueConveniodel
GO

 CREATE TRIGGER sueConveniodel
ON sueConvenio
AFTER DELETE
AS
 BEGIN
INSERT INTO sueConvenio_log(
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
GETDATE(),
'del'
FROM deleted where sueConvenio=deleted.sueConvenio)
 END
GO

 DROP TRIGGER sueConvenioupd
GO

 CREATE TRIGGER sueConvenioupd
ON sueConvenio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueConvenio_log(
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
FechaModifLog,
TipoModificacion
)
(Select 
sueConvenio,
Convenio_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
TablaVac_Id,
Sindicalizdo,
GETDATE(),
'upd'
FROM inserted where sueConvenio=inserted.sueConvenio)
 END
GO

 DROP TRIGGER sueDatoins
GO

 CREATE TRIGGER sueDatoins
ON sueDato
AFTER INSERT
AS
 BEGIN
INSERT INTO sueDato_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueDatodel
GO

 CREATE TRIGGER sueDatodel
ON sueDato
AFTER DELETE
AS
 BEGIN
INSERT INTO sueDato_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueDatoupd
GO

 CREATE TRIGGER sueDatoupd
ON sueDato
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueDato_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Usuario_Id,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueDatoRetroins
GO

 CREATE TRIGGER sueDatoRetroins
ON sueDatoRetro
AFTER INSERT
AS
 BEGIN
INSERT INTO sueDatoRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueDatoRetrodel
GO

 CREATE TRIGGER sueDatoRetrodel
ON sueDatoRetro
AFTER DELETE
AS
 BEGIN
INSERT INTO sueDatoRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueDatoRetroupd
GO

 CREATE TRIGGER sueDatoRetroupd
ON sueDatoRetro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueDatoRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Dato,
Dato2,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueGananciasins
GO

 CREATE TRIGGER sueGananciasins
ON sueGanancias
AFTER INSERT
AS
 BEGIN
INSERT INTO sueGanancias_log(
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'ins'
FROM inserted where TabGan_Id=inserted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGananciasdel
GO

 CREATE TRIGGER sueGananciasdel
ON sueGanancias
AFTER DELETE
AS
 BEGIN
INSERT INTO sueGanancias_log(
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'del'
FROM deleted where TabGan_Id=deleted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGananciasupd
GO

 CREATE TRIGGER sueGananciasupd
ON sueGanancias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueGanancias_log(
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'upd'
FROM inserted where TabGan_Id=inserted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGanTituloins
GO

 CREATE TRIGGER sueGanTituloins
ON sueGanTitulo
AFTER INSERT
AS
 BEGIN
INSERT INTO sueGanTitulo_log(
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where TabGan_Id=inserted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGanTitulodel
GO

 CREATE TRIGGER sueGanTitulodel
ON sueGanTitulo
AFTER DELETE
AS
 BEGIN
INSERT INTO sueGanTitulo_log(
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where TabGan_Id=deleted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGanTituloupd
GO

 CREATE TRIGGER sueGanTituloupd
ON sueGanTitulo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueGanTitulo_log(
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
TabGan_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where TabGan_Id=inserted.TabGan_Id)
 END
GO

 DROP TRIGGER sueGruposins
GO

 CREATE TRIGGER sueGruposins
ON sueGrupos
AFTER INSERT
AS
 BEGIN
INSERT INTO sueGrupos_log(
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where sueGrupos=inserted.sueGrupos)
 END
GO

 DROP TRIGGER sueGruposdel
GO

 CREATE TRIGGER sueGruposdel
ON sueGrupos
AFTER DELETE
AS
 BEGIN
INSERT INTO sueGrupos_log(
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where sueGrupos=deleted.sueGrupos)
 END
GO

 DROP TRIGGER sueGruposupd
GO

 CREATE TRIGGER sueGruposupd
ON sueGrupos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueGrupos_log(
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueGrupos,
Grupo_Id,
Descripcion,
Empresa_Id,
Segmento_Id,
Periodo_Id,
CtaSueldoAPagar,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where sueGrupos=inserted.sueGrupos)
 END
GO

 DROP TRIGGER sueImpNombreins
GO

 CREATE TRIGGER sueImpNombreins
ON sueImpNombre
AFTER INSERT
AS
 BEGIN
INSERT INTO sueImpNombre_log(
Importe_Id,
Descripcion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Importe_Id,
Descripcion,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Importe_Id=inserted.Importe_Id)
 END
GO

 DROP TRIGGER sueImpNombredel
GO

 CREATE TRIGGER sueImpNombredel
ON sueImpNombre
AFTER DELETE
AS
 BEGIN
INSERT INTO sueImpNombre_log(
Importe_Id,
Descripcion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Importe_Id,
Descripcion,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Importe_Id=deleted.Importe_Id)
 END
GO

 DROP TRIGGER sueImpNombreupd
GO

 CREATE TRIGGER sueImpNombreupd
ON sueImpNombre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueImpNombre_log(
Importe_Id,
Descripcion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Importe_Id,
Descripcion,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Importe_Id=inserted.Importe_Id)
 END
GO

 DROP TRIGGER sueInfDefFormulasins
GO

 CREATE TRIGGER sueInfDefFormulasins
ON sueInfDefFormulas
AFTER INSERT
AS
 BEGIN
INSERT INTO sueInfDefFormulas_log(
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
GETDATE(),
'ins'
FROM inserted where sueInfDefinibles=inserted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueInfDefFormulasdel
GO

 CREATE TRIGGER sueInfDefFormulasdel
ON sueInfDefFormulas
AFTER DELETE
AS
 BEGIN
INSERT INTO sueInfDefFormulas_log(
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
GETDATE(),
'del'
FROM deleted where sueInfDefinibles=deleted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueInfDefFormulasupd
GO

 CREATE TRIGGER sueInfDefFormulasupd
ON sueInfDefFormulas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueInfDefFormulas_log(
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Columna,
Alias,
Titulo,
Formula,
Formato,
Ancho,
Orden,
Tipo,
GETDATE(),
'upd'
FROM inserted where sueInfDefinibles=inserted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueInfDefiniblesins
GO

 CREATE TRIGGER sueInfDefiniblesins
ON sueInfDefinibles
AFTER INSERT
AS
 BEGIN
INSERT INTO sueInfDefinibles_log(
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'ins'
FROM inserted where sueInfDefinibles=inserted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueInfDefiniblesdel
GO

 CREATE TRIGGER sueInfDefiniblesdel
ON sueInfDefinibles
AFTER DELETE
AS
 BEGIN
INSERT INTO sueInfDefinibles_log(
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'del'
FROM deleted where sueInfDefinibles=deleted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueInfDefiniblesupd
GO

 CREATE TRIGGER sueInfDefiniblesupd
ON sueInfDefinibles
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueInfDefinibles_log(
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueInfDefinibles,
Informe_Id,
Descripcion,
AgrupadoPor,
TamanioHoja,
Horizontal,
Um,
LegajoDesde,
LegajoHasta,
SucursalDesde,
SucursalHasta,
ConvenioDesde,
ConvenioHasta,
AnchoNombre,
Centro1Desde,
Centro1Hasta,
Centro2Desde,
Centro2Hasta,
Usuario_Id,
Empresa_Id,
Inactivo,
Posteado,
GETDATE(),
'upd'
FROM inserted where sueInfDefinibles=inserted.sueInfDefinibles)
 END
GO

 DROP TRIGGER sueLiqEmpCategoins
GO

 CREATE TRIGGER sueLiqEmpCategoins
ON sueLiqEmpCatego
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiqEmpCatego_log(
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Categoria_Id=inserted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqEmpCategodel
GO

 CREATE TRIGGER sueLiqEmpCategodel
ON sueLiqEmpCatego
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiqEmpCatego_log(
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Categoria_Id=deleted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqEmpCategoupd
GO

 CREATE TRIGGER sueLiqEmpCategoupd
ON sueLiqEmpCatego
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiqEmpCatego_log(
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Categoria_Id=inserted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqImpCategoins
GO

 CREATE TRIGGER sueLiqImpCategoins
ON sueLiqImpCatego
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiqImpCatego_log(
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Categoria_Id=inserted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqImpCategodel
GO

 CREATE TRIGGER sueLiqImpCategodel
ON sueLiqImpCatego
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiqImpCatego_log(
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Categoria_Id=deleted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqImpCategoupd
GO

 CREATE TRIGGER sueLiqImpCategoupd
ON sueLiqImpCatego
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiqImpCatego_log(
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Categoria_Id,
CateNombre_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Categoria_Id=inserted.Categoria_Id)
 END
GO

 DROP TRIGGER sueLiqPersImportesins
GO

 CREATE TRIGGER sueLiqPersImportesins
ON sueLiqPersImportes
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiqPersImportes_log(
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueLiqPersImportesdel
GO

 CREATE TRIGGER sueLiqPersImportesdel
ON sueLiqPersImportes
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiqPersImportes_log(
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER sueLiqPersImportesupd
GO

 CREATE TRIGGER sueLiqPersImportesupd
ON sueLiqPersImportes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiqPersImportes_log(
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Importe_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueLiquidacionins
GO

 CREATE TRIGGER sueLiquidacionins
ON sueLiquidacion
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiquidacion_log(
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueLiquidaciondel
GO

 CREATE TRIGGER sueLiquidaciondel
ON sueLiquidacion
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiquidacion_log(
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueLiquidacionupd
GO

 CREATE TRIGGER sueLiquidacionupd
ON sueLiquidacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiquidacion_log(
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Grupo_Id,
Descripcion,
FechaPago,
FechaDeposito,
PeriodoDeposito,
CtaSueldosAPagar,
FechaInicial,
FechaFinal,
Periodo_Id,
PorEmpleado,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaContabilizacion,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueLiqVarEmpGlobalesins
GO

 CREATE TRIGGER sueLiqVarEmpGlobalesins
ON sueLiqVarEmpGlobales
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiqVarEmpGlobales_log(
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueLiqVarEmpGlobalesdel
GO

 CREATE TRIGGER sueLiqVarEmpGlobalesdel
ON sueLiqVarEmpGlobales
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiqVarEmpGlobales_log(
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where VarGlobal_Id=deleted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueLiqVarEmpGlobalesupd
GO

 CREATE TRIGGER sueLiqVarEmpGlobalesupd
ON sueLiqVarEmpGlobales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiqVarEmpGlobales_log(
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Empresa_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueLiqVarGlobalesins
GO

 CREATE TRIGGER sueLiqVarGlobalesins
ON sueLiqVarGlobales
AFTER INSERT
AS
 BEGIN
INSERT INTO sueLiqVarGlobales_log(
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueLiqVarGlobalesdel
GO

 CREATE TRIGGER sueLiqVarGlobalesdel
ON sueLiqVarGlobales
AFTER DELETE
AS
 BEGIN
INSERT INTO sueLiqVarGlobales_log(
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where VarGlobal_Id=deleted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueLiqVarGlobalesupd
GO

 CREATE TRIGGER sueLiqVarGlobalesupd
ON sueLiqVarGlobales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueLiqVarGlobales_log(
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Fecha_Hasta,
Fecha_Desde,
Valor,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueMovContins
GO

 CREATE TRIGGER sueMovContins
ON sueMovCont
AFTER INSERT
AS
 BEGIN
INSERT INTO sueMovCont_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueMovContdel
GO

 CREATE TRIGGER sueMovContdel
ON sueMovCont
AFTER DELETE
AS
 BEGIN
INSERT INTO sueMovCont_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueMovContupd
GO

 CREATE TRIGGER sueMovContupd
ON sueMovCont
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueMovCont_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Importe,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueNominaCfdiins
GO

 CREATE TRIGGER sueNominaCfdiins
ON sueNominaCfdi
AFTER INSERT
AS
 BEGIN
INSERT INTO sueNominaCfdi_log(
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
FechaModifLog,
TipoModificacion
)
(Select 
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
GETDATE(),
'ins'
FROM inserted where Folio=inserted.Folio)
 END
GO

 DROP TRIGGER sueNominaCfdidel
GO

 CREATE TRIGGER sueNominaCfdidel
ON sueNominaCfdi
AFTER DELETE
AS
 BEGIN
INSERT INTO sueNominaCfdi_log(
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
FechaModifLog,
TipoModificacion
)
(Select 
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
GETDATE(),
'del'
FROM deleted where Folio=deleted.Folio)
 END
GO

 DROP TRIGGER sueNominaCfdiupd
GO

 CREATE TRIGGER sueNominaCfdiupd
ON sueNominaCfdi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueNominaCfdi_log(
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
FechaModifLog,
TipoModificacion
)
(Select 
Folio,
sueLiquidacion,
Legajo,
SelloDigital,
Xml,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
noCertificadoSAT,
Fecha,
Anulada,
RfcProvCertif,
Leyenda,
FechaCancelacion,
GETDATE(),
'upd'
FROM inserted where Folio=inserted.Folio)
 END
GO

 DROP TRIGGER suePagosHabiins
GO

 CREATE TRIGGER suePagosHabiins
ON suePagosHabi
AFTER INSERT
AS
 BEGIN
INSERT INTO suePagosHabi_log(
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePagosHabidel
GO

 CREATE TRIGGER suePagosHabidel
ON suePagosHabi
AFTER DELETE
AS
 BEGIN
INSERT INTO suePagosHabi_log(
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePagosHabiupd
GO

 CREATE TRIGGER suePagosHabiupd
ON suePagosHabi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePagosHabi_log(
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePagosHabiPorEmpleadoins
GO

 CREATE TRIGGER suePagosHabiPorEmpleadoins
ON suePagosHabiPorEmpleado
AFTER INSERT
AS
 BEGIN
INSERT INTO suePagosHabiPorEmpleado_log(
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePagosHabiPorEmpleadodel
GO

 CREATE TRIGGER suePagosHabiPorEmpleadodel
ON suePagosHabiPorEmpleado
AFTER DELETE
AS
 BEGIN
INSERT INTO suePagosHabiPorEmpleado_log(
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePagosHabiPorEmpleadoupd
GO

 CREATE TRIGGER suePagosHabiPorEmpleadoupd
ON suePagosHabiPorEmpleado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePagosHabiPorEmpleado_log(
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Secuencia,
Legajo,
tesMovimientos,
FechaHabilitacion,
Importe,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER suePeriodicidadins
GO

 CREATE TRIGGER suePeriodicidadins
ON suePeriodicidad
AFTER INSERT
AS
 BEGIN
INSERT INTO suePeriodicidad_log(
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
GETDATE(),
'ins'
FROM inserted where Periodo_Id=inserted.Periodo_Id)
 END
GO

 DROP TRIGGER suePeriodicidaddel
GO

 CREATE TRIGGER suePeriodicidaddel
ON suePeriodicidad
AFTER DELETE
AS
 BEGIN
INSERT INTO suePeriodicidad_log(
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
GETDATE(),
'del'
FROM deleted where Periodo_Id=deleted.Periodo_Id)
 END
GO

 DROP TRIGGER suePeriodicidadupd
GO

 CREATE TRIGGER suePeriodicidadupd
ON suePeriodicidad
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePeriodicidad_log(
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
FechaModifLog,
TipoModificacion
)
(Select 
Periodo_Id,
Descripcion,
Dias,
Empresa_Id,
FechaActiva,
CodFiscal,
GETDATE(),
'upd'
FROM inserted where Periodo_Id=inserted.Periodo_Id)
 END
GO

 DROP TRIGGER suePeriodosSugeridosins
GO

 CREATE TRIGGER suePeriodosSugeridosins
ON suePeriodosSugeridos
AFTER INSERT
AS
 BEGIN
INSERT INTO suePeriodosSugeridos_log(
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER suePeriodosSugeridosdel
GO

 CREATE TRIGGER suePeriodosSugeridosdel
ON suePeriodosSugeridos
AFTER DELETE
AS
 BEGIN
INSERT INTO suePeriodosSugeridos_log(
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER suePeriodosSugeridosupd
GO

 CREATE TRIGGER suePeriodosSugeridosupd
ON suePeriodosSugeridos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePeriodosSugeridos_log(
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Anio,
Mes,
Quincena,
Semana,
Decena,
Vez,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER suePersActividadins
GO

 CREATE TRIGGER suePersActividadins
ON suePersActividad
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersActividad_log(
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersActividaddel
GO

 CREATE TRIGGER suePersActividaddel
ON suePersActividad
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersActividad_log(
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersActividadupd
GO

 CREATE TRIGGER suePersActividadupd
ON suePersActividad
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersActividad_log(
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Actividad_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersAforeins
GO

 CREATE TRIGGER suePersAforeins
ON suePersAfore
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersAfore_log(
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersAforedel
GO

 CREATE TRIGGER suePersAforedel
ON suePersAfore
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersAfore_log(
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersAforeupd
GO

 CREATE TRIGGER suePersAforeupd
ON suePersAfore
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersAfore_log(
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Afore_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersCategoins
GO

 CREATE TRIGGER suePersCategoins
ON suePersCatego
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersCatego_log(
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersCategodel
GO

 CREATE TRIGGER suePersCategodel
ON suePersCatego
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersCatego_log(
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersCategoupd
GO

 CREATE TRIGGER suePersCategoupd
ON suePersCatego
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersCatego_log(
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Categoria_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersCondServicioins
GO

 CREATE TRIGGER suePersCondServicioins
ON suePersCondServicio
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersCondServicio_log(
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersCondServiciodel
GO

 CREATE TRIGGER suePersCondServiciodel
ON suePersCondServicio
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersCondServicio_log(
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersCondServicioupd
GO

 CREATE TRIGGER suePersCondServicioupd
ON suePersCondServicio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersCondServicio_log(
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
CondServicio_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersContableins
GO

 CREATE TRIGGER suePersContableins
ON suePersContable
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersContable_log(
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersContabledel
GO

 CREATE TRIGGER suePersContabledel
ON suePersContable
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersContable_log(
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersContableupd
GO

 CREATE TRIGGER suePersContableupd
ON suePersContable
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersContable_log(
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersContableDatosins
GO

 CREATE TRIGGER suePersContableDatosins
ON suePersContableDatos
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersContableDatos_log(
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersContableDatosdel
GO

 CREATE TRIGGER suePersContableDatosdel
ON suePersContableDatos
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersContableDatos_log(
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersContableDatosupd
GO

 CREATE TRIGGER suePersContableDatosupd
ON suePersContableDatos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersContableDatos_log(
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Porcentaje,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersConvenioins
GO

 CREATE TRIGGER suePersConvenioins
ON suePersConvenio
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersConvenio_log(
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersConveniodel
GO

 CREATE TRIGGER suePersConveniodel
ON suePersConvenio
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersConvenio_log(
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersConvenioupd
GO

 CREATE TRIGGER suePersConvenioupd
ON suePersConvenio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersConvenio_log(
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Convenio_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersDomicilioins
GO

 CREATE TRIGGER suePersDomicilioins
ON suePersDomicilio
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersDomicilio_log(
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersDomiciliodel
GO

 CREATE TRIGGER suePersDomiciliodel
ON suePersDomicilio
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersDomicilio_log(
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersDomicilioupd
GO

 CREATE TRIGGER suePersDomicilioupd
ON suePersDomicilio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersDomicilio_log(
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
EntreCalle1,
EntreCalle2,
Provincia_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersEstadoCivilins
GO

 CREATE TRIGGER suePersEstadoCivilins
ON suePersEstadoCivil
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersEstadoCivil_log(
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersEstadoCivildel
GO

 CREATE TRIGGER suePersEstadoCivildel
ON suePersEstadoCivil
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersEstadoCivil_log(
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersEstadoCivilupd
GO

 CREATE TRIGGER suePersEstadoCivilupd
ON suePersEstadoCivil
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersEstadoCivil_log(
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
EstadoCivil_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersLocalidadins
GO

 CREATE TRIGGER suePersLocalidadins
ON suePersLocalidad
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersLocalidad_log(
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersLocalidaddel
GO

 CREATE TRIGGER suePersLocalidaddel
ON suePersLocalidad
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersLocalidad_log(
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersLocalidadupd
GO

 CREATE TRIGGER suePersLocalidadupd
ON suePersLocalidad
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersLocalidad_log(
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Localidad_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersModContratains
GO

 CREATE TRIGGER suePersModContratains
ON suePersModContrata
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersModContrata_log(
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersModContratadel
GO

 CREATE TRIGGER suePersModContratadel
ON suePersModContrata
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersModContrata_log(
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersModContrataupd
GO

 CREATE TRIGGER suePersModContrataupd
ON suePersModContrata
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersModContrata_log(
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Modalidad_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersonalins
GO

 CREATE TRIGGER suePersonalins
ON suePersonal
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersonal_log(
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER suePersonaldel
GO

 CREATE TRIGGER suePersonaldel
ON suePersonal
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersonal_log(
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER suePersonalupd
GO

 CREATE TRIGGER suePersonalupd
ON suePersonal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersonal_log(
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Legajo,
Empresa_Id,
Nombres,
ApellidoPaterno,
ApellidoMaterno,
NumeroDoc,
NroSegSocial,
Telefonos,
Celular,
FechaNacimiento,
Sexo,
Nacionalidad_Id,
CodigoNatural,
eMail,
FechaIngreso,
FechaBaja,
AniosReconocidos,
MesesReconocidos,
GrupoSanguineo,
RH,
BancoSucursal,
BancoCuenta,
BancoTipoCta,
CuentaInactiva,
ClaveBancaria,
Observaciones,
UMF,
AvisarA,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER suePersonalInfoins
GO

 CREATE TRIGGER suePersonalInfoins
ON suePersonalInfo
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersonalInfo_log(
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersonalInfodel
GO

 CREATE TRIGGER suePersonalInfodel
ON suePersonalInfo
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersonalInfo_log(
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersonalInfoupd
GO

 CREATE TRIGGER suePersonalInfoupd
ON suePersonalInfo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersonalInfo_log(
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
NroCreditoInfonavit,
TipoDescuento,
Fecha,
ValorDescuento,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersPuestosins
GO

 CREATE TRIGGER suePersPuestosins
ON suePersPuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersPuestos_log(
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersPuestosdel
GO

 CREATE TRIGGER suePersPuestosdel
ON suePersPuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersPuestos_log(
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersPuestosupd
GO

 CREATE TRIGGER suePersPuestosupd
ON suePersPuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersPuestos_log(
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Puesto_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSiniestradoins
GO

 CREATE TRIGGER suePersSiniestradoins
ON suePersSiniestrado
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersSiniestrado_log(
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSiniestradodel
GO

 CREATE TRIGGER suePersSiniestradodel
ON suePersSiniestrado
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersSiniestrado_log(
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersSiniestradoupd
GO

 CREATE TRIGGER suePersSiniestradoupd
ON suePersSiniestrado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersSiniestrado_log(
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Siniestro_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSituacionReviins
GO

 CREATE TRIGGER suePersSituacionReviins
ON suePersSituacionRevi
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersSituacionRevi_log(
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSituacionRevidel
GO

 CREATE TRIGGER suePersSituacionRevidel
ON suePersSituacionRevi
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersSituacionRevi_log(
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersSituacionReviupd
GO

 CREATE TRIGGER suePersSituacionReviupd
ON suePersSituacionRevi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersSituacionRevi_log(
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Situacion_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSucursalins
GO

 CREATE TRIGGER suePersSucursalins
ON suePersSucursal
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersSucursal_log(
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersSucursaldel
GO

 CREATE TRIGGER suePersSucursaldel
ON suePersSucursal
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersSucursal_log(
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersSucursalupd
GO

 CREATE TRIGGER suePersSucursalupd
ON suePersSucursal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersSucursal_log(
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
Sucursal,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoContratoins
GO

 CREATE TRIGGER suePersTipoContratoins
ON suePersTipoContrato
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoContrato_log(
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoContratodel
GO

 CREATE TRIGGER suePersTipoContratodel
ON suePersTipoContrato
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoContrato_log(
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoContratoupd
GO

 CREATE TRIGGER suePersTipoContratoupd
ON suePersTipoContrato
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoContrato_log(
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoContrato,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoEmpleadorins
GO

 CREATE TRIGGER suePersTipoEmpleadorins
ON suePersTipoEmpleador
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoEmpleador_log(
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoEmpleadordel
GO

 CREATE TRIGGER suePersTipoEmpleadordel
ON suePersTipoEmpleador
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoEmpleador_log(
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoEmpleadorupd
GO

 CREATE TRIGGER suePersTipoEmpleadorupd
ON suePersTipoEmpleador
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoEmpleador_log(
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoEmpleador_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoJornadains
GO

 CREATE TRIGGER suePersTipoJornadains
ON suePersTipoJornada
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoJornada_log(
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoJornadadel
GO

 CREATE TRIGGER suePersTipoJornadadel
ON suePersTipoJornada
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoJornada_log(
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoJornadaupd
GO

 CREATE TRIGGER suePersTipoJornadaupd
ON suePersTipoJornada
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoJornada_log(
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoJornada,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoPagoins
GO

 CREATE TRIGGER suePersTipoPagoins
ON suePersTipoPago
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoPago_log(
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoPagodel
GO

 CREATE TRIGGER suePersTipoPagodel
ON suePersTipoPago
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoPago_log(
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoPagoupd
GO

 CREATE TRIGGER suePersTipoPagoupd
ON suePersTipoPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoPago_log(
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoPago_Id,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoRegimenins
GO

 CREATE TRIGGER suePersTipoRegimenins
ON suePersTipoRegimen
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoRegimen_log(
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoRegimendel
GO

 CREATE TRIGGER suePersTipoRegimendel
ON suePersTipoRegimen
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoRegimen_log(
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoRegimenupd
GO

 CREATE TRIGGER suePersTipoRegimenupd
ON suePersTipoRegimen
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoRegimen_log(
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoRegimen,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoSDIins
GO

 CREATE TRIGGER suePersTipoSDIins
ON suePersTipoSDI
AFTER INSERT
AS
 BEGIN
INSERT INTO suePersTipoSDI_log(
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoSDIdel
GO

 CREATE TRIGGER suePersTipoSDIdel
ON suePersTipoSDI
AFTER DELETE
AS
 BEGIN
INSERT INTO suePersTipoSDI_log(
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER suePersTipoSDIupd
GO

 CREATE TRIGGER suePersTipoSDIupd
ON suePersTipoSDI
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePersTipoSDI_log(
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
FechaDesde,
FechaHasta,
TipoSDI,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER suePlantillains
GO

 CREATE TRIGGER suePlantillains
ON suePlantilla
AFTER INSERT
AS
 BEGIN
INSERT INTO suePlantilla_log(
Centro1_Id,
Puesto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Centro1_Id,
Puesto_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where Centro1_Id=inserted.Centro1_Id)
 END
GO

 DROP TRIGGER suePlantilladel
GO

 CREATE TRIGGER suePlantilladel
ON suePlantilla
AFTER DELETE
AS
 BEGIN
INSERT INTO suePlantilla_log(
Centro1_Id,
Puesto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Centro1_Id,
Puesto_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where Centro1_Id=deleted.Centro1_Id)
 END
GO

 DROP TRIGGER suePlantillaupd
GO

 CREATE TRIGGER suePlantillaupd
ON suePlantilla
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePlantilla_log(
Centro1_Id,
Puesto_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
Centro1_Id,
Puesto_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where Centro1_Id=inserted.Centro1_Id)
 END
GO

 DROP TRIGGER suePuestosins
GO

 CREATE TRIGGER suePuestosins
ON suePuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO suePuestos_log(
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where suePuestos=inserted.suePuestos)
 END
GO

 DROP TRIGGER suePuestosdel
GO

 CREATE TRIGGER suePuestosdel
ON suePuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO suePuestos_log(
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where suePuestos=deleted.suePuestos)
 END
GO

 DROP TRIGGER suePuestosupd
GO

 CREATE TRIGGER suePuestosupd
ON suePuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO suePuestos_log(
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
suePuestos,
Puesto_Id,
Descripcion,
Empresa_Id,
RiesgoPuesto,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where suePuestos=inserted.suePuestos)
 END
GO

 DROP TRIGGER sueTablains
GO

 CREATE TRIGGER sueTablains
ON sueTabla
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTabla_log(
Fila,
Tabla_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Fila,
Tabla_Id,
Valor,
GETDATE(),
'ins'
FROM inserted where Fila=inserted.Fila)
 END
GO

 DROP TRIGGER sueTabladel
GO

 CREATE TRIGGER sueTabladel
ON sueTabla
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTabla_log(
Fila,
Tabla_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Fila,
Tabla_Id,
Valor,
GETDATE(),
'del'
FROM deleted where Fila=deleted.Fila)
 END
GO

 DROP TRIGGER sueTablaupd
GO

 CREATE TRIGGER sueTablaupd
ON sueTabla
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTabla_log(
Fila,
Tabla_Id,
Valor,
FechaModifLog,
TipoModificacion
)
(Select 
Fila,
Tabla_Id,
Valor,
GETDATE(),
'upd'
FROM inserted where Fila=inserted.Fila)
 END
GO

 DROP TRIGGER sueTablaVacacionins
GO

 CREATE TRIGGER sueTablaVacacionins
ON sueTablaVacacion
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTablaVacacion_log(
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'ins'
FROM inserted where sueTablaVacacion=inserted.sueTablaVacacion)
 END
GO

 DROP TRIGGER sueTablaVacaciondel
GO

 CREATE TRIGGER sueTablaVacaciondel
ON sueTablaVacacion
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTablaVacacion_log(
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'del'
FROM deleted where sueTablaVacacion=deleted.sueTablaVacacion)
 END
GO

 DROP TRIGGER sueTablaVacacionupd
GO

 CREATE TRIGGER sueTablaVacacionupd
ON sueTablaVacacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTablaVacacion_log(
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
sueTablaVacacion,
TablaVac_Id,
Descripcion,
Dias,
Empresa_Id,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'upd'
FROM inserted where sueTablaVacacion=inserted.sueTablaVacacion)
 END
GO

 DROP TRIGGER sueTablaVacRengins
GO

 CREATE TRIGGER sueTablaVacRengins
ON sueTablaVacReng
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTablaVacReng_log(
TablaVac_Id,
Antiguedad,
Dias,
FechaModifLog,
TipoModificacion
)
(Select 
TablaVac_Id,
Antiguedad,
Dias,
GETDATE(),
'ins'
FROM inserted where TablaVac_Id=inserted.TablaVac_Id)
 END
GO

 DROP TRIGGER sueTablaVacRengdel
GO

 CREATE TRIGGER sueTablaVacRengdel
ON sueTablaVacReng
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTablaVacReng_log(
TablaVac_Id,
Antiguedad,
Dias,
FechaModifLog,
TipoModificacion
)
(Select 
TablaVac_Id,
Antiguedad,
Dias,
GETDATE(),
'del'
FROM deleted where TablaVac_Id=deleted.TablaVac_Id)
 END
GO

 DROP TRIGGER sueTablaVacRengupd
GO

 CREATE TRIGGER sueTablaVacRengupd
ON sueTablaVacReng
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTablaVacReng_log(
TablaVac_Id,
Antiguedad,
Dias,
FechaModifLog,
TipoModificacion
)
(Select 
TablaVac_Id,
Antiguedad,
Dias,
GETDATE(),
'upd'
FROM inserted where TablaVac_Id=inserted.TablaVac_Id)
 END
GO

 DROP TRIGGER sueTabTituloins
GO

 CREATE TRIGGER sueTabTituloins
ON sueTabTitulo
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTabTitulo_log(
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER sueTabTitulodel
GO

 CREATE TRIGGER sueTabTitulodel
ON sueTabTitulo
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTabTitulo_log(
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where Tabla_Id=deleted.Tabla_Id)
 END
GO

 DROP TRIGGER sueTabTituloupd
GO

 CREATE TRIGGER sueTabTituloupd
ON sueTabTitulo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTabTitulo_log(
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Descripcion,
Usuario_Id,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER sueTerminadains
GO

 CREATE TRIGGER sueTerminadains
ON sueTerminada
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTerminada_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTerminadadel
GO

 CREATE TRIGGER sueTerminadadel
ON sueTerminada
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTerminada_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTerminadaupd
GO

 CREATE TRIGGER sueTerminadaupd
ON sueTerminada
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTerminada_log(
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
Dato,
Dato2,
Importe,
Signo,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTerminadaRetroins
GO

 CREATE TRIGGER sueTerminadaRetroins
ON sueTerminadaRetro
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTerminadaRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
GETDATE(),
'ins'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTerminadaRetrodel
GO

 CREATE TRIGGER sueTerminadaRetrodel
ON sueTerminadaRetro
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTerminadaRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
GETDATE(),
'del'
FROM deleted where sueLiquidacion=deleted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTerminadaRetroupd
GO

 CREATE TRIGGER sueTerminadaRetroupd
ON sueTerminadaRetro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTerminadaRetro_log(
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
sueLiquidacion,
Legajo,
Concepto_Id,
AnioRetro,
MesRetro,
Importe,
GETDATE(),
'upd'
FROM inserted where sueLiquidacion=inserted.sueLiquidacion)
 END
GO

 DROP TRIGGER sueTipoPagoins
GO

 CREATE TRIGGER sueTipoPagoins
ON sueTipoPago
AFTER INSERT
AS
 BEGIN
INSERT INTO sueTipoPago_log(
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where sueTipoPago=inserted.sueTipoPago)
 END
GO

 DROP TRIGGER sueTipoPagodel
GO

 CREATE TRIGGER sueTipoPagodel
ON sueTipoPago
AFTER DELETE
AS
 BEGIN
INSERT INTO sueTipoPago_log(
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where sueTipoPago=deleted.sueTipoPago)
 END
GO

 DROP TRIGGER sueTipoPagoupd
GO

 CREATE TRIGGER sueTipoPagoupd
ON sueTipoPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueTipoPago_log(
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
sueTipoPago,
TipoPago_Id,
Descripcion,
Empresa_Id,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where sueTipoPago=inserted.sueTipoPago)
 END
GO

 DROP TRIGGER sueVacCorrespondenins
GO

 CREATE TRIGGER sueVacCorrespondenins
ON sueVacCorresponden
AFTER INSERT
AS
 BEGIN
INSERT INTO sueVacCorresponden_log(
Legajo,
Anio,
Dias,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
Dias,
Saldo,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueVacCorrespondendel
GO

 CREATE TRIGGER sueVacCorrespondendel
ON sueVacCorresponden
AFTER DELETE
AS
 BEGIN
INSERT INTO sueVacCorresponden_log(
Legajo,
Anio,
Dias,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
Dias,
Saldo,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER sueVacCorrespondenupd
GO

 CREATE TRIGGER sueVacCorrespondenupd
ON sueVacCorresponden
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueVacCorresponden_log(
Legajo,
Anio,
Dias,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
Dias,
Saldo,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueVacTomadasins
GO

 CREATE TRIGGER sueVacTomadasins
ON sueVacTomadas
AFTER INSERT
AS
 BEGIN
INSERT INTO sueVacTomadas_log(
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueVacTomadasdel
GO

 CREATE TRIGGER sueVacTomadasdel
ON sueVacTomadas
AFTER DELETE
AS
 BEGIN
INSERT INTO sueVacTomadas_log(
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER sueVacTomadasupd
GO

 CREATE TRIGGER sueVacTomadasupd
ON sueVacTomadas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueVacTomadas_log(
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Anio,
FechaDesde,
Dias,
FechaHasta,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueVarGlobalesins
GO

 CREATE TRIGGER sueVarGlobalesins
ON sueVarGlobales
AFTER INSERT
AS
 BEGIN
INSERT INTO sueVarGlobales_log(
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueVarGlobalesdel
GO

 CREATE TRIGGER sueVarGlobalesdel
ON sueVarGlobales
AFTER DELETE
AS
 BEGIN
INSERT INTO sueVarGlobales_log(
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where VarGlobal_Id=deleted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueVarGlobalesupd
GO

 CREATE TRIGGER sueVarGlobalesupd
ON sueVarGlobales
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueVarGlobales_log(
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
VarGlobal_Id,
Descripcion,
PorEmpresa,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where VarGlobal_Id=inserted.VarGlobal_Id)
 END
GO

 DROP TRIGGER sueVariableins
GO

 CREATE TRIGGER sueVariableins
ON sueVariable
AFTER INSERT
AS
 BEGIN
INSERT INTO sueVariable_log(
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
GETDATE(),
'ins'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER sueVariabledel
GO

 CREATE TRIGGER sueVariabledel
ON sueVariable
AFTER DELETE
AS
 BEGIN
INSERT INTO sueVariable_log(
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
GETDATE(),
'del'
FROM deleted where Legajo=deleted.Legajo)
 END
GO

 DROP TRIGGER sueVariableupd
GO

 CREATE TRIGGER sueVariableupd
ON sueVariable
AFTER  UPDATE
AS
 BEGIN
INSERT INTO sueVariable_log(
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
FechaModifLog,
TipoModificacion
)
(Select 
Legajo,
Grupo_Id,
Concepto_Id,
Usuario_Id,
FechaRegistro,
GETDATE(),
'upd'
FROM inserted where Legajo=inserted.Legajo)
 END
GO

 DROP TRIGGER tesAIChequesins
GO

 CREATE TRIGGER tesAIChequesins
ON tesAICheques
AFTER INSERT
AS
 BEGIN
INSERT INTO tesAICheques_log(
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAIChequesdel
GO

 CREATE TRIGGER tesAIChequesdel
ON tesAICheques
AFTER DELETE
AS
 BEGIN
INSERT INTO tesAICheques_log(
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAIChequesupd
GO

 CREATE TRIGGER tesAIChequesupd
ON tesAICheques
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesAICheques_log(
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
FechaVencimiento,
Chequera_Id,
numCheque,
AlaOrden,
Importe,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAIDepositosins
GO

 CREATE TRIGGER tesAIDepositosins
ON tesAIDepositos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesAIDepositos_log(
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAIDepositosdel
GO

 CREATE TRIGGER tesAIDepositosdel
ON tesAIDepositos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesAIDepositos_log(
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAIDepositosupd
GO

 CREATE TRIGGER tesAIDepositosupd
ON tesAIDepositos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesAIDepositos_log(
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
Renglon,
CarteraCheq_Id,
numCheque,
FechaVencimiento,
Importe,
Clearing,
Banco_Id,
Cliente_Id,
cuentaBanco,
sucBanco,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAISaldosins
GO

 CREATE TRIGGER tesAISaldosins
ON tesAISaldos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesAISaldos_log(
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAISaldosdel
GO

 CREATE TRIGGER tesAISaldosdel
ON tesAISaldos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesAISaldos_log(
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesAISaldosupd
GO

 CREATE TRIGGER tesAISaldosupd
ON tesAISaldos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesAISaldos_log(
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Empresa_Id,
SaldoInicial,
Cambio,
Usuario_Id,
FechaRegistro,
Confirmado,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesBancosins
GO

 CREATE TRIGGER tesBancosins
ON tesBancos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesBancos_log(
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
FechaModifLog,
TipoModificacion
)
(Select 
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
GETDATE(),
'ins'
FROM inserted where tesBancos=inserted.tesBancos)
 END
GO

 DROP TRIGGER tesBancosdel
GO

 CREATE TRIGGER tesBancosdel
ON tesBancos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesBancos_log(
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
FechaModifLog,
TipoModificacion
)
(Select 
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
GETDATE(),
'del'
FROM deleted where tesBancos=deleted.tesBancos)
 END
GO

 DROP TRIGGER tesBancosupd
GO

 CREATE TRIGGER tesBancosupd
ON tesBancos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesBancos_log(
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
FechaModifLog,
TipoModificacion
)
(Select 
tesBancos,
Banco_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
RFC,
GETDATE(),
'upd'
FROM inserted where tesBancos=inserted.tesBancos)
 END
GO

 DROP TRIGGER tesBPlinkins
GO

 CREATE TRIGGER tesBPlinkins
ON tesBPlink
AFTER INSERT
AS
 BEGIN
INSERT INTO tesBPlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesBPlinkdel
GO

 CREATE TRIGGER tesBPlinkdel
ON tesBPlink
AFTER DELETE
AS
 BEGIN
INSERT INTO tesBPlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesBPlinkupd
GO

 CREATE TRIGGER tesBPlinkupd
ON tesBPlink
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesBPlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqProp,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesCausasRechazoins
GO

 CREATE TRIGGER tesCausasRechazoins
ON tesCausasRechazo
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCausasRechazo_log(
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where tesCausasRechazo=inserted.tesCausasRechazo)
 END
GO

 DROP TRIGGER tesCausasRechazodel
GO

 CREATE TRIGGER tesCausasRechazodel
ON tesCausasRechazo
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCausasRechazo_log(
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where tesCausasRechazo=deleted.tesCausasRechazo)
 END
GO

 DROP TRIGGER tesCausasRechazoupd
GO

 CREATE TRIGGER tesCausasRechazoupd
ON tesCausasRechazo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCausasRechazo_log(
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCausasRechazo,
Causa_Id,
Descripcion,
Empresa_Id,
FechaModificacion,
Posteado,
Inactivo,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where tesCausasRechazo=inserted.tesCausasRechazo)
 END
GO

 DROP TRIGGER tesCFDICobranzains
GO

 CREATE TRIGGER tesCFDICobranzains
ON tesCFDICobranza
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCFDICobranza_log(
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
GETDATE(),
'ins'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzadel
GO

 CREATE TRIGGER tesCFDICobranzadel
ON tesCFDICobranza
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCFDICobranza_log(
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
GETDATE(),
'del'
FROM deleted where tesCFDICobranza=deleted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaupd
GO

 CREATE TRIGGER tesCFDICobranzaupd
ON tesCFDICobranza
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCFDICobranza_log(
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
Cliente_Id,
Moneda_Id,
Fecha,
SelloDigital,
Xml,
Cadena,
NoCertificado,
UUID,
FechaTimbrado,
SelloSat,
NoCertificadoSat,
RfcProvCertif,
Leyenda,
Anulada,
Sucursal,
FechaCancelacion,
UsuarioCanc_Id,
GETDATE(),
'upd'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaCuerpoins
GO

 CREATE TRIGGER tesCFDICobranzaCuerpoins
ON tesCFDICobranzaCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCFDICobranzaCuerpo_log(
tesCFDICobranza,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesMovimientos,
GETDATE(),
'ins'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaCuerpodel
GO

 CREATE TRIGGER tesCFDICobranzaCuerpodel
ON tesCFDICobranzaCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCFDICobranzaCuerpo_log(
tesCFDICobranza,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesMovimientos,
GETDATE(),
'del'
FROM deleted where tesCFDICobranza=deleted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaCuerpoupd
GO

 CREATE TRIGGER tesCFDICobranzaCuerpoupd
ON tesCFDICobranzaCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCFDICobranzaCuerpo_log(
tesCFDICobranza,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesMovimientos,
GETDATE(),
'upd'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaRelins
GO

 CREATE TRIGGER tesCFDICobranzaRelins
ON tesCFDICobranzaRel
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCFDICobranzaRel_log(
tesCFDICobranza,
tesCFDICobranzaR,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesCFDICobranzaR,
GETDATE(),
'ins'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaReldel
GO

 CREATE TRIGGER tesCFDICobranzaReldel
ON tesCFDICobranzaRel
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCFDICobranzaRel_log(
tesCFDICobranza,
tesCFDICobranzaR,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesCFDICobranzaR,
GETDATE(),
'del'
FROM deleted where tesCFDICobranza=deleted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaRelupd
GO

 CREATE TRIGGER tesCFDICobranzaRelupd
ON tesCFDICobranzaRel
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCFDICobranzaRel_log(
tesCFDICobranza,
tesCFDICobranzaR,
FechaModifLog,
TipoModificacion
)
(Select 
tesCFDICobranza,
tesCFDICobranzaR,
GETDATE(),
'upd'
FROM inserted where tesCFDICobranza=inserted.tesCFDICobranza)
 END
GO

 DROP TRIGGER tesCFDICobranzaSegmentosins
GO

 CREATE TRIGGER tesCFDICobranzaSegmentosins
ON tesCFDICobranzaSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCFDICobranzaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesCFDICobranzaSegmentosdel
GO

 CREATE TRIGGER tesCFDICobranzaSegmentosdel
ON tesCFDICobranzaSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCFDICobranzaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER tesCFDICobranzaSegmentosupd
GO

 CREATE TRIGGER tesCFDICobranzaSegmentosupd
ON tesCFDICobranzaSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCFDICobranzaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesCFDICobranza,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesCheqPropins
GO

 CREATE TRIGGER tesCheqPropins
ON tesCheqProp
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCheqProp_log(
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
GETDATE(),
'ins'
FROM inserted where tesCheqProp=inserted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropdel
GO

 CREATE TRIGGER tesCheqPropdel
ON tesCheqProp
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCheqProp_log(
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
GETDATE(),
'del'
FROM deleted where tesCheqProp=deleted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropupd
GO

 CREATE TRIGGER tesCheqPropupd
ON tesCheqProp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCheqProp_log(
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Empresa_Id,
Cartera_Id,
Chequera_Id,
numCheque,
FechaVencimiento,
FechaDebito,
aLaOrden,
Estado_Id,
SecuenciaActual,
Cuit,
CuentaDestino,
BancoDestino,
BancoDestinoExt,
GETDATE(),
'upd'
FROM inserted where tesCheqProp=inserted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropAnulins
GO

 CREATE TRIGGER tesCheqPropAnulins
ON tesCheqPropAnul
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCheqPropAnul_log(
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where tesCheqProp=inserted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropAnuldel
GO

 CREATE TRIGGER tesCheqPropAnuldel
ON tesCheqPropAnul
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCheqPropAnul_log(
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where tesCheqProp=deleted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropAnulupd
GO

 CREATE TRIGGER tesCheqPropAnulupd
ON tesCheqPropAnul
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCheqPropAnul_log(
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqProp,
Fecha_Anul,
Observaciones,
Importe,
FechaOriginal,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where tesCheqProp=inserted.tesCheqProp)
 END
GO

 DROP TRIGGER tesCheqPropEstadoins
GO

 CREATE TRIGGER tesCheqPropEstadoins
ON tesCheqPropEstado
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCheqPropEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesCheqPropEstadodel
GO

 CREATE TRIGGER tesCheqPropEstadodel
ON tesCheqPropEstado
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCheqPropEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Estado_Id=deleted.Estado_Id)
 END
GO

 DROP TRIGGER tesCheqPropEstadoupd
GO

 CREATE TRIGGER tesCheqPropEstadoupd
ON tesCheqPropEstado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCheqPropEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesCheqTercerosins
GO

 CREATE TRIGGER tesCheqTercerosins
ON tesCheqTerceros
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCheqTerceros_log(
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
GETDATE(),
'ins'
FROM inserted where tesCheqTerceros=inserted.tesCheqTerceros)
 END
GO

 DROP TRIGGER tesCheqTercerosdel
GO

 CREATE TRIGGER tesCheqTercerosdel
ON tesCheqTerceros
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCheqTerceros_log(
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
GETDATE(),
'del'
FROM deleted where tesCheqTerceros=deleted.tesCheqTerceros)
 END
GO

 DROP TRIGGER tesCheqTercerosupd
GO

 CREATE TRIGGER tesCheqTercerosupd
ON tesCheqTerceros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCheqTerceros_log(
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
FechaModifLog,
TipoModificacion
)
(Select 
tesCheqTerceros,
Empresa_Id,
Cartera_Id,
Banco_Id,
Clearing,
SecuenciaActual,
ClearingDias,
FechaVencimiento,
FechaAcreditacion,
FechaConciliacion,
sucBanco,
numCheque,
Estado_Id,
Cliente_Id,
cuentaBanco,
BancoConc,
NumeroConc,
BancoConcVta,
NumeroConcVta,
GETDATE(),
'upd'
FROM inserted where tesCheqTerceros=inserted.tesCheqTerceros)
 END
GO

 DROP TRIGGER tesCheqTerEstadoins
GO

 CREATE TRIGGER tesCheqTerEstadoins
ON tesCheqTerEstado
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCheqTerEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesCheqTerEstadodel
GO

 CREATE TRIGGER tesCheqTerEstadodel
ON tesCheqTerEstado
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCheqTerEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Estado_Id=deleted.Estado_Id)
 END
GO

 DROP TRIGGER tesCheqTerEstadoupd
GO

 CREATE TRIGGER tesCheqTerEstadoupd
ON tesCheqTerEstado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCheqTerEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesChequerasins
GO

 CREATE TRIGGER tesChequerasins
ON tesChequeras
AFTER INSERT
AS
 BEGIN
INSERT INTO tesChequeras_log(
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where Chequera_Id=inserted.Chequera_Id)
 END
GO

 DROP TRIGGER tesChequerasdel
GO

 CREATE TRIGGER tesChequerasdel
ON tesChequeras
AFTER DELETE
AS
 BEGIN
INSERT INTO tesChequeras_log(
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where Chequera_Id=deleted.Chequera_Id)
 END
GO

 DROP TRIGGER tesChequerasupd
GO

 CREATE TRIGGER tesChequerasupd
ON tesChequeras
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesChequeras_log(
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
Chequera_Id,
Cartera_Id,
Empresa_Id,
TipoChequera,
Estado_Id,
Desde,
Hasta,
Proximo,
FechaAlta,
FechaBaja,
MotivoBaja,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where Chequera_Id=inserted.Chequera_Id)
 END
GO

 DROP TRIGGER tesChequerasEstadoins
GO

 CREATE TRIGGER tesChequerasEstadoins
ON tesChequerasEstado
AFTER INSERT
AS
 BEGIN
INSERT INTO tesChequerasEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesChequerasEstadodel
GO

 CREATE TRIGGER tesChequerasEstadodel
ON tesChequerasEstado
AFTER DELETE
AS
 BEGIN
INSERT INTO tesChequerasEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where Estado_Id=deleted.Estado_Id)
 END
GO

 DROP TRIGGER tesChequerasEstadoupd
GO

 CREATE TRIGGER tesChequerasEstadoupd
ON tesChequerasEstado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesChequerasEstado_log(
Estado_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
Estado_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where Estado_Id=inserted.Estado_Id)
 END
GO

 DROP TRIGGER tesClearingins
GO

 CREATE TRIGGER tesClearingins
ON tesClearing
AFTER INSERT
AS
 BEGIN
INSERT INTO tesClearing_log(
Clearing,
Descripcion,
Dias,
cVariable,
FechaModifLog,
TipoModificacion
)
(Select 
Clearing,
Descripcion,
Dias,
cVariable,
GETDATE(),
'ins'
FROM inserted where Clearing=inserted.Clearing)
 END
GO

 DROP TRIGGER tesClearingdel
GO

 CREATE TRIGGER tesClearingdel
ON tesClearing
AFTER DELETE
AS
 BEGIN
INSERT INTO tesClearing_log(
Clearing,
Descripcion,
Dias,
cVariable,
FechaModifLog,
TipoModificacion
)
(Select 
Clearing,
Descripcion,
Dias,
cVariable,
GETDATE(),
'del'
FROM deleted where Clearing=deleted.Clearing)
 END
GO

 DROP TRIGGER tesClearingupd
GO

 CREATE TRIGGER tesClearingupd
ON tesClearing
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesClearing_log(
Clearing,
Descripcion,
Dias,
cVariable,
FechaModifLog,
TipoModificacion
)
(Select 
Clearing,
Descripcion,
Dias,
cVariable,
GETDATE(),
'upd'
FROM inserted where Clearing=inserted.Clearing)
 END
GO

 DROP TRIGGER tesConciliacionins
GO

 CREATE TRIGGER tesConciliacionins
ON tesConciliacion
AFTER INSERT
AS
 BEGIN
INSERT INTO tesConciliacion_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesConciliaciondel
GO

 CREATE TRIGGER tesConciliaciondel
ON tesConciliacion
AFTER DELETE
AS
 BEGIN
INSERT INTO tesConciliacion_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER tesConciliacionupd
GO

 CREATE TRIGGER tesConciliacionupd
ON tesConciliacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesConciliacion_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
FechaConciliacion,
ExtractoCierre,
ExtractoApertura,
ContableApertura,
ContableCierre,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesCTlinkins
GO

 CREATE TRIGGER tesCTlinkins
ON tesCTlink
AFTER INSERT
AS
 BEGIN
INSERT INTO tesCTlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesCTlinkdel
GO

 CREATE TRIGGER tesCTlinkdel
ON tesCTlink
AFTER DELETE
AS
 BEGIN
INSERT INTO tesCTlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesCTlinkupd
GO

 CREATE TRIGGER tesCTlinkupd
ON tesCTlink
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesCTlink_log(
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Estado_Id,
Secuencia,
tesCheqTerceros,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesDepositoins
GO

 CREATE TRIGGER tesDepositoins
ON tesDeposito
AFTER INSERT
AS
 BEGIN
INSERT INTO tesDeposito_log(
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesDepositodel
GO

 CREATE TRIGGER tesDepositodel
ON tesDeposito
AFTER DELETE
AS
 BEGIN
INSERT INTO tesDeposito_log(
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesDepositoupd
GO

 CREATE TRIGGER tesDepositoupd
ON tesDeposito
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesDeposito_log(
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
FormaDePagoP,
NumOperacion,
RfcEmisorCtaOrd,
NomBancoOrdExt,
CtaOrdenante,
TipoCadPago,
CertPago,
CadPago,
SelloPago,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesGananciasins
GO

 CREATE TRIGGER tesGananciasins
ON tesGanancias
AFTER INSERT
AS
 BEGIN
INSERT INTO tesGanancias_log(
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where tesGanancias=inserted.tesGanancias)
 END
GO

 DROP TRIGGER tesGananciasdel
GO

 CREATE TRIGGER tesGananciasdel
ON tesGanancias
AFTER DELETE
AS
 BEGIN
INSERT INTO tesGanancias_log(
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where tesGanancias=deleted.tesGanancias)
 END
GO

 DROP TRIGGER tesGananciasupd
GO

 CREATE TRIGGER tesGananciasupd
ON tesGanancias
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesGanancias_log(
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
tesGanancias,
Tabla_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where tesGanancias=inserted.tesGanancias)
 END
GO

 DROP TRIGGER tesGanCuerpoins
GO

 CREATE TRIGGER tesGanCuerpoins
ON tesGanCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO tesGanCuerpo_log(
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'ins'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER tesGanCuerpodel
GO

 CREATE TRIGGER tesGanCuerpodel
ON tesGanCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO tesGanCuerpo_log(
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'del'
FROM deleted where Tabla_Id=deleted.Tabla_Id)
 END
GO

 DROP TRIGGER tesGanCuerpoupd
GO

 CREATE TRIGGER tesGanCuerpoupd
ON tesGanCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesGanCuerpo_log(
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
FechaModifLog,
TipoModificacion
)
(Select 
Tabla_Id,
Hasta,
Porcentaje,
Minimo,
GETDATE(),
'upd'
FROM inserted where Tabla_Id=inserted.Tabla_Id)
 END
GO

 DROP TRIGGER tesIdBancoPropioins
GO

 CREATE TRIGGER tesIdBancoPropioins
ON tesIdBancoPropio
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdBancoPropio_log(
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdBancoPropiodel
GO

 CREATE TRIGGER tesIdBancoPropiodel
ON tesIdBancoPropio
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdBancoPropio_log(
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdBancoPropioupd
GO

 CREATE TRIGGER tesIdBancoPropioupd
ON tesIdBancoPropio
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdBancoPropio_log(
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
ChequeraPredeter,
Banco_Id,
CantRenglones,
numCuenta,
CtaContDiferido,
MaximoLibrado,
ValorComision,
LimCredVtaCheques,
CtaCorto,
Formulario_Id,
Referencia,
RepoCheq_Id,
RepoCheqDif_Id,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCajaAhorroins
GO

 CREATE TRIGGER tesIdCajaAhorroins
ON tesIdCajaAhorro
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdCajaAhorro_log(
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCajaAhorrodel
GO

 CREATE TRIGGER tesIdCajaAhorrodel
ON tesIdCajaAhorro
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdCajaAhorro_log(
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCajaAhorroupd
GO

 CREATE TRIGGER tesIdCajaAhorroupd
ON tesIdCajaAhorro
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdCajaAhorro_log(
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
numCuenta,
topeExtraccion,
InteresPorc,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCheqTercerosins
GO

 CREATE TRIGGER tesIdCheqTercerosins
ON tesIdCheqTerceros
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdCheqTerceros_log(
Cartera_Id,
CtaChqRechazado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
CtaChqRechazado,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCheqTercerosdel
GO

 CREATE TRIGGER tesIdCheqTercerosdel
ON tesIdCheqTerceros
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdCheqTerceros_log(
Cartera_Id,
CtaChqRechazado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
CtaChqRechazado,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdCheqTercerosupd
GO

 CREATE TRIGGER tesIdCheqTercerosupd
ON tesIdCheqTerceros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdCheqTerceros_log(
Cartera_Id,
CtaChqRechazado,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
CtaChqRechazado,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdentificains
GO

 CREATE TRIGGER tesIdentificains
ON tesIdentifica
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdentifica_log(
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
GETDATE(),
'ins'
FROM inserted where tesIdentifica=inserted.tesIdentifica)
 END
GO

 DROP TRIGGER tesIdentificadel
GO

 CREATE TRIGGER tesIdentificadel
ON tesIdentifica
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdentifica_log(
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
GETDATE(),
'del'
FROM deleted where tesIdentifica=deleted.tesIdentifica)
 END
GO

 DROP TRIGGER tesIdentificaupd
GO

 CREATE TRIGGER tesIdentificaupd
ON tesIdentifica
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdentifica_log(
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesIdentifica,
Cartera_Id,
Empresa_Id,
TipoCartera,
Descripcion,
Cuenta_Id,
Centro1_Id,
Centro2_Id,
Moneda_Id,
UsuarioAmo,
ModiCent1,
ModiCent2,
CtaValEnTransito,
Reservado,
VaAlCashFlow,
Inactivo,
Usuario_Id,
Posteado,
FormaDePagoP,
GETDATE(),
'upd'
FROM inserted where tesIdentifica=inserted.tesIdentifica)
 END
GO

 DROP TRIGGER tesIdRetClienins
GO

 CREATE TRIGGER tesIdRetClienins
ON tesIdRetClien
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdRetClien_log(
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdRetCliendel
GO

 CREATE TRIGGER tesIdRetCliendel
ON tesIdRetClien
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdRetClien_log(
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdRetClienupd
GO

 CREATE TRIGGER tesIdRetClienupd
ON tesIdRetClien
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdRetClien_log(
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
vaSubDiarioVta,
TipoImpuesto,
NroResSicore,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdRetProvins
GO

 CREATE TRIGGER tesIdRetProvins
ON tesIdRetProv
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdRetProv_log(
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdRetProvdel
GO

 CREATE TRIGGER tesIdRetProvdel
ON tesIdRetProv
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdRetProv_log(
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdRetProvupd
GO

 CREATE TRIGGER tesIdRetProvupd
ON tesIdRetProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdRetProv_log(
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Formula,
Segmento_Id,
TipoImpuesto,
NroResSicore,
TipoCtaProv,
Concepto,
Porcentaje,
UsuarioFirmante,
Minimo,
GenRetxFact,
Reporte_Id,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdVariosins
GO

 CREATE TRIGGER tesIdVariosins
ON tesIdVarios
AFTER INSERT
AS
 BEGIN
INSERT INTO tesIdVarios_log(
Cartera_Id,
Modi_Cuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Modi_Cuenta,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdVariosdel
GO

 CREATE TRIGGER tesIdVariosdel
ON tesIdVarios
AFTER DELETE
AS
 BEGIN
INSERT INTO tesIdVarios_log(
Cartera_Id,
Modi_Cuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Modi_Cuenta,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesIdVariosupd
GO

 CREATE TRIGGER tesIdVariosupd
ON tesIdVarios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesIdVarios_log(
Cartera_Id,
Modi_Cuenta,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Modi_Cuenta,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesMoviGravadoins
GO

 CREATE TRIGGER tesMoviGravadoins
ON tesMoviGravado
AFTER INSERT
AS
 BEGIN
INSERT INTO tesMoviGravado_log(
tesMovimientos,
TipoCtaProv,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
TipoCtaProv,
Importe,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviGravadodel
GO

 CREATE TRIGGER tesMoviGravadodel
ON tesMoviGravado
AFTER DELETE
AS
 BEGIN
INSERT INTO tesMoviGravado_log(
tesMovimientos,
TipoCtaProv,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
TipoCtaProv,
Importe,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviGravadoupd
GO

 CREATE TRIGGER tesMoviGravadoupd
ON tesMoviGravado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesMoviGravado_log(
tesMovimientos,
TipoCtaProv,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
TipoCtaProv,
Importe,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviImpins
GO

 CREATE TRIGGER tesMoviImpins
ON tesMoviImp
AFTER INSERT
AS
 BEGIN
INSERT INTO tesMoviImp_log(
tesMovimientos,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conAsientos,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviImpdel
GO

 CREATE TRIGGER tesMoviImpdel
ON tesMoviImp
AFTER DELETE
AS
 BEGIN
INSERT INTO tesMoviImp_log(
tesMovimientos,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conAsientos,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviImpupd
GO

 CREATE TRIGGER tesMoviImpupd
ON tesMoviImp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesMoviImp_log(
tesMovimientos,
conAsientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conAsientos,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMovimientosins
GO

 CREATE TRIGGER tesMovimientosins
ON tesMovimientos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesMovimientos_log(
tesMovimientos,
SubTipo_Id,
Fecha_Real,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
SubTipo_Id,
Fecha_Real,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMovimientosdel
GO

 CREATE TRIGGER tesMovimientosdel
ON tesMovimientos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesMovimientos_log(
tesMovimientos,
SubTipo_Id,
Fecha_Real,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
SubTipo_Id,
Fecha_Real,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMovimientosupd
GO

 CREATE TRIGGER tesMovimientosupd
ON tesMovimientos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesMovimientos_log(
tesMovimientos,
SubTipo_Id,
Fecha_Real,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
SubTipo_Id,
Fecha_Real,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviReversains
GO

 CREATE TRIGGER tesMoviReversains
ON tesMoviReversa
AFTER INSERT
AS
 BEGIN
INSERT INTO tesMoviReversa_log(
tesMovimientos,
tesMoviReversa,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesMoviReversa,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviReversadel
GO

 CREATE TRIGGER tesMoviReversadel
ON tesMoviReversa
AFTER DELETE
AS
 BEGIN
INSERT INTO tesMoviReversa_log(
tesMovimientos,
tesMoviReversa,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesMoviReversa,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesMoviReversaupd
GO

 CREATE TRIGGER tesMoviReversaupd
ON tesMoviReversa
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesMoviReversa_log(
tesMovimientos,
tesMoviReversa,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesMoviReversa,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesPartidasInConins
GO

 CREATE TRIGGER tesPartidasInConins
ON tesPartidasInCon
AFTER INSERT
AS
 BEGIN
INSERT INTO tesPartidasInCon_log(
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
GETDATE(),
'ins'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesPartidasInCondel
GO

 CREATE TRIGGER tesPartidasInCondel
ON tesPartidasInCon
AFTER DELETE
AS
 BEGIN
INSERT INTO tesPartidasInCon_log(
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
GETDATE(),
'del'
FROM deleted where Cartera_Id=deleted.Cartera_Id)
 END
GO

 DROP TRIGGER tesPartidasInConupd
GO

 CREATE TRIGGER tesPartidasInConupd
ON tesPartidasInCon
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesPartidasInCon_log(
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cartera_Id,
Fecha,
Comprobante,
Debe_Haber,
Importe,
Empresa_Id,
GETDATE(),
'upd'
FROM inserted where Cartera_Id=inserted.Cartera_Id)
 END
GO

 DROP TRIGGER tesRengConcilEspins
GO

 CREATE TRIGGER tesRengConcilEspins
ON tesRengConcilEsp
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengConcilEsp_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesRengConcilEspdel
GO

 CREATE TRIGGER tesRengConcilEspdel
ON tesRengConcilEsp
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengConcilEsp_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER tesRengConcilEspupd
GO

 CREATE TRIGGER tesRengConcilEspupd
ON tesRengConcilEsp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengConcilEsp_log(
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
tesIdentifica,
NumeroConc,
tesMovimientos,
conRenglon,
Importe,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesRengConciliacins
GO

 CREATE TRIGGER tesRengConciliacins
ON tesRengConciliac
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengConciliac_log(
tesMovimientos,
conRenglon,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Saldo,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengConciliacdel
GO

 CREATE TRIGGER tesRengConciliacdel
ON tesRengConciliac
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengConciliac_log(
tesMovimientos,
conRenglon,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Saldo,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengConciliacupd
GO

 CREATE TRIGGER tesRengConciliacupd
ON tesRengConciliac
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengConciliac_log(
tesMovimientos,
conRenglon,
Saldo,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Saldo,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviins
GO

 CREATE TRIGGER tesRengMoviins
ON tesRengMovi
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengMovi_log(
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMovidel
GO

 CREATE TRIGGER tesRengMovidel
ON tesRengMovi
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengMovi_log(
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviupd
GO

 CREATE TRIGGER tesRengMoviupd
ON tesRengMovi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengMovi_log(
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Cartera_Id,
Cambio,
TipomovCont,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMovicomMovProvins
GO

 CREATE TRIGGER tesRengMovicomMovProvins
ON tesRengMovicomMovProv
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengMovicomMovProv_log(
tesMovimientos,
Renglon,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
comMovProv,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMovicomMovProvdel
GO

 CREATE TRIGGER tesRengMovicomMovProvdel
ON tesRengMovicomMovProv
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengMovicomMovProv_log(
tesMovimientos,
Renglon,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
comMovProv,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMovicomMovProvupd
GO

 CREATE TRIGGER tesRengMovicomMovProvupd
ON tesRengMovicomMovProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengMovicomMovProv_log(
tesMovimientos,
Renglon,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
Renglon,
comMovProv,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetClieins
GO

 CREATE TRIGGER tesRengMoviRetClieins
ON tesRengMoviRetClie
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengMoviRetClie_log(
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetCliedel
GO

 CREATE TRIGGER tesRengMoviRetCliedel
ON tesRengMoviRetClie
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengMoviRetClie_log(
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetClieupd
GO

 CREATE TRIGGER tesRengMoviRetClieupd
ON tesRengMoviRetClie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengMoviRetClie_log(
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
SucursalRet,
ComprobanteRet,
BaseImponible,
Porcentaje,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetProvins
GO

 CREATE TRIGGER tesRengMoviRetProvins
ON tesRengMoviRetProv
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRengMoviRetProv_log(
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetProvdel
GO

 CREATE TRIGGER tesRengMoviRetProvdel
ON tesRengMoviRetProv
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRengMoviRetProv_log(
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRengMoviRetProvupd
GO

 CREATE TRIGGER tesRengMoviRetProvupd
ON tesRengMoviRetProv
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRengMoviRetProv_log(
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
conRenglon,
Porcentaje,
Exencion,
BaseImponible,
Acum,
TRet,
AcumTot,
comMovProv,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesRetProvSegmentoins
GO

 CREATE TRIGGER tesRetProvSegmentoins
ON tesRetProvSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO tesRetProvSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesRetProvSegmentodel
GO

 CREATE TRIGGER tesRetProvSegmentodel
ON tesRetProvSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO tesRetProvSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER tesRetProvSegmentoupd
GO

 CREATE TRIGGER tesRetProvSegmentoupd
ON tesRetProvSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesRetProvSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesMovimientos,
conRenglon,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesSolicitantesins
GO

 CREATE TRIGGER tesSolicitantesins
ON tesSolicitantes
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER tesSolicitantesdel
GO

 CREATE TRIGGER tesSolicitantesdel
ON tesSolicitantes
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER tesSolicitantesupd
GO

 CREATE TRIGGER tesSolicitantesupd
ON tesSolicitantes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSolicitantes_log(
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Solicitante_Id,
Empresa_Id,
Nombre,
Inactivo,
Posteado,
Banco_Id,
Cuenta,
Usuario_Id,
FechaCarga,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER tesSolicitudins
GO

 CREATE TRIGGER tesSolicitudins
ON tesSolicitud
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSolicitud_log(
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'ins'
FROM inserted where tesSolicitud=inserted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolicituddel
GO

 CREATE TRIGGER tesSolicituddel
ON tesSolicitud
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSolicitud_log(
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'del'
FROM deleted where tesSolicitud=deleted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolicitudupd
GO

 CREATE TRIGGER tesSolicitudupd
ON tesSolicitud
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSolicitud_log(
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
Solicitante_Id,
Causa,
Fecha,
Monto,
Estado,
UsuarioAutorizo,
FechaAutorizo,
Usuario_Id,
FechaCarga,
Cartera_Id,
GETDATE(),
'upd'
FROM inserted where tesSolicitud=inserted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolPagoins
GO

 CREATE TRIGGER tesSolPagoins
ON tesSolPago
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSolPago_log(
tesSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
tesMovimientos,
GETDATE(),
'ins'
FROM inserted where tesSolicitud=inserted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolPagodel
GO

 CREATE TRIGGER tesSolPagodel
ON tesSolPago
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSolPago_log(
tesSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
tesMovimientos,
GETDATE(),
'del'
FROM deleted where tesSolicitud=deleted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolPagoupd
GO

 CREATE TRIGGER tesSolPagoupd
ON tesSolPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSolPago_log(
tesSolicitud,
tesMovimientos,
FechaModifLog,
TipoModificacion
)
(Select 
tesSolicitud,
tesMovimientos,
GETDATE(),
'upd'
FROM inserted where tesSolicitud=inserted.tesSolicitud)
 END
GO

 DROP TRIGGER tesSolRendicionins
GO

 CREATE TRIGGER tesSolRendicionins
ON tesSolRendicion
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSolRendicion_log(
tesMovimientos,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesSolicitud,
GETDATE(),
'ins'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesSolRendiciondel
GO

 CREATE TRIGGER tesSolRendiciondel
ON tesSolRendicion
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSolRendicion_log(
tesMovimientos,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesSolicitud,
GETDATE(),
'del'
FROM deleted where tesMovimientos=deleted.tesMovimientos)
 END
GO

 DROP TRIGGER tesSolRendicionupd
GO

 CREATE TRIGGER tesSolRendicionupd
ON tesSolRendicion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSolRendicion_log(
tesMovimientos,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
tesMovimientos,
tesSolicitud,
GETDATE(),
'upd'
FROM inserted where tesMovimientos=inserted.tesMovimientos)
 END
GO

 DROP TRIGGER tesSolSegmentosins
GO

 CREATE TRIGGER tesSolSegmentosins
ON tesSolSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesSolSegmentosdel
GO

 CREATE TRIGGER tesSolSegmentosdel
ON tesSolSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER tesSolSegmentosupd
GO

 CREATE TRIGGER tesSolSegmentosupd
ON tesSolSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSolSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
tesSolicitud,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER tesSubTiposMovins
GO

 CREATE TRIGGER tesSubTiposMovins
ON tesSubTiposMov
AFTER INSERT
AS
 BEGIN
INSERT INTO tesSubTiposMov_log(
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
FechaModifLog,
TipoModificacion
)
(Select 
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
GETDATE(),
'ins'
FROM inserted where tesSubTiposMov=inserted.tesSubTiposMov)
 END
GO

 DROP TRIGGER tesSubTiposMovdel
GO

 CREATE TRIGGER tesSubTiposMovdel
ON tesSubTiposMov
AFTER DELETE
AS
 BEGIN
INSERT INTO tesSubTiposMov_log(
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
FechaModifLog,
TipoModificacion
)
(Select 
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
GETDATE(),
'del'
FROM deleted where tesSubTiposMov=deleted.tesSubTiposMov)
 END
GO

 DROP TRIGGER tesSubTiposMovupd
GO

 CREATE TRIGGER tesSubTiposMovupd
ON tesSubTiposMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesSubTiposMov_log(
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
FechaModifLog,
TipoModificacion
)
(Select 
tesSubTiposMov,
SubTipo_Id,
Descripcion,
TipoMov,
CantCopias,
genReportes,
GETDATE(),
'upd'
FROM inserted where tesSubTiposMov=inserted.tesSubTiposMov)
 END
GO

 DROP TRIGGER tesTiposIdins
GO

 CREATE TRIGGER tesTiposIdins
ON tesTiposId
AFTER INSERT
AS
 BEGIN
INSERT INTO tesTiposId_log(
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
GETDATE(),
'ins'
FROM inserted where tesTiposId=inserted.tesTiposId)
 END
GO

 DROP TRIGGER tesTiposIddel
GO

 CREATE TRIGGER tesTiposIddel
ON tesTiposId
AFTER DELETE
AS
 BEGIN
INSERT INTO tesTiposId_log(
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
GETDATE(),
'del'
FROM deleted where tesTiposId=deleted.tesTiposId)
 END
GO

 DROP TRIGGER tesTiposIdupd
GO

 CREATE TRIGGER tesTiposIdupd
ON tesTiposId
AFTER  UPDATE
AS
 BEGIN
INSERT INTO tesTiposId_log(
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
FechaModifLog,
TipoModificacion
)
(Select 
tesTiposId,
TipoCartera,
Descripcion,
FormaDePagoP,
GETDATE(),
'upd'
FROM inserted where tesTiposId=inserted.tesTiposId)
 END
GO

 DROP TRIGGER venAsiCierreins
GO

 CREATE TRIGGER venAsiCierreins
ON venAsiCierre
AFTER INSERT
AS
 BEGIN
INSERT INTO venAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venAsiCierredel
GO

 CREATE TRIGGER venAsiCierredel
ON venAsiCierre
AFTER DELETE
AS
 BEGIN
INSERT INTO venAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER venAsiCierreupd
GO

 CREATE TRIGGER venAsiCierreupd
ON venAsiCierre
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venAsiCierre_log(
Asiento_Id,
Fecha,
Moneda_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
Fecha,
Moneda_Id,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venAsiCierreCrins
GO

 CREATE TRIGGER venAsiCierreCrins
ON venAsiCierreCr
AFTER INSERT
AS
 BEGIN
INSERT INTO venAsiCierreCr_log(
Asiento_Id,
conRenglon,
Cliente_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Cliente_Id,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venAsiCierreCrdel
GO

 CREATE TRIGGER venAsiCierreCrdel
ON venAsiCierreCr
AFTER DELETE
AS
 BEGIN
INSERT INTO venAsiCierreCr_log(
Asiento_Id,
conRenglon,
Cliente_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Cliente_Id,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER venAsiCierreCrupd
GO

 CREATE TRIGGER venAsiCierreCrupd
ON venAsiCierreCr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venAsiCierreCr_log(
Asiento_Id,
conRenglon,
Cliente_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
conRenglon,
Cliente_Id,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venCamionesins
GO

 CREATE TRIGGER venCamionesins
ON venCamiones
AFTER INSERT
AS
 BEGIN
INSERT INTO venCamiones_log(
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venCamiones=inserted.venCamiones)
 END
GO

 DROP TRIGGER venCamionesdel
GO

 CREATE TRIGGER venCamionesdel
ON venCamiones
AFTER DELETE
AS
 BEGIN
INSERT INTO venCamiones_log(
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venCamiones=deleted.venCamiones)
 END
GO

 DROP TRIGGER venCamionesupd
GO

 CREATE TRIGGER venCamionesupd
ON venCamiones
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCamiones_log(
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCamiones,
Patente_Id,
Empresa_Id,
Descripcion,
FormaEntrega_Id,
CargaMaxima,
Tara,
Marca,
Inspeccion,
EsAcoplado,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venCamiones=inserted.venCamiones)
 END
GO

 DROP TRIGGER venCanjeNotasins
GO

 CREATE TRIGGER venCanjeNotasins
ON venCanjeNotas
AFTER INSERT
AS
 BEGIN
INSERT INTO venCanjeNotas_log(
venMovimientos,
venMovimientosNC,
venMovimientosFC,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosNC,
venMovimientosFC,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCanjeNotasdel
GO

 CREATE TRIGGER venCanjeNotasdel
ON venCanjeNotas
AFTER DELETE
AS
 BEGIN
INSERT INTO venCanjeNotas_log(
venMovimientos,
venMovimientosNC,
venMovimientosFC,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosNC,
venMovimientosFC,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venCanjeNotasupd
GO

 CREATE TRIGGER venCanjeNotasupd
ON venCanjeNotas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCanjeNotas_log(
venMovimientos,
venMovimientosNC,
venMovimientosFC,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosNC,
venMovimientosFC,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCategCreditoins
GO

 CREATE TRIGGER venCategCreditoins
ON venCategCredito
AFTER INSERT
AS
 BEGIN
INSERT INTO venCategCredito_log(
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venCategCredito=inserted.venCategCredito)
 END
GO

 DROP TRIGGER venCategCreditodel
GO

 CREATE TRIGGER venCategCreditodel
ON venCategCredito
AFTER DELETE
AS
 BEGIN
INSERT INTO venCategCredito_log(
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venCategCredito=deleted.venCategCredito)
 END
GO

 DROP TRIGGER venCategCreditoupd
GO

 CREATE TRIGGER venCategCreditoupd
ON venCategCredito
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCategCredito_log(
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCategCredito,
CategCred_Id,
Empresa_Id,
Descripcion,
MaxDiasAtraso,
PorcenDeudaVenci,
TipoCredito,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venCategCredito=inserted.venCategCredito)
 END
GO

 DROP TRIGGER venCFDISatins
GO

 CREATE TRIGGER venCFDISatins
ON venCFDISat
AFTER INSERT
AS
 BEGIN
INSERT INTO venCFDISat_log(
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
GETDATE(),
'ins'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER venCFDISatdel
GO

 CREATE TRIGGER venCFDISatdel
ON venCFDISat
AFTER DELETE
AS
 BEGIN
INSERT INTO venCFDISat_log(
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
GETDATE(),
'del'
FROM deleted where UUID=deleted.UUID)
 END
GO

 DROP TRIGGER venCFDISatupd
GO

 CREATE TRIGGER venCFDISatupd
ON venCFDISat
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCFDISat_log(
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
FechaModifLog,
TipoModificacion
)
(Select 
UUID,
Empresa_Id,
RFCReceptor,
Fecha,
Monto,
Impuestos,
Folio,
Serie,
XML,
Usuario,
FechaCarga,
TipoComprobante,
GETDATE(),
'upd'
FROM inserted where UUID=inserted.UUID)
 END
GO

 DROP TRIGGER venClieContactoins
GO

 CREATE TRIGGER venClieContactoins
ON venClieContacto
AFTER INSERT
AS
 BEGIN
INSERT INTO venClieContacto_log(
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
GETDATE(),
'ins'
FROM inserted where Cliente_Id=inserted.Cliente_Id)
 END
GO

 DROP TRIGGER venClieContactodel
GO

 CREATE TRIGGER venClieContactodel
ON venClieContacto
AFTER DELETE
AS
 BEGIN
INSERT INTO venClieContacto_log(
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
GETDATE(),
'del'
FROM deleted where Cliente_Id=deleted.Cliente_Id)
 END
GO

 DROP TRIGGER venClieContactoupd
GO

 CREATE TRIGGER venClieContactoupd
ON venClieContacto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venClieContacto_log(
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Sucursal,
NroContacto,
Nombre,
Puesto,
Email,
Telefono,
Interno,
Movil,
EnviaFacturas,
EnviaRecibo,
EnviaPedido,
Observaciones,
Inactivo,
GETDATE(),
'upd'
FROM inserted where Cliente_Id=inserted.Cliente_Id)
 END
GO

 DROP TRIGGER venClieEstadosins
GO

 CREATE TRIGGER venClieEstadosins
ON venClieEstados
AFTER INSERT
AS
 BEGIN
INSERT INTO venClieEstados_log(
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venClieEstados=inserted.venClieEstados)
 END
GO

 DROP TRIGGER venClieEstadosdel
GO

 CREATE TRIGGER venClieEstadosdel
ON venClieEstados
AFTER DELETE
AS
 BEGIN
INSERT INTO venClieEstados_log(
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venClieEstados=deleted.venClieEstados)
 END
GO

 DROP TRIGGER venClieEstadosupd
GO

 CREATE TRIGGER venClieEstadosupd
ON venClieEstados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venClieEstados_log(
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venClieEstados,
Estado_Id,
Empresa_Id,
Descripcion,
Cuenta_Id,
Reservado,
ImpideOperaciones,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venClieEstados=inserted.venClieEstados)
 END
GO

 DROP TRIGGER venClieHabitualins
GO

 CREATE TRIGGER venClieHabitualins
ON venClieHabitual
AFTER INSERT
AS
 BEGIN
INSERT INTO venClieHabitual_log(
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER venClieHabitualdel
GO

 CREATE TRIGGER venClieHabitualdel
ON venClieHabitual
AFTER DELETE
AS
 BEGIN
INSERT INTO venClieHabitual_log(
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER venClieHabitualupd
GO

 CREATE TRIGGER venClieHabitualupd
ON venClieHabitual
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venClieHabitual_log(
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Sucursal,
NombreFantasia,
Direccion1_Fact,
Direccion2_Fact,
Localidad_Fact,
CodPostal_Fact,
Provincia_Id_Fact,
Pais_Id_Fact,
Telefonos,
Fax,
EMail,
Direccion1_Entr,
Direccion2_Entr,
Localidad_Entr,
CodPostal_Entr,
Provincia_Id_Entr,
Pais_Id_Entr,
TipoClie_Id,
ListaPrecio_Id,
FormaEntrega_Id,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
Zona_Id,
Region_Id,
Contactos,
Usuario_Id_Alta,
FechaAlta,
FechaUltContacto,
FechaModificacion,
Observaciones,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Centro1_Id,
Centro2_Id,
ClieConsolida,
NroExterior_Fact,
NroInterior_Fact,
NroExterior_Entr,
NroInterior_Entr,
Reclamos,
MetodoDePago,
NumCuenta,
C_UsoCFDI,
N_MetodoPago,
UsaComplementoINE,
Inactivo,
LatitudGPS,
LongitudGPS,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER venClientesins
GO

 CREATE TRIGGER venClientesins
ON venClientes
AFTER INSERT
AS
 BEGIN
INSERT INTO venClientes_log(
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
GETDATE(),
'ins'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER venClientesdel
GO

 CREATE TRIGGER venClientesdel
ON venClientes
AFTER DELETE
AS
 BEGIN
INSERT INTO venClientes_log(
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
GETDATE(),
'del'
FROM deleted where genEntidades=deleted.genEntidades)
 END
GO

 DROP TRIGGER venClientesupd
GO

 CREATE TRIGGER venClientesupd
ON venClientes
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venClientes_log(
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
FechaModifLog,
TipoModificacion
)
(Select 
genEntidades,
Cliente_Id,
Empresa_Id,
RazonSocial,
SucursalPredeter,
CondFisc_Id,
LimiteCredito,
MonedaLimCred,
CategCred_Id,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Puntual,
Estado_Id,
GeneraDebito,
Siempre,
CongelaCambio,
IBrutos,
Situacion,
Posteado,
FacturaCredito,
MontoFacturaCredito,
CbuBanco,
GETDATE(),
'upd'
FROM inserted where genEntidades=inserted.genEntidades)
 END
GO

 DROP TRIGGER venClientesCtasins
GO

 CREATE TRIGGER venClientesCtasins
ON venClientesCtas
AFTER INSERT
AS
 BEGIN
INSERT INTO venClientesCtas_log(
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
GETDATE(),
'ins'
FROM inserted where Cliente_Id=inserted.Cliente_Id)
 END
GO

 DROP TRIGGER venClientesCtasdel
GO

 CREATE TRIGGER venClientesCtasdel
ON venClientesCtas
AFTER DELETE
AS
 BEGIN
INSERT INTO venClientesCtas_log(
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
GETDATE(),
'del'
FROM deleted where Cliente_Id=deleted.Cliente_Id)
 END
GO

 DROP TRIGGER venClientesCtasupd
GO

 CREATE TRIGGER venClientesCtasupd
ON venClientesCtas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venClientesCtas_log(
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
FechaModifLog,
TipoModificacion
)
(Select 
Cliente_Id,
Moneda_Id,
CuentaDxVtas,
CtaFactAnticipo,
CtaAnticipo,
GETDATE(),
'upd'
FROM inserted where Cliente_Id=inserted.Cliente_Id)
 END
GO

 DROP TRIGGER venCobradoresins
GO

 CREATE TRIGGER venCobradoresins
ON venCobradores
AFTER INSERT
AS
 BEGIN
INSERT INTO venCobradores_log(
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venCobradores=inserted.venCobradores)
 END
GO

 DROP TRIGGER venCobradoresdel
GO

 CREATE TRIGGER venCobradoresdel
ON venCobradores
AFTER DELETE
AS
 BEGIN
INSERT INTO venCobradores_log(
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venCobradores=deleted.venCobradores)
 END
GO

 DROP TRIGGER venCobradoresupd
GO

 CREATE TRIGGER venCobradoresupd
ON venCobradores
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCobradores_log(
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCobradores,
Cobrador_Id,
Empresa_Id,
Nombre,
Comision,
LimiteComision,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venCobradores=inserted.venCobradores)
 END
GO

 DROP TRIGGER venCondFiscalins
GO

 CREATE TRIGGER venCondFiscalins
ON venCondFiscal
AFTER INSERT
AS
 BEGIN
INSERT INTO venCondFiscal_log(
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venCondFiscal=inserted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondFiscaldel
GO

 CREATE TRIGGER venCondFiscaldel
ON venCondFiscal
AFTER DELETE
AS
 BEGIN
INSERT INTO venCondFiscal_log(
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venCondFiscal=deleted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondFiscalupd
GO

 CREATE TRIGGER venCondFiscalupd
ON venCondFiscal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCondFiscal_log(
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
CondFisc_Id,
Empresa_Id,
Descripcion,
Letra,
AplicaFactCredito,
Letra_Rf,
Discrimina,
FacturaElectronica,
CodigoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venCondFiscal=inserted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondFiscImpins
GO

 CREATE TRIGGER venCondFiscImpins
ON venCondFiscImp
AFTER INSERT
AS
 BEGIN
INSERT INTO venCondFiscImp_log(
venCondFiscal,
venImpuestos,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
venImpuestos,
GETDATE(),
'ins'
FROM inserted where venCondFiscal=inserted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondFiscImpdel
GO

 CREATE TRIGGER venCondFiscImpdel
ON venCondFiscImp
AFTER DELETE
AS
 BEGIN
INSERT INTO venCondFiscImp_log(
venCondFiscal,
venImpuestos,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
venImpuestos,
GETDATE(),
'del'
FROM deleted where venCondFiscal=deleted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondFiscImpupd
GO

 CREATE TRIGGER venCondFiscImpupd
ON venCondFiscImp
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCondFiscImp_log(
venCondFiscal,
venImpuestos,
FechaModifLog,
TipoModificacion
)
(Select 
venCondFiscal,
venImpuestos,
GETDATE(),
'upd'
FROM inserted where venCondFiscal=inserted.venCondFiscal)
 END
GO

 DROP TRIGGER venCondPagoins
GO

 CREATE TRIGGER venCondPagoins
ON venCondPago
AFTER INSERT
AS
 BEGIN
INSERT INTO venCondPago_log(
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venCondPago=inserted.venCondPago)
 END
GO

 DROP TRIGGER venCondPagodel
GO

 CREATE TRIGGER venCondPagodel
ON venCondPago
AFTER DELETE
AS
 BEGIN
INSERT INTO venCondPago_log(
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venCondPago=deleted.venCondPago)
 END
GO

 DROP TRIGGER venCondPagoupd
GO

 CREATE TRIGGER venCondPagoupd
ON venCondPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCondPago_log(
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venCondPago,
CondPagoCli_Id,
Empresa_Id,
Descripcion,
CantCuotas,
TipoVencimiento,
Dias,
DiasVencimiento,
DiasDescFinanc,
DescFinanc,
ImpPrimCuota,
EditaCuotas,
FactCredito,
TipoFiscal,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venCondPago=inserted.venCondPago)
 END
GO

 DROP TRIGGER venCondPagoCuotasins
GO

 CREATE TRIGGER venCondPagoCuotasins
ON venCondPagoCuotas
AFTER INSERT
AS
 BEGIN
INSERT INTO venCondPagoCuotas_log(
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
GETDATE(),
'ins'
FROM inserted where CondPagoCli_Id=inserted.CondPagoCli_Id)
 END
GO

 DROP TRIGGER venCondPagoCuotasdel
GO

 CREATE TRIGGER venCondPagoCuotasdel
ON venCondPagoCuotas
AFTER DELETE
AS
 BEGIN
INSERT INTO venCondPagoCuotas_log(
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
GETDATE(),
'del'
FROM deleted where CondPagoCli_Id=deleted.CondPagoCli_Id)
 END
GO

 DROP TRIGGER venCondPagoCuotasupd
GO

 CREATE TRIGGER venCondPagoCuotasupd
ON venCondPagoCuotas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCondPagoCuotas_log(
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
FechaModifLog,
TipoModificacion
)
(Select 
CondPagoCli_Id,
Renglon,
Dias,
Porcentaje,
GETDATE(),
'upd'
FROM inserted where CondPagoCli_Id=inserted.CondPagoCli_Id)
 END
GO

 DROP TRIGGER venCotizacionesins
GO

 CREATE TRIGGER venCotizacionesins
ON venCotizaciones
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizaciones_log(
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
FechaModifLog,
TipoModificacion
)
(Select 
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
GETDATE(),
'ins'
FROM inserted where venCotizaciones=inserted.venCotizaciones)
 END
GO

 DROP TRIGGER venCotizacionesdel
GO

 CREATE TRIGGER venCotizacionesdel
ON venCotizaciones
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizaciones_log(
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
FechaModifLog,
TipoModificacion
)
(Select 
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
GETDATE(),
'del'
FROM deleted where venCotizaciones=deleted.venCotizaciones)
 END
GO

 DROP TRIGGER venCotizacionesupd
GO

 CREATE TRIGGER venCotizacionesupd
ON venCotizaciones
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizaciones_log(
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
FechaModifLog,
TipoModificacion
)
(Select 
venCotizaciones,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
ClienteExistente,
Vigencia,
GETDATE(),
'upd'
FROM inserted where venCotizaciones=inserted.venCotizaciones)
 END
GO

 DROP TRIGGER venCotizAnulins
GO

 CREATE TRIGGER venCotizAnulins
ON venCotizAnul
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizAnul_log(
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizAnuldel
GO

 CREATE TRIGGER venCotizAnuldel
ON venCotizAnul
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizAnul_log(
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where Cotizacion_Id=deleted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizAnulupd
GO

 CREATE TRIGGER venCotizAnulupd
ON venCotizAnul
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizAnul_log(
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizClienteins
GO

 CREATE TRIGGER venCotizClienteins
ON venCotizCliente
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizCliente_log(
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
GETDATE(),
'ins'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizClientedel
GO

 CREATE TRIGGER venCotizClientedel
ON venCotizCliente
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizCliente_log(
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
GETDATE(),
'del'
FROM deleted where Cotizacion_Id=deleted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizClienteupd
GO

 CREATE TRIGGER venCotizClienteupd
ON venCotizCliente
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizCliente_log(
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
RazonSocial,
Direccion1,
Direccion2,
NroExterior,
NroInterior,
Localidad,
CodigoPostal,
Provincia_Id,
Pais_Id,
Telefono,
CUIT,
Email,
GETDATE(),
'upd'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizCuerpoins
GO

 CREATE TRIGGER venCotizCuerpoins
ON venCotizCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizCuerpo_log(
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizCuerpodel
GO

 CREATE TRIGGER venCotizCuerpodel
ON venCotizCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizCuerpo_log(
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where Cotizacion_Id=deleted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizCuerpoupd
GO

 CREATE TRIGGER venCotizCuerpoupd
ON venCotizCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizCuerpo_log(
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Renglon_Co,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioLista,
PrecioVenta,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
PrecioListaForm,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizFactuCuerpoins
GO

 CREATE TRIGGER venCotizFactuCuerpoins
ON venCotizFactuCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizFactuCuerpo_log(
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizFactuCuerpodel
GO

 CREATE TRIGGER venCotizFactuCuerpodel
ON venCotizFactuCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizFactuCuerpo_log(
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizFactuCuerpoupd
GO

 CREATE TRIGGER venCotizFactuCuerpoupd
ON venCotizFactuCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizFactuCuerpo_log(
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizFacturains
GO

 CREATE TRIGGER venCotizFacturains
ON venCotizFactura
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizFactura_log(
venMovimientos,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venCotizaciones,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizFacturadel
GO

 CREATE TRIGGER venCotizFacturadel
ON venCotizFactura
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizFactura_log(
venMovimientos,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venCotizaciones,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizFacturaupd
GO

 CREATE TRIGGER venCotizFacturaupd
ON venCotizFactura
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizFactura_log(
venMovimientos,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venCotizaciones,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venCotizPediCuerpoins
GO

 CREATE TRIGGER venCotizPediCuerpoins
ON venCotizPediCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizPediCuerpo_log(
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venCotizPediCuerpodel
GO

 CREATE TRIGGER venCotizPediCuerpodel
ON venCotizPediCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizPediCuerpo_log(
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venCotizPediCuerpoupd
GO

 CREATE TRIGGER venCotizPediCuerpoupd
ON venCotizPediCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizPediCuerpo_log(
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venCotizaciones,
Renglon_Co,
Cantidad,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venCotizPedidosins
GO

 CREATE TRIGGER venCotizPedidosins
ON venCotizPedidos
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizPedidos_log(
Cotizacion_Id,
Pedido_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Pedido_Id,
Importe,
GETDATE(),
'ins'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizPedidosdel
GO

 CREATE TRIGGER venCotizPedidosdel
ON venCotizPedidos
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizPedidos_log(
Cotizacion_Id,
Pedido_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Pedido_Id,
Importe,
GETDATE(),
'del'
FROM deleted where Cotizacion_Id=deleted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizPedidosupd
GO

 CREATE TRIGGER venCotizPedidosupd
ON venCotizPedidos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizPedidos_log(
Cotizacion_Id,
Pedido_Id,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
Cotizacion_Id,
Pedido_Id,
Importe,
GETDATE(),
'upd'
FROM inserted where Cotizacion_Id=inserted.Cotizacion_Id)
 END
GO

 DROP TRIGGER venCotizSegmentoins
GO

 CREATE TRIGGER venCotizSegmentoins
ON venCotizSegmento
AFTER INSERT
AS
 BEGIN
INSERT INTO venCotizSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venCotizSegmentodel
GO

 CREATE TRIGGER venCotizSegmentodel
ON venCotizSegmento
AFTER DELETE
AS
 BEGIN
INSERT INTO venCotizSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER venCotizSegmentoupd
GO

 CREATE TRIGGER venCotizSegmentoupd
ON venCotizSegmento
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venCotizSegmento_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venCotizaciones,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venEsquemaAutoins
GO

 CREATE TRIGGER venEsquemaAutoins
ON venEsquemaAuto
AFTER INSERT
AS
 BEGIN
INSERT INTO venEsquemaAuto_log(
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where venEsquemaAuto=inserted.venEsquemaAuto)
 END
GO

 DROP TRIGGER venEsquemaAutodel
GO

 CREATE TRIGGER venEsquemaAutodel
ON venEsquemaAuto
AFTER DELETE
AS
 BEGIN
INSERT INTO venEsquemaAuto_log(
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where venEsquemaAuto=deleted.venEsquemaAuto)
 END
GO

 DROP TRIGGER venEsquemaAutoupd
GO

 CREATE TRIGGER venEsquemaAutoupd
ON venEsquemaAuto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venEsquemaAuto_log(
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venEsquemaAuto,
EsquemaAuto_Id,
Empresa_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where venEsquemaAuto=inserted.venEsquemaAuto)
 END
GO

 DROP TRIGGER venEsquemaAutoRengins
GO

 CREATE TRIGGER venEsquemaAutoRengins
ON venEsquemaAutoReng
AFTER INSERT
AS
 BEGIN
INSERT INTO venEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
GETDATE(),
'ins'
FROM inserted where EsquemaAuto_Id=inserted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER venEsquemaAutoRengdel
GO

 CREATE TRIGGER venEsquemaAutoRengdel
ON venEsquemaAutoReng
AFTER DELETE
AS
 BEGIN
INSERT INTO venEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
GETDATE(),
'del'
FROM deleted where EsquemaAuto_Id=deleted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER venEsquemaAutoRengupd
GO

 CREATE TRIGGER venEsquemaAutoRengupd
ON venEsquemaAutoReng
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venEsquemaAutoReng_log(
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
EsquemaAuto_Id,
Orden,
Formula,
NivelAuto_Id,
GETDATE(),
'upd'
FROM inserted where EsquemaAuto_Id=inserted.EsquemaAuto_Id)
 END
GO

 DROP TRIGGER venFormaEntregains
GO

 CREATE TRIGGER venFormaEntregains
ON venFormaEntrega
AFTER INSERT
AS
 BEGIN
INSERT INTO venFormaEntrega_log(
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venFormaEntrega=inserted.venFormaEntrega)
 END
GO

 DROP TRIGGER venFormaEntregadel
GO

 CREATE TRIGGER venFormaEntregadel
ON venFormaEntrega
AFTER DELETE
AS
 BEGIN
INSERT INTO venFormaEntrega_log(
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venFormaEntrega=deleted.venFormaEntrega)
 END
GO

 DROP TRIGGER venFormaEntregaupd
GO

 CREATE TRIGGER venFormaEntregaupd
ON venFormaEntrega
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venFormaEntrega_log(
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venFormaEntrega,
FormaEntrega_Id,
Empresa_Id,
RazonSocial,
Direccion,
Localidad,
Provincia_Id,
Pais_Id,
Telefono,
Cuit,
CondFisc_Id,
Seguro,
Contacto,
Cargo,
Email,
ExcluirDelReparto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venFormaEntrega=inserted.venFormaEntrega)
 END
GO

 DROP TRIGGER venImpuestosins
GO

 CREATE TRIGGER venImpuestosins
ON venImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO venImpuestos_log(
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venImpuestos=inserted.venImpuestos)
 END
GO

 DROP TRIGGER venImpuestosdel
GO

 CREATE TRIGGER venImpuestosdel
ON venImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO venImpuestos_log(
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venImpuestos=deleted.venImpuestos)
 END
GO

 DROP TRIGGER venImpuestosupd
GO

 CREATE TRIGGER venImpuestosupd
ON venImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venImpuestos_log(
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venImpuestos,
Impuesto_Id,
Empresa_Id,
Descripcion,
TipoImpuesto,
CodigoFiscal,
UsaFormula,
Formulacalc,
Porcentaje,
Fecha_Desde,
Fecha_Hasta,
Depende_de,
PorVencimiento,
CtaReversion,
Cuenta_Id,
CtaDifCambio,
ImpuestoXProducto,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venImpuestos=inserted.venImpuestos)
 END
GO

 DROP TRIGGER venIncotermins
GO

 CREATE TRIGGER venIncotermins
ON venIncoterm
AFTER INSERT
AS
 BEGIN
INSERT INTO venIncoterm_log(
venIncoterm_int,
Incoterm_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venIncoterm_int,
Incoterm_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where venIncoterm_int=inserted.venIncoterm_int)
 END
GO

 DROP TRIGGER venIncotermdel
GO

 CREATE TRIGGER venIncotermdel
ON venIncoterm
AFTER DELETE
AS
 BEGIN
INSERT INTO venIncoterm_log(
venIncoterm_int,
Incoterm_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venIncoterm_int,
Incoterm_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where venIncoterm_int=deleted.venIncoterm_int)
 END
GO

 DROP TRIGGER venIncotermupd
GO

 CREATE TRIGGER venIncotermupd
ON venIncoterm
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venIncoterm_log(
venIncoterm_int,
Incoterm_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venIncoterm_int,
Incoterm_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where venIncoterm_int=inserted.venIncoterm_int)
 END
GO

 DROP TRIGGER venLibrosins
GO

 CREATE TRIGGER venLibrosins
ON venLibros
AFTER INSERT
AS
 BEGIN
INSERT INTO venLibros_log(
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'ins'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosdel
GO

 CREATE TRIGGER venLibrosdel
ON venLibros
AFTER DELETE
AS
 BEGIN
INSERT INTO venLibros_log(
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'del'
FROM deleted where venLibros=deleted.venLibros)
 END
GO

 DROP TRIGGER venLibrosupd
GO

 CREATE TRIGGER venLibrosupd
ON venLibros
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venLibros_log(
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Empresa_Id,
Libro_Id,
Descripcion,
GETDATE(),
'upd'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosColumnasins
GO

 CREATE TRIGGER venLibrosColumnasins
ON venLibrosColumnas
AFTER INSERT
AS
 BEGIN
INSERT INTO venLibrosColumnas_log(
venLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Titulo,
GETDATE(),
'ins'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosColumnasdel
GO

 CREATE TRIGGER venLibrosColumnasdel
ON venLibrosColumnas
AFTER DELETE
AS
 BEGIN
INSERT INTO venLibrosColumnas_log(
venLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Titulo,
GETDATE(),
'del'
FROM deleted where venLibros=deleted.venLibros)
 END
GO

 DROP TRIGGER venLibrosColumnasupd
GO

 CREATE TRIGGER venLibrosColumnasupd
ON venLibrosColumnas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venLibrosColumnas_log(
venLibros,
Columna,
Titulo,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Titulo,
GETDATE(),
'upd'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosImpuestosins
GO

 CREATE TRIGGER venLibrosImpuestosins
ON venLibrosImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO venLibrosImpuestos_log(
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
GETDATE(),
'ins'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosImpuestosdel
GO

 CREATE TRIGGER venLibrosImpuestosdel
ON venLibrosImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO venLibrosImpuestos_log(
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
GETDATE(),
'del'
FROM deleted where venLibros=deleted.venLibros)
 END
GO

 DROP TRIGGER venLibrosImpuestosupd
GO

 CREATE TRIGGER venLibrosImpuestosupd
ON venLibrosImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venLibrosImpuestos_log(
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Impuesto_Id,
TipoRenglon,
GETDATE(),
'upd'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosRetencionins
GO

 CREATE TRIGGER venLibrosRetencionins
ON venLibrosRetencion
AFTER INSERT
AS
 BEGIN
INSERT INTO venLibrosRetencion_log(
venLibros,
Columna,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Cartera_Id,
GETDATE(),
'ins'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venLibrosRetenciondel
GO

 CREATE TRIGGER venLibrosRetenciondel
ON venLibrosRetencion
AFTER DELETE
AS
 BEGIN
INSERT INTO venLibrosRetencion_log(
venLibros,
Columna,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Cartera_Id,
GETDATE(),
'del'
FROM deleted where venLibros=deleted.venLibros)
 END
GO

 DROP TRIGGER venLibrosRetencionupd
GO

 CREATE TRIGGER venLibrosRetencionupd
ON venLibrosRetencion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venLibrosRetencion_log(
venLibros,
Columna,
Cartera_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venLibros,
Columna,
Cartera_Id,
GETDATE(),
'upd'
FROM inserted where venLibros=inserted.venLibros)
 END
GO

 DROP TRIGGER venListasPrecBoniRecins
GO

 CREATE TRIGGER venListasPrecBoniRecins
ON venListasPrecBoniRec
AFTER INSERT
AS
 BEGIN
INSERT INTO venListasPrecBoniRec_log(
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
GETDATE(),
'ins'
FROM inserted where ListaPrecio_Id=inserted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venListasPrecBoniRecdel
GO

 CREATE TRIGGER venListasPrecBoniRecdel
ON venListasPrecBoniRec
AFTER DELETE
AS
 BEGIN
INSERT INTO venListasPrecBoniRec_log(
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
GETDATE(),
'del'
FROM deleted where ListaPrecio_Id=deleted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venListasPrecBoniRecupd
GO

 CREATE TRIGGER venListasPrecBoniRecupd
ON venListasPrecBoniRec
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venListasPrecBoniRec_log(
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
GETDATE(),
'upd'
FROM inserted where ListaPrecio_Id=inserted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venListasPreciosins
GO

 CREATE TRIGGER venListasPreciosins
ON venListasPrecios
AFTER INSERT
AS
 BEGIN
INSERT INTO venListasPrecios_log(
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venListasPrecios=inserted.venListasPrecios)
 END
GO

 DROP TRIGGER venListasPreciosdel
GO

 CREATE TRIGGER venListasPreciosdel
ON venListasPrecios
AFTER DELETE
AS
 BEGIN
INSERT INTO venListasPrecios_log(
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venListasPrecios=deleted.venListasPrecios)
 END
GO

 DROP TRIGGER venListasPreciosupd
GO

 CREATE TRIGGER venListasPreciosupd
ON venListasPrecios
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venListasPrecios_log(
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venListasPrecios,
ListaPrecio_Id,
Empresa_Id,
Descripcion,
Moneda_Id,
LlevaImpuestoInclu,
UsuAutorizado,
DecimalesPu,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venListasPrecios=inserted.venListasPrecios)
 END
GO

 DROP TRIGGER venListasPrecProdins
GO

 CREATE TRIGGER venListasPrecProdins
ON venListasPrecProd
AFTER INSERT
AS
 BEGIN
INSERT INTO venListasPrecProd_log(
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
GETDATE(),
'ins'
FROM inserted where ListaPrecio_Id=inserted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venListasPrecProddel
GO

 CREATE TRIGGER venListasPrecProddel
ON venListasPrecProd
AFTER DELETE
AS
 BEGIN
INSERT INTO venListasPrecProd_log(
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
GETDATE(),
'del'
FROM deleted where ListaPrecio_Id=deleted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venListasPrecProdupd
GO

 CREATE TRIGGER venListasPrecProdupd
ON venListasPrecProd
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venListasPrecProd_log(
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
FechaModifLog,
TipoModificacion
)
(Select 
ListaPrecio_Id,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo,
GETDATE(),
'upd'
FROM inserted where ListaPrecio_Id=inserted.ListaPrecio_Id)
 END
GO

 DROP TRIGGER venMovConformains
GO

 CREATE TRIGGER venMovConformains
ON venMovConforma
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovConforma_log(
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConformadel
GO

 CREATE TRIGGER venMovConformadel
ON venMovConforma
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovConforma_log(
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConformaupd
GO

 CREATE TRIGGER venMovConformaupd
ON venMovConforma
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovConforma_log(
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Usuario_Id,
FechaConforma,
FechaRegistro,
Observaciones,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockins
GO

 CREATE TRIGGER venMovConStockins
ON venMovConStock
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovConStock_log(
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockdel
GO

 CREATE TRIGGER venMovConStockdel
ON venMovConStock
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovConStock_log(
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockupd
GO

 CREATE TRIGGER venMovConStockupd
ON venMovConStock
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovConStock_log(
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ListaPrecio_Id,
TipoPrecioForm,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrins
GO

 CREATE TRIGGER venMovConStockCrins
ON venMovConStockCr
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovConStockCr_log(
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrdel
GO

 CREATE TRIGGER venMovConStockCrdel
ON venMovConStockCr
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovConStockCr_log(
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrupd
GO

 CREATE TRIGGER venMovConStockCrupd
ON venMovConStockCr
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovConStockCr_log(
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Producto_Id,
Deposito_Id,
Medida_Id,
Factor,
CantFacturada,
CantEntregada,
CantPendiente,
CantOriginal,
MedidaAlterna,
CantidadAlternaForm,
TipoPrecio,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioVenta,
PrecioFormImpuesto,
PrecioFormImpuestoBon,
PrecioFormImpuestoTot,
ComiPorce,
Bonificacion,
Observaciones,
FechaEntrega,
SubTotal,
SubTotalFormImpuesto,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrCtasins
GO

 CREATE TRIGGER venMovConStockCrCtasins
ON venMovConStockCrCtas
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovConStockCrCtas_log(
venMovimientos,
RenglonCuerpo,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Renglon,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrCtasdel
GO

 CREATE TRIGGER venMovConStockCrCtasdel
ON venMovConStockCrCtas
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovConStockCrCtas_log(
venMovimientos,
RenglonCuerpo,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Renglon,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrCtasupd
GO

 CREATE TRIGGER venMovConStockCrCtasupd
ON venMovConStockCrCtas
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovConStockCrCtas_log(
venMovimientos,
RenglonCuerpo,
Renglon,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Renglon,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovConStockCrPedins
GO

 CREATE TRIGGER venMovConStockCrPedins
ON venMovConStockCrPed
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovConStockCrPed_log(
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venMovConStockCrPeddel
GO

 CREATE TRIGGER venMovConStockCrPeddel
ON venMovConStockCrPed
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovConStockCrPed_log(
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venMovConStockCrPedupd
GO

 CREATE TRIGGER venMovConStockCrPedupd
ON venMovConStockCrPed
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovConStockCrPed_log(
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
venMovimientos,
RenglonCuerpo,
venReparto,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venMovCSImpuestosins
GO

 CREATE TRIGGER venMovCSImpuestosins
ON venMovCSImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovCSImpuestos_log(
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovCSImpuestosdel
GO

 CREATE TRIGGER venMovCSImpuestosdel
ON venMovCSImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovCSImpuestos_log(
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovCSImpuestosupd
GO

 CREATE TRIGGER venMovCSImpuestosupd
ON venMovCSImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovCSImpuestos_log(
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovDetalleins
GO

 CREATE TRIGGER venMovDetalleins
ON venMovDetalle
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovDetalle_log(
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovDetalledel
GO

 CREATE TRIGGER venMovDetalledel
ON venMovDetalle
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovDetalle_log(
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovDetalleupd
GO

 CREATE TRIGGER venMovDetalleupd
ON venMovDetalle
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovDetalle_log(
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Detalle,
CFVenta_Id,
Cantidad,
Medida_Id,
ImporteUnitario,
SubTotal,
ImporteUnitarioDelImpuesto,
SubTotalFormImpuesto,
CodigoFiscal,
Producto_Id,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviAnticipoins
GO

 CREATE TRIGGER venMoviAnticipoins
ON venMoviAnticipo
AFTER INSERT
AS
 BEGIN
INSERT INTO venMoviAnticipo_log(
venMovimientos,
Porcentaje,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Porcentaje,
Importe,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviAnticipodel
GO

 CREATE TRIGGER venMoviAnticipodel
ON venMoviAnticipo
AFTER DELETE
AS
 BEGIN
INSERT INTO venMoviAnticipo_log(
venMovimientos,
Porcentaje,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Porcentaje,
Importe,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviAnticipoupd
GO

 CREATE TRIGGER venMoviAnticipoupd
ON venMoviAnticipo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMoviAnticipo_log(
venMovimientos,
Porcentaje,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Porcentaje,
Importe,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviCompAsocins
GO

 CREATE TRIGGER venMoviCompAsocins
ON venMoviCompAsoc
AFTER INSERT
AS
 BEGIN
INSERT INTO venMoviCompAsoc_log(
venMoviAsociado,
venMoviFactura,
FechaModifLog,
TipoModificacion
)
(Select 
venMoviAsociado,
venMoviFactura,
GETDATE(),
'ins'
FROM inserted where venMoviAsociado=inserted.venMoviAsociado)
 END
GO

 DROP TRIGGER venMoviCompAsocdel
GO

 CREATE TRIGGER venMoviCompAsocdel
ON venMoviCompAsoc
AFTER DELETE
AS
 BEGIN
INSERT INTO venMoviCompAsoc_log(
venMoviAsociado,
venMoviFactura,
FechaModifLog,
TipoModificacion
)
(Select 
venMoviAsociado,
venMoviFactura,
GETDATE(),
'del'
FROM deleted where venMoviAsociado=deleted.venMoviAsociado)
 END
GO

 DROP TRIGGER venMoviCompAsocupd
GO

 CREATE TRIGGER venMoviCompAsocupd
ON venMoviCompAsoc
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMoviCompAsoc_log(
venMoviAsociado,
venMoviFactura,
FechaModifLog,
TipoModificacion
)
(Select 
venMoviAsociado,
venMoviFactura,
GETDATE(),
'upd'
FROM inserted where venMoviAsociado=inserted.venMoviAsociado)
 END
GO

 DROP TRIGGER venMovimientosins
GO

 CREATE TRIGGER venMovimientosins
ON venMovimientos
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientos_log(
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosdel
GO

 CREATE TRIGGER venMovimientosdel
ON venMovimientos
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientos_log(
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosupd
GO

 CREATE TRIGGER venMovimientosupd
ON venMovimientos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientos_log(
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Cliente_Id,
Sucursal,
venSubTipoMov_Id,
venTipoMov,
CondPagoCli_Id,
Vendedor_Id,
Cobrador_Id,
FormaEntrega_Id,
CondFisc_Id,
Importe,
Saldo,
SubTotal,
SubTotalBonif,
Comision1,
Comision2,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
CobraAbasto,
CambioFijo,
ComprobanteDesde,
TipoPago,
Incoterm_Id,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCFDIRins
GO

 CREATE TRIGGER venMovimientosCFDIRins
ON venMovimientosCFDIR
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosCFDIR_log(
venMovimientos,
venMovimientosR,
TipoRelacion,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosR,
TipoRelacion,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCFDIRdel
GO

 CREATE TRIGGER venMovimientosCFDIRdel
ON venMovimientosCFDIR
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosCFDIR_log(
venMovimientos,
venMovimientosR,
TipoRelacion,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosR,
TipoRelacion,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCFDIRupd
GO

 CREATE TRIGGER venMovimientosCFDIRupd
ON venMovimientosCFDIR
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosCFDIR_log(
venMovimientos,
venMovimientosR,
TipoRelacion,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venMovimientosR,
TipoRelacion,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCRExpMxins
GO

 CREATE TRIGGER venMovimientosCRExpMxins
ON venMovimientosCRExpMx
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosCRExpMx_log(
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCRExpMxdel
GO

 CREATE TRIGGER venMovimientosCRExpMxdel
ON venMovimientosCRExpMx
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosCRExpMx_log(
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosCRExpMxupd
GO

 CREATE TRIGGER venMovimientosCRExpMxupd
ON venMovimientosCRExpMx
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosCRExpMx_log(
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
CantidadAduana,
UnidadAduana,
ValorUnitarioAduana,
ValorDolares,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosExpMXins
GO

 CREATE TRIGGER venMovimientosExpMXins
ON venMovimientosExpMX
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosExpMX_log(
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosExpMXdel
GO

 CREATE TRIGGER venMovimientosExpMXdel
ON venMovimientosExpMX
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosExpMX_log(
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosExpMXupd
GO

 CREATE TRIGGER venMovimientosExpMXupd
ON venMovimientosExpMX
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosExpMX_log(
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
Motivo_id,
TipoOperacion,
ClaveDePedimento,
CertificadoOrigen,
NumCertificadoOrigen,
NumeroExportadorConfiable,
Subdivision,
Observaciones,
TipoCambioUSD,
TotalUSD,
UsaProv,
PropNumRegIdTrib,
PropResidenciaFiscal,
ReceptorNumRegIdTrib,
Destinatario_id,
SucursalDest,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscalins
GO

 CREATE TRIGGER venMovimientosFiscalins
ON venMovimientosFiscal
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosFiscal_log(
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscaldel
GO

 CREATE TRIGGER venMovimientosFiscaldel
ON venMovimientosFiscal
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosFiscal_log(
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscalupd
GO

 CREATE TRIGGER venMovimientosFiscalupd
ON venMovimientosFiscal
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosFiscal_log(
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveFiscal,
Fecha,
Letra,
Comprobante_Id,
EsFactElec,
Motivo,
XMLFiscal,
SelloDigital,
FechaString,
SelloFiscal,
NoCertificadoFiscal,
NoCertificadoPropio,
FechaAutorizacion,
FechaDesde,
NumeroDesde,
NumeroHasta,
RfcProvCertif,
Leyenda,
TipoProceso,
TipoComite,
idContabilidad,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscalINEins
GO

 CREATE TRIGGER venMovimientosFiscalINEins
ON venMovimientosFiscalINE
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosFiscalINE_log(
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscalINEdel
GO

 CREATE TRIGGER venMovimientosFiscalINEdel
ON venMovimientosFiscalINE
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosFiscalINE_log(
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosFiscalINEupd
GO

 CREATE TRIGGER venMovimientosFiscalINEupd
ON venMovimientosFiscalINE
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosFiscalINE_log(
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
ClaveIdentidad,
idContabilidad,
Ambito,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosMetodoPagoins
GO

 CREATE TRIGGER venMovimientosMetodoPagoins
ON venMovimientosMetodoPago
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovimientosMetodoPago_log(
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosMetodoPagodel
GO

 CREATE TRIGGER venMovimientosMetodoPagodel
ON venMovimientosMetodoPago
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovimientosMetodoPago_log(
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovimientosMetodoPagoupd
GO

 CREATE TRIGGER venMovimientosMetodoPagoupd
ON venMovimientosMetodoPago
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovimientosMetodoPago_log(
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
MetodoPago,
CuentaPago,
NMetodoPago,
UsoCfdi,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovImpTrasladoins
GO

 CREATE TRIGGER venMovImpTrasladoins
ON venMovImpTraslado
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovImpTraslado_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
GETDATE(),
'ins'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venMovImpTrasladodel
GO

 CREATE TRIGGER venMovImpTrasladodel
ON venMovImpTraslado
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovImpTraslado_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
GETDATE(),
'del'
FROM deleted where Asiento_Id=deleted.Asiento_Id)
 END
GO

 DROP TRIGGER venMovImpTrasladoupd
GO

 CREATE TRIGGER venMovImpTrasladoupd
ON venMovImpTraslado
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovImpTraslado_log(
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
FechaModifLog,
TipoModificacion
)
(Select 
Asiento_Id,
RenglonDebe,
RenglonHaber,
venMovimientos,
tesMovimientos,
Impuesto_Id,
Cliente_Id,
Cartera_Id,
Banco_Id,
BaseImponible,
Monto,
TotalCobro,
GETDATE(),
'upd'
FROM inserted where Asiento_Id=inserted.Asiento_Id)
 END
GO

 DROP TRIGGER venMovImpuestosins
GO

 CREATE TRIGGER venMovImpuestosins
ON venMovImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovImpuestosdel
GO

 CREATE TRIGGER venMovImpuestosdel
ON venMovImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovImpuestosupd
GO

 CREATE TRIGGER venMovImpuestosupd
ON venMovImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Porcentaje,
BaseImponible,
Importe,
BaseImponibleMonedaNac,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviPredialins
GO

 CREATE TRIGGER venMoviPredialins
ON venMoviPredial
AFTER INSERT
AS
 BEGIN
INSERT INTO venMoviPredial_log(
venMovimientos,
conRenglon,
CuentaPredial,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
CuentaPredial,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviPredialdel
GO

 CREATE TRIGGER venMoviPredialdel
ON venMoviPredial
AFTER DELETE
AS
 BEGIN
INSERT INTO venMoviPredial_log(
venMovimientos,
conRenglon,
CuentaPredial,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
CuentaPredial,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMoviPredialupd
GO

 CREATE TRIGGER venMoviPredialupd
ON venMoviPredial
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMoviPredial_log(
venMovimientos,
conRenglon,
CuentaPredial,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
CuentaPredial,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovSSImpuestosins
GO

 CREATE TRIGGER venMovSSImpuestosins
ON venMovSSImpuestos
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovSSImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovSSImpuestosdel
GO

 CREATE TRIGGER venMovSSImpuestosdel
ON venMovSSImpuestos
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovSSImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovSSImpuestosupd
GO

 CREATE TRIGGER venMovSSImpuestosupd
ON venMovSSImpuestos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovSSImpuestos_log(
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
conRenglon,
Impuesto_Id,
Importe,
ImporteMonedaNac,
Porcentaje,
BaseImponible,
BaseImponibleMonedaNac,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovStkHistins
GO

 CREATE TRIGGER venMovStkHistins
ON venMovStkHist
AFTER INSERT
AS
 BEGIN
INSERT INTO venMovStkHist_log(
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venMovStkHistdel
GO

 CREATE TRIGGER venMovStkHistdel
ON venMovStkHist
AFTER DELETE
AS
 BEGIN
INSERT INTO venMovStkHist_log(
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venMovStkHistupd
GO

 CREATE TRIGGER venMovStkHistupd
ON venMovStkHist
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venMovStkHist_log(
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
RenglonCuerpo,
stkMoviCabe,
Renglon,
Cantidad,
FacturaRemito,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venNivelesAutoins
GO

 CREATE TRIGGER venNivelesAutoins
ON venNivelesAuto
AFTER INSERT
AS
 BEGIN
INSERT INTO venNivelesAuto_log(
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where venNivelesAuto=inserted.venNivelesAuto)
 END
GO

 DROP TRIGGER venNivelesAutodel
GO

 CREATE TRIGGER venNivelesAutodel
ON venNivelesAuto
AFTER DELETE
AS
 BEGIN
INSERT INTO venNivelesAuto_log(
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where venNivelesAuto=deleted.venNivelesAuto)
 END
GO

 DROP TRIGGER venNivelesAutoupd
GO

 CREATE TRIGGER venNivelesAutoupd
ON venNivelesAuto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venNivelesAuto_log(
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venNivelesAuto,
NivelAuto_Id,
Empresa_Id,
Descripcion,
Inactivo,
Posteado,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where venNivelesAuto=inserted.venNivelesAuto)
 END
GO

 DROP TRIGGER venNivelesAutoUsuins
GO

 CREATE TRIGGER venNivelesAutoUsuins
ON venNivelesAutoUsu
AFTER INSERT
AS
 BEGIN
INSERT INTO venNivelesAutoUsu_log(
Usuario_Id,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
NivelAuto_Id,
GETDATE(),
'ins'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER venNivelesAutoUsudel
GO

 CREATE TRIGGER venNivelesAutoUsudel
ON venNivelesAutoUsu
AFTER DELETE
AS
 BEGIN
INSERT INTO venNivelesAutoUsu_log(
Usuario_Id,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
NivelAuto_Id,
GETDATE(),
'del'
FROM deleted where Usuario_Id=deleted.Usuario_Id)
 END
GO

 DROP TRIGGER venNivelesAutoUsuupd
GO

 CREATE TRIGGER venNivelesAutoUsuupd
ON venNivelesAutoUsu
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venNivelesAutoUsu_log(
Usuario_Id,
NivelAuto_Id,
FechaModifLog,
TipoModificacion
)
(Select 
Usuario_Id,
NivelAuto_Id,
GETDATE(),
'upd'
FROM inserted where Usuario_Id=inserted.Usuario_Id)
 END
GO

 DROP TRIGGER venNPAutorizandoins
GO

 CREATE TRIGGER venNPAutorizandoins
ON venNPAutorizando
AFTER INSERT
AS
 BEGIN
INSERT INTO venNPAutorizando_log(
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venNPAutorizandodel
GO

 CREATE TRIGGER venNPAutorizandodel
ON venNPAutorizando
AFTER DELETE
AS
 BEGIN
INSERT INTO venNPAutorizando_log(
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venNPAutorizandoupd
GO

 CREATE TRIGGER venNPAutorizandoupd
ON venNPAutorizando
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venNPAutorizando_log(
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Secuencia,
Usuario_Id,
Fecha,
TipoApro,
NivelAuto_Id,
ResultadoFormula,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediAnticiposins
GO

 CREATE TRIGGER venPediAnticiposins
ON venPediAnticipos
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediAnticipos_log(
Pedido_Id,
venMovimientos,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
Pedido_Id,
venMovimientos,
Importe,
Signo,
GETDATE(),
'ins'
FROM inserted where Pedido_Id=inserted.Pedido_Id)
 END
GO

 DROP TRIGGER venPediAnticiposdel
GO

 CREATE TRIGGER venPediAnticiposdel
ON venPediAnticipos
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediAnticipos_log(
Pedido_Id,
venMovimientos,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
Pedido_Id,
venMovimientos,
Importe,
Signo,
GETDATE(),
'del'
FROM deleted where Pedido_Id=deleted.Pedido_Id)
 END
GO

 DROP TRIGGER venPediAnticiposupd
GO

 CREATE TRIGGER venPediAnticiposupd
ON venPediAnticipos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediAnticipos_log(
Pedido_Id,
venMovimientos,
Importe,
Signo,
FechaModifLog,
TipoModificacion
)
(Select 
Pedido_Id,
venMovimientos,
Importe,
Signo,
GETDATE(),
'upd'
FROM inserted where Pedido_Id=inserted.Pedido_Id)
 END
GO

 DROP TRIGGER venPediCuerpoins
GO

 CREATE TRIGGER venPediCuerpoins
ON venPediCuerpo
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediCuerpo_log(
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediCuerpodel
GO

 CREATE TRIGGER venPediCuerpodel
ON venPediCuerpo
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediCuerpo_log(
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venPediCuerpoupd
GO

 CREATE TRIGGER venPediCuerpoupd
ON venPediCuerpo
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediCuerpo_log(
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Producto_Id,
Medida_Id,
Deposito_Id,
Factor,
CantidadOriginal,
CantidadPedida,
CantidadRemitida,
CantidadFacturada,
PrecioForm,
PrecioSinIva,
PrecioLista,
PrecioListaForm,
PrecioVenta,
TipoPrecio,
SubTotal,
FechaEntrega,
Especial,
Bonificacion,
Observaciones,
Pendiente,
ReservaMercaderia,
Centro1_Id,
Centro2_Id,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosins
GO

 CREATE TRIGGER venPedidosins
ON venPedidos
AFTER INSERT
AS
 BEGIN
INSERT INTO venPedidos_log(
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosdel
GO

 CREATE TRIGGER venPedidosdel
ON venPedidos
AFTER DELETE
AS
 BEGIN
INSERT INTO venPedidos_log(
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosupd
GO

 CREATE TRIGGER venPedidosupd
ON venPedidos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPedidos_log(
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Empresa_Id,
SubTipoMov_Id,
Fecha,
Cliente_Id,
Sucursal,
SucursalUsu,
Moneda_Id,
MonedaFacturacion,
CondPagoCli_Id,
ListaPrecio_Id,
Vendedor_Id,
FormaEntrega_Id,
Estado,
UsuarioAutoriz_Id,
FechaAutorizo,
Observaciones,
ObservEstado,
Motivo_Id,
SubTotal,
SubTotalBonif,
ImporteTotal,
Bonificacion1,
Bonificacion2,
Bonificacion3,
Bonificacion4,
Bonificacion5,
Dato1,
Dato2,
Dato3,
FechaUltMod,
CliOrdenCompra,
venNroPedido,
FacturaAnticipo,
TrabaDespacho,
PorAnticipo,
Anticipo,
AnticipoPendiente,
ObsAnticipo,
TipoPrecioForm,
CongelaCambio,
Fecha_Registro,
Cambio,
Incoterm_Id,
SoloEntrega,
Usuario_Id,
Posteado,
MetodoPago,
UsoCfdi,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosAnulins
GO

 CREATE TRIGGER venPedidosAnulins
ON venPedidosAnul
AFTER INSERT
AS
 BEGIN
INSERT INTO venPedidosAnul_log(
venPedidos,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosAnuldel
GO

 CREATE TRIGGER venPedidosAnuldel
ON venPedidosAnul
AFTER DELETE
AS
 BEGIN
INSERT INTO venPedidosAnul_log(
venPedidos,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venPedidosAnulupd
GO

 CREATE TRIGGER venPedidosAnulupd
ON venPedidosAnul
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPedidosAnul_log(
venPedidos,
Fecha,
Operacion,
Usuario_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Fecha,
Operacion,
Usuario_Id,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediFacturadosins
GO

 CREATE TRIGGER venPediFacturadosins
ON venPediFacturados
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediFacturados_log(
venMovimientos,
venPedidos,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venPedidos,
Importe,
GETDATE(),
'ins'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venPediFacturadosdel
GO

 CREATE TRIGGER venPediFacturadosdel
ON venPediFacturados
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediFacturados_log(
venMovimientos,
venPedidos,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venPedidos,
Importe,
GETDATE(),
'del'
FROM deleted where venMovimientos=deleted.venMovimientos)
 END
GO

 DROP TRIGGER venPediFacturadosupd
GO

 CREATE TRIGGER venPediFacturadosupd
ON venPediFacturados
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediFacturados_log(
venMovimientos,
venPedidos,
Importe,
FechaModifLog,
TipoModificacion
)
(Select 
venMovimientos,
venPedidos,
Importe,
GETDATE(),
'upd'
FROM inserted where venMovimientos=inserted.venMovimientos)
 END
GO

 DROP TRIGGER venPediRemitidosins
GO

 CREATE TRIGGER venPediRemitidosins
ON venPediRemitidos
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediRemitidos_log(
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediRemitidosdel
GO

 CREATE TRIGGER venPediRemitidosdel
ON venPediRemitidos
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediRemitidos_log(
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venPediRemitidosupd
GO

 CREATE TRIGGER venPediRemitidosupd
ON venPediRemitidos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediRemitidos_log(
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
Renglon_Pe,
Renglon,
stkMoviCabe,
venReparto,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediSegmentosins
GO

 CREATE TRIGGER venPediSegmentosins
ON venPediSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venPediSegmentosdel
GO

 CREATE TRIGGER venPediSegmentosdel
ON venPediSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER venPediSegmentosupd
GO

 CREATE TRIGGER venPediSegmentosupd
ON venPediSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venPedidos,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venPediValiComerins
GO

 CREATE TRIGGER venPediValiComerins
ON venPediValiComer
AFTER INSERT
AS
 BEGIN
INSERT INTO venPediValiComer_log(
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
GETDATE(),
'ins'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venPediValiComerdel
GO

 CREATE TRIGGER venPediValiComerdel
ON venPediValiComer
AFTER DELETE
AS
 BEGIN
INSERT INTO venPediValiComer_log(
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
GETDATE(),
'del'
FROM deleted where venPedidos=deleted.venPedidos)
 END
GO

 DROP TRIGGER venPediValiComerupd
GO

 CREATE TRIGGER venPediValiComerupd
ON venPediValiComer
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venPediValiComer_log(
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
FechaModifLog,
TipoModificacion
)
(Select 
venPedidos,
MVendedor,
MFormaE,
MListaP,
MBonifDato,
MBonifReng,
MPrecioReng,
GETDATE(),
'upd'
FROM inserted where venPedidos=inserted.venPedidos)
 END
GO

 DROP TRIGGER venRegionins
GO

 CREATE TRIGGER venRegionins
ON venRegion
AFTER INSERT
AS
 BEGIN
INSERT INTO venRegion_log(
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venRegion=inserted.venRegion)
 END
GO

 DROP TRIGGER venRegiondel
GO

 CREATE TRIGGER venRegiondel
ON venRegion
AFTER DELETE
AS
 BEGIN
INSERT INTO venRegion_log(
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venRegion=deleted.venRegion)
 END
GO

 DROP TRIGGER venRegionupd
GO

 CREATE TRIGGER venRegionupd
ON venRegion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRegion_log(
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venRegion,
Region_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venRegion=inserted.venRegion)
 END
GO

 DROP TRIGGER venRepaPediins
GO

 CREATE TRIGGER venRepaPediins
ON venRepaPedi
AFTER INSERT
AS
 BEGIN
INSERT INTO venRepaPedi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
GETDATE(),
'ins'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaPedidel
GO

 CREATE TRIGGER venRepaPedidel
ON venRepaPedi
AFTER DELETE
AS
 BEGIN
INSERT INTO venRepaPedi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
GETDATE(),
'del'
FROM deleted where venReparto=deleted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediupd
GO

 CREATE TRIGGER venRepaPediupd
ON venRepaPedi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRepaPedi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
CantidadForm,
CantidadAlternaForm,
Remitido,
Facturado,
GETDATE(),
'upd'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSerieins
GO

 CREATE TRIGGER venRepaPediSerieins
ON venRepaPediSerie
AFTER INSERT
AS
 BEGIN
INSERT INTO venRepaPediSerie_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
GETDATE(),
'ins'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSeriedel
GO

 CREATE TRIGGER venRepaPediSeriedel
ON venRepaPediSerie
AFTER DELETE
AS
 BEGIN
INSERT INTO venRepaPediSerie_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
GETDATE(),
'del'
FROM deleted where venReparto=deleted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSerieupd
GO

 CREATE TRIGGER venRepaPediSerieupd
ON venRepaPediSerie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRepaPediSerie_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Cantidad,
GETDATE(),
'upd'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSerieUbiins
GO

 CREATE TRIGGER venRepaPediSerieUbiins
ON venRepaPediSerieUbi
AFTER INSERT
AS
 BEGIN
INSERT INTO venRepaPediSerieUbi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'ins'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSerieUbidel
GO

 CREATE TRIGGER venRepaPediSerieUbidel
ON venRepaPediSerieUbi
AFTER DELETE
AS
 BEGIN
INSERT INTO venRepaPediSerieUbi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'del'
FROM deleted where venReparto=deleted.venReparto)
 END
GO

 DROP TRIGGER venRepaPediSerieUbiupd
GO

 CREATE TRIGGER venRepaPediSerieUbiupd
ON venRepaPediSerieUbi
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRepaPediSerieUbi_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Serie,
Ubicacion_Id,
Cantidad,
GETDATE(),
'upd'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepartoins
GO

 CREATE TRIGGER venRepartoins
ON venReparto
AFTER INSERT
AS
 BEGIN
INSERT INTO venReparto_log(
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
GETDATE(),
'ins'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepartodel
GO

 CREATE TRIGGER venRepartodel
ON venReparto
AFTER DELETE
AS
 BEGIN
INSERT INTO venReparto_log(
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
GETDATE(),
'del'
FROM deleted where venReparto=deleted.venReparto)
 END
GO

 DROP TRIGGER venRepartoupd
GO

 CREATE TRIGGER venRepartoupd
ON venReparto
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venReparto_log(
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Empresa_Id,
Sucursal,
FechaReparto,
FechaEntrega,
Deposito_Id,
ZonaDesde,
ZonaHasta,
TipoClieDesde,
TipoClieHasta,
ClienteDesde,
ClienteHasta,
DepoPedido_Id,
Automatico,
Cerrado,
GETDATE(),
'upd'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaSegmentosins
GO

 CREATE TRIGGER venRepaSegmentosins
ON venRepaSegmentos
AFTER INSERT
AS
 BEGIN
INSERT INTO venRepaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
GETDATE(),
'ins'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venRepaSegmentosdel
GO

 CREATE TRIGGER venRepaSegmentosdel
ON venRepaSegmentos
AFTER DELETE
AS
 BEGIN
INSERT INTO venRepaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
GETDATE(),
'del'
FROM deleted where Empresa_Id=deleted.Empresa_Id)
 END
GO

 DROP TRIGGER venRepaSegmentosupd
GO

 CREATE TRIGGER venRepaSegmentosupd
ON venRepaSegmentos
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRepaSegmentos_log(
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
FechaModifLog,
TipoModificacion
)
(Select 
Empresa_Id,
Segmento_Id,
Segmento1N,
Segmento2N,
Segmento3N,
Segmento4N,
Segmento1C,
Segmento2C,
Segmento3C,
Segmento4C,
venReparto,
GETDATE(),
'upd'
FROM inserted where Empresa_Id=inserted.Empresa_Id)
 END
GO

 DROP TRIGGER venRepaUbicacionins
GO

 CREATE TRIGGER venRepaUbicacionins
ON venRepaUbicacion
AFTER INSERT
AS
 BEGIN
INSERT INTO venRepaUbicacion_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
GETDATE(),
'ins'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venRepaUbicaciondel
GO

 CREATE TRIGGER venRepaUbicaciondel
ON venRepaUbicacion
AFTER DELETE
AS
 BEGIN
INSERT INTO venRepaUbicacion_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
GETDATE(),
'del'
FROM deleted where venReparto=deleted.venReparto)
 END
GO

 DROP TRIGGER venRepaUbicacionupd
GO

 CREATE TRIGGER venRepaUbicacionupd
ON venRepaUbicacion
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venRepaUbicacion_log(
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
FechaModifLog,
TipoModificacion
)
(Select 
venReparto,
Renglon_Rep,
venPedidos,
Renglon_Pe,
Ubicacion_Id,
CantidadForm,
CantidadAlternaForm,
GETDATE(),
'upd'
FROM inserted where venReparto=inserted.venReparto)
 END
GO

 DROP TRIGGER venSTMAfipins
GO

 CREATE TRIGGER venSTMAfipins
ON venSTMAfip
AFTER INSERT
AS
 BEGIN
INSERT INTO venSTMAfip_log(
venSubTipoMov,
Letra,
Comprobante_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
Letra,
Comprobante_Id,
GETDATE(),
'ins'
FROM inserted where venSubTipoMov=inserted.venSubTipoMov)
 END
GO

 DROP TRIGGER venSTMAfipdel
GO

 CREATE TRIGGER venSTMAfipdel
ON venSTMAfip
AFTER DELETE
AS
 BEGIN
INSERT INTO venSTMAfip_log(
venSubTipoMov,
Letra,
Comprobante_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
Letra,
Comprobante_Id,
GETDATE(),
'del'
FROM deleted where venSubTipoMov=deleted.venSubTipoMov)
 END
GO

 DROP TRIGGER venSTMAfipupd
GO

 CREATE TRIGGER venSTMAfipupd
ON venSTMAfip
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venSTMAfip_log(
venSubTipoMov,
Letra,
Comprobante_Id,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
Letra,
Comprobante_Id,
GETDATE(),
'upd'
FROM inserted where venSubTipoMov=inserted.venSubTipoMov)
 END
GO

 DROP TRIGGER venSubTipoMovins
GO

 CREATE TRIGGER venSubTipoMovins
ON venSubTipoMov
AFTER INSERT
AS
 BEGIN
INSERT INTO venSubTipoMov_log(
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
GETDATE(),
'ins'
FROM inserted where venSubTipoMov=inserted.venSubTipoMov)
 END
GO

 DROP TRIGGER venSubTipoMovdel
GO

 CREATE TRIGGER venSubTipoMovdel
ON venSubTipoMov
AFTER DELETE
AS
 BEGIN
INSERT INTO venSubTipoMov_log(
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
GETDATE(),
'del'
FROM deleted where venSubTipoMov=deleted.venSubTipoMov)
 END
GO

 DROP TRIGGER venSubTipoMovupd
GO

 CREATE TRIGGER venSubTipoMovupd
ON venSubTipoMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venSubTipoMov_log(
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
FechaModifLog,
TipoModificacion
)
(Select 
venSubTipoMov,
SubTipoMov_Id,
Empresa_Id,
venTipoMov,
Descripcion,
MueveStock,
EsVentaContado,
AdmiteDevolucion,
ModificaPrecio,
Reservado,
GeneraRemito,
SegmentoRemito_Id,
NCxDevolucion,
UsuarioAutorizado,
AdmiteBoniRenglon,
Centro1_Id,
Centro2_Id,
PideCambio,
ModFecha,
ModCondPago,
ModVendedor,
ModCobrador,
PideObervaciones,
CantidadCopias,
ModDeposito,
ModListaPrecios,
PideFechaEntrega,
PideObsReng,
CtaDefecto,
ModCtaDefecto,
ModCentro1,
ModCentro2,
PideOtrosCargos,
CtaOtrosCargos,
PermModCtaOtCar,
FechaEntregaporRen,
AdmiteFactsinEntr,
ModiUniMed,
AfectaComVenta,
AfectaComCobra,
MaxCantItems,
EsPorDifPrecio,
AfectaEstadistica,
ClaveAcceso,
EsPorDifCambio,
TipoPrecioForm,
SoloImpuestos,
CodigoFormulario,
BajoCosto,
Administrativa,
PideReferencia,
PideOrdenCompra,
PideCongelarCambio,
PideMarcaReserva,
PermiteSoloEntrega,
CodigoFiscal,
PidePredial,
PideCodProd,
PideComExpoMX,
Reporte_Id,
Inactivo,
Usuario_Id,
Posteado,
EsquemaAuto_Id,
PorCotizacion,
EsContado,
GETDATE(),
'upd'
FROM inserted where venSubTipoMov=inserted.venSubTipoMov)
 END
GO

 DROP TRIGGER venTipoMovins
GO

 CREATE TRIGGER venTipoMovins
ON venTipoMov
AFTER INSERT
AS
 BEGIN
INSERT INTO venTipoMov_log(
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
FechaModifLog,
TipoModificacion
)
(Select 
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
GETDATE(),
'ins'
FROM inserted where venTipoMov=inserted.venTipoMov)
 END
GO

 DROP TRIGGER venTipoMovdel
GO

 CREATE TRIGGER venTipoMovdel
ON venTipoMov
AFTER DELETE
AS
 BEGIN
INSERT INTO venTipoMov_log(
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
FechaModifLog,
TipoModificacion
)
(Select 
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
GETDATE(),
'del'
FROM deleted where venTipoMov=deleted.venTipoMov)
 END
GO

 DROP TRIGGER venTipoMovupd
GO

 CREATE TRIGGER venTipoMovupd
ON venTipoMov
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venTipoMov_log(
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
FechaModifLog,
TipoModificacion
)
(Select 
venTipoMov,
Descripcion,
Signo,
TipoMovResumido,
GETDATE(),
'upd'
FROM inserted where venTipoMov=inserted.venTipoMov)
 END
GO

 DROP TRIGGER venTiposClieins
GO

 CREATE TRIGGER venTiposClieins
ON venTiposClie
AFTER INSERT
AS
 BEGIN
INSERT INTO venTiposClie_log(
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venTiposClie=inserted.venTiposClie)
 END
GO

 DROP TRIGGER venTiposCliedel
GO

 CREATE TRIGGER venTiposCliedel
ON venTiposClie
AFTER DELETE
AS
 BEGIN
INSERT INTO venTiposClie_log(
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venTiposClie=deleted.venTiposClie)
 END
GO

 DROP TRIGGER venTiposClieupd
GO

 CREATE TRIGGER venTiposClieupd
ON venTiposClie
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venTiposClie_log(
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venTiposClie,
TipoClie_Id,
Empresa_Id,
Descripcion,
Centro1_Id,
Centro2_Id,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venTiposClie=inserted.venTiposClie)
 END
GO

 DROP TRIGGER venVendedoresins
GO

 CREATE TRIGGER venVendedoresins
ON venVendedores
AFTER INSERT
AS
 BEGIN
INSERT INTO venVendedores_log(
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'ins'
FROM inserted where venVendedores=inserted.venVendedores)
 END
GO

 DROP TRIGGER venVendedoresdel
GO

 CREATE TRIGGER venVendedoresdel
ON venVendedores
AFTER DELETE
AS
 BEGIN
INSERT INTO venVendedores_log(
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'del'
FROM deleted where venVendedores=deleted.venVendedores)
 END
GO

 DROP TRIGGER venVendedoresupd
GO

 CREATE TRIGGER venVendedoresupd
ON venVendedores
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venVendedores_log(
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venVendedores,
Vendedor_Id,
Empresa_Id,
Nombre,
Usuario,
Comision,
ComisionxSuperv,
Supervisor_Id,
PisoDeVentas,
Centro1_Id,
Centro2_Id,
FacturaCobrada,
ConAnticipos,
SinImpuestos,
Usuario_Id,
Inactivo,
Posteado,
GETDATE(),
'upd'
FROM inserted where venVendedores=inserted.venVendedores)
 END
GO

 DROP TRIGGER venZonains
GO

 CREATE TRIGGER venZonains
ON venZona
AFTER INSERT
AS
 BEGIN
INSERT INTO venZona_log(
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'ins'
FROM inserted where venZona=inserted.venZona)
 END
GO

 DROP TRIGGER venZonadel
GO

 CREATE TRIGGER venZonadel
ON venZona
AFTER DELETE
AS
 BEGIN
INSERT INTO venZona_log(
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'del'
FROM deleted where venZona=deleted.venZona)
 END
GO

 DROP TRIGGER venZonaupd
GO

 CREATE TRIGGER venZonaupd
ON venZona
AFTER  UPDATE
AS
 BEGIN
INSERT INTO venZona_log(
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
FechaModifLog,
TipoModificacion
)
(Select 
venZona,
Zona_Id,
Empresa_Id,
Descripcion,
Inactivo,
Usuario_Id,
Posteado,
GETDATE(),
'upd'
FROM inserted where venZona=inserted.venZona)
 END
GO

