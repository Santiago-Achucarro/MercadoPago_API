using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genUsuarios
    {
        public static genUsuariosDS Datos(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUsuariosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Sucursal", "DescripcionSucursalesEmpr", "Email", "PtoEmision", "Cultura", "DescripcionCultura", "Cliente_Id", "DescripcionCliente", "Proveed_Id", "DescripcionProveedor", "Vendedor_Id", "DescripcionVendedor", "Cobrador_Id", "DescripcionCobrador", "Legajo", "DescripcionLegajo", "Firma", "ImagenFirmaB64" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla7 = { "HoraDesde", "HoraHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            genUsuariosDS dsTipado = new genUsuariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Proveedor.TableName, dsTipado.Cliente.TableName, dsTipado.Empleado.TableName, dsTipado.Vendedor.TableName, dsTipado.Cobrador.TableName, dsTipado.HorariosIngreso.TableName, dsTipado.Adjuntos.TableName, dsTipado.Sucursales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genUsuariosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pUsuario_Id, string /*1*/pUsuario_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pApellido_y_Nombres, string /*4*/pTipoUsuario, string /*5*/pSucursal, int /*6*/pClave_de_Acceso, string /*7*/pCargo, DateTime /*8*/pUltCambioPass, short /*9*/pIntentos, string /*10*/pEmail, int /*11*/pUsuarioCarga, string /*12*/pPtoEmision, bool /*13*/pCambiarClave, short /*14*/pMalClave, bool /*15*/pEsSupervisor, string /*16*/pCultura, bool /*17*/pInactivo, bool /*18*/pPosteado, bool /*19*/pMultiplesLogins, string /*20*/pCliente_Id, string /*21*/pProveed_Id, string /*22*/pVendedor_Id, string /*23*/pCobrador_Id, int /*24*/pLegajo, bool /*25*/pRestringeHorarios, string /*26*/pFirma, string /*27*/pImagenFirma, string /*28*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pUsuario_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pApellido_y_Nombres, /*4*/pTipoUsuario, new Generalidades.NullableString(/*5*/pSucursal), /*6*/pClave_de_Acceso, /*7*/pCargo, /*8*/pUltCambioPass, /*9*/pIntentos, new Generalidades.NullableString(/*10*/pEmail), /*11*/pUsuarioCarga, new Generalidades.NullableString(/*12*/pPtoEmision), /*13*/pCambiarClave, /*14*/pMalClave, /*15*/pEsSupervisor, new Generalidades.NullableString(/*16*/pCultura), /*17*/pInactivo, /*18*/pPosteado, /*19*/pMultiplesLogins, new Generalidades.NullableString(/*20*/pCliente_Id), new Generalidades.NullableString(/*21*/pProveed_Id), new Generalidades.NullableString(/*22*/pVendedor_Id), new Generalidades.NullableString(/*23*/pCobrador_Id), new Generalidades.NullableInt(/*24*/pLegajo), /*25*/pRestringeHorarios, /*26*/pFirma, /*27*/pImagenFirma };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("genUsuariosGuardar", parametros));
        }

       
        public static void CambiarClaveGuardar(int /*0*/Usuario_Id, int /*1*/Clave, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id, /*1*/Clave };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUsuariosCambiarClaveGuardar", parametros);
        }





        public static genUsuariosCambiarClaveDS CambiarClaveDatos( string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {  };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUsuariosCambiarClaveDatos", parametros);

            genUsuariosCambiarClaveDS dsTipado = new genUsuariosCambiarClaveDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static genUsuariosDS DatosInt(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUsuariosDatosInt", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Sucursal", "DescripcionSucursalesEmpr", "Email", "PtoEmision", "Cultura", "DescripcionCultura", "Cliente_Id", "DescripcionCliente", "Proveed_Id", "DescripcionProveedor", "Vendedor_Id", "DescripcionVendedor", "Cobrador_Id", "DescripcionCobrador", "Legajo", "DescripcionLegajo", "Firma", "ImagenFirmaB64" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genUsuariosDS dsTipado = new genUsuariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Proveedor.TableName, dsTipado.Cliente.TableName, dsTipado.Empleado.TableName, dsTipado.Vendedor.TableName, dsTipado.Cobrador.TableName, dsTipado.HorariosIngreso.TableName, dsTipado.Adjuntos.TableName, dsTipado.Sucursales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genUsuariosLogueadosDS DatosLogueados(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUsuariosLogueadosDatos", parametros);

            genUsuariosLogueadosDS dsTipado = new genUsuariosLogueadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void insertarLogin(int nUsuario, int nEmpresa, string cToken, string pAuxiliar)
        {
            
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "INSERT INTO genUsuariosLogueados ( Usuario_Id, UltEmpresa,  FechaLogin, Caduca, Token) "+
                " VALUES(" + nUsuario.ToString() + "," + nEmpresa.ToString() + ",getdate(),Dateadd(mi, 5, getdate()),"+
                "'" +cToken+"')";

            oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

            lSql = "delete genUsuariosLogueados  Where Caduca < Dateadd(hh, -1, getdate())";
            oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

        }

        public static int CuantosLogeados(string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "SELECT count(*) Cantidad FROM genUsuariosLogueados WHERE Caduca >= getdate()";

            DataSet lDs = oiDAAB.helper.ExecuteDataset(pAuxiliar, CommandType.Text, lSql);
            if (lDs.Tables[0].Rows.Count == 0)
                return 0;

            return Convert.ToInt32(lDs.Tables[0].Rows[0][0]);

        }


        public static int ActualizarCaduca(string cToken, string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "Update genUsuariosLogueados SET Caduca = Dateadd(mi, 5, getdate()) WHERE "+
                    " Token = '"+cToken+"'";

            return oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

        }

        public static bool YaEstaLogueado(string cToken, string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "select 1 From  genUsuariosLogueados WHERE " +
                    " Token = '" + cToken + "' and Caduca > getdate() ";

            DataSet lDs = oiDAAB.helper.ExecuteDataset(pAuxiliar, CommandType.Text, lSql);
            return (lDs.Tables[0].Rows.Count > 0);

        }

        public static void QuitaUsuario(int nUsuario, string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "Delete genUsuariosLogueados WHERE Usuario_id = " + nUsuario.ToString();

            oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

        }


        public static void QuitaUsuarioToken(int nUsuario, string pToken, string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "Delete genUsuariosLogueados WHERE Usuario_id = " + nUsuario.ToString() +
                    "AND Token = '" + pToken + "'";
            oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

        }


        public static void QuitaUsuarioCaduco(int nUsuario, string pAuxiliar)
        {

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            String lSql = "Delete genUsuariosLogueados WHERE Caduca < getDate() and Usuario_id = " + nUsuario.ToString();

            oiDAAB.helper.ExecuteNonQuery(pAuxiliar, CommandType.Text, lSql);

        }
        public static void IntentosGuardar(int /*0*/Usuario_Id, int /*1*/Intentos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id, /*1*/Intentos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUsuariosIntentosGuardar", parametros);
        }


        public static void MalClaveGuardar(int /*0*/Usuario_Id, int /*1*/MalClave, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id, /*1*/MalClave };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUsuariosMalClaveGuardar", parametros);
        }

        public static genClavesComunesDS ClavesComunesDatos(string /*0*/Clave, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Clave };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genClavesComunesDatos", parametros);

            genClavesComunesDS dsTipado = new genClavesComunesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static genUsuariosRecuperarDS DatosRecuperarPass(string /*0*/pUsuario_Id, string /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genUsuariosRecuperar", parametros);

            string[] camposTabla0 = { "Email", "EmailEmpresa", "Servidor", "Seguridad", "Puerto", "Clave", "EmailUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genUsuariosRecuperarDS dsTipado = new genUsuariosRecuperarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void ActualizarCorreo(string /*0*/Usuario_Id, string /*1*/Correo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id, /*1*/Correo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUsuariosActualizarCorreo", parametros);
        }



    }
}
