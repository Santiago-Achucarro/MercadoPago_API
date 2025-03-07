using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;

namespace ContabilidadDAL
{
    public class conAnexoGrupoTipos
    {
        public static void Eliminar(string /*0*/pGrupoAne_Id, string /*1*/pTipo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoAne_Id, new Generalidades.NullableString(/*1*/pTipo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAnexoGrupoTiposEliminar", parametros);
        }

        public static void Guardar(string /*0*/pGruposAne_Id, string /*1*/pTipo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGruposAne_Id, /*1*/pTipo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAnexoGrupoTiposInsertar", parametros);
        }


    }
}
