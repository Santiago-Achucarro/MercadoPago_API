using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using StockCommon;
using System.Data;

namespace StockDAL
{
    public class stkDepositos
    {


        public static stkDepositosDS Datos(string /*0*/pDeposito_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDeposito_id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkDepositosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Sucursal", "DescripcionSucursalesEmpr", "GrupoUsuarios", "DescripcionGrupoUsuarios", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "CuentaDeudCons", "DescripcionCuentaDeudCons", "CuentaAcredCons", "DescripcionCuentaAcredCons", "CtaBienesCambio", "DescripcionCtaBienesCambio", "CtaMercEnCons", "DescripcionCtaMercEnCons", "DepositoReal", "Localidad", "CodigoPostal", "Provincia_Id", "DescripcionProvincias", "c_ColoniaEntr", "c_LocalidadEntr", "c_MunicipioEntr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkDepositosDS dsTipado = new stkDepositosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pDeposito_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pDeposito_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkDepositosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pDeposito_id, string /*1*/pDeposito_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pSucursal, string /*4*/pDescripcion, string /*5*/pDireccion, string /*6*/pGrupoUsuarios, string /*7*/pCentro1_Id, string /*8*/pCentro2_Id, bool /*9*/pAdmiteVentas, bool /*10*/pConsignacion, string /*11*/pCuentaDeudCons, string /*12*/pCuentaAcredCons, string /*13*/pCtaBienesCambio, string /*14*/pCtaMercEnCons, string /*15*/pDepositoReal, bool /*16*/pconsCompra_Venta, string /*17*/pLocalidad, string /*18*/pCodigoPostal, string /*19*/pProvincia_Id, bool /*20*/pInactivo, bool /*21*/pPosteado, int /*22*/pUsuario_Id, bool /*23*/pUsaUbicacion, string /*24*/pc_ColoniaEntr, string /*25*/pc_LocalidadEntr, string /*26*/pc_MunicipioEntr, string /*27*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDeposito_id, /*1*/pDeposito_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), new Generalidades.NullableString(/*3*/pSucursal), /*4*/pDescripcion, /*5*/pDireccion, new Generalidades.NullableString(/*6*/pGrupoUsuarios), new Generalidades.NullableString(/*7*/pCentro1_Id), new Generalidades.NullableString(/*8*/pCentro2_Id), /*9*/pAdmiteVentas, /*10*/pConsignacion, new Generalidades.NullableString(/*11*/pCuentaDeudCons), new Generalidades.NullableString(/*12*/pCuentaAcredCons), new Generalidades.NullableString(/*13*/pCtaBienesCambio), new Generalidades.NullableString(/*14*/pCtaMercEnCons), new Generalidades.NullableString(/*15*/pDepositoReal), /*16*/pconsCompra_Venta, new Generalidades.NullableString(/*17*/pLocalidad), new Generalidades.NullableString(/*18*/pCodigoPostal), new Generalidades.NullableString(/*19*/pProvincia_Id), /*20*/pInactivo, /*21*/pPosteado, /*22*/pUsuario_Id, /*23*/pUsaUbicacion, new Generalidades.NullableString(/*24*/pc_ColoniaEntr), new Generalidades.NullableString(/*25*/pc_LocalidadEntr), new Generalidades.NullableString(/*26*/pc_MunicipioEntr) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("stkDepositosGuardar", parametros);
        }

        public static stkTieneExistenciaDepoDS TieneExistencia(string /*0*/pDeposito_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDeposito_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkTieneExistenciaDepo", parametros);

            string[] camposTabla0 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkTieneExistenciaDepoDS dsTipado = new stkTieneExistenciaDepoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
