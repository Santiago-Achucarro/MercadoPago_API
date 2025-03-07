using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrdenPasarProduccion
    {

        public static proPasarAProduccionDS Datos(string /*0*/CentroProdDesde, string /*1*/CentroProdHasta, DateTime /*2*/FechaDesde, DateTime /*3*/FechaHasta, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/CentroProdDesde, /*1*/CentroProdHasta, /*2*/FechaDesde, /*3*/FechaHasta, /*4*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proPasarAProduccionDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta", "FechaProduccion", "CentroProdDesde", "CentroProdHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "Segmento_Str" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proPasarAProduccionDS dsTipado = new proPasarAProduccionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Ordenes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Guardar(int /*0*/proOrden, DateTime /*1*/FechaProduccion, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/proOrden, /*1*/FechaProduccion, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proPasarAProduccionGuardar", parametros);
        }




    }
}
