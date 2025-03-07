using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public static class venMovDetalle
    {
        public static venMovDetalleDS Datos(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovDetalleDatos", parametros);

            string[] camposTabla0 = { "CFVenta_Id", "DescripcionCondFisVenta", "Medida_id", "DescripcionUniMed" , "Producto_Id",
                "CodigoFiscal","CuentaPredial"};
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovDetalleDS dsTipado = new venMovDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovDetalleEliminar", parametros);
        }


        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pDetalle, string /*3*/pCFVenta_Id,
            decimal /*4*/pCantidad, string /*5*/pMedida_Id, decimal /*6*/pImporteUnitario, decimal /*7*/pSubTotal, 
            decimal /*8*/pImporteUnitarioDelImpuesto, decimal /*9*/pSubTotalFormImpuesto, string /*10*/pCodigoFiscal, 
            string /*11*/pProducto_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon, /*2*/pDetalle,
                new Generalidades.NullableString(/*3*/pCFVenta_Id), /*4*/pCantidad, new Generalidades.NullableString(/*5*/pMedida_Id),
                /*6*/pImporteUnitario, /*7*/pSubTotal, /*8*/pImporteUnitarioDelImpuesto, /*9*/pSubTotalFormImpuesto,
                new Generalidades.NullableString(/*10*/pCodigoFiscal), new Generalidades.NullableString(/*11*/pProducto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovDetalleGuardar", parametros);
        }

    }
}
