using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proSubRecursos
    {
        public static proTrabajo3ProvDS Datos(string /*0*/pTrabajo3_Id, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTrabajo3_Id, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proTrabajo3ProvDatos", parametros);

            string[] camposTabla0 = { "Proveed_Id", "DescripcionProveed", "Moneda_Id", "DescripcionMoneda", "Medida_Id", "DescripcionUniMed" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proTrabajo3ProvDS dsTipado = new proTrabajo3ProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pRecurso_Id, string /*1*/pSubRecurso_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRecurso_Id, new Generalidades.NullableString(/*1*/pSubRecurso_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proSubRecursosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pSubRecurso_Id, string /*1*/pSubRecurso_Id_Nuevo, string /*2*/pRecurso_Id, string /*3*/pDescripcion, decimal /*4*/pCapacidad, decimal /*5*/pCosto, bool /*6*/pPredeterminado, bool /*7*/pInactivo, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubRecurso_Id, /*1*/pSubRecurso_Id_Nuevo, /*2*/pRecurso_Id, /*3*/pDescripcion, /*4*/pCapacidad, /*5*/pCosto, /*6*/pPredeterminado, /*7*/pInactivo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proSubRecursosGuardar", parametros);
        }

        public static proSubRecursosDS DatosUNO(string /*0*/pSubRecurso_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubRecurso_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proSubRecursosUNODatos", parametros);

            proSubRecursosDS dsTipado = new proSubRecursosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
