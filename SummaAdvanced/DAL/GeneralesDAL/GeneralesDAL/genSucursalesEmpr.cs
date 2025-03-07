using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genSucursalesEmpr
    {
        public static genSucursalesEmprDS Datos(string /*0*/pSucursal, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genSucursalesEmprDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Provincia_Id", "DescripcionProvincias", "Pais_Id", "DescripcionPaises", "DepositoVentas", "DescripcionDepositoVentas", "DepositoPedidos", "DescripcionDepositoPedidos", "DepositoOC", "DescripcionDepositoOC", "TipoFE", "DescripcionTipoFE", "Direccion", "Localidad", "Telefono", "SucursalRemito", "SucursalTesoreria", "CodigoPostal", "Serie", "RegPatronal", "codColonia", "DescripcioncodColonia", "codLocalidad", "DescripcioncodLocalidad", "codMunicipio", "DescripcioncodMunicipio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genSucursalesEmprDS dsTipado = new genSucursalesEmprDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(string /*0*/pSucursal, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pSucursal) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genSucursalesEmprEliminar", parametros);
        }

        public static int Guardar(string /*0*/pSucursal, string /*1*/pSucursal_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pProvincia_Id, short /*5*/pPais_Id, string /*6*/pDepositoVentas, string /*7*/pDepositoPedidos, string /*8*/pDepositoOC, DateTime /*9*/pFechaCaja, bool /*10*/pVaConCentral, bool /*11*/pFacturaElectronica, bool /*12*/pUsaWS, string /*13*/pTipoFE, string /*14*/pDireccion, string /*15*/pLocalidad, string /*16*/pTelefono, string /*17*/pSucursalRemito, string /*18*/pSucursalTesoreria, bool /*19*/pInactivo, int /*20*/pUsuario_Id, bool /*21*/pPosteado, string /*22*/pCodigoPostal, string /*23*/pSerie, string /*24*/pRegPatronal, string /*25*/pcodColonia, string /*26*/pcodLocalidad, string /*27*/pcodMunicipio, string /*28*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal, /*1*/pSucursal_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pProvincia_Id), new Generalidades.NullableShort(/*5*/pPais_Id), new Generalidades.NullableString(/*6*/pDepositoVentas), new Generalidades.NullableString(/*7*/pDepositoPedidos), new Generalidades.NullableString(/*8*/pDepositoOC), /*9*/pFechaCaja, /*10*/pVaConCentral, /*11*/pFacturaElectronica, /*12*/pUsaWS, new Generalidades.NullableString(/*13*/pTipoFE), new Generalidades.NullableString(/*14*/pDireccion), new Generalidades.NullableString(/*15*/pLocalidad), new Generalidades.NullableString(/*16*/pTelefono), new Generalidades.NullableString(/*17*/pSucursalRemito), new Generalidades.NullableString(/*18*/pSucursalTesoreria), /*19*/pInactivo, /*20*/pUsuario_Id, /*21*/pPosteado, /*22*/pCodigoPostal, new Generalidades.NullableString(/*23*/pSerie), new Generalidades.NullableString(/*24*/pRegPatronal), new Generalidades.NullableString(/*25*/pcodColonia), new Generalidades.NullableString(/*26*/pcodLocalidad), new Generalidades.NullableString(/*27*/pcodMunicipio) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("genSucursalesEmprGuardar", parametros);
        }


        public static void SetFechaCaja(int /*0*/pEmpresa_Id, string /*1*/pSucursal, DateTime /*2*/pFechaCaja, 
            bool /*3*/pEsSucuCentral, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSucursal, /*2*/pFechaCaja, /*3*/pEsSucuCentral };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genSucursalesSetFechaCaja", parametros);
        }

        public static genSucursalesListaDS ListaDatos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSucursalesListaDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genSucursalesListaDS dsTipado = new genSucursalesListaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Sucursales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
