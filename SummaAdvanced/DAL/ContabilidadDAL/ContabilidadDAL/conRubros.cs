using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conRubros
    {
        public static conRubrosDS Datos(string /*0*/pRubro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conRubrosDatos", parametros);

            conRubrosDS dsTipado = new conRubrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pRubro_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pRubro_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conRubrosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pRubro_Id, string /*1*/pDescripcion, string /*2*/pTipo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Id, /*1*/pDescripcion, /*2*/pTipo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conRubrosGuardar", parametros);
        }
    }
}
