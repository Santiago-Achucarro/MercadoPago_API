using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
namespace VentasDAL
{
    public class venCompCartaPorte
    {
		public static venCompCartaPorteDS Datos(long /*0*/pvenmovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCompCartaPorteDatos", parametros);

			string[] camposTabla0 = { "UnidadPeso", "Camion_Id", "DescripcionCamiones", "Remolque1", "DescripcionRemolque1", "Remolque2", "DescripcionRemolque2", "Operador_Id", "NombreOperador" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCompCartaPorteDS dsTipado = new venCompCartaPorteDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



		public static void Eliminar(long /*0*/pvenmovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCompCartaPorteEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenmovimientos, string /*1*/pTranspInternac, string /*2*/pEntradaSalidaMerc, string /*3*/pViaEntradaSalida, decimal /*4*/pTotalDistRec, decimal /*5*/pPesoBrutoTotal, string /*6*/pUnidadPeso, decimal /*7*/pPesoNetoTotal, decimal /*8*/pCargoPorTasacion, string /*9*/pCamion_Id, string /*10*/pRemolque1, string /*11*/pRemolque2, string /*12*/pOperador_Id, string /*13*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, /*1*/pTranspInternac, /*2*/pEntradaSalidaMerc, /*3*/pViaEntradaSalida, /*4*/pTotalDistRec, /*5*/pPesoBrutoTotal, new Generalidades.NullableString(/*6*/pUnidadPeso), /*7*/pPesoNetoTotal, /*8*/pCargoPorTasacion, new Generalidades.NullableString(/*9*/pCamion_Id), new Generalidades.NullableString(/*10*/pRemolque1), new Generalidades.NullableString(/*11*/pRemolque2), new Generalidades.NullableString(/*12*/pOperador_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCompCartaPorteGuardar", parametros);
		}

	}
}
