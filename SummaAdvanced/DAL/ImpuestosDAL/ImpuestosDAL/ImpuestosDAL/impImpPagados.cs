using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impImpPagados
    {
        public static impImpuestosPagadosDS Datos(int /*0*/Empresa, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impImpuestosPagadosDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "BaseImponible", "Monto", "TotalPago", "tesSegmento", "comSegmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impImpuestosPagadosDS dsTipado = new impImpuestosPagadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static impImpuestosPagadosAsiDS DatosAsi(int /*0*/Empresa, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impImpuestosPagadosAsiDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impImpuestosPagadosAsiDS dsTipado = new impImpuestosPagadosAsiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
