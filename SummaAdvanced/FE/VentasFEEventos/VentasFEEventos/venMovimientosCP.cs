using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
namespace VentasFEEventos
{
    public class venMovimientosCP
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDF(VentasCommon.venMovimientosCPDS pCommonDS, Command cmd)
        {
            VentasExchange.venMovimientosCPActionExchange eCP = new VentasExchange.venMovimientosCPActionExchange(VentasExchange.venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Descargar)
            {
                //Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                //Segmento1N = pCommonDS.Principal[0].Segmento1N,
                //Segmento2N = pCommonDS.Principal[0].Segmento2N,
                //Segmento3N = pCommonDS.Principal[0].Segmento3N,
                //Segmento4N = pCommonDS.Principal[0].Segmento4N,
                //Segmento1C = pCommonDS.Principal[0].Segmento1C,
                //Segmento2C = pCommonDS.Principal[0].Segmento2C,
                //Segmento3C = pCommonDS.Principal[0].Segmento3C,
                //Segmento4C = pCommonDS.Principal[0].Segmento4C,
                //Extension = "PDF"
            };
            eCP = new VentasExchange.venMovimientosCPActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCP, cmd));

            return Generalidades.Archivos.ConvertirADatasetDownload("Carta Porte Pdf", /*eCP.NombreArchivo*/"", false, "pdf", ""/*eCP.Archivo*/);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXML(VentasCommon.venMovimientosCPDS pCommonDS, Command cmd)
        {
            VentasExchange.venMovimientosCPActionExchange eCP = new VentasExchange.venMovimientosCPActionExchange(VentasExchange.venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Descargar)
            {
                //Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                //Segmento1N = pCommonDS.Principal[0].Segmento1N,
                //Segmento2N = pCommonDS.Principal[0].Segmento2N,
                //Segmento3N = pCommonDS.Principal[0].Segmento3N,
                //Segmento4N = pCommonDS.Principal[0].Segmento4N,
                //Segmento1C = pCommonDS.Principal[0].Segmento1C,
                //Segmento2C = pCommonDS.Principal[0].Segmento2C,
                //Segmento3C = pCommonDS.Principal[0].Segmento3C,
                //Segmento4C = pCommonDS.Principal[0].Segmento4C,
                //Extension = "XML"
            };
            eCP = new VentasExchange.venMovimientosCPActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCP, cmd));

            return Generalidades.Archivos.ConvertirADatasetDownload("Carta Porte Xml", /*eCP.NombreArchivo*/"", false, "xml","" /*eCP.Archivo*/);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosCPDS FacturaDatos(VentasCommon.venMovimientosCPDS pCommonDS, VentasCommon.venMovimientosCPDS pCommonDSNoPost, int pIndice, Command cmd)
        {


            VentasExchange.venMovimientosCPActionExchange eCP = new VentasExchange.venMovimientosCPActionExchange(VentasExchange.venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Datos)
            {
            };

            //eCP.Param.Factura[0].Segmento_Id = pCommonDS.Factura[0].Segmento_Id;
            //eCP.Param.Factura[0].Segmento1N = pCommonDS.Factura[0].Segmento1N;
            //eCP.Param.Factura[0].Segmento2N = pCommonDS.Factura[0].Segmento2N;
            //eCP.Param.Factura[0].Segmento3N = pCommonDS.Factura[0].Segmento3N;
            //eCP.Param.Factura[0].Segmento4N = pCommonDS.Factura[0].Segmento4N;
            //eCP.Param.Factura[0].Segmento1C = pCommonDS.Factura[0].Segmento1C;
            //eCP.Param.Factura[0].Segmento2C = pCommonDS.Factura[0].Segmento2C;
            //eCP.Param.Factura[0].Segmento3C = pCommonDS.Factura[0].Segmento3C;
            //eCP.Param.Factura[0].Segmento4C = pCommonDS.Factura[0].Segmento4C;
                
            //eCP = new VentasExchange.venMovimientosCPActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCP, cmd));

            //pCommonDS.Factura.Merge(eCP.Param.Factura);
            //pCommonDS.Factura[0].Delete();

            //pCommonDS.Cuerpo.Merge(eCP.Param.Cuerpo);

            return pCommonDS;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosCPDS FacturaEliminar(VentasCommon.venMovimientosCPDS pCommonDS, VentasCommon.venMovimientosCPDS pCommonDSNoPost, int pIndice, Command cmd)
        {


            VentasCommon.venMovimientosCPDS CPDS = new VentasCommon.venMovimientosCPDS();


            //foreach(var ren in pCommonDS.Factura)
            //{
            //    if (ren.venMovimientos != pCommonDS.Factura[pIndice].venMovimientos)
            //        CPDS.Factura.AddFacturaRow(ren);
            //}

            //foreach (var ren in pCommonDS.Cuerpo)
            //{

            //    if (ren.venMovimientos != pCommonDS.Cuerpo[pIndice].venMovimientos)
            //        CPDS.Cuerpo.AddCuerpoRow(ren);
            //}

            //CPDS.Principal.Merge(pCommonDS.Principal);
            //CPDS.Principal[0].Delete();

            return CPDS;
        }
      
    }

    
}
