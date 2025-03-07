using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePeriodicidad
    {
        public static suePeriodicidadDS Datos(string /*0*/pPeriodo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPeriodo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePeriodicidadDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CodFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePeriodicidadDS dsTipado = new suePeriodicidadDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pPeriodo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pPeriodo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePeriodicidadEliminar", parametros);
        }

        public static void Guardar(string /*0*/pPeriodo_Id, string /*1*/pPeriodo_Id_Nueva, string /*2*/pDescripcion, decimal /*3*/pDias, string /*4*/pCodFiscal, int /*5*/pEmpresa_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPeriodo_Id, /*1*/pPeriodo_Id_Nueva, /*2*/pDescripcion, /*3*/pDias, new Generalidades.NullableString(/*4*/pCodFiscal), new Generalidades.NullableInt(pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePeriodicidadGuardar", parametros);
        }

    }
}
