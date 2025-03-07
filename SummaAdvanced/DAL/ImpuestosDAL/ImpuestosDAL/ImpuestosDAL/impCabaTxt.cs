using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{
    public class impCabaTxt
    {
        public static long ImportarGral(Int16 pAnio, Int16 pMes, string pArchivo, string pAuxiliar)
        {
            object[] parametros = { pAnio, pMes, pArchivo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (long)oiDAAB.guardar("impRentasCapGralTxtImpor", parametros);
        }

        public static long ImportarMagSup(Int16 pAnio, Int16 pMes, string pArchivo, string pAuxiliar)
        {
            object[] parametros = { pAnio, pMes, pArchivo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (long)oiDAAB.guardar("impRentasCapMagSupTxtImpor", parametros);
        }

        public static long ImportarExentos(Int16 pAnio, Int16 pTrimestre, string pArchivo, string pAuxiliar)
        {
            object[] parametros = { pAnio, pTrimestre, pArchivo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (long)oiDAAB.guardar("impRentasCapExentosTxtImpor", parametros);
        }

        public static long ImportarRiesgo(Int16 pAnio, Int16 pTrimestre, string pArchivo, string pAuxiliar)
        {
            object[] parametros = { pAnio, pTrimestre, pArchivo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (long)oiDAAB.guardar("impRentasCapRiesgoTxtImport", parametros);
        }

        public static impCABATxtDS Datos(short /*0*/pAnio, short /*1*/pMes, short /*2*/pTrimestre, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAnio, /*1*/pMes, /*2*/pTrimestre };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impCABATxtDatos", parametros);

            string[] camposTabla0 = { "Mes", "Anio", "Trimestre", "CantGral", "CantMagSup", "CantExentos", "CantRiesgo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "VigGralDesde", "VigGralHasta", "VigMagSupDesde", "VigMagSupHasta", "VigExentosDesde",
                "VigExentosHasta", "VigRiesgoDesde", "VigRiesgoHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impCABATxtDS dsTipado = new impCABATxtDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Vigencias.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
