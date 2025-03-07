using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genCancMov
    {
        public static genCancMovDS Datos(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, long /*2*/pAsiento_Id_Ap, short /*3*/pCuotaNro_Ap, decimal /*4*/pCambio, decimal /*5*/pCambio_ap, bool /*6*/pImportacion, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/new Generalidades.NullableInt64(pAsiento_Id), new Generalidades.NullableShort(/*1*/pCuotaNro), /*2*/new Generalidades.NullableInt64(pAsiento_Id_Ap), new Generalidades.NullableShort(/*3*/pCuotaNro_Ap), /*4*/pCambio, /*5*/pCambio_ap, /*6*/pImportacion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genCancMovDatos", parametros);

            string[] camposTabla0 = { "Asiento_Id", "CuotaNro", "Asiento_Id_Ap", "CuotaNro_Ap", "Cambio", "Cambio_Ap", "Importacion", "EsVentaContado", "EsAplicOriginal", "LlamarAlWS" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Segmento_ap", "AsientoApli_Id", "AsieDifCambio_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genCancMovDS dsTipado = new genCancMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, long /*2*/pAsiento_Id_Ap, short /*3*/pCuotaNro_Ap, 
            int /*4*/pNroAplicacion, bool /*5*/pImportacion, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pCuotaNro, /*2*/pAsiento_Id_Ap, /*3*/pCuotaNro_Ap,
                new Generalidades.NullableInt(/*4*/pNroAplicacion), /*5*/pImportacion };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genCancMovEliminar", parametros);
        }




        public static void Guardar(long /*0*/pAsiento_Id, short /*1*/pCuotaNro, long /*2*/pAsiento_Id_Ap,
            short /*3*/pCuotaNro_Ap, int /*4*/pUsuario_Id, DateTime /*5*/pFechaAplicacion, decimal /*6*/pImporte, 
            decimal /*7*/pImporte_Ap, long /*8*/pAsientoApli_Id, bool /*9*/pImportacion, long /*10*/pAsieDifCambio_Id,
            bool pEsVentaContado, bool pEsAplicOriginal, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pCuotaNro, /*2*/pAsiento_Id_Ap, 
                /*3*/pCuotaNro_Ap, /*4*/pUsuario_Id, /*5*/pFechaAplicacion, /*6*/pImporte, /*7*/pImporte_Ap, 
                /*8*/new Generalidades.NullableInt64(pAsientoApli_Id), /*9*/pImportacion, 
                /*10*/new Generalidades.NullableInt64(pAsieDifCambio_Id), pEsVentaContado, pEsAplicOriginal };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genCancMovGuardar", parametros);
        }


        public static genCancMovCuentaDS CuentasDatos(long /*0*/pconAsientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genCancMovCuentaDatos", parametros);

            genCancMovCuentaDS dsTipado = new genCancMovCuentaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genCancSaldosCuentaDS SaldosCuentas(long /*0*/pAsiento_Id, long /*1*/pAsiento_Id_ap, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pAsiento_Id_ap };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genCancSaldosCuenta", parametros);

            string[] camposTabla1 = { "Monto", "MontoOriginal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genCancSaldosCuentaDS dsTipado = new genCancSaldosCuentaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
