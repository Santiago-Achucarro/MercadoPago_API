using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesTiposId
    {
        public static tesTiposIdDS Datos(string /*0*/pTipoCartera, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoCartera };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesTiposIdDatos", parametros);

            tesTiposIdDS dsTipado = new tesTiposIdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoCartera, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTipoCartera) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesTiposIdEliminar", parametros);
        }


        public static int Guardar(string /*0*/pTipoCartera, string /*1*/pTipoCartera_Nuevo, string /*2*/pDescripcion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoCartera, /*1*/pTipoCartera_Nuevo, /*2*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesTiposIdGuardar", parametros);
        }


    }
}
