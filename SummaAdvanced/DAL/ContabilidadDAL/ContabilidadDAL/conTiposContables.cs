using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using ContabilidadDAL;
using interfaceDAAB;
using System.Data;

namespace ContabilidadDAL
{
    public class conTiposContables
    {
        public static conTiposContablesDS Datos(string /*0*/pTipo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conTiposContablesDatos", parametros);

            conTiposContablesDS dsTipado = new conTiposContablesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTipo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTipo_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conTiposContablesEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTipo_Id, string /*1*/pDescripcion, string /*2*/pRubro_Balance,
            string /*3*/pDestino, string /*4*/pCorriente, bool /*5*/pReservado, string /*6*/pRubro_Id,
            string /*7*/pDescripcionUsu, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipo_Id, /*1*/pDescripcion, /*2*/pRubro_Balance, /*3*/pDestino,
                /*4*/pCorriente, /*5*/pReservado, /*6*/pRubro_Id, /*7*/pDescripcionUsu };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conTiposContablesGuardar", parametros);
        }
    }
}
