using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqPropAnul
    {

        public static tesCheqPropAnulDS Datos(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, int /*3*/pnumCheque, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, /*3*/pnumCheque };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqPropAnulDatos", parametros);

            tesCheqPropAnulDS dsTipado = new tesCheqPropAnulDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/ptesCheqProp, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqProp };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCheqPropAnulEliminar", parametros);
        }


        public static void Guardar(int /*0*/ptesCheqProp, DateTime /*1*/pFecha_Anul, string /*2*/pObservaciones, decimal /*3*/pImporte, DateTime /*4*/pFechaOriginal, int /*5*/pUsuario_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCheqProp, /*1*/pFecha_Anul, /*2*/pObservaciones, /*3*/pImporte, /*4*/pFechaOriginal, /*5*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCheqPropAnulGuardar", parametros);
        }



    }
}
