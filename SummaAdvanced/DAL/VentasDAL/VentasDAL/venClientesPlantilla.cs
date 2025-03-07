using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venClientesPlantilla
    {
        public static venClientesPlantillaDS Datos(string /*0*/pPlantilla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClientesPlantillaDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CondFisc_Id", "DescripcionCondFiscal", "MonedaLimCred", "DescripcionMonedaLimCred", "CategCred_Id", "DescripcionCategCredito", "Estado_Id", "DescripcionClieEstados", "Provincia_Id_Fact", "DescripcionProvincia_Id_Fact", "Pais_Id_Fact", "DescripcionPais_Id_Fact", "Provincia_Id_Entr", "DescripcionProvincia_Id_Entr", "Pais_Id_Entr", "DescripcionPais_Id_Entr", "TipoClie_Id", "DescripcionTiposClie", "ListaPrecio_Id", "DescripcionListasPrecios", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "Zona_Id", "DescripcionZona", "Region_Id", "DescripcionRegion", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "CuentaDxVtas", "DescripcionCuentaDxVtas", "CtaFactAnticipo", "DescripcionCtaFactAnticipo",
                "CtaAnticipo", "DescripcionCtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venClientesPlantillaDS dsTipado = new venClientesPlantillaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.grdCuentas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pPlantilla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClientesPlantillaEliminar", parametros);
        }

        public static int Guardar(string /*0*/pPlantilla_Id, string /*1*/pPlantilla_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCuit, string /*5*/pTipoDoc, string /*6*/pIdFiscal, int /*7*/pSucursal, string /*8*/pRazonSocial, string /*9*/pCondFisc_Id, decimal /*10*/pLimiteCredito, string /*11*/pMonedaLimCred, string /*12*/pCategCred_Id, decimal /*13*/pBonificacion1, decimal /*14*/pBonificacion2, decimal /*15*/pBonificacion3, bool /*16*/pPuntual, string /*17*/pEstado_Id, bool /*18*/pGeneraDebito, bool /*19*/pSiempre, string /*20*/pIBrutos, string /*21*/pSituacion, string /*22*/pNombreFantasia, string /*23*/pDireccion1_Fact, string /*24*/pDireccion2_Fact, string /*25*/pLocalidad_Fact, string /*26*/pCodPostal_Fact, string /*27*/pProvincia_Id_Fact, short /*28*/pPais_Id_Fact, string /*29*/pTelefonos, string /*30*/pFax, string /*31*/pEMail, string /*32*/pDireccion1_Entr, string /*33*/pDireccion2_Entr, string /*34*/pLocalidad_Entr, string /*35*/pCodPostal_Entr, string /*36*/pProvincia_Id_Entr, short /*37*/pPais_Id_Entr, string /*38*/pTipoClie_Id, string /*39*/pListaPrecio_Id, string /*40*/pFormaEntrega_Id, string /*41*/pCondPagoCli_Id, string /*42*/pVendedor_Id, string /*43*/pCobrador_Id, string /*44*/pZona_Id, string /*45*/pRegion_Id, string /*46*/pContactos, string /*47*/pObservaciones, decimal /*48*/pBonificacion1Suc, decimal /*49*/pBonificacion2Suc, decimal /*50*/pBonificacion3Suc, string /*51*/pCentro1_Id, string /*52*/pCentro2_Id, string /*53*/pNroExterior_Fact, string /*54*/pNroInterior_Fact, string /*55*/pNroExterior_Entr, string /*56*/pNroInterior_Entr, string /*57*/pReclamos, string /*58*/pMetodoDePago, string /*59*/pNumCuenta, string /*60*/pC_UsoCFDI, string /*61*/pN_MetodoPago, bool /*62*/pUsaComplementoINE, bool /*63*/pInactivoCliente, bool /*64*/pPosteado, bool /*65*/pInactivo, int /*66*/pUsuario_Id, string /*67*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPlantilla_Id, /*1*/pPlantilla_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pCuit, /*5*/pTipoDoc, /*6*/pIdFiscal, /*7*/pSucursal, /*8*/pRazonSocial, new Generalidades.NullableString(/*9*/pCondFisc_Id), /*10*/pLimiteCredito, new Generalidades.NullableString(/*11*/pMonedaLimCred), new Generalidades.NullableString(/*12*/pCategCred_Id), /*13*/pBonificacion1, /*14*/pBonificacion2, /*15*/pBonificacion3, /*16*/pPuntual, new Generalidades.NullableString(/*17*/pEstado_Id), /*18*/pGeneraDebito, /*19*/pSiempre, /*20*/pIBrutos, /*21*/pSituacion, /*22*/pNombreFantasia, /*23*/pDireccion1_Fact, /*24*/pDireccion2_Fact, /*25*/pLocalidad_Fact, /*26*/pCodPostal_Fact, new Generalidades.NullableString(/*27*/pProvincia_Id_Fact), new Generalidades.NullableShort(/*28*/pPais_Id_Fact), /*29*/pTelefonos, /*30*/pFax, /*31*/pEMail, /*32*/pDireccion1_Entr, /*33*/pDireccion2_Entr, /*34*/pLocalidad_Entr, /*35*/pCodPostal_Entr, new Generalidades.NullableString(/*36*/pProvincia_Id_Entr), new Generalidades.NullableShort(/*37*/pPais_Id_Entr), new Generalidades.NullableString(/*38*/pTipoClie_Id), new Generalidades.NullableString(/*39*/pListaPrecio_Id), new Generalidades.NullableString(/*40*/pFormaEntrega_Id), new Generalidades.NullableString(/*41*/pCondPagoCli_Id), new Generalidades.NullableString(/*42*/pVendedor_Id), new Generalidades.NullableString(/*43*/pCobrador_Id), new Generalidades.NullableString(/*44*/pZona_Id), new Generalidades.NullableString(/*45*/pRegion_Id), /*46*/pContactos, /*47*/pObservaciones, /*48*/pBonificacion1Suc, /*49*/pBonificacion2Suc, /*50*/pBonificacion3Suc, new Generalidades.NullableString(/*51*/pCentro1_Id), new Generalidades.NullableString(/*52*/pCentro2_Id), /*53*/pNroExterior_Fact, /*54*/pNroInterior_Fact, /*55*/pNroExterior_Entr, /*56*/pNroInterior_Entr, /*57*/pReclamos, /*58*/pMetodoDePago, /*59*/pNumCuenta, /*60*/pC_UsoCFDI, /*61*/pN_MetodoPago, /*62*/pUsaComplementoINE, /*63*/pInactivoCliente, /*64*/pPosteado, /*65*/pInactivo, new Generalidades.NullableInt(/*66*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venClientesPlantillaGuardar", parametros));
        }

    }
}
