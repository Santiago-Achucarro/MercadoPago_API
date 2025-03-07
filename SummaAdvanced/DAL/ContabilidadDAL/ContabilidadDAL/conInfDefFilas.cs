using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;


namespace ContabilidadDAL
{
    public class conInfDefFilas
    {
        public static conInfDefFilasDS Datos(string /*0*/pInforme_Id, int /*1*/pFila, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, new Generalidades.NullableInt(/*1*/pFila) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefFilasDatos", parametros);

            conInfDefFilasDS dsTipado = new conInfDefFilasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pInforme_Id, int /*1*/pFila, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, new Generalidades.NullableInt(/*1*/pFila) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conInfDefFilasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pInforme_Id, int /*1*/pFila, int /*2*/pNivel, string /*3*/pTitulo, string /*4*/pTipo, string /*5*/pFuente, bool /*6*/pInvierteSigno, string /*7*/pCentro1Desde, string /*8*/pCentro1Hasta, string /*9*/pCentro2Desde, string /*10*/pCentro2Hasta, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/pFila, /*2*/pNivel, /*3*/pTitulo, /*4*/pTipo, /*5*/pFuente, /*6*/pInvierteSigno, /*7*/pCentro1Desde, /*8*/pCentro1Hasta, /*9*/pCentro2Desde, /*10*/pCentro2Hasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conInfDefFilasInsertar", parametros);
        }






    }
}
