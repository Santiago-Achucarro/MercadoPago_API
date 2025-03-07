using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkMoviCabeSalidasCausa
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(stkMoviCabeDatosCausaDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        
        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS LlenarUM(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.ExistePosteadoyActivo
                  (exchNoPost.grdCuerpo[0].Producto_Id, cmd);

            exchNoPost.grdCuerpo[0].Medida_Id = exchProd.Medida_Id;
            exchNoPost.grdCuerpo[0].Factor = 1;
            exchNoPost.grdCuerpo[0].MedidaAlterna = exchProd.MedidaAlterna;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS LlenarFactor(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
               (exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        
        
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
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
        public Dictionary<string, string> VariablesProductos(stkMoviCabeDatosCausaDS exch,
          stkMoviCabeDatosCausaDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id,
                   exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkMoviCabeSalidasCausaVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, DepositoDefecto, CantidadSoloLectura
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS SumarCantSerie(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
int pIndice, Framework.Core.Command cmd)
        {

            //exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            //exchNoPost.AcceptChanges();

            //return exchNoPost;

            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS ds = stkMoviSerieSalidasSolapa.SumarCantSerie(dsExch, dsExchNoPost, pIndice, cmd);

            stkMoviCabeDatosCausaDS dsc = new stkMoviCabeDatosCausaDS();
            dsc.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            return dsc;

        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS SumarCantLote(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
int pIndice, Framework.Core.Command cmd)
        {

            //exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            //exchNoPost.AcceptChanges();

            //return exchNoPost;

            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS ds = stkMoviSerieSalidasSolapa.SumarCantLote(dsExch, dsExchNoPost, pIndice, cmd);

            stkMoviCabeDatosCausaDS dsc = new stkMoviCabeDatosCausaDS();
            dsc.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            return dsc;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {

            stkMoviCabeDS dsExch = new stkMoviCabeDS();
            dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            return stkMoviSerieSalidasSolapa.ValirSerieLote(dsExch, dsExchNoPost, pIndice, cmd);

        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkMoviCabeDatosCausaDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDatosCausaDS AsignarCantidad(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, int pIndice,
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


        public static stkMoviCabeDatosCausaDS SumarCantU(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkMoviCabeDatosCausaDS PopularSerie(StockCommon.stkMoviCabeDatosCausaDS pCommonDS, StockCommon.stkMoviCabeDatosCausaDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDatosCausaDS ds = new stkMoviCabeDatosCausaDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkMoviCabeDatosCausaDS PopularLote(StockCommon.stkMoviCabeDatosCausaDS pCommonDS, StockCommon.stkMoviCabeDatosCausaDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            stkMoviCabeDatosCausaDS ds = new stkMoviCabeDatosCausaDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkMoviCabeDatosCausaDS PopularUbi(StockCommon.stkMoviCabeDatosCausaDS pCommonDS, StockCommon.stkMoviCabeDatosCausaDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            stkMoviCabeDatosCausaDS ds = new stkMoviCabeDatosCausaDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Ignore);
            return ds;

            //if (pIndice < 0 || pCommonDSNoPost.grdCuerpo[0].Producto_Id != pCommonDS.grdCuerpo[pIndice].Producto_Id || pCommonDSNoPost.grdCuerpo[0].Deposito_Id != pCommonDS.grdCuerpo[pIndice].Deposito_Id || pCommonDSNoPost.grdCuerpo[0].Medida_Id != pCommonDS.grdCuerpo[pIndice].Medida_Id)
            //{
            //    // Si estoy agregando un nuevo renglón o cambié alguno de los datos de un renglón existente entonces //
            //    // populo las ubicaciones //
            //    StockExchange.stkExistenciaXSerieXUbiActionExchange exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosUbi)
            //    {
            //        Producto_Id = pCommonDSNoPost.grdCuerpo[0].Producto_Id,
            //        Medida_Id = pCommonDSNoPost.grdCuerpo[0].Medida_Id,
            //        Deposito_Id = pCommonDSNoPost.grdCuerpo[0].Deposito_Id
            //    };
            //    exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchUbi, cmd));

            //    pCommonDSNoPost.grdCuerpo[0].CantidadForm = 0;
            //    pCommonDSNoPost.Ubicaciones.Clear();
            //    pCommonDSNoPost.Ubicaciones.Merge(exchUbi.Param.ExistenciaUbi);
            //    pCommonDSNoPost.Ubicaciones.AcceptChanges();
            //    // Le paso el renglón de la grilla principal //
            //    pCommonDSNoPost.Ubicaciones.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.grdCuerpo[0].Renglon);
            //}
            //return pCommonDSNoPost;
        }
    }
}
