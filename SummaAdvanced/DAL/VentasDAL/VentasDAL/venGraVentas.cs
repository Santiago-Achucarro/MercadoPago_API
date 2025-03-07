using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;
namespace VentasDAL
{
    public class venGraVentas
    {
        public static venGraVentasDS Datos(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venGraVentas", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Periodo", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venGraVentasDS dsTipado = new venGraVentasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Grafico.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
