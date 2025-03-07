using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class AfiCentros
    {

        public static AfiCentrosDS Datos(int /*0*/pActivoFijo_Id, string /*1*/pCentro1_Id, string /*2*/pCentro2_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, new Generalidades.NullableString(/*1*/pCentro1_Id), new Generalidades.NullableString(/*2*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiCentrosDatos", parametros);

            string[] camposTabla0 = { "DescripcionActivoFijo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AfiCentrosDS dsTipado = new AfiCentrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pActivoFijo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("AfiCentrosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pActivoFijo_Id, string /*1*/pCentro1_Id, string /*2*/pCentro2_Id, decimal /*3*/pPorcentaje, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pCentro1_Id, /*2*/pCentro2_Id, /*3*/pPorcentaje };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AfiCentrosGuardar", parametros);
        }



    }
}
