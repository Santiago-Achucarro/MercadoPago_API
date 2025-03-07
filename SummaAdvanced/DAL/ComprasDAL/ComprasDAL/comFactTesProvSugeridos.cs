using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    public class comFactTesProvSugeridos
    {
        public static comFactTesValoresSugeridosDS Datos(string /*0*/Proveed_id, DateTime /*1*/Fecha, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Proveed_id, /*1*/Fecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFactTesValoresSugeridos", parametros);

            string[] camposTabla0 = { "Proveed_id", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "Centro2_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comFactTesValoresSugeridosDS dsTipado = new comFactTesValoresSugeridosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuentas.TableName, dsTipado.Impuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
