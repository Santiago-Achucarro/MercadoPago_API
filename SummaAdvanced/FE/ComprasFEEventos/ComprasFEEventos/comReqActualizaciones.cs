using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comReqActualizaciones
    {

        

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaArt(ComprasCommon.comReqInternoDS exch, ComprasCommon.comReqInternoDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comReqInternoDS.CuerpoArtiDataTable lDF = exchNoPost.CuerpoArti;

            if (lDF[0].Producto_Id == "")
                return "El_Producto_No_puede_ser_Vacio";

            if (lDF[0].CantidadOriginal == 0)

                return "La_cantidad_debe_ser_distinta_a_cero";



            // todo validar la UM


            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string validarFilaMemo(ComprasCommon.comReqInternoDS exch, ComprasCommon.comReqInternoDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comReqInternoDS.CuerpoMemoDataTable lDF = exchNoPost.CuerpoMemo;

            if (lDF[0].Cantidad == 0)
                return "La_cantidad_debe_ser_distinta_a_cero";

            // todo validar la UM?
            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);
            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDF[0].Centro1_Id, cmd);
            ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(lDF[0].Centro2_Id, cmd);


            return "";

        }

        [Generalidades.QFuncion_Condicion]
        public string TipoCuerpo(ComprasCommon.comReqInternoDS exch, Command cmd)
        {
            ComprasExchange.comTipoPermiRIActionExchange ExcTP = new ComprasExchange.comTipoPermiRIActionExchange(ComprasExchange.comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction.Datos);

            ExcTP.TipoPermiRI_Id = exch.Principal[0].TipoPermiRI_Id;

            ExcTP = new ComprasExchange.comTipoPermiRIActionExchange(
                                Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcTP, cmd));

            if (ExcTP.Existe)
                return ExcTP.TipoCuerpo;

            return "P";
        }
        [Generalidades.QFuncion_Condicion]
        public string Print(ComprasCommon.comReqInternoDS exch, Command cmd)
        {

            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].EstadoRI_Id == "P" || exch.Principal[0].EstadoRI_Id == "R")
                return "P";

            return "A";

        }

        

        [Generalidades.QFuncion_CondicionGrilla]
        public string ClaseProducto(ComprasCommon.comReqInternoDS exch, ComprasCommon.comReqInternoDS exchNoPost,
            int pIndice, Command cmd)

        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);

            exchProd.Producto_Id = exchNoPost.CuerpoArti[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchProd, cmd));

            return exchProd.Clase;
        }

        [Generalidades.QFuncion_Condicion]
        public string GeneraOC(ComprasCommon.comReqInternoDS exch, Command cmd)
        {
            var dsTipoPermi=ComprasValidacion.comTipoPermiRI.ExistePosteadoyActivo(exch.Principal[0].TipoPermiRI_Id, cmd);
            if (dsTipoPermi.GeneraOC)
                return "OC";
            return "M";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablescomReqInterno(ComprasCommon.comReqInternoDS exch,
         ComprasCommon.comReqInternoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Tomo la sucursal del Usuario
            string lSucursal = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal;
            string lDeposito = GeneralesValidacion.genSucursalesEmpr.Existe(lSucursal, cmd).DepositoOC;

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add(comReqInternoVar.DepositoDefecto.ToString(), lDeposito);

            return lRetorno;
        }

        public enum comReqInternoVar
        {
            DepositoDefecto
        }

        //[Generalidades.QFuncion_ObtenerParametrosReporte]
        //public string ParametrosReporte(ComprasCommon.comReqInternoDS Exch, ComprasCommon.comReqInternoDS exchNoPost, int pIndice, Command cmd)
        //{
        //    string lRetorno = "Segmento_Id|"+ Exch.Principal[0].Segmento_Id+ "Segmento1N|" + Exch.Principal[0].Segmento1N.ToString() +
        //        "Segmento2N|" + Exch.Principal[0].Segmento2N.ToString() + "Segmento3N|" + Exch.Principal[0].Segmento3N.ToString()+
        //        "Segmento4N|" + Exch.Principal[0].Segmento4N.ToString() + "Segmento1C|" + Exch.Principal[0].Segmento1C +
        //        "Segmento2C|" + Exch.Principal[0].Segmento2C + "Segmento3C|" + Exch.Principal[0].Segmento3C +
        //        "Segmento4C|" + Exch.Principal[0].Segmento4C + "Empresa_Id|" + cmd.Empresa_Id.ToString();
        //    ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
        //    return lRetorno;
        //}
        /////Si no es invocado desde eventos de grilla
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string ParametrosReporte(ComprasCommon.comReqInternoDS Exch, Command cmd)
        {
            string lRetorno = "Segmento_Id|" + Exch.Principal[0].Segmento_Id + "@Segmento1N|" + Exch.Principal[0].Segmento1N.ToString() +
                "@Segmento2N|" + Exch.Principal[0].Segmento2N.ToString() + "@Segmento3N|" + Exch.Principal[0].Segmento3N.ToString() +
                "@Segmento4N|" + Exch.Principal[0].Segmento4N.ToString() + "@Segmento1C|" + Exch.Principal[0].Segmento1C +
                "@Segmento2C|" + Exch.Principal[0].Segmento2C + "@Segmento3C|" + Exch.Principal[0].Segmento3C +
                "@Segmento4C|" + Exch.Principal[0].Segmento4C + "@Empresa_Id|" + cmd.Empresa_Id.ToString();
            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }
    }
}
