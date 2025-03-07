using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conPolizaElectroMx
    {
        public static conPolizasElectroMxDS Datos(int /*0*/Empresa_Id, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/TipoSolicitud, string /*4*/NumOrden, string /*5*/NumTramite, string /*6*/Sello, string /*7*/noCertificado, string /*8*/Certificado, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/FechaDesde, /*2*/FechaHasta, /*3*/TipoSolicitud, /*4*/NumOrden, /*5*/NumTramite, /*6*/Sello, new Generalidades.NullableString(/*7*/noCertificado), new Generalidades.NullableString(/*8*/Certificado) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conPolizasElectroMxDatos", parametros);

            string[] camposTabla0 = { "Anio", "Mes", "TipoSolicitud", "NumOrden", "NumTramite", "Sello", "noCertificado", "Certificado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "NumUnidenPol", "Concepto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Concepto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "UUID_CFDI", "MontoTotal", "Moneda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "NumFactExt", "Moneda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Num", "BanEmisNal", "Rfc" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "BanEmisNal", "CtaDest", "BancoDestNal", "BancoDestExt", "Rfc" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "MetPagoPol" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            conPolizasElectroMxDS dsTipado = new conPolizasElectroMxDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Poliza.TableName, dsTipado.Transaccion.TableName, dsTipado.CompNal.TableName, dsTipado.ComNalOtr.TableName, dsTipado.ComExt.TableName, dsTipado.Cheque.TableName, dsTipado.Transferencia.TableName, dsTipado.MetodoPago.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
