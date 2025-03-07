using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SueldosCommon;

namespace SueldosDAL
{
    public class  suePlantilla
    {
        public static suePlantillaDS Datos(string /*0*/pCentro1_Id, string /*1*/pPuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCentro1_Id, new Generalidades.NullableString(/*1*/pPuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePlantillaDatos", parametros);

            suePlantillaDS dsTipado = new suePlantillaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Puestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(string /*0*/pCentro1_Id, string /*1*/pPuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCentro1_Id, new Generalidades.NullableString(/*1*/pPuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePlantillaEliminar", parametros);
        }



        public static void Guardar(string /*0*/pCentro1_Id, string /*1*/pPuesto_Id, decimal /*2*/pCantidad, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCentro1_Id, /*1*/pPuesto_Id, /*2*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("suePlantillaGuardar", parametros);
        }




    }
}
