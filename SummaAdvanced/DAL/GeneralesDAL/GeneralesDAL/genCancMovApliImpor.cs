using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;
using System.Text;


namespace GeneralesDAL
{
    public class genCancMovApliImpor
    {
        public static genCancMovApliImporDS Datos(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genCancMovApliImporDatos", parametros);

            genCancMovApliImporDS dsTipado = new genCancMovApliImporDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(long /*0*/pconAsientos, int /*1*/pRenglon, bool /*2*/pEsDelAp, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon, /*2*/pEsDelAp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genCancMovApliImporGuardar", parametros);
        }

        public static void Eliminar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genCancMovApliImporEliminar", parametros);
        }




    }
}
