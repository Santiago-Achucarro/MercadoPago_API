using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMenus
    {
        public static genMenusDS Datos(int /*0*/Usuario_id, string Dominio_Id, int Empresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_id, Dominio_Id, Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMenusDatos", parametros);

            string[] camposTabla0 = { "Opcion", "Formulario_id", "FrmEspecial", "Reporte_Id", "Pais" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genMenusDS dsTipado = new genMenusDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
