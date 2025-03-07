using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venFormaEntrega
    {
        public static venFormaEntregaDS Datos(string /*0*/pFormaEntrega_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFormaEntrega_id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venFormaEntregaDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Provincia_Id", "DescripcionProvincias", "Pais_Id", "DescripcionPaises", "CondFisc_Id", "DescripcionCondFiscal", "Email" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venFormaEntregaDS dsTipado = new venFormaEntregaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pFormaEntrega_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pFormaEntrega_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venFormaEntregaEliminar", parametros);
        }
        public static int Guardar(string /*0*/pFormaEntrega_id, string /*1*/pFormaEntrega_id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pRazonSocial, string /*4*/pDireccion, string /*5*/pLocalidad, string /*6*/pProvincia_Id, short /*7*/pPais_Id, string /*8*/pTelefono, string /*9*/pCuit, string /*10*/pCondFisc_id, decimal /*11*/pSeguro, string /*12*/pContacto, string /*13*/pCargo, string /*14*/pEmail, bool /*15*/pExcluirDelReparto, bool /*16*/pInactivo, int /*17*/pUsuario_Id, bool /*18*/pPosteado, bool /*19*/pUsaCartaPorte, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFormaEntrega_id, /*1*/pFormaEntrega_id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pRazonSocial, /*4*/pDireccion, /*5*/pLocalidad, new Generalidades.NullableString(/*6*/pProvincia_Id), new Generalidades.NullableShort(/*7*/pPais_Id), /*8*/pTelefono, /*9*/pCuit, new Generalidades.NullableString(/*10*/pCondFisc_id), /*11*/pSeguro, /*12*/pContacto, /*13*/pCargo, new Generalidades.NullableString(/*14*/pEmail), /*15*/pExcluirDelReparto, /*16*/pInactivo, /*17*/pUsuario_Id, /*18*/pPosteado, /*19*/pUsaCartaPorte };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venFormaEntregaGuardar", parametros);
        }


    }
}
