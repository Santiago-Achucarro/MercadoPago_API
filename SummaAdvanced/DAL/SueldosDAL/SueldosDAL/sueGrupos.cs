using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueGrupos
    {
        public static sueGruposDS Datos(int /*0*/pGrupo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueGruposDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Segmento_Id", "DescripcionSegmento", "Periodo_Id", "CtaSueldoAPagar", "DescripcionCtaSueldoAPagar" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueGruposDS dsTipado = new sueGruposDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pGrupo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pGrupo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueGruposEliminar", parametros);
        }

        public static int Guardar(int /*0*/pGrupo_Id, int /*1*/pGrupo_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, string /*4*/pSegmento_Id, string /*5*/pPeriodo_Id, string /*6*/pCtaSueldoAPagar, bool /*7*/pInactivo, bool /*8*/pPosteado, int /*9*/pUsuario_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, /*1*/pGrupo_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), new Generalidades.NullableString(/*4*/pSegmento_Id), new Generalidades.NullableString(/*5*/pPeriodo_Id), new Generalidades.NullableString(/*6*/pCtaSueldoAPagar), /*7*/pInactivo, /*8*/pPosteado, /*9*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueGruposGuardar", parametros);
        }

    }
}
