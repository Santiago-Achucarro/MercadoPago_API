using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venSubTipomov
    {
        public static venSubTipoMovDS Datos(string /*0*/pSubTipoMov_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipoMov_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venSubTipoMovDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Signo", "TipoMovResumido", "venTipoMov", "DescripcionTipoMov", "SegmentoRemito_Id", "DescripcionSegmentos", "UsuarioAutorizado", "DescripcionUsuarioAutorizado", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "CtaDefecto", "DescripcionCtaDefecto", "CtaOtrosCargos", "DescripcionCtaOtrosCargos", "CodigoFormulario", "CodigoFiscal", "Reporte_Id", "DescripcionReporte", "EsquemaAuto_Id", "DescripcionEsquemaAuto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "DescripcionTiposCompAfip" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venSubTipoMovDS dsTipado = new venSubTipoMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.venSTMAfip.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static int Guardar(string /*0*/pSubTipoMov_Id, string /*1*/pSubTipoMov_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pvenTipoMov, string /*4*/pDescripcion, bool /*5*/pMueveStock, bool /*6*/pEsVentaContado, bool /*7*/pAdmiteDevolucion, bool /*8*/pModificaPrecio, bool /*9*/pReservado, bool /*10*/pGeneraRemito, string /*11*/pSegmentoRemito_Id, bool /*12*/pNCxDevolucion, string /*13*/pUsuarioAutorizado, bool /*14*/pAdmiteBoniRenglon, string /*15*/pCentro1_Id, string /*16*/pCentro2_Id, bool /*17*/pPideCambio, bool /*18*/pModFecha, bool /*19*/pModCondPago, bool /*20*/pModVendedor, bool /*21*/pModCobrador, bool /*22*/pPideObervaciones, short /*23*/pCantidadCopias, bool /*24*/pModDeposito, bool /*25*/pModListaPrecios, bool /*26*/pPideFechaEntrega, bool /*27*/pPideObsReng, string /*28*/pCtaDefecto, bool /*29*/pModCtaDefecto, bool /*30*/pModCentro1, bool /*31*/pModCentro2, bool /*32*/pPideOtrosCargos, string /*33*/pCtaOtrosCargos, bool /*34*/pPermModCtaOtCar, bool /*35*/pFechaEntregaporRen, bool /*36*/pAdmiteFactsinEntr, bool /*37*/pModiUniMed, bool /*38*/pAfectaComVenta, bool /*39*/pAfectaComCobra, short /*40*/pMaxCantItems, bool /*41*/pEsPorDifPrecio, bool /*42*/pAfectaEstadistica, string /*43*/pClaveAcceso, bool /*44*/pEsPorDifCambio, string /*45*/pTipoPrecioForm, bool /*46*/pSoloImpuestos, string /*47*/pCodigoFormulario, bool /*48*/pBajoCosto, bool /*49*/pAdministrativa, bool /*50*/pPideReferencia, bool /*51*/pPideOrdenCompra, bool /*52*/pPideCongelarCambio, bool /*53*/pPideMarcaReserva, bool /*54*/pPermiteSoloEntrega, bool /*55*/pInactivo, int /*56*/pUsuario_Id, bool /*57*/pPosteado, bool /*58*/pPidePredial, bool /*59*/pPideCodProd, bool /*60*/pPideComExpoMX, string /*61*/pCodigoFiscal, string /*62*/pReporte_Id, string /*63*/pEsquemaAuto_Id, bool /*64*/pPorCotizacion, bool /*65*/pUsaCartaPorte, string /*66*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipoMov_Id, /*1*/pSubTipoMov_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), new Generalidades.NullableString(/*3*/pvenTipoMov), /*4*/pDescripcion, /*5*/pMueveStock, /*6*/pEsVentaContado, /*7*/pAdmiteDevolucion, /*8*/pModificaPrecio, /*9*/pReservado, /*10*/pGeneraRemito, new Generalidades.NullableString(/*11*/pSegmentoRemito_Id), /*12*/pNCxDevolucion, new Generalidades.NullableString(/*13*/pUsuarioAutorizado), /*14*/pAdmiteBoniRenglon, new Generalidades.NullableString(/*15*/pCentro1_Id), new Generalidades.NullableString(/*16*/pCentro2_Id), /*17*/pPideCambio, /*18*/pModFecha, /*19*/pModCondPago, /*20*/pModVendedor, /*21*/pModCobrador, /*22*/pPideObervaciones, /*23*/pCantidadCopias, /*24*/pModDeposito, /*25*/pModListaPrecios, /*26*/pPideFechaEntrega, /*27*/pPideObsReng, new Generalidades.NullableString(/*28*/pCtaDefecto), /*29*/pModCtaDefecto, /*30*/pModCentro1, /*31*/pModCentro2, /*32*/pPideOtrosCargos, new Generalidades.NullableString(/*33*/pCtaOtrosCargos), /*34*/pPermModCtaOtCar, /*35*/pFechaEntregaporRen, /*36*/pAdmiteFactsinEntr, /*37*/pModiUniMed, /*38*/pAfectaComVenta, /*39*/pAfectaComCobra, /*40*/pMaxCantItems, /*41*/pEsPorDifPrecio, /*42*/pAfectaEstadistica, /*43*/pClaveAcceso, /*44*/pEsPorDifCambio, /*45*/pTipoPrecioForm, /*46*/pSoloImpuestos, new Generalidades.NullableString(/*47*/pCodigoFormulario), /*48*/pBajoCosto, /*49*/pAdministrativa, /*50*/pPideReferencia, /*51*/pPideOrdenCompra, /*52*/pPideCongelarCambio, /*53*/pPideMarcaReserva, /*54*/pPermiteSoloEntrega, /*55*/pInactivo, /*56*/pUsuario_Id, /*57*/pPosteado, /*58*/pPidePredial, /*59*/pPideCodProd, /*60*/pPideComExpoMX, new Generalidades.NullableString(/*61*/pCodigoFiscal), new Generalidades.NullableString(/*62*/pReporte_Id), new Generalidades.NullableString(/*63*/pEsquemaAuto_Id), /*64*/pPorCotizacion, /*65*/pUsaCartaPorte };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venSubTipoMovGuardar", parametros));
        }



        public static void Eliminar(string /*0*/pSubTipoMov_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pSubTipoMov_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venSubTipoMovEliminar", parametros);
        }


    }
}
