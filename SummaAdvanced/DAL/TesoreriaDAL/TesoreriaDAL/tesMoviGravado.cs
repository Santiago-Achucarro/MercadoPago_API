using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesMoviGravado
    {
        public static tesMoviGravadoDS Datos(long /*0*/ptesMovimientos, int /*1*/pTipoCtaProv, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pTipoCtaProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesMoviGravadoDatos", parametros);

            tesMoviGravadoDS dsTipado = new tesMoviGravadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pTipoCtaProv, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pTipoCtaProv) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesMoviGravadoEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pTipoCtaProv, decimal /*2*/pImporte, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pTipoCtaProv, /*2*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesMoviGravadoGuardar", parametros);
        }
    }
}
