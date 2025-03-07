using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comOcReceCuerpo
    {

        public static comOcReceCuerpoDS Datos(long /*0*/pcomOcRecepcion, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOcRecepcion, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOcReceCuerpoDatos", parametros);

            string[] camposTabla0 = { "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOcReceCuerpoDS dsTipado = new comOcReceCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomOcRecepcion, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOcRecepcion, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOcReceCuerpoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomOcRecepcion, int /*1*/pconRenglon, int /*2*/pcomOrdenComp, int /*3*/pRenglon_OC, 
            decimal /*4*/pCantidad, string /*5*/pObservaciones, decimal /*6*/pCantFactPendiente, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOcRecepcion, /*1*/pconRenglon, /*2*/pcomOrdenComp, /*3*/pRenglon_OC, /*4*/pCantidad,
                new Generalidades.NullableString(/*5*/pObservaciones), /*6*/pCantFactPendiente };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOcReceCuerpoGuardar", parametros);
        }

        public static void ActuPendiente(long /*0*/pcomOcRecepcion, int /*1*/pconRenglon, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOcRecepcion, /*1*/pconRenglon, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOcReceCuerpoActuPendiente", parametros);
        }
    }
}
