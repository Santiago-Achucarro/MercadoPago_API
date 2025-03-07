using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkProductosCostosSucursal
    {
        public static stkProductosCostosSucursalDS Datos(string /*0*/pSucursal, string /*1*/pProducto_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal, /*1*/pProducto_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosCostosSucursalDatos", parametros);

            string[] camposTabla0 = { "Moneda_Id", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkProductosCostosSucursalDS dsTipado = new stkProductosCostosSucursalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pSucursal, string /*1*/pProducto_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal, /*1*/pProducto_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosCostosSucursalEliminar", parametros);
        }

        public static void Guardar(string /*0*/pSucursal, string /*1*/pProducto_Id, int /*2*/pEmpresa_Id, string /*3*/pMonedaUltCompra, decimal /*4*/pCostoPromPond, decimal /*5*/pCostoUltCompra, decimal /*6*/pCostoStandard, decimal /*7*/pPrecioUltCompra, DateTime /*8*/pFecha_Ult_Compra, int /*9*/pUsuario_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal, /*1*/pProducto_Id, /*2*/pEmpresa_Id, new Generalidades.NullableString(/*3*/pMonedaUltCompra), /*4*/pCostoPromPond, /*5*/pCostoUltCompra, /*6*/pCostoStandard, /*7*/pPrecioUltCompra, /*8*/pFecha_Ult_Compra, new Generalidades.NullableInt(/*9*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCostosSucursalGuardar", parametros);
        }





    }
}
