using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genEntidadesBasicasValor
    {

        public static genEntidadesBasicasValorDS Datos(int /*0*/pEntidad_Id, string /*1*/pDominio_Id, string /*2*/pClave, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEntidad_Id, /*1*/pDominio_Id, /*2*/pClave };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genEntidadesBasicasValorDatos", parametros);

            genEntidadesBasicasValorDS dsTipado = new genEntidadesBasicasValorDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pEntidad_Id, string /*1*/pDominio_Id, string /*2*/pClave, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEntidad_Id, /*1*/pDominio_Id, new Generalidades.NullableString(/*2*/pClave) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genEntidadesBasicasValorEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEntidad_Id, string /*1*/pDominio_Id, string /*2*/pClave, string /*3*/pDescripcion, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEntidad_Id, /*1*/pDominio_Id, /*2*/pClave, /*3*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genEntidadesBasicasValorGuardar", parametros);
        }


    }
}
