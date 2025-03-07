using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSKFEEventos
{
    public class espvenComandasDatosKSK
    {
        [Generalidades.QFuncion_AccionGrilla]
        public KSKCommon.espvenComandasDatosKSKDS Facturar(KSKCommon.espvenComandasDatosKSKDS pCommonDS, KSKCommon.espvenComandasDatosKSKDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            KSKExchange.espvenComandasDatosKSKActionExchange exchComanda = new KSKExchange.espvenComandasDatosKSKActionExchange(KSKExchange.espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction.FacturarTicket);
            exchComanda.Param.Merge(pCommonDSNoPost, false, System.Data.MissingSchemaAction.Ignore);
            exchComanda.Param.Principal[0].Delete();
            exchComanda.Param.Comandas.Clear();
            exchComanda.Param.Comandas.AddComandasRow(pCommonDSNoPost.Comandas[pIndice].Comanda, pCommonDSNoPost.Comandas[pIndice].Ticket, pCommonDSNoPost.Comandas[pIndice].Importe, pCommonDSNoPost.Comandas[pIndice].Cliente_Id, pCommonDSNoPost.Comandas[pIndice].RazonSocial, pCommonDSNoPost.Comandas[pIndice].Saldo);
            exchComanda.Param.AcceptChanges();

            Generalidades.QBIInternal.WrapperExecuteActionInternal(exchComanda, cmd);
            
            return pCommonDS;
        }

        [Generalidades.QFuncion_MostrarHTML]
        public string HTMLTicket(KSKCommon.espvenComandasDatosKSKDS pCommonDS, KSKCommon.espvenComandasDatosKSKDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            // A través del número interno obtengo los datos del comprobante //
            GeneralesExchange.genAsiSegmentosActionExchange exchSeg = new GeneralesExchange.genAsiSegmentosActionExchange(GeneralesExchange.genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.DatosInt)
            {
                Asiento_Id = pCommonDS.Comandas[pIndice].Comanda
            };
            exchSeg = new GeneralesExchange.genAsiSegmentosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSeg, cmd));

            // y lo traigo //
            VentasExchange.venMovimientosConStockActionExchange exchVMCT = new VentasExchange.venMovimientosConStockActionExchange(VentasExchange.venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Datos)
            {
                Segmento_Id = exchSeg.Segmento_Id,
                Segmento1C = exchSeg.Segmento1C,
                Segmento2C = exchSeg.Segmento2C,
                Segmento3C = exchSeg.Segmento3C,
                Segmento4C = exchSeg.Segmento4C,
                Segmento1N = exchSeg.Segmento1N,
                Segmento2N = exchSeg.Segmento2N,
                Segmento3N = exchSeg.Segmento3N,
                Segmento4N = exchSeg.Segmento4N,
                Empresa_Id = cmd.Empresa_Id
            };
            exchVMCT = new VentasExchange.venMovimientosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchVMCT, cmd));


            return Comunes.HTMLTicket(exchVMCT.Param, exchVMCT.Param, pIndice, cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public KSKCommon.espvenComandasDatosKSKDS QuitarTicket(KSKCommon.espvenComandasDatosKSKDS pCommonDS, KSKCommon.espvenComandasDatosKSKDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            // Borro la que acabo de facturar porque no está más pendiente //
            pCommonDS.Comandas[pIndice].Delete();
            pCommonDS.Comandas.AcceptChanges();

            return pCommonDS;
        }
    }
}
