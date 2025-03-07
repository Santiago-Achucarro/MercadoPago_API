using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comEsquemaAutoUsu
    {
        public static comNivelesAutoUsuDS Datos(string /*0*/pNivel_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pNivel_Id), new Generalidades.NullableString(/*1*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comNivelesAutoUsuDatos", parametros);

            comNivelesAutoUsuDS dsTipado = new comNivelesAutoUsuDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pNivel_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pNivel_Id), new Generalidades.NullableString(/*1*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comNivelesAutoUsuEliminar", parametros);
        }

        public static void Guardar(string /*0*/pNivel_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pNivel_Id, /*1*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comNivelesAutoUsuGuardar", parametros);
        }


    }
}
