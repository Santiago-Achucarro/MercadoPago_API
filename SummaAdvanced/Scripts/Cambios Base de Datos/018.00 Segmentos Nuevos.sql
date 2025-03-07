IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 18.00)
begin

INSERT INTO genVersion(Version) Values(18.00);


exec genSegmentosGuardar @pSegmento_Id='PRAJU',@pSegmento_Id_Nuevo='PRAJU',@pDescripcion='AJUSTES A PROVEEDORES',@pDigitos1N=8,@pDigitos2N=0,@pDigitos3N=0,@pDigitos4N=0,@pTieneColumnaAutomatica=1,@pDigitos1C=1,@pDigitos2C=4,@pDigitos3C=0,@pDigitos4C=0,@pOrigen1N=1,@pOrigen2N=0,@pOrigen3N=0,@pOrigen4N=0,@pOrigen1C=8,@pOrigen2C=11,@pOrigen3C=0,@pOrigen4C=0,@pOrden1N=2,@pOrden2N=0,@pOrden3N=0,@pOrden4N=0,@pOrden1C=1,@pOrden2C=0,@pOrden3C=0,@pOrden4C=0,@pHabilitaEdicion=0,@pTamanioVariable='1N',@pInactivo=0,@pUsuario_Id=1,@pPosteado=1
exec genSegmentosNombresGuardar @pSegmento_Id=20,@pNombre1N='Comprobante',@pNombre2N='',@pNombre3N='',@pNombre4N='',@pNombre1C='TM',@pNombre2C='Suc',@pNombre3C='',@pNombre4C='',@pUsuario_Id=1

exec genSegmentosGuardar @pSegmento_Id='REVOC',@pSegmento_Id_Nuevo='REVOC',@pDescripcion='Reversion de Recepciones OC No Codificado',@pDigitos1N=8,@pDigitos2N=0,@pDigitos3N=0,@pDigitos4N=0,@pTieneColumnaAutomatica=1,@pDigitos1C=4,@pDigitos2C=0,@pDigitos3C=0,@pDigitos4C=0,@pOrigen1N=1,@pOrigen2N=0,@pOrigen3N=0,@pOrigen4N=0,@pOrigen1C=11,@pOrigen2C=0,@pOrigen3C=0,@pOrigen4C=0,@pOrden1N=2,@pOrden2N=0,@pOrden3N=0,@pOrden4N=0,@pOrden1C=1,@pOrden2C=0,@pOrden3C=0,@pOrden4C=0,@pHabilitaEdicion=0,@pTamanioVariable='1N',@pInactivo=0,@pUsuario_Id=1,@pPosteado=1
exec genSegmentosNombresGuardar @pSegmento_Id=21,@pNombre1N='Comprob',@pNombre2N='',@pNombre3N='',@pNombre4N='',@pNombre1C='Suc',@pNombre2C='',@pNombre3C='',@pNombre4C='',@pUsuario_Id=1

end
