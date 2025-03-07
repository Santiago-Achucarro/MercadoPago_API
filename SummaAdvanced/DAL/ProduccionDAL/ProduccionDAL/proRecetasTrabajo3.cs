using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;
namespace ProduccionDAL
{
    public class proRecetasTrabajo3
    {
        public static proRecetasTrabajo3DS Datos(string /*0*/pReceta_Id, string /*1*/pTrabajo3_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, new Generalidades.NullableString(/*1*/pTrabajo3_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proRecetasTrabajo3Datos", parametros);

            proRecetasTrabajo3DS dsTipado = new proRecetasTrabajo3DS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pReceta_Id, string /*1*/pTrabajo3_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, new Generalidades.NullableString(/*1*/pTrabajo3_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proRecetasTrabajo3Eliminar", parametros);
        }

        public static void Guardar(string /*0*/pReceta_Id, string /*1*/pTrabajo3_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReceta_Id, /*1*/pTrabajo3_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proRecetasTrabajo3Guardar", parametros);
        }

    }
}
