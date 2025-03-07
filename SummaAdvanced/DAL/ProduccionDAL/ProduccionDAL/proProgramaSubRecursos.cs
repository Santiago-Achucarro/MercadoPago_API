using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proProgramaSubRecursos
    {
        public static proProgramaSubRecursosDS Datos(int /*0*/pEmpresa_Id, string /*1*/pRecurso_Id, DateTime /*2*/pFechaDesde, DateTime /*3*/pFechaHasta, string /*4*/pPendHist, bool /*5*/pSoloEnProd, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, new Generalidades.NullableString(/*1*/pRecurso_Id), /*2*/pFechaDesde, /*3*/pFechaHasta, /*4*/pPendHist, /*5*/pSoloEnProd };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramaSubRecursosDatos", parametros);

            string[] camposTabla0 = { "Recurso_Id", "FechaDesde", "FechaHasta", "PendHist", "SoloEnProd" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "Medida_Id", "DescripcionMedida", "FechaEmision", "FechaNecesidad", "FechaProduccion", "FechaFin", "CantidadSubRecurso" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proProgramaSubRecursosDS dsTipado = new proProgramaSubRecursosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Ordenes.TableName, dsTipado.SubRecursos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Guardar(int /*0*/pOrden, string /*1*/pSubRecurso_Id, int /*2*/pRenglon, decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrden, /*1*/pSubRecurso_Id, /*2*/pRenglon, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramaSubRecursosGuardar", parametros);
        }
        public static void Eliminar(int /*0*/proOrden, string /*1*/pRecurso_id, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/proOrden, /*1*/pRecurso_id, /*2*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proProgramaSubRecursosEliminar", parametros);
        }


    }
}
