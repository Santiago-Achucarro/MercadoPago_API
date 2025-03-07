using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkInventarios
    {
        public static stkInventarioDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkInventarioDatos", parametros);

            string[] camposTabla0 = { "FechaAutorizo", "UsuarioAutorizo", "Centro1_Id", "Centro1Descripcion", "Centro2_Id", "Centro2Descripcion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "MedidaAlterna_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            stkInventarioDS dsTipado = new stkInventarioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Despachos.TableName, dsTipado.Series.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pstkInventario, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventario };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkInventarioEliminar", parametros);
        }

        public static int Guardar(string /*0*/pDeposito_Id, DateTime /*1*/pFechaInventario, DateTime /*2*/pFechaCarga, DateTime /*3*/pFechaAutorizo, int /*4*/pUsuarioAutorizo, string /*5*/pUsuRespo_Id, string /*6*/pCentro1_Id, string /*7*/pCentro2_Id, int /*8*/pUsuario_Id, bool /*9*/pPosteado, int /*10*/pEmpresa_Id, string /*11*/pSegmento_Id, int /*12*/pSegmento1N, int /*13*/pSegmento2N, int /*14*/pSegmento3N, int /*15*/pSegmento4N, string /*16*/pSegmento1C, string /*17*/pSegmento2C, string /*18*/pSegmento3C, string /*19*/pSegmento4C, bool /*20*/pTieneAutomatico, string /*21*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDeposito_Id, /*1*/pFechaInventario, /*2*/pFechaCarga, new Generalidades.NullableDate(/*3*/pFechaAutorizo), new Generalidades.NullableInt(/*4*/pUsuarioAutorizo), /*5*/pUsuRespo_Id, new Generalidades.NullableString(/*6*/pCentro1_Id), new Generalidades.NullableString(/*7*/pCentro2_Id), /*8*/pUsuario_Id, /*9*/pPosteado, /*10*/pEmpresa_Id, /*11*/pSegmento_Id, /*12*/pSegmento1N, /*13*/pSegmento2N, /*14*/pSegmento3N, /*15*/pSegmento4N, /*16*/pSegmento1C, /*17*/pSegmento2C, /*18*/pSegmento3C, /*19*/pSegmento4C, /*20*/pTieneAutomatico };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkInventarioGuardar", parametros));
        }



        public static stkInventarioDatosIntDS DatosInt(int /*0*/pstkInventarios, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkInventarioDatosInt", parametros);

            stkInventarioDatosIntDS dsTipado = new stkInventarioDatosIntDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static stkAgregarListaProductosDS AgregarProductos(string /*0*/pProductoDesde_Id, string /*1*/pProductoHasta_Id, string /*2*/pFamiliaDesde, string /*3*/pFamiliaHasta, string /*4*/pGrupoDesde, string /*5*/pGrupoHasta, int /*6*/pEmpresa_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProductoDesde_Id, /*1*/pProductoHasta_Id, /*2*/pFamiliaDesde, /*3*/pFamiliaHasta, /*4*/pGrupoDesde, /*5*/pGrupoHasta, /*6*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkAgregarListaProductos", parametros);

            string[] camposTabla0 = { "MedidaAlterna" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkAgregarListaProductosDS dsTipado = new stkAgregarListaProductosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Autorizar(int /*0*/pstkInventarios, int /*1*/pUsuarioAutorizo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, /*1*/pUsuarioAutorizo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkInventariosAutorizar", parametros);
        }

        public static QuePedimentoDS QuePedimento(string /*0*/Producto_Id, string /*1*/Deposito_Id, decimal /*2*/Cantidad, DateTime /*3*/Fecha, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_Id, /*1*/Deposito_Id, /*2*/Cantidad, /*3*/Fecha, /*4*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("QuePedimento", parametros);

            string[] camposTabla0 = { "Producto_Id", "Deposito_Id", "Cantidad", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Despacho_Id", "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            QuePedimentoDS dsTipado = new QuePedimentoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Despachos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
