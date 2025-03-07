using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCotizCuerpo
    {
        public static venCotizCuerpoDS Datos(int /*0*/pCotizacion_Id, int /*1*/pRenglon_Co, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, new Generalidades.NullableInt(/*1*/pRenglon_Co) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venCotizCuerpoDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "DescripcionProducto", "Medida_Id", "DescripcionMedida", "Deposito_Id", "DescripcionDeposito", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "SubTotal", "SubTotalNeto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venCotizCuerpoDS dsTipado = new venCotizCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pCotizacion_Id, int /*1*/pRenglon_Co, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, new Generalidades.NullableInt(/*1*/pRenglon_Co) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCotizCuerpoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pCotizacion_Id, int /*1*/pRenglon_Co, string /*2*/pProducto_Id, string /*3*/pMedida_Id, string /*4*/pDeposito_Id, decimal /*5*/pFactor, decimal /*6*/pCantidadOriginal, decimal /*7*/pCantidadPedida, decimal /*8*/pCantidadRemitida, decimal /*9*/pCantidadFacturada, decimal /*10*/pPrecioForm, decimal /*11*/pPrecioLista, decimal /*12*/pPrecioVenta, DateTime /*13*/pFechaEntrega, bool /*14*/pEspecial, decimal /*15*/pBonificacion, string /*16*/pObservaciones, bool /*17*/pPendiente, bool /*18*/pReservaMercaderia, decimal /*19*/pPrecioListaForm, string /*20*/pCentro1_Id, string /*21*/pCentro2_Id, string /*22*/pTipoPrecio, string /*23*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, /*1*/pRenglon_Co, new Generalidades.NullableString(/*2*/pProducto_Id), new Generalidades.NullableString(/*3*/pMedida_Id), new Generalidades.NullableString(/*4*/pDeposito_Id), /*5*/pFactor, /*6*/pCantidadOriginal, /*7*/pCantidadPedida, /*8*/pCantidadRemitida, /*9*/pCantidadFacturada, /*10*/pPrecioForm, /*11*/pPrecioLista, /*12*/pPrecioVenta, /*13*/pFechaEntrega, /*14*/pEspecial, /*15*/pBonificacion, new Generalidades.NullableString(/*16*/pObservaciones), /*17*/pPendiente, /*18*/pReservaMercaderia, /*19*/pPrecioListaForm, new Generalidades.NullableString(/*20*/pCentro1_Id), new Generalidades.NullableString(/*21*/pCentro2_Id), /*22*/pTipoPrecio };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizCuerpoGuardar", parametros);
        }



        public static void SumarCant(int /*0*/pCotizacion_Id, int /*1*/pRenglon_Co, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, /*1*/pRenglon_Co, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizCuerpoSumaCant", parametros);
        }

        public static bool TienePendiente(int /*0*/pCotizacion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizCuerpoTienePend", parametros);
            if (ds.Tables[0].Rows.Count==0)
                return false;

            if (Convert.ToInt32(ds.Tables[0].Rows[0]["Cantidad"]) > 0)
                return true;

            return false;


        }



    }
}
