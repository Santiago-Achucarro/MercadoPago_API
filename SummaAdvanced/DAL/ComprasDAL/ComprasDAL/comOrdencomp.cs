using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comOrdenComp
    {
        public static comOrdenCompDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comOrdenCompDatos", parametros);

            string[] camposTabla0 = { "Proveed_Id", "DescripcionProveedores", "TipoPermi_Id", "DescripcionTipoPermi", "Moneda_Id", "DescripcionMonedas", "NroUsuAuto", "Autorizo", "DescripcionUsuarioAutorizo", "CondPago_Id", "DescripcionConPago", "Observaciones", "TipoCuerpo", "Total", "FechaNueva" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Marca", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cuenta_Id", "DescripcionCuentas", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Marca", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            comOrdenCompDS dsTipado = new comOrdenCompDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CuerpoArti.TableName, dsTipado.CuerpoMemo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Autorizando.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pComordencomp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pComordencomp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOrdenCompEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, bool /*10*/pTieneAutomatico, DateTime /*11*/pFecha, string /*12*/pProveed_Id, string /*13*/pTipoPermi_Id, string /*14*/pMoneda_Id, int /*15*/pAutorizo, string /*16*/pCondPago_Id, bool /*17*/pImpreso, string /*18*/pObservaciones, string /*19*/pEstado_Id, decimal /*20*/pSaldo_Anticipo, decimal /*21*/pImporteImpuestos, decimal /*22*/pSaldo_NC, decimal /*23*/pCambio, int /*24*/pUsuario_Id, bool /*25*/pPosteado, string /*26*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pTieneAutomatico, /*11*/pFecha, /*12*/pProveed_Id, new Generalidades.NullableString(/*13*/pTipoPermi_Id), new Generalidades.NullableString(/*14*/pMoneda_Id), new Generalidades.NullableInt(/*15*/pAutorizo), new Generalidades.NullableString(/*16*/pCondPago_Id), /*17*/pImpreso, new Generalidades.NullableString(/*18*/pObservaciones), /*19*/pEstado_Id, /*20*/pSaldo_Anticipo, /*21*/pImporteImpuestos, /*22*/pSaldo_NC, /*23*/pCambio, /*24*/pUsuario_Id, /*25*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("comOrdenCompGuardar", parametros));
        }


        public static comOrdenCompDatosIntDS DatosInt(int /*0*/pComOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pComOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompDatosInt", parametros);

            string[] camposTabla0 = { "comOrdenComp" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOrdenCompDatosIntDS dsTipado = new comOrdenCompDatosIntDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comOrdenCompPendAutoDS PendAutoDatos(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
        {

            Object[] parametros = new Object[] {/*0*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompPendAuto", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "comOrdenComp", "SegmentoStr", "SubTotal", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comOrdenCompPendAutoDS dsTipado = new comOrdenCompPendAutoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }


        public static void CambiarEstado(int /*0*/pcomOrdenComp, string /*1*/pEstado_Id, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pEstado_Id, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOrdenCompCambiarEstado", parametros);
        }


        public static comOrdenCompTienePendEntregaDS TienePendEntrega(int /*0*/comOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/comOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompTienePendEntrega", parametros);

            string[] camposTabla0 = { "Pendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOrdenCompTienePendEntregaDS dsTipado = new comOrdenCompTienePendEntregaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static comOrdenCompTienePendFactDS TienePendFact(int /*0*/comOrdenComp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/comOrdenComp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompTienePendFact", parametros);

            string[] camposTabla0 = { "comOrdenComp", "Pendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOrdenCompTienePendFactDS dsTipado = new comOrdenCompTienePendFactDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comOrdenCompPendAutoDS PendAuto(int /*0*/Empresa_Id, int /*1*/pUsuario, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pUsuario };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompPendAuto", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "Proveed_Id", "RazonSocial", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Proveed_Id", "DescripcionProveedores", "TipoPermi_Id", "DescripcionTipoPermi", "Moneda_Id", "DescripcionMonedas", "NroUsuAuto", "Autorizo", "DescripcionUsuarioAutorizo", "CondPago_Id", "DescripcionConPago", "Observaciones", "TipoCuerpo", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cuenta_Id", "DescripcionCuentas", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            
            string[] camposTabla5 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);


            comOrdenCompPendAutoDS dsTipado = new comOrdenCompPendAutoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.CabeceraOc.TableName, dsTipado.comOCArticulo.TableName, dsTipado.comOcMemo.TableName, dsTipado.Autorizando.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comOrdenCompSePuedeModificarDS SePuedeModificar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOrdenCompSePuedeModificar", parametros);

            comOrdenCompSePuedeModificarDS dsTipado = new comOrdenCompSePuedeModificarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
