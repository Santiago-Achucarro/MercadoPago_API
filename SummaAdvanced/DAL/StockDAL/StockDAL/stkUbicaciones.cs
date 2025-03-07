using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using interfaceDAAB;
using System.Data;
namespace StockDAL
{
    public class stkUbicaciones
    {
        public static stkUbicacionesDS Datos(string /*0*/pUbicacion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUbicacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkUbicacionesDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkUbicacionesDS dsTipado = new stkUbicacionesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(string /*0*/pUbicacion_Id, string /*1*/pUbicacion_Id_Nuevo, decimal /*2*/pCapacidad, int /*3*/pUsuario_Id, bool /*4*/pInactivo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUbicacion_Id, /*1*/pUbicacion_Id_Nuevo, /*2*/pCapacidad, new Generalidades.NullableInt(/*3*/pUsuario_Id), /*4*/pInactivo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkUbicacionesGuardar", parametros);
        }



        public static void Eliminar(string /*0*/pUbicacion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUbicacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkUbicacionesDatos", parametros);
        }
    }
}
