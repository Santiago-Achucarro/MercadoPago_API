using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;


namespace VentasDAL
{
    public class venListasPrecProd
    {

        public static venListasPrecProdDS Datos(string /*0*/pListaPrecio_Id, string /*1*/pProducto_Id, int /*2*/pVersion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pProducto_Id, /*2*/pVersion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venListasPrecProdDatos", parametros);

            venListasPrecProdDS dsTipado = new venListasPrecProdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pListaPrecio_Id, string /*1*/pProducto_Id, int /*2*/pVersion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, new Generalidades.NullableString(/*1*/pProducto_Id), /*2*/pVersion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venListasPrecProdEliminar", parametros);
        }


        public static void Guardar(int /*0*/pListaPrecio_Id, int /*1*/pVersion, string /*2*/pProducto_Id, decimal /*3*/pPrecioLista, decimal /*4*/pPrecioPromocion, bool /*5*/pAdmiteRegalo, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pVersion, /*2*/pProducto_Id, /*3*/pPrecioLista, /*4*/pPrecioPromocion, /*5*/pAdmiteRegalo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venListasPrecProdGuardar", parametros);
        }



        public static venListasPrecProdDS DatosFecha(string /*0*/pListaPrecio_Id, string /*1*/pProducto_Id, DateTime /*2*/pFecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pProducto_Id, /*2*/pFecha };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venListasPrecProdFechaDatos", parametros);

            venListasPrecProdDS dsTipado = new venListasPrecProdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
