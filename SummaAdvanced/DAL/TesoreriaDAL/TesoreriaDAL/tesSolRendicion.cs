using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesSolRendicion
    {
        public static tesSolRendicionDS Datos(long /*0*/ptesMovimientos, long /*1*/ptesSolicitud, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/ptesSolicitud };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolRendicionDatos", parametros);

            tesSolRendicionDS dsTipado = new tesSolRendicionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesSolRendicionEliminar", parametros);
        }

        public static void Insertar(long /*0*/ptesMovimientos, long /*1*/ptesSolicitud, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/ptesSolicitud };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesSolRendicionInsertar", parametros);
        }


    }
}
