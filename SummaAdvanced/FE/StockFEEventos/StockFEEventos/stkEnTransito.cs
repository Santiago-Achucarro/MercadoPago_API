using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace StockFEEventos
{

    public class stkEnTransito
    {
        private StockCommon.stkMoviCabeDS TostkMoviCabe(StockCommon.stkSalidasCDDS req)
        {
            StockCommon.stkMoviCabeDS exchSTMC = new StockCommon.stkMoviCabeDS();
            exchSTMC.Principal.Merge(req.Principal);
            exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();


            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);
            exchSTMC.Ubicaciones.Merge(req.Ubicaciones);
            return exchSTMC;
        }
        private StockCommon.stkSalidasCDDS FromstkMoviCabe(StockCommon.stkMoviCabeDS req)
        {
            StockCommon.stkSalidasCDDS exchSTMC = new StockCommon.stkSalidasCDDS();
            exchSTMC.Principal.Merge(req.Principal);
            if (exchSTMC.Principal.Count > 1) exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();

            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);
            exchSTMC.Ubicaciones.Merge(req.Ubicaciones);
            return exchSTMC;
        }
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkSalidasCDDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkSalidasCDDS LlenarUM(StockCommon.stkSalidasCDDS exch, StockCommon.stkSalidasCDDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarUM(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkSalidasCDDS LlenarFactor(StockCommon.stkSalidasCDDS exch, StockCommon.stkSalidasCDDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarFactor(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));
        }



        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(StockCommon.stkSalidasCDDS exch, StockCommon.stkSalidasCDDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            if (exchNoPost.grdCuerpo[0].Producto_Id == "")
                return "Debe_informar_un_producto";

            if (exchNoPost.grdCuerpo[0].Medida_Id == "")
                return "Debe_informar_una_Unidad_de_medida";

            if (exchNoPost.grdCuerpo[0].Deposito_Id == "")
                return "Debe_informar_un_deposito";

            if (!(exchNoPost.grdCuerpo[0].CantidadForm > 0))
                return "La_cantidad_debe_ser_mayor_que_cero";

            if (exchNoPost.grdCuerpo[0].CantidadAlternaForm < 0)
                return "La_cantidad_alternativa_debe_ser_mayor_o_igual_que_cero";

            //TODO FM falta validar el despacho. Ver cómo evitar buscar el producto otra vez

            return "";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(StockCommon.stkSalidasCDDS exch,
          StockCommon.stkSalidasCDDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkEnTransitoVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasCDDS SumarCantLote(StockCommon.stkSalidasCDDS exch, StockCommon.stkSalidasCDDS exchNoPost,
    int pIndice, Framework.Core.Command cmd)
        {
            // FM 18/12/2019 //
            // No estaba programado este método //
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();
            // Fin FM //
            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasCDDS SumarCantSerie(StockCommon.stkSalidasCDDS exch, StockCommon.stkSalidasCDDS exchNoPost,
int pIndice, Framework.Core.Command cmd)
        {
            // FM 18/12/2019 //
            // No estaba programado este método //
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            exchNoPost.AcceptChanges();
            // Fin FM //
            return exchNoPost;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValirSerieLote(stkSalidasCDDS exch, stkSalidasCDDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            return stkMoviSerieSalidasSolapa.ValirSerieLote(dsExch, dsExchNoPost, pIndice, cmd);

        }
        [Generalidades.QFuncion_AccionGrilla]
        public static stkSalidasCDDS AsignarCantidad(stkSalidasCDDS exch, stkSalidasCDDS exchNoPost, int pIndice,
 Framework.Core.Command cmd)
        {
            if (exchNoPost.grdCuerpo[0].CantidadForm == 0)
                return exchNoPost;

            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.grdCuerpo[0].CantidadForm - lCant, eExistU.Cantidad);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static stkSalidasCDDS SumarCantU(stkSalidasCDDS exch, stkSalidasCDDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string CartaPorte(StockCommon.stkSalidasCDDS exch, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id != "MX" || !exch.CartaPorte[0].GeneraRemito || String.IsNullOrWhiteSpace(exch.CartaPorte[0].FormaEntrega_Id))
                return "N";
            return (VentasValidacion.venFormaEntrega.Existe(exch.CartaPorte[0].FormaEntrega_Id, cmd).UsaCartaPorte ? "S" : "N");

        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(StockCommon.stkSalidasCDDS pCommonDS, Framework.Core.Command cmd)
        {

            StockExchange.stkSalidasCDActionExchange emov = new StockExchange.stkSalidasCDActionExchange(StockExchange.stkSalidasCDActionEnum.EnumstkSalidasCDAction.Descargar);
            emov.Param.Merge(pCommonDS, false);
            emov.Param.Principal[0].Delete();
            emov.Param.Descargas.Clear();
            emov.Param.Descargas.AddDescargasRow("", "XML");
            emov.Param.Descargas.AddDescargasRow("", "PDF");
            emov.Param.AcceptChanges();
            emov = new StockExchange.stkSalidasCDActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(emov, cmd));

            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();

            foreach (var ren in emov.Param.Descargas)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(1, Guid.NewGuid().ToString(), emov.Segmento1C + emov.Segmento2C + emov.Segmento3C + emov.Segmento4C +
                        (emov.Segmento1N == 0 ? "" : emov.Segmento1N.ToString("00000000")) +
                        (emov.Segmento2N == 0 ? "" : emov.Segmento2N.ToString("00000000")) +
                        (emov.Segmento3N == 0 ? "" : emov.Segmento3N.ToString("00000000")) +
                        (emov.Segmento4N == 0 ? "" : emov.Segmento4N.ToString("00000000")) + "." + ren.Extension,
                        ren.Extension, ren.Archivo, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());

            }
            string lCuerpo = "";
            lRetorno.Principal.AddPrincipalRow("Carta Porte", lCuerpo, "", "", "", true);
            lRetorno.AcceptChanges();
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXml(StockCommon.stkSalidasCDDS pCommonDS, Framework.Core.Command cmd)
        {
            StockExchange.stkSalidasCDActionExchange emov = new StockExchange.stkSalidasCDActionExchange(StockExchange.stkSalidasCDActionEnum.EnumstkSalidasCDAction.Descargar);
            emov.Param.Merge(pCommonDS, false);
            emov.Param.Principal[0].Delete();
            emov.Param.Descargas.Clear();
            emov.Param.Descargas.AddDescargasRow("", "XML");
            emov.Param.AcceptChanges();
            emov = new StockExchange.stkSalidasCDActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(emov, cmd));


            return Generalidades.Archivos.ConvertirADatasetDownload("XML", emov.Segmento1C + emov.Segmento2C + emov.Segmento3C + emov.Segmento4C +
                        (emov.Segmento1N == 0 ? "" : emov.Segmento1N.ToString("00000000")) +
                        (emov.Segmento2N == 0 ? "" : emov.Segmento2N.ToString("00000000")) +
                        (emov.Segmento3N == 0 ? "" : emov.Segmento3N.ToString("00000000")) +
                        (emov.Segmento4N == 0 ? "" : emov.Segmento4N.ToString("00000000")) + ".xml", false, "xml", emov.Param.Descargas[0].Archivo);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDF(StockCommon.stkSalidasCDDS pCommonDS, Framework.Core.Command cmd)
        {
            StockExchange.stkSalidasCDActionExchange emov = new StockExchange.stkSalidasCDActionExchange(StockExchange.stkSalidasCDActionEnum.EnumstkSalidasCDAction.Descargar);
            emov.Param.Merge(pCommonDS, false);
            emov.Param.Principal[0].Delete();
            emov.Param.Descargas.Clear();
            emov.Param.Descargas.AddDescargasRow("", "PDF");
            emov.Param.AcceptChanges();
            emov = new StockExchange.stkSalidasCDActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(emov, cmd));


            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", emov.Segmento1C + emov.Segmento2C + emov.Segmento3C + emov.Segmento4C +
                        (emov.Segmento1N == 0 ? "" : emov.Segmento1N.ToString("00000000")) +
                        (emov.Segmento2N == 0 ? "" : emov.Segmento2N.ToString("00000000")) +
                        (emov.Segmento3N == 0 ? "" : emov.Segmento3N.ToString("00000000")) +
                        (emov.Segmento4N == 0 ? "" : emov.Segmento4N.ToString("00000000")) + ".pdf", false, "pdf", emov.Param.Descargas[0].Archivo);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasCDDS PopularSerie(stkSalidasCDDS pCommonDS, stkSalidasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkSalidasCDDS ds = new stkSalidasCDDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasCDDS PopularLote(stkSalidasCDDS pCommonDS, stkSalidasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkSalidasCDDS ds = new stkSalidasCDDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasCDDS PopularUbi(stkSalidasCDDS pCommonDS, stkSalidasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkSalidasCDDS ds = new stkSalidasCDDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }
    }
}
