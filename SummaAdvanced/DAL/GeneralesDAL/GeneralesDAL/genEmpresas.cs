using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;
using System.Text;

namespace GeneralesDAL
{
    public class genEmpresas
    {
        public static genEmpresasDS Datos(string /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genEmpresasDatos", parametros);

            string[] camposTabla0 = { "Logo", "Moneda_Id", "DescripcionMonedas", "Pais_Id", "DescripcionPaises", "Provincia_Id", "DescripcionProvincias", "FechaCierreSueldos", "Telefono", "Usuario_Id", "DescripcionUsuario", "Dominio_Id", "CarpetaEspecial", "CodLocalidad", "CodColonia", "CodMunicipio", "CondFiscal", "PaginaWeb", "CtaMercaEnTransitoImpor", "DescripcionCtaMercaEnTransitoImpor", "CtaMercTransito", "DescripcionCtaMercTransito", "CtaApliImportacion", "DescripcionCtaApliImportacion", "SucursalCentral", "DescripcionSucursalCentral", "Centro1De", "Centro2De", "CtaUtiCambioRealizada", "DescripcionCtaUtiCambioRealizada", "CtaPerCambioRealizada", "DescripcionCtaPerCambioRealizada", "CtaUtiCambioProv", "DescripcionCtaUtiCambioProv", "CtaPerCambioProv", "DescripcionCtaPerCambioProv", "CtaAjuStockPos", "CtaAjuStockPosDescripcion", "CtaAjuStockNeg", "CtaAjuStockNegDescripcion", "Servidor", "Puerto", "Correo", "UsuarioCorreo", "Clave", "Seguridad", "CFVenta_Id", "DescripcionCFVenta_Id", "Medida_Id", "DescripcionMedida_Id", "EnviaFacturas", "EnviaRecibo", "EnviaOC", "MailClientesSinMail", "FechaCierreImpuestos", "CFAjusCtaCte", "DescripcionCFAjusCtaCte", "TipoDtoFin", "MontoDtoFinanciero", "CtaDtoFinPos", "DescripcionCtaDtoFinPos", "CtaDtoFinNeg", "DescripcionCtaDtoFinNeg", "Firma", "ImagenFirmaB64", "CuentasDeposito", "CtaRemisiones", "DescripcionCtaRemisiones", "ServidorRH", "PuertoRH", "CorreoRH", "UsuarioCorreoRH", "ClaveRH", "SeguridadRH", "TipoPermisoSCT", "NroPermisoSCT" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genEmpresasDS dsTipado = new genEmpresasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static genEmpresasDS DatosInt(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genEmpresasDatosInt", parametros);

            string[] camposTabla0 = { "Logo", "Moneda_Id", "DescripcionMonedas", "Pais_Id", "DescripcionPaises", "Provincia_Id", "DescripcionProvincias", "FechaCierreSueldos", "Telefono", "Usuario_Id", "DescripcionUsuario", "Dominio_Id", "CarpetaEspecial", "CodLocalidad", "CodColonia", "CodMunicipio", "CondFiscal", "PaginaWeb", "CtaMercaEnTransitoImpor", "DescripcionCtaMercaEnTransitoImpor", "CtaMercTransito", "DescripcionCtaMercTransito", "CtaApliImportacion", "DescripcionCtaApliImportacion", "SucursalCentral", "DescripcionSucursalCentral", "Centro1De", "Centro2De", "CtaUtiCambioRealizada", "DescripcionCtaUtiCambioRealizada", "CtaPerCambioRealizada", "DescripcionCtaPerCambioRealizada", "CtaUtiCambioProv", "DescripcionCtaUtiCambioProv", "CtaPerCambioProv", "DescripcionCtaPerCambioProv", "CtaAjuStockPos", "CtaAjuStockPosDescripcion", "CtaAjuStockNeg", "CtaAjuStockNegDescripcion", "Servidor", "Puerto", "Correo", "UsuarioCorreo", "Clave", "Seguridad", "CFVenta_Id", "DescripcionCFVenta_Id", "Medida_Id", "DescripcionMedida_Id", "EnviaFacturas", "EnviaRecibo", "EnviaOC", "MailClientesSinMail", "FechaCierreImpuestos", "CFAjusCtaCte", "DescripcionCFAjusCtaCte", "TipoDtoFin", "MontoDtoFinanciero", "CtaDtoFinPos", "DescripcionCtaDtoFinPos", "CtaDtoFinNeg", "DescripcionCtaDtoFinNeg", "Firma", "ImagenFirmaB64", "CuentasDeposito", "CtaRemisiones", "DescripcionCtaRemisiones", "ServidorRH", "PuertoRH", "CorreoRH", "UsuarioCorreoRH", "ClaveRH", "SeguridadRH", "TipoPermisoSCT", "NroPermisoSCT" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genEmpresasDS dsTipado = new genEmpresasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genEmpresasEliminar", parametros);
        }

        /*26*/
        //pLogo==""?null:Convert.FromBase64String(pLogo)
        public static int Guardar(string /*0*/pEmpresa_Id, string /*1*/pEmpresa_Id_Nueva, string /*2*/pDetalle, string /*3*/pLogo, string /*4*/pExtensionArchivo, string /*5*/pMoneda_Id, short /*6*/pPais_Id, string /*7*/pCuit, string /*8*/pCalle, string /*9*/pNoExterior, string /*10*/pNoInterior, string /*11*/pColonia, string /*12*/pLocalidad, string /*13*/pMunicipio, string /*14*/pReferencia, string /*15*/pProvincia_Id, string /*16*/pCodigoPostal, DateTime /*17*/pFechaInicioSumma, DateTime /*18*/pFechaInicioSociedad, string /*19*/pNumeroIIBB, string /*20*/pIGJ, string /*21*/pActividad, string /*22*/pRegimen, string /*23*/pTelefono, bool /*24*/pInactivo, int /*25*/pUsuario_id, string /*26*/pCarpetaEspecial, bool /*27*/pUsaCantidadAlterna, bool /*28*/pUsaDespachoImportacion, bool /*29*/pUsaSerie, DateTime /*30*/pFechaCierreVentas, DateTime /*31*/pFechaCierreCompras, DateTime /*32*/pFechaCierreTesoreria, DateTime /*33*/pFechaCierreStock, DateTime /*34*/pFechaCalculoStock, string /*35*/pRazonSocial, string /*36*/pTipoCosto, string /*37*/pTipoCosto2, string /*38*/pTipoCosto3, string /*39*/pCodLocalidad, string /*40*/pCodColonia, string /*41*/pCodMunicipio, string /*42*/pCondFiscal, string /*43*/pPaginaWeb, string /*44*/pCtaMercaEnTransitoImpor, string /*45*/pSucursalCentral, string /*46*/pCtaMercTransito, string /*47*/pCtaApliImportacion, string /*48*/pCentro1De, string /*49*/pCentro2De, string /*50*/pCtaUtiCambioRealizada, string /*51*/pCtaPerCambioRealizada, string /*52*/pCtaUtiCambioProv, string /*53*/pCtaPerCambioProv, string /*54*/pCtaAjuStockPos, string /*55*/pCtaAjuStockNeg, string /*56*/pServidor, int /*57*/pPuerto, string /*58*/pCorreo, string /*59*/pUsuarioCorreo, string /*60*/pClave, string /*61*/pSeguridad, string /*62*/pCFVenta_Id, string /*63*/pMedida_Id, bool /*64*/pEnviaFacturas, bool /*65*/pEnviaRecibo, bool /*66*/pEnviaOC, bool /*67*/pEnviaPedido, string /*68*/pMailClientesSinMail, DateTime /*69*/pFechaCierreImpuestos, string /*70*/pCFAjusCtaCte, DateTime /*71*/pFechaCierreActivoFijo, DateTime /*72*/pFechaCalculoActivoFijo, DateTime /*73*/pFechaCalculoActivoDiferido, string /*74*/pTipoDtoFin, decimal /*75*/pMontoDtoFinanciero, string /*76*/pCtaDtoFinPos, string /*77*/pCtaDtoFinNeg, DateTime /*78*/pFechaCierreSueldos, bool /*79*/pConfirmarEnviarPedidos, bool /*80*/pConfirmarEnviarOC, bool /*81*/pConfirmarEnviarRecibo, bool /*82*/pConfirmarEnviarFacturas, string /*83*/pFirma, string /*84*/pImagenFirmaB64, string /*85*/pCuentasDeposito, bool /*86*/pRemisionesAlCosto, string /*87*/pCtaRemisiones, bool /*88*/pUsaServerRH, string /*89*/pServidorRH, int /*90*/pPuertoRH, string /*91*/pCorreoRH, string /*92*/pUsuarioCorreoRH, string /*93*/pClaveRH, string /*94*/pSeguridadRH, string /*95*/pTipoPermisoSCT, string /*96*/pNroPermisoSCT, bool /*97*/pTrabajaSabado, bool /*98*/pTrabajaDomingo, string /*99*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pEmpresa_Id_Nueva, /*2*/pDetalle, new Generalidades.NullableString(/*3*/pLogo), /*4*/pExtensionArchivo, new Generalidades.NullableString(/*5*/pMoneda_Id), new Generalidades.NullableShort(/*6*/pPais_Id), /*7*/pCuit, /*8*/pCalle, /*9*/pNoExterior, /*10*/pNoInterior, /*11*/pColonia, /*12*/pLocalidad, /*13*/pMunicipio, /*14*/pReferencia, new Generalidades.NullableString(/*15*/pProvincia_Id), /*16*/pCodigoPostal, /*17*/pFechaInicioSumma, /*18*/pFechaInicioSociedad, /*19*/pNumeroIIBB, /*20*/pIGJ, /*21*/pActividad, /*22*/pRegimen, new Generalidades.NullableString(/*23*/pTelefono), /*24*/pInactivo, /*25*/pUsuario_id, new Generalidades.NullableString(/*26*/pCarpetaEspecial), /*27*/pUsaCantidadAlterna, /*28*/pUsaDespachoImportacion, /*29*/pUsaSerie, /*30*/pFechaCierreVentas, /*31*/pFechaCierreCompras, /*32*/pFechaCierreTesoreria, /*33*/pFechaCierreStock, /*34*/pFechaCalculoStock, /*35*/pRazonSocial, /*36*/pTipoCosto, /*37*/pTipoCosto2, /*38*/pTipoCosto3, /*39*/pCodLocalidad, /*40*/pCodColonia, /*41*/pCodMunicipio, /*42*/pCondFiscal, /*43*/pPaginaWeb, new Generalidades.NullableString(/*44*/pCtaMercaEnTransitoImpor), new Generalidades.NullableString(/*45*/pSucursalCentral), new Generalidades.NullableString(/*46*/pCtaMercTransito), new Generalidades.NullableString(/*47*/pCtaApliImportacion), /*48*/pCentro1De, /*49*/pCentro2De, new Generalidades.NullableString(/*50*/pCtaUtiCambioRealizada), new Generalidades.NullableString(/*51*/pCtaPerCambioRealizada), new Generalidades.NullableString(/*52*/pCtaUtiCambioProv), new Generalidades.NullableString(/*53*/pCtaPerCambioProv), new Generalidades.NullableString(/*54*/pCtaAjuStockPos), new Generalidades.NullableString(/*55*/pCtaAjuStockNeg), new Generalidades.NullableString(/*56*/pServidor), /*57*/pPuerto, new Generalidades.NullableString(/*58*/pCorreo), new Generalidades.NullableString(/*59*/pUsuarioCorreo), new Generalidades.NullableString(/*60*/pClave), new Generalidades.NullableString(/*61*/pSeguridad), new Generalidades.NullableString(/*62*/pCFVenta_Id), /*63*/pMedida_Id, /*64*/pEnviaFacturas, /*65*/pEnviaRecibo, /*66*/pEnviaOC, /*67*/pEnviaPedido, new Generalidades.NullableString(/*68*/pMailClientesSinMail), /*69*/pFechaCierreImpuestos, /*70*/pCFAjusCtaCte, /*71*/pFechaCierreActivoFijo, /*72*/pFechaCalculoActivoFijo, /*73*/pFechaCalculoActivoDiferido, /*74*/pTipoDtoFin, /*75*/pMontoDtoFinanciero, new Generalidades.NullableString(/*76*/pCtaDtoFinPos), new Generalidades.NullableString(/*77*/pCtaDtoFinNeg), /*78*/pFechaCierreSueldos, /*79*/pConfirmarEnviarPedidos, /*80*/pConfirmarEnviarOC, /*81*/pConfirmarEnviarRecibo, /*82*/pConfirmarEnviarFacturas, new Generalidades.NullableString(/*83*/pFirma), new Generalidades.NullableString(/*84*/pImagenFirmaB64), new Generalidades.NullableString(/*85*/pCuentasDeposito), /*86*/pRemisionesAlCosto, new Generalidades.NullableString(/*87*/pCtaRemisiones), /*88*/pUsaServerRH, new Generalidades.NullableString(/*89*/pServidorRH), /*90*/pPuertoRH, new Generalidades.NullableString(/*91*/pCorreoRH), new Generalidades.NullableString(/*92*/pUsuarioCorreoRH), new Generalidades.NullableString(/*93*/pClaveRH), new Generalidades.NullableString(/*94*/pSeguridadRH), new Generalidades.NullableString(/*95*/pTipoPermisoSCT), new Generalidades.NullableString(/*96*/pNroPermisoSCT), /*97*/pTrabajaSabado, /*98*/pTrabajaDomingo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("genEmpresasGuardar", parametros));
        }





        public static int GuardarConMovimientos(string /*0*/pEmpresa_Id, string /*1*/pEmpresa_Id_Nueva, string /*2*/pDetalle, string /*3*/pLogo, string /*4*/pExtensionArchivo, short /*5*/pPais_Id, string /*6*/pCuit, string /*7*/pCalle, string /*8*/pNoExterior, string /*9*/pNoInterior, string /*10*/pColonia, string /*11*/pLocalidad, string /*12*/pMunicipio, string /*13*/pReferencia, string /*14*/pProvincia_Id, string /*15*/pCodigoPostal, DateTime /*16*/pFechaInicioSumma, DateTime /*17*/pFechaInicioSociedad, string /*18*/pNumeroIIBB, string /*19*/pIGJ, string /*20*/pActividad, string /*21*/pRegimen, string /*22*/pTelefono, bool /*23*/pInactivo, int /*24*/pUsuario_id, string /*25*/pCarpetaEspecial, bool /*26*/pUsaCantidadAlterna, bool /*27*/pUsaDespachoImportacion, bool /*28*/pUsaSerie, DateTime /*29*/pFechaCierreVentas, DateTime /*30*/pFechaCierreCompras, DateTime /*31*/pFechaCierreTesoreria, DateTime /*32*/pFechaCierreStock, DateTime /*33*/pFechaCalculoStock, string /*34*/pRazonSocial, string /*35*/pTipoCosto, string /*36*/pTipoCosto2, string /*37*/pTipoCosto3, string /*38*/pCodLocalidad, string /*39*/pCodColonia, string /*40*/pCodMunicipio, string /*41*/pCondFiscal, string /*42*/pPaginaWeb, string /*43*/pCtaMercaEnTransitoImpor, string /*44*/pSucursalCentral, string /*45*/pCtaMercTransito, string /*46*/pCtaApliImportacion, string /*47*/pCentro1De, string /*48*/pCentro2De, string /*49*/pCtaUtiCambioRealizada, string /*50*/pCtaPerCambioRealizada, string /*51*/pCtaUtiCambioProv, string /*52*/pCtaPerCambioProv, string /*53*/pCtaAjuStockPos, string /*54*/pCtaAjuStockNeg, string /*55*/pServidor, int /*56*/pPuerto, string /*57*/pCorreo, string /*58*/pUsuarioCorreo, string /*59*/pClave, string /*60*/pSeguridad, string /*61*/pCFVenta_Id, string /*62*/pMedida_Id, bool /*63*/pEnviaFacturas, bool /*64*/pEnviaRecibo, bool /*65*/pEnviaOC, bool /*66*/pEnviaPedido, string /*67*/pMailClientesSinMail, DateTime /*68*/pFechaCierreImpuestos, string /*69*/pCFAjusCtaCte, string /*70*/pTipoDtoFin, decimal /*71*/pMontoDtoFinanciero, string /*72*/pCtaDtoFinPos, string /*73*/pCtaDtoFinNeg, DateTime /*74*/pFechaCalculoActivoDiferido, DateTime /*75*/pFechaCalculoActivoFijo, DateTime /*76*/pFechaCierreActivoFijo, DateTime /*77*/pFechaCierreSueldos, bool /*78*/pConfirmarEnviarPedidos, bool /*79*/pConfirmarEnviarOC, bool /*80*/pConfirmarEnviarRecibo, bool /*81*/pConfirmarEnviarFacturas, string /*82*/pFirma, string /*83*/pImagenFirmaB64, string /*84*/pCuentasDeposito, bool /*85*/pRemisionesAlCosto, string /*86*/pCtaRemisiones, bool /*87*/pUsaServerRH, string /*88*/pServidorRH, int /*89*/pPuertoRH, string /*90*/pCorreoRH, string /*91*/pUsuarioCorreoRH, string /*92*/pClaveRH, string /*93*/pSeguridadRH, string /*94*/pTipoPermisoSCT, string /*95*/pNroPermisoSCT, bool /*96*/pTrabajaSabado, bool /*97*/pTrabajaDomingo, string /*98*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pEmpresa_Id_Nueva, /*2*/pDetalle, new Generalidades.NullableString(/*3*/pLogo), /*4*/pExtensionArchivo, new Generalidades.NullableShort(/*5*/pPais_Id), /*6*/pCuit, /*7*/pCalle, /*8*/pNoExterior, /*9*/pNoInterior, /*10*/pColonia, /*11*/pLocalidad, /*12*/pMunicipio, /*13*/pReferencia, new Generalidades.NullableString(/*14*/pProvincia_Id), /*15*/pCodigoPostal, /*16*/pFechaInicioSumma, /*17*/pFechaInicioSociedad, /*18*/pNumeroIIBB, /*19*/pIGJ, /*20*/pActividad, /*21*/pRegimen, new Generalidades.NullableString(/*22*/pTelefono), /*23*/pInactivo, /*24*/pUsuario_id, new Generalidades.NullableString(/*25*/pCarpetaEspecial), /*26*/pUsaCantidadAlterna, /*27*/pUsaDespachoImportacion, /*28*/pUsaSerie, /*29*/pFechaCierreVentas, /*30*/pFechaCierreCompras, /*31*/pFechaCierreTesoreria, /*32*/pFechaCierreStock, /*33*/pFechaCalculoStock, /*34*/pRazonSocial, /*35*/pTipoCosto, /*36*/pTipoCosto2, /*37*/pTipoCosto3, /*38*/pCodLocalidad, /*39*/pCodColonia, /*40*/pCodMunicipio, /*41*/pCondFiscal, /*42*/pPaginaWeb, new Generalidades.NullableString(/*43*/pCtaMercaEnTransitoImpor), new Generalidades.NullableString(/*44*/pSucursalCentral), new Generalidades.NullableString(/*45*/pCtaMercTransito), new Generalidades.NullableString(/*46*/pCtaApliImportacion), /*47*/pCentro1De, /*48*/pCentro2De, new Generalidades.NullableString(/*49*/pCtaUtiCambioRealizada), new Generalidades.NullableString(/*50*/pCtaPerCambioRealizada), new Generalidades.NullableString(/*51*/pCtaUtiCambioProv), new Generalidades.NullableString(/*52*/pCtaPerCambioProv), new Generalidades.NullableString(/*53*/pCtaAjuStockPos), new Generalidades.NullableString(/*54*/pCtaAjuStockNeg), new Generalidades.NullableString(/*55*/pServidor), /*56*/pPuerto, new Generalidades.NullableString(/*57*/pCorreo), new Generalidades.NullableString(/*58*/pUsuarioCorreo), new Generalidades.NullableString(/*59*/pClave), new Generalidades.NullableString(/*60*/pSeguridad), new Generalidades.NullableString(/*61*/pCFVenta_Id), /*62*/pMedida_Id, /*63*/pEnviaFacturas, /*64*/pEnviaRecibo, /*65*/pEnviaOC, /*66*/pEnviaPedido, new Generalidades.NullableString(/*67*/pMailClientesSinMail), /*68*/pFechaCierreImpuestos, /*69*/pCFAjusCtaCte, /*70*/pTipoDtoFin, /*71*/pMontoDtoFinanciero, new Generalidades.NullableString(/*72*/pCtaDtoFinPos), new Generalidades.NullableString(/*73*/pCtaDtoFinNeg), /*74*/pFechaCalculoActivoDiferido, /*75*/pFechaCalculoActivoFijo, /*76*/pFechaCierreActivoFijo, /*77*/pFechaCierreSueldos, /*78*/pConfirmarEnviarPedidos, /*79*/pConfirmarEnviarOC, /*80*/pConfirmarEnviarRecibo, /*81*/pConfirmarEnviarFacturas, new Generalidades.NullableString(/*82*/pFirma), new Generalidades.NullableString(/*83*/pImagenFirmaB64), new Generalidades.NullableString(/*84*/pCuentasDeposito), /*85*/pRemisionesAlCosto, new Generalidades.NullableString(/*86*/pCtaRemisiones), /*87*/pUsaServerRH, new Generalidades.NullableString(/*88*/pServidorRH), /*89*/pPuertoRH, new Generalidades.NullableString(/*90*/pCorreoRH), new Generalidades.NullableString(/*91*/pUsuarioCorreoRH), new Generalidades.NullableString(/*92*/pClaveRH), new Generalidades.NullableString(/*93*/pSeguridadRH), new Generalidades.NullableString(/*94*/pTipoPermisoSCT), new Generalidades.NullableString(/*95*/pNroPermisoSCT), /*96*/pTrabajaSabado, /*97*/pTrabajaDomingo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("genEmpresasGuardarConMovimientos", parametros));
        }








        public static genEmpresasTodasDS Todas( string /*0*/ pAuxiliar)
        {
            
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genEmpresasTodas");

            genEmpresasTodasDS dsTipado = new genEmpresasTodasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void SetFechaCompras(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaCompras", parametros);
        }

        public static void SetFechaCalculoStock(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaCalculoStock", parametros);
        }

        public static void SetFechaStock(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaStock", parametros);
        }

        public static void SetFechaTesoreria(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaTesoreria", parametros);
        }

        public static void SetFechaVentas(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaVentas", parametros);
        }

        public static void SetFechaImpuestos(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaImpuestos", parametros);
        }

        public static void SetFechaActivoFijo(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaActivoFijo", parametros);
        }

        public static void SetFechaCalcActivoFijo(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaCalcActivoFijo", parametros);
        }

        public static void SetFechaCalcActivoDiferido(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaCalcActivoDiferido", parametros);
        }


        public static void SetFechaSueldos(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaCierre, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaCierre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEmpresasSetFechaSueldos", parametros);
        }

    }
}
