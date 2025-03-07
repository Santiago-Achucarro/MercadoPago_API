using System;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCondPago
    {
        public static venCondPagoDS Datos(string /*0*/pCondPagoCli_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPagoCli_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCondPagoDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "TipoFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Dias" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venCondPagoDS dsTipado = new venCondPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Cuotas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pvenCondPago, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pvenCondPago };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCondPagoEliminar", parametros);
        }
        public static int Guardar(string /*0*/pCondPagoCli_id, string /*1*/pCondPagoCli_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, short /*4*/pCantCuotas, string /*5*/pTipoVencimiento, int /*6*/pDias, short /*7*/pDiasVencimiento, short /*8*/pDiasDescFinanc, decimal /*9*/pDescFinanc, bool /*10*/pImpPrimCuota, bool /*11*/pEditaCuotas, bool /*12*/pFactCredito, bool /*13*/pInactivo, int /*14*/pUsuario_Id, bool /*15*/pPosteado, string pTipoFiscal,  string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondPagoCli_id, /*1*/pCondPagoCli_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pCantCuotas, /*5*/pTipoVencimiento, /*6*/pDias, /*7*/pDiasVencimiento, /*8*/pDiasDescFinanc, /*9*/pDescFinanc, /*10*/pImpPrimCuota, /*11*/pEditaCuotas, /*12*/pFactCredito, /*13*/pInactivo, /*14*/pUsuario_Id, /*15*/pPosteado, pTipoFiscal };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venCondPagoGuardar", parametros);
        }

        public static venCondPagoDS DatosXDias(int /*0*/pDias, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDias };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCondPagoDatosXDias", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "TipoFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Dias" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venCondPagoDS dsTipado = new venCondPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Cuotas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
