using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCategCredito
    {
        public static venCategCreditoDS Datos(string /*0*/pCategCred_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategCred_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCategCreditoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venCategCreditoDS dsTipado = new venCategCreditoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCategCred_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCategCred_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCategCreditoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCategCred_id, string /*1*/pCategCred_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, short /*4*/pMaxDiasAtraso, decimal /*5*/pPorcenDeudaVenci, decimal /*6*/pTipoCredito, bool /*7*/pInactivo, int /*8*/pUsuario_Id, bool /*9*/pPosteado, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategCred_id, /*1*/pCategCred_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pMaxDiasAtraso, /*5*/pPorcenDeudaVenci, /*6*/pTipoCredito, /*7*/pInactivo, /*8*/pUsuario_Id, /*9*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venCategCreditoGuardar", parametros);
        }




    }
}
