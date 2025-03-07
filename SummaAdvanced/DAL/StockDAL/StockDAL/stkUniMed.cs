using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkUniMed
    {
        public static stkUniMedDS Datos(string /*0*/pMedida_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMedida_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkUniMedDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodigoFiscal", "UniExpor"};
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkUniMedDS dsTipado = new stkUniMedDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pMedida_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pMedida_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkUniMedEliminar", parametros);
        }

        public static int Guardar(string /*0*/pMedida_id, string /*1*/pMedida_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, 
            int /*4*/pDecimales, string /*5*/pMascara, string /*6*/pCodigoFiscal, bool /*7*/pInactivo, 
            int /*8*/pUsuario_Id, bool /*9*/pPosteado, string pUniExpor, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMedida_id, /*1*/pMedida_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pDecimales, /*5*/pMascara, new Generalidades.NullableString(/*6*/pCodigoFiscal), /*7*/pInactivo, /*8*/pUsuario_Id, /*9*/pPosteado, new Generalidades.NullableString(pUniExpor) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("stkUniMedGuardar", parametros);
        }



    }
}
