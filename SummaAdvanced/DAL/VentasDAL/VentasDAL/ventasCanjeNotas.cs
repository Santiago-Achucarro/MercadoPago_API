using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class ventasCanjeNotas
    {
        public static ventasCanjeNotasDS Datos(string /*0*/Sucursal, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ClienteDesde, string /*4*/ClienteHasta, int /*5*/Empresa, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Sucursal, /*1*/FechaDesde, /*2*/FechaHasta, /*3*/ClienteDesde, /*4*/ClienteHasta, /*5*/Empresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("ventasCanjeNotasDatos", parametros);

            string[] camposTabla0 = { "SucursalEmpr", "FechaDesde", "FechaHasta", "ClienteDesde", "ClienteHasta", "Cliente_Id", "Sucursal", "PorNota", "Total", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "SubTotal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            ventasCanjeNotasDS dsTipado = new ventasCanjeNotasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.venMovimientosCFDIR.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static ventasCanjeNotasAgregarDS DatosNotas(string /*0*/Sucursal, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ClienteDesde, string /*4*/ClienteHasta, int /*5*/Empresa, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Sucursal, /*1*/FechaDesde, /*2*/FechaHasta, /*3*/ClienteDesde, /*4*/ClienteHasta, /*5*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("ventasCanjeNotasAgregarDatos", parametros);

            string[] camposTabla0 = { "SucursalEmpr", "FechaDesde", "FechaHasta", "ClienteDesde", "ClienteHasta", "Cliente_Id", "Sucursal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "SubTotal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            ventasCanjeNotasAgregarDS dsTipado = new ventasCanjeNotasAgregarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static ventasCanjeNotaAgregarDS DatosNota(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("ventasCanjeNotaAgregarDatos", parametros);

            string[] camposTabla0 = { "SegmentoStr", "SubTotal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            ventasCanjeNotaAgregarDS dsTipado = new ventasCanjeNotaAgregarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

   







    }
}
