using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;

namespace StockDAL
{
    public class stkPlantillasProductos
    {

        public static stkProductosPlantillaDS Datos(string /*0*/pPlantilla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosPlantillaDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Medida_Id", "DescripcionUniMed", "MedidaAlterna",
                "DescripcionMedidaAlterna", "Tipo_Id", "DescripcionTipos", "Familia_Id", "DescripcionFamilias", "Grupo_Id",
                "DescripcionGrupos", "UMCompra_Id", "DescripcionUMCompra", "Moneda_Id", "DescripcionMonedas", "UMVenta_Id",
                "DescripcionUMVenta", "CtaCompra", "DescripcionCtaCompra", "CtaAjuInventario", "DescripcionCtaAjuInventario",
                "CtaVenta", "DescripcionCtaVenta", "CtaCredito", "DescripcionCtaCredito", "CtaDescuento", "DescripcionCtaDescuento",
                "CtaCosto", "DescripcionCtaCosto", "CtaVentasExt", "DescripcionCtaVentasExt", "CtaCreditoExt",
                "DescripcionCtaCreditoExt", "CtaDescuentoExt", "DescripcionCtaDescuentoExt", "CtaCostoExt", "DescripcionCtaCostoExt",
                "CFVenta_Id", "DescripcionCondFisVenta", "CFComp_Id", "DescripcionCondFisCompra", "CodigoFiscal",
                "FraccionArancelaria", "Usuario_Id", "DescripcionUsuario", "CtaConsumo", "DescripcionCtaConsumo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkProductosPlantillaDS dsTipado = new stkProductosPlantillaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pPlantilla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pPlantilla_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosPlantillaEliminar", parametros);
        }

        public static int Guardar(string /*0*/pPlantilla_Id, string /*1*/pPlantilla_Id_Nuevo, int /*2*/pEmpresa_Id, 
            string /*3*/pDescripcion, string /*4*/pMedida_Id, string /*5*/pMedidaAlterna, decimal /*6*/pFactorAlterna, 
            string /*7*/pClase, string /*8*/pClaseAlterna, string /*9*/pTipo_Id, string /*10*/pFamilia_Id, string /*11*/pGrupo_Id, 
            bool /*12*/pTrabajaPorLotes, bool /*13*/pconVencimiento, bool /*14*/pSerializable, bool /*15*/pUsaDespachoImportacion, 
            string /*16*/pUMVenta_Id, string /*17*/pMonedaUltCompra, string /*18*/pUMCompra_Id, string /*19*/pCtaCompra, 
            string /*20*/pCtaAjuInventario, string /*21*/pCtaVenta, string /*22*/pCtaCredito, string /*23*/pCtaDescuento, 
            string /*24*/pCtaCosto, string /*25*/pCtaVentasExt, string /*26*/pCtaCreditoExt, string /*27*/pCtaDescuentoExt, 
            string /*28*/pCtaCostoExt, decimal /*29*/pMargenExceso, short /*30*/pTiempoEntrega, bool /*31*/pAcepta_Ventas, 
            string /*32*/pCFVenta_Id, bool /*33*/pAcepta_Compras, string /*34*/pCFCompra_Id, bool /*35*/pAcepta_Comis_Vta, 
            short /*36*/pDiasGarantia, string /*37*/pCodigoFiscal, string /*38*/pFraccionArancelaria, bool /*39*/pInactivo, 
            bool /*40*/pPosteado, int /*41*/pUsuario_Id, string /*42*/pCtaConsumo, string /*43*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id, /*1*/pPlantilla_Id_Nuevo,
                new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pMedida_Id),
                new Generalidades.NullableString(/*5*/pMedidaAlterna), /*6*/pFactorAlterna, /*7*/pClase, /*8*/pClaseAlterna,
                new Generalidades.NullableString(/*9*/pTipo_Id), new Generalidades.NullableString(/*10*/pFamilia_Id),
                new Generalidades.NullableString(/*11*/pGrupo_Id), /*12*/pTrabajaPorLotes, /*13*/pconVencimiento,
                /*14*/pSerializable, /*15*/pUsaDespachoImportacion, new Generalidades.NullableString(/*16*/pUMVenta_Id),
                new Generalidades.NullableString(/*17*/pMonedaUltCompra), new Generalidades.NullableString(/*18*/pUMCompra_Id),
                new Generalidades.NullableString(/*19*/pCtaCompra), new Generalidades.NullableString(/*20*/pCtaAjuInventario),
                new Generalidades.NullableString(/*21*/pCtaVenta), new Generalidades.NullableString(/*22*/pCtaCredito),
                new Generalidades.NullableString(/*23*/pCtaDescuento), new Generalidades.NullableString(/*24*/pCtaCosto),
                new Generalidades.NullableString(/*25*/pCtaVentasExt), new Generalidades.NullableString(/*26*/pCtaCreditoExt),
                new Generalidades.NullableString(/*27*/pCtaDescuentoExt), new Generalidades.NullableString(/*28*/pCtaCostoExt), 
                /*29*/pMargenExceso, /*30*/pTiempoEntrega, /*31*/pAcepta_Ventas,
                new Generalidades.NullableString(/*32*/pCFVenta_Id), /*33*/pAcepta_Compras,
                new Generalidades.NullableString(/*34*/pCFCompra_Id), /*35*/pAcepta_Comis_Vta, /*36*/pDiasGarantia,
                new Generalidades.NullableString(/*37*/pCodigoFiscal), new Generalidades.NullableString(/*38*/pFraccionArancelaria),
                /*39*/pInactivo, /*40*/pPosteado, new Generalidades.NullableInt(/*41*/pUsuario_Id),
                new Generalidades.NullableString(/*42*/pCtaConsumo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkProductosPlantillaGuardar", parametros));
        }
    }
}
