using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genProvincias
    {
        public static genProvinciasDS Datos(string /*0*/pProvincia_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProvincia_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genProvinciasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genProvinciasDS dsTipado = new genProvinciasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pProvincia_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pProvincia_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genProvinciasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pProvincia_Id, string /*1*/pProvincia_Id_Nuevo, int /*2*/pEmpresa_Id, 
            string /*3*/pDescripcion, string /*4*/pCodFiscal, bool /*5*/pInactivo, int /*6*/pUsuario_Id, bool /*7*/pPosteado, 
            string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProvincia_Id, /*1*/pProvincia_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pCodFiscal, /*5*/pInactivo, /*6*/pUsuario_Id, /*7*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("genProvinciasGuardar", parametros);
        }





    }
}
