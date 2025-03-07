using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comCFDISat
    {
        public static comCFDISatDS Datos(string /*0*/pUUID, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUUID };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comCFDISatDatos", parametros);

            string[] camposTabla0 = { "XML", "Usuario", "FechaCarga" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comCFDISatDS dsTipado = new comCFDISatDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pagos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pUUID, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pUUID) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comCFDISatEliminar", parametros);
        }

        public static void Guardar(string /*0*/pUUID, int /*1*/pEmpresa_Id, string /*2*/pRFCEmisor, DateTime /*3*/pFecha, decimal /*4*/pMonto, string /*5*/pFolio, string /*6*/pSerie, bool /*7*/pSubido, string /*8*/pXML, int /*9*/pUsuario, DateTime /*10*/pFechaCarga, string /*11*/pTipoComprobante, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUUID, /*1*/pEmpresa_Id, /*2*/pRFCEmisor, /*3*/pFecha, /*4*/pMonto, /*5*/pFolio, /*6*/pSerie, /*7*/pSubido, new Generalidades.NullableString(/*8*/pXML), new Generalidades.NullableInt(/*9*/pUsuario), new Generalidades.NullableDate(/*10*/pFechaCarga), /*11*/pTipoComprobante };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comCFDISatGuardar", parametros);
        }

        public static comCFDISatDatosRangoDS DatosRango(DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, string /*2*/pRFCEmisorDesde, string /*3*/pRFCEmisorHasta, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pRFCEmisorDesde, /*3*/pRFCEmisorHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comCFDISatDatosRango", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta", "RFCDesde", "RFCHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Folio", "Usuario", "FechaCarga", "TipoDeComprobante", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comCFDISatDatosRangoDS dsTipado = new comCFDISatDatosRangoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
