using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasFEEventos
{
    public class comOrdenCompCons
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comOrdenCompDatosConsDS exch, Command cmd)
        {
            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaArt(ComprasCommon.comOrdenCompDatosConsDS exch, ComprasCommon.comOrdenCompDatosConsDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comOrdenCompDatosConsDS.CuerpoArtiDataTable lDF = exchNoPost.CuerpoArti;

            if (lDF[0].Producto_Id == "")
                return "El_Producto_No_puede_ser_Vacio";

            if (lDF[0].CantidadOriginal == 0)

                return "La_cantidad_debe_ser_distinta_a_cero";



            // todo validar la UM


            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string validarFilaMemo(ComprasCommon.comOrdenCompDatosConsDS exch, ComprasCommon.comOrdenCompDatosConsDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comOrdenCompDatosConsDS.CuerpoMemoDataTable lDF = exchNoPost.CuerpoMemo;

            if (lDF[0].Cantidad == 0)
                return "La_cantidad_debe_ser_distinta_a_cero";

            // todo validar la UM?
            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);
            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDF[0].Centro1_Id, cmd);
            ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(lDF[0].Centro2_Id, cmd);


            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string TipoCuerpo(ComprasCommon.comOrdenCompDatosConsDS exch, Command cmd)
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
        public string Print(ComprasCommon.comOrdenCompDatosConsDS exch, Command cmd)
        {
            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].Estado_Id == "P" || exch.Principal[0].Estado_Id == "R")
                return "P";

            return "A";
        }

        public enum comOrdenCompVar
        {
            DepositoDefecto
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablescomOrdenComp(ComprasCommon.comOrdenCompDatosConsDS exch,
          ComprasCommon.comOrdenCompDatosConsDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Tomo la sucursal del Usuario
            string lSucursal = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal;
            string lDeposito = GeneralesValidacion.genSucursalesEmpr.Existe(lSucursal, cmd).DepositoOC;

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add(comOrdenCompVar.DepositoDefecto.ToString(), lDeposito);

            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ClaseProducto(ComprasCommon.comOrdenCompDatosConsDS exch, ComprasCommon.comOrdenCompDatosConsDS exchNoPost,
            int pIndice, Command cmd)

        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);

            exchProd.Producto_Id = exchNoPost.CuerpoArti[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchProd, cmd));

            return exchProd.Clase;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comOrdenCompDatosConsDS DetalleRenglonArti(ComprasCommon.comOrdenCompDatosConsDS exch,
            ComprasCommon.comOrdenCompDatosConsDS exchNoPost, int pIndice, Command cmd)
        {
            exch.DetalleProducto[0].Producto_Id = exch.CuerpoArti[pIndice].Producto_Id;
            exch.DetalleProducto[0].Descripcion = exch.CuerpoArti[pIndice].DescripcionProductos;
            exch.DetalleProducto[0].Medida_Id = exch.CuerpoArti[pIndice].Medida_Id;
            exch.DetalleProducto[0].CantidadPedida = Generalidades.Auxiliares.Redondear(exch.CuerpoArti[pIndice].Cantidad /
                exch.CuerpoArti[0].Factor, 8);
            exch.DetalleProducto[0].CantidadRecibida = Generalidades.Auxiliares.Redondear(exch.CuerpoArti[pIndice].Cantidad_Recibida /
                exch.CuerpoArti[0].Factor, 8);
            exch.DetalleProducto[0].CantidadPendRec = exch.DetalleProducto[0].CantidadPedida - exch.DetalleProducto[0].CantidadRecibida;
            exch.DetalleProducto[0].CantidadFacturada = Generalidades.Auxiliares.Redondear(exch.CuerpoArti[pIndice].Cantidad_Facturada /
                exch.CuerpoArti[0].Factor, 8);
            exch.DetalleProducto[0].CantidadPendFac = exch.DetalleProducto[0].CantidadPedida - exch.DetalleProducto[0].CantidadFacturada;
            exch.DetalleProducto[0].CantidadConsignada = exch.CuerpoArti[pIndice].CantidadConsignada;

            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comOrdenCompDatosConsDS DetalleRenglonMemo(ComprasCommon.comOrdenCompDatosConsDS exch,
            ComprasCommon.comOrdenCompDatosConsDS exchNoPost, int pIndice, Command cmd)
        {
            exch.DetalleProducto[0].Producto_Id = "";
            exch.DetalleProducto[0].Descripcion = exch.CuerpoMemo[pIndice].Detalle;
            exch.DetalleProducto[0].Medida_Id = exch.CuerpoMemo[pIndice].Medida_Id;
            exch.DetalleProducto[0].CantidadPedida = exch.CuerpoMemo[pIndice].Cantidad;
            exch.DetalleProducto[0].CantidadRecibida = exch.CuerpoMemo[pIndice].Cantidad_Recibida;
            exch.DetalleProducto[0].CantidadPendRec = exch.DetalleProducto[0].CantidadPedida - exch.DetalleProducto[0].CantidadRecibida;
            exch.DetalleProducto[0].CantidadFacturada = exch.CuerpoMemo[pIndice].Cantidad_Facturada;
            exch.DetalleProducto[0].CantidadPendFac = exch.DetalleProducto[0].CantidadPedida - exch.DetalleProducto[0].CantidadFacturada;
            exch.DetalleProducto[0].CantidadConsignada = 0;
            return exch;
        }
    }
}
