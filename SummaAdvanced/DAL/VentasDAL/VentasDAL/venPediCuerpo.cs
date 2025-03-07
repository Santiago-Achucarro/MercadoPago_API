using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venPediCuerpo
    {
        public static venPediCuerpoDS Datos(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, new Generalidades.NullableInt(/*1*/pRenglon_Pe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venPediCuerpoDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "DescripcionProductos", "ObservacionesProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "SubTotalNeto", "Anular" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPediCuerpoDS dsTipado = new venPediCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, new Generalidades.NullableInt(/*1*/pRenglon_Pe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
                             
            oiDAAB.eliminar("venPediCuerpoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/pProducto_Id, string /*3*/pMedida_Id, string /*4*/pDeposito_Id,
            decimal /*5*/pFactor, decimal /*6*/pCantidadOriginal, decimal /*7*/pCantidadPedida, decimal /*8*/pCantidadRemitida,
            decimal /*9*/pCantidadFacturada, decimal /*10*/pPrecioForm, decimal /*11*/pPrecioSinIva, decimal /*12*/pPrecioLista, 
            decimal /*13*/pPrecioListaForm, decimal /*14*/pPrecioVenta, string /*15*/pTipoPrecio, decimal /*16*/pSubTotal, DateTime /*17*/pFechaEntrega,
            bool /*18*/pEspecial, decimal /*19*/pBonificacion, string /*20*/pObservaciones, bool /*21*/pPendiente, bool /*22*/pReservaMercaderia, 
            string /*23*/pCentro1_Id, string /*24*/pCentro2_Id, string /*25*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, new Generalidades.NullableString(/*2*/pProducto_Id),
                new Generalidades.NullableString(/*3*/pMedida_Id), new Generalidades.NullableString(/*4*/pDeposito_Id), /*5*/pFactor, 
                /*6*/pCantidadOriginal, /*7*/pCantidadPedida, /*8*/pCantidadRemitida, /*9*/pCantidadFacturada, /*10*/pPrecioForm, /*11*/pPrecioSinIva,
                /*12*/pPrecioLista, /*13*/pPrecioListaForm, /*14*/pPrecioVenta, /*15*/pTipoPrecio, /*16*/pSubTotal, /*17*/pFechaEntrega,
                /*18*/pEspecial, /*19*/pBonificacion, new Generalidades.NullableString(/*20*/pObservaciones), /*21*/pPendiente, /*22*/pReservaMercaderia,
                new Generalidades.NullableString(/*23*/pCentro1_Id), new Generalidades.NullableString(/*24*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediCuerpoGuardar", parametros);
        }


        public static void Entregan(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediCuerpoEntregar", parametros);
        }

        public static void Facturan(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediCuerpoFacturar", parametros);
        }

        public static venPediCuerpoDS Renglon(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediCuerpoRenglon", parametros);

            string[] camposTabla0 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos",
                "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPediCuerpoDS dsTipado = new venPediCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Desechar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, new Generalidades.NullableInt(/*1*/pRenglon_Pe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediCuerpoDesecharPend", parametros);
        }

    }
}
