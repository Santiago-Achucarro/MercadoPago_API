using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comConsEdoCtaProveedores
    {
        public static comConsEdoCtaProveedoresDS Datos(string /*0*/Proveed_Id, int /*1*/PendHist, DateTime /*2*/FechaDesde, DateTime /*3*/FechaHasta, string /*4*/Moneda_Id, int /*5*/Empresa, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Proveed_Id, /*1*/PendHist, /*2*/FechaDesde, /*3*/FechaHasta, new Generalidades.NullableString(/*4*/Moneda_Id), /*5*/Empresa };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comConsEdoCtaProveedores", parametros);

            string[] camposTabla0 = { "Proveed_Id", "PendHist", "FechaDesde", "FechaHasta", "Moneda_Id", "Empresa", "FechaAplicacion", "FechaApli", "OrigenXml" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Fecha", "Debe", "Haber", "Saldo", "SaldoAcum", "FechaVencimiento", "FechaRegistro", "EditaEmbarques", "Observaciones", "TipoCtaProv", "TipoCtaProvDescripcion", "ClaveFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla4 = { "Fecha", "Seleccionar", "Asiento_Id", "NroCuota", "AsientoApli_Id", "AsiDifCambio_Id", "Importacion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla6 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "FechaDoc" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Asiento_Id", "Fecha", "NroCuota" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "Asiento_Id", "Cuota_Nro" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla10 = { "comEmbarque", "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            string[] camposTabla11 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            string[] camposTabla12 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            comConsEdoCtaProveedoresDS dsTipado = new comConsEdoCtaProveedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Inventario.TableName, dsTipado.AsientoContable.TableName, dsTipado.Aplicaciones.TableName, dsTipado.Impuestos.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Valores.TableName, dsTipado.Comprobantes.TableName, dsTipado.CompAAplic.TableName, dsTipado.Embarques.TableName, dsTipado.Oc.TableName, dsTipado.EmbCons.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






        public static comConsEdoCtaOcEmbDS DatosOcEmb(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comConsEdoCtaOcEmbDatos", parametros);

            string[] camposTabla0 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comConsEdoCtaOcEmbDS dsTipado = new comConsEdoCtaOcEmbDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Embarques.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void EliminarXML(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comConsEdoCtaProveedoresEliminarXML", parametros);
        }

    }
}
