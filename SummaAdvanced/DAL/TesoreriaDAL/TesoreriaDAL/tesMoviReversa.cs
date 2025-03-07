using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesMoviReversa
    {
        public static tesMoviReversaDS Datos(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesMoviReversaDatos", parametros);

            tesMoviReversaDS dsTipado = new tesMoviReversaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesMoviReversaEliminar", parametros);
        }
        public static void Guardar(long /*0*/ptesMovimientos, long /*1*/ptesMoviReversa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/ptesMoviReversa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesMoviReversaGuardar", parametros);
        }

        public static tesMoviReversaRevDS DatosRev(long /*0*/ptesMovimientosRev, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientosRev };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesMoviReversaRevDatos", parametros);

            tesMoviReversaRevDS dsTipado = new tesMoviReversaRevDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
