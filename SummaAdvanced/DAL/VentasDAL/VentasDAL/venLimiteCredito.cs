using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venLimiteCredito
    {
        public static venLimiteCreditoDS Datos(string /*0*/pCliente_Ap, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Ap };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venLimiteCreditoDatos", parametros);

            string[] camposTabla0 = { "Moneda_Id", "DescripcionMoneda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venLimiteCreditoDS dsTipado = new venLimiteCreditoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Guardar(string /*0*/pCliente_Id, decimal /*1*/pLimiteCredito, string /*2*/pMoneda_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pLimiteCredito, /*2*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venLimiteCreditoGuardar", parametros);
        }





    }
}
