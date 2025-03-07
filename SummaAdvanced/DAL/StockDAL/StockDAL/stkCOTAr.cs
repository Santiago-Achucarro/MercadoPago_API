using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
   public class stkCOTAr
    {
        public static stkCOTArDS Datos(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkCOTArDatos", parametros);

            stkCOTArDS dsTipado = new stkCOTArDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, int /*1*/lIdentity, int /*2*/pUsuario_Id, string /*3*/pCot, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/lIdentity, new Generalidades.NullableInt(/*2*/pUsuario_Id), /*3*/pCot };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkCOTArGuardar", parametros));
        }
    }
}
