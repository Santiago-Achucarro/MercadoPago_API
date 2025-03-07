using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public static class venMovConStockCr
    {

        public static venMovConStockCrDS Datos(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pRenglonCuerpo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovConStockCrDatos", parametros);

            string[] camposTabla0 = { "RenglonReferencia", "Producto_Id", "CFVenta_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "Observaciones", "CantidadAduana", "UnidadAduana", "ValorUnitarioAduana", "ValorDolares", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovConStockCrDS dsTipado = new venMovConStockCrDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pConRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pConRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovConStockCrEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/pProducto_Id, string /*3*/pDeposito_Id, string /*4*/pMedida_Id, decimal /*5*/pFactor, decimal /*6*/pCantFacturada, decimal /*7*/pCantEntregada, decimal /*8*/pCantPendiente, decimal /*9*/pCantOriginal, string /*10*/pMedidaAlterna, decimal /*11*/pCantidadAlternaForm, string /*12*/pTipoPrecio, decimal /*13*/pPrecioForm, decimal /*14*/pPrecioSinIva, decimal /*15*/pPrecioLista, decimal /*16*/pPrecioVenta, decimal /*17*/pPrecioFormImpuesto, decimal /*18*/pPrecioFormImpuestoBon, decimal /*19*/pPrecioFormImpuestoTot, decimal /*20*/pComiPorce, decimal /*21*/pBonificacion, string /*22*/pObservaciones, DateTime /*23*/pFechaEntrega, decimal /*24*/pSubTotal, decimal /*25*/pSubTotalFormImpuesto, string /*26*/pCentro1_Id, string /*27*/pCentro2_Id, decimal /*28*/pCantEntregadaForm, string /*29*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, new Generalidades.NullableString(/*2*/pProducto_Id), new Generalidades.NullableString(/*3*/pDeposito_Id), new Generalidades.NullableString(/*4*/pMedida_Id), /*5*/pFactor, /*6*/pCantFacturada, /*7*/pCantEntregada, /*8*/pCantPendiente, /*9*/pCantOriginal, new Generalidades.NullableString(/*10*/pMedidaAlterna), /*11*/pCantidadAlternaForm, /*12*/pTipoPrecio, /*13*/pPrecioForm, /*14*/pPrecioSinIva, /*15*/pPrecioLista, /*16*/pPrecioVenta, /*17*/pPrecioFormImpuesto, /*18*/pPrecioFormImpuestoBon, /*19*/pPrecioFormImpuestoTot, /*20*/pComiPorce, /*21*/pBonificacion, new Generalidades.NullableString(/*22*/pObservaciones), /*23*/pFechaEntrega, /*24*/pSubTotal, /*25*/pSubTotalFormImpuesto, new Generalidades.NullableString(/*26*/pCentro1_Id), new Generalidades.NullableString(/*27*/pCentro2_Id), /*28*/pCantEntregadaForm };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovConStockCrGuardar", parametros);
        }



        public static void ActuCantPendiente(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovConStockCrCantPendiente", parametros);
        }


    }
}
