using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockDAL
{
    public class stkExistenciaDespaXFifo
    {
        public static stkExistenciaDespaXFifoDS Datos(int pEmpresa_Id, string /*0*/pProducto_Id, string /*1*/pDeposito_Id, 
            decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, /*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaDespaXFifo", parametros);

            string[] camposTabla0 = { "Producto_Id", "Deposito_Id", "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkExistenciaDespaXFifoDS dsTipado = new stkExistenciaDespaXFifoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Despachos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
