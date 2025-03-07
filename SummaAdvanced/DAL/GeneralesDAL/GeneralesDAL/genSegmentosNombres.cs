using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genSegmentosNombres
    {

        public static genSegmentosNombresDS Datos(int /*0*/pSegmento_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSegmentosNombresDatos", parametros);

            genSegmentosNombresDS dsTipado = new genSegmentosNombresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pSegmento_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genSegmentosNombresEliminar", parametros);
        }


        public static void Guardar(int /*0*/pSegmento_id, string /*1*/pNombre1N, string /*2*/pNombre2N, string /*3*/pNombre3N, string /*4*/pNombre4N, string /*5*/pNombre1C, string /*6*/pNombre2C, string /*7*/pNombre3C, string /*8*/pNombre4C, int /*9*/pUsuario_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_id, /*1*/pNombre1N, /*2*/pNombre2N, /*3*/pNombre3N, /*4*/pNombre4N, /*5*/pNombre1C, /*6*/pNombre2C, /*7*/pNombre3C, /*8*/pNombre4C, /*9*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genSegmentosNombresGuardar", parametros);
        }


    }
}
