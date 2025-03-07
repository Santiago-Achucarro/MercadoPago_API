using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasExchange;

namespace GeneralesFEEventos
{
    public class genLogRequestDatosTodos
    {
        [Generalidades.QFuncion_AccionGrilla]
        public GeneralesCommon.genLogRequestDatosTodosDS Procesar(GeneralesCommon.genLogRequestDatosTodosDS pCommonDS, GeneralesCommon.genLogRequestDatosTodosDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            GeneralesExchange.genLogRequestActionExchange exchLog = new GeneralesExchange.genLogRequestActionExchange(GeneralesExchange.genLogRequestActionEnum.EnumgenLogRequestAction.EliminarXSeg)
            {
                Empresa_Id = cmd.Empresa_Id,
                Segmento_Id = pCommonDS.Request[pIndice].Segmento_Id,
                Segmento1C = pCommonDS.Request[pIndice].Segmento1C,
                Segmento2C = pCommonDS.Request[pIndice].Segmento2C,
                Segmento3C = pCommonDS.Request[pIndice].Segmento3C,
                Segmento4C = pCommonDS.Request[pIndice].Segmento4C,
                Segmento1N = pCommonDS.Request[pIndice].Segmento1N,
                Segmento2N = pCommonDS.Request[pIndice].Segmento2N,
                Segmento3N = pCommonDS.Request[pIndice].Segmento3N,
                Segmento4N = pCommonDS.Request[pIndice].Segmento4N
            };

            string lExchange = pCommonDS.Request[pIndice].NombreClase;
            string lAccion = pCommonDS.Request[pIndice].Accion;

            switch(lExchange)
            {
                case "venFacturacionPedidoActionExchange":
                    {
                        // Acá no sé si puedo saber si ya se volvió a facturar por la opción original //

                        venFacturacionPedidoActionExchange exch = new venFacturacionPedidoActionExchange();
                        exch.Param.Merge(Generalidades.DatsetJson.JsonToDatset(pCommonDS.Request[pIndice].Request, exch.Param.GetType()));
                        exch.Param.Principal[0].Delete();
                        exch.Param.AcceptChanges();

                        exch.Action = lAccion;

                        Generalidades.QBIInternal.WrapperExecuteActionInternal(exch, cmd);

                        // Borro el log de este comprobante //
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLog, cmd);

                        break;
                    }
                case "venMovimientosConStockActionExchange":
                    {
                        venMovimientosConStockActionExchange exch = new venMovimientosConStockActionExchange();
                        exch.Param.Merge(Generalidades.DatsetJson.JsonToDatset(pCommonDS.Request[pIndice].Request, exch.Param.GetType()));
                        exch.Param.Principal[0].Delete();
                        exch.Param.AcceptChanges();

                        exch.Action = lAccion;

                        GeneralesExchange.genAsiSegmentosActionExchange exchMov = new GeneralesExchange.genAsiSegmentosActionExchange(GeneralesExchange.genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Datos)
                        {
                            Segmento_Id = exch.Segmento_Id,
                            Segmento1C = exch.Segmento1C,
                            Segmento2C = exch.Segmento2C,
                            Segmento3C = exch.Segmento3C,
                            Segmento4C = exch.Segmento4C,
                            Segmento1N = exch.Segmento1N,
                            Segmento2N = exch.Segmento2N,
                            Segmento3N = exch.Segmento3N,
                            Segmento4N = exch.Segmento4N
                        };
                        exchMov = new GeneralesExchange.genAsiSegmentosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchMov, cmd));

                        if (!exchMov.Existe)
                        {
                            // Tal vez lo volvieron a hacer desde la opción original //
                            Generalidades.QBIInternal.WrapperExecuteActionInternal(exch, cmd);
                        }

                        // Borro el log de este comprobante //
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLog, cmd);

                        break;
                    }
                case "tesCobranzasActionExchange":
                    {
                        // Acá no sé si puedo saber si ya se volvió a generar la cobranza por la opción original //

                        TesoreriaExchange.tesCobranzasActionExchange exch = new TesoreriaExchange.tesCobranzasActionExchange();
                        exch.Param.Merge(Generalidades.DatsetJson.JsonToDatset(pCommonDS.Request[pIndice].Request, exch.Param.GetType()));
                        exch.Param.Principal[0].Delete();
                        exch.Param.AcceptChanges();

                        exch.Action = lAccion;

                        Generalidades.QBIInternal.WrapperExecuteActionInternal(exch, cmd);

                        // Borro el log de este comprobante //
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLog, cmd);

                        break;
                    }
            }
            return pCommonDS;
        }
    }
}
