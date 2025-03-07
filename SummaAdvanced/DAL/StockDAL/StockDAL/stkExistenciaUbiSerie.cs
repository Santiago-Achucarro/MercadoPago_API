using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkExistenciaUbiSerie
    {
        public static stkExistenciaUbiSerieDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, string /*3*/pSerie, string /*4*/pUbicacion_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, new Generalidades.NullableString(/*2*/pDeposito_Id), new Generalidades.NullableString(/*3*/pSerie), new Generalidades.NullableString(/*4*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaUbiSerieDatos", parametros);

            string[] camposTabla0 = { "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkExistenciaUbiSerieDS dsTipado = new stkExistenciaUbiSerieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Sumar(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, string /*3*/pSerie, string /*4*/pUbicacion_Id, decimal /*5*/pCantidad, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, /*2*/pDeposito_Id, /*3*/pSerie, /*4*/pUbicacion_Id, /*5*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkExistenciaUbiSerieSumar", parametros);
        }



    }
}
