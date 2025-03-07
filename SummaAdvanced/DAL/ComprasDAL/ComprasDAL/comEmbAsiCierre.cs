using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;
namespace ComprasDAL
{
    public class comEmbAsiCierre
    {
        public static comEmbAsiCierreDS Datos(long /*0*/pcomEmbarques, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/new Generalidades.NullableInt64(pcomEmbarques), /*1*/new Generalidades.NullableInt64(pstkMoviCabe) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbAsiCierreDatos", parametros);

            comEmbAsiCierreDS dsTipado = new comEmbAsiCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomEmbarques, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEmbAsiCierreEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomEmbarques, long /*1*/pstkMoviCabe, decimal /*2*/pCambio, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pstkMoviCabe, /*2*/pCambio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbAsiCierreInsertar", parametros);
        }


    }
}
