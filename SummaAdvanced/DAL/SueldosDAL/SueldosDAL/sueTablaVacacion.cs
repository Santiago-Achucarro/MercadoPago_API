using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
    public class sueTablaVacacion
    {
        public static sueTablaVacacionDS Datos(string /*0*/pTablaVac_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTablaVac_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTablaVacacionDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            sueTablaVacacionDS dsTipado = new sueTablaVacacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pTablaVac_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTablaVac_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTablaVacacionEliminar", parametros);
        }

        public static int Guardar(string /*0*/pTablaVac_Id, string /*1*/pTablaVac_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pDias, int /*4*/pEmpresa_Id, int /*5*/pUsuario_Id, bool /*6*/pInactivo, bool /*7*/pPosteado, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTablaVac_Id, /*1*/pTablaVac_Id_Nuevo, /*2*/pDescripcion, /*3*/pDias, new Generalidades.NullableInt(/*4*/pEmpresa_Id), /*5*/pUsuario_Id, /*6*/pInactivo, /*7*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueTablaVacacionGuardar", parametros);
        }






    }
}
