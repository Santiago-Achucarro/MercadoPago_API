using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genTipoCambio
    {
        public static genTipoCambioDS Datos(string /*0*/pMoneda_Id, DateTime /*1*/pFecha, int pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id, /*1*/pFecha,  pEmpresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genTipoCambioDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genTipoCambioDS dsTipado = new genTipoCambioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pMoneda_Id, DateTime /*1*/pFecha, int pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id, /*1*/pFecha, new Generalidades.NullableInt(pEmpresa) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genTipoCambioEliminar", parametros);
        }
        public static void Guardar(string /*0*/pMoneda_Id, DateTime /*1*/pFecha, int /*2*/pEmpresa_Id, decimal /*3*/pCambioCompra, decimal /*4*/pCambioVenta, int /*5*/pUsuario_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id, /*1*/pFecha, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pCambioCompra, /*4*/pCambioVenta, /*5*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genTipoCambioGuardar", parametros);
        }

        public static genTipoCambioDS DatosPost(string /*0*/pMoneda_Id, DateTime /*1*/pFecha, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pMoneda_Id, /*1*/pFecha, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genTipoCambioPostDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genTipoCambioDS dsTipado = new genTipoCambioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
