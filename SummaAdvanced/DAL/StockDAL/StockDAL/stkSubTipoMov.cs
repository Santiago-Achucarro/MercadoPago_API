using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkSubTipoMov
    {
        public static stkSubTipoMovDS Datos(string /*0*/pSubTipoMov_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipoMov_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkSubTipoMovDatos", parametros);

            string[] camposTabla0 = { "Reporte_Id", "DescripcionReporte" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkSubTipoMovDS dsTipado = new stkSubTipoMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pSubTipoMov_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pSubTipoMov_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkSubTipoMovEliminar", parametros);
        }

        public static void Guardar(string /*0*/pSubTipoMov_Id, string /*1*/pDescripcion, bool /*2*/pConsumo, short /*3*/pCantCopias, string /*4*/pTipoMov, string /*5*/pReporte_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipoMov_Id, /*1*/pDescripcion, /*2*/pConsumo, /*3*/pCantCopias, /*4*/pTipoMov, /*5*/pReporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkSubTipoMovGuardar", parametros);
        }




    }
}
