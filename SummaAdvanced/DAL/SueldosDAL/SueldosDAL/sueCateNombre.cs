using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueCateNombre
    {
        public static sueCateNombreDS Datos(int /*0*/pCateNombre_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueCateNombreDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueCateNombreDS dsTipado = new sueCateNombreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pCateNombre_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueCateNombreEliminar", parametros);
        }

        public static void Guardar(int /*0*/pCateNombre_Id, string /*1*/pDescripcion, bool /*2*/pPorEmpresa, int /*3*/pUsuario_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre_Id, /*1*/pDescripcion, /*2*/pPorEmpresa, new Generalidades.NullableInt(/*3*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueCateNombreGuardar", parametros);
        }

        public static bool Editable(int /*0*/pCateNombre, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCateNombre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((bool)oiDAAB.guardar("sueCateNombreEditable", parametros));
        }


    }
}
