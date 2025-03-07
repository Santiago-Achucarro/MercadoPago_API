﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;
namespace StockDAL
{
    public class stkProductos
    {
        public static stkProductosDS Datos(string /*0*/pProducto_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkProductosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "DescripcionDetallada", "Description", "MedidaAlterna", "DescripcionMedidaAlterna", "Tipo_Id", "DescripcionTipos", "Familia_Id", "DescripcionFamilia", "Grupo_Id", "DescripcionGrupo", "UmVenta", "DescripcionUmVenta", "MonedaUltCompra", "DescripcionMonedas", "UMCompra", "DescripcionUMCompra", "CtaCompra", "DescripcionCtaCompra", "CtaAjuInventario", "DescripcionCtaAjuInventario", "CtaVenta", "DescripcionCtaVenta", "CtaCredito", "DescripcionCtaCredito", "CtaDescuento", "DescripcionCtaDescuento", "CtaCosto", "DescripcionCtaCosto", "CtaVentaExt", "DescripcionCtaVentaExt", "CtaCreditoExt", "DescripcionCtaCreditoExt", "CtaDescuentoExt", "DescripcionCtaDescuentoExt", "CtaCostoExt", "DescripcionCtaCostoExt", "CFVenta_Id", "DescripcionCondFisVenta", "CFComp_Id", "DescripcionCondFisCompra", "Imagen", "CodigoFiscal", "FraccionArancelaria", "TieneMovimientos", "CtaConsumo", "DescripcionCtaConsumo", "Observaciones", "UrlProd", "ClaveSTCC", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "PesoEnKg" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "CodigoBarra" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Principal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            stkProductosDS dsTipado = new stkProductosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Medidas.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Recetas.TableName, dsTipado.Combos.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pProducto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkProductosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pProducto_Id, string /*1*/pProducto_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pDescripcionDetallada, string /*5*/pDescription, string /*6*/pMedida_Id, string /*7*/pMedidaAlterna, decimal /*8*/pFactorAlterna, string /*9*/pClase, string /*10*/pClaseAlterna, string /*11*/pCodigoBarra, string /*12*/pTipo_Id, string /*13*/pFamilia_Id, string /*14*/pGrupo_Id, bool /*15*/pTrabajaPorLotes, bool /*16*/pconVencimiento, bool /*17*/pSerializable, bool /*18*/pUsaDespachoImportacion, string /*19*/pUmVenta, decimal /*20*/pCostoPromPond, decimal /*21*/pCostoUltCompra, decimal /*22*/pCostoReposicion, decimal /*23*/pCostoStandard, decimal /*24*/pCostoUltimoCierre, string /*25*/pMonedaUltCompra, decimal /*26*/pPrecioUltCompra, string /*27*/pUMCompra, string /*28*/pCtaCompra, string /*29*/pCtaAjuInventario, string /*30*/pCtaVenta, string /*31*/pCtaCredito, string /*32*/pCtaDescuento, string /*33*/pCtaCosto, string /*34*/pCtaVentaExt, string /*35*/pCtaCreditoExt, string /*36*/pCtaDescuentoExt, string /*37*/pCtaCostoExt, DateTime /*38*/pFcha_Ult_Compra, decimal /*39*/pMargenExceso, short /*40*/pTiempoEntrega, bool /*41*/pAcepta_Ventas, string /*42*/pCFVenta_Id, bool /*43*/pAcepta_Compras, string /*44*/pCFComp_Id, bool /*45*/pAcepta_Comis_Vta, short /*46*/pDiasGarantia, string /*47*/pImagen, DateTime /*48*/pFechaUltModif, string /*49*/pImagenExtension, string /*50*/pCodigoFiscal, string /*51*/pFraccionArancelaria, bool /*52*/pInactivo, int /*53*/pUsuario_Id, bool /*54*/pPosteado, string /*55*/pCtaConsumo, string /*56*/pObservaciones, string /*57*/pUlrProd, string /*58*/pClaveSTCC, bool /*59*/pMaterialPeligroso, string /*60*/pCveMaterialPeligroso, string /*61*/pEmbalaje, decimal /*62*/pPesoEnKg, string /*63*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pProducto_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pDescripcionDetallada), new Generalidades.NullableString(/*5*/pDescription), /*6*/pMedida_Id, new Generalidades.NullableString(/*7*/pMedidaAlterna), /*8*/pFactorAlterna, /*9*/pClase, /*10*/pClaseAlterna, /*11*/pCodigoBarra, new Generalidades.NullableString(/*12*/pTipo_Id), new Generalidades.NullableString(/*13*/pFamilia_Id), new Generalidades.NullableString(/*14*/pGrupo_Id), /*15*/pTrabajaPorLotes, /*16*/pconVencimiento, /*17*/pSerializable, /*18*/pUsaDespachoImportacion, new Generalidades.NullableString(/*19*/pUmVenta), /*20*/pCostoPromPond, /*21*/pCostoUltCompra, /*22*/pCostoReposicion, /*23*/pCostoStandard, /*24*/pCostoUltimoCierre, new Generalidades.NullableString(/*25*/pMonedaUltCompra), /*26*/pPrecioUltCompra, new Generalidades.NullableString(/*27*/pUMCompra), new Generalidades.NullableString(/*28*/pCtaCompra), new Generalidades.NullableString(/*29*/pCtaAjuInventario), new Generalidades.NullableString(/*30*/pCtaVenta), new Generalidades.NullableString(/*31*/pCtaCredito), new Generalidades.NullableString(/*32*/pCtaDescuento), new Generalidades.NullableString(/*33*/pCtaCosto), new Generalidades.NullableString(/*34*/pCtaVentaExt), new Generalidades.NullableString(/*35*/pCtaCreditoExt), new Generalidades.NullableString(/*36*/pCtaDescuentoExt), new Generalidades.NullableString(/*37*/pCtaCostoExt), /*38*/pFcha_Ult_Compra, /*39*/pMargenExceso, /*40*/pTiempoEntrega, /*41*/pAcepta_Ventas, new Generalidades.NullableString(/*42*/pCFVenta_Id), /*43*/pAcepta_Compras, new Generalidades.NullableString(/*44*/pCFComp_Id), /*45*/pAcepta_Comis_Vta, /*46*/pDiasGarantia, new Generalidades.NullableString(/*47*/pImagen), /*48*/pFechaUltModif, /*49*/pImagenExtension, new Generalidades.NullableString(/*50*/pCodigoFiscal), new Generalidades.NullableString(/*51*/pFraccionArancelaria), /*52*/pInactivo, /*53*/pUsuario_Id, /*54*/pPosteado, new Generalidades.NullableString(/*55*/pCtaConsumo), /*56*/pObservaciones, new Generalidades.NullableString(/*57*/pUlrProd), new Generalidades.NullableString(/*58*/pClaveSTCC), /*59*/pMaterialPeligroso, new Generalidades.NullableString(/*60*/pCveMaterialPeligroso), new Generalidades.NullableString(/*61*/pEmbalaje), /*62*/pPesoEnKg };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkProductosGuardar", parametros));
        }



        public static int GuardarConMovimientos(string /*0*/pProducto_Id, string /*1*/pProducto_Id_Nueva, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pDescripcionDetallada, string /*5*/pDescription, string /*6*/pMedidaAlterna, decimal /*7*/pFactorAlterna, string /*8*/pClaseAlterna, string /*9*/pCodigoBarra, string /*10*/pTipo_Id, string /*11*/pFamilia_Id, string /*12*/pGrupo_Id, string /*13*/pUmVenta, decimal /*14*/pCostoReposicion, string /*15*/pMonedaUltCompra, string /*16*/pUMCompra, string /*17*/pCtaCompra, string /*18*/pCtaAjuInventario, string /*19*/pCtaVenta, string /*20*/pCtaCredito, string /*21*/pCtaDescuento, string /*22*/pCtaCosto, string /*23*/pCtaVentaExt, string /*24*/pCtaCreditoExt, string /*25*/pCtaDescuentoExt, string /*26*/pCtaCostoExt, decimal /*27*/pMargenExceso, short /*28*/pTiempoEntrega, bool /*29*/pAcepta_Ventas, string /*30*/pCFVenta_Id, bool /*31*/pAcepta_Compras, string /*32*/pCFComp_Id, bool /*33*/pAcepta_Comis_Vta, short /*34*/pDiasGarantia, string /*35*/pImagen, DateTime /*36*/pFechaUltModif, string /*37*/pImagenExtension, string /*38*/pCodigoFiscal, string /*39*/pFraccionArancelaria, bool /*40*/pInactivo, int /*41*/pUsuario_Id, bool /*42*/pPosteado, string /*43*/pCtaConsumo, string /*44*/pObservaciones, string /*45*/pUlrProd, string /*46*/pClaveSTCC, bool /*47*/pMaterialPeligroso, string /*48*/pCveMaterialPeligroso, string /*49*/pEmbalaje, decimal /*50*/pPesoEnKg, string /*51*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pProducto_Id_Nueva, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pDescripcionDetallada), new Generalidades.NullableString(/*5*/pDescription), new Generalidades.NullableString(/*6*/pMedidaAlterna), /*7*/pFactorAlterna, /*8*/pClaseAlterna, /*9*/pCodigoBarra, new Generalidades.NullableString(/*10*/pTipo_Id), new Generalidades.NullableString(/*11*/pFamilia_Id), new Generalidades.NullableString(/*12*/pGrupo_Id), new Generalidades.NullableString(/*13*/pUmVenta), /*14*/pCostoReposicion, new Generalidades.NullableString(/*15*/pMonedaUltCompra), new Generalidades.NullableString(/*16*/pUMCompra), new Generalidades.NullableString(/*17*/pCtaCompra), new Generalidades.NullableString(/*18*/pCtaAjuInventario), new Generalidades.NullableString(/*19*/pCtaVenta), new Generalidades.NullableString(/*20*/pCtaCredito), new Generalidades.NullableString(/*21*/pCtaDescuento), new Generalidades.NullableString(/*22*/pCtaCosto), new Generalidades.NullableString(/*23*/pCtaVentaExt), new Generalidades.NullableString(/*24*/pCtaCreditoExt), new Generalidades.NullableString(/*25*/pCtaDescuentoExt), new Generalidades.NullableString(/*26*/pCtaCostoExt), /*27*/pMargenExceso, /*28*/pTiempoEntrega, /*29*/pAcepta_Ventas, new Generalidades.NullableString(/*30*/pCFVenta_Id), /*31*/pAcepta_Compras, new Generalidades.NullableString(/*32*/pCFComp_Id), /*33*/pAcepta_Comis_Vta, /*34*/pDiasGarantia, new Generalidades.NullableString(/*35*/pImagen), /*36*/pFechaUltModif, /*37*/pImagenExtension, new Generalidades.NullableString(/*38*/pCodigoFiscal), new Generalidades.NullableString(/*39*/pFraccionArancelaria), /*40*/pInactivo, /*41*/pUsuario_Id, /*42*/pPosteado, /*43*/pCtaConsumo, /*44*/pObservaciones, new Generalidades.NullableString(/*45*/pUlrProd), new Generalidades.NullableString(/*46*/pClaveSTCC), /*47*/pMaterialPeligroso, new Generalidades.NullableString(/*48*/pCveMaterialPeligroso), new Generalidades.NullableString(/*49*/pEmbalaje), /*50*/pPesoEnKg };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("stkProductosGuardarConMovimientos", parametros));
        }





        public static bool TieneMovimientos(string /*0*/pProducto_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkProductosTieneMovimientos", parametros);

            if (ds.Tables[0].Rows.Count > 0)
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["Cantidad"]) > 0)
                    return true;

            return false;

        }
        /// <summary>
        /// Esta acutaliza el costo en la base deberias usar al ActuCostoProd
        /// </summary>
        /// <param name="Producto_id"></param>
        /// <param name="Cantidad"></param>
        /// <param name="Costo"></param>
        /// <param name="CostoOriginal"></param>
        /// <param name="Moneda_Id"></param>
        /// <param name="pAuxiliar"></param>
        /// <returns></returns>
        public static decimal Actucosto(string /*0*/Producto_id, decimal /*1*/Cantidad, decimal /*2*/Costo,
                decimal CostoOriginal, string Moneda_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Cantidad, /*2*/Costo, CostoOriginal, Moneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("stkProductosActucostos", parametros);
        }

        public static stkProductosExistenciaaFechaDS ExistenciaAFecha(int /*0*/Empresa_Id, string /*1*/Producto_id, DateTime /*2*/Fecha, DateTime /*3*/FechaRegistro, string /*4*/pSucursal, long /*5*/pStkMoviCabe, int /*6*/pRenglon, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Producto_id, /*2*/Fecha, /*3*/FechaRegistro, new Generalidades.NullableString(/*4*/pSucursal), /*5*/pStkMoviCabe, /*6*/pRenglon };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkProductosExistenciaaFecha", parametros);

            string[] camposTabla0 = { "Costo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkProductosExistenciaaFechaDS dsTipado = new stkProductosExistenciaaFechaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkCostosEliminar", parametros);
        }

        public static void EliminarCostos(string /*0*/pProducto_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkCostosEliminar", parametros);
        }
        public static stkCostoUltimaCompraDS CostoUltCompra(string /*0*/pProducto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkCostoUltimaCompra", parametros);

            stkCostoUltimaCompraDS dsTipado = new stkCostoUltimaCompraDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void GuardarCodFiscal(string /*0*/pProducto_Id, string /*1*/pCodigoFiscal, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pCodigoFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCodFiscalGuardar", parametros);
        }

        public static void GuardarCosto(string /*0*/Producto_Id, decimal /*1*/CostoPromPond, decimal /*2*/CostoUltCompra, decimal /*3*/PrecioUltCompra, string /*4*/MonedaUltCompra, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_Id, /*1*/CostoPromPond, /*2*/CostoUltCompra, /*3*/PrecioUltCompra, /*4*/MonedaUltCompra };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosGuardarCosto", parametros);
        }



    }
}
