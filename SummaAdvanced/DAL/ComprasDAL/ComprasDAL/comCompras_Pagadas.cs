using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comCompras_Pagadas
    {
        public static PagadasDSDS Datos(DateTime /*0*/FECHADESDE, DateTime /*1*/FECHAHASTA, int /*2*/Empresa_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FECHADESDE, /*1*/FECHAHASTA, /*2*/Empresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comCompras_Pagadas", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Pais", "Origen_id", "BASE16", "IVA16", "BASE0", "BaseExe", "RISR", "RIVA", "IVAIM", "OTROS" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            PagadasDSDS dsTipado = new PagadasDSDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
