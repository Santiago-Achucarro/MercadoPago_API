using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ComprasCommon;
using System.Data;

namespace ComprasDAL
{
    public class comMovProvXmlcs
    {
        public static comMovProvXmlDS Datos(string /*0*/pProveedorDesde, string /*1*/pProveedorHasta, DateTime /*2*/pFechaDesde, DateTime /*3*/pFechaHasta, string /*4*/pPendiende, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveedorDesde, /*1*/pProveedorHasta, /*2*/pFechaDesde, /*3*/pFechaHasta, /*4*/pPendiende };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvXmlDatos", parametros);

            string[] camposTabla0 = { "ProveedorDesde", "ProveedorHasta", "FechaDesde", "FechaHasta", "Pendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Cuit", "Marca", "UUID", "Proveed_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comMovProvXmlDS dsTipado = new comMovProvXmlDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(long /*0*/pcomMovProv, string /*1*/pXml, string /*2*/pUUID, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pXml, /*2*/pUUID };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvXmlGuardar", parametros);
        }


    }
}
