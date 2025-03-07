using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VentasCommon;
using interfaceDAAB;

namespace VentasDAL
{
    public class venMoviPredial
    {
        public static venMoviPredialDS Datos(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMoviPredialDatos", parametros);

            venMoviPredialDS dsTipado = new venMoviPredialDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMoviPredialEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pCuentaPredial, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon, /*2*/pCuentaPredial };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMoviPredialGuardar", parametros);
        }




    }
}
