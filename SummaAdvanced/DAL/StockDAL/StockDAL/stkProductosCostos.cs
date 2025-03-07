using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkProductosCostos
    {
        public static stkProductosCostosDS Datos(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosCostosDatos", parametros);

            stkProductosCostosDS dsTipado = new stkProductosCostosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosCostosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, decimal /*2*/pCostoPromPond, decimal /*3*/pCostoUltCompra, decimal /*4*/pCostoStandard, int /*5*/pUsuario_Id, string /*6*/pMonedaUltCompra, decimal /*7*/pPrecioUltCompra, DateTime /*8*/pFecha_Ult_Compra, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id, /*2*/pCostoPromPond, /*3*/pCostoUltCompra, /*4*/pCostoStandard, /*5*/pUsuario_Id, /*6*/pMonedaUltCompra, /*7*/pPrecioUltCompra, /*8*/pFecha_Ult_Compra };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCostosGuardar", parametros);
        }

    }
}
