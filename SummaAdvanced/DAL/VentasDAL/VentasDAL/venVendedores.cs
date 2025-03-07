using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venVendedores
    {
        public static venVendedoresDS Datos(string /*0*/pVendedor_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVendedor_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venVendedoresDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Supervisor_Id", "NombreSupervisor", "Centro1_Id", "DescripcionCentro1", "Centro2_Id",
                "DescripcionCentro2", "Usuario", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venVendedoresDS dsTipado = new venVendedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venVendedoresDS DatosId(long /*0*/pIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venVendedoresDatosId", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Supervisor_Id", "NombreSupervisor", "Centro1_Id", "DescripcionCentro1", "Centro2_Id",
                "DescripcionCentro2", "Usuario", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venVendedoresDS dsTipado = new venVendedoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pVendedor_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVendedor_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venVendedoresEliminar", parametros);
        }


        public static void Guardar(long /*0*/pvenVendedores, string /*1*/pVendedor_Id, string /*2*/pVendedor_Id_Nueva, int /*3*/pEmpresa_Id,
            string /*4*/pNombre, decimal /*5*/pComision, decimal /*6*/pComisionxSuperv, string /*7*/pSupervisor_Id, decimal /*8*/pPisoDeVentas,
            string /*9*/pCentro1_Id, string /*10*/pCentro2_Id, bool /*11*/pFacturaCobrada, bool /*12*/pConAnticipos, bool /*13*/pSinImpuestos, 
            bool /*14*/pInactivo, string /*15*/pUsuario, int /*16*/pUsuario_Id, bool /*17*/pPosteado, string /*18*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenVendedores, /*1*/pVendedor_Id, /*2*/pVendedor_Id_Nueva,
                new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pNombre, /*5*/pComision, /*6*/pComisionxSuperv,
                new Generalidades.NullableString(/*7*/pSupervisor_Id), /*8*/pPisoDeVentas, new Generalidades.NullableString(/*9*/pCentro1_Id),
                new Generalidades.NullableString(/*10*/pCentro2_Id), /*11*/pFacturaCobrada, /*12*/pConAnticipos, /*13*/pSinImpuestos, /*14*/pInactivo,
                new Generalidades.NullableString(/*15*/pUsuario), /*16*/pUsuario_Id, /*17*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venVendedoresGuardar", parametros);
        }
    }
}
