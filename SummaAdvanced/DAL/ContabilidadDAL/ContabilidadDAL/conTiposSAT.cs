using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conTiposSAT
    {
        public static conTiposSATDS Datos(string /*0*/pTipoSAT_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoSAT_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conTiposSATDatos", parametros);

            conTiposSATDS dsTipado = new conTiposSATDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoSAT_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTipoSAT_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conTiposSATEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTipoSAT_Id, string /*1*/pDescripcion, string /*2*/pRubro, bool /*3*/pCirculante, bool /*4*/pImputable, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoSAT_Id, /*1*/pDescripcion, /*2*/pRubro, /*3*/pCirculante, /*4*/pImputable };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conTiposSATGuardar", parametros);
        }
    }
}
