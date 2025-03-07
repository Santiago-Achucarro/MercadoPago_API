using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venReparto
    {

        public static venRepartoDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepartoDatos", parametros);

            string[] camposTabla0 = { "Sucursal", "Deposito_Id", "DescripcionDepositos", "DepoPedido_Id", "DescripcionDepoPedido", "IncluyeStockCero" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "UsuarioAutoriz_Id", "MedidaAlterna", "PendienteRemitir", "PendienteFacturar", "Stock", "CantidadReservada", "CantResePedi", "StockAlterna" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venRepartoDS dsTipado = new venRepartoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venRepaPedi.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static venRepartoDS DatosIdentity(int /*0*/pvenReparto, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepartoDatosIdentity", parametros);

            string[] camposTabla0 = { "Sucursal", "Deposito_Id", "DescripcionDepositos", "DepoPedido_Id", "DescripcionDepoPedido", "IncluyeStockCero" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "UsuarioAutoriz_Id", "MedidaAlterna", "PendienteRemitir", "PendienteFacturar", "Stock", "CantidadReservada", "CantResePedi", "StockAlterna" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venRepartoDS dsTipado = new venRepartoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venRepaPedi.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venRepartoDS CalcularCuerpoDatos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, DateTime /*10*/pFechaEntrega, string /*11*/pDeposito_Id, string /*12*/pDepoPedido, string /*13*/pZonaDesde, string /*14*/pZonaHasta, string /*15*/pTipoClieDesde, string /*16*/pTipoClieHasta, string /*17*/pClienteDesde, string /*18*/pClienteHasta, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pFechaEntrega, /*11*/pDeposito_Id, /*12*/pDepoPedido, /*13*/pZonaDesde, /*14*/pZonaHasta, /*15*/pTipoClieDesde, /*16*/pTipoClieHasta, /*17*/pClienteDesde, /*18*/pClienteHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepartoCalcularCuerpo", parametros);

            string[] camposTabla0 = { "Sucursal", "Deposito_Id", "DescripcionDepositos", "DepoPedido_Id", "DescripcionDepoPedido", "IncluyeStockCero" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "UsuarioAutoriz_Id", "MedidaAlterna", "PendienteRemitir", "PendienteFacturar", "Stock", "CantidadReservada", "CantResePedi", "StockAlterna", "Remitido", "Facturado", "Renglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Vencimiento","Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venRepartoDS dsTipado = new venRepartoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venRepaPedi.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venRepartoEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N,
            int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C,
            string /*10*/pSucursal, DateTime /*11*/pFechaReparto, DateTime /*12*/pFechaEntrega, string /*13*/pDeposito_Id, string /*14*/pZonaDesde,
            string /*15*/pZonaHasta, string /*16*/pTipoClieDesde, string /*17*/pTipoClieHasta, string /*18*/pClienteDesde, string /*19*/pClienteHasta,
            string /*20*/pDepoPedido_Id, bool /*21*/pAutomatico, bool /*22*/pCerrado, string /*23*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N,
                /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSucursal, /*11*/pFechaReparto,
                /*12*/pFechaEntrega, new Generalidades.NullableString(/*13*/pDeposito_Id), /*14*/pZonaDesde, /*15*/pZonaHasta, /*16*/pTipoClieDesde,
                /*17*/pTipoClieHasta, /*18*/pClienteDesde, /*19*/pClienteHasta, new Generalidades.NullableString(/*20*/pDepoPedido_Id),
                /*21*/pAutomatico, /*22*/pCerrado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venRepartoGuardar", parametros));
        }

        public static void Cerrar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N,
            int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C,
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepartoCerrar", parametros);
        }
    }
}
