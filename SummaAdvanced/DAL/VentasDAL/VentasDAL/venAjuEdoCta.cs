using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using System.Data;
using interfaceDAAB;

namespace VentasDAL
{
    public class venAjuEdoCta
    {
        public static venAjuEdoCtaDS Datos(string /*0*/pClienteDesde, string /*1*/pClienteHasta, decimal /*2*/pMonto, int /*3*/pEmpresa_Id, string /*4*/pSucursalDesde, string /*5*/pSucursalHasta, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClienteDesde, /*1*/pClienteHasta, /*2*/pMonto, /*3*/pEmpresa_Id, /*4*/pSucursalDesde, /*5*/pSucursalHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venAjuEdoCtaDatos", parametros);

            string[] camposTabla0 = { "ClieDesde", "ClieHasta", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "Importe", "Saldo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venAjuEdoCtaDS dsTipado = new venAjuEdoCtaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
