using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkProductosCostoCierre
    {
        public static stkProductosCostoCierreDS Datos(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, DateTime /*2*/pFecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id, /*2*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosCostoCierreDatos", parametros);

            stkProductosCostoCierreDS dsTipado = new stkProductosCostoCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, DateTime /*2*/pFecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id, /*2*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosCostoCierreEliminar", parametros);
        }

        public static void Guardar(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, DateTime /*2*/pFecha, decimal /*3*/pCosto, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id, /*2*/pFecha, /*3*/pCosto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCostoCierreGuardar", parametros);
        }


    }
}
