using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conCentro1
    {
        public static conCentro1DS Datos(string /*0*/pCentro1_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCentro1_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCentro1Datos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Notas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conCentro1DS dsTipado = new conCentro1DS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCentro1_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCentro1_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conCentro1Eliminar", parametros);
        }

        public static int Guardar(string /*0*/pCentro1_Id, string /*1*/pCentro1_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, short /*4*/pNivel, bool /*5*/pImputable, string /*6*/pNotas, bool /*7*/pInactivo, int /*8*/pUsuario_Id, bool /*9*/pPosteado, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCentro1_Id, /*1*/pCentro1_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pNivel, /*5*/pImputable, new Generalidades.NullableString(/*6*/pNotas), /*7*/pInactivo, /*8*/pUsuario_Id, /*9*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("conCentro1Guardar", parametros));
        }


    }
}
