using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueLiqCatego
    {
        public static sueLiqCategoDS Datos(string /*0*/pCategoria_Id, int /*1*/pEmpresa_Id, DateTime /*2*/pFecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pEmpresa_Id, /*2*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqCategoDatos", parametros);

            string[] camposTabla1 = { "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqCategoDS dsTipado = new sueLiqCategoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void EliminarEmpresa(int /*0*/pCateNombre_Id, string /*1*/pCategoria_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre_Id, /*1*/pCategoria_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiqEmpCategoEliminar", parametros);
        }

        public static void GuardarEmpresa(int /*0*/pCateNombre_Id, string /*1*/pCategoria_Id, DateTime /*2*/pFecha_Desde, decimal /*3*/pValor, int /*4*/pUsuario_Id, int /*5*/pEmpresa_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre_Id, /*1*/pCategoria_Id, /*2*/pFecha_Desde, /*3*/pValor, /*4*/pUsuario_Id, /*5*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiqEmpCategoGuardar", parametros);
        }

        public static void Eliminar(string /*0*/pCategoria_Id, int /*1*/pCateNombre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pCateNombre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiqImpCategoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pCateNombre, string /*1*/pCategoria_Id, DateTime /*2*/pFecha_Desde, decimal /*3*/pValor, int /*4*/pUsuario_Id, int /*5*/pEmpresa_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre, /*1*/pCategoria_Id, /*2*/pFecha_Desde, /*3*/pValor, /*4*/pUsuario_Id, /*5*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiqImpCategoGuardar", parametros);
        }

        public static sueLiqCateNombreHistoricoDS DatosHistorico(string /*0*/pCategoria_Id, int /*1*/pCateNombre, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCategoria_Id, /*1*/pCateNombre, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqCateNombreHistorico", parametros);

            string[] camposTabla1 = { "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqCateNombreHistoricoDS dsTipado = new sueLiqCateNombreHistoricoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
