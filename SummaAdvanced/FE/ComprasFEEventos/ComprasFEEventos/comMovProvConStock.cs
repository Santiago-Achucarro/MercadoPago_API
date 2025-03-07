using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comMovProvConStock
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comMovProvDatosConStockDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaArt(ComprasCommon.comMovProvDatosConStockDS exch, ComprasCommon.comMovProvDatosConStockDS exchNoPost, 
            int pIndice, Command cmd)
        {
            comMovProvDatosConStockDS.grdCuerpoDataTable lDF = exchNoPost.grdCuerpo;

            if (lDF[0].Producto_Id == "")
                return "El_Producto_No_puede_ser_Vacio";

            if (lDF[0].CantidadForm == 0)
                return "La_cantidad_debe_ser_distinta_a_cero";


            // todo validar la UM

            StockValidacion.stkArtiUM.PerteneceUMProd(lDF[0].Producto_Id, lDF[0].Medida_Id, cmd);
            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comMovProvDatosConStockDS exch, Command cmd)
        {
            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";
        }
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(ComprasCommon.comMovProvDatosConStockDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExcEmp =
                 new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExcEmp.Empresa_Id = "";
            ExcEmp.genEmpresas = cmd.Empresa_Id;
            ExcEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEmp, cmd));

            if (ExcEmp.Existe)
            {
                if (ExcEmp.UsaCantidadAlterna)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comMovProvDatosConStockDS exch, ComprasCommon.comMovProvDatosConStockDS exchNoPost, 
            int pIndice, Command cmd)
        {
            comMovProvDatosConStockDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            // TODO DUPLICADO

            return "";
        }


        public enum comMovProvConStockVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, UsaDespacho, ManejaUbicacion
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(ComprasCommon.comMovProvDatosConStockDS exch,
           ComprasCommon.comMovProvDatosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                    (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            if (exchProd.Serializable || exchProd.TrabajaPorLotes)
                lRetorno.Add(comMovProvConStockVar.ManejaSerieoLote.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaSerieoLote.ToString(), "N");
            if (exchProd.Serializable)
                lRetorno.Add(comMovProvConStockVar.ManejaSerie.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaSerie.ToString(), "N");

            if (exchProd.TrabajaPorLotes)
                lRetorno.Add(comMovProvConStockVar.ManejaLote.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaLote.ToString(), "N");

            if (exchProd.conVencimiento)
                lRetorno.Add(comMovProvConStockVar.ManejaVencimiento.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaVencimiento.ToString(), "N");

            if (exchProd.MedidaAlterna != "")
                lRetorno.Add(comMovProvConStockVar.ManejaUMAlterna.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaUMAlterna.ToString(), "N");

            lRetorno.Add(comMovProvConStockVar.Clase.ToString(), exchProd.Clase);

            if (exchProd.Clase != "D")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(comMovProvConStockVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(comMovProvConStockVar.ManejoDeposito.ToString(), "N");

            if (exchProd.UsaDespachoImportacion)
                lRetorno.Add(comMovProvConStockVar.UsaDespacho.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.UsaDespacho.ToString(), "N");


            StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
            {
                Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id
            };
            eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
            if (eDepo.Existe && eDepo.UsaUbicacion)

                lRetorno.Add(comMovProvConStockVar.ManejaUbicacion.ToString(), "S");
            else
                lRetorno.Add(comMovProvConStockVar.ManejaUbicacion.ToString(), "N");

            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public comMovProvDatosConStockDS SumarCant(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static comMovProvDatosConStockDS AsignarCantidad(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost, int pIndice,
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

        public static comMovProvDatosConStockDS SumarCantU(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public comMovProvDatosConStockDS LlenarUM(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.ExistePosteadoyActivo
                (exchNoPost.grdCuerpo[0].Producto_Id, cmd);

            exchNoPost.grdCuerpo[0].Medida_Id = exchProd.Medida_Id;
            exchNoPost.grdCuerpo[0].DescripcionUniMed = exchProd.DescripcionUniMed;
            exchNoPost.grdCuerpo[0].Factor = 1;
            exchNoPost.grdCuerpo[0].MedidaAlterna = exchProd.MedidaAlterna;
            exchNoPost.grdCuerpo[0].DescripcionUnidadAlterna = exchProd.DescripcionMedidaAlterna;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public comMovProvDatosConStockDS LlenarFactor(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
                (exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comMovProvDatosConStockDS ValoresImpuesto(comMovProvDatosConStockDS exch, comMovProvDatosConStockDS exchNoPost, int pIndice, Command cmd)
        {
            // TODO FM Ver de dónde sacamos la cantidad de dígitos
            int lDigitos = 2;

            comMovProvDatosConStockDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            ComprasExchange.comImpuestosActionExchange exchImp = new ComprasExchange.comImpuestosActionExchange
                (ComprasExchange.comImpuestosActionEnum.EnumcomImpuestosAction.Datos);
            exchImp.Impuesto_Id = lDF[0].Impuesto_Id;

            exchImp = new ComprasExchange.comImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchImp), cmd));

            if (exchNoPost.grdImpuestos[0].Porcentaje == 0)
                // Asigno el porcentaje si está en 0. Si es distinto de cero que no cambie por si el usuario lo editó //
                exchNoPost.grdImpuestos[0].Porcentaje = exchImp.Porcentaje;
            exchNoPost.grdImpuestos[0].Cuenta_Id = exchImp.CtaDebe;

            // FM Si cambio el porcentaje que calculo siempre el impuesto y no solo si estoy dando //
            // de alta un nuevo impuesto. Comento el if de abajo //

            if (exchImp.Formulacalc == "")
            {
                exchNoPost.grdImpuestos[0].Importe_Impuesto = Generalidades.Auxiliares.Redondear
                    (lDF[0].Base_Imponible * exchImp.Porcentaje, lDigitos);
            }
            else
            {
                ComprasExchange.comMovProvDatosConStockActionExchange exchCMPST =
                    new ComprasExchange.comMovProvDatosConStockActionExchange
                    (ComprasExchange.comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.CalcularImpuesto);

                exchCMPST.Param.Merge(exch);
                exchCMPST.Param.Principal[0].Delete();

                // Tomo siempre el porcentaje desde la grilla porque si está editando un renglón existente está bien //
                // Y si está editando uno nuevo, ya copió el valor del impuesto a la grilla //

                // Agrego el renglón no posteado al Exchange para que haga el cálculo del impuesto //
                exchCMPST.Param.grdImpuestos.Clear();
                exchCMPST.Param.grdImpuestos.AddgrdImpuestosRow(0, 0, exchImp.Impuesto_Id, "",
                    exchNoPost.grdImpuestos[0].Porcentaje, lDF[0].Base_Imponible, 0, "", "", "", "", "", "", 0, "", 0);
                exchCMPST.Param.grdImpuestos.AcceptChanges();

                exchCMPST = new ComprasExchange.comMovProvDatosConStockActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchCMPST), cmd));

                // Traigo el valor calculado al Exchange no posteado para que actualice el importe calculado //
                exchNoPost.grdImpuestos[0].Importe_Impuesto = exchCMPST.Param.grdImpuestos[0].Importe_Impuesto;

            }
            //}

            return exchNoPost;
        }

    }
}
