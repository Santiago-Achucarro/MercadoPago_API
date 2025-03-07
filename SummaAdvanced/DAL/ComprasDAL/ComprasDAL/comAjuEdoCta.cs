using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comAjuEdoCta
    {
        public static comAjuEdoCtaDS Datos(string /*0*/pProveeedDesde, string /*1*/pProveeedHasta, decimal /*2*/pMonto, int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveeedDesde, /*1*/pProveeedHasta, /*2*/pMonto, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comAjuEdoCtaDatos", parametros);

            string[] camposTabla0 = { "ProveeedDesde", "ProveeedHasta", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "Importe", "Saldo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comAjuEdoCtaDS dsTipado = new comAjuEdoCtaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
