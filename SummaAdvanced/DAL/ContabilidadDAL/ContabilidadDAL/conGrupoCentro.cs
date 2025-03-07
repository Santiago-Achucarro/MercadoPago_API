using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conGrupoCentro
    {
        public static conGrupoCentroDS Datos(int /*0*/pGrupo_Id, string /*1*/pCentro1_Id, string /*2*/pCentro2_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, new Generalidades.NullableString(/*1*/pCentro1_Id), new Generalidades.NullableString(/*2*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conGrupoCentroDatos", parametros);

            conGrupoCentroDS dsTipado = new conGrupoCentroDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pGrupo_Id, string /*1*/pCentro1_Id, string /*2*/pCentro2_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, new Generalidades.NullableString(/*1*/pCentro1_Id), new Generalidades.NullableString(/*2*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conGrupoCentroEliminar", parametros);
        }

        public static void Guardar(string /*0*/pGrupo_Id, string /*1*/pCentro1_id, string /*2*/pCentro2_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, /*1*/pCentro1_id, /*2*/pCentro2_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conGrupoCentroGuardar", parametros);
        }




    }
}
