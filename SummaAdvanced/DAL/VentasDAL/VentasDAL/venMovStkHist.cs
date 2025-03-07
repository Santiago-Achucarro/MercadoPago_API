using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMovStkHist
    {
        public static venMovStkHistDS Datos(long /*0*/pvenMovimientos, int /*1*/pConRenglon, long /*2*/pstkMoviCabe, int /*3*/pRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {new Generalidades.NullableInt64(/*0*/pvenMovimientos),
                new Generalidades.NullableInt(/*1*/pConRenglon), new Generalidades.NullableInt64(/*2*/pstkMoviCabe),
                new Generalidades.NullableInt(/*3*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovStkHistDatos", parametros);

            string[] camposTabla0 = { "Factura", "Remito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovStkHistDS dsTipado = new venMovStkHistDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, long /*2*/pstkMoviCabe,
            int /*3*/pRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pstkMoviCabe, /*3*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovStkHistEliminar", parametros);
        }


        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, long /*2*/pstkMoviCabe, int /*3*/pRenglon, 
            decimal /*4*/pCantidad, string /*5*/pFacturaRemito, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pstkMoviCabe, /*3*/pRenglon,
                /*4*/pCantidad, /*5*/pFacturaRemito };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovStkHistGuardar", parametros);
        }

        public static venMovHistDatosXMovDS DatosXMov(int /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovHistDatosXMov", parametros);

            venMovHistDatosXMovDS dsTipado = new venMovHistDatosXMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
