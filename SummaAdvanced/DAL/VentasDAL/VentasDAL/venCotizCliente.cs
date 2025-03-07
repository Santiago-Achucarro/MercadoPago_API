using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCotizCliente
    {
        public static venCotizClienteDS Datos(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizClienteDatos", parametros);

            string[] camposTabla0 = { "RazonSocial", "Direccion1", "Direccion2", "NroExterior", "NroInterior", "Localidad", "CodigoPostal", "Provincia_Id", "Pais_Id", "DescripcionPaises", "Telefono", "CUIT", "Email" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venCotizClienteDS dsTipado = new venCotizClienteDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pvenCotizaciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCotizaciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCotizClienteEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenCotizaciones, string /*1*/pRazonSocial, string /*2*/pDireccion1, string /*3*/pDireccion2, string /*4*/pNroExterior, string /*5*/pNroInterior, string /*6*/pLocalidad, string /*7*/pCodigoPostal, string /*8*/pProvincia_Id, short /*9*/pPais_Id, string /*10*/pTelefono, string /*11*/pCUIT, string /*12*/pEmail, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { /*0*/pvenCotizaciones, /*1*/pRazonSocial, /*2*/pDireccion1, 
                /*3*/pDireccion2, /*4*/pNroExterior, /*5*/pNroInterior, /*6*/pLocalidad, /*7*/pCodigoPostal, 
                new Generalidades.NullableString(/*8*/pProvincia_Id), new Generalidades.NullableShort(/*9*/pPais_Id), /*10*/pTelefono, 
                /*11*/pCUIT, /*12*/pEmail };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizClienteGuardar", parametros);
        }

    }
}
