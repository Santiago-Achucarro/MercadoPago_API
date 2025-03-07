using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockDAL
{
    public class stkHojaDeRuta
    {
        public static stkHojaDeRutaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkHojaDeRutaDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "FormaEntrega_Id", "ForEntregaRazonSocial", "Patente_Id", "DescripcionCamiones", "PatenteAcoplado", "DescripcionAcoplado", "Reparto", "Reparto_Id", "FiltroXFecha", "FechaDesde", "FechaHasta", "Chofer" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Remito", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            stkHojaDeRutaDS dsTipado = new stkHojaDeRutaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdRemitos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkHojaDeRutaDS Pendientes(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pFormaEntrega_Id, string /*11*/pPatente_Id, string /*12*/pPatenteAcoplado, string /*13*/pClienteDesde, string /*14*/pClienteHasta, string /*15*/pZonaDesde, string /*16*/pZonaHasta, string /*17*/pRegionDesde, string /*18*/pRegionHasta, string /*19*/pTipoClieDesde, string /*20*/pTipoClieHasta, string /*21*/pFormaDesde, string /*22*/pFormaHasta, bool /*23*/pFiltroXFecha, DateTime /*24*/pFechaHoraDesde, DateTime /*25*/pFechaHoraHasta, string /*26*/pSucursalDesde, string /*27*/pSucursalHasta, string /*28*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, new Generalidades.NullableString(/*10*/pFormaEntrega_Id), /*11*/pPatente_Id, new Generalidades.NullableString(/*12*/pPatenteAcoplado), /*13*/pClienteDesde, /*14*/pClienteHasta, /*15*/pZonaDesde, /*16*/pZonaHasta, /*17*/pRegionDesde, /*18*/pRegionHasta, /*19*/pTipoClieDesde, /*20*/pTipoClieHasta, /*21*/pFormaDesde, /*22*/pFormaHasta, /*23*/pFiltroXFecha, new Generalidades.NullableDate(/*24*/pFechaHoraDesde), new Generalidades.NullableDate(/*25*/pFechaHoraHasta), /*26*/pSucursalDesde, /*27*/pSucursalHasta };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkHojaDeRutaPendientes", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "FormaEntrega_Id", "ForEntregaRazonSocial", "Patente_Id", "DescripcionCamiones", "PatenteAcoplado", "DescripcionAcoplado", "Reparto", "Reparto_Id", "FiltroXFecha", "FechaDesde", "FechaHasta", "Chofer" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Remito", "Cliente_Id", "RazonSocial", "FormaEntrega_Id", "ForEntregaRazonSocial", "TipoClie_Id", "DescripcionTiposClie", "Region_Id", "DescripcionRegion", "Zona_Id", "DescripcionZona", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            stkHojaDeRutaDS dsTipado = new stkHojaDeRutaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdRemitos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkHojaDeRutaEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pUsuario_Id, DateTime /*11*/pFechaRegistro, int /*12*/pvenReparto, string /*13*/pFormaEntrega_Id, string /*14*/pPatente_Id, string /*15*/pPatenteAcoplado, string /*16*/pChofer, string /*17*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, new Generalidades.NullableInt(/*10*/pUsuario_Id), /*11*/pFechaRegistro, new Generalidades.NullableInt(/*12*/pvenReparto), new Generalidades.NullableString(/*13*/pFormaEntrega_Id), new Generalidades.NullableString(/*14*/pPatente_Id), new Generalidades.NullableString(/*15*/pPatenteAcoplado), /*16*/pChofer };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkHojaDeRutaGuardar", parametros));
        }



        public static int GuardarCOT(int /*0*/pEmpresa_Id, int /*1*/lIdentity, int /*2*/pUsuario_Id, string /*3*/pCot, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/lIdentity, new Generalidades.NullableInt(/*2*/pUsuario_Id), /*3*/pCot };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkHojaDeRutaGuardarCOT", parametros));
        }


        public static stkHojaDeRutaDS PendientesCOT(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pUsuario, string /*11*/pFormaEntrega_Id, string /*12*/pPatente_Id, string /*13*/pPatenteAcoplado, string /*14*/pClienteDesde, string /*15*/pClienteHasta, string /*16*/pZonaDesde, string /*17*/pZonaHasta, string /*18*/pRegionDesde, string /*19*/pRegionHasta, string /*20*/pTipoClieDesde, string /*21*/pTipoClieHasta, string /*22*/pFormaDesde, string /*23*/pFormaHasta, bool /*24*/pFiltroXFecha, DateTime /*25*/pFechaHoraDesde, DateTime /*26*/pFechaHoraHasta, string /*27*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pUsuario, new Generalidades.NullableString(/*11*/pFormaEntrega_Id), /*12*/pPatente_Id, new Generalidades.NullableString(/*13*/pPatenteAcoplado), /*14*/pClienteDesde, /*15*/pClienteHasta, /*16*/pZonaDesde, /*17*/pZonaHasta, /*18*/pRegionDesde, /*19*/pRegionHasta, /*20*/pTipoClieDesde, /*21*/pTipoClieHasta, /*22*/pFormaDesde, /*23*/pFormaHasta, /*24*/pFiltroXFecha, new Generalidades.NullableDate(/*25*/pFechaHoraDesde), new Generalidades.NullableDate(/*26*/pFechaHoraHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkHojaDeRutaPendientesCOT", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "FormaEntrega_Id", "ForEntregaRazonSocial", "Patente_Id", "DescripcionCamiones", "PatenteAcoplado", "DescripcionAcoplado", "Reparto", "Reparto_Id", "FiltroXFecha", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Remito", "Cliente_Id", "RazonSocial", "FormaEntrega_Id", "ForEntregaRazonSocial", "TipoClie_Id", "DescripcionTiposClie", "Region_Id", "DescripcionRegion", "Zona_Id", "DescripcionZona", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            stkHojaDeRutaDS dsTipado = new stkHojaDeRutaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdRemitos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);


            /*string[] camposTabla0 = { "Remito", "Cliente_Id", "RazonSocial", "FormaEntrega_Id", "ForEntregaRazonSocial", "TipoClie_Id", "DescripcionTiposClie", "Region_Id", "DescripcionRegion", "Zona_Id", "DescripcionZona", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkHojaDeRutaDS dsTipado = new stkHojaDeRutaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);*/
        }

        public static stkHojaDeRutaCerrarDS CerrarDatos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkHojaDeRutaCerrarDatos", parametros);

            string[] camposTabla1 = { "Remito", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkHojaDeRutaCerrarDS dsTipado = new stkHojaDeRutaCerrarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void CambiarEstado(int /*0*/pstkHojaDeRuta, string /*1*/pEstado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkHojaDeRuta, /*1*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkHojaDeRutaCambiarEstado", parametros);
        }




    }
}
