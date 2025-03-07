using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;
namespace ProduccionDAL
{
    public class proVarGlobales
    {
        public static provarGlobalesDS Datos(short /*0*/pVariable_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVariable_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("provarGlobalesDatos", parametros);

            provarGlobalesDS dsTipado = new provarGlobalesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(short /*0*/pVariable_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pVariable_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("provarGlobalesEliminar", parametros);
        }

        public static void Guardar(short /*0*/pVariable_Id, string /*1*/pDescripcion, decimal /*2*/pValor, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVariable_Id, /*1*/pDescripcion, /*2*/pValor };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("provarGlobalesGuardar", parametros);
        }

    }
}
