using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comProveedoresSaldoInicial
    {

        public static comProveedoresSaldoIniDS Datos(string /*0*/ProveedDesde, string /*1*/ProveedHasta, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ProveedDesde, /*1*/ProveedHasta, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresSaldoIniDatos", parametros);

            string[] camposTabla0 = { "ProveedDesde", "ProveedHasta", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "TipoMov", "SegmentoStr", "ClaveFiscal", "TipoCompFE", "Aplicado" };

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comProveedoresSaldoIniDS dsTipado = new comProveedoresSaldoIniDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Impuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
