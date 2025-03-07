using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovTipos
    {
        public static comMovTiposDS Datos(string /*0*/pTipoMov, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoMov };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovTiposDatos", parametros);

            comMovTiposDS dsTipado = new comMovTiposDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
