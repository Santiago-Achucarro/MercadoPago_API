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
    public class stkArtiUM
    {
        public static stkArtiUMDS Datos(string /*0*/pProducto_Id, string /*1*/pMedida_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pMedida_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkArtiUMDatos", parametros);

            string[] camposTabla0 = { "CodigoBarra" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkArtiUMDS dsTipado = new stkArtiUMDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(string /*0*/pProducto_Id, string /*1*/pMedida_Id, decimal /*2*/pFactor, string /*3*/pCodigoBarra, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pMedida_Id, /*2*/pFactor, /*3*/pCodigoBarra };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkArtiUMGuardar", parametros);
        }



        public static void Eliminar(string /*0*/pProducto_id, string /*1*/pMedida_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_id, new Generalidades.NullableString(/*1*/pMedida_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkArtiUMEliminar", parametros);
        }


    }
}
