using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePersDomicilio
    {
        public static suePersDomicilioDS Datos(long /*0*/pLegajo, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePersDomicilioDatos", parametros);

            string[] camposTabla0 = { "Provincia_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePersDomicilioDS dsTipado = new suePersDomicilioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableDate(/*1*/pFechaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePersDomicilioEliminar", parametros);
        }

        public static void Guardar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/pDireccion1, string /*4*/pDireccion2, string /*5*/pNroExterior, string /*6*/pNroInterior, string /*7*/pLocalidad, string /*8*/pCodigoPostal, string /*9*/pEntreCalle1, string /*10*/pEntreCalle2, string /*11*/pProvincia_Id, int /*12*/pUsuario_Id, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pDireccion1, /*4*/pDireccion2, /*5*/pNroExterior, /*6*/pNroInterior, /*7*/pLocalidad, /*8*/pCodigoPostal, /*9*/pEntreCalle1, /*10*/pEntreCalle2, new Generalidades.NullableString(/*11*/pProvincia_Id), /*12*/pUsuario_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePersDomicilioGuardar", parametros);
        }


    }
}
