using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesRengMoviRetProv
    {
        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesRengMoviRetProvEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, decimal /*2*/pPorcentaje, 
            decimal /*3*/pExencion, decimal /*4*/pBaseImponible, decimal /*5*/pAcum, decimal /*6*/pTRet, decimal /*7*/pAcumTot,
            long /*8*/pcomMovProv, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon, /*2*/pPorcentaje, /*3*/pExencion,
                /*4*/pBaseImponible, /*5*/pAcum, /*6*/pTRet, /*7*/pAcumTot, new Generalidades.NullableLong(/*8*/pcomMovProv) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesRengMoviRetProvGuardar", parametros);
        }

        public static tesRengMoviRetProvDS Datos(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengMoviRetProvDatos", parametros);

            string[] camposTabla0 = { "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesRengMoviRetProvDS dsTipado = new tesRengMoviRetProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
