using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkEnTransito
    {

        public static stkEnTransitoDS Datos(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkEnTransitoDatos", parametros);

            string[] camposTabla0 = { "Segmento1NEntr", "Segmento2NEntr", "Segmento3NEntr", "Segmento4NEntr", "stkMoviCabeEntr", "Segmento1CEntr", "Segmento2CEntr", "Segmento3CEntr", "Segmento4CEntr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkEnTransitoDS dsTipado = new stkEnTransitoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkEnTransitoEliminar", parametros);
        }
        public static void Guardar(long /*0*/pstkMoviCabe, long /*1*/pstkMoviCabeEntr, string /*2*/pDeposito_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt64( /*1*/pstkMoviCabeEntr), /*2*/pDeposito_Id };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkEnTransitoGuardar", parametros);
        }

        public static stkSalidasCDDS DatosSalida(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkSalidasCDDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento", "Existencia", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad", "CantidadAlterna", "Existencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "stkMoviCabeEntr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla8 = { "GeneraRemito", "venmovimientos", "TranspInternac", "EntradaSalidaMerc", "ViaEntradaSalida", "TotalDistRec", "PesoBrutoTotal", "UnidadPeso", "PesoNetoTotal", "CargoPorTasacion", "Camion_Id", "Remolque1", "Remolque2", "FormaEntrega_Id", "DescripcionFormaEntrega", "Operador_Id", "NombreOperador", "FechaHoraSalida", "FechaHoraProgLlegada" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            stkSalidasCDDS dsTipado = new stkSalidasCDDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.EnTransito.TableName, dsTipado.Solicitud.TableName, dsTipado.CartaPorte.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
