using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkProductosCostoCierreSucursal
    {
        public static stkProductosCostoCierreSucursalDS Datos(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/pSucursal, string /*3*/pProducto_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha, /*2*/pSucursal, /*3*/pProducto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosCostoCierreSucursalDatos", parametros);

            stkProductosCostoCierreSucursalDS dsTipado = new stkProductosCostoCierreSucursalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/pSucursal, string /*3*/pProducto_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha, /*2*/pSucursal, /*3*/pProducto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosCostoCierreSucursalEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/pSucursal, string /*3*/pProducto_Id, decimal /*4*/pCosto, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha, /*2*/pSucursal, /*3*/pProducto_Id, /*4*/pCosto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCostoCierreSucursalGuardar", parametros);
        }


    }
}
