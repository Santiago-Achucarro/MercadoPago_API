using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueLiqVarGlobales
    {
        public static void EliminarEmpresa(int /*0*/pVarGlobal_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiqVarEmpGlobalesEliminar", parametros);
        }

        public static sueLiqVarGlobalesDS Datos(DateTime /*0*/pFecha, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueLiqVarGlobalesDatos", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Fecha_Desde", "Usuario_Id", "Empresa_Id", "Ver" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqVarGlobalesDS dsTipado = new sueLiqVarGlobalesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pVarGlobal_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiqVarGlobalesEliminar", parametros);
        }

        public static void Guardar(int /*0*/pVarGlobal_Id, DateTime /*1*/pFecha_Desde, decimal /*2*/pValor, int /*3*/pUsuario_Id, int /*4*/pEmpresa_Id, int /*5*/pVer, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id, /*1*/pFecha_Desde, /*2*/pValor, /*3*/pUsuario_Id, /*4*/pEmpresa_Id, /*5*/pVer };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiqVarGlobalesGuardar", parametros);
        }



        public static void GuardarEmpresa(int /*0*/pVarGlobal_Id, DateTime /*1*/pFecha_Desde, decimal /*2*/pValor, int /*3*/pUsuario_Id, int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id, /*1*/pFecha_Desde, /*2*/pValor, /*3*/pUsuario_Id, /*4*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiqVarEmpGlobalesGuardar", parametros);
        }

        public static sueLiqVarGlobalHistoricoDS DatosHistorico(int /*0*/pVarGlobal_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id, /*1*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueLiqVarGlobalHistorico", parametros);

            string[] camposTabla0 = { "VarGlobal_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Usuario_Id", "Ver" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqVarGlobalHistoricoDS dsTipado = new sueLiqVarGlobalHistoricoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
