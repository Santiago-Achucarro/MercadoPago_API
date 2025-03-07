using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;
namespace SueldosDAL
{
    public class sueTablaVacReng
    {

        public static sueTablaVacRengDS Datos(string /*0*/pTablaVac_Id, int /*1*/pAntiguedad, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTablaVac_Id, new Generalidades.NullableInt(/*1*/pAntiguedad) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTablaVacRengDatos", parametros);

            sueTablaVacRengDS dsTipado = new sueTablaVacRengDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTablaVac_Id, int /*1*/pAntiguedad, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTablaVac_Id, new Generalidades.NullableInt(/*1*/pAntiguedad) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTablaVacRengEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTablaVac_Id, int /*1*/pAntiguedad, int /*2*/pDias, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTablaVac_Id, /*1*/pAntiguedad, /*2*/pDias };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueTablaVacRengGuardar", parametros);
        }




    }
}
