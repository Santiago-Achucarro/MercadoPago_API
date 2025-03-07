using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StockDAL
{
    public class stkRemitos
    {

        public static stkRemitosDS Datos(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkRemitosDatos", parametros);

            string[] camposTabla0 = { "Sucursal", "ListaPrecio_Id", "DescripcionListasPrecios", "Moneda_Id", "DescripcionMoneda", "HojaRuta_Id", "HojaRuta", "FormaEntrega_Id", "DescripcionFormaEntrega", "Camion_Id", "Remolque1", "Remolque2", "FechaHoraSalida", "FechaHoraProgLlegada", "Operador_Id", "NombreOperador", "TotalDistRec" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkRemitosDS dsTipado = new stkRemitosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkRemitosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, string /*1*/pCliente_Id, int /*2*/pSucursal, string /*3*/pSegmento_Id, string /*4*/pListaPrecio_Id, int /*5*/pHojaRuta_Id, string /*6*/pFormaEntrega_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableString(/*1*/pCliente_Id), new Generalidades.NullableInt(/*2*/pSucursal), new Generalidades.NullableString(/*3*/pSegmento_Id), new Generalidades.NullableString(/*4*/pListaPrecio_Id), new Generalidades.NullableInt(/*5*/pHojaRuta_Id), new Generalidades.NullableString(/*6*/pFormaEntrega_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkRemitosGuardar", parametros);
        }



        public static void AsignarHR(long /*0*/pstkMoviCabe, int /*1*/pstkHojaDeRuta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pstkHojaDeRuta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkRemitosAsignarHR", parametros);
        }

        public static void DesasignarHR(int /*0*/pstkHojaDeRuta, long /*1*/pstkMoviCabe, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkHojaDeRuta, new Generalidades.NullableInt64(/*1*/pstkMoviCabe) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkRemitosDesasignarHR", parametros);
        }

        public static stkSalidasRemitoConsultaDrillDownDS DatosConsultaDrillDown(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkSalidasRemitoConsultaDrillDown", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Sucursal", "ListaPrecio_Id", "DescripcionListasPrecios", "Moneda_Id", "DescripcionMoneda", "HojaRuta_Id", "HojaRuta", "FormaEntrega_Id", "DescripcionFormaEntrega" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "SoloRemito", "PendienteFacturacion", "DescripcionCausa", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Relacionado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            stkSalidasRemitoConsultaDrillDownDS dsTipado = new stkSalidasRemitoConsultaDrillDownDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdMoviCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.stkRemitos.TableName, dsTipado.stkMoviCausa.TableName, dsTipado.Relacionados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
