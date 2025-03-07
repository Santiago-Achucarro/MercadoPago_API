using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkEntradasCD
    {
        private StockCommon.stkMoviCabeDS TostkMoviCabe(StockCommon.stkEntradasCDDS req)
        {
            StockCommon.stkMoviCabeDS exchSTMC = new StockCommon.stkMoviCabeDS();
            exchSTMC.Principal.Merge(req.Principal);
            exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();

            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);
            exchSTMC.Ubicaciones.Merge(req.grdMoviDespa);
            return exchSTMC;
        }
        private StockCommon.stkEntradasCDDS FromstkMoviCabe(StockCommon.stkMoviCabeDS req)
        {
            StockCommon.stkEntradasCDDS exchSTMC = new StockCommon.stkEntradasCDDS();
            exchSTMC.Principal.Merge(req.Principal);
            exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();

            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);

            return exchSTMC;
        }
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkEntradasCDDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkEntradasCDDS LlenarUM(StockCommon.stkEntradasCDDS exch, StockCommon.stkEntradasCDDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarUM(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));

        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkEntradasCDDS LlenarFactor(StockCommon.stkEntradasCDDS exch, StockCommon.stkEntradasCDDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarFactor(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));

        }



        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(StockCommon.stkEntradasCDDS exch, StockCommon.stkEntradasCDDS exchNoPost,
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
        public Dictionary<string, string> VariablesProductos(StockCommon.stkEntradasCDDS exch,
          StockCommon.stkEntradasCDDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkEntradasCDVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }
        public static stkEntradasCDDS SumarCantU(stkEntradasCDDS exch, stkEntradasCDDS exchNoPost, int pIndice,
   Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasCDDS PopularSerie(stkEntradasCDDS pCommonDS, stkEntradasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkEntradasCDDS ds = new stkEntradasCDDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasCDDS PopularLote(stkEntradasCDDS pCommonDS, stkEntradasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkEntradasCDDS ds = new stkEntradasCDDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasCDDS PopularUbi(stkEntradasCDDS pCommonDS, stkEntradasCDDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkEntradasCDDS ds = new stkEntradasCDDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        public static stkEntradasCDDS SumarCant(stkEntradasCDDS exch, stkEntradasCDDS exchNoPost, int pIndice,
Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            return exchNoPost;
        }
    }
}
