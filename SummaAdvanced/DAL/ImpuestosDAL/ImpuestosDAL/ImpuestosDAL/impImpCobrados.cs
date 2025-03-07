using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ImpuestosCommon;
using System.Data;

namespace ImpuestosDAL
{
    public class impImpCobrados
    {

        public static impImpuestosCobradosDS Datos(int /*0*/Empresa, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impImpuestosCobradosDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "BaseImponible", "Monto", "TotalCobro", "tesSegmento", "venSegmento","venMovimientos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impImpuestosCobradosDS dsTipado = new impImpuestosCobradosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static impImpuestosCobradosAsiDS DatosAsi(int /*0*/Empresa, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impImpuestosCobradosAsiDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impImpuestosCobradosAsiDS dsTipado = new impImpuestosCobradosAsiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
