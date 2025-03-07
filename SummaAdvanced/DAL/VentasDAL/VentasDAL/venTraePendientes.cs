using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;


namespace VentasDAL
{
    public class venTraePendientes
    {
        public static venTraePendientesDS Datos(int Empresa_Id, string /*0*/Cliente_Id, string /*1*/Moneda_Id, int /*2*/Signo, 
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {Empresa_Id, /*0*/Cliente_Id, /*1*/Moneda_Id, /*2*/Signo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venTraePendientes", parametros);

            string[] camposTabla0 = { "venMovimientos", "Moneda_Id", "Cliente_id", "Signo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "ImporteAplicado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venTraePendientesDS dsTipado = new venTraePendientesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pendientes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
