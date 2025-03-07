using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comTraePendientes
    {
        public static comTraePendientesDS Datos(string /*0*/Proveed_Id, string /*1*/Moneda_Id, int /*2*/Signo, int Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Proveed_Id, /*1*/Moneda_Id, /*2*/Signo, Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comTraePendientes", parametros);

            string[] camposTabla0 = { "comMovProv", "Moneda_Id", "Proveee_id", "Signo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "ImporteAplicado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comTraePendientesDS dsTipado = new comTraePendientesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pendientes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
