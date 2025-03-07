using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRIConsolidacion
    {
        public static comRIConsolidacionDS Datos(DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, string /*2*/pProveed_Id, string /*3*/pTipoPermi_Id, string /*4*/pCondPago_Id, string /*5*/pMoneda_Id, string /*6*/pFamiliaDesde, string /*7*/pFamiliaHasta, int /*8*/pEmpresa_Id, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pProveed_Id, /*3*/pTipoPermi_Id, /*4*/pCondPago_Id, /*5*/pMoneda_Id, /*6*/pFamiliaDesde, /*7*/pFamiliaHasta, /*8*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comRIConsolidacion", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta", "Proveed_Id", "DescripcionProveed", "TipoPermi_Id", "CondPago_Id", "DescripcionCondPago", "Moneda_Id", "DescripcionMoneda", "Total", "FamiliaDesde", "FamiliaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "comReqInterno", "Proveed_Id", "DescripcionProveed", "Producto_Id", "DescripcionProducto", "Marca", "Deposito_Id", "DescripcionDeposito", "Medida_Id", "DescripcionMedida", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Faltante", "Comprar" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "SegmentoSTR", "comReqInterno", "Proveed_Id", "DescripcionProveed", "Detalle", "Marca", "Medida_Id", "DescripcionMedida", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Cuenta_Id", "DescripcionCuenta", "Faltante", "Comprar" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "SegmentoSTR", "comReqInterno", "Proveed_Id", "DescripcionProveed", "Producto_Id", "DescripcionProducto", "Marca", "Deposito_Id", "DescripcionDeposito", "Medida_Id", "DescripcionMedida", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "StockVirtual" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            comRIConsolidacionDS dsTipado = new comRIConsolidacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CuerpoArti.TableName, dsTipado.CuerpoMemo.TableName, dsTipado.DatosCalc.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, int /*2*/pcomReqInterno, int /*3*/pRenglon_RI, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, /*2*/pcomReqInterno, /*3*/pRenglon_RI, /*4*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCRIGuardar", parametros);
        }

        public static void CambiarPendiente(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, bool pPendiente, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI, /*2*/ pPendiente };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRICambiarPendiente", parametros);
        }

        public static comOCRIDS DatosOCRI(int /*0*/comOrdenComp, int /*1*/Renglon_OC, int /*2*/comReqInterno, int /*3*/Renglon_Ri, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/comOrdenComp), new Generalidades.NullableInt(/*1*/Renglon_OC), new Generalidades.NullableInt(/*2*/comReqInterno), new Generalidades.NullableInt(/*3*/Renglon_Ri) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOCRIDatos", parametros);

            comOCRIDS dsTipado = new comOCRIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/comOrdenComp, int /*1*/Renglon_OC, int /*2*/comReqInterno, int /*3*/Renglon_Ri, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/comOrdenComp), new Generalidades.NullableInt(/*1*/Renglon_OC), new Generalidades.NullableInt(/*2*/comReqInterno), new Generalidades.NullableInt(/*3*/Renglon_Ri) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOCRIEliminar", parametros);
        }



    }
}
