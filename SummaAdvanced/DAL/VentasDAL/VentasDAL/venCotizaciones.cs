using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCotizaciones
    {
        public static venCotizacionesDS DatosInt(int /*0*/pvenCotizacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizacionesDatosInt", parametros);

            string[] camposTabla0 = { "SubTipoMov_Id", "DescripcionSubTipoMov", "Cliente_Id", "DescripcionCliente", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMoneda", "MonedaFact", "DescripcionMonedaFact", "CondPagoCli_Id", "DescripcionCondPagoCli", "ListaPrecio_Id", "DescripcionListaPrec", "Vendedor_Id", "DescripcionVendedor", "FormaEntrega_Id", "DescripcionFormaEntrega", "Estado", "UsuAutoriz", "DescripcionUsuAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "CliOrdenCompra", "venNroPedido", "ObsAnticipo", "TipoPrecioForm", "Incoterm_Id", "DescripcionIncoterm", "Usuario_Id", "DescripcionUsuario", "MetodoPago", "UsoCfdi"};
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Provincia_Id", "DescripcionProvincia", "Pais_Id", "DescripcionPaises" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Producto_Id", "DescripcionProducto", "Medida_Id", "DescripcionMedida", "Deposito_Id", "DescripcionDeposito", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venCotizacionesDS dsTipado = new venCotizacionesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cliente.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venCotizacionesDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venCotizacionesDatos", parametros);

            string[] camposTabla0 = { "SubTipoMov_Id", "DescripcionSubTipoMov", "Cliente_Id", "DescripcionCliente", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMoneda", "MonedaFact", "DescripcionMonedaFact", "CondPagoCli_Id", "DescripcionCondPagoCli", "ListaPrecio_Id", "DescripcionListaPrec", "Vendedor_Id", "DescripcionVendedor", "FormaEntrega_Id", "DescripcionFormaEntrega", "Estado", "UsuAutoriz", "DescripcionUsuAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "CliOrdenCompra", "venNroPedido", "ObsAnticipo", "TipoPrecioForm", "Incoterm_Id", "DescripcionIncoterm", "Usuario_Id", "DescripcionUsuario", "MetodoPago", "UsoCfdi", "AceptaDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Provincia_Id", "DescripcionProvincia", "Pais_Id", "DescripcionPaises" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Producto_Id", "DescripcionProducto", "Medida_Id", "DescripcionMedida", "Deposito_Id", "DescripcionDeposito", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "SubTotal", "SubTotalNeto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venCotizacionesDS dsTipado = new venCotizacionesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cliente.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCotizacionesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/pSubTipoMov_Id, DateTime /*11*/pFecha, string /*12*/pCliente_Id, int /*13*/pSucursal, string /*14*/pMoneda_Id, string /*15*/pMonedaFacturacion, string /*16*/pCondPagoCli_Id, string /*17*/pListaPrecio_Id, string /*18*/pVendedor_Id, string /*19*/pFormaEntrega_Id, string /*20*/pEstado, string /*21*/pUsuarioAutoriz_Id, DateTime /*22*/pFechaAutorizo, string /*23*/pObservaciones, string /*24*/pObservEstado, short /*25*/pMotivo_Id, decimal /*26*/pImporteTotal, decimal /*27*/pBonificacion1, decimal /*28*/pBonificacion2, decimal /*29*/pBonificacion3, decimal /*30*/pBonificacion4, decimal /*31*/pBonificacion5, decimal /*32*/pDato1, decimal /*33*/pDato2, decimal /*34*/pDato3, DateTime /*35*/pFechaUltMod, string /*36*/pCliOrdenCompra, string /*37*/pvenNroPedido, bool /*38*/pFacturaAnticipo, bool /*39*/pTrabaDespacho, decimal /*40*/pPorAnticipo, decimal /*41*/pAnticipo, decimal /*42*/pAnticipoPendiente, string /*43*/pObsAnticipo, string /*44*/pTipoPrecioForm, bool /*45*/pCongelaCambio, DateTime /*46*/pFecha_Registro, decimal /*47*/pCambio, string /*48*/pIncoterm_Id, bool /*49*/pSoloEntrega, int /*50*/pUsuario_Id, bool /*51*/pPosteado, string /*52*/pMetodoPago, string /*53*/pUsoCfdi, bool /*54*/pClienteExistente, DateTime /*55*/pVigencia, string /*56*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, new Generalidades.NullableInt(/*9*/pEmpresa_Id), new Generalidades.NullableString(/*10*/pSubTipoMov_Id), new Generalidades.NullableDate(/*11*/pFecha), new Generalidades.NullableString(/*12*/pCliente_Id), new Generalidades.NullableInt(/*13*/pSucursal), new Generalidades.NullableString(/*14*/pMoneda_Id), new Generalidades.NullableString(/*15*/pMonedaFacturacion), new Generalidades.NullableString(/*16*/pCondPagoCli_Id), new Generalidades.NullableString(/*17*/pListaPrecio_Id), new Generalidades.NullableString(/*18*/pVendedor_Id), new Generalidades.NullableString(/*19*/pFormaEntrega_Id), new Generalidades.NullableString(/*20*/pEstado), new Generalidades.NullableString(/*21*/pUsuarioAutoriz_Id), new Generalidades.NullableDate(/*22*/pFechaAutorizo), new Generalidades.NullableString(/*23*/pObservaciones), new Generalidades.NullableString(/*24*/pObservEstado), new Generalidades.NullableShort(/*25*/pMotivo_Id), /*26*/pImporteTotal, /*27*/pBonificacion1, /*28*/pBonificacion2, /*29*/pBonificacion3, /*30*/pBonificacion4, /*31*/pBonificacion5, /*32*/pDato1, /*33*/pDato2, /*34*/pDato3, new Generalidades.NullableDate(/*35*/pFechaUltMod), new Generalidades.NullableString(/*36*/pCliOrdenCompra), new Generalidades.NullableString(/*37*/pvenNroPedido), /*38*/pFacturaAnticipo, /*39*/pTrabaDespacho, /*40*/pPorAnticipo, /*41*/pAnticipo, /*42*/pAnticipoPendiente, new Generalidades.NullableString(/*43*/pObsAnticipo), new Generalidades.NullableString(/*44*/pTipoPrecioForm), /*45*/pCongelaCambio, new Generalidades.NullableDate(/*46*/pFecha_Registro), /*47*/pCambio, new Generalidades.NullableString(/*48*/pIncoterm_Id), /*49*/pSoloEntrega, new Generalidades.NullableInt(/*50*/pUsuario_Id), /*51*/pPosteado, new Generalidades.NullableString(/*52*/pMetodoPago), new Generalidades.NullableString(/*53*/pUsoCfdi), /*54*/pClienteExistente, /*55*/pVigencia };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venCotizacionesGuardar", parametros));
        }





        public static void CambiarEstado(int /*0*/pvenCotizaciones, string /*1*/pEstado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones, /*1*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizacionesCambiarEstado", parametros);
        }

        public static void Autorizar(int /*0*/pvenCotizaciones, int /*1*/pUsuario_Id, string /*2*/pObservEstado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones, /*1*/pUsuario_Id, /*2*/pObservEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizacionesAutorizar", parametros);
        }

        public static void AplicarAnticipo(int /*0*/pvenCotizaciones, decimal /*1*/pMonto, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones, /*1*/pMonto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizAplicarAnticipo", parametros);
        }

        public static void AplicarAnticipo(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizEstadoDatos", parametros);
        }

        public static venCotizEstadoDS EstadoDatos(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizEstadoDatos", parametros);

            string[] camposTabla0 = { "Estado", "UsuarioAutoriz_Id", "Pendiente", "CantidadPedida", "CantidadRemitida", "CantidadFacturada" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venCotizEstadoDS dsTipado = new venCotizEstadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Rechazar(int /*0*/pvenCotizaciones, int /*1*/pUsuario_Id, string /*2*/pObservEstado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones, /*1*/pUsuario_Id, /*2*/pObservEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizRechazar", parametros);
        }

        public static void GuardarSegmento(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pvenCotizaciones, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pEmpresa_Id), new Generalidades.NullableString(/*1*/pSegmento_Id), new Generalidades.NullableInt(/*2*/pSegmento1N), new Generalidades.NullableInt(/*3*/pSegmento2N), new Generalidades.NullableInt(/*4*/pSegmento3N), new Generalidades.NullableInt(/*5*/pSegmento4N), new Generalidades.NullableString(/*6*/pSegmento1C), new Generalidades.NullableString(/*7*/pSegmento2C), new Generalidades.NullableString(/*8*/pSegmento3C), new Generalidades.NullableString(/*9*/pSegmento4C), new Generalidades.NullableInt(/*10*/pvenCotizaciones) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizSegmentoGuardar", parametros);
        }


    }
}
