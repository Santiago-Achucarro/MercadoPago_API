using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venTiposClie
    {
        public static venTiposClieDS Datos(string /*0*/pTipoClie_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoClie_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venTiposClieDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id",  "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venTiposClieDS dsTipado = new venTiposClieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pTipoClie_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoClie_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venTiposClieEliminar", parametros);
        }
        public static int Guardar(string /*0*/pTipoClie_Id, string TipoClie_Id_Nuevo, int /*1*/pEmpresa_Id, string /*2*/pDescripcion, string /*3*/pCentro1_Id, string /*4*/pCentro2_Id, int /*5*/pUsuario_Id, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoClie_Id, TipoClie_Id_Nuevo, new Generalidades.NullableInt(/*1*/pEmpresa_Id), /*2*/pDescripcion, new Generalidades.NullableString(/*3*/pCentro1_Id), new Generalidades.NullableString(/*4*/pCentro2_Id), /*5*/pUsuario_Id, /*6*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venTiposClieGuardar", parametros);
        }
    }
}
