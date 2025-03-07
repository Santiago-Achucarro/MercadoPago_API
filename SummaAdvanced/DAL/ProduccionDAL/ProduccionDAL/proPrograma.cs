using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proPrograma
    {
        public static proProgramaDS Datos(int /*0*/pEmpresa, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/pPendHist, string /*4*/pProveedor_Id, string /*5*/pTrabajo3_Id, bool /*6*/pSoloEnProd, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pPendHist, /*4*/pProveedor_Id, /*5*/pTrabajo3_Id, /*6*/pSoloEnProd };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramaDatos", parametros);

            string[] camposTabla0 = { "Proveedor_Id", "DescripcionProveedor", "FechaDesde", "FechaHasta", "PendHist", "SoloEnProd" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "Proveed_Id", "DescripcionProveed", "FechaEmision", "FechaNecesidad", "FechaProduccion", "FechaFin" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proProgramaDS dsTipado = new proProgramaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Trabajos3.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Guardar(int /*0*/pOrden, int /*1*/pRenlon, string /*2*/pProveed_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrden, /*1*/pRenlon, /*2*/pProveed_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramaGuardar", parametros);
        }

       


    }
}
