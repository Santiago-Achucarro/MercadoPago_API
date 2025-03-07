using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrdenTrabajo3
    {
        public static proOrdenTrabajos3DS Datos(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenTrabajos3Datos", parametros);

            string[] camposTabla0 = { "Proveed_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proOrdenTrabajos3DS dsTipado = new proOrdenTrabajos3DS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenTrabajos3Eliminar", parametros);
        }

        public static void Guardar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/pproTrabajo3, string /*3*/pProveed_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon, /*2*/pproTrabajo3, new Generalidades.NullableString(/*3*/pProveed_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenTrabajos3Guardar", parametros);
        }

    }
}
