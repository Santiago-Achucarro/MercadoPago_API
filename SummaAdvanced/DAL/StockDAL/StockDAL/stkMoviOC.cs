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
    public class stkMoviOC
    {
        public static stkMoviOCDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviOCDatos", parametros);

            stkMoviOCDS dsTipado = new stkMoviOCDS();
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

            oiDAAB.eliminar("stkMoviOCEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, int /*2*/pcomOrdenComp, int /*3*/pRenglon_OC, 
            decimal /*4*/pCantFactPendiente, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pcomOrdenComp, /*3*/pRenglon_OC, /*4*/pCantFactPendiente };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviOCInsertar", parametros);
        }

        public static void ActuPendiente(long /*0*/pstkMoviCabe, int /*1*/pRenglon, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviOCActuPendiente", parametros);
        }
    }
}
