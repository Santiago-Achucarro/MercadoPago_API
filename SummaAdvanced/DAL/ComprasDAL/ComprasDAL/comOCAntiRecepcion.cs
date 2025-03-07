using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    public class comOCAntiRecepcion
    {
        public static comOCAntiRecepcionDS Datos(long /*0*/pcomAntiRecepcion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomAntiRecepcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOCAntiRecepcionDatos", parametros);

            string[] camposTabla0 = { "comOcRecepcion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOCAntiRecepcionDS dsTipado = new comOCAntiRecepcionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomAntiRecepcion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomAntiRecepcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOCAntiRecepcionEliminar", parametros);
        }


        public static void Insertar(long /*0*/pcomAntiRecepcion, long /*1*/pcomOcRecepcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomAntiRecepcion, /*1*/pcomOcRecepcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCAntiRecepcionInsertar", parametros);
        }




    }
}
