using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
   public class stkFamilias
    {
        public static stkFamiliasDS Datos(string /*0*/pFamilia_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFamilia_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkFamiliasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkFamiliasDS dsTipado = new stkFamiliasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pFamilia_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pFamilia_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkFamiliasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pFamilia_Id, string /*1*/pFamilia_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id,
            bool /*4*/pInactivo, bool /*5*/pPosteado, int /*6*/pUsuario_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFamilia_Id, /*1*/pFamilia_Id_Nuevo, /*2*/pDescripcion,
                new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pInactivo, /*5*/pPosteado, /*6*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkFamiliasGuardar", parametros));
        }
    }
}
