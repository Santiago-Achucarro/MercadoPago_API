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
    public class sueTipoPago
    {
        public static sueTipoPagoDS Datos(string /*0*/pTipoPago_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoPago_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTipoPagoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueTipoPagoDS dsTipado = new sueTipoPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoPago_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoPago_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTipoPagoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pTipoPago_Id, string /*1*/pTipoPago_Id_Nueva, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, bool /*4*/pInactivo, bool /*5*/pPosteado, int /*6*/pUsuario_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoPago_Id, /*1*/pTipoPago_Id_Nueva, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pInactivo, /*5*/pPosteado, /*6*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueTipoPagoGuardar", parametros);
        }

    }
}
