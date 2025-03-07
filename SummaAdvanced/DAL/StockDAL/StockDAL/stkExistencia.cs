using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkExistencia
    {
        public static stkExistenciaDS Datos(Int32 pEmpresa_Id, string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/ pAuxiliar)
        {

            Object[] parametros = new Object[] {pEmpresa_Id, /*0*/pProducto_Id, new Generalidades.NullableString(/*1*/pDeposito_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaDatos", parametros);

            stkExistenciaDS dsTipado = new stkExistenciaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Sumar(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, 
            decimal /*3*/pCantidad, decimal /*4*/pCantidadReservada, decimal /*5*/pCantidadAlterna, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, /*2*/pDeposito_Id, /*3*/pCantidad,
                /*4*/pCantidadReservada, /*5*/pCantidadAlterna };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkExistenciaSumar", parametros);
        }
    }
}
