using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{

    public class venCamiones
    {
        public static venCamionesDS Datos(string /*0*/pPatente_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPatente_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venCamionesDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "FormaEntrega_Id", "RazonSocial", "CargaMaxima", "Tara", "Marca", "Inspeccion", "Usuario_Id", "DescripcionUsuario", "NroPoliza", "NombreAseg", "ConfVehicular", "Modelo", "TipoPermisoSCT", "NroPermisoSCT", "PropArre_Id", "Nombre", "AseguraMedAmb", "PolizaMedAmbiente", "AseguraCarga", "PolizaCarga", "PrimaSeguro" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venCamionesDS dsTipado = new venCamionesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pPatente_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pPatente_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCamionesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pPatente_Id, string /*1*/pPatente_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pFormaEntrega_Id, decimal /*5*/pCargaMaxima, decimal /*6*/pTara, string /*7*/pMarca, DateTime /*8*/pInspeccion, bool /*9*/pEsAcoplado, bool /*10*/pInactivo, int /*11*/pUsuario_Id, bool /*12*/pPosteado, string /*13*/pNroPoliza, string /*14*/pNombreAseg, string /*15*/pConfVehicular, int /*16*/pModelo, string /*17*/pTipoPermisoSCT, string /*18*/pNroPermisoSCT, string /*19*/pPropArre_Id, string /*20*/pAseguraMedAmb, string /*21*/pPolizaMedAmbiente, string /*22*/pAseguraCarga, string /*23*/pPolizaCarga, decimal /*24*/pPrimaSeguro, string /*25*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPatente_Id, /*1*/pPatente_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pFormaEntrega_Id), new Generalidades.NullableDecimal(/*5*/pCargaMaxima), new Generalidades.NullableDecimal(/*6*/pTara), new Generalidades.NullableString(/*7*/pMarca), new Generalidades.NullableDate(/*8*/pInspeccion), /*9*/pEsAcoplado, /*10*/pInactivo, new Generalidades.NullableInt(/*11*/pUsuario_Id), /*12*/pPosteado, new Generalidades.NullableString(/*13*/pNroPoliza), new Generalidades.NullableString(/*14*/pNombreAseg), new Generalidades.NullableString(/*15*/pConfVehicular), new Generalidades.NullableInt(/*16*/pModelo), new Generalidades.NullableString(/*17*/pTipoPermisoSCT), new Generalidades.NullableString(/*18*/pNroPermisoSCT), new Generalidades.NullableString(/*19*/pPropArre_Id), new Generalidades.NullableString(/*20*/pAseguraMedAmb), new Generalidades.NullableString(/*21*/pPolizaMedAmbiente), new Generalidades.NullableString(/*22*/pAseguraCarga), new Generalidades.NullableString(/*23*/pPolizaCarga), /*24*/pPrimaSeguro };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venCamionesGuardar", parametros));
        }


    }
}
