using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conTipoEspeciales
    {
        public static conTipoEspecialesDS Datos(string /*0*/pTipoEspe_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conTipoEspecialesDatos", parametros);

            conTipoEspecialesDS dsTipado = new conTipoEspecialesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.conTipoEspecialesCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipoEspe_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conTipoEspecialesEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTipoEspe_Id, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conTipoEspecialesGuardar", parametros);
        }

    }
}
