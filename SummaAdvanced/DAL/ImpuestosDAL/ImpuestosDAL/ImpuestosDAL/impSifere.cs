using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{

    public static class impSifere
    {
        public static impSifereDS Datos(int /*0*/pEmpresa_id, int /*1*/pMes, int /*2*/pAnio, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pMes, /*2*/pAnio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impSifere", parametros);

            string[] camposTabla0 = { "Empresa_Id", "Mes", "Anio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "TipoMov", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impSifereDS dsTipado = new impSifereDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Percepciones.TableName, dsTipado.Retenciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
