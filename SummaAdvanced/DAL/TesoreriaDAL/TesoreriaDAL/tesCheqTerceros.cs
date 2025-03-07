using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqTerceros
    {

        public static tesCheqTercerosDS Datos(int /*0*/ptesCheqTerceros, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqTerceros };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosDatos", parametros);

            string[] camposTabla0 = { "FechaAcreditacion", "FechaConciliacion", "Cliente_Id", "DescripcionClientes", "BancoConc", "NumeroConc", "BancoConcVta", "NumeroConcVta", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCheqTercerosDS dsTipado = new tesCheqTercerosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/ptesCheqTerceros, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/ptesCheqTerceros) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCheqTercerosEliminar", parametros);
        }



        public static int Guardar(int /*0*/ptesCheqTerceros, string /*1*/pCartera_Id, string /*2*/pBanco_Id, string /*3*/pClearing, short /*4*/pSecuenciaActual, short /*5*/pClearingDias, DateTime /*6*/pFechaVencimiento, DateTime /*7*/pFechaAcreditacion, DateTime /*8*/pFechaConciliacion, string /*9*/psucBanco, int /*10*/pnumCheque, string /*11*/pEstado_Id, string /*12*/pCliente_Id, string /*13*/pcuentaBanco, string /*14*/pBancoConc, int /*15*/pNumeroConc, int /*16*/pEmpresa_Id, string /*17*/pBancoConcVta, int /*18*/pNumeroConcVta, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqTerceros, /*1*/pCartera_Id, /*2*/pBanco_Id, /*3*/pClearing, /*4*/pSecuenciaActual, /*5*/pClearingDias, /*6*/pFechaVencimiento, new Generalidades.NullableDate(/*7*/pFechaAcreditacion), new Generalidades.NullableDate(/*8*/pFechaConciliacion), /*9*/psucBanco, /*10*/pnumCheque, /*11*/pEstado_Id, new Generalidades.NullableString(/*12*/pCliente_Id), /*13*/pcuentaBanco, new Generalidades.NullableString(/*14*/pBancoConc), new Generalidades.NullableInt(/*15*/pNumeroConc), new Generalidades.NullableInt(/*16*/pEmpresa_Id), new Generalidades.NullableString(/*17*/pBancoConcVta), new Generalidades.NullableInt(/*18*/pNumeroConcVta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesCheqTercerosGuardar", parametros);
        }



        public static tesCheqTercerosXEstadoDS DatosxEstado(int /*0*/Empresa_Id, string /*1*/Cartera_Id, string /*2*/Estado_Id,
            DateTime /*3*/FechaHasta, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Cartera_Id, /*2*/Estado_Id,
                new Generalidades.NullableDate(/*3*/FechaHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosXEstadoDatos", parametros);

            string[] camposTabla0 = { "Empresa_id", "Cartera_Id", "Estado_id", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "Cliente_Id", "RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCheqTercerosXEstadoDS dsTipado = new tesCheqTercerosXEstadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CheqTercerosHaber.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static tesCheqTercerosXEstadoDS DatosxEstado(int /*0*/Empresa_Id, string /*1*/Cartera_Id, string /*2*/Estado_Id, DateTime /*3*/FechaDesde, DateTime /*4*/FechaHasta, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Cartera_Id, /*2*/Estado_Id, /*3*/FechaDesde, /*4*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosXEstado2Datos", parametros);

            string[] camposTabla0 = { "Empresa_id", "Cartera_Id", "Estado_id", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "Cliente_Id", "RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCheqTercerosXEstadoDS dsTipado = new tesCheqTercerosXEstadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CheqTercerosHaber.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Conciliar(int /*0*/ptesCheqTerceros, string /*1*/pBancoConc, int /*2*/pNumeroConc, int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqTerceros, /*1*/pBancoConc, /*2*/pNumeroConc, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCheqTercerosConciliar", parametros);
        }



        public static tesCheqTercerosBancoDepoDS DatosBancoDepo(int /*0*/pTesCheqterceros, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesCheqterceros };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosBancoDepo", parametros);

            tesCheqTercerosBancoDepoDS dsTipado = new tesCheqTercerosBancoDepoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesCheqTercerosRechazadosClieDS DatosRechClie(int /*0*/Empresa_Id, string /*1*/pCliente_Id, string /*2*/ pCartera_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pCliente_Id, /*2*/ pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosRechazadosClieDatos", parametros);

            string[] camposTabla0 = { "Marca", "Cliente_Id", "RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCheqTercerosRechazadosClieDS dsTipado = new tesCheqTercerosRechazadosClieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Modificar(int /*0*/ptesCheqTerceros, string /*1*/pBanco_Id, string /*2*/pClearing, DateTime /*3*/pFechaVencimiento, string /*4*/psucBanco, int /*5*/pnumCheque, int /*6*/pEmpresa_Id, string /*7*/pcuentaBanco, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqTerceros, /*1*/pBanco_Id, /*2*/pClearing, /*3*/pFechaVencimiento, /*4*/psucBanco, /*5*/pnumCheque, new Generalidades.NullableInt(/*6*/pEmpresa_Id), /*7*/pcuentaBanco };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCheqTercerosModificar", parametros);
        }

        public static tesCheqTercerosProveedorDS DatosProveedor(int /*0*/pTesCheqterceros, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesCheqterceros };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesCheqTercerosProveedor", parametros);

            tesCheqTercerosProveedorDS dsTipado = new tesCheqTercerosProveedorDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static tesCheqTercerosEgresosVariosDS DatosEgresosVarios(int /*0*/pTesCheqterceros, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesCheqterceros };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesCheqTercerosEgresosVarios", parametros);

            string[] camposTabla0 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCheqTercerosEgresosVariosDS dsTipado = new tesCheqTercerosEgresosVariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
