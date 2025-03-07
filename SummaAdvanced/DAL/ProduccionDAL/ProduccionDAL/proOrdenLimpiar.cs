using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProduccionCommon;
using interfaceDAAB;
using System.Data;

namespace ProduccionDAL
{
    public class proOrdenLimpiar
    {
        public static proOrdenesLimpiarDS Datos(DateTime /*0*/FechaHasta, string /*1*/CtroProdDesde, string /*2*/CtroProdHasta, int /*3*/Empresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaHasta, /*1*/CtroProdDesde, /*2*/CtroProdHasta, /*3*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenesLimpiar", parametros);

            string[] camposTabla0 = { "FechaHasta", "CtroProdDesde", "CtroProdHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Orden", "FechaEmision", "FechaNecesidad", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proOrdenesLimpiarDS dsTipado = new proOrdenesLimpiarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Ordenes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
