using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comReqInterno
    {
        public static comReqInternoDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comReqInternoDatos", parametros);

            string[] camposTabla0 = { "TipoPermiRI_Id", "DescripcionTipoPermiRI", "Observaciones", "Proveed_Id", "DescripcionProveedores", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "SubCategoria_Id", "DescripcionSubCategorias", "Detalle", "Categoria_Id", "DescripcionCategoria" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            comReqInternoDS dsTipado = new comReqInternoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CuerpoArti.TableName, dsTipado.CuerpoMemo.TableName, dsTipado.Autorizando.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static int Guardar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, DateTime /*10*/pFecha, string /*11*/pTipoPermi_Id, string /*12*/pObservaciones, string /*13*/pProveed_Id, string /*14*/pEstadoRI_Id, int /*15*/pUsuario_Id, string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/pFecha, new Generalidades.NullableString(/*11*/pTipoPermi_Id), new Generalidades.NullableString(/*12*/pObservaciones), new Generalidades.NullableString(/*13*/pProveed_Id), /*14*/pEstadoRI_Id, new Generalidades.NullableInt(/*15*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("comReqInternoGuardar", parametros));
        }

        public static comReqInternoDS DatosInt(int /*0*/pReqInterno, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReqInterno };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comReqInternoDatosInt", parametros);

            string[] camposTabla0 = { "TipoPermiRI_Id", "DescripcionTipoPermiRI", "Observaciones", "Proveed_Id", "DescripcionProveedores", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "SubCategoria_Id", "DescripcionSubCategorias", "Detalle", "Categoria_Id", "DescripcionCategoria" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            comReqInternoDS dsTipado = new comReqInternoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CuerpoArti.TableName, dsTipado.CuerpoMemo.TableName, dsTipado.Autorizando.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void CambiarEstado(int /*0*/pReqInterno, string /*1*/pEstado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReqInterno, /*1*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRICambiarEstado", parametros);
        }

        public static comReqInternoCompTienePendEntregaDS TienePendienteEntretga(int /*0*/comReqInerno, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/comReqInerno };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comReqInternoCompTienePendEntrega", parametros);

            string[] camposTabla0 = { "comReqInterno", "Pendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comReqInternoCompTienePendEntregaDS dsTipado = new comReqInternoCompTienePendEntregaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
