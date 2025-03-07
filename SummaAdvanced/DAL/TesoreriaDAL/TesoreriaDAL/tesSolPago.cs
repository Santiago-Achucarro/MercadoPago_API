using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesSolPago
    {
        public static tesSolPagoDS Datos(long /*0*/ptesSolicitud, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesSolicitud, /*1*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolPagoDatos", parametros);

            tesSolPagoDS dsTipado = new tesSolPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/ptesSolicitud, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesSolicitud, /*1*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesSolPagoEliminar", parametros);
        }

        public static void Insertar(long /*0*/ptesSolicitud, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesSolicitud, /*1*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesSolPagoInsertar", parametros);
        }


    }
}
