using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCobradores
    {
        public static venCobradoresDS Datos(string /*0*/pCobrador_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCobrador_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCobradoresDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venCobradoresDS dsTipado = new venCobradoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venCobradoresDS DatosId(long /*0*/pIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCobradoresDatosId", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venCobradoresDS dsTipado = new venCobradoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string pCobrador_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCobrador_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCobradoresEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenCobradores, string /*1*/pCobrador_Id, string /*2*/pCobrador_Id_Nuevo, int /*3*/pEmpresa_Id, 
            string /*4*/pNombre, decimal /*6*/pComision, decimal /*7*/pLimiteComision, bool /*8*/pInactivo, int /*9*/pUsuario_Id,
            bool /*10*/pPosteado, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCobradores, /*1*/pCobrador_Id, /*2*/pCobrador_Id_Nuevo,
                new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pNombre, /*6*/pComision,
                /*7*/pLimiteComision, /*8*/pInactivo, /*9*/pUsuario_Id, /*10*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCobradoresGuardar", parametros);
        }

    }
}
