using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.Xml;
using System.Security.Cryptography;
using System.Data;

namespace ComprasFEEventos
{
  public  class comCFDISatRango
    {
        [Generalidades.QFuncion_AccionDescargarFila]
         public Generalidades.DescargaArchivoDS Xml(ComprasCommon.comCFDISatDatosRangoDS exch,
                ComprasCommon.comCFDISatDatosRangoDS exchNoPost, int pIndice, Command cmd)
        {




            ComprasExchange.comCFDISatActionExchange ExcCFDI = new ComprasExchange.comCFDISatActionExchange(ComprasExchange.comCFDISatActionEnum.EnumcomCFDISatAction.Datos)
            {
                UUID = exch.Cuerpo[pIndice].UUID
            };

            ExcCFDI = new ComprasExchange.comCFDISatActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcCFDI, cmd));
            if (ExcCFDI.Existe && ExcCFDI.XML != "")
            {
                string lNombreArchivo = ExcCFDI.Serie;
                if (lNombreArchivo == "")
                    lNombreArchivo = ExcCFDI.RFCEmisor + "_" + ExcCFDI.Folio;

                return Generalidades.Archivos.ConvertirADatasetDownload("XML", lNombreArchivo + ".xml", false, "XML",
                                    Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(ExcCFDI.XML)));
            }
            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_XML");
            return new Generalidades.DescargaArchivoDS();
        }

    }
}
