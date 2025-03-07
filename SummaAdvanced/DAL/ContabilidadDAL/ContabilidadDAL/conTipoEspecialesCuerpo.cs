using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using System.Data;

namespace ContabilidadDAL
{
    public class conTipoEspecialesCuerpo
    {
        public static void Guardar(string /*0*/pTipoEspe_Id, string /*1*/pTipo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id, /*1*/pTipo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conTipoEspecialesCuerpoGuardar", parametros);
        }

        public static void Eliminar(string /*0*/pTipoEspe_Id, string /*1*/pTipo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id, new Generalidades.NullableString(/*1*/pTipo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conTipoEspecialesCuerpoEliminar", parametros);
        }

        public static conTipoEspecialesCuerpoDS Datos(string /*0*/pTipoEspe_Id, string /*1*/pTipo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoEspe_Id, new Generalidades.NullableString(/*1*/pTipo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conTipoEspecialesCuerpoDatos", parametros);

            conTipoEspecialesCuerpoDS dsTipado = new conTipoEspecialesCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
