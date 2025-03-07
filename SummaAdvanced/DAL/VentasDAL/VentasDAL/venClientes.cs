using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venClientes
    {
        public static venClientesDS Datos(string /*0*/pCliente_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venClientesDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CondFisc_Id", "DescripcionCondFiscal", "MonedaLimCred", "CategCred_Id", "DescripcionCategCredito", "Estado_Id", "DescripcionClieEstados", "FacturaCredito", "MontoFacturaCredito", "CbuBanco", "Regimen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venClientesDS dsTipado = new venClientesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static venClientesDS DatosId(long /*0*/genEntidades, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/genEntidades };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venClientesDatosId", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CondFisc_Id", "DescripcionCondFiscal", "MonedaLimCred", "CategCred_Id", "DescripcionCategCredito", "Estado_Id", "DescripcionClieEstados", "FacturaCredito", "MontoFacturaCredito", "CbuBanco", "Regimen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venClientesDS dsTipado = new venClientesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pCliente_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClientesEliminar", parametros);
        }

        public static void Guardar(long /*0*/pgenEntidades, string /*1*/pCliente_Id, string /*2*/pCliente_Id_Nueva, int /*3*/pEmpresa_Id, string /*4*/pRazonSocial, int /*5*/pSucursalPredeter, string /*6*/pCondFisc_Id, decimal /*7*/pLimiteCredito, string /*8*/pMonedaLimCred, string /*9*/pCategCred_Id, decimal /*10*/pBonificacion1, decimal /*11*/pBonificacion2, decimal /*12*/pBonificacion3, bool /*13*/pPuntual, string /*14*/pEstado_Id, bool /*15*/pGeneraDebito, bool /*16*/pSiempre, bool /*17*/pCongelaCambio, string /*18*/pIBrutos, string /*19*/pSituacion, bool /*20*/pFacturaCredito, decimal /*21*/pMontoFacturaCredito, string /*22*/pCbuBanco, bool /*23*/pPosteado, string /*24*/pRegimen, string /*25*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pCliente_Id, /*2*/pCliente_Id_Nueva, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pRazonSocial, /*5*/pSucursalPredeter, new Generalidades.NullableString(/*6*/pCondFisc_Id), /*7*/pLimiteCredito, /*8*/pMonedaLimCred, new Generalidades.NullableString(/*9*/pCategCred_Id), /*10*/pBonificacion1, /*11*/pBonificacion2, /*12*/pBonificacion3, /*13*/pPuntual, new Generalidades.NullableString(/*14*/pEstado_Id), /*15*/pGeneraDebito, /*16*/pSiempre, /*17*/pCongelaCambio, /*18*/pIBrutos, /*19*/pSituacion, new Generalidades.NullableBool(/*20*/pFacturaCredito), new Generalidades.NullableDecimal(/*21*/pMontoFacturaCredito), new Generalidades.NullableString(/*22*/pCbuBanco), /*23*/pPosteado, new Generalidades.NullableString(/*24*/pRegimen) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venClientesGuardar", parametros);
        }



        public static void CFiscalCambiar(long /*0*/pCliente_Id, string /*1*/pCondFiscal_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pCondFiscal_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venClientesCFiscalGuardar", parametros);
        }

        public static venClientesSucDS SucDatos(string /*0*/pCliente_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClientesSucDatos", parametros);

            venClientesSucDS dsTipado = new venClientesSucDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Sucursales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venClientesXLSCatalogoDS DatosXLS(string /*0*/pClienteDesde, string /*1*/pClienteHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClienteDesde, /*1*/pClienteHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venClientesXLSCatalogo", parametros);

            string[] camposTabla0 = { "ClienteDesde", "ClienteHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Regimen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla4 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            venClientesXLSCatalogoDS dsTipado = new venClientesXLSCatalogoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Clientes.TableName, dsTipado.Sucursales.TableName, dsTipado.Cuentas.TableName, dsTipado.IIBB.TableName, dsTipado.Contactos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
