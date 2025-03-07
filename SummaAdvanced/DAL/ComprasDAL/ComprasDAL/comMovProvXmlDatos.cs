using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
   public class comMovProvXmlDatos
    {
        public static comMovProvXmlDS Datos(string /*0*/pProveedorDesde, string /*1*/pProveedorHasta, DateTime /*2*/pFechaDesde, DateTime /*3*/pFechaHasta, string /*4*/pPendiende, int /*5*/Empresa_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveedorDesde, /*1*/pProveedorHasta, /*2*/pFechaDesde, /*3*/pFechaHasta, /*4*/pPendiende, /*5*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvXmlDatos", parametros);

            string[] camposTabla0 = { "ProveedorDesde", "ProveedorHasta", "FechaDesde", "FechaHasta", "Pendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "UUID", "Pago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comMovProvXmlDS dsTipado = new comMovProvXmlDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Guardar(long /*0*/pcomMovProv, string /*1*/pXml, string /*2*/pUUID, bool /*3*/pRequiere, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pXml, /*2*/pUUID, /*3*/pRequiere };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvXmlGuardar", parametros);
        }



        public static comMovprovXmlBuscarDS Buscar(string /*0*/ProveedorDesde, string /*1*/ProveedorHasta, DateTime /*2*/FechaDesde, DateTime /*3*/FechaHasta, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ProveedorDesde, /*1*/ProveedorHasta, /*2*/FechaDesde, /*3*/FechaHasta, /*4*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovprovXmlBuscarDatos", parametros);

            string[] camposTabla0 = { "UUID", "Xml" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovprovXmlBuscarDS dsTipado = new comMovprovXmlBuscarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







    }
}
