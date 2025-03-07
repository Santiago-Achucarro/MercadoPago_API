using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venNivelesAutoUsu
    {
        public static venNivelesAutoUsuDS Datos(string /*0*/pNivelAuto_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pNivelAuto_Id), new Generalidades.NullableString(/*1*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venNivelesAutoUsuDatos", parametros);

            venNivelesAutoUsuDS dsTipado = new venNivelesAutoUsuDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pNivelAuto_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pNivelAuto_Id), new Generalidades.NullableString(/*1*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venNivelesAutoUsuEliminar", parametros);
        }

        public static void Guardar(string /*0*/pNivelAuto_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pNivelAuto_Id, /*1*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venNivelesAutoUsuGuardar", parametros);
        }



    }
}
