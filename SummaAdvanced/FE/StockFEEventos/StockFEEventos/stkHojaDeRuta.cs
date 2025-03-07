using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.IO;

namespace StockFEEventos
{
    public class stkHojaDeRuta
    {
        [Generalidades.QFuncion_Condicion]
        public string FiltroXFecha(StockCommon.stkHojaDeRutaDS ds, Framework.Core.Command cmd)
        {
            if (ds.Principal[0].FiltroXFecha)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarArchivo(StockCommon.stkHojaDeRutaDS Exch, Command cmd)
        {
            StockExchange.stkHojaDeRutaActionExchange exchStkHR = new StockExchange.stkHojaDeRutaActionExchange(StockExchange.stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Datos);

            StockExchange.stkCOTArActionExchange exchStkCotAr = new StockExchange.stkCOTArActionExchange(StockExchange.stkCOTArActionEnum.EnumstkCOTArAction.Datos);

            /*exchVenFE = new VentasExchange.venFormaEntregaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchVenFE, cmd));*/

            exchStkHR.Segmento1N = Exch.Principal[0].Segmento1N;
            exchStkHR.Segmento2N = Exch.Principal[0].Segmento2N;
            exchStkHR.Segmento3N = Exch.Principal[0].Segmento3N;
            exchStkHR.Segmento4N = Exch.Principal[0].Segmento4N;
            exchStkHR.Segmento1C = Exch.Principal[0].Segmento1C;
            exchStkHR.Segmento2C = Exch.Principal[0].Segmento2C;
            exchStkHR.Segmento3C = Exch.Principal[0].Segmento3C;
            exchStkHR.Segmento4C = Exch.Principal[0].Segmento4C;
            exchStkHR.Segmento_Id = Exch.Principal[0].Segmento_Id;

            exchStkHR = new StockExchange.stkHojaDeRutaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchStkHR, cmd));

            exchStkCotAr.stkHojaDeRuta = exchStkHR.stkHojaDeRuta;

            exchStkCotAr = new StockExchange.stkCOTArActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchStkCotAr, cmd));
                 
            if (exchStkCotAr.COT == "")
                Generalidades.qFunctionalException.GenerarExcepcion("No_Se_Genera_COT");

            var lbytes = File.ReadAllBytes(@"C:\Temp\COT.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", exchStkCotAr.COT, false, "txt", lbase64);
        }


        
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string ParmetrosRep(StockCommon.stkHojaDeRutaDS pCommonDS, Command cmd)
        {

            string lRetorno = "Empresa_Id|" + cmd.Empresa_Id.ToString() + 
                 "@Segmento_Id|" + pCommonDS.Principal[0].Segmento_Id +
                 "@Segmento1N|" + pCommonDS.Principal[0].Segmento1N.ToString() +
                 "@Segmento2N|" + pCommonDS.Principal[0].Segmento2N.ToString() +
                 "@Segmento3N|" + pCommonDS.Principal[0].Segmento3N.ToString() +
                 "@Segmento4N|" + pCommonDS.Principal[0].Segmento4N.ToString() +
                 "@Segmento1C|" + pCommonDS.Principal[0].Segmento1C +
                 "@Segmento2C|" + pCommonDS.Principal[0].Segmento2C +
                 "@Segmento3C|" + pCommonDS.Principal[0].Segmento3C +
                 "@Segmento4C|" + pCommonDS.Principal[0].Segmento4C;

            

            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }
    }
}
