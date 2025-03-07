using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comCondFiscal
    {
        public static comCondFiscalDS Datos(string /*0*/pCondFiscal_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFiscal_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comCondFiscalDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id",  "CodigoFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comCondFiscalDS dsTipado = new comCondFiscalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pCondFiscal_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCondFiscal_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comCondFiscalEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCondFiscal_id, string /*1*/pCondFiscal_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCodigoFiscal, bool /*5*/pInactivo, int /*6*/pUsuario_Id, bool /*7*/pPosteado, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFiscal_id, /*1*/pCondFiscal_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pCodigoFiscal), /*5*/pInactivo, /*6*/pUsuario_Id, /*7*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("comCondFiscalGuardar", parametros));
        }








    }
}
