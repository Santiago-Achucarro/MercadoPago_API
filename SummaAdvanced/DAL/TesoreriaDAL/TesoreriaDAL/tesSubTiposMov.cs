using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesSubTiposMov
    {
        public static tesSubTiposMovDS Datos(string /*0*/pSubTipo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSubTiposMovDatos", parametros);
            string[] camposTabla0 = { "Reporte_Id", "Titulo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesSubTiposMovDS dsTipado = new tesSubTiposMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pSubTipo_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipo_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesSubTiposMovEliminar", parametros);
        }
        public static int Guardar(string /*0*/pSubTipo_Id, string /*1*/pSubTipo_Id_Nuevo, string /*2*/pDescripcion, short /*3*/pCantCopias, string /*4*/pTipomov, 
            string /*7*/ pReporte_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipo_Id, /*1*/pSubTipo_Id_Nuevo, /*2*/pDescripcion, /*3*/pCantCopias, /*4*/pTipomov,
             /*5*/   new Generalidades.NullableString(pReporte_Id)};

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesSubTiposMovGuardar", parametros);
        }


    }
}
