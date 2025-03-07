using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImpuestosCommon;
using System.Data;
using interfaceDAAB;

namespace ImpuestosDAL
{
    public class impRetCFDIArrenda
    {
        public static impRetCFDIArrendaDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIArrendaDatos", parametros);

            impRetCFDIArrendaDS dsTipado = new impRetCFDIArrendaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIArrendaEliminar", parametros);
        }


        public static void Guardar(int /*0*/pimpRetencionesCFDI, decimal /*1*/pPagProvEfecPorFiduc, decimal /*2*/pRendimFideicom, decimal /*3*/pDeduccCorresp, decimal /*4*/pMontTotRet, decimal /*5*/pMontResFiscDistFibras, decimal /*6*/pMontOtrosConceptDistr, string /*7*/pDescrMontOtrosConceptDistr, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pPagProvEfecPorFiduc, /*2*/pRendimFideicom, /*3*/pDeduccCorresp, /*4*/pMontTotRet, /*5*/pMontResFiscDistFibras, /*6*/pMontOtrosConceptDistr, /*7*/pDescrMontOtrosConceptDistr };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIArrendaGuardar", parametros);
        }




    }
}
