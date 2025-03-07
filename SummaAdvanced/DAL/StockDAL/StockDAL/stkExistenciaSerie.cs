using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkExistenciaSerie
    {
        public static stkExistenciaSerieDS Datos(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pSerie,
            int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pSerie, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaSerieDatos", parametros);

            stkExistenciaSerieDS dsTipado = new stkExistenciaSerieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pSerie, 
            int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, new Generalidades.NullableString(/*2*/pSerie),
                new Generalidades.NullableInt(/*3*/pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkExistenciaSerieEliminar", parametros);
        }

        public static void Sumar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pSerie, decimal /*3*/pCantidad,
            int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pSerie, /*3*/pCantidad, /*4*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkExistenciaSerieSumar", parametros);
        }


    }
}
