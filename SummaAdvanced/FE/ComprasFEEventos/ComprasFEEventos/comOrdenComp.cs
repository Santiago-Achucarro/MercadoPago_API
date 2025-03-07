using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comOrdenComp
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comOrdenCompDS exch, Command cmd)
        {
            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaArt(ComprasCommon.comOrdenCompDS exch, ComprasCommon.comOrdenCompDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comOrdenCompDS.CuerpoArtiDataTable lDF = exchNoPost.CuerpoArti;

            if (lDF[0].Producto_Id == "")
                return "El_Producto_No_puede_ser_Vacio";

            if (lDF[0].CantidadOriginal == 0)

                return "La_cantidad_debe_ser_distinta_a_cero";



            // todo validar la UM


            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string validarFilaMemo(ComprasCommon.comOrdenCompDS exch, ComprasCommon.comOrdenCompDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comOrdenCompDS.CuerpoMemoDataTable lDF = exchNoPost.CuerpoMemo;

            if (lDF[0].Cantidad == 0)
                return "La_cantidad_debe_ser_distinta_a_cero";

            // todo validar la UM?
            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);
            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDF[0].Centro1_Id, cmd);
            ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(lDF[0].Centro2_Id, cmd);


            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string TipoCuerpo(ComprasCommon.comOrdenCompDS exch, Command cmd)
        {
            ComprasExchange.comTipoPermiActionExchange ExcTP = new ComprasExchange.comTipoPermiActionExchange(ComprasExchange.comTipoPermiActionEnum.EnumcomTipoPermiAction.Datos);

            ExcTP.TipoPermi_Id = exch.Principal[0].TipoPermi_Id;

            ExcTP = new ComprasExchange.comTipoPermiActionExchange(
                                Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcTP, cmd));

            if (ExcTP.Existe)
                return ExcTP.TipoCuerpo;

            return "P";
        }
        [Generalidades.QFuncion_Condicion]
        public string Print(ComprasCommon.comOrdenCompDS exch, Command cmd)
        {
            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].Estado_Id == "P" || exch.Principal[0].Estado_Id == "R")
                return "P";

            return "A";
        }

        public enum comOrdenCompVar
        {
            DepositoDefecto, Sucursal
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablescomOrdenComp(ComprasCommon.comOrdenCompDS exch,
          ComprasCommon.comOrdenCompDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Tomo la sucursal del Usuario
            string lSucursal = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal;
            string lDeposito = GeneralesValidacion.genSucursalesEmpr.Existe(lSucursal, cmd).DepositoOC;

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add(comOrdenCompVar.DepositoDefecto.ToString(), lDeposito);
            lRetorno.Add(comOrdenCompVar.Sucursal.ToString(), lSucursal);

            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ClaseProducto(ComprasCommon.comOrdenCompDS exch, ComprasCommon.comOrdenCompDS exchNoPost,
            int pIndice, Command cmd)

        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);

            exchProd.Producto_Id = exchNoPost.CuerpoArti[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchProd, cmd));

            return exchProd.Clase;
        }

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(ComprasCommon.comOrdenCompDS pCommonDS, Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();


            GeneralesExchange.genEmpresasActionExchange eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            ComprasExchange.comOrdenCompActionExchange eMov = new ComprasExchange.comOrdenCompActionExchange(ComprasExchange.comOrdenCompActionEnum.EnumcomOrdenCompAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N

            };
            eMov = new ComprasExchange.comOrdenCompActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            if (eMov.Estado_Id != "A")
                Generalidades.qFunctionalException.GenerarExcepcion("La_Orden_de_Compra_No_Esta_Autorizada");



            ComprasExchange.comProveedoresActionExchange eProv =
                ComprasValidacion.comProveedores.Existe(eMov.Proveed_Id, cmd);


            string lPara = eProv.EMail;


            // Averigo la Ruta al Pdf

            ComprasExchange.comOrdenCompImprimirActionExchange eImprimir = new ComprasExchange.comOrdenCompImprimirActionExchange(ComprasExchange.comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.AsignarNombre)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N
            };


            eImprimir = new ComprasExchange.comOrdenCompImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eImprimir, cmd));
            // aj siempre la regenero ya que si se modifico enviaba la version anterior

            //if (!System.IO.File.Exists(eImprimir.NombreArchivo + ".pdf"))
            //{
            // Si no existe la genero
            eImprimir.Action = ComprasExchange.comOrdenCompImprimirActionEnum.GetAccioncomOrdenCompImprimirAction
                (ComprasExchange.comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction.Guardar);

            eImprimir = new ComprasExchange.comOrdenCompImprimirActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(eImprimir, cmd));


            // FIN AJ
            lRetorno.Adjuntos.AddAdjuntosRow(1,
                    Guid.NewGuid().ToString(), eImprimir.NombreArchivo.EndsWith(".pdf") ? eImprimir.NombreArchivo : eImprimir.NombreArchivo + ".pdf", "pdf",
                     eImprimir.PDF, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());


            object[] lParam = { eEmpresa.RazonSocial };
            // todo definir esto

            string lCuerpo = "<HTML>";
            lCuerpo += "<div><p>Sres " + eProv.RazonSocial + "</p></div>";
            lCuerpo += "<div><p>Adjunto a este correo encontrará su Orden de Compra</p></div>";
            lCuerpo += "<div><p>Agradecemos su Atención.</p></div>";
            lCuerpo += "<div><p>Área de Compras de " + eEmpresa.RazonSocial.Trim() + "</p></div>";
            lCuerpo += "</HTML>";
            var eUsu = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
            Recursos.RecursoFE recu = new Recursos.RecursoFE(eUsu.Cultura);

            lRetorno.Principal.AddPrincipalRow(recu.GetString("Orden_de_Compra_de_<0>", new object[] { eEmpresa.RazonSocial }),
                    lCuerpo, lPara, "", "", true);
            

            //...... 
            //...... 
            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }
    }
}
