using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkRemiPendFact
    {
        public static stkRemiPendFactDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkRemiPendFactDatos", parametros);

            stkRemiPendFactDS dsTipado = new stkRemiPendFactDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkRemiPendFactEliminar", parametros);
        }
        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, decimal /*2*/pCantidadPendiente, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pCantidadPendiente };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkRemiPendFactGuardar", parametros);
        }

        public static void ActualizarPend(long /*0*/pstkMoviCabe, int /*1*/pRenglon, decimal /*2*/pCantidadPendiente, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pCantidadPendiente };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkRemiPendFactActualizarPend", parametros);
        }


    }
}
