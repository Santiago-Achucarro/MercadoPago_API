using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace VentasFEEventos
{
    public class venMoviAnuladas
    {
        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Xml(VentasCommon.venMovAnuladosDS exch,
                VentasCommon.venMovAnuladosDS exchNoPost, int pIndice, Command cmd)
        {
            string lRes = "";
            if (!String.IsNullOrWhiteSpace(exch.Anuladas[pIndice].Acuse))
                lRes = exch.Anuladas[pIndice].Acuse;
            else
            {
                lRes = VentasBEFactElect.venMovimientosCancelarenSAT.GetAcuseFact(exch.Anuladas[pIndice].venMovimientos, cmd);
                if (lRes == "")
                    Generalidades.qFunctionalException.GenerarExcepcion("Error_Al_obtener_Acuse");
                else
                {
                    VentasExchange.venMovAnuladosActionExchange eAnul =
                        new VentasExchange.venMovAnuladosActionExchange(VentasExchange.venMovAnuladosActionEnum.EnumvenMovAnuladosAction.Guardar)
                        {
                            FechaDesde = exch.Principal[0].FechaDesde,
                            FechaHasta = exch.Principal[0].FechaHasta
                        };
                    eAnul.Param.Anuladas.AddAnuladasRow(exch.Anuladas[pIndice].venMovimientos,
                            exch.Anuladas[pIndice].Comprobante, exch.Anuladas[pIndice].FechaEmision,
                            exch.Anuladas[pIndice].FechaAnulacion, exch.Anuladas[pIndice].Cliente_Id, exch.Anuladas[pIndice].RazonSocial,
                            exch.Anuladas[pIndice].Usuario_Id, lRes, exch.Anuladas[pIndice].Estado );

                    eAnul.Param.AcceptChanges();
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eAnul, cmd);
                }
            }
            return Generalidades.Archivos.ConvertirADatasetDownload("Acuse", "Acuse.xml", false, "xml",
                           Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(lRes)));
        }

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS PDF(VentasCommon.venMovAnuladosDS exch,
              VentasCommon.venMovAnuladosDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovAnuladosActionExchange eAnul = new VentasExchange.venMovAnuladosActionExchange(VentasExchange.venMovAnuladosActionEnum.EnumvenMovAnuladosAction.PDF)
            {
                FechaDesde = exch.Principal[0].FechaDesde,
                FechaHasta = exch.Principal[0].FechaHasta
            };
            eAnul.Param.Anuladas.AddAnuladasRow(exch.Anuladas[pIndice].venMovimientos,
                    exch.Anuladas[pIndice].Comprobante, exch.Anuladas[pIndice].FechaEmision,
                    exch.Anuladas[pIndice].FechaAnulacion, exch.Anuladas[pIndice].Cliente_Id, exch.Anuladas[pIndice].RazonSocial,
                    exch.Anuladas[pIndice].Usuario_Id, exch.Anuladas[pIndice].Acuse, exch.Anuladas[pIndice].Estado);

            eAnul.Param.AcceptChanges();
            eAnul = new VentasExchange.venMovAnuladosActionExchange(
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eAnul, cmd));
            return Generalidades.Archivos.ConvertirADatasetDownload("Acuse", eAnul.NombreArchivo, false, "pdf",
                           eAnul.PDF);
        }
    }
}
