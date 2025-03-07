using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genDominios
    {
        public static genDominiosDS Datos(string /*0*/pDominio_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDominio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genDominiosDatos", parametros);

            genDominiosDS dsTipado = new genDominiosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pDominio_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDominio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genDominiosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pDominio_Id, string /*1*/pDominio_Id_Nuevo, string /*2*/pDescripcion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pDominio_Id, /*1*/pDominio_Id_Nuevo, /*2*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genDominiosGuardar", parametros);
        }




    }
}
