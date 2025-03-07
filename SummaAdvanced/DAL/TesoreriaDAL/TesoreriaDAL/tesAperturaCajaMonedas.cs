using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesAperturaCajaMonedas
    {
        public static tesAperturaCajaMonedasDS Datos(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/pSucursal, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha, /*2*/pSucursal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesAperturaCajaMonedasDatos", parametros);

            string[] camposTabla0 = { "FechaNueva", "EsCentral" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "CambioCompra", "CambioVenta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesAperturaCajaMonedasDS dsTipado = new tesAperturaCajaMonedasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Monedas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
