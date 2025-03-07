using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqProp
    {
        public static tesCheqPropDS Datos(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, int /*3*/pnumCheque, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, /*3*/pnumCheque };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqPropDatos", parametros);

            string[] camposTabla0 = { "FechaDebito", "Cuit", "CuentaDestino", "Banco_Id", "DescripcionBancos", "BancoDestinoExt" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCheqPropDS dsTipado = new tesCheqPropDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, int /*3*/pnumCheque, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, new Generalidades.NullableInt(/*3*/pnumCheque) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCheqPropEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, int /*3*/pnumCheque, int /*4*/pnumCheque_Nuevo, DateTime /*5*/pFechaVencimiento, DateTime /*6*/pFechaDebito, string /*7*/paLaOrden, string /*8*/pEstado_Id, short /*9*/pSecuenciaActual, string /*10*/pCuit, string /*11*/pCuentaDestino, string /*12*/pBancoDestino, string /*13*/pBancoDestinoExt, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, /*3*/pnumCheque, /*4*/pnumCheque_Nuevo, /*5*/pFechaVencimiento, new Generalidades.NullableDate(/*6*/pFechaDebito), /*7*/paLaOrden, /*8*/pEstado_Id, /*9*/pSecuenciaActual, new Generalidades.NullableString(/*10*/pCuit), new Generalidades.NullableString(/*11*/pCuentaDestino), new Generalidades.NullableString(/*12*/pBancoDestino), new Generalidades.NullableString(/*13*/pBancoDestinoExt) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("tesCheqPropGuardar", parametros);
        }



    }
}
