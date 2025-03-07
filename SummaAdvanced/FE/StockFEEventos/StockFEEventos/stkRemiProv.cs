using StockCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkRemiProv
    {
        private StockCommon.stkMoviCabeDS TostkMoviCabe(StockCommon.stkRemiProvDS req)
        {
            StockCommon.stkMoviCabeDS exchSTMC = new StockCommon.stkMoviCabeDS();
            exchSTMC.Principal.Merge(req.Principal);
            if (exchSTMC.Principal.Count > 1) exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();

            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);
            return exchSTMC;
        }
        private StockCommon.stkRemiProvDS FromstkMoviCabe(StockCommon.stkMoviCabeDS req)
        {
            StockCommon.stkRemiProvDS exchSTMC = new StockCommon.stkRemiProvDS();
            exchSTMC.Principal.Merge(req.Principal);
            if (exchSTMC.Principal.Count > 1) exchSTMC.Principal[0].Delete();
            exchSTMC.Principal.AcceptChanges();

            exchSTMC.grdCuerpo.Merge(req.grdCuerpo);
            exchSTMC.genAtributosGenerales.Merge(req.genAtributosGenerales);
            exchSTMC.grdMoviSerie.Merge(req.grdMoviSerie);
            exchSTMC.grdMoviDespa.Merge(req.grdMoviDespa);
            return exchSTMC;
        }
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkRemiProvDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkRemiProvDS AsignarPrecio(StockCommon.stkRemiProvDS exch, StockCommon.stkRemiProvDS exchNoPost,
         int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();

            if (exchNoPost.grdCuerpo[0].IsPrecioOriginalNull())
                exchNoPost.grdCuerpo[0].PrecioOriginal = 0;
            return FromstkMoviCabe(SMC.AsignarPrecio(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkRemiProvDS LlenarUM(StockCommon.stkRemiProvDS exch, StockCommon.stkRemiProvDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarUM(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkRemiProvDS LlenarFactor(StockCommon.stkRemiProvDS exch, StockCommon.stkRemiProvDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockFEEventos.stkMoviCabe SMC = new StockFEEventos.stkMoviCabe();
            return FromstkMoviCabe(SMC.LlenarFactor(TostkMoviCabe(exch), TostkMoviCabe(exchNoPost), pIndice, cmd));

        }



        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(StockCommon.stkRemiProvDS exch, StockCommon.stkRemiProvDS exchNoPost,
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
        public Dictionary<string, string> VariablesProductos(StockCommon.stkRemiProvDS exch,
          StockCommon.stkRemiProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkRemiProvVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho
        }


        public stkRemiProvDS SumarCantSerie(stkRemiProvDS exch, stkRemiProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS ds = stkMoviSerieSalidasSolapa.SumarCantSerie(dsExch, dsExchNoPost, pIndice, cmd);

            stkRemiProvDS dsc = new stkRemiProvDS();
            dsc.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            return dsc;
        }

        public stkRemiProvDS SumarCantLote(stkRemiProvDS exch, stkRemiProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS ds = stkMoviSerieSalidasSolapa.SumarCantLote(dsExch, dsExchNoPost, pIndice, cmd);

            stkRemiProvDS dsc = new stkRemiProvDS();
            dsc.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            return dsc;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValirSerieLote(stkRemiProvDS exch, stkRemiProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            return stkMoviSerieSalidasSolapa.ValirSerieLote(dsExch, dsExchNoPost, pIndice, cmd);
        }
        public static stkRemiProvDS SumarCantU(stkRemiProvDS exch, stkRemiProvDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }



        [Generalidades.QFuncion_AccionGrilla]
        public static stkRemiProvDS AsignarCantidad(stkRemiProvDS exch, stkRemiProvDS exchNoPost, int pIndice,
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
    }
}
