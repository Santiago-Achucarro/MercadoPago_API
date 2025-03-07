using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueGanTitulo
    {
        public static sueGanTituloDS Datos(int /*0*/pTabGan_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabGan_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueGanTituloDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "Codigo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Ver" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueGanTituloDS dsTipado = new sueGanTituloDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(int /*0*/pTabGan_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pTabGan_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueGanTituloEliminar", parametros);
        }

        public static void Guardar(int /*0*/pTabGan_Id, string /*1*/pDescripcion, int /*2*/pUsuario_Id, DateTime /*3*/pFechaRegistro, string /*4*/pCodigo, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabGan_Id, /*1*/pDescripcion, new Generalidades.NullableInt(/*2*/pUsuario_Id), /*3*/pFechaRegistro, new Generalidades.NullableString(/*4*/pCodigo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueGanTituloGuardar", parametros);
        }



    }
}
