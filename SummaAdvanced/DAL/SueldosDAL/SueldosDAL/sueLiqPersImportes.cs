using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueLiqPersImportes
    {
        public static sueLiqPersImportesDS Datos(int /*0*/pLegajo, DateTime /*1*/pFecha, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqPersImportesDatos", parametros);

            string[] camposTabla1 = { "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqPersImportesDS dsTipado = new sueLiqPersImportesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pLegajo, int /*1*/pImporte_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pImporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiqPersImportesEliminar", parametros);
        }

        public static void Guardar(int /*0*/pLegajo, int /*1*/pImporte_Id, DateTime /*2*/pFecha_Hasta, DateTime /*3*/pFecha_Desde, decimal /*4*/pValor, int /*5*/pUsuario_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pImporte_Id, /*2*/pFecha_Hasta, /*3*/pFecha_Desde, /*4*/pValor, new Generalidades.NullableInt(/*5*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiqPersImportesGuardar", parametros);
        }

        public static sueLiqPersImportesHistoricoDS DatosHistorico(int /*0*/pLegajo, int /*1*/pImporte_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pImporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqPersImportesHistorico", parametros);

            string[] camposTabla1 = { "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiqPersImportesHistoricoDS dsTipado = new sueLiqPersImportesHistoricoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
