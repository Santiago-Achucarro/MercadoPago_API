using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comProveedores
    {
        public static comProveedoresDS Datos(string /*0*/pProveed_Id, string /*1*/pEspecializacion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pEspecializacion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comProveedoresDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Provincia_Id", "DescripcionProvincias", "Pais_Id", "DescripcionPaises", "Region_Id", "DescripcionRegiones", "CondPago_Id", "DescripcionConPago", "FormaEnt_Id", "DescripcionForEntre", "Observaciones", "CondFiscal_Id", "DescripcionCondFiscal", "Origen_Id", "DescripcionOrCredFisc", "Interbanking", "Banco_Id", "DescripcionBancos", "ProvTipo_Id", "DescripcionProvTipos", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ctaPagoXAdelantado", "DescripcionctaPagoXAdelantado", "CtaAnticipo", "DescripcionCtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "CodigoFiscal", "CuentaDebe", "DescricpionCtaDebe", "CuentaHaber", "DescricpionCuentaCtaHaber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            comProveedoresDS dsTipado = new comProveedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CtasPasivo.TableName, dsTipado.CtasContraPartida.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.genJurisCoeficientes.TableName, dsTipado.Retenciones.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pProveed_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProveedoresEliminar", parametros);
        }


        public static void Guardar(long /*0*/pgenEntidades, string /*1*/pProveed_Id, int /*2*/pEmpresa_Id, string /*3*/pRazonSocial, 
            string /*4*/pNombreLegal, string /*5*/pDireccion1, string /*6*/pDireccion2, string /*7*/pLocalidad, string /*8*/pCodigoPostal,
            string /*9*/pProvincia_Id, short /*10*/pPais, string /*11*/pTelefono, string /*12*/pRegion_Id, string /*13*/pCondPago_Id,
            string /*14*/pFormaEnt_Id, string /*15*/pContacto, string /*16*/pEMail, string /*17*/pFax, DateTime /*18*/pFecha_Alta, 
            DateTime /*19*/pFechaUltActiv, string /*20*/pLetra_Fact, string /*21*/pObservaciones, string /*22*/pCondFiscal_Id, 
            bool /*23*/pGanancias, string /*24*/pIBrutos, string /*25*/pEspecializacion, short /*26*/pOrigen_Id, bool /*27*/pEsAduana, 
            string /*28*/pTipoCuenta, string /*29*/pNroCuenta, string /*30*/pCBU, DateTime /*31*/pInterbanking, string /*32*/pBanco_Id,
            string /*33*/pProvTipo_Id, bool /*34*/pInactivo, int /*35*/pUsuario_Id, bool /*36*/pPosteado, string /*37*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pProveed_Id, new Generalidades.NullableInt(/*2*/pEmpresa_Id),
                /*3*/pRazonSocial, /*4*/pNombreLegal, /*5*/pDireccion1, /*6*/pDireccion2, /*7*/pLocalidad, /*8*/pCodigoPostal,
                new Generalidades.NullableString(/*9*/pProvincia_Id), new Generalidades.NullableShort(/*10*/pPais), /*11*/pTelefono,
                new Generalidades.NullableString(/*12*/pRegion_Id), new Generalidades.NullableString(/*13*/pCondPago_Id),
                new Generalidades.NullableString(/*14*/pFormaEnt_Id), /*15*/pContacto, /*16*/pEMail, /*17*/pFax, /*18*/pFecha_Alta,
                /*19*/pFechaUltActiv, /*20*/pLetra_Fact, new Generalidades.NullableString(/*21*/pObservaciones),
                new Generalidades.NullableString(/*22*/pCondFiscal_Id), /*23*/pGanancias, /*24*/pIBrutos, /*25*/pEspecializacion,
                new Generalidades.NullableShort(/*26*/pOrigen_Id), /*27*/pEsAduana, /*28*/pTipoCuenta, /*29*/pNroCuenta, /*30*/pCBU,
                new Generalidades.NullableDate(/*31*/pInterbanking), new Generalidades.NullableString(/*32*/pBanco_Id),
                new Generalidades.NullableString(/*33*/pProvTipo_Id), /*34*/pInactivo, new Generalidades.NullableInt(/*35*/pUsuario_Id),
                /*36*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProveedoresGuardar", parametros);
        }

        public static comProveedoresDatosCUITDS DatosCuit(string /*0*/pCuit, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuit };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresDatosCUIT", parametros);

            comProveedoresDatosCUITDS dsTipado = new comProveedoresDatosCUITDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static comProveedoresDS DatosId(long /*0*/pIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresDatosId", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Provincia_Id", "DescripcionProvincias", "Pais_Id",
                "DescripcionPaises", "Region_Id", "DescripcionRegiones", "CondPago_Id", "DescripcionConPago", "FormaEnt_Id",
                "DescripcionForEntre", "Observaciones", "CondFiscal_Id", "DescripcionCondFiscal", "Origen_Id", "DescripcionOrCredFisc",
                "Interbanking", "Banco_Id", "DescripcionBancos", "ProvTipo_Id", "DescripcionProvTipos", "Usuario_Id",
                "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ctaPagoXAdelantado", "DescripcionctaPagoXAdelantado", "CtaAnticipo", "DescripcionCtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "CodigoFiscal", "CuentaDebe", "DescricpionCtaDebe", "CuentaHaber", "DescricpionCuentaCtaHaber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            comProveedoresDS dsTipado = new comProveedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CtasPasivo.TableName,
                dsTipado.CtasContraPartida.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.genJurisCoeficientes.TableName, dsTipado.Retenciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comProveedoresXLSCatalogoDS DatosXLS(string /*0*/pProveedorDesde, string /*1*/pProveedorHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveedorDesde, /*1*/pProveedorHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("comProveedoresXLSCatalogo", parametros);

            string[] camposTabla0 = { "ProveedorDesde", "ProveedorHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Observaciones", "Banco_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comProveedoresXLSCatalogoDS dsTipado = new comProveedoresXLSCatalogoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Proveedores.TableName, dsTipado.CtasPasivo.TableName, dsTipado.CtaContrapartida.TableName, dsTipado.Impuestos.TableName, dsTipado.IIBB.TableName, dsTipado.Retenciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
