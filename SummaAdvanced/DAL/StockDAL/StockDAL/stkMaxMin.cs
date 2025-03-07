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
    public class stkMaxMin
    {
        public static stkMaxMinDS Datos(string /*0*/pDeposito_Id, int pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDeposito_Id, pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMaxMinDatos", parametros);

            stkMaxMinDS dsTipado = new stkMaxMinDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, int pEmpresa_Id,  string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pProducto_Id), /*1*/pDeposito_Id, pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMaxMinEliminar", parametros);
        }


        public static void Insertar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, decimal /*2*/pMin, decimal /*3*/pMax, int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pMin, /*3*/pMax, /*4*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMaxMinInsertar", parametros);
        }


    }
}
