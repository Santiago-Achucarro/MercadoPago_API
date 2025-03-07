using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venMovimientosExpMX
    {
        public static venMovimientosExpMXDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosExpMXDatos", parametros);

            string[] camposTabla0 = { "Motivo_id", "NumCertificadoOrigen", "NumeroExportadorConfiable", "Observaciones", "TipoCambioUSD", "TotalUSD", "PropNumRegIdTrib", "PropResidenciaFiscal", "ReceptorNumRegIdTrib", "Destinatario_id", "SucursalDest" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosExpMXDS dsTipado = new venMovimientosExpMXDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosExpMXEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, string /*1*/pMotivo_id, string /*2*/pTipoOperacion, string /*3*/pClaveDePedimento, int /*4*/pCertificadoOrigen, string /*5*/pNumCertificadoOrigen, string /*6*/pNumeroExportadorConfiable, int /*7*/pSubdivision, string /*8*/pObservaciones, decimal /*9*/pTipoCambioUSD, decimal /*10*/pTotalUSD, bool /*11*/pUsaProv, string /*12*/pPropNumRegIdTrib, string /*13*/pPropResidenciaFiscal, string /*14*/pReceptorNumRegIdTrib, string /*15*/pDestinatario_id, int /*16*/pSucursalDest, string /*17*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableString(/*1*/pMotivo_id), /*2*/pTipoOperacion, /*3*/pClaveDePedimento, /*4*/pCertificadoOrigen, new Generalidades.NullableString(/*5*/pNumCertificadoOrigen), new Generalidades.NullableString(/*6*/pNumeroExportadorConfiable), /*7*/pSubdivision, new Generalidades.NullableString(/*8*/pObservaciones), /*9*/pTipoCambioUSD, /*10*/pTotalUSD, /*11*/pUsaProv, new Generalidades.NullableString(/*12*/pPropNumRegIdTrib), new Generalidades.NullableString(/*13*/pPropResidenciaFiscal), new Generalidades.NullableString(/*14*/pReceptorNumRegIdTrib), new Generalidades.NullableString(/*15*/pDestinatario_id), new Generalidades.NullableInt(/*16*/pSucursalDest) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosExpMXGuardar", parametros);
        }


    }
}
